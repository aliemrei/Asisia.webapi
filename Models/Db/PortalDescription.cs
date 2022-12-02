using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("PORTAL_DESCRIPTION")]
    public partial class PortalDescription : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("PORTALUID")]
        public Guid Portaluid { get; set; }
        [Column("ICON")]
        [StringLength(50)]
        public string? Icon { get; set; }
        [Column("CAPTION")]
        [StringLength(100)]
        public string? Caption { get; set; }
        [Column("DESCRIPTION")]
        public string? Description { get; set; }
        [Column("TYPE")]
        public int? Type { get; set; }

        public virtual Portal Portalu { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
