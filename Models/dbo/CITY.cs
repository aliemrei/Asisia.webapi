using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class CITY : EntityBase // My Handlebars Helper
    {
        public CITY()
        {
            DISTRICT = new HashSet<DISTRICT>();
            LOCATION_ADDRESS = new HashSet<LOCATION_ADDRESS>();
        }

        public Guid ID { get; set; }
        public Guid? COUNTRYID { get; set; }
        public string NAME { get; set; } = null!;

        public virtual COUNTRY? COUNTRY { get; set; }
        public virtual ICollection<DISTRICT> DISTRICT { get; set; }
        public virtual ICollection<LOCATION_ADDRESS> LOCATION_ADDRESS { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
