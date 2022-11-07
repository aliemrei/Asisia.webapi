using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class PORTAL_AUTH_IPADDRESS : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid PORTALUID { get; set; }
        public string IPADDRESS { get; set; } = null!;
        public bool? ISMANAGER { get; set; }

        public virtual PORTAL PORTALU { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
