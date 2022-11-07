using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class BASKET_DATA : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public Guid? REQUESTID { get; set; }
        public string? DATA { get; set; }

        public virtual REQUEST? REQUEST { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
