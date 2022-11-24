using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class StdstoreItemPrices : EntityBase // My Handlebars Helper
    {
        public StdstoreItemPrices()
        {
            StdstoreItemPricesIngredients = new HashSet<StdstoreItemPricesIngredients>();
        }

        public Guid Id { get; set; }
        public Guid StoreItemid { get; set; }
        public Guid? StoreItemSizesid { get; set; }
        public bool Isdeleted { get; set; }
        public double? StorePrice { get; set; }
        public double? OnlinePrice { get; set; }
        public string? Curcode { get; set; }
        public DateTime Adddate { get; set; }
        public Guid Adduser { get; set; }
        public DateTime? Editdate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Sellstart { get; set; }
        public DateTime? Sellend { get; set; }
        public string? Selldays { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Curcode? CurcodeNavigation { get; set; }
        public virtual StdstoreItems StoreItem { get; set; } = null!;
        public virtual StdstoreItemSizes? StoreItemSizes { get; set; }
        public virtual ICollection<StdstoreItemPricesIngredients> StdstoreItemPricesIngredients { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
