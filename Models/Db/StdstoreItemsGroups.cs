using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDSTORE_ITEMS_GROUPS")]
    public partial class StdstoreItemsGroups : EntityBase 
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


        [Column("SORTINDEX")]
        [RequiredIf]
        public int Sortindex { get; set; }



        [ForeignKey(nameof(Groupid))]
        [InverseProperty(nameof(StdstoreItemGroups.StdstoreItemsGroups))]
        public virtual StdstoreItemGroups Group { get; set; } = null!;
        [ForeignKey(nameof(Itemid))]
        [InverseProperty(nameof(StdstoreItems.StdstoreItemsGroups))]
        public virtual StdstoreItems Item { get; set; } = null!;

            }
}
