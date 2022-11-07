using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class TOURDISCOUNT : EntityBase // My Handlebars Helper
    {
        public TOURDISCOUNT()
        {
            TOUR_DISCOUNTS = new HashSet<TOUR_DISCOUNTS>();
        }

        public byte ID { get; set; }
        public string? DEFINITION { get; set; }

        public virtual ICollection<TOUR_DISCOUNTS> TOUR_DISCOUNTS { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
