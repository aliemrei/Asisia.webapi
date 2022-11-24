using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class ProjectGroupdetailSeo : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public string Lang { get; set; } = null!;
        public string? Url { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Keywords { get; set; }
        public Guid ProjectDetailid { get; set; }

        public virtual Stdlanguages LangNavigation { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
