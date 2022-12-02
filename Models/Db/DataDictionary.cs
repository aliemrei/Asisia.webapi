using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("DATA_DICTIONARY")]
    [Index(nameof(Recid), nameof(Tablename), nameof(Fieldname), nameof(Langcode), Name = "UQ__DATA_DIC__54F85D1A5F1C9BBD", IsUnique = true)]
    public partial class DataDictionary : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("TABLENAME")]
        [StringLength(100)]
        public string Tablename { get; set; } = null!;
        [Column("RECID")]
        public Guid Recid { get; set; }
        [Column("FIELDNAME")]
        [StringLength(150)]
        public string Fieldname { get; set; } = null!;
        [Column("LANGCODE")]
        [StringLength(6)]
        [Unicode(false)]
        public string Langcode { get; set; } = null!;
        [Column("VAL")]
        public string? Val { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
