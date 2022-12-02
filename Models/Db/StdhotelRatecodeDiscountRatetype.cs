using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDHOTEL_RATECODE_DISCOUNT_RATETYPE")]
    [Index(nameof(Discountid), nameof(Ratetypeid), Name = "UQ__STDHOTEL__050B357DD8B8D23E", IsUnique = true)]
    public partial class StdhotelRatecodeDiscountRatetype : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("DISCOUNTID")]
        public Guid Discountid { get; set; }
        [Column("RATETYPEID")]
        public Guid Ratetypeid { get; set; }

        [ForeignKey(nameof(Discountid))]
        [InverseProperty(nameof(StdhotelRatecodeDiscount.StdhotelRatecodeDiscountRatetype))]
        public virtual StdhotelRatecodeDiscount Discount { get; set; } = null!;
        [ForeignKey(nameof(Ratetypeid))]
        [InverseProperty(nameof(StdhotelRatetype.StdhotelRatecodeDiscountRatetype))]
        public virtual StdhotelRatetype Ratetype { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
