using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class RolesDashboards : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid Roleid { get; set; }
        public Guid Dashboardid { get; set; }
        public bool? Allow { get; set; }

        public virtual Dashboard Dashboard { get; set; } = null!;
        public virtual Roles Role { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
