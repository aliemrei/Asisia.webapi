using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    [Table("TOUR_IMAGES")]
    public partial class TourImages : EntityBase // My Handlebars Helper
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("TOURID")]
        public Guid Tourid { get; set; }
        [Column("TOUR_PROGRAMID")]
        public Guid? TourProgramid { get; set; }
        [Column("DEFINITION")]
        [StringLength(100)]
        public string? Definition { get; set; }
        [Column("DEFAULT")]
        public bool? Default { get; set; }
        [Column("SORTORDER")]
        public int? Sortorder { get; set; }
        [Column("THUMBNAIL")]
        [StringLength(250)]
        public string? Thumbnail { get; set; }
        [Column("URL")]
        [StringLength(250)]
        public string? Url { get; set; }

        [ForeignKey(nameof(Tourid))]
        public virtual Tour Tour { get; set; } = null!;
        [ForeignKey(nameof(TourProgramid))]
        public virtual TourProgram? TourProgram { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
