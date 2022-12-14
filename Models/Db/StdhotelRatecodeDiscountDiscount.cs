using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDHOTEL_RATECODE_DISCOUNT_DISCOUNT")]
    [Index(nameof(Discountid), nameof(Otherdiscountid), Name = "UQ__STDHOTEL__649F0431A924ADCC", IsUnique = true)]
    public partial class StdhotelRatecodeDiscountDiscount : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public int Id { get; set; }


        [Column("DISCOUNTID")]
        [RequiredIf]
        public Guid Discountid { get; set; }


        [Column("OTHERDISCOUNTID")]
        [RequiredIf]
        public Guid Otherdiscountid { get; set; }



            }
}
