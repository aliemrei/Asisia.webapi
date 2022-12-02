using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("BONUS_DEF")]
    public partial class BonusDef : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("CORPID")]
        public Guid Corpid { get; set; }
        [Column("FIRST_DATE", TypeName = "datetime")]
        public DateTime FirstDate { get; set; }
        [Column("LAST_DATE", TypeName = "datetime")]
        public DateTime LastDate { get; set; }
        [Column("RATE")]
        public double? Rate { get; set; }
        [Column("APPLY_TYPE")]
        public short ApplyType { get; set; }
        [Column("PROJECT_GROUPID")]
        public Guid? ProjectGroupid { get; set; }
        [Column("DEFINITION")]
        [StringLength(100)]
        public string? Definition { get; set; }
        [Column("CURCODE")]
        [StringLength(5)]
        [Unicode(false)]
        public string Curcode { get; set; } = null!;
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("ADDUSER")]
        public Guid? Adduser { get; set; }
        [Column("EDITDATE", TypeName = "datetime")]
        public DateTime? Editdate { get; set; }
        [Column("EDITUSER")]
        public Guid? Edituser { get; set; }

        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.BonusDefAdduserNavigation))]
        public virtual Users? AdduserNavigation { get; set; }
        [ForeignKey(nameof(Corpid))]
        [InverseProperty("BonusDef")]
        public virtual Corp Corp { get; set; } = null!;
        [ForeignKey(nameof(Curcode))]
        [InverseProperty("BonusDef")]
        public virtual Curcode CurcodeNavigation { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.BonusDefEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(ProjectGroupid))]
        [InverseProperty("BonusDef")]
        public virtual ProjectGroup? ProjectGroup { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
