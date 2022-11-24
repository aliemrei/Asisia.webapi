using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class Tourdiscount : EntityBase // My Handlebars Helper
    {
        public Tourdiscount()
        {
            TourDiscounts = new HashSet<TourDiscounts>();
        }

        public byte Id { get; set; }
        public string? Definition { get; set; }

        public virtual ICollection<TourDiscounts> TourDiscounts { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
