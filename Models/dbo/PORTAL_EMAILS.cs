using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class PORTAL_EMAILS : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid PORTALUID { get; set; }
        public string? TO_EMAILS { get; set; }
        public string? CC_EMAILS { get; set; }
        public string? BCC_EMAILS { get; set; }

        public virtual PORTAL PORTALU { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
