using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class PortalAuthIpaddress : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid Portaluid { get; set; }
        public string Ipaddress { get; set; } = null!;
        public bool? Ismanager { get; set; }

        public virtual Portal Portalu { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
