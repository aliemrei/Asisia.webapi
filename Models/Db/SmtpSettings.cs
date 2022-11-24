using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class SmtpSettings : EntityBase // My Handlebars Helper
    {
        public SmtpSettings()
        {
            SmtpMails = new HashSet<SmtpMails>();
        }

        public Guid Id { get; set; }
        public Guid? Corpid { get; set; }
        public Guid? Projectid { get; set; }
        public Guid? ProjectDetailid { get; set; }
        public string Host { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string Pass { get; set; } = null!;
        public int Portno { get; set; }
        public string? Tsl { get; set; }
        public string? Sendername { get; set; }
        public bool Isdisabled { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public string? Sendermail { get; set; }
        public short Type { get; set; }
        public string? Domain { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Corp? Corp { get; set; }
        public virtual Users? EdituserNavigation { get; set; }
        public virtual ProjectGroup? Project { get; set; }
        public virtual ICollection<SmtpMails> SmtpMails { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
