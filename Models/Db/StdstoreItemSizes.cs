using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class StdstoreItemSizes : EntityBase // My Handlebars Helper
    {
        public StdstoreItemSizes()
        {
            StdstoreItemImages = new HashSet<StdstoreItemImages>();
            StdstoreItemIngredients = new HashSet<StdstoreItemIngredients>();
            StdstoreItemPrices = new HashSet<StdstoreItemPrices>();
        }

        public Guid Id { get; set; }
        public Guid StoreItemid { get; set; }
        public string Definition { get; set; } = null!;
        public string? Description { get; set; }
        public bool Isdeleted { get; set; }
        public bool Isdisabled { get; set; }
        public DateTime Adddate { get; set; }
        public Guid Adduser { get; set; }
        public DateTime? Editdate { get; set; }
        public Guid? Edituser { get; set; }

        public virtual ICollection<StdstoreItemImages> StdstoreItemImages { get; set; }
        public virtual ICollection<StdstoreItemIngredients> StdstoreItemIngredients { get; set; }
        public virtual ICollection<StdstoreItemPrices> StdstoreItemPrices { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
