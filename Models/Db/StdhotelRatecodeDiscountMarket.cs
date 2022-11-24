using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class StdhotelRatecodeDiscountMarket : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public Guid Discountid { get; set; }
        public Guid Marketid { get; set; }

        public virtual StdhotelRatecodeDiscount Discount { get; set; } = null!;
        public virtual StdhotelMarket Market { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
