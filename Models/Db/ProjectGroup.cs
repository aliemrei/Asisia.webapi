using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class ProjectGroup : EntityBase // My Handlebars Helper
    {
        public ProjectGroup()
        {
            BonusDef = new HashSet<BonusDef>();
            CallJobs = new HashSet<CallJobs>();
            Campaigns = new HashSet<Campaigns>();
            PaymentEmails = new HashSet<PaymentEmails>();
            Portal = new HashSet<Portal>();
            ProjectGroupdetail = new HashSet<ProjectGroupdetail>();
            SmsSettings = new HashSet<SmsSettings>();
            SmtpSettings = new HashSet<SmtpSettings>();
            UserProjects = new HashSet<UserProjects>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public Guid? Corpid { get; set; }
        public bool Mergeclients { get; set; }
        public bool Usealternates { get; set; }
        public bool Isdeleted { get; set; }
        public bool Isdisabled { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public string? EntId { get; set; }
        public string? EntUrl { get; set; }
        public string? RakamId { get; set; }
        public string? AccCode { get; set; }
        public bool EntUse { get; set; }
        public string? ResMailurl { get; set; }
        public string? EntSetururl { get; set; }
        public string? EntSeturapikey { get; set; }
        public bool? DontstoreCcards { get; set; }
        public Guid? Addressid { get; set; }

        public virtual LocationAddress? Address { get; set; }
        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Corp? Corp { get; set; }
        public virtual Users? EdituserNavigation { get; set; }
        public virtual ICollection<BonusDef> BonusDef { get; set; }
        public virtual ICollection<CallJobs> CallJobs { get; set; }
        public virtual ICollection<Campaigns> Campaigns { get; set; }
        public virtual ICollection<PaymentEmails> PaymentEmails { get; set; }
        public virtual ICollection<Portal> Portal { get; set; }
        public virtual ICollection<ProjectGroupdetail> ProjectGroupdetail { get; set; }
        public virtual ICollection<SmsSettings> SmsSettings { get; set; }
        public virtual ICollection<SmtpSettings> SmtpSettings { get; set; }
        public virtual ICollection<UserProjects> UserProjects { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
