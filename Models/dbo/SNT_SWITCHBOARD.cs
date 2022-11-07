using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class SNT_SWITCHBOARD : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public string NAME { get; set; } = null!;
        public string? IPADDRESS { get; set; }
        public string? USERNAME { get; set; }
        public string? PASS { get; set; }
        public int PORT { get; set; }
        public string? EXTENSIONS_FIX { get; set; }
        public Guid? CORPID { get; set; }
        public string? EXTENSIONS_OUTBOUND_FIX { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
