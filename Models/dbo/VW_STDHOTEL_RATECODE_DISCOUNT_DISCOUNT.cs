using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class VW_STDHOTEL_RATECODE_DISCOUNT_DISCOUNT : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public Guid DISCOUNTID { get; set; }
        public Guid OTHERDISCOUNTID { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
