using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDHOTELDISCOUNT")]
    public partial class Stdhoteldiscount : EntityBase 
    {
        public Stdhoteldiscount()
        {
            StdhotelRatecodeDiscount = new HashSet<StdhotelRatecodeDiscount>();
        }

        [Key]
        [Column("ID")]
        [RequiredIf]
        public byte Id { get; set; }


        [Column("DEFINITION")]
        [StringLength(50)]
        
        public string? Definition { get; set; }



        [InverseProperty("DiscounttypeNavigation")]
        public virtual ICollection<StdhotelRatecodeDiscount> StdhotelRatecodeDiscount { get; set; }

            }
}
