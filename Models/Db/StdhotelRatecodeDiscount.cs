using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class StdhotelRatecodeDiscount : EntityBase // My Handlebars Helper
    {
        public StdhotelRatecodeDiscount()
        {
            StdhotelRatecodeDiscountContract = new HashSet<StdhotelRatecodeDiscountContract>();
            StdhotelRatecodeDiscountMarket = new HashSet<StdhotelRatecodeDiscountMarket>();
            StdhotelRatecodeDiscountRatetype = new HashSet<StdhotelRatecodeDiscountRatetype>();
            StdhotelRatecodeDiscountRoomtype = new HashSet<StdhotelRatecodeDiscountRoomtype>();
        }

        public Guid Id { get; set; }
        public Guid Hotelid { get; set; }
        public Guid Ratecodeid { get; set; }
        public string? Definition { get; set; }
        public byte? Basictype { get; set; }
        public double Discount { get; set; }
        public byte Discounttype { get; set; }
        public bool Applyalone { get; set; }
        public byte Applyorder { get; set; }
        public DateTime? Sellfrom { get; set; }
        public DateTime? Sellto { get; set; }
        public DateTime? Stayfrom { get; set; }
        public DateTime? Stayto { get; set; }
        public DateTime? Applyfrom { get; set; }
        public DateTime? Applyto { get; set; }
        public string? Checkindays { get; set; }
        public string? Checkoutdays { get; set; }
        public string? Stayingdays { get; set; }
        public byte? Minlos { get; set; }
        public byte? Maxlos { get; set; }
        public byte? Minpax { get; set; }
        public byte? Maxpax { get; set; }
        public byte Applytype { get; set; }
        public byte Applyzone { get; set; }
        public bool AdditionalDiscount { get; set; }
        public byte AdditionalEffect { get; set; }
        public string? Applydays { get; set; }
        public Guid? Agencyid { get; set; }

        public virtual Agency? Agency { get; set; }
        public virtual Stdhoteldiscount DiscounttypeNavigation { get; set; } = null!;
        public virtual Stdhotel Hotel { get; set; } = null!;
        public virtual StdhotelRatecode Ratecode { get; set; } = null!;
        public virtual ICollection<StdhotelRatecodeDiscountContract> StdhotelRatecodeDiscountContract { get; set; }
        public virtual ICollection<StdhotelRatecodeDiscountMarket> StdhotelRatecodeDiscountMarket { get; set; }
        public virtual ICollection<StdhotelRatecodeDiscountRatetype> StdhotelRatecodeDiscountRatetype { get; set; }
        public virtual ICollection<StdhotelRatecodeDiscountRoomtype> StdhotelRatecodeDiscountRoomtype { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
