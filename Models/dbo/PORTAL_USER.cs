using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class PORTAL_USER : EntityBase // My Handlebars Helper
    {
        public PORTAL_USER()
        {
            PORTAL_USER_SOCIALACCOUNT = new HashSet<PORTAL_USER_SOCIALACCOUNT>();
        }

        public Guid ID { get; set; }
        public Guid? PERSONID { get; set; }
        public string? PWD { get; set; }
        public string? CHANGEKEY { get; set; }
        public DateTime? CHANGEDATE { get; set; }
        public string? EMAIL { get; set; }
        public long? PHONE { get; set; }

        public virtual PERSON? PERSON { get; set; }
        public virtual ICollection<PORTAL_USER_SOCIALACCOUNT> PORTAL_USER_SOCIALACCOUNT { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
