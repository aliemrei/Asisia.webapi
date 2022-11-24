using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class PortalEmails : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid Portaluid { get; set; }
        public string? ToEmails { get; set; }
        public string? CcEmails { get; set; }
        public string? BccEmails { get; set; }

        public virtual Portal Portalu { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
