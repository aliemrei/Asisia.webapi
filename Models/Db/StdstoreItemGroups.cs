using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDSTORE_ITEM_GROUPS")]
    [Index(nameof(Storeid), nameof(Definition), Name = "UQ__STDSTORE__C467D422F9DABF61", IsUnique = true)]
    public partial class StdstoreItemGroups : EntityBase // My Handlebars Helper
    {
        public StdstoreItemGroups()
        {
            StdstoreItemGroupItems = new HashSet<StdstoreItemGroupItems>();
            StdstoreItemsGroups = new HashSet<StdstoreItemsGroups>();
        }

        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("STOREID")]
        public Guid Storeid { get; set; }
        [Column("DEFINITION")]
        [StringLength(120)]
        public string Definition { get; set; } = null!;
        [Column("DESCRIPTION")]
        public string? Description { get; set; }
        [Column("SHOWINPORTAL")]
        public bool Showinportal { get; set; }
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
        [Column("THUMBNAILURL")]
        [StringLength(350)]
        public string? Thumbnailurl { get; set; }
        [Column("TITLE")]
        public string? Title { get; set; }
        [Column("SORTINDEX")]
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

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
