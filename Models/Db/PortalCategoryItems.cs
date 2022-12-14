using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("PORTAL_CATEGORY_ITEMS")]
    public partial class PortalCategoryItems : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("CATID")]
        [RequiredIf]
        public Guid Catid { get; set; }


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


        [Column("HOTELID")]
        
        public Guid? Hotelid { get; set; }


        [Column("TOURID")]
        
        public Guid? Tourid { get; set; }


        [Column("TICKETID")]
        
        public Guid? Ticketid { get; set; }


        [Column("THUMBNAILURL")]
        [StringLength(250)]
        
        public string? Thumbnailurl { get; set; }


        [Column("IMAGEURL")]
        [StringLength(250)]
        
        public string? Imageurl { get; set; }


        [Column("PRICE")]
        
        public double? Price { get; set; }


        [Column("DISCOUNT")]
        
        public double? Discount { get; set; }


        [Column("CURCODE")]
        [StringLength(4)]
        [Unicode(false)]
        
        public string? Curcode { get; set; }


        [Column("DESCRIPTION")]
        [StringLength(100)]
        
        public string? Description { get; set; }



        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.PortalCategoryItemsAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Catid))]
        [InverseProperty(nameof(PortalCategories.PortalCategoryItems))]
        public virtual PortalCategories Cat { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.PortalCategoryItemsEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(Hotelid))]
        [InverseProperty(nameof(Stdhotel.PortalCategoryItems))]
        public virtual Stdhotel? Hotel { get; set; }
        [ForeignKey(nameof(Ticketid))]
        [InverseProperty("PortalCategoryItems")]
        public virtual Ticket? Ticket { get; set; }
        [ForeignKey(nameof(Tourid))]
        [InverseProperty("PortalCategoryItems")]
        public virtual Tour? Tour { get; set; }

            }
}
