using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class AuditLogs : EntityBase 
    {
        [RequiredIf]
        public int Id { get; set; }


        [RequiredIf]
        public Guid UserId { get; set; }


        [StringLength(16)]
        [Unicode(false)]
        [RequiredIf]
        public string Type { get; set; } = null!;


        [StringLength(200)]
        
        public string? TableName { get; set; }


        [Column(TypeName = "datetime")]
        [RequiredIf]
        public DateTime DateTime { get; set; }


        
        public string? OldValues { get; set; }


        
        public string? NewValues { get; set; }


        
        public string? AffectedColumns { get; set; }


        [StringLength(200)]
        
        public string? PrimaryKey { get; set; }


        [StringLength(200)]
        
        public string? DatabaseName { get; set; }



            }
}
