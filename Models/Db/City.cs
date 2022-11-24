using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class City : EntityBase // My Handlebars Helper
    {
        public City()
        {
            District = new HashSet<District>();
            LocationAddress = new HashSet<LocationAddress>();
        }

        public Guid Id { get; set; }
        public Guid? Countryid { get; set; }
        public string Name { get; set; } = null!;

        public virtual Country? Country { get; set; }
        public virtual ICollection<District> District { get; set; }
        public virtual ICollection<LocationAddress> LocationAddress { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
