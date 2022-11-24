using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class PortalDescription : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public Guid Portaluid { get; set; }
        public string? Icon { get; set; }
        public string? Caption { get; set; }
        public string? Description { get; set; }
        public int? Type { get; set; }

        public virtual Portal Portalu { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
