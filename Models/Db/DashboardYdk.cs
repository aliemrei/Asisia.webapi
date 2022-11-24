using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class DashboardYdk : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public string? Design { get; set; }
        public string? Title { get; set; }
        public int Maxcolumn { get; set; }
        public string? Stateid { get; set; }
        public string Columnwidths { get; set; } = null!;
        public int Sortorder { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
