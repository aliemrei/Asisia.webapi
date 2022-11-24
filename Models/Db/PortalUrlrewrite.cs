using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class PortalUrlrewrite : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public string Link { get; set; } = null!;
        public DateTime? Validdate { get; set; }
        public DateTime Adddate { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
