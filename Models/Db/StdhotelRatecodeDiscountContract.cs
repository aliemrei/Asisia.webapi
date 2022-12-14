using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDHOTEL_RATECODE_DISCOUNT_CONTRACT")]
    [Index(nameof(Discountid), nameof(Contractid), Name = "UQ__STDHOTEL__100A09E2B088803D", IsUnique = true)]
    public partial class StdhotelRatecodeDiscountContract : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public int Id { get; set; }


        [Column("DISCOUNTID")]
        [RequiredIf]
        public Guid Discountid { get; set; }


        [Column("CONTRACTID")]
        [RequiredIf]
        public Guid Contractid { get; set; }



        [ForeignKey(nameof(Contractid))]
        [InverseProperty(nameof(StdhotelRatecodeDetail.StdhotelRatecodeDiscountContract))]
        public virtual StdhotelRatecodeDetail Contract { get; set; } = null!;
        [ForeignKey(nameof(Discountid))]
        [InverseProperty(nameof(StdhotelRatecodeDiscount.StdhotelRatecodeDiscountContract))]
        public virtual StdhotelRatecodeDiscount Discount { get; set; } = null!;

            }
}
