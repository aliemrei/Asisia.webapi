using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class ROLES_DASHBOARDS : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid ROLEID { get; set; }
        public Guid DASHBOARDID { get; set; }
        public bool? ALLOW { get; set; }

        public virtual DASHBOARD DASHBOARD { get; set; } = null!;
        public virtual ROLES ROLE { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
