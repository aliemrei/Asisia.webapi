using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class COUNTRY : EntityBase // My Handlebars Helper
    {
        public COUNTRY()
        {
            CITY = new HashSet<CITY>();
            LOCATION_ADDRESS = new HashSet<LOCATION_ADDRESS>();
            PERSON = new HashSet<PERSON>();
        }

        public Guid ID { get; set; }
        public string NAME { get; set; } = null!;
        public string? ISOCODE2 { get; set; }
        public string? DIAL_CODE { get; set; }

        public virtual ICollection<CITY> CITY { get; set; }
        public virtual ICollection<LOCATION_ADDRESS> LOCATION_ADDRESS { get; set; }
        public virtual ICollection<PERSON> PERSON { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
