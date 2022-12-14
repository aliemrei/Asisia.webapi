using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("PORTAL_CATEGORIES")]
    public partial class PortalCategories : EntityBase 
    {
        public PortalCategories()
        {
            PortalCategoryImages = new HashSet<PortalCategoryImages>();
            PortalCategoryItems = new HashSet<PortalCategoryItems>();
        }

        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("PORTALID")]
        [RequiredIf]
        public int Portalid { get; set; }


        [Column("DESCRIPTION")]
        
        public string? Description { get; set; }


        [Column("URL")]
        [StringLength(250)]
        
        public string? Url { get; set; }


        [Column("ISDELETED")]
        [RequiredIf]
        public bool Isdeleted { get; set; }


        [Column("ISDISABLED")]
        [RequiredIf]
        public bool Isdisabled { get; set; }


        [Column("ADDUSER")]
        [RequiredIf]
        public Guid Adduser { get; set; }


        [Column("ADDDATE", TypeName = "datetime")]
        [RequiredIf]
        public DateTime Adddate { get; set; }


        [Column("EDITUSER")]
        
        public Guid? Edituser { get; set; }


        [Column("EDITDATE", TypeName = "datetime")]
        
        public DateTime? Editdate { get; set; }


        [Column("DEFINITION")]
        [StringLength(150)]
        [RequiredIf]
        public string Definition { get; set; } = null!;


        [Column("TYPE")]
        [StringLength(150)]
        [RequiredIf]
        public string Type { get; set; } = null!;


        [Column("INTID")]
        [RequiredIf]
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

            }
}
