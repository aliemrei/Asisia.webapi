using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDBOARDTYPES")]
    public partial class Stdboardtypes : EntityBase 
    {
        public Stdboardtypes()
        {
            StdhotelBoardtypes = new HashSet<StdhotelBoardtypes>();
        }

        [Key]
        [Column("BOARDTYPE")]
        [StringLength(10)]
        [RequiredIf]
        public string Boardtype { get; set; } = null!;



        [InverseProperty("BoardtypeNavigation")]
        public virtual ICollection<StdhotelBoardtypes> StdhotelBoardtypes { get; set; }

            }
}
