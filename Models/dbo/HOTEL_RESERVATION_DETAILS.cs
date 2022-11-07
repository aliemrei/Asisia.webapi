using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class HOTEL_RESERVATION_DETAILS : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid? RESID { get; set; }
        public int TEMPID { get; set; }
        public DateTime? DATE { get; set; }
        public Guid? COMBID { get; set; }
        public string? DAYOFWEEK { get; set; }
        public int? REMAININGQUOTA { get; set; }
        public byte? FIXPRICE { get; set; }
        public decimal? COSTPRICE { get; set; }
        public decimal? GUESTPRICE { get; set; }
        public decimal? FINALPRICE { get; set; }
        public decimal? FINALCOST { get; set; }
        public string? PRICEDEBUGINFO { get; set; }
        public Guid? RATECODEDETAILID { get; set; }
        public int? PRICESORT { get; set; }
        public bool? STOP_CHECKIN { get; set; }
        public bool? STOP_CHECKOUT { get; set; }
        public bool? STOP_SELL { get; set; }
        public int? QUOTA { get; set; }
        public string? AVAIL { get; set; }
        public int? MINLOS { get; set; }
        public int? MAXLOS { get; set; }
        public int? ADULT { get; set; }
        public int? CHDE { get; set; }
        public int? CHDY { get; set; }
        public int? BABY { get; set; }
        public double? D1 { get; set; }
        public Guid? DID1 { get; set; }
        public byte? DT1 { get; set; }
        public double? DAMT1 { get; set; }
        public string? DEXP1 { get; set; }
        public bool? DALN1 { get; set; }
        public byte? DAT1 { get; set; }
        public double? D2 { get; set; }
        public Guid? DID2 { get; set; }
        public byte? DT2 { get; set; }
        public double? DAMT2 { get; set; }
        public string? DEXP2 { get; set; }
        public bool? DALN2 { get; set; }
        public byte? DAT2 { get; set; }
        public double? D3 { get; set; }
        public Guid? DID3 { get; set; }
        public byte? DT3 { get; set; }
        public double? DAMT3 { get; set; }
        public string? DEXP3 { get; set; }
        public bool? DALN3 { get; set; }
        public byte? DAT3 { get; set; }
        public double? D4 { get; set; }
        public Guid? DID4 { get; set; }
        public byte? DT4 { get; set; }
        public double? DAMT4 { get; set; }
        public string? DEXP4 { get; set; }
        public bool? DALN4 { get; set; }
        public byte? DAT4 { get; set; }
        public double? D5 { get; set; }
        public Guid? DID5 { get; set; }
        public byte? DT5 { get; set; }
        public double? DAMT5 { get; set; }
        public string? DEXP5 { get; set; }
        public bool? DALN5 { get; set; }
        public byte? DAT5 { get; set; }
        public Guid? RATECODEID { get; set; }

        public virtual STDHOTEL_PRICECONDITION? COMB { get; set; }
        public virtual STDHOTEL_RATECODE? RATECODE { get; set; }
        public virtual HOTEL_RESERVATIONS? RES { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
