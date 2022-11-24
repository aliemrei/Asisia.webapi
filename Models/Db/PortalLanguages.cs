using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class PortalLanguages : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public Guid Portaluid { get; set; }
        public string Langcode { get; set; } = null!;

        public virtual Portal Portalu { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
