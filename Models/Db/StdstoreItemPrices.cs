using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDSTORE_ITEM_PRICES")]
    public partial class StdstoreItemPrices : EntityBase 
    {
        public StdstoreItemPrices()
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


        [Column("STORE_PRICE")]
        
        public double? StorePrice { get; set; }


        [Column("ONLINE_PRICE")]
        
        public double? OnlinePrice { get; set; }


        [Column("CURCODE")]
        [StringLength(5)]
        [Unicode(false)]
        
        public string? Curcode { get; set; }


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


        [Column("SELLSTART", TypeName = "date")]
        
        public DateTime? Sellstart { get; set; }


        [Column("SELLEND", TypeName = "date")]
        
        public DateTime? Sellend { get; set; }


        [Column("SELLDAYS")]
        [StringLength(7)]
        [Unicode(false)]
        
        public string? Selldays { get; set; }



        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.StdstoreItemPrices))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Curcode))]
        [InverseProperty("StdstoreItemPrices")]
        public virtual Curcode? CurcodeNavigation { get; set; }
        [ForeignKey(nameof(StoreItemid))]
        [InverseProperty(nameof(StdstoreItems.StdstoreItemPrices))]
        public virtual StdstoreItems StoreItem { get; set; } = null!;
        [ForeignKey(nameof(StoreItemSizesid))]
        [InverseProperty(nameof(StdstoreItemSizes.StdstoreItemPrices))]
        public virtual StdstoreItemSizes? StoreItemSizes { get; set; }
        [InverseProperty("PriceNavigation")]
        public virtual ICollection<StdstoreItemPricesIngredients> StdstoreItemPricesIngredients { get; set; }

            }
}
