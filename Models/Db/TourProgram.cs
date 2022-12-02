using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("TOUR_PROGRAM")]
    [Index(nameof(Stepno), nameof(Sortorder), Name = "IX_TOUR_PROGRAM")]
    public partial class TourProgram : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("TOURID")]
        public Guid Tourid { get; set; }
        [Column("STEPNO")]
        public int Stepno { get; set; }
        [Column("DURATION")]
        public int Duration { get; set; }
        [Column("INTERVAL")]
        public short Interval { get; set; }
        [Column("TITLE")]
        [StringLength(200)]
        public string Title { get; set; } = null!;
        [Column("DESCRIPTION")]
        public string? Description { get; set; }
        [Column("HOTELID")]
        public Guid? Hotelid { get; set; }
        [Column("ISDISABLED")]
        public bool Isdisabled { get; set; }
        [Column("ADDUSER")]
        public Guid Adduser { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("EDITUSER")]
        public Guid? Edituser { get; set; }
        [Column("EDITDATE", TypeName = "datetime")]
        public DateTime? Editdate { get; set; }
        [Column("SORTORDER")]
        public int? Sortorder { get; set; }

        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.TourProgramAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.TourProgramEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(Hotelid))]
        [InverseProperty(nameof(Stdhotel.TourProgram))]
        public virtual Stdhotel? Hotel { get; set; }
        [ForeignKey(nameof(Tourid))]
        [InverseProperty("TourProgram")]
        public virtual Tour Tour { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
