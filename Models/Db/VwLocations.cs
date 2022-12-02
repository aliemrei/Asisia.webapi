using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class VwLocations : EntityBase // My Handlebars Helper
    {
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("DEFINITION")]
        [StringLength(170)]
        public string Definition { get; set; } = null!;
        [Column("CORPID")]
        public Guid Corpid { get; set; }
        [Column("TYPE")]
        [StringLength(8)]
        [Unicode(false)]
        public string Type { get; set; } = null!;
        [Column("CODE")]
        [StringLength(5)]
        public string? Code { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
