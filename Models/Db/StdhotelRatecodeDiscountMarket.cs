using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDHOTEL_RATECODE_DISCOUNT_MARKET")]
    [Index(nameof(Discountid), nameof(Marketid), Name = "UQ__STDHOTEL__4B96FBB176D8588E", IsUnique = true)]
    public partial class StdhotelRatecodeDiscountMarket : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public int Id { get; set; }


        [Column("DISCOUNTID")]
        [RequiredIf]
        public Guid Discountid { get; set; }


        [Column("MARKETID")]
        [RequiredIf]
        public Guid Marketid { get; set; }



        [ForeignKey(nameof(Discountid))]
        [InverseProperty(nameof(StdhotelRatecodeDiscount.StdhotelRatecodeDiscountMarket))]
        public virtual StdhotelRatecodeDiscount Discount { get; set; } = null!;
        [ForeignKey(nameof(Marketid))]
        [InverseProperty(nameof(StdhotelMarket.StdhotelRatecodeDiscountMarket))]
        public virtual StdhotelMarket Market { get; set; } = null!;

            }
}
