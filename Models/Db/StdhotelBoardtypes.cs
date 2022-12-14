using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDHOTEL_BOARDTYPES")]
    public partial class StdhotelBoardtypes : EntityBase 
    {
        public StdhotelBoardtypes()
        {
            PropertyMapping = new HashSet<PropertyMapping>();
            RequestDetail = new HashSet<RequestDetail>();
            StdhotelPricecondition = new HashSet<StdhotelPricecondition>();
        }

        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("BOARDTYPE")]
        [StringLength(10)]
        [RequiredIf]
        public string Boardtype { get; set; } = null!;


        [Column("HOTELID")]
        [RequiredIf]
        public Guid Hotelid { get; set; }


        [Column("DEFINITION")]
        [StringLength(25)]
        
        public string? Definition { get; set; }


        [Column("ENT_ID")]
        [StringLength(25)]
        
        public string? EntId { get; set; }


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



        [ForeignKey(nameof(Boardtype))]
        [InverseProperty(nameof(Stdboardtypes.StdhotelBoardtypes))]
        public virtual Stdboardtypes BoardtypeNavigation { get; set; } = null!;
        [ForeignKey(nameof(Hotelid))]
        [InverseProperty(nameof(Stdhotel.StdhotelBoardtypes))]
        public virtual Stdhotel Hotel { get; set; } = null!;
        [InverseProperty("Boardtype")]
        public virtual ICollection<PropertyMapping> PropertyMapping { get; set; }
        [InverseProperty("BoardtypeNavigation")]
        public virtual ICollection<RequestDetail> RequestDetail { get; set; }
        [InverseProperty("Boardtype")]
        public virtual ICollection<StdhotelPricecondition> StdhotelPricecondition { get; set; }

            }
}
