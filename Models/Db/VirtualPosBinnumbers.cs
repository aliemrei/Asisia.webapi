using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("VIRTUAL_POS_BINNUMBERS")]
    [Index(nameof(Binno), Name = "IX_VIRTUAL_POS_BINNUMBERS")]
    [Index(nameof(Binno), Name = "UQ__VIRTUAL___5D92CF0E5E919BD3", IsUnique = true)]
    public partial class VirtualPosBinnumbers : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("BANKNAME")]
        [StringLength(100)]
        public string? Bankname { get; set; }
        [Column("BINNO")]
        [StringLength(7)]
        public string? Binno { get; set; }
        [Column("SCHEMA")]
        [StringLength(30)]
        public string? Schema { get; set; }
        [Column("TYPE")]
        [StringLength(30)]
        public string? Type { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
