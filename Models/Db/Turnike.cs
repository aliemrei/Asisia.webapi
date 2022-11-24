using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class Turnike : EntityBase // My Handlebars Helper
    {
        public Turnike()
        {
            TicketActivations = new HashSet<TicketActivations>();
        }

        public Guid Corpid { get; set; }
        public string Gatenumber { get; set; } = null!;
        public bool? Direction { get; set; }

        public virtual Corp Corp { get; set; } = null!;
        public virtual ICollection<TicketActivations> TicketActivations { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
