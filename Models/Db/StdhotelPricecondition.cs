using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class StdhotelPricecondition : EntityBase // My Handlebars Helper
    {
        public StdhotelPricecondition()
        {
            HotelReservationDetails = new HashSet<HotelReservationDetails>();
            RequestDetail = new HashSet<RequestDetail>();
            StdhotelPriceconditionCalendar = new HashSet<StdhotelPriceconditionCalendar>();
            StdhotelPriceconditionOccupancy = new HashSet<StdhotelPriceconditionOccupancy>();
            StdhotelRatecodeDetail = new HashSet<StdhotelRatecodeDetail>();
            StdhotelStopsale = new HashSet<StdhotelStopsale>();
        }

        public Guid Id { get; set; }
        public Guid Hotelid { get; set; }
        public string Definition { get; set; } = null!;
        public string Curcode { get; set; } = null!;
        public Guid Roomtypeid { get; set; }
        public Guid Boardtypeid { get; set; }
        public Guid Ratetypeid { get; set; }
        public Guid? Marketid { get; set; }
        public Guid Corpid { get; set; }
        public double? Sngrate { get; set; }
        public double? Dblrate { get; set; }
        public double? Trprate { get; set; }
        public double? Quadrate { get; set; }
        public double? Chdyrate { get; set; }
        public double? Chderate { get; set; }
        public double? Babyrate { get; set; }
        public decimal? Sngamount { get; set; }
        public decimal? Dblamount { get; set; }
        public decimal? Trpamount { get; set; }
        public decimal? Quadamount { get; set; }
        public decimal? Chdyamount { get; set; }
        public decimal? Chdeamount { get; set; }
        public decimal? Babyamount { get; set; }
        public short? BabyMaxage { get; set; }
        public short? ChdyMaxage { get; set; }
        public short? ChdeMaxage { get; set; }
        public bool UseMaxages { get; set; }
        public bool ShareNullmarketToAllmarkets { get; set; }
        public bool UseCapacity { get; set; }
        public int? Minbedcount { get; set; }
        public int? Maxbedcount { get; set; }
        public int? Minadultcount { get; set; }
        public int? Maxadultcount { get; set; }
        public int? Minchildcount { get; set; }
        public int? Maxchildcount { get; set; }
        public int? Minbabycount { get; set; }
        public int? Maxbabycount { get; set; }
        public byte BabycountsIncToBeds { get; set; }
        public double? AdultRate { get; set; }
        public double? ChildRate { get; set; }
        public double? BabyRate1 { get; set; }

        public virtual StdhotelBoardtypes Boardtype { get; set; } = null!;
        public virtual Corp Corp { get; set; } = null!;
        public virtual Stdhotel Hotel { get; set; } = null!;
        public virtual StdhotelMarket? Market { get; set; }
        public virtual StdhotelRatetype Ratetype { get; set; } = null!;
        public virtual StdhotelRoomtypes Roomtype { get; set; } = null!;
        public virtual ICollection<HotelReservationDetails> HotelReservationDetails { get; set; }
        public virtual ICollection<RequestDetail> RequestDetail { get; set; }
        public virtual ICollection<StdhotelPriceconditionCalendar> StdhotelPriceconditionCalendar { get; set; }
        public virtual ICollection<StdhotelPriceconditionOccupancy> StdhotelPriceconditionOccupancy { get; set; }
        public virtual ICollection<StdhotelRatecodeDetail> StdhotelRatecodeDetail { get; set; }
        public virtual ICollection<StdhotelStopsale> StdhotelStopsale { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
