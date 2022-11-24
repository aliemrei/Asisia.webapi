using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class SmtpMails : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public Guid? RequestDetailid { get; set; }
        public bool Issent { get; set; }
        public DateTime? Senddate { get; set; }
        public Guid? Reportid { get; set; }
        public string? Sendername { get; set; }
        public string? Sendermail { get; set; }
        public string? Host { get; set; }
        public string? To { get; set; }
        public string? Cc { get; set; }
        public Guid? Smtpid { get; set; }
        public string? Senderror { get; set; }
        public Guid? Requestid { get; set; }
        public Guid Uid { get; set; }

        public virtual Reports? Report { get; set; }
        public virtual Request? Request { get; set; }
        public virtual RequestDetail? RequestDetail { get; set; }
        public virtual SmtpSettings? Smtp { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
