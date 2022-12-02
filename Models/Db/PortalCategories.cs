using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("PORTAL_CATEGORIES")]
    public partial class PortalCategories : EntityBase // My Handlebars Helper
    {
        public PortalCategories()
        {
            PortalCategoryImages = new HashSet<PortalCategoryImages>();
            PortalCategoryItems = new HashSet<PortalCategoryItems>();
        }

        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("PORTALID")]
        public int Portalid { get; set; }
        [Column("DESCRIPTION")]
        public string? Description { get; set; }
        [Column("URL")]
        [StringLength(250)]
        public string? Url { get; set; }
        [Column("ISDELETED")]
        public bool Isdeleted { get; set; }
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
        [Column("DEFINITION")]
        [StringLength(150)]
        public string Definition { get; set; } = null!;
        [Column("TYPE")]
        [StringLength(150)]
        public string Type { get; set; } = null!;
        [Column("INTID")]
        public int Intid { get; set; }

        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.PortalCategoriesAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.PortalCategoriesEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(Portalid))]
        [InverseProperty("PortalCategories")]
        public virtual Portal Portal { get; set; } = null!;
        [InverseProperty("Cat")]
        public virtual ICollection<PortalCategoryImages> PortalCategoryImages { get; set; }
        [InverseProperty("Cat")]
        public virtual ICollection<PortalCategoryItems> PortalCategoryItems { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
