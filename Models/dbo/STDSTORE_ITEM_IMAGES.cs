using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class STDSTORE_ITEM_IMAGES : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public Guid? STORE_ITEMID { get; set; }
        public string? DEFINITION { get; set; }
        public bool? DEFAULT { get; set; }
        public int? SORTORDER { get; set; }
        public string? THUMBNAIL { get; set; }
        public string? URL { get; set; }
        public string? DESCRIPTION { get; set; }
        public Guid UID { get; set; }
        public Guid STORE_ITEM_SIZESID { get; set; }

        public virtual STDSTORE_ITEMS? STORE_ITEM { get; set; }
        public virtual STDSTORE_ITEM_SIZES STORE_ITEM_SIZES { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
