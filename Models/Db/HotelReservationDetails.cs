using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class HotelReservationDetails : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid? Resid { get; set; }
        public int Tempid { get; set; }
        public DateTime? Date { get; set; }
        public Guid? Combid { get; set; }
        public string? Dayofweek { get; set; }
        public int? Remainingquota { get; set; }
        public byte? Fixprice { get; set; }
        public decimal? Costprice { get; set; }
        public decimal? Guestprice { get; set; }
        public decimal? Finalprice { get; set; }
        public decimal? Finalcost { get; set; }
        public string? Pricedebuginfo { get; set; }
        public Guid? Ratecodedetailid { get; set; }
        public int? Pricesort { get; set; }
        public bool? StopCheckin { get; set; }
        public bool? StopCheckout { get; set; }
        public bool? StopSell { get; set; }
        public int? Quota { get; set; }
        public string? Avail { get; set; }
        public int? Minlos { get; set; }
        public int? Maxlos { get; set; }
        public int? Adult { get; set; }
        public int? Chde { get; set; }
        public int? Chdy { get; set; }
        public int? Baby { get; set; }
        public double? D1 { get; set; }
        public Guid? Did1 { get; set; }
        public byte? Dt1 { get; set; }
        public double? Damt1 { get; set; }
        public string? Dexp1 { get; set; }
        public bool? Daln1 { get; set; }
        public byte? Dat1 { get; set; }
        public double? D2 { get; set; }
        public Guid? Did2 { get; set; }
        public byte? Dt2 { get; set; }
        public double? Damt2 { get; set; }
        public string? Dexp2 { get; set; }
        public bool? Daln2 { get; set; }
        public byte? Dat2 { get; set; }
        public double? D3 { get; set; }
        public Guid? Did3 { get; set; }
        public byte? Dt3 { get; set; }
        public double? Damt3 { get; set; }
        public string? Dexp3 { get; set; }
        public bool? Daln3 { get; set; }
        public byte? Dat3 { get; set; }
        public double? D4 { get; set; }
        public Guid? Did4 { get; set; }
        public byte? Dt4 { get; set; }
        public double? Damt4 { get; set; }
        public string? Dexp4 { get; set; }
        public bool? Daln4 { get; set; }
        public byte? Dat4 { get; set; }
        public double? D5 { get; set; }
        public Guid? Did5 { get; set; }
        public byte? Dt5 { get; set; }
        public double? Damt5 { get; set; }
        public string? Dexp5 { get; set; }
        public bool? Daln5 { get; set; }
        public byte? Dat5 { get; set; }
        public Guid? Ratecodeid { get; set; }

        public virtual StdhotelPricecondition? Comb { get; set; }
        public virtual StdhotelRatecode? Ratecode { get; set; }
        public virtual HotelReservations? Res { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
