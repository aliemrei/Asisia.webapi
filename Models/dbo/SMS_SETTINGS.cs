using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class SMS_SETTINGS : EntityBase // My Handlebars Helper
    {
        public SMS_SETTINGS()
        {
            SMS_MESSAGE = new HashSet<SMS_MESSAGE>();
        }

        public Guid ID { get; set; }
        public Guid? CORPID { get; set; }
        public Guid? PROJECTID { get; set; }
        public Guid? PROJECT_DETAILID { get; set; }
        public string SMSCLASSNAME { get; set; } = null!;
        public string? PARAM { get; set; }
        public string USERNAME { get; set; } = null!;
        public string PASS { get; set; } = null!;
        public string? SENDER { get; set; }
        public bool ISDISABLED { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual CORP? CORP { get; set; }
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual PROJECT_GROUP? PROJECT { get; set; }
        public virtual PROJECT_GROUPDETAIL? PROJECT_DETAIL { get; set; }
        public virtual ICollection<SMS_MESSAGE> SMS_MESSAGE { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
