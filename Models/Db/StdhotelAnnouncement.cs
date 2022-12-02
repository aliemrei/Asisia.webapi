using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDHOTEL_ANNOUNCEMENT")]
    public partial class StdhotelAnnouncement : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("HOTELID")]
        public Guid Hotelid { get; set; }
        [Column("KIND")]
        public short Kind { get; set; }
        [Column("DEFINITION")]
        [StringLength(150)]
        public string? Definition { get; set; }
        [Column("STARTDATE", TypeName = "datetime")]
        public DateTime Startdate { get; set; }
        [Column("ENDDATE", TypeName = "datetime")]
        public DateTime Enddate { get; set; }
        [Column("INNERHTML")]
        public string? Innerhtml { get; set; }
        [Column("ADDUSER")]
        public Guid Adduser { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("EDITUSER")]
        public Guid? Edituser { get; set; }
        [Column("EDITDATE", TypeName = "datetime")]
        public DateTime? Editdate { get; set; }
        [Column("ISDELETED")]
        public bool Isdeleted { get; set; }
        [Column("ISDISABLED")]
        public bool Isdisabled { get; set; }
        [Column("MARKETS")]
        public string? Markets { get; set; }

        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.StdhotelAnnouncementAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.StdhotelAnnouncementEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(Hotelid))]
        [InverseProperty(nameof(Stdhotel.StdhotelAnnouncement))]
        public virtual Stdhotel Hotel { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
