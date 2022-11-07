using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class VW_BASKET_INFO : EntityBase // My Handlebars Helper
    {
        public Guid REQUESTDETAILID { get; set; }
        public Guid? REQUESTID { get; set; }
        public string? THUMBNAILURL { get; set; }
        public string? PRODUCTNAME { get; set; }
        public string? COUNTRY { get; set; }
        public string? CITY { get; set; }
        public double? STARS { get; set; }
        public DateTime? DATE1 { get; set; }
        public DateTime? DATE2 { get; set; }
        public int? ROOMCOUNT { get; set; }
        public int? ADULT { get; set; }
        public int? CHDE { get; set; }
        public int? CHDY { get; set; }
        public int? BABY { get; set; }
        public string? RATETYPE { get; set; }
        public string? BOARDTYPE { get; set; }
        public string? ROOMTYPE { get; set; }
        public double? DISCOUNT_RATE { get; set; }
        public byte? DISCOUNT_REQ { get; set; }
        public byte? DISCOUNT_RESULT { get; set; }
        public Guid? PROMOTIONID { get; set; }
        public string? PROMOTIONCODE { get; set; }
        public string? PROMOTION { get; set; }
        public double? EXTRA_TOTAL { get; set; }
        public double? TOTAL { get; set; }
        public double? GRAND_TOTAL { get; set; }
        public string? CURCODE { get; set; }
        public double? D_GRAND_TOTAL { get; set; }
        public string? REQ_CURCODE { get; set; }
        public DateTime CHECKINTIME { get; set; }
        public DateTime CHECKOUTTIME { get; set; }
        public double? TOTAL_PAYMENTS { get; set; }
        public Guid? PROJECT_DETAILID { get; set; }
        public Guid? HOTELID { get; set; }
        public bool? PAY_AT_PLACE { get; set; }
        public short? BABY_MAXAGE { get; set; }
        public short? CHDE_MAXAGE { get; set; }
        public short? CHDY_MAXAGE { get; set; }
        public Guid? STATUS { get; set; }
        public Guid? SUBSTATUS { get; set; }
        public Guid? MARKETID { get; set; }
        public Guid? RATECODEID { get; set; }
        public double? CANCELATION_RATE { get; set; }
        public int? CANCELATION_DAYS { get; set; }
        public double? PAYMENT_RATE { get; set; }
        public double CANCELLATION_WARRANTY_RATE { get; set; }
        public bool? MEN_ACCOMMODATION_FORBIDDEN { get; set; }
        public Guid? FROMLOCATIONID { get; set; }
        public Guid? TOLOCATIONID { get; set; }
        public bool ROUNDTRIP { get; set; }
        public Guid? TRANSFER_PRICEID { get; set; }
        public Guid? VEHICLEID { get; set; }
        public string? FROMLOC { get; set; }
        public string? TOLOC { get; set; }
        public string? VEHICLETYPE { get; set; }
        public string? VEHICLE { get; set; }
        public int? VEHICLE_PERSON_COUNT { get; set; }
        public string? SPECIAL_CODE { get; set; }
        public Guid? ROOMTYPEID { get; set; }
        public Guid? BOARDTYPEID { get; set; }
        public Guid? RATETYPEID { get; set; }
        public Guid? RESERVATION_SETTINGSID { get; set; }
        public bool? ALLOW_SINGLE_MEN { get; set; }
        public Guid? CORRELATIONID { get; set; }
        public string? PNR1 { get; set; }
        public string? PNR2 { get; set; }
        public DateTime? VALIDDATE { get; set; }
        public int VALIDDAY { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
