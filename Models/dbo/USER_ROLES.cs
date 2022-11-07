using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class USER_ROLES : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid USERID { get; set; }
        public Guid ROLEID { get; set; }
        public bool ISDELETED { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public Guid? MODULEID { get; set; }

        public virtual ROLES ROLE { get; set; } = null!;
        public virtual USERS USER { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
