using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class StdhotelRatecodeDiscountContract : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public Guid Discountid { get; set; }
        public Guid Contractid { get; set; }

        public virtual StdhotelRatecodeDetail Contract { get; set; } = null!;
        public virtual StdhotelRatecodeDiscount Discount { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
