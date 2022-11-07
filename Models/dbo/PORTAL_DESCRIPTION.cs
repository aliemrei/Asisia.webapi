using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class PORTAL_DESCRIPTION : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public Guid PORTALUID { get; set; }
        public string? ICON { get; set; }
        public string? CAPTION { get; set; }
        public string? DESCRIPTION { get; set; }
        public int? TYPE { get; set; }

        public virtual PORTAL PORTALU { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
