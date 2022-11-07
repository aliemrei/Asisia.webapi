using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class STDLANGUAGES : EntityBase // My Handlebars Helper
    {
        public STDLANGUAGES()
        {
            PORTAL_SEO = new HashSet<PORTAL_SEO>();
            PROJECT_GROUPDETAIL_SEO = new HashSet<PROJECT_GROUPDETAIL_SEO>();
            REQUEST = new HashSet<REQUEST>();
            VIRTUAL_POS_PAYMENT_TEMPS = new HashSet<VIRTUAL_POS_PAYMENT_TEMPS>();
        }

        public string CODE { get; set; } = null!;
        public string DEFINITION { get; set; } = null!;

        public virtual ICollection<PORTAL_SEO> PORTAL_SEO { get; set; }
        public virtual ICollection<PROJECT_GROUPDETAIL_SEO> PROJECT_GROUPDETAIL_SEO { get; set; }
        public virtual ICollection<REQUEST> REQUEST { get; set; }
        public virtual ICollection<VIRTUAL_POS_PAYMENT_TEMPS> VIRTUAL_POS_PAYMENT_TEMPS { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
