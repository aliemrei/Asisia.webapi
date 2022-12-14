using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDHOTEL_RATECODE_DISCOUNT_ROOMTYPE")]
    [Index(nameof(Discountid), nameof(Roomtypeid), Name = "UQ__STDHOTEL__46861580EC62108A", IsUnique = true)]
    public partial class StdhotelRatecodeDiscountRoomtype : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public int Id { get; set; }


        [Column("DISCOUNTID")]
        [RequiredIf]
        public Guid Discountid { get; set; }


        [Column("ROOMTYPEID")]
        [RequiredIf]
        public Guid Roomtypeid { get; set; }



        [ForeignKey(nameof(Discountid))]
        [InverseProperty(nameof(StdhotelRatecodeDiscount.StdhotelRatecodeDiscountRoomtype))]
        public virtual StdhotelRatecodeDiscount Discount { get; set; } = null!;
        [ForeignKey(nameof(Roomtypeid))]
        [InverseProperty(nameof(StdhotelRoomtypes.StdhotelRatecodeDiscountRoomtype))]
        public virtual StdhotelRoomtypes Roomtype { get; set; } = null!;

            }
}
