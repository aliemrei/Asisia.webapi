using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class PROPERTY_PROVIDERS : EntityBase // My Handlebars Helper
    {
        public PROPERTY_PROVIDERS()
        {
            PROPERTY_MAPPING = new HashSet<PROPERTY_MAPPING>();
        }

        public Guid ID { get; set; }
        public Guid? CORPID { get; set; }
        public string CODE { get; set; } = null!;
        public string? NAME { get; set; }

        public virtual CORP? CORP { get; set; }
        public virtual ICollection<PROPERTY_MAPPING> PROPERTY_MAPPING { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
