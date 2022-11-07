using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class STDSTORE_ITEM_GROUPS : EntityBase // My Handlebars Helper
    {
        public STDSTORE_ITEM_GROUPS()
        {
            STDSTORE_ITEMS_GROUPS = new HashSet<STDSTORE_ITEMS_GROUPS>();
            STDSTORE_ITEM_GROUP_ITEMS = new HashSet<STDSTORE_ITEM_GROUP_ITEMS>();
        }

        public Guid ID { get; set; }
        public Guid STOREID { get; set; }
        public string DEFINITION { get; set; } = null!;
        public string? DESCRIPTION { get; set; }
        public bool SHOWINPORTAL { get; set; }
        public bool ISDELETED { get; set; }
        public bool ISDISABLED { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public string? THUMBNAILURL { get; set; }
        public string? TITLE { get; set; }
        public int SORTINDEX { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual STDSTORE STORE { get; set; } = null!;
        public virtual ICollection<STDSTORE_ITEMS_GROUPS> STDSTORE_ITEMS_GROUPS { get; set; }
        public virtual ICollection<STDSTORE_ITEM_GROUP_ITEMS> STDSTORE_ITEM_GROUP_ITEMS { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
