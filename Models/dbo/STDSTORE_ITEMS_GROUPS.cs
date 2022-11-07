using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class STDSTORE_ITEMS_GROUPS : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid GROUPID { get; set; }
        public Guid ITEMID { get; set; }
        public int SORTINDEX { get; set; }

        public virtual STDSTORE_ITEM_GROUPS GROUP { get; set; } = null!;
        public virtual STDSTORE_ITEMS ITEM { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
