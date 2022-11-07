using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class STDSTORE_ITEM_INGREDIENTS : EntityBase // My Handlebars Helper
    {
        public STDSTORE_ITEM_INGREDIENTS()
        {
            STDSTORE_ITEM_PRICES_INGREDIENTS = new HashSet<STDSTORE_ITEM_PRICES_INGREDIENTS>();
        }

        public Guid ID { get; set; }
        public Guid STORE_ITEMID { get; set; }
        public Guid? STORE_ITEM_SIZESID { get; set; }
        public bool ISDELETED { get; set; }
        public string DEFINITION { get; set; } = null!;
        public DateTime ADDDATE { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public Guid? EDITUSER { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual STDSTORE_ITEMS STORE_ITEM { get; set; } = null!;
        public virtual STDSTORE_ITEM_SIZES? STORE_ITEM_SIZES { get; set; }
        public virtual ICollection<STDSTORE_ITEM_PRICES_INGREDIENTS> STDSTORE_ITEM_PRICES_INGREDIENTS { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
