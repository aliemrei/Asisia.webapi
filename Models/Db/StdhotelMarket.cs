using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDHOTEL_MARKET")]
    [Index(nameof(Id), Name = "UQ__STDHOTEL__3214EC26A7DB71ED", IsUnique = true)]
    public partial class StdhotelMarket : EntityBase 
    {
        public StdhotelMarket()
        {
            RequestDetail = new HashSet<RequestDetail>();
            ReservationSettingsMarket = new HashSet<ReservationSettingsMarket>();
            StdhotelPricecondition = new HashSet<StdhotelPricecondition>();
            StdhotelRatecodeDiscountMarket = new HashSet<StdhotelRatecodeDiscountMarket>();
            StdhotelRatecodeMarkupMarkets = new HashSet<StdhotelRatecodeMarkupMarkets>();
        }

        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("HOTELID")]
        [RequiredIf]
        public Guid Hotelid { get; set; }


        [Column("DEFINITION")]
        [StringLength(50)]
        [RequiredIf]
        public string Definition { get; set; } = null!;


        [Column("ENT_ID")]
        [StringLength(25)]
        
        public string? EntId { get; set; }


        [Column("STDMARKETID")]
        
        public Guid? Stdmarketid { get; set; }


        [Column("ENT_ETSID")]
        [StringLength(50)]
        
        public string? EntEtsid { get; set; }


        [Column("ENT_TOURISTICAID")]
        [StringLength(50)]
        
        public string? EntTouristicaid { get; set; }


        [Column("ENT_TATILBUDURID")]
        [StringLength(50)]
        
        public string? EntTatilbudurid { get; set; }


        [Column("ENT_IATIID")]
        [StringLength(50)]
        
        public string? EntIatiid { get; set; }


        [Column("ENT_TRAVELCLICKID")]
        [StringLength(50)]
        
        public string? EntTravelclickid { get; set; }


        [Column("ENT_JOLLYTOURID")]
        [StringLength(150)]
        
        public string? EntJollytourid { get; set; }


        [Column("ENT_SEDNAID")]
        [StringLength(250)]
        
        public string? EntSednaid { get; set; }


        [Column("ENT_HOTELRUNNERID")]
        [StringLength(100)]
        
        public string? EntHotelrunnerid { get; set; }


        [Column("ENT_SETURID")]
        [StringLength(150)]
        
        public string? EntSeturid { get; set; }



        [ForeignKey(nameof(Hotelid))]
        [InverseProperty(nameof(Stdhotel.StdhotelMarket))]
        public virtual Stdhotel Hotel { get; set; } = null!;
        [ForeignKey(nameof(Stdmarketid))]
        [InverseProperty(nameof(Stdmarkets.StdhotelMarket))]
        public virtual Stdmarkets? Stdmarket { get; set; }
        [InverseProperty("Market")]
        public virtual ICollection<RequestDetail> RequestDetail { get; set; }
        [InverseProperty("Market")]
        public virtual ICollection<ReservationSettingsMarket> ReservationSettingsMarket { get; set; }
        [InverseProperty("Market")]
        public virtual ICollection<StdhotelPricecondition> StdhotelPricecondition { get; set; }
        [InverseProperty("Market")]
        public virtual ICollection<StdhotelRatecodeDiscountMarket> StdhotelRatecodeDiscountMarket { get; set; }
        [InverseProperty("Market")]
        public virtual ICollection<StdhotelRatecodeMarkupMarkets> StdhotelRatecodeMarkupMarkets { get; set; }

            }
}
