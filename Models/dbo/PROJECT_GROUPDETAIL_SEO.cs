using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class PROJECT_GROUPDETAIL_SEO : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public string LANG { get; set; } = null!;
        public string? URL { get; set; }
        public string? TITLE { get; set; }
        public string? DESCRIPTION { get; set; }
        public string? KEYWORDS { get; set; }
        public Guid PROJECT_DETAILID { get; set; }

        public virtual STDLANGUAGES LANGNavigation { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
