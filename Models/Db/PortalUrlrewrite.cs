using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("PORTAL_URLREWRITE")]
    public partial class PortalUrlrewrite : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("LINK")]
        public string Link { get; set; } = null!;
        [Column("VALIDDATE", TypeName = "datetime")]
        public DateTime? Validdate { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
