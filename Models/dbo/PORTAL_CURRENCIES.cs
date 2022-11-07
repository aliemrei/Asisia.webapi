using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class PORTAL_CURRENCIES : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public Guid PORTALUID { get; set; }
        public string CURCODE { get; set; } = null!;

        public virtual CURCODE CURCODENavigation { get; set; } = null!;
        public virtual PORTAL PORTALU { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
