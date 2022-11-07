using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class REPORTS : EntityBase // My Handlebars Helper
    {
        public REPORTS()
        {
            CORPAUTO_PASSWORD_FORGETNavigation = new HashSet<CORP>();
            CORPAUTO_RESMAIL_CLIENTNavigation = new HashSet<CORP>();
            CORPAUTO_RESMAIL_HOSTNavigation = new HashSet<CORP>();
            SMTP_MAILS = new HashSet<SMTP_MAILS>();
        }

        public Guid ID { get; set; }
        public string REPORTNAME { get; set; } = null!;
        public Guid? PARENTID { get; set; }
        public string? DESIGN { get; set; }
        public string? CLASSNAME { get; set; }
        public string? EXPORTTYPE { get; set; }
        public byte? KIND { get; set; }

        public virtual ICollection<CORP> CORPAUTO_PASSWORD_FORGETNavigation { get; set; }
        public virtual ICollection<CORP> CORPAUTO_RESMAIL_CLIENTNavigation { get; set; }
        public virtual ICollection<CORP> CORPAUTO_RESMAIL_HOSTNavigation { get; set; }
        public virtual ICollection<SMTP_MAILS> SMTP_MAILS { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
