using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class PORTAL_SETTINGS : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid PORTALID { get; set; }
        public bool BASKET_HIDE_CLIENT_DETAILS { get; set; }
        public bool BASKET_SHOW_CLIENT_GENDER { get; set; }
        public bool BASKET_SHOW_TRANSFER_OPTIONS { get; set; }
        public string? KVKK { get; set; }
        public string? PRIVACY { get; set; }
        public string? SALES_RULES { get; set; }
        public string? CANCELATION_RULES { get; set; }
        public string? POLICIES { get; set; }

        public virtual PORTAL PORTAL { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
