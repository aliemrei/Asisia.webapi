using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class STDSTORE_ITEM_PRICES_INGREDIENTS : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid INGREDIENTID { get; set; }
        public bool ISDELETED { get; set; }
        public double? PRICE { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public Guid PRICEID { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual STDSTORE_ITEM_INGREDIENTS INGREDIENT { get; set; } = null!;
        public virtual STDSTORE_ITEM_PRICES PRICENavigation { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
