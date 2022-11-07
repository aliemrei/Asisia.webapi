using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class DISTRICT : EntityBase // My Handlebars Helper
    {
        public DISTRICT()
        {
            LOCATION_ADDRESS = new HashSet<LOCATION_ADDRESS>();
        }

        public Guid ID { get; set; }
        public Guid CITYID { get; set; }
        public string? NAME { get; set; }

        public virtual CITY CITY { get; set; } = null!;
        public virtual ICollection<LOCATION_ADDRESS> LOCATION_ADDRESS { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
