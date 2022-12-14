using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("PORTAL_CATEGORY_IMAGES")]
    public partial class PortalCategoryImages : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("CATID")]
        [RequiredIf]
        public Guid Catid { get; set; }


        [Column("GROUPNAME")]
        [StringLength(100)]
        
        public string? Groupname { get; set; }


        [Column("DESCRIPTION")]
        [StringLength(255)]
        
        public string? Description { get; set; }


        [Column("THUMBNAILURL")]
        [StringLength(350)]
        [RequiredIf]
        public string Thumbnailurl { get; set; } = null!;


        [Column("IMAGEURL")]
        [StringLength(350)]
        [RequiredIf]
        public string Imageurl { get; set; } = null!;


        [Column("SORTINDEX")]
        [RequiredIf]
        public int Sortindex { get; set; }


        [Column("ISDISABLED")]
        [RequiredIf]
        public bool Isdisabled { get; set; }


        [Column("ISDELETED")]
        [RequiredIf]
        public bool Isdeleted { get; set; }


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



        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.PortalCategoryImagesAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Catid))]
        [InverseProperty(nameof(PortalCategories.PortalCategoryImages))]
        public virtual PortalCategories Cat { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.PortalCategoryImagesEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }

            }
}
