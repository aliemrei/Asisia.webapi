using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDSTORE_ITEM_GROUP_ITEMS")]
    [Index(nameof(Groupid), nameof(Itemid), Name = "UQ__STDSTORE__98E91DBD6E833329", IsUnique = true)]
    public partial class StdstoreItemGroupItems : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("GROUPID")]
        [RequiredIf]
        public Guid Groupid { get; set; }


        [Column("ITEMID")]
        [RequiredIf]
        public Guid Itemid { get; set; }


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
        [InverseProperty(nameof(Users.StdstoreItemGroupItemsAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.StdstoreItemGroupItemsEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(Groupid))]
        [InverseProperty(nameof(StdstoreItemGroups.StdstoreItemGroupItems))]
        public virtual StdstoreItemGroups Group { get; set; } = null!;
        [ForeignKey(nameof(Itemid))]
        [InverseProperty(nameof(StdstoreItems.StdstoreItemGroupItems))]
        public virtual StdstoreItems Item { get; set; } = null!;

            }
}
