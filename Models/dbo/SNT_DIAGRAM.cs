using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class SNT_DIAGRAM : EntityBase // My Handlebars Helper
    {
        public Guid dataKey { get; set; }
        public string description { get; set; } = null!;
        public string? page { get; set; }
        public string? connectors { get; set; }
        public string? shapes { get; set; }
        public bool isactive { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
