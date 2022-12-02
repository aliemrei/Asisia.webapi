using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDSTORE_ITEM_INGREDIENTS")]
    public partial class StdstoreItemIngredients : EntityBase // My Handlebars Helper
    {
        public StdstoreItemIngredients()
        {
            StdstoreItemPricesIngredients = new HashSet<StdstoreItemPricesIngredients>();
        }

        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("STORE_ITEMID")]
        public Guid StoreItemid { get; set; }
        [Column("STORE_ITEM_SIZESID")]
        public Guid? StoreItemSizesid { get; set; }
        [Column("ISDELETED")]
        public bool Isdeleted { get; set; }
        [Column("DEFINITION")]
        [StringLength(75)]
        public string Definition { get; set; } = null!;
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("ADDUSER")]
        public Guid Adduser { get; set; }
        [Column("EDITDATE", TypeName = "datetime")]
        public DateTime? Editdate { get; set; }
        [Column("EDITUSER")]
        public Guid? Edituser { get; set; }

        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.StdstoreItemIngredients))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(StoreItemid))]
        [InverseProperty(nameof(StdstoreItems.StdstoreItemIngredients))]
        public virtual StdstoreItems StoreItem { get; set; } = null!;
        [ForeignKey(nameof(StoreItemSizesid))]
        [InverseProperty(nameof(StdstoreItemSizes.StdstoreItemIngredients))]
        public virtual StdstoreItemSizes? StoreItemSizes { get; set; }
        [InverseProperty("Ingredient")]
        public virtual ICollection<StdstoreItemPricesIngredients> StdstoreItemPricesIngredients { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
