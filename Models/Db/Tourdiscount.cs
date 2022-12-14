using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("TOURDISCOUNT")]
    public partial class Tourdiscount : EntityBase 
    {
        public Tourdiscount()
        {
            TourDiscounts = new HashSet<TourDiscounts>();
        }

        [Key]
        [Column("ID")]
        [RequiredIf]
        public byte Id { get; set; }


        [Column("DEFINITION")]
        [StringLength(50)]
        
        public string? Definition { get; set; }



        [InverseProperty("DiscounttypeNavigation")]
        public virtual ICollection<TourDiscounts> TourDiscounts { get; set; }

            }
}
