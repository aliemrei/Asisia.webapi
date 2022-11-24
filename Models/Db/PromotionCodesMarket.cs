using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class PromotionCodesMarket : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public Guid Promotionid { get; set; }
        public Guid Marketid { get; set; }

        public virtual Stdmarkets Market { get; set; } = null!;
        public virtual PromotionCodes Promotion { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
