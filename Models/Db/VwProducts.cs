using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class VwProducts : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid Corpid { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
