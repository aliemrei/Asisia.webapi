using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDSTORE_ITEMS_GROUPS")]
    public partial class StdstoreItemsGroups : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("GROUPID")]
        public Guid Groupid { get; set; }
        [Column("ITEMID")]
        public Guid Itemid { get; set; }
        [Column("SORTINDEX")]
        public int Sortindex { get; set; }

        [ForeignKey(nameof(Groupid))]
        [InverseProperty(nameof(StdstoreItemGroups.StdstoreItemsGroups))]
        public virtual StdstoreItemGroups Group { get; set; } = null!;
        [ForeignKey(nameof(Itemid))]
        [InverseProperty(nameof(StdstoreItems.StdstoreItemsGroups))]
        public virtual StdstoreItems Item { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
