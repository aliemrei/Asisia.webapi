using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class TourDiscounts : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid Tourid { get; set; }
        public string? Definition { get; set; }
        public double Discount { get; set; }
        public byte Discounttype { get; set; }
        public DateTime? Sellfrom { get; set; }
        public DateTime? Sellto { get; set; }
        public double? Minprice { get; set; }
        public double? Maxprice { get; set; }
        public byte? Minpax { get; set; }
        public byte? Maxpax { get; set; }
        public byte Applytype { get; set; }
        public DateTime? Tourfrom { get; set; }
        public DateTime? Tourto { get; set; }
        public int Validcount { get; set; }
        public DateTime Adddate { get; set; }
        public Guid Adduser { get; set; }
        public DateTime? Editdate { get; set; }
        public Guid? Edituser { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Tourdiscount DiscounttypeNavigation { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual Tour Tour { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
