using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class DASHBOARD_YDK : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public string? DESIGN { get; set; }
        public string? TITLE { get; set; }
        public int MAXCOLUMN { get; set; }
        public string? STATEID { get; set; }
        public string COLUMNWIDTHS { get; set; } = null!;
        public int SORTORDER { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
