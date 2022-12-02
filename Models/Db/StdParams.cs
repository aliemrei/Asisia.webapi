using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STD_PARAMS")]
    public partial class StdParams : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("CORPID")]
        public Guid Corpid { get; set; }
        [Column("PARAMNAME")]
        [StringLength(200)]
        public string? Paramname { get; set; }
        [Column("PARAMVALUE")]
        [StringLength(250)]
        public string? Paramvalue { get; set; }
        [Column("GROUPNAME")]
        [StringLength(50)]
        public string? Groupname { get; set; }

        [ForeignKey(nameof(Corpid))]
        [InverseProperty("StdParams")]
        public virtual Corp Corp { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
