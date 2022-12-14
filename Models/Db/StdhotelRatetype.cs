using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDHOTEL_RATETYPE")]
    [Index(nameof(Id), Name = "UQ__STDHOTEL__3214EC26E6CD802C", IsUnique = true)]
    public partial class StdhotelRatetype : EntityBase 
    {
        public StdhotelRatetype()
        {
            PropertyMapping = new HashSet<PropertyMapping>();
            RequestDetail = new HashSet<RequestDetail>();
            StdhotelPricecondition = new HashSet<StdhotelPricecondition>();
            StdhotelRatecodeDiscountRatetype = new HashSet<StdhotelRatecodeDiscountRatetype>();
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


        [Column("ISREFUNDABLE")]
        [RequiredIf]
        public bool Isrefundable { get; set; }


        [Column("ENT_ID")]
        
        public int? EntId { get; set; }


        [Column("USEONLINE")]
        [RequiredIf]
        public byte Useonline { get; set; }


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


        [Column("REFUND_DAY")]
        
        public int? RefundDay { get; set; }


        [Column("REFUND_LASTTIME")]
        
        public TimeSpan? RefundLasttime { get; set; }



        [ForeignKey(nameof(Hotelid))]
        [InverseProperty(nameof(Stdhotel.StdhotelRatetype))]
        public virtual Stdhotel Hotel { get; set; } = null!;
        [InverseProperty("Ratetype")]
        public virtual ICollection<PropertyMapping> PropertyMapping { get; set; }
        [InverseProperty("Ratetype")]
        public virtual ICollection<RequestDetail> RequestDetail { get; set; }
        [InverseProperty("Ratetype")]
        public virtual ICollection<StdhotelPricecondition> StdhotelPricecondition { get; set; }
        [InverseProperty("Ratetype")]
        public virtual ICollection<StdhotelRatecodeDiscountRatetype> StdhotelRatecodeDiscountRatetype { get; set; }

            }
}
