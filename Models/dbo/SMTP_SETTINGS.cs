using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class SMTP_SETTINGS : EntityBase // My Handlebars Helper
    {
        public SMTP_SETTINGS()
        {
            SMTP_MAILS = new HashSet<SMTP_MAILS>();
        }

        public Guid ID { get; set; }
        public Guid? CORPID { get; set; }
        public Guid? PROJECTID { get; set; }
        public Guid? PROJECT_DETAILID { get; set; }
        public string HOST { get; set; } = null!;
        public string USERNAME { get; set; } = null!;
        public string PASS { get; set; } = null!;
        public int PORTNO { get; set; }
        public string? TSL { get; set; }
        public string? SENDERNAME { get; set; }
        public bool ISDISABLED { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public string? SENDERMAIL { get; set; }
        public short TYPE { get; set; }
        public string? DOMAIN { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual CORP? CORP { get; set; }
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual PROJECT_GROUP? PROJECT { get; set; }
        public virtual ICollection<SMTP_MAILS> SMTP_MAILS { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
