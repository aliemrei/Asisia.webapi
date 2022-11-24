using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class SntDiagramChildkeys : EntityBase // My Handlebars Helper
    {
        public string Key { get; set; } = null!;
        public Guid DataKey { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
