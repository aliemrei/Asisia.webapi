using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class StdstoreItemGroups : EntityBase // My Handlebars Helper
    {
        public StdstoreItemGroups()
        {
            StdstoreItemGroupItems = new HashSet<StdstoreItemGroupItems>();
            StdstoreItemsGroups = new HashSet<StdstoreItemsGroups>();
        }

        public Guid Id { get; set; }
        public Guid Storeid { get; set; }
        public string Definition { get; set; } = null!;
        public string? Description { get; set; }
        public bool Showinportal { get; set; }
        public bool Isdeleted { get; set; }
        public bool Isdisabled { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public string? Thumbnailurl { get; set; }
        public string? Title { get; set; }
        public int Sortindex { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual Stdstore Store { get; set; } = null!;
        public virtual ICollection<StdstoreItemGroupItems> StdstoreItemGroupItems { get; set; }
        public virtual ICollection<StdstoreItemsGroups> StdstoreItemsGroups { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
