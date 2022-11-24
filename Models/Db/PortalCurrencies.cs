using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class PortalCurrencies : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public Guid Portaluid { get; set; }
        public string Curcode { get; set; } = null!;

        public virtual Curcode CurcodeNavigation { get; set; } = null!;
        public virtual Portal Portalu { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
