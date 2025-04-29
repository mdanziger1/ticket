using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RestSharp.Authenticators;
using RestSharp.Serialization.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reactive.Subjects;
using System.Threading.Tasks;
using UTA.API.DAL.Models;
using UTA.API.DAL.Repositories;
using UTA.API.SHARED.Helpers;
using Aspose.Pdf.Operators;
using DevExpress.Pdf.ContentGeneration.Interop;
using AdminPortal.Models;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Http;
using static AdminPortal.Models.ManageengineRequestInfo;
namespace AdminPortal.Controllers
{
    [Authorize]
    public class ManageengineController : Controller
    {
        private readonly AzurePayments azurePayments;
        private readonly IConfiguration configuration;

        public ManageengineController(AzurePayments azurePayments, IConfiguration configuration)
        {
            this.azurePayments = azurePayments;
            this.configuration = configuration;
        }

        [HttpGet]
        [EnableQuery(MaxNodeCount = 200)]
        public IQueryable<view_ManageengineRequests> Get(string user = null)
        {
            if (user.HasValue())
            {
                return azurePayments.view_ManageengineRequests.Where(s => s.RequesterEmail == user);
            }

            return azurePayments.view_ManageengineRequests;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> ManageenginePost([FromBody] ManageenginePostParams data)
        {
            var tokenData = azurePayments.Tokens.First(t => t.Source == "Manageengine");
            var token = tokenData.Token1;

            if (tokenData.ExpirationTime < DateTime.Now)
            {
                token = await RefreshToken();
            }

            var client = new HttpClient();
            var url = "https://utaw.sdpondemand.manageengine.com/api/v3/requests";

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.manageengine.sdp.v3+json"));
            client.DefaultRequestHeaders.Add("Authorization", "Zoho-Oauthtoken " + token);


            var requestObject = new
            {
                request = new Dictionary<string, object>
                {
                    ["category"] = new { name = data.Category },
                    ["description"] = data.Description,
                    ["requester"] = new { email_id = data.User },
                    ["priority"] = new { name = data.Priority },
                    ["subject"] = data.Subject
                }
            };

            if (!string.IsNullOrEmpty(data.Attachments))
            {
                var attachments = JsonConvert.DeserializeObject<List<string>>(data.Attachments);
                var attachmentArray = attachments.Select(id => new Dictionary<string, object> { { "file_id", id } }).ToArray();

                requestObject.request["attachments"] = attachmentArray;
            }

            string jsonString = JsonConvert.SerializeObject(requestObject);

            var content = new FormUrlEncodedContent(new[]
              {new KeyValuePair<string, string>("input_data", jsonString) }
            );


            content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");

            try
            {
                var response = await client.PostAsync(url, content);
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync();

                var manageengineRequest = JsonConvert.DeserializeObject<ManageengineResponse>(responseBody);

                SaveNewRequest(manageengineRequest.request, data.User);

                return Ok(responseBody);
            }
            catch (HttpRequestException e)
            {
                return BadRequest(new Exception("Request error: " + e.Message));
            }
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> ManageengineUpload([FromForm] IFormFile file)
        {

            if (file == null || file.Length == 0)
            {
                return BadRequest("No file uploaded.");
            }

            var tokenData = azurePayments.Tokens.First(t => t.Source == "Manageengine");
            var token = tokenData.Token1;

            if (tokenData.ExpirationTime < DateTime.Now)
            {
                token = await RefreshToken();
            }

            using var client = new HttpClient();
            var url = "https://utaw.sdpondemand.manageengine.com/app/itdesk/api/v3/requests/uploads";

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.manageengine.v3+json"));
            client.DefaultRequestHeaders.Add("Authorization", "Zoho-Oauthtoken " + token);

            using var content = new MultipartFormDataContent();
            await using var fileStream = file.OpenReadStream();
            var fileContent = new StreamContent(fileStream);
            fileContent.Headers.ContentType = new MediaTypeHeaderValue(file.ContentType);

            content.Add(fileContent, "filename", file.FileName);

            try
            {
                var response = await client.PostAsync(url, content);
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync();

                return Ok(JsonConvert.DeserializeObject<object>(responseBody));
            }
            catch (HttpRequestException e)
            {
                return BadRequest(new { error = "Request error: " + e.Message });
            }
        }



        [HttpGet]
        public async Task<ActionResult> GetbyID(int id)
        {
            var manageengineRequest = azurePayments.ManageengineRequests.First(m => m.ID == id);

            try
            {
                await UpdateRequest(manageengineRequest.ManageengineID);
            }
            catch (Exception ex)
            {

            }

            return Ok(azurePayments.ManageengineRequests.First(m => m.ID == id));
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult> UpdateRequest(string id)
        {
            var tokenData = azurePayments.Tokens.First(t => t.Source == "Manageengine");
            var token = tokenData.Token1;
            if (tokenData.ExpirationTime < DateTime.Now)
            {
                token = await RefreshToken();
            }

            var client = new RestClient();

            var url = "https://utaw.sdpondemand.manageengine.com/api/v3/requests/" + id;

            var request = new RestRequest(url);

            request.Method = Method.GET;
            request.AddHeader("Accept", "application/vnd.manageengine.sdp.v3+json");
            request.AddHeader("Authorization", "Zoho-Oauthtoken " + token);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");

            var response = client.Execute<ManageengineRequestInfo>(request);
            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                var authParam = request.Parameters.Find(p => p.Name == "Authorization");

                request.Parameters.Remove(authParam);

                token = await RefreshToken();

                request.AddHeader("Authorization", "Zoho-Oauthtoken " + token);

                response = client.Execute<ManageengineRequestInfo>(request);
            }

            if (response.StatusCode != HttpStatusCode.NotFound && (!response.IsSuccessful || response.ErrorException != null))
            {
                throw new Exception(response.ErrorMessage);
            }


            var manageengineRequest = response.Data;


            HandleDeletedTicket(azurePayments, id, response);


            var existing = azurePayments.ManageengineRequests.FirstOrDefault(x => x.ManageengineID == manageengineRequest.request.id);

            existing.Subject = manageengineRequest.request.subject;
            existing.TechnicianEmail = manageengineRequest.request.technician?.email_id;
            existing.TechnicianName = manageengineRequest.request.technician?.name;
            existing.StatusName = manageengineRequest.request.status?.name;
            existing.CategoryName = manageengineRequest.request.category?.name;
            existing.LastUpdatedTime = manageengineRequest.request.last_updated_time.display_value;
            existing.Description = manageengineRequest.request.description;
            existing.Attachments = JsonConvert.SerializeObject(manageengineRequest.request.attachments.Select(attachment => new
            { content_url = attachment.content_url, name = attachment.name, }).ToList());
            existing.CompletedTime = manageengineRequest.request.completed_time != null ? Convert.ToDateTime(manageengineRequest.request.completed_time.display_value) : (DateTime?)null;
            existing.NotificationStatus = manageengineRequest.request?.notification_status;
            azurePayments.SaveChanges("SYSTEM");

            if (existing.NotificationStatus != null)
            {
                try
                {
                    await UpdateConversations(existing.ID, existing.DisplayID, existing.ManageengineID);
                }
                catch (Exception ex)
                {
                }

            }

            return Ok();
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> UpdateConversations(int userPortalRequestsID, string displayID, string manageengineID)
        {
            try
            {
                var tokenData = azurePayments.Tokens.First(t => t.Source == "Manageengine");
                var token = tokenData.Token1;

                if (tokenData.ExpirationTime < DateTime.Now)
                {
                    token = await RefreshToken();
                }

                var client = new RestClient();
                var url = $"https://utaw.sdpondemand.manageengine.com/api/v3/requests/{manageengineID}/conversations";

                var request = new RestRequest(url);
                request.Method = Method.GET;
                request.AddHeader("Accept", "application/vnd.manageengine.sdp.v3+json");
                request.AddHeader("Authorization", $"Zoho-oauthtoken {token}");

                var response = client.Execute<ManageengineConversationsResponse>(request);
                if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    var authParam = request.Parameters.Find(p => p.Name == "Authorization");

                    request.Parameters.Remove(authParam);

                    token = await RefreshToken();

                    request.AddHeader("Authorization", "Zoho-Oauthtoken " + token);

                    response = client.Execute<ManageengineConversationsResponse>(request);
                }

                if (!response.IsSuccessful || response.ErrorException != null)
                {
                    throw new Exception($"Error fetching conversations: {response.StatusCode} - {response.ErrorMessage ?? response.Content}");
                }

                var conversationsData = response.Data;

                foreach (var conversation in conversationsData.conversations)
                {
                    var existing = azurePayments.ManageengineConversations.FirstOrDefault(m => m.ConversationsID == conversation.id);

                    if (existing != null)
                    {
                        continue;
                    }
                    SaveNewConversation(userPortalRequestsID, displayID, manageengineID, conversation);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return Ok();
        }





        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult> ImportRequests(int pages = 10)
        {
            var tokenData = azurePayments.Tokens.First(t => t.Source == "Manageengine");
            var token = tokenData.Token1;
            if (tokenData.ExpirationTime < DateTime.Now)
            {
                token = await RefreshToken();
            }

            var client = new RestClient();

            uint page = 1;

            while (true)
            {
                try
                {
                    //client.BaseUrl = new Uri("https://utaw.sdpondemand.manageengine.com/api/v3");

                    var url = "https://utaw.sdpondemand.manageengine.com/api/v3/requests?input_data=%7B%22list_info%22%3A%7B%22row_count%22%3A%22100%22%2C%22start_index%22%3A%221%22%2C%22sort_field%22%3A%22created_time%22%2C%22page%22%3A%22" + page + "%22%2C%22sort_order%22%3A%22desc%22%7D%7D";

                    var request = new RestRequest(url);

                    request.Method = Method.GET;
                    request.AddHeader("Accept", "application/vnd.manageengine.sdp.v3+json");
                    request.AddHeader("Authorization", "Zoho-Oauthtoken " + token);
                    request.AddHeader("Content-Type", "application/x-www-form-urlencoded");

                    var response = client.Execute<ManageengineRequests>(request);

                    if (response.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        var authParam = request.Parameters.Find(p => p.Name == "Authorization");

                        request.Parameters.Remove(authParam);

                        token = await RefreshToken();

                        request.AddHeader("Authorization", "Zoho-Oauthtoken " + token);

                        response = client.Execute<ManageengineRequests>(request);
                    }

                    if (!response.IsSuccessful || response.ErrorException != null)
                    {
                        throw new Exception(response.ErrorMessage);
                    }

                    if (response.Data.requests.Count < 100) break;
                    if (page > pages) break;

                    page++;

                    foreach (var manageengineRequest in response.Data.requests)
                    {

                        var existing = azurePayments.ManageengineRequests.FirstOrDefault(m => m.ManageengineID == manageengineRequest.id);

                        // HandleDeletedTicket(azurePayments, existing.ManageengineID, response);

                        //Console.WriteLine(existing.ManageengineID);
                        //Console.WriteLine(response.Data);
                        //Console.WriteLine(response.StatusCode);

                        if (existing != null)
                        {
                            existing.RequesterID = manageengineRequest.id;
                            existing.RequesterEmail = manageengineRequest.requester.email_id;
                            existing.RequesterID = manageengineRequest.requester.id;
                            existing.IsTechnician = manageengineRequest.requester.is_technician;
                            existing.SMSMail = manageengineRequest.requester.sms_mail;
                            existing.Mobile = manageengineRequest.requester.mobile;
                            existing.LastName = manageengineRequest.requester.last_name;
                            existing.UserScope = manageengineRequest.requester.user_scope;
                            existing.SMSMailID = manageengineRequest.requester.sms_mail_id;
                            existing.SiteDeleted = manageengineRequest.requester.site?.deleted;
                            existing.SiteName = manageengineRequest.requester.site?.name;
                            existing.SiteID = manageengineRequest.requester.site?.id;
                            existing.SiteIsDefault = manageengineRequest.requester.site?.is_default;
                            existing.Phone = manageengineRequest.requester.phone;
                            existing.EmployeeID = manageengineRequest.requester.employee_id;
                            existing.Name = manageengineRequest.requester.name;
                            existing.PhotoURL = manageengineRequest.requester.photo_url;
                            existing.IsVIPUser = manageengineRequest.requester.is_vip_user;
                            existing.DepartmentID = manageengineRequest.requester.department?.id;
                            existing.DepartmentName = manageengineRequest.requester.department?.name;
                            existing.FirstName = manageengineRequest.requester.first_name;
                            existing.JobTitle = manageengineRequest.requester.job_title;
                            existing.TemplateID = manageengineRequest.template?.id;
                            existing.TemplateInactive = manageengineRequest.template?.inactive;
                            existing.TemplateName = manageengineRequest.template?.name;
                            existing.TemplateIsServiceTemplate = manageengineRequest.template?.is_service_template;
                            existing.HasDraft = manageengineRequest.has_draft;
                            existing.CancelFlagComments = manageengineRequest.cancel_flag_comments;
                            existing.DisplayID = manageengineRequest.display_id;
                            existing.OnBehalfOf = manageengineRequest.on_behalf_of;
                            existing.Subject = manageengineRequest.subject;
                            existing.TechnicianEmail = manageengineRequest.technician?.email_id;
                            existing.TechnicianIsTechnician = manageengineRequest.technician?.is_technician;
                            existing.TechnicianMobile = manageengineRequest.technician?.mobile;
                            existing.TechnicianLastName = manageengineRequest.technician?.last_name;
                            existing.TechnicianUserScope = manageengineRequest.technician?.user_scope;
                            existing.TechnicianSMSMailID = manageengineRequest.technician?.sms_mail_id;
                            existing.TechnicianSMSMail = manageengineRequest.technician?.sms_mail;
                            existing.TechnicianSiteID = manageengineRequest.technician?.site.id;
                            existing.TechnicianPhone = manageengineRequest.technician?.phone;
                            existing.TechnicianEmployeeID = manageengineRequest.technician?.employee_id;
                            existing.TechnicianName = manageengineRequest.technician?.name;
                            existing.TechnicianID = manageengineRequest.technician?.id;
                            existing.TechnicianIsVIPUser = manageengineRequest.technician?.is_vip_user;
                            existing.TechnicianPhotoURL = manageengineRequest.technician?.photo_url;
                            existing.TechnicianDepartmentID = manageengineRequest.technician?.department?.id;
                            existing.TechnicianFirstName = manageengineRequest.technician?.first_name;
                            existing.TechnicianJobTitle = manageengineRequest.technician?.job_title;
                            existing.DueByTimeValue = manageengineRequest.due_by_time?.value;
                            existing.DueByTimeDisplayValue = manageengineRequest.due_by_time?.display_value;
                            existing.IsServiceRequest = manageengineRequest.is_service_request;
                            existing.CancellationRequested = manageengineRequest.cancellation_requested;
                            existing.HasNotes = manageengineRequest.has_notes;
                            existing.StatusInProgress = manageengineRequest.status?.in_progress;
                            existing.StatusInternalName = manageengineRequest.status?.internal_name;
                            existing.StatusStopTimer = manageengineRequest.status?.stop_timer;
                            existing.StatusColor = manageengineRequest.status?.color;
                            existing.StatusName = manageengineRequest.status?.name;
                            existing.StatusID = manageengineRequest.status?.id;
                            existing.LastUpdatedTime = manageengineRequest.last_updated_time?.display_value;
                            existing.CategoryName = manageengineRequest.category?.name;
                            existing.Description = manageengineRequest.description;
                            existing.Attachments = JsonConvert.SerializeObject(manageengineRequest.attachments?.Select(attachment => new
                            { content_url = attachment.content_url, name = attachment.name, }).ToList());
                            existing.NotificationStatus = manageengineRequest.notification_status;

                            azurePayments.SaveChanges("SYSTEM");

                            continue;
                        }

                        SaveNewRequest(manageengineRequest);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            return Ok();
        }

        private void SaveNewRequest(Request manageengineRequest, string user = "SYSTEM")
        {
            azurePayments.ManageengineRequests.Add(new ManageengineRequest
            {
                ManageengineID = manageengineRequest.id,
                CreatedAt = manageengineRequest.created_time != null ? Convert.ToDateTime(manageengineRequest.created_time.display_value) : (DateTime?)null,
                RequesterEmail = manageengineRequest.requester.email_id,
                RequesterID = manageengineRequest.requester.id,
                IsTechnician = manageengineRequest.requester.is_technician,
                SMSMail = manageengineRequest.requester.sms_mail,
                Mobile = manageengineRequest.requester.mobile,
                LastName = manageengineRequest.requester.last_name,
                UserScope = manageengineRequest.requester.user_scope,
                SMSMailID = manageengineRequest.requester.sms_mail_id,
                //CostPerHour = manageengineRequest.requester.cost_per_hour,
                SiteDeleted = manageengineRequest.requester.site?.deleted,
                SiteName = manageengineRequest.requester.site?.name,
                SiteID = manageengineRequest.requester.site?.id,
                SiteIsDefault = manageengineRequest.requester.site?.is_default,
                Phone = manageengineRequest.requester.phone,
                EmployeeID = manageengineRequest.requester.employee_id,
                Name = manageengineRequest.requester.name,
                PhotoURL = manageengineRequest.requester.photo_url,
                IsVIPUser = manageengineRequest.requester.is_vip_user,
                DepartmentID = manageengineRequest.requester.department?.id,
                DepartmentName = manageengineRequest.requester.department?.name,
                FirstName = manageengineRequest.requester.first_name,
                JobTitle = manageengineRequest.requester.job_title,
                TemplateID = manageengineRequest.template?.id,
                TemplateInactive = manageengineRequest.template?.inactive,
                TemplateName = manageengineRequest.template?.name,
                TemplateIsServiceTemplate = manageengineRequest.template?.is_service_template,
                CreatedTimeValue = manageengineRequest.created_time?.value,
                CreatedTimeDisplayValue = manageengineRequest.created_time?.display_value,
                HasDraft = manageengineRequest.has_draft,
                CancelFlagComments = manageengineRequest.cancel_flag_comments,
                DisplayID = manageengineRequest.display_id,
                OnBehalfOf = manageengineRequest.on_behalf_of,
                Subject = manageengineRequest.subject,
                //TechnicianCostPerHour = manageengineRequest.technician.cost_per_hour,
                TechnicianEmail = manageengineRequest.technician?.email_id,
                TechnicianIsTechnician = manageengineRequest.technician?.is_technician,
                TechnicianMobile = manageengineRequest.technician?.mobile,
                TechnicianLastName = manageengineRequest.technician?.last_name,
                TechnicianUserScope = manageengineRequest.technician?.user_scope,
                TechnicianSMSMailID = manageengineRequest.technician?.sms_mail_id,
                TechnicianSMSMail = manageengineRequest.technician?.sms_mail,
                TechnicianSiteID = manageengineRequest.technician?.site.id,
                TechnicianPhone = manageengineRequest.technician?.phone,
                TechnicianEmployeeID = manageengineRequest.technician?.employee_id,
                TechnicianName = manageengineRequest.technician?.name,
                TechnicianID = manageengineRequest.technician?.id,
                TechnicianIsVIPUser = manageengineRequest.technician?.is_vip_user,
                TechnicianPhotoURL = manageengineRequest.technician?.photo_url,
                TechnicianDepartmentID = manageengineRequest.technician?.department?.id,
                TechnicianFirstName = manageengineRequest.technician?.first_name,
                TechnicianJobTitle = manageengineRequest.technician?.job_title,
                DueByTimeValue = manageengineRequest.due_by_time?.value,
                DueByTimeDisplayValue = manageengineRequest.due_by_time?.display_value,
                IsServiceRequest = manageengineRequest.is_service_request,
                CancellationRequested = manageengineRequest.cancellation_requested,
                HasNotes = manageengineRequest.has_notes,
                //Maintenance = manageengineRequest.maintenance,
                StatusInProgress = manageengineRequest.status?.in_progress,
                StatusInternalName = manageengineRequest.status?.internal_name,
                StatusStopTimer = manageengineRequest.status?.stop_timer,
                StatusColor = manageengineRequest.status?.color,
                StatusName = manageengineRequest.status?.name,
                StatusID = manageengineRequest.status?.id,
                LastUpdatedTime = manageengineRequest.last_updated_time?.display_value,
                CategoryName = manageengineRequest.category?.name,
                Description = manageengineRequest.description,
                Attachments = JsonConvert.SerializeObject(manageengineRequest.attachments.Select(attachment => new
                { content_url = attachment.content_url, name = attachment.name, }).ToList()),
                NotificationStatus = manageengineRequest.notification_status,
            });

            azurePayments.SaveChanges(user);
        }

        private void HandleDeletedTicket(AzurePayments azurePayments, string manageengineId, IRestResponse<ManageengineRequestInfo> response)
        {
            var manageengineRequest = response.Data;

            bool shouldDelete = manageengineRequest.request?.deleted_time != null
                                || response.StatusCode == HttpStatusCode.NotFound;

            if (shouldDelete)
            {
                var deleteTicket = azurePayments.ManageengineRequests.FirstOrDefault(x => x.ManageengineID == manageengineId);
                if (deleteTicket?.StatusName == "Open")
                {
                    azurePayments.ManageengineRequests.Remove(deleteTicket);
                    azurePayments.SaveChanges("SYSTEM");
                }
                throw new InvalidOperationException($"ManageEngine error for ticket {manageengineId} with status code {response.StatusCode}: {response.ErrorMessage ?? "Unknown error"}");
            }
        }


        private void SaveNewConversation(int userPortalRequestsID, string displayID, string manageengineID, Conversation conversation)
        {
            azurePayments.ManageengineConversations.Add(new ManageengineConversation
            {
                UserPortalRequestsID = userPortalRequestsID,
                DisplayID = displayID,
                ManageengineID = manageengineID,
                ConversationsID = conversation.id,
                IsTechnician = conversation.created_by.is_technician,
                SenderEmail = conversation.created_by.email_id,
                SenderName = conversation.created_by.name,
                ShowToRequester = conversation.show_to_requester,
                Type = conversation.type,
                TimeDisplayValue = conversation.created_time.display_value,
                TimeValue = conversation.created_time.value,
            });

            azurePayments.SaveChanges("SYSTEM");
        }


        private async Task<string> RefreshToken()
        {
            var client_ID = configuration["Zoho:Client_ID"];
            var client_Secret = configuration["Zoho:Client_Secret"];
            var refresh_Token = configuration["Zoho:Refresh_Token"];

            var client = new HttpClient();

            var formContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("refresh_token", refresh_Token),
                new KeyValuePair<string, string>("grant_type", "refresh_token"),
                new KeyValuePair<string, string>("client_id", client_ID),
                new KeyValuePair<string, string>("client_secret", client_Secret),
                new KeyValuePair<string, string>("redirect_uri", "https://www.zoho.com")
            });

            var response = await client.PostAsync("https://accounts.zoho.com/oauth/v2/token", formContent);
            var tokenResponse = await response.Content.ReadAsStringAsync();

            var tokenData = JsonConvert.DeserializeObject<RefreshTokenResponse>(tokenResponse);

            var token = azurePayments.Tokens.First(t => t.Source == "Manageengine");
            ;
            token.Token1 = tokenData.access_token;
            token.ExpirationTime = DateTime.Now.AddMinutes(59);
            token.LastUpdated = DateTime.Now;

            azurePayments.SaveChanges(HttpContext);

            return tokenData.access_token; ;
        }
    }

    public class RefreshTokenResponse
    {
        public string access_token { get; set; }
        public string scope { get; set; }
        public string api_domain { get; set; }
        public string token_type { get; set; }
        public int expires_in { get; set; }
    }

    public class CreatedTime
    {
        public string display_value { get; set; }
        public string value { get; set; }
    }

    public class LastUpdatedTime
    {
        public string display_value { get; set; }
        public string value { get; set; }
    }

    public class Department
    {
        public Site site { get; set; }
        public string name { get; set; }
        public string id { get; set; }
    }

    public class DueByTime
    {
        public string display_value { get; set; }
        public string value { get; set; }
    }

    public class ListInfo
    {
        public bool has_more_rows { get; set; }
        public int start_index { get; set; }
        public string sort_field { get; set; }
        public int page { get; set; }
        public string sort_order { get; set; }
        public int row_count { get; set; }
    }


    public class Request
    {
        public Requester requester { get; set; }
        public Template template { get; set; }
        public CreatedTime created_time { get; set; }
        public bool has_draft { get; set; }
        public string cancel_flag_comments { get; set; }
        public string display_id { get; set; }
        public string on_behalf_of { get; set; }
        public string subject { get; set; }
        public Technician technician { get; set; }
        public DueByTime due_by_time { get; set; }
        public bool is_service_request { get; set; }
        public bool cancellation_requested { get; set; }
        public bool has_notes { get; set; }
        public string id { get; set; }
        public object maintenance { get; set; }
        public Status status { get; set; }
        public LastUpdatedTime last_updated_time { get; set; }
        public Category category { get; set; }
        public string description { get; set; }
        public List<Attachments> attachments { get; set; }
        public string notification_status { get; set; }

    }

    public class Requester
    {
        public string email_id { get; set; }
        public bool is_technician { get; set; }
        public string sms_mail { get; set; }
        public string mobile { get; set; }
        public string last_name { get; set; }
        public string user_scope { get; set; }
        public string sms_mail_id { get; set; }
        public string cost_per_hour { get; set; }
        public Site site { get; set; }
        public string phone { get; set; }
        public string employee_id { get; set; }
        public string name { get; set; }
        public string id { get; set; }
        public string photo_url { get; set; }
        public bool is_vip_user { get; set; }
        public Department department { get; set; }
        public string first_name { get; set; }
        public string job_title { get; set; }
    }

    public class ResponseStatus
    {
        public int status_code { get; set; }
        public string status { get; set; }
    }

    public class ManageengineRequests
    {
        public List<ResponseStatus> response_status { get; set; }
        public ListInfo list_info { get; set; }
        public List<Request> requests { get; set; }
    }

    public class Site
    {
        public bool deleted { get; set; }
        public string name { get; set; }
        public string id { get; set; }
        public bool is_default { get; set; }
    }

    public class Status
    {
        public bool in_progress { get; set; }
        public string internal_name { get; set; }
        public bool stop_timer { get; set; }
        public string color { get; set; }
        public string name { get; set; }
        public string id { get; set; }
    }

    public class Technician
    {
        public string email_id { get; set; }
        public bool is_technician { get; set; }
        public string sms_mail { get; set; }
        public string mobile { get; set; }
        public string last_name { get; set; }
        public string user_scope { get; set; }
        public string sms_mail_id { get; set; }
        public string cost_per_hour { get; set; }
        public Site site { get; set; }
        public string phone { get; set; }
        public string employee_id { get; set; }
        public string name { get; set; }
        public string id { get; set; }
        public bool is_vip_user { get; set; }
        public string photo_url { get; set; }
        public Department department { get; set; }
        public string first_name { get; set; }
        public string job_title { get; set; }
    }

    public class Template
    {
        public bool is_service_template { get; set; }
        public bool inactive { get; set; }
        public string name { get; set; }
        public string id { get; set; }
    }

    public class ManageenginePostParams
    {
        public string Category { get; set; }
        public string Site { get; set; }
        public string User { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string Attachments { get; set; }
        public string Priority { get; set; }
    }

    public class ManageengineResponse
    {
        public Request request { get; set; }
        public ResponseStatus response_status { get; set; }
    }

    public class Category
    {
        public string name { get; set; }  
    }

    public class Attachments
    {
        public string name { get; set; }
        public string content_url { get; set; }
    }

    public class ManageengineConversationsResponse
    {
        public List<ResponseStatus> response_status { get; set; }
        public ListInfo list_info { get; set; }
        public List<Conversation> conversations { get; set; }
    }

    public class Conversation
    {
        public CreatedTime created_time { get; set; }
        public int number_of_attachments { get; set; }
        public bool show_to_requester { get; set; }
        public string id { get; set; }
        public string type { get; set; }
        public CreatedBy created_by { get; set; }
    }

}
