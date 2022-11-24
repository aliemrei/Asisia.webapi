using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
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

        public Guid Id { get; set; }
        public Guid Storeid { get; set; }
        public string Definition { get; set; } = null!;
        public string? Description { get; set; }
        public bool Isdeleted { get; set; }
        public bool Isdisabled { get; set; }
        public DateTime Adddate { get; set; }
        public Guid Adduser { get; set; }
        public DateTime? Editdate { get; set; }
        public Guid? Edituser { get; set; }

        public virtual ICollection<StdstoreItemGroupItems> StdstoreItemGroupItems { get; set; }
        public virtual ICollection<StdstoreItemImages> StdstoreItemImages { get; set; }
        public virtual ICollection<StdstoreItemIngredients> StdstoreItemIngredients { get; set; }
        public virtual ICollection<StdstoreItemPrices> StdstoreItemPrices { get; set; }
        public virtual ICollection<StdstoreItemsGroups> StdstoreItemsGroups { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
