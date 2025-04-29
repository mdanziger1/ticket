using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UTA.API.DAL.Models
{
    public partial class ManageengineRequest
    {
        public int ID { get; set; }

        public string ManageengineID { get; set; }
        public DateTime? CreatedAt { get; set; }

        [StringLength(255)]
        public string RequesterEmail { get; set; }
        public string RequesterID { get; set; }

        public bool? IsTechnician { get; set; }

        [StringLength(255)]
        public string SMSMail { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        [StringLength(255)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string UserScope { get; set; }

        [StringLength(255)]
        public string SMSMailID { get; set; }

        public decimal? CostPerHour { get; set; }

        public bool? SiteDeleted { get; set; }

        [StringLength(255)]
        public string SiteName { get; set; }

        [StringLength(255)]
        public string SiteID { get; set; }

        public bool? SiteIsDefault { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string EmployeeID { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(255)]
        public string PhotoURL { get; set; }

        public bool? IsVIPUser { get; set; }

        [StringLength(255)]
        public string DepartmentName { get; set; }

        [StringLength(255)]
        public string DepartmentID { get; set; }

        [StringLength(255)]
        public string FirstName { get; set; }

        [StringLength(255)]
        public string JobTitle { get; set; }

        public bool? TemplateIsServiceTemplate { get; set; }

        public bool? TemplateInactive { get; set; }

        [StringLength(255)]
        public string TemplateName { get; set; }

        [StringLength(255)]
        public string TemplateID { get; set; }

        [StringLength(50)]
        public string CreatedTimeDisplayValue { get; set; }

        [StringLength(50)]
        public string CreatedTimeValue { get; set; }

        public bool? HasDraft { get; set; }

        [StringLength(255)]
        public string CancelFlagComments { get; set; }

        [StringLength(50)]
        public string DisplayID { get; set; }

        [StringLength(255)]
        public string OnBehalfOf { get; set; }

        [StringLength(255)]
        public string Subject { get; set; }

        [StringLength(255)]
        public string TechnicianEmail { get; set; }

        public bool? TechnicianIsTechnician { get; set; }

        [StringLength(255)]
        public string TechnicianSMSMail { get; set; }

        [StringLength(50)]
        public string TechnicianMobile { get; set; }

        [StringLength(255)]
        public string TechnicianLastName { get; set; }

        [StringLength(50)]
        public string TechnicianUserScope { get; set; }

        [StringLength(255)]
        public string TechnicianSMSMailID { get; set; }

        public decimal? TechnicianCostPerHour { get; set; }

        [StringLength(255)]
        public string TechnicianSiteID { get; set; }

        [StringLength(50)]
        public string TechnicianPhone { get; set; }

        [StringLength(50)]
        public string TechnicianEmployeeID { get; set; }

        [StringLength(255)]
        public string TechnicianName { get; set; }

        [StringLength(255)]
        public string TechnicianPhotoURL { get; set; }

        public bool? TechnicianIsVIPUser { get; set; }

        [StringLength(255)]
        public string TechnicianDepartmentID { get; set; }

        [StringLength(255)]
        public string TechnicianFirstName { get; set; }

        [StringLength(255)]
        public string TechnicianJobTitle { get; set; }
        public string TechnicianID { get; set; }

        [StringLength(50)]
        public string DueByTimeDisplayValue { get; set; }

        [StringLength(50)]
        public string DueByTimeValue { get; set; }

        public bool? IsServiceRequest { get; set; }

        public bool? CancellationRequested { get; set; }

        public bool? HasNotes { get; set; }

        [StringLength(255)]
        public string Maintenance { get; set; }

        public bool? StatusInProgress { get; set; }

        [StringLength(255)]
        public string StatusInternalName { get; set; }

        public bool? StatusStopTimer { get; set; }

        [StringLength(20)]
        public string StatusColor { get; set; }

        [StringLength(255)]
        public string StatusName { get; set; }

        [StringLength(255)]
        public string StatusID { get; set; }

        public string Description { get; set; }
        public string LastUpdatedTime { get; set; }

        public string CategoryID { get; set; }
        public string CategoryName { get; set; }

        public string Attachments { get; set; }

        public DateTime? CompletedTime { get; set; }

        public string NotificationStatus { get; set; }
    }
}
