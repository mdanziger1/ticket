using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UTA.API.DAL.Models
{
    public partial class ManageengineConversation
    {
        [Key]
        public int ID { get; set; }

        public int UserPortalRequestsID { get; set; }

        [MaxLength(100)]
        public string DisplayID { get; set; }

        [MaxLength(100)]
        public string ManageengineID { get; set; }

        [MaxLength(100)]
        public string ConversationsID { get; set; }

        public bool IsTechnician { get; set; }

        [MaxLength(255)]
        public string SenderEmail { get; set; }

        [MaxLength(255)]
        public string SenderName { get; set; }

        public bool ShowToRequester { get; set; }

        [MaxLength(50)]
        public string Type { get; set; }

        [MaxLength(100)]
        public string TimeDisplayValue { get; set; }

        [MaxLength(100)]
        public string TimeValue { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public bool HasAttachments { get; set; }
        public string Attachments { get; set; }
        public string ToEmail { get; set; }
    }
}
