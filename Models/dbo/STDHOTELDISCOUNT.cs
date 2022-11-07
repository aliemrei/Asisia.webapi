using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class STDHOTELDISCOUNT : EntityBase // My Handlebars Helper
    {
        public STDHOTELDISCOUNT()
        {
            STDHOTEL_RATECODE_DISCOUNT = new HashSet<STDHOTEL_RATECODE_DISCOUNT>();
        }

        public byte ID { get; set; }
        public string? DEFINITION { get; set; }

        public virtual ICollection<STDHOTEL_RATECODE_DISCOUNT> STDHOTEL_RATECODE_DISCOUNT { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
