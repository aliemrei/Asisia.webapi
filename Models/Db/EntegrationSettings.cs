using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    [Table("ENTEGRATION_SETTINGS")]
    public partial class EntegrationSettings : EntityBase // My Handlebars Helper
    {
        [Column("FIRST_DATE", TypeName = "date")]
        public DateTime? FirstDate { get; set; }
        [Column("LAST_DATE", TypeName = "date")]
        public DateTime? LastDate { get; set; }
        [Column("ENTTYPE")]
        [StringLength(50)]
        public string? Enttype { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
