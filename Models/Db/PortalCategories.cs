using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class PortalCategories : EntityBase // My Handlebars Helper
    {
        public PortalCategories()
        {
            PortalCategoryImages = new HashSet<PortalCategoryImages>();
            PortalCategoryItems = new HashSet<PortalCategoryItems>();
        }

        public Guid Id { get; set; }
        public int Portalid { get; set; }
        public string? Description { get; set; }
        public string? Url { get; set; }
        public bool Isdeleted { get; set; }
        public bool Isdisabled { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public string Definition { get; set; } = null!;
        public string Type { get; set; } = null!;
        public int Intid { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual Portal Portal { get; set; } = null!;
        public virtual ICollection<PortalCategoryImages> PortalCategoryImages { get; set; }
        public virtual ICollection<PortalCategoryItems> PortalCategoryItems { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
