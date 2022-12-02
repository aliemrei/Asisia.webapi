using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDHOTEL_RATECODE_DISCOUNT_ROOMTYPE")]
    [Index(nameof(Discountid), nameof(Roomtypeid), Name = "UQ__STDHOTEL__46861580EC62108A", IsUnique = true)]
    public partial class StdhotelRatecodeDiscountRoomtype : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("DISCOUNTID")]
        public Guid Discountid { get; set; }
        [Column("ROOMTYPEID")]
        public Guid Roomtypeid { get; set; }

        [ForeignKey(nameof(Discountid))]
        [InverseProperty(nameof(StdhotelRatecodeDiscount.StdhotelRatecodeDiscountRoomtype))]
        public virtual StdhotelRatecodeDiscount Discount { get; set; } = null!;
        [ForeignKey(nameof(Roomtypeid))]
        [InverseProperty(nameof(StdhotelRoomtypes.StdhotelRatecodeDiscountRoomtype))]
        public virtual StdhotelRoomtypes Roomtype { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
