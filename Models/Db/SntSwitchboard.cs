using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class SntSwitchboard : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Ipaddress { get; set; }
        public string? Username { get; set; }
        public string? Pass { get; set; }
        public int Port { get; set; }
        public string? ExtensionsFix { get; set; }
        public Guid? Corpid { get; set; }
        public string? ExtensionsOutboundFix { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
