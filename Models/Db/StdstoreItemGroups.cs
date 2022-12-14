using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDSTORE_ITEM_GROUPS")]
    [Index(nameof(Storeid), nameof(Definition), Name = "UQ__STDSTORE__C467D422F9DABF61", IsUnique = true)]
    public partial class StdstoreItemGroups : EntityBase 
    {
        public StdstoreItemGroups()
        {
            StdstoreItemGroupItems = new HashSet<StdstoreItemGroupItems>();
            StdstoreItemsGroups = new HashSet<StdstoreItemsGroups>();
        }

        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("STOREID")]
        [RequiredIf]
        public Guid Storeid { get; set; }


        [Column("DEFINITION")]
        [StringLength(120)]
        [RequiredIf]
        public string Definition { get; set; } = null!;


        [Column("DESCRIPTION")]
        
        public string? Description { get; set; }


        [Column("SHOWINPORTAL")]
        [RequiredIf]
        public bool Showinportal { get; set; }


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


        [Column("THUMBNAILURL")]
        [StringLength(350)]
        
        public string? Thumbnailurl { get; set; }


        [Column("TITLE")]
        
        public string? Title { get; set; }


        [Column("SORTINDEX")]
        [RequiredIf]
        public int Sortindex { get; set; }



        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.StdstoreItemGroupsAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.StdstoreItemGroupsEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(Storeid))]
        [InverseProperty(nameof(Stdstore.StdstoreItemGroups))]
        public virtual Stdstore Store { get; set; } = null!;
        [InverseProperty("Group")]
        public virtual ICollection<StdstoreItemGroupItems> StdstoreItemGroupItems { get; set; }
        [InverseProperty("Group")]
        public virtual ICollection<StdstoreItemsGroups> StdstoreItemsGroups { get; set; }

            }
}
