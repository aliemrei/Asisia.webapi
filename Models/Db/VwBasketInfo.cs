using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class VwBasketInfo : EntityBase // My Handlebars Helper
    {
        public Guid Requestdetailid { get; set; }
        public Guid? Requestid { get; set; }
        public string? Thumbnailurl { get; set; }
        public string? Productname { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public double? Stars { get; set; }
        public DateTime? Date1 { get; set; }
        public DateTime? Date2 { get; set; }
        public int? Roomcount { get; set; }
        public int? Adult { get; set; }
        public int? Chde { get; set; }
        public int? Chdy { get; set; }
        public int? Baby { get; set; }
        public string? Ratetype { get; set; }
        public string? Boardtype { get; set; }
        public string? Roomtype { get; set; }
        public double? DiscountRate { get; set; }
        public byte? DiscountReq { get; set; }
        public byte? DiscountResult { get; set; }
        public Guid? Promotionid { get; set; }
        public string? Promotioncode { get; set; }
        public string? Promotion { get; set; }
        public double? ExtraTotal { get; set; }
        public double? Total { get; set; }
        public double? GrandTotal { get; set; }
        public string? Curcode { get; set; }
        public double? DGrandTotal { get; set; }
        public string? ReqCurcode { get; set; }
        public DateTime Checkintime { get; set; }
        public DateTime Checkouttime { get; set; }
        public double? TotalPayments { get; set; }
        public Guid? ProjectDetailid { get; set; }
        public Guid? Hotelid { get; set; }
        public bool? PayAtPlace { get; set; }
        public short? BabyMaxage { get; set; }
        public short? ChdeMaxage { get; set; }
        public short? ChdyMaxage { get; set; }
        public Guid? Status { get; set; }
        public Guid? Substatus { get; set; }
        public Guid? Marketid { get; set; }
        public Guid? Ratecodeid { get; set; }
        public double? CancelationRate { get; set; }
        public int? CancelationDays { get; set; }
        public double? PaymentRate { get; set; }
        public double CancellationWarrantyRate { get; set; }
        public bool? MenAccommodationForbidden { get; set; }
        public Guid? Fromlocationid { get; set; }
        public Guid? Tolocationid { get; set; }
        public bool Roundtrip { get; set; }
        public Guid? TransferPriceid { get; set; }
        public Guid? Vehicleid { get; set; }
        public string? Fromloc { get; set; }
        public string? Toloc { get; set; }
        public string? Vehicletype { get; set; }
        public string? Vehicle { get; set; }
        public int? VehiclePersonCount { get; set; }
        public string? SpecialCode { get; set; }
        public Guid? Roomtypeid { get; set; }
        public Guid? Boardtypeid { get; set; }
        public Guid? Ratetypeid { get; set; }
        public Guid? ReservationSettingsid { get; set; }
        public bool? AllowSingleMen { get; set; }
        public Guid? Correlationid { get; set; }
        public string? Pnr1 { get; set; }
        public string? Pnr2 { get; set; }
        public DateTime? Validdate { get; set; }
        public int Validday { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
