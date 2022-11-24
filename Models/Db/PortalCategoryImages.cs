using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class PortalCategoryImages : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid Catid { get; set; }
        public string? Groupname { get; set; }
        public string? Description { get; set; }
        public string Thumbnailurl { get; set; } = null!;
        public string Imageurl { get; set; } = null!;
        public int Sortindex { get; set; }
        public bool Isdisabled { get; set; }
        public bool Isdeleted { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual PortalCategories Cat { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
