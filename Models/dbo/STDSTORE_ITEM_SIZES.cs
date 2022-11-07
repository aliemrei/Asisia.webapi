using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class STDSTORE_ITEM_SIZES : EntityBase // My Handlebars Helper
    {
        public STDSTORE_ITEM_SIZES()
        {
            STDSTORE_ITEM_IMAGES = new HashSet<STDSTORE_ITEM_IMAGES>();
            STDSTORE_ITEM_INGREDIENTS = new HashSet<STDSTORE_ITEM_INGREDIENTS>();
            STDSTORE_ITEM_PRICES = new HashSet<STDSTORE_ITEM_PRICES>();
        }

        public Guid ID { get; set; }
        public Guid STORE_ITEMID { get; set; }
        public string DEFINITION { get; set; } = null!;
        public string? DESCRIPTION { get; set; }
        public bool ISDELETED { get; set; }
        public bool ISDISABLED { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public Guid? EDITUSER { get; set; }

        public virtual ICollection<STDSTORE_ITEM_IMAGES> STDSTORE_ITEM_IMAGES { get; set; }
        public virtual ICollection<STDSTORE_ITEM_INGREDIENTS> STDSTORE_ITEM_INGREDIENTS { get; set; }
        public virtual ICollection<STDSTORE_ITEM_PRICES> STDSTORE_ITEM_PRICES { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
