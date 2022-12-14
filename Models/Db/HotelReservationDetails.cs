using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("HOTEL_RESERVATION_DETAILS")]
    [Index(nameof(Id), Name = "IX_HOTEL_RESERVATION_DETAILS")]
    [Index(nameof(Resid), Name = "IX_MISS_HOTELSEARCH_2")]
    public partial class HotelReservationDetails : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("RESID")]
        
        public Guid? Resid { get; set; }


        [Column("TEMPID")]
        [RequiredIf]
        public int Tempid { get; set; }


        [Column("DATE", TypeName = "date")]
        
        public DateTime? Date { get; set; }


        [Column("COMBID")]
        
        public Guid? Combid { get; set; }


        [Column("DAYOFWEEK")]
        [StringLength(1)]
        [Unicode(false)]
        
        public string? Dayofweek { get; set; }


        [Column("REMAININGQUOTA")]
        
        public int? Remainingquota { get; set; }


        [Column("FIXPRICE")]
        
        public byte? Fixprice { get; set; }


        [Column("COSTPRICE", TypeName = "decimal(19, 2)")]
        
        public decimal? Costprice { get; set; }


        [Column("GUESTPRICE", TypeName = "decimal(19, 2)")]
        
        public decimal? Guestprice { get; set; }


        [Column("FINALPRICE", TypeName = "decimal(19, 2)")]
        
        public decimal? Finalprice { get; set; }


        [Column("FINALCOST", TypeName = "decimal(19, 2)")]
        
        public decimal? Finalcost { get; set; }


        [Column("PRICEDEBUGINFO")]
        [StringLength(100)]
        
        public string? Pricedebuginfo { get; set; }


        [Column("RATECODEDETAILID")]
        
        public Guid? Ratecodedetailid { get; set; }


        [Column("PRICESORT")]
        
        public int? Pricesort { get; set; }


        [Column("STOP_CHECKIN")]
        
        public bool? StopCheckin { get; set; }


        [Column("STOP_CHECKOUT")]
        
        public bool? StopCheckout { get; set; }


        [Column("STOP_SELL")]
        
        public bool? StopSell { get; set; }


        [Column("QUOTA")]
        
        public int? Quota { get; set; }


        [Column("AVAIL")]
        [StringLength(150)]
        
        public string? Avail { get; set; }


        [Column("MINLOS")]
        
        public int? Minlos { get; set; }


        [Column("MAXLOS")]
        
        public int? Maxlos { get; set; }


        [Column("ADULT")]
        
        public int? Adult { get; set; }


        [Column("CHDE")]
        
        public int? Chde { get; set; }


        [Column("CHDY")]
        
        public int? Chdy { get; set; }


        [Column("BABY")]
        
        public int? Baby { get; set; }


        
        public double? D1 { get; set; }


        [Column("DID1")]
        
        public Guid? Did1 { get; set; }


        [Column("DT1")]
        
        public byte? Dt1 { get; set; }


        [Column("DAMT1")]
        
        public double? Damt1 { get; set; }


        [Column("DEXP1")]
        [StringLength(50)]
        
        public string? Dexp1 { get; set; }


        [Column("DALN1")]
        
        public bool? Daln1 { get; set; }


        [Column("DAT1")]
        
        public byte? Dat1 { get; set; }


        
        public double? D2 { get; set; }


        [Column("DID2")]
        
        public Guid? Did2 { get; set; }


        [Column("DT2")]
        
        public byte? Dt2 { get; set; }


        [Column("DAMT2")]
        
        public double? Damt2 { get; set; }


        [Column("DEXP2")]
        [StringLength(50)]
        
        public string? Dexp2 { get; set; }


        [Column("DALN2")]
        
        public bool? Daln2 { get; set; }


        [Column("DAT2")]
        
        public byte? Dat2 { get; set; }


        
        public double? D3 { get; set; }


        [Column("DID3")]
        
        public Guid? Did3 { get; set; }


        [Column("DT3")]
        
        public byte? Dt3 { get; set; }


        [Column("DAMT3")]
        
        public double? Damt3 { get; set; }


        [Column("DEXP3")]
        [StringLength(50)]
        
        public string? Dexp3 { get; set; }


        [Column("DALN3")]
        
        public bool? Daln3 { get; set; }


        [Column("DAT3")]
        
        public byte? Dat3 { get; set; }


        
        public double? D4 { get; set; }


        [Column("DID4")]
        
        public Guid? Did4 { get; set; }


        [Column("DT4")]
        
        public byte? Dt4 { get; set; }


        [Column("DAMT4")]
        
        public double? Damt4 { get; set; }


        [Column("DEXP4")]
        [StringLength(50)]
        
        public string? Dexp4 { get; set; }


        [Column("DALN4")]
        
        public bool? Daln4 { get; set; }


        [Column("DAT4")]
        
        public byte? Dat4 { get; set; }


        
        public double? D5 { get; set; }


        [Column("DID5")]
        
        public Guid? Did5 { get; set; }


        [Column("DT5")]
        
        public byte? Dt5 { get; set; }


        [Column("DAMT5")]
        
        public double? Damt5 { get; set; }


        [Column("DEXP5")]
        [StringLength(50)]
        
        public string? Dexp5 { get; set; }


        [Column("DALN5")]
        
        public bool? Daln5 { get; set; }


        [Column("DAT5")]
        
        public byte? Dat5 { get; set; }


        [Column("RATECODEID")]
        
        public Guid? Ratecodeid { get; set; }



        [ForeignKey(nameof(Combid))]
        [InverseProperty(nameof(StdhotelPricecondition.HotelReservationDetails))]
        public virtual StdhotelPricecondition? Comb { get; set; }
        [ForeignKey(nameof(Ratecodeid))]
        [InverseProperty(nameof(StdhotelRatecode.HotelReservationDetails))]
        public virtual StdhotelRatecode? Ratecode { get; set; }
        [ForeignKey(nameof(Resid))]
        [InverseProperty(nameof(HotelReservations.HotelReservationDetails))]
        public virtual HotelReservations? Res { get; set; }

            }
}
