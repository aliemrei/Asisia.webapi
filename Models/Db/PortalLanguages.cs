using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("PORTAL_LANGUAGES")]
    public partial class PortalLanguages : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("PORTALUID")]
        public Guid Portaluid { get; set; }
        [Column("LANGCODE")]
        [StringLength(5)]
        public string Langcode { get; set; } = null!;

        public virtual Portal Portalu { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
