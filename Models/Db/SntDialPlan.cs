using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class SntDialPlan : EntityBase // My Handlebars Helper
    {
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("PARENTID")]
        public Guid? Parentid { get; set; }
        [Column("SWID")]
        public Guid Swid { get; set; }
        [Column("GROUPNAME")]
        [StringLength(150)]
        public string Groupname { get; set; } = null!;
        [Column("PRIORITY")]
        public int Priority { get; set; }
        [Column("APP")]
        [StringLength(100)]
        public string? App { get; set; }
        [Column("APPDATA")]
        [StringLength(250)]
        public string? Appdata { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
