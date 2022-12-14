using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDHOTEL_PRICECONDITION")]
    [Index(nameof(Ratetypeid), nameof(Boardtypeid), nameof(Roomtypeid), nameof(Marketid), nameof(Curcode), Name = "IX_STDHOTEL_PRICECONDITION", IsUnique = true)]
    [Index(nameof(Id), Name = "UQ__STDHOTEL__3214EC261CABA467", IsUnique = true)]
    public partial class StdhotelPricecondition : EntityBase 
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

        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("HOTELID")]
        [RequiredIf]
        public Guid Hotelid { get; set; }


        [Column("DEFINITION")]
        [StringLength(150)]
        [RequiredIf]
        public string Definition { get; set; } = null!;


        [Column("CURCODE")]
        [StringLength(4)]
        [Unicode(false)]
        [RequiredIf]
        public string Curcode { get; set; } = null!;


        [Column("ROOMTYPEID")]
        [RequiredIf]
        public Guid Roomtypeid { get; set; }


        [Column("BOARDTYPEID")]
        [RequiredIf]
        public Guid Boardtypeid { get; set; }


        [Column("RATETYPEID")]
        [RequiredIf]
        public Guid Ratetypeid { get; set; }


        [Column("MARKETID")]
        
        public Guid? Marketid { get; set; }


        [Column("CORPID")]
        [RequiredIf]
        public Guid Corpid { get; set; }


        [Column("SNGRATE")]
        
        public double? Sngrate { get; set; }


        [Column("DBLRATE")]
        
        public double? Dblrate { get; set; }


        [Column("TRPRATE")]
        
        public double? Trprate { get; set; }


        [Column("QUADRATE")]
        
        public double? Quadrate { get; set; }


        [Column("CHDYRATE")]
        
        public double? Chdyrate { get; set; }


        [Column("CHDERATE")]
        
        public double? Chderate { get; set; }


        [Column("BABYRATE")]
        
        public double? Babyrate { get; set; }


        [Column("SNGAMOUNT", TypeName = "decimal(19, 2)")]
        
        public decimal? Sngamount { get; set; }


        [Column("DBLAMOUNT", TypeName = "decimal(19, 2)")]
        
        public decimal? Dblamount { get; set; }


        [Column("TRPAMOUNT", TypeName = "decimal(19, 2)")]
        
        public decimal? Trpamount { get; set; }


        [Column("QUADAMOUNT", TypeName = "decimal(19, 2)")]
        
        public decimal? Quadamount { get; set; }


        [Column("CHDYAMOUNT", TypeName = "decimal(19, 2)")]
        
        public decimal? Chdyamount { get; set; }


        [Column("CHDEAMOUNT", TypeName = "decimal(19, 2)")]
        
        public decimal? Chdeamount { get; set; }


        [Column("BABYAMOUNT", TypeName = "decimal(19, 2)")]
        
        public decimal? Babyamount { get; set; }


        [Column("BABY_MAXAGE")]
        
        public short? BabyMaxage { get; set; }


        [Column("CHDY_MAXAGE")]
        
        public short? ChdyMaxage { get; set; }


        [Column("CHDE_MAXAGE")]
        
        public short? ChdeMaxage { get; set; }


        [Column("USE_MAXAGES")]
        [RequiredIf]
        public bool UseMaxages { get; set; }


        [Column("SHARE_NULLMARKET_TO_ALLMARKETS")]
        [RequiredIf]
        public bool ShareNullmarketToAllmarkets { get; set; }


        [Column("USE_CAPACITY")]
        [RequiredIf]
        public bool UseCapacity { get; set; }


        [Column("MINBEDCOUNT")]
        
        public int? Minbedcount { get; set; }


        [Column("MAXBEDCOUNT")]
        
        public int? Maxbedcount { get; set; }


        [Column("MINADULTCOUNT")]
        
        public int? Minadultcount { get; set; }


        [Column("MAXADULTCOUNT")]
        
        public int? Maxadultcount { get; set; }


        [Column("MINCHILDCOUNT")]
        
        public int? Minchildcount { get; set; }


        [Column("MAXCHILDCOUNT")]
        
        public int? Maxchildcount { get; set; }


        [Column("MINBABYCOUNT")]
        
        public int? Minbabycount { get; set; }


        [Column("MAXBABYCOUNT")]
        
        public int? Maxbabycount { get; set; }


        [Column("BABYCOUNTS_INC_TO_BEDS")]
        [RequiredIf]
        public byte BabycountsIncToBeds { get; set; }


        [Column("ADULT_RATE")]
        
        public double? AdultRate { get; set; }


        [Column("CHILD_RATE")]
        
        public double? ChildRate { get; set; }


        [Column("BABY_RATE")]
        
        public double? BabyRate1 { get; set; }



        [ForeignKey(nameof(Boardtypeid))]
        [InverseProperty(nameof(StdhotelBoardtypes.StdhotelPricecondition))]
        public virtual StdhotelBoardtypes Boardtype { get; set; } = null!;
        [ForeignKey(nameof(Corpid))]
        [InverseProperty("StdhotelPricecondition")]
        public virtual Corp Corp { get; set; } = null!;
        [ForeignKey(nameof(Hotelid))]
        [InverseProperty(nameof(Stdhotel.StdhotelPricecondition))]
        public virtual Stdhotel Hotel { get; set; } = null!;
        [ForeignKey(nameof(Marketid))]
        [InverseProperty(nameof(StdhotelMarket.StdhotelPricecondition))]
        public virtual StdhotelMarket? Market { get; set; }
        [ForeignKey(nameof(Ratetypeid))]
        [InverseProperty(nameof(StdhotelRatetype.StdhotelPricecondition))]
        public virtual StdhotelRatetype Ratetype { get; set; } = null!;
        [ForeignKey(nameof(Roomtypeid))]
        [InverseProperty(nameof(StdhotelRoomtypes.StdhotelPricecondition))]
        public virtual StdhotelRoomtypes Roomtype { get; set; } = null!;
        [InverseProperty("Comb")]
        public virtual ICollection<HotelReservationDetails> HotelReservationDetails { get; set; }
        [InverseProperty("PriceCondition")]
        public virtual ICollection<RequestDetail> RequestDetail { get; set; }
        [InverseProperty("Pricecondition")]
        public virtual ICollection<StdhotelPriceconditionCalendar> StdhotelPriceconditionCalendar { get; set; }
        [InverseProperty("Pricecondition")]
        public virtual ICollection<StdhotelPriceconditionOccupancy> StdhotelPriceconditionOccupancy { get; set; }
        [InverseProperty("Pricecondition")]
        public virtual ICollection<StdhotelRatecodeDetail> StdhotelRatecodeDetail { get; set; }
        [InverseProperty("Pricecondition")]
        public virtual ICollection<StdhotelStopsale> StdhotelStopsale { get; set; }

            }
}
