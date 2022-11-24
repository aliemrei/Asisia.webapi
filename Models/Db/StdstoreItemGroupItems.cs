using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class StdstoreItemGroupItems : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid Groupid { get; set; }
        public Guid Itemid { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual StdstoreItemGroups Group { get; set; } = null!;
        public virtual StdstoreItems Item { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
