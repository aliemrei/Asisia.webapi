using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class SntDiagram : EntityBase // My Handlebars Helper
    {
        public Guid DataKey { get; set; }
        public string Description { get; set; } = null!;
        public string? Page { get; set; }
        public string? Connectors { get; set; }
        public string? Shapes { get; set; }
        public bool Isactive { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
