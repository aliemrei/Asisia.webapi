using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDSTORE_ITEMS")]
    [Index(nameof(Storeid), nameof(Definition), Name = "UQ__STDSTORE__C467D422F4172951", IsUnique = true)]
    public partial class StdstoreItems : EntityBase // My Handlebars Helper
    {
        public StdstoreItems()
        {
            StdstoreItemGroupItems = new HashSet<StdstoreItemGroupItems>();
            StdstoreItemImages = new HashSet<StdstoreItemImages>();
            StdstoreItemIngredients = new HashSet<StdstoreItemIngredients>();
            StdstoreItemPrices = new HashSet<StdstoreItemPrices>();
            StdstoreItemsGroups = new HashSet<StdstoreItemsGroups>();
        }

        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("STOREID")]
        public Guid Storeid { get; set; }
        [Column("DEFINITION")]
        [StringLength(200)]
        public string Definition { get; set; } = null!;
        [Column("DESCRIPTION")]
        public string? Description { get; set; }
        [Column("ISDELETED")]
        public bool Isdeleted { get; set; }
        [Column("ISDISABLED")]
        public bool Isdisabled { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("ADDUSER")]
        public Guid Adduser { get; set; }
        [Column("EDITDATE", TypeName = "datetime")]
        public DateTime? Editdate { get; set; }
        [Column("EDITUSER")]
        public Guid? Edituser { get; set; }

        [InverseProperty("Item")]
        public virtual ICollection<StdstoreItemGroupItems> StdstoreItemGroupItems { get; set; }
        [InverseProperty("StoreItem")]
        public virtual ICollection<StdstoreItemImages> StdstoreItemImages { get; set; }
        [InverseProperty("StoreItem")]
        public virtual ICollection<StdstoreItemIngredients> StdstoreItemIngredients { get; set; }
        [InverseProperty("StoreItem")]
        public virtual ICollection<StdstoreItemPrices> StdstoreItemPrices { get; set; }
        [InverseProperty("Item")]
        public virtual ICollection<StdstoreItemsGroups> StdstoreItemsGroups { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
