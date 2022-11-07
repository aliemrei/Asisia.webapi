using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class CONTACT_CATEGORY : EntityBase // My Handlebars Helper
    {
        public CONTACT_CATEGORY()
        {
            CONTACT_FORM = new HashSet<CONTACT_FORM>();
        }

        public Guid ID { get; set; }
        public string DEFINITION { get; set; } = null!;
        public Guid CORPID { get; set; }

        public virtual CORP CORP { get; set; } = null!;
        public virtual ICollection<CONTACT_FORM> CONTACT_FORM { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
