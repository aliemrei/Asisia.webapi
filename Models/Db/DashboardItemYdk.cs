using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class DashboardItemYdk : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid Dashboardid { get; set; }
        public string? Qsql { get; set; }
        public string? Design { get; set; }
        public string? Title { get; set; }
        public string Widgetname { get; set; } = null!;
        public int Columnindex { get; set; }
        public string? DetailSql { get; set; }
        public int Sortorder { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
