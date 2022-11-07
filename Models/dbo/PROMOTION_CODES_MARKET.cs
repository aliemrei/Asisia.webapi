using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class PROMOTION_CODES_MARKET : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public Guid PROMOTIONID { get; set; }
        public Guid MARKETID { get; set; }

        public virtual STDMARKETS MARKET { get; set; } = null!;
        public virtual PROMOTION_CODES PROMOTION { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
