using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class Country : EntityBase // My Handlebars Helper
    {
        public Country()
        {
            City = new HashSet<City>();
            LocationAddress = new HashSet<LocationAddress>();
            Person = new HashSet<Person>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Isocode2 { get; set; }
        public string? DialCode { get; set; }

        public virtual ICollection<City> City { get; set; }
        public virtual ICollection<LocationAddress> LocationAddress { get; set; }
        public virtual ICollection<Person> Person { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
