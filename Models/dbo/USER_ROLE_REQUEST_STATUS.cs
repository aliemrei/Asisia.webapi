using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class USER_ROLE_REQUEST_STATUS : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid ROLEID { get; set; }
        public Guid STATUID { get; set; }
        public bool? ALLOW { get; set; }

        public virtual ROLES ROLE { get; set; } = null!;
        public virtual REQUEST_STATUS STATU { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
