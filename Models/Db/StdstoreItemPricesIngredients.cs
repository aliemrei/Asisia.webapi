using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDSTORE_ITEM_PRICES_INGREDIENTS")]
    public partial class StdstoreItemPricesIngredients : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("INGREDIENTID")]
        public Guid Ingredientid { get; set; }
        [Column("ISDELETED")]
        public bool Isdeleted { get; set; }
        [Column("PRICE")]
        public double? Price { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("ADDUSER")]
        public Guid Adduser { get; set; }
        [Column("EDITDATE", TypeName = "datetime")]
        public DateTime? Editdate { get; set; }
        [Column("EDITUSER")]
        public Guid? Edituser { get; set; }
        [Column("PRICEID")]
        public Guid Priceid { get; set; }

        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.StdstoreItemPricesIngredients))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Ingredientid))]
        [InverseProperty(nameof(StdstoreItemIngredients.StdstoreItemPricesIngredients))]
        public virtual StdstoreItemIngredients Ingredient { get; set; } = null!;
        [ForeignKey(nameof(Priceid))]
        [InverseProperty(nameof(StdstoreItemPrices.StdstoreItemPricesIngredients))]
        public virtual StdstoreItemPrices PriceNavigation { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
