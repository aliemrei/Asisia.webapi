using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class PORTAL_URLREWRITE : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public string LINK { get; set; } = null!;
        public DateTime? VALIDDATE { get; set; }
        public DateTime ADDDATE { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
