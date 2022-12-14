using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class VwBasketInfo : EntityBase 
    {
        [Column("REQUESTDETAILID")]
        [RequiredIf]
        public Guid Requestdetailid { get; set; }


        [Column("REQUESTID")]
        
        public Guid? Requestid { get; set; }


        [Column("THUMBNAILURL")]
        [StringLength(350)]
        
        public string? Thumbnailurl { get; set; }


        [Column("PRODUCTNAME")]
        [StringLength(200)]
        
        public string? Productname { get; set; }


        [Column("COUNTRY")]
        [StringLength(70)]
        
        public string? Country { get; set; }


        [Column("CITY")]
        [StringLength(70)]
        
        public string? City { get; set; }


        [Column("STARS")]
        
        public double? Stars { get; set; }


        [Column("DATE1", TypeName = "datetime")]
        
        public DateTime? Date1 { get; set; }


        [Column("DATE2", TypeName = "datetime")]
        
        public DateTime? Date2 { get; set; }


        [Column("ROOMCOUNT")]
        
        public int? Roomcount { get; set; }


        [Column("ADULT")]
        
        public int? Adult { get; set; }


        [Column("CHDE")]
        
        public int? Chde { get; set; }


        [Column("CHDY")]
        
        public int? Chdy { get; set; }


        [Column("BABY")]
        
        public int? Baby { get; set; }


        [Column("RATETYPE")]
        [StringLength(50)]
        
        public string? Ratetype { get; set; }


        [Column("BOARDTYPE")]
        [StringLength(25)]
        
        public string? Boardtype { get; set; }


        [Column("ROOMTYPE")]
        [StringLength(50)]
        
        public string? Roomtype { get; set; }


        [Column("DISCOUNT_RATE")]
        
        public double? DiscountRate { get; set; }


        [Column("DISCOUNT_REQ")]
        
        public byte? DiscountReq { get; set; }


        [Column("DISCOUNT_RESULT")]
        
        public byte? DiscountResult { get; set; }


        [Column("PROMOTIONID")]
        
        public Guid? Promotionid { get; set; }


        [Column("PROMOTIONCODE")]
        [StringLength(255)]
        
        public string? Promotioncode { get; set; }


        [Column("PROMOTION")]
        [StringLength(150)]
        
        public string? Promotion { get; set; }


        [Column("EXTRA_TOTAL")]
        
        public double? ExtraTotal { get; set; }


        [Column("TOTAL")]
        
        public double? Total { get; set; }


        [Column("GRAND_TOTAL")]
        
        public double? GrandTotal { get; set; }


        [Column("CURCODE")]
        [StringLength(4)]
        [Unicode(false)]
        
        public string? Curcode { get; set; }


        [Column("D_GRAND_TOTAL")]
        
        public double? DGrandTotal { get; set; }


        [Column("REQ_CURCODE")]
        [StringLength(5)]
        [Unicode(false)]
        
        public string? ReqCurcode { get; set; }


        [Column("CHECKINTIME", TypeName = "datetime")]
        [RequiredIf]
        public DateTime Checkintime { get; set; }


        [Column("CHECKOUTTIME", TypeName = "datetime")]
        [RequiredIf]
        public DateTime Checkouttime { get; set; }


        [Column("TOTAL_PAYMENTS")]
        
        public double? TotalPayments { get; set; }


        [Column("PROJECT_DETAILID")]
        
        public Guid? ProjectDetailid { get; set; }


        [Column("HOTELID")]
        
        public Guid? Hotelid { get; set; }


        [Column("PAY_AT_PLACE")]
        
        public bool? PayAtPlace { get; set; }


        [Column("BABY_MAXAGE")]
        
        public short? BabyMaxage { get; set; }


        [Column("CHDE_MAXAGE")]
        
        public short? ChdeMaxage { get; set; }


        [Column("CHDY_MAXAGE")]
        
        public short? ChdyMaxage { get; set; }


        [Column("STATUS")]
        
        public Guid? Status { get; set; }


        [Column("SUBSTATUS")]
        
        public Guid? Substatus { get; set; }


        [Column("MARKETID")]
        
        public Guid? Marketid { get; set; }


        [Column("RATECODEID")]
        
        public Guid? Ratecodeid { get; set; }


        [Column("CANCELATION_RATE")]
        
        public double? CancelationRate { get; set; }


        [Column("CANCELATION_DAYS")]
        
        public int? CancelationDays { get; set; }


        [Column("PAYMENT_RATE")]
        
        public double? PaymentRate { get; set; }


        [Column("CANCELLATION_WARRANTY_RATE")]
        [RequiredIf]
        public double CancellationWarrantyRate { get; set; }


        [Column("MEN_ACCOMMODATION_FORBIDDEN")]
        
        public bool? MenAccommodationForbidden { get; set; }


        [Column("FROMLOCATIONID")]
        
        public Guid? Fromlocationid { get; set; }


        [Column("TOLOCATIONID")]
        
        public Guid? Tolocationid { get; set; }


        [Column("ROUNDTRIP")]
        [RequiredIf]
        public bool Roundtrip { get; set; }


        [Column("TRANSFER_PRICEID")]
        
        public Guid? TransferPriceid { get; set; }


        [Column("VEHICLEID")]
        
        public Guid? Vehicleid { get; set; }


        [Column("FROMLOC")]
        [StringLength(170)]
        
        public string? Fromloc { get; set; }


        [Column("TOLOC")]
        [StringLength(170)]
        
        public string? Toloc { get; set; }


        [Column("VEHICLETYPE")]
        [StringLength(40)]
        
        public string? Vehicletype { get; set; }


        [Column("VEHICLE")]
        [StringLength(70)]
        
        public string? Vehicle { get; set; }


        [Column("VEHICLE_PERSON_COUNT")]
        
        public int? VehiclePersonCount { get; set; }


        [Column("SPECIAL_CODE")]
        [StringLength(15)]
        
        public string? SpecialCode { get; set; }


        [Column("ROOMTYPEID")]
        
        public Guid? Roomtypeid { get; set; }


        [Column("BOARDTYPEID")]
        
        public Guid? Boardtypeid { get; set; }


        [Column("RATETYPEID")]
        
        public Guid? Ratetypeid { get; set; }


        [Column("RESERVATION_SETTINGSID")]
        
        public Guid? ReservationSettingsid { get; set; }


        [Column("ALLOW_SINGLE_MEN")]
        
        public bool? AllowSingleMen { get; set; }


        [Column("CORRELATIONID")]
        
        public Guid? Correlationid { get; set; }


        [Column("PNR1")]
        [StringLength(15)]
        
        public string? Pnr1 { get; set; }


        [Column("PNR2")]
        [StringLength(15)]
        
        public string? Pnr2 { get; set; }


        [Column("VALIDDATE", TypeName = "datetime")]
        
        public DateTime? Validdate { get; set; }


        [Column("VALIDDAY")]
        [RequiredIf]
        public int Validday { get; set; }



            }
}
