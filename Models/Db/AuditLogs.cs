using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class AuditLogs : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public string Type { get; set; } = null!;
        public string? TableName { get; set; }
        public DateTime DateTime { get; set; }
        public string? OldValues { get; set; }
        public string? NewValues { get; set; }
        public string? AffectedColumns { get; set; }
        public string? PrimaryKey { get; set; }
        public string? DatabaseName { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
