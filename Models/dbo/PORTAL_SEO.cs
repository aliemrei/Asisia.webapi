using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class PORTAL_SEO : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public int? PORTALID { get; set; }
        public Guid? PROJECT_DETAILID { get; set; }
        public string LANG { get; set; } = null!;
        public string? URL { get; set; }
        public string? TITLE { get; set; }
        public string? DESCRIPTION { get; set; }
        public string? KEYWORDS { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public Guid PORTALUID { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual STDLANGUAGES LANGNavigation { get; set; } = null!;
        public virtual PROJECT_GROUPDETAIL? PROJECT_DETAIL { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
