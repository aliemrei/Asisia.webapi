using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class StdhotelRatetype : EntityBase // My Handlebars Helper
    {
        public StdhotelRatetype()
        {
            PropertyMapping = new HashSet<PropertyMapping>();
            RequestDetail = new HashSet<RequestDetail>();
            StdhotelPricecondition = new HashSet<StdhotelPricecondition>();
            StdhotelRatecodeDiscountRatetype = new HashSet<StdhotelRatecodeDiscountRatetype>();
        }

        public Guid Id { get; set; }
        public Guid Hotelid { get; set; }
        public string Definition { get; set; } = null!;
        public bool Isrefundable { get; set; }
        public int? EntId { get; set; }
        public byte Useonline { get; set; }
        public string? EntEtsid { get; set; }
        public string? EntTouristicaid { get; set; }
        public string? EntTatilbudurid { get; set; }
        public string? EntIatiid { get; set; }
        public string? EntTravelclickid { get; set; }
        public string? EntJollytourid { get; set; }
        public string? EntSednaid { get; set; }
        public string? EntHotelrunnerid { get; set; }
        public string? EntSeturid { get; set; }
        public int? RefundDay { get; set; }
        public TimeSpan? RefundLasttime { get; set; }

        public virtual Stdhotel Hotel { get; set; } = null!;
        public virtual ICollection<PropertyMapping> PropertyMapping { get; set; }
        public virtual ICollection<RequestDetail> RequestDetail { get; set; }
        public virtual ICollection<StdhotelPricecondition> StdhotelPricecondition { get; set; }
        public virtual ICollection<StdhotelRatecodeDiscountRatetype> StdhotelRatecodeDiscountRatetype { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
