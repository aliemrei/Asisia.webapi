using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class PortalSeo : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public int? Portalid { get; set; }
        public Guid? ProjectDetailid { get; set; }
        public string Lang { get; set; } = null!;
        public string? Url { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Keywords { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public Guid Portaluid { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual Stdlanguages LangNavigation { get; set; } = null!;
        public virtual ProjectGroupdetail? ProjectDetail { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
