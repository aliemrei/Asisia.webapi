using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("TOUR_DISCOUNTS")]
    public partial class TourDiscounts : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("TOURID")]
        [RequiredIf]
        public Guid Tourid { get; set; }


        [Column("DEFINITION")]
        [StringLength(50)]
        
        public string? Definition { get; set; }


        [Column("DISCOUNT")]
        [RequiredIf]
        public double Discount { get; set; }


        [Column("DISCOUNTTYPE")]
        [RequiredIf]
        public byte Discounttype { get; set; }


        [Column("SELLFROM", TypeName = "datetime")]
        
        public DateTime? Sellfrom { get; set; }


        [Column("SELLTO", TypeName = "datetime")]
        
        public DateTime? Sellto { get; set; }


        [Column("MINPRICE")]
        
        public double? Minprice { get; set; }


        [Column("MAXPRICE")]
        
        public double? Maxprice { get; set; }


        [Column("MINPAX")]
        
        public byte? Minpax { get; set; }


        [Column("MAXPAX")]
        
        public byte? Maxpax { get; set; }


        [Column("APPLYTYPE")]
        [RequiredIf]
        public byte Applytype { get; set; }


        [Column("TOURFROM", TypeName = "datetime")]
        
        public DateTime? Tourfrom { get; set; }


        [Column("TOURTO", TypeName = "datetime")]
        
        public DateTime? Tourto { get; set; }


        [Column("VALIDCOUNT")]
        [RequiredIf]
        public int Validcount { get; set; }


        [Column("ADDDATE", TypeName = "datetime")]
        [RequiredIf]
        public DateTime Adddate { get; set; }


        [Column("ADDUSER")]
        [RequiredIf]
        public Guid Adduser { get; set; }


        [Column("EDITDATE", TypeName = "datetime")]
        
        public DateTime? Editdate { get; set; }


        [Column("EDITUSER")]
        
        public Guid? Edituser { get; set; }



        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.TourDiscountsAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Discounttype))]
        [InverseProperty(nameof(Tourdiscount.TourDiscounts))]
        public virtual Tourdiscount DiscounttypeNavigation { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.TourDiscountsEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(Tourid))]
        [InverseProperty("TourDiscounts")]
        public virtual Tour Tour { get; set; } = null!;

            }
}
