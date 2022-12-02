using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDHOTEL_DESCRIPTIONS")]
    [Index(nameof(Uid), Name = "IX_STDHOTEL_DESCRIPTIONS", IsUnique = true)]
    public partial class StdhotelDescriptions : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("HOTELID")]
        public Guid? Hotelid { get; set; }
        [Column("DESCRIPTION")]
        public string? Description { get; set; }
        [Column("CATEGORY")]
        [StringLength(150)]
        public string? Category { get; set; }
        [Column("SEASON")]
        [StringLength(10)]
        public string? Season { get; set; }
        [Column("UID")]
        public Guid Uid { get; set; }

        [ForeignKey(nameof(Hotelid))]
        [InverseProperty(nameof(Stdhotel.StdhotelDescriptions))]
        public virtual Stdhotel? Hotel { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
