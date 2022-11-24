using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class StdhotelRatecodeDiscountDiscount : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public Guid Discountid { get; set; }
        public Guid Otherdiscountid { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
