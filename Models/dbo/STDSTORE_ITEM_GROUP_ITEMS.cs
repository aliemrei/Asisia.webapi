using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class STDSTORE_ITEM_GROUP_ITEMS : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid GROUPID { get; set; }
        public Guid ITEMID { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual STDSTORE_ITEM_GROUPS GROUP { get; set; } = null!;
        public virtual STDSTORE_ITEMS ITEM { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
