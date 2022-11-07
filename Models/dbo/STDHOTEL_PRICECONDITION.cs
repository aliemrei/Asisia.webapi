using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class STDHOTEL_PRICECONDITION : EntityBase // My Handlebars Helper
    {
        public STDHOTEL_PRICECONDITION()
        {
            HOTEL_RESERVATION_DETAILS = new HashSet<HOTEL_RESERVATION_DETAILS>();
            REQUEST_DETAIL = new HashSet<REQUEST_DETAIL>();
            STDHOTEL_PRICECONDITION_CALENDAR = new HashSet<STDHOTEL_PRICECONDITION_CALENDAR>();
            STDHOTEL_PRICECONDITION_OCCUPANCY = new HashSet<STDHOTEL_PRICECONDITION_OCCUPANCY>();
            STDHOTEL_RATECODE_DETAIL = new HashSet<STDHOTEL_RATECODE_DETAIL>();
            STDHOTEL_STOPSALE = new HashSet<STDHOTEL_STOPSALE>();
        }

        public Guid ID { get; set; }
        public Guid HOTELID { get; set; }
        public string DEFINITION { get; set; } = null!;
        public string CURCODE { get; set; } = null!;
        public Guid ROOMTYPEID { get; set; }
        public Guid BOARDTYPEID { get; set; }
        public Guid RATETYPEID { get; set; }
        public Guid? MARKETID { get; set; }
        public Guid CORPID { get; set; }
        public double? SNGRATE { get; set; }
        public double? DBLRATE { get; set; }
        public double? TRPRATE { get; set; }
        public double? QUADRATE { get; set; }
        public double? CHDYRATE { get; set; }
        public double? CHDERATE { get; set; }
        public double? BABYRATE { get; set; }
        public decimal? SNGAMOUNT { get; set; }
        public decimal? DBLAMOUNT { get; set; }
        public decimal? TRPAMOUNT { get; set; }
        public decimal? QUADAMOUNT { get; set; }
        public decimal? CHDYAMOUNT { get; set; }
        public decimal? CHDEAMOUNT { get; set; }
        public decimal? BABYAMOUNT { get; set; }
        public short? BABY_MAXAGE { get; set; }
        public short? CHDY_MAXAGE { get; set; }
        public short? CHDE_MAXAGE { get; set; }
        public bool USE_MAXAGES { get; set; }
        public bool SHARE_NULLMARKET_TO_ALLMARKETS { get; set; }
        public bool USE_CAPACITY { get; set; }
        public int? MINBEDCOUNT { get; set; }
        public int? MAXBEDCOUNT { get; set; }
        public int? MINADULTCOUNT { get; set; }
        public int? MAXADULTCOUNT { get; set; }
        public int? MINCHILDCOUNT { get; set; }
        public int? MAXCHILDCOUNT { get; set; }
        public int? MINBABYCOUNT { get; set; }
        public int? MAXBABYCOUNT { get; set; }
        public byte BABYCOUNTS_INC_TO_BEDS { get; set; }
        public double? ADULT_RATE { get; set; }
        public double? CHILD_RATE { get; set; }
        public double? BABY_RATE { get; set; }

        public virtual STDHOTEL_BOARDTYPES BOARDTYPE { get; set; } = null!;
        public virtual CORP CORP { get; set; } = null!;
        public virtual STDHOTEL HOTEL { get; set; } = null!;
        public virtual STDHOTEL_MARKET? MARKET { get; set; }
        public virtual STDHOTEL_RATETYPE RATETYPE { get; set; } = null!;
        public virtual STDHOTEL_ROOMTYPES ROOMTYPE { get; set; } = null!;
        public virtual ICollection<HOTEL_RESERVATION_DETAILS> HOTEL_RESERVATION_DETAILS { get; set; }
        public virtual ICollection<REQUEST_DETAIL> REQUEST_DETAIL { get; set; }
        public virtual ICollection<STDHOTEL_PRICECONDITION_CALENDAR> STDHOTEL_PRICECONDITION_CALENDAR { get; set; }
        public virtual ICollection<STDHOTEL_PRICECONDITION_OCCUPANCY> STDHOTEL_PRICECONDITION_OCCUPANCY { get; set; }
        public virtual ICollection<STDHOTEL_RATECODE_DETAIL> STDHOTEL_RATECODE_DETAIL { get; set; }
        public virtual ICollection<STDHOTEL_STOPSALE> STDHOTEL_STOPSALE { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
