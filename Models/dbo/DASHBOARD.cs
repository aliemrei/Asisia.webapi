using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class DASHBOARD : EntityBase // My Handlebars Helper
    {
        public DASHBOARD()
        {
            DASHBOARD_ITEM = new HashSet<DASHBOARD_ITEM>();
            ROLES_DASHBOARDS = new HashSet<ROLES_DASHBOARDS>();
        }

        public Guid ID { get; set; }
        public string? DESIGN { get; set; }
        public string? TITLE { get; set; }
        public int MAXCOLUMN { get; set; }
        public string? STATEID { get; set; }
        public string COLUMNWIDTHS { get; set; } = null!;
        public int SORTORDER { get; set; }

        public virtual ICollection<DASHBOARD_ITEM> DASHBOARD_ITEM { get; set; }
        public virtual ICollection<ROLES_DASHBOARDS> ROLES_DASHBOARDS { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
