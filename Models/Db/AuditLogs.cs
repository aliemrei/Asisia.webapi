using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class AuditLogs : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        [StringLength(16)]
        [Unicode(false)]
        public string Type { get; set; } = null!;
        [StringLength(200)]
        public string? TableName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateTime { get; set; }
        public string? OldValues { get; set; }
        public string? NewValues { get; set; }
        public string? AffectedColumns { get; set; }
        [StringLength(200)]
        public string? PrimaryKey { get; set; }
        [StringLength(200)]
        public string? DatabaseName { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
