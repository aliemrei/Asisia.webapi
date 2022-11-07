using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class ROLES : EntityBase // My Handlebars Helper
    {
        public ROLES()
        {
            ROLES_DASHBOARDS = new HashSet<ROLES_DASHBOARDS>();
            ROLE_AUTH = new HashSet<ROLE_AUTH>();
            USER_ROLES = new HashSet<USER_ROLES>();
            USER_ROLE_REQUEST_STATUS = new HashSet<USER_ROLE_REQUEST_STATUS>();
        }

        public Guid ID { get; set; }
        public Guid CORPID { get; set; }
        public string NAME { get; set; } = null!;
        public bool ISDELETED { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public Guid? MODULEID { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual CORP CORP { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual ICollection<ROLES_DASHBOARDS> ROLES_DASHBOARDS { get; set; }
        public virtual ICollection<ROLE_AUTH> ROLE_AUTH { get; set; }
        public virtual ICollection<USER_ROLES> USER_ROLES { get; set; }
        public virtual ICollection<USER_ROLE_REQUEST_STATUS> USER_ROLE_REQUEST_STATUS { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
