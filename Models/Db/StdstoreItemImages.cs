using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class StdstoreItemImages : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public Guid? StoreItemid { get; set; }
        public string? Definition { get; set; }
        public bool? Default { get; set; }
        public int? Sortorder { get; set; }
        public string? Thumbnail { get; set; }
        public string? Url { get; set; }
        public string? Description { get; set; }
        public Guid Uid { get; set; }
        public Guid StoreItemSizesid { get; set; }

        public virtual StdstoreItems? StoreItem { get; set; }
        public virtual StdstoreItemSizes StoreItemSizes { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
