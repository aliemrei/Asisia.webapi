using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("CALENDAR")]
    public partial class Calendar : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("DATE", TypeName = "date")]
        public DateTime Date { get; set; }
        [Column("DAYOFWEEK")]
        public byte? Dayofweek { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
