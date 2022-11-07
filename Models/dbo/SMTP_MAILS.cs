using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class SMTP_MAILS : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public Guid? REQUEST_DETAILID { get; set; }
        public bool ISSENT { get; set; }
        public DateTime? SENDDATE { get; set; }
        public Guid? REPORTID { get; set; }
        public string? SENDERNAME { get; set; }
        public string? SENDERMAIL { get; set; }
        public string? HOST { get; set; }
        public string? _TO { get; set; }
        public string? _CC { get; set; }
        public Guid? SMTPID { get; set; }
        public string? SENDERROR { get; set; }
        public Guid? REQUESTID { get; set; }
        public Guid UID { get; set; }

        public virtual REPORTS? REPORT { get; set; }
        public virtual REQUEST? REQUEST { get; set; }
        public virtual REQUEST_DETAIL? REQUEST_DETAIL { get; set; }
        public virtual SMTP_SETTINGS? SMTP { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
