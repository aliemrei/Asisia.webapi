using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class SntDiagramChildkeys : EntityBase // My Handlebars Helper
    {
        [Column("key")]
        [StringLength(15)]
        [Unicode(false)]
        public string Key { get; set; } = null!;
        [Column("dataKey")]
        public Guid DataKey { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
