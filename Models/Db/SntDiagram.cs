using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class SntDiagram : EntityBase // My Handlebars Helper
    {
        [Column("dataKey")]
        public Guid DataKey { get; set; }
        [Column("description")]
        [StringLength(40)]
        public string Description { get; set; } = null!;
        [Column("page")]
        public string? Page { get; set; }
        [Column("connectors")]
        public string? Connectors { get; set; }
        [Column("shapes")]
        public string? Shapes { get; set; }
        [Column("isactive")]
        public bool Isactive { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
