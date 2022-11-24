using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class PortalSettings : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid Portalid { get; set; }
        public bool BasketHideClientDetails { get; set; }
        public bool BasketShowClientGender { get; set; }
        public bool BasketShowTransferOptions { get; set; }
        public string? Kvkk { get; set; }
        public string? Privacy { get; set; }
        public string? SalesRules { get; set; }
        public string? CancelationRules { get; set; }
        public string? Policies { get; set; }

        public virtual Portal Portal { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
