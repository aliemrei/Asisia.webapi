using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class SmsSettings : EntityBase // My Handlebars Helper
    {
        public SmsSettings()
        {
            SmsMessage = new HashSet<SmsMessage>();
        }

        public Guid Id { get; set; }
        public Guid? Corpid { get; set; }
        public Guid? Projectid { get; set; }
        public Guid? ProjectDetailid { get; set; }
        public string Smsclassname { get; set; } = null!;
        public string? Param { get; set; }
        public string Username { get; set; } = null!;
        public string Pass { get; set; } = null!;
        public string? Sender { get; set; }
        public bool Isdisabled { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Corp? Corp { get; set; }
        public virtual Users? EdituserNavigation { get; set; }
        public virtual ProjectGroup? Project { get; set; }
        public virtual ProjectGroupdetail? ProjectDetail { get; set; }
        public virtual ICollection<SmsMessage> SmsMessage { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
