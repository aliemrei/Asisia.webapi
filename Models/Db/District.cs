using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class District : EntityBase // My Handlebars Helper
    {
        public District()
        {
            LocationAddress = new HashSet<LocationAddress>();
        }

        public Guid Id { get; set; }
        public Guid Cityid { get; set; }
        public string? Name { get; set; }

        public virtual City City { get; set; } = null!;
        public virtual ICollection<LocationAddress> LocationAddress { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
