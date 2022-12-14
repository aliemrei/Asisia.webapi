using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDHOTEL_RATECODE_DISCOUNT")]
    [Index(nameof(AdditionalDiscount), Name = "IX_STDHOTEL_RATECODE_DISCOUNT")]
    [Index(nameof(Sellfrom), nameof(Sellto), Name = "IX_STDHOTEL_RATECODE_DISCOUNT_1")]
    [Index(nameof(Stayfrom), nameof(Stayto), Name = "IX_STDHOTEL_RATECODE_DISCOUNT_2")]
    [Index(nameof(Id), Name = "UQ__STDHOTEL__3214EC267A852001", IsUnique = true)]
    public partial class StdhotelRatecodeDiscount : EntityBase 
    {
        public StdhotelRatecodeDiscount()
        {
            StdhotelRatecodeDiscountContract = new HashSet<StdhotelRatecodeDiscountContract>();
            StdhotelRatecodeDiscountMarket = new HashSet<StdhotelRatecodeDiscountMarket>();
            StdhotelRatecodeDiscountRatetype = new HashSet<StdhotelRatecodeDiscountRatetype>();
            StdhotelRatecodeDiscountRoomtype = new HashSet<StdhotelRatecodeDiscountRoomtype>();
        }

        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("HOTELID")]
        [RequiredIf]
        public Guid Hotelid { get; set; }


        [Column("RATECODEID")]
        [RequiredIf]
        public Guid Ratecodeid { get; set; }


        [Column("DEFINITION")]
        [StringLength(50)]
        
        public string? Definition { get; set; }


        [Column("BASICTYPE")]
        
        public byte? Basictype { get; set; }


        [Column("DISCOUNT")]
        [RequiredIf]
        public double Discount { get; set; }


        [Column("DISCOUNTTYPE")]
        [RequiredIf]
        public byte Discounttype { get; set; }


        [Column("APPLYALONE")]
        [RequiredIf]
        public bool Applyalone { get; set; }


        [Column("APPLYORDER")]
        [RequiredIf]
        public byte Applyorder { get; set; }


        [Column("SELLFROM", TypeName = "datetime")]
        
        public DateTime? Sellfrom { get; set; }


        [Column("SELLTO", TypeName = "datetime")]
        
        public DateTime? Sellto { get; set; }


        [Column("STAYFROM", TypeName = "datetime")]
        
        public DateTime? Stayfrom { get; set; }


        [Column("STAYTO", TypeName = "datetime")]
        
        public DateTime? Stayto { get; set; }


        [Column("APPLYFROM", TypeName = "datetime")]
        
        public DateTime? Applyfrom { get; set; }


        [Column("APPLYTO", TypeName = "datetime")]
        
        public DateTime? Applyto { get; set; }


        [Column("CHECKINDAYS")]
        [StringLength(7)]
        [Unicode(false)]
        
        public string? Checkindays { get; set; }


        [Column("CHECKOUTDAYS")]
        [StringLength(7)]
        [Unicode(false)]
        
        public string? Checkoutdays { get; set; }


        [Column("STAYINGDAYS")]
        [StringLength(7)]
        [Unicode(false)]
        
        public string? Stayingdays { get; set; }


        [Column("MINLOS")]
        
        public byte? Minlos { get; set; }


        [Column("MAXLOS")]
        
        public byte? Maxlos { get; set; }


        [Column("MINPAX")]
        
        public byte? Minpax { get; set; }


        [Column("MAXPAX")]
        
        public byte? Maxpax { get; set; }


        [Column("APPLYTYPE")]
        [RequiredIf]
        public byte Applytype { get; set; }


        [Column("APPLYZONE")]
        [RequiredIf]
        public byte Applyzone { get; set; }


        [Column("ADDITIONAL_DISCOUNT")]
        [RequiredIf]
        public bool AdditionalDiscount { get; set; }


        [Column("ADDITIONAL_EFFECT")]
        [RequiredIf]
        public byte AdditionalEffect { get; set; }


        [Column("APPLYDAYS")]
        [StringLength(100)]
        
        public string? Applydays { get; set; }


        [Column("AGENCYID")]
        
        public Guid? Agencyid { get; set; }



        [ForeignKey(nameof(Agencyid))]
        [InverseProperty("StdhotelRatecodeDiscount")]
        public virtual Agency? Agency { get; set; }
        [ForeignKey(nameof(Discounttype))]
        [InverseProperty(nameof(Stdhoteldiscount.StdhotelRatecodeDiscount))]
        public virtual Stdhoteldiscount DiscounttypeNavigation { get; set; } = null!;
        [ForeignKey(nameof(Hotelid))]
        [InverseProperty(nameof(Stdhotel.StdhotelRatecodeDiscount))]
        public virtual Stdhotel Hotel { get; set; } = null!;
        [ForeignKey(nameof(Ratecodeid))]
        [InverseProperty(nameof(StdhotelRatecode.StdhotelRatecodeDiscount))]
        public virtual StdhotelRatecode Ratecode { get; set; } = null!;
        [InverseProperty("Discount")]
        public virtual ICollection<StdhotelRatecodeDiscountContract> StdhotelRatecodeDiscountContract { get; set; }
        [InverseProperty("Discount")]
        public virtual ICollection<StdhotelRatecodeDiscountMarket> StdhotelRatecodeDiscountMarket { get; set; }
        [InverseProperty("Discount")]
        public virtual ICollection<StdhotelRatecodeDiscountRatetype> StdhotelRatecodeDiscountRatetype { get; set; }
        [InverseProperty("Discount")]
        public virtual ICollection<StdhotelRatecodeDiscountRoomtype> StdhotelRatecodeDiscountRoomtype { get; set; }

            }
}
