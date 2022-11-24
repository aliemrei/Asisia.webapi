using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class StdhotelMarket : EntityBase // My Handlebars Helper
    {
        public StdhotelMarket()
        {
            RequestDetail = new HashSet<RequestDetail>();
            ReservationSettingsMarket = new HashSet<ReservationSettingsMarket>();
            StdhotelPricecondition = new HashSet<StdhotelPricecondition>();
            StdhotelRatecodeDiscountMarket = new HashSet<StdhotelRatecodeDiscountMarket>();
            StdhotelRatecodeMarkupMarkets = new HashSet<StdhotelRatecodeMarkupMarkets>();
        }

        public Guid Id { get; set; }
        public Guid Hotelid { get; set; }
        public string Definition { get; set; } = null!;
        public string? EntId { get; set; }
        public Guid? Stdmarketid { get; set; }
        public string? EntEtsid { get; set; }
        public string? EntTouristicaid { get; set; }
        public string? EntTatilbudurid { get; set; }
        public string? EntIatiid { get; set; }
        public string? EntTravelclickid { get; set; }
        public string? EntJollytourid { get; set; }
        public string? EntSednaid { get; set; }
        public string? EntHotelrunnerid { get; set; }
        public string? EntSeturid { get; set; }

        public virtual Stdhotel Hotel { get; set; } = null!;
        public virtual Stdmarkets? Stdmarket { get; set; }
        public virtual ICollection<RequestDetail> RequestDetail { get; set; }
        public virtual ICollection<ReservationSettingsMarket> ReservationSettingsMarket { get; set; }
        public virtual ICollection<StdhotelPricecondition> StdhotelPricecondition { get; set; }
        public virtual ICollection<StdhotelRatecodeDiscountMarket> StdhotelRatecodeDiscountMarket { get; set; }
        public virtual ICollection<StdhotelRatecodeMarkupMarkets> StdhotelRatecodeMarkupMarkets { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
