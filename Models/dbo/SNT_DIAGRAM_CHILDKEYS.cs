using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class SNT_DIAGRAM_CHILDKEYS : EntityBase // My Handlebars Helper
    {
        public string key { get; set; } = null!;
        public Guid dataKey { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
