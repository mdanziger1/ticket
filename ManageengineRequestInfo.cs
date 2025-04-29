using System.Collections.Generic;

namespace AdminPortal.Models
{
    public class ManageengineRequestInfo
    {
        public Request request { get; set; }
        public ResponseStatus response_status { get; set; }

        public class AssignedTime
        {
            public string display_value { get; set; }
            public string value { get; set; }
        }

        public class Attachment
        {
            public string size { get; set; }
            public string content_type { get; set; }
            public string module { get; set; }
            public string file_id { get; set; }
            public string name { get; set; }
            public string content_url { get; set; }
            public string id { get; set; }
        }

        public class Category
        {
            public bool deleted { get; set; }
            public string name { get; set; }
            public string id { get; set; }
        }

        public class ClosureInfo
        {
            public object requester_ack_comments { get; set; }
            public object closure_code { get; set; }
            public object closure_comments { get; set; }
            public bool requester_ack_resolution { get; set; }
        }

        public class CompletedTime
        {
            public string display_value { get; set; }
            public string value { get; set; }
        }

        public class CreatedBy
        {
            public string email_id { get; set; }
            public bool is_technician { get; set; }
            public object sms_mail { get; set; }
            public object mobile { get; set; }
            public string last_name { get; set; }
            public string user_scope { get; set; }
            public object sms_mail_id { get; set; }
            public object cost_per_hour { get; set; }
            public object site { get; set; }
            public object phone { get; set; }
            public string employee_id { get; set; }
            public string name { get; set; }
            public string id { get; set; }
            public string photo_url { get; set; }
            public bool is_vip_user { get; set; }
            public object department { get; set; }
            public string first_name { get; set; }
            public string job_title { get; set; }
        }

        public class CreatedTime
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

        public class FirstResponseDueByTime
        {
            public string display_value { get; set; }
            public string value { get; set; }
        }

        public class LastUpdatedTime
        {
            public string display_value { get; set; }
            public string value { get; set; }
        }

        public class Priority
        {
            public string color { get; set; }
            public string name { get; set; }
            public string id { get; set; }
        }

        public class Rel
        {
            public object fixed_in_releases { get; set; }
            public object caused_by_releases { get; set; }
        }

        public class Request
        {
            public string subject { get; set; }
            public object project { get; set; }
            public Resolution resolution { get; set; }
            public object linked_to_request { get; set; }
            public object lifecycle { get; set; }
            public bool is_read { get; set; }
            public object workflow_instance_details { get; set; }
            public List<object> entity_instance_properties { get; set; }
            public bool cancellation_requested { get; set; }
            public bool is_trashed { get; set; }
            public bool has_change_initiated_request { get; set; }
            public Rel rel { get; set; }
            public string id { get; set; }
            public AssignedTime assigned_time { get; set; }
            public Requester requester { get; set; }
            public List<string> email_to { get; set; }
            public CreatedTime created_time { get; set; }
            public object workflow { get; set; }
            public object cancel_flag_comments { get; set; }
            public object on_behalf_of { get; set; }
            public object approval_status { get; set; }
            public Sla sla { get; set; }
            public ResolvedTime resolved_time { get; set; }
            public Priority priority { get; set; }
            public CreatedBy created_by { get; set; }
            public List<object> tags { get; set; }
            public FirstResponseDueByTime first_response_due_by_time { get; set; }
            public bool is_escalated { get; set; }
            public LastUpdatedTime last_updated_time { get; set; }
            public bool has_notes { get; set; }
            public UdfFields udf_fields { get; set; }
            public object subcategory { get; set; }
            public object deleted_time { get; set; }
            public List<object> email_cc { get; set; }
            public Status status { get; set; }
            public Template template { get; set; }
            public List<string> email_ids_to_notify { get; set; }
            public List<Attachment> attachments { get; set; }
            public bool completed_by_denial { get; set; }
            public string display_id { get; set; }
            public string time_elapsed { get; set; }
            public string notification_status { get; set; }
            public string description { get; set; }
            public RespondedTime responded_time { get; set; }
            public ClosureInfo closure_info { get; set; }
            public bool is_service_request { get; set; }
            public bool has_request_initiated_change { get; set; }
            public List<object> request_template_task_ids { get; set; }
            public Department department { get; set; }
            public bool is_reopened { get; set; }
            public bool has_draft { get; set; }
            public bool has_attachments { get; set; }
            public bool has_linked_requests { get; set; }
            public string message_id { get; set; }
            public bool is_overdue { get; set; }
            public Technician technician { get; set; }
            public bool has_problem { get; set; }
            public DueByTime due_by_time { get; set; }
            public bool is_fcr { get; set; }
            public bool has_project { get; set; }
            public Site site { get; set; }
            public bool is_first_response_overdue { get; set; }
            public CompletedTime completed_time { get; set; }
            public int unreplied_count { get; set; }
            public List<object> email_bcc { get; set; }
            public Category category { get; set; }
            public object maintenance { get; set; }
        }

        public class Requester
        {
            public string email_id { get; set; }
            public bool is_technician { get; set; }
            public object sms_mail { get; set; }
            public object mobile { get; set; }
            public object last_name { get; set; }
            public string user_scope { get; set; }
            public object sms_mail_id { get; set; }
            public object cost_per_hour { get; set; }
            public Site site { get; set; }
            public string phone { get; set; }
            public object employee_id { get; set; }
            public string name { get; set; }
            public string id { get; set; }
            public string photo_url { get; set; }
            public bool is_vip_user { get; set; }
            public Department department { get; set; }
            public string first_name { get; set; }
            public object job_title { get; set; }
        }

        public class Resolution
        {
            public string content { get; set; }
        }

        public class ResolvedTime
        {
            public string display_value { get; set; }
            public string value { get; set; }
        }

        public class RespondedTime
        {
            public string display_value { get; set; }
            public string value { get; set; }
        }

        public class ResponseStatus
        {
            public int status_code { get; set; }
            public string status { get; set; }
        }

        public class Site
        {
            public bool deleted { get; set; }
            public string name { get; set; }
            public string id { get; set; }
            public bool is_default { get; set; }
        }

        public class Sla
        {
            public string name { get; set; }
            public string id { get; set; }
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
            public object sms_mail { get; set; }
            public string mobile { get; set; }
            public string last_name { get; set; }
            public string user_scope { get; set; }
            public object sms_mail_id { get; set; }
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

        public class UdfFields
        {
            public object udf_char6 { get; set; }
            public object udf_char2 { get; set; }
            public string udf_char3 { get; set; }
            public string udf_char5 { get; set; }
        }
    }
}
