using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class DASHBOARD_ITEM_YDK : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid DASHBOARDID { get; set; }
        public string? QSQL { get; set; }
        public string? DESIGN { get; set; }
        public string? TITLE { get; set; }
        public string WIDGETNAME { get; set; } = null!;
        public int COLUMNINDEX { get; set; }
        public string? DETAIL_SQL { get; set; }
        public int SORTORDER { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
