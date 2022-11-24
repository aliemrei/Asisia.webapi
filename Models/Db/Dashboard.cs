using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class Dashboard : EntityBase // My Handlebars Helper
    {
        public Dashboard()
        {
            DashboardItem = new HashSet<DashboardItem>();
            RolesDashboards = new HashSet<RolesDashboards>();
        }

        public Guid Id { get; set; }
        public string? Design { get; set; }
        public string? Title { get; set; }
        public int Maxcolumn { get; set; }
        public string? Stateid { get; set; }
        public string Columnwidths { get; set; } = null!;
        public int Sortorder { get; set; }

        public virtual ICollection<DashboardItem> DashboardItem { get; set; }
        public virtual ICollection<RolesDashboards> RolesDashboards { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
