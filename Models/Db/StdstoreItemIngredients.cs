using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDSTORE_ITEM_INGREDIENTS")]
    public partial class StdstoreItemIngredients : EntityBase 
    {
        public StdstoreItemIngredients()
        {
            StdstoreItemPricesIngredients = new HashSet<StdstoreItemPricesIngredients>();
        }

        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("STORE_ITEMID")]
        [RequiredIf]
        public Guid StoreItemid { get; set; }


        [Column("STORE_ITEM_SIZESID")]
        
        public Guid? StoreItemSizesid { get; set; }


        [Column("ISDELETED")]
        [RequiredIf]
        public bool Isdeleted { get; set; }


        [Column("DEFINITION")]
        [StringLength(75)]
        [RequiredIf]
        public string Definition { get; set; } = null!;


        [Column("ADDDATE", TypeName = "datetime")]
        [RequiredIf]
        public DateTime Adddate { get; set; }


        [Column("ADDUSER")]
        [RequiredIf]
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

            }
}
