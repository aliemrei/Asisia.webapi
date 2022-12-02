using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDHOTELDISCOUNT")]
    public partial class Stdhoteldiscount : EntityBase // My Handlebars Helper
    {
        public Stdhoteldiscount()
        {
            StdhotelRatecodeDiscount = new HashSet<StdhotelRatecodeDiscount>();
        }

        [Key]
        [Column("ID")]
        public byte Id { get; set; }
        [Column("DEFINITION")]
        [StringLength(50)]
        public string? Definition { get; set; }

        [InverseProperty("DiscounttypeNavigation")]
        public virtual ICollection<StdhotelRatecodeDiscount> StdhotelRatecodeDiscount { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
