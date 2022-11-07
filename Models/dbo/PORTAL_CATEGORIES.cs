using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class PORTAL_CATEGORIES : EntityBase // My Handlebars Helper
    {
        public PORTAL_CATEGORIES()
        {
            PORTAL_CATEGORY_IMAGES = new HashSet<PORTAL_CATEGORY_IMAGES>();
            PORTAL_CATEGORY_ITEMS = new HashSet<PORTAL_CATEGORY_ITEMS>();
        }

        public Guid ID { get; set; }
        public int PORTALID { get; set; }
        public string? DESCRIPTION { get; set; }
        public string? URL { get; set; }
        public bool ISDELETED { get; set; }
        public bool ISDISABLED { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public string DEFINITION { get; set; } = null!;
        public string TYPE { get; set; } = null!;
        public int INTID { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual PORTAL PORTAL { get; set; } = null!;
        public virtual ICollection<PORTAL_CATEGORY_IMAGES> PORTAL_CATEGORY_IMAGES { get; set; }
        public virtual ICollection<PORTAL_CATEGORY_ITEMS> PORTAL_CATEGORY_ITEMS { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
