using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class VwLocations : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public string Definition { get; set; } = null!;
        public Guid Corpid { get; set; }
        public string Type { get; set; } = null!;
        public string? Code { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
