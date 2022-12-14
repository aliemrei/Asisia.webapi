using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("CALENDAR")]
    public partial class Calendar : EntityBase 
    {
        [Key]
        [Column("DATE", TypeName = "date")]
        [RequiredIf]
        public DateTime Date { get; set; }


        [Column("DAYOFWEEK")]
        
        public byte? Dayofweek { get; set; }



            }
}
