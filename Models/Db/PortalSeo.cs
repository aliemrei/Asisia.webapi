using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("PORTAL_SEO")]
    public partial class PortalSeo : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("PORTALID")]
        public int? Portalid { get; set; }
        [Column("PROJECT_DETAILID")]
        public Guid? ProjectDetailid { get; set; }
        [Column("LANG")]
        [StringLength(6)]
        [Unicode(false)]
        public string Lang { get; set; } = null!;
        [Column("URL")]
        [StringLength(150)]
        public string? Url { get; set; }
        [Column("TITLE")]
        [StringLength(250)]
        public string? Title { get; set; }
        [Column("DESCRIPTION")]
        public string? Description { get; set; }
        [Column("KEYWORDS")]
        public string? Keywords { get; set; }
        [Column("ADDUSER")]
        public Guid Adduser { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("EDITUSER")]
        public Guid? Edituser { get; set; }
        [Column("EDITDATE", TypeName = "datetime")]
        public DateTime? Editdate { get; set; }
        [Column("PORTALUID")]
        public Guid Portaluid { get; set; }

        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.PortalSeoAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.PortalSeoEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(Lang))]
        [InverseProperty(nameof(Stdlanguages.PortalSeo))]
        public virtual Stdlanguages LangNavigation { get; set; } = null!;
        [ForeignKey(nameof(ProjectDetailid))]
        [InverseProperty(nameof(ProjectGroupdetail.PortalSeo))]
        public virtual ProjectGroupdetail? ProjectDetail { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
