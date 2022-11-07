using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class TURNIKE : EntityBase // My Handlebars Helper
    {
        public TURNIKE()
        {
            TICKET_ACTIVATIONS = new HashSet<TICKET_ACTIVATIONS>();
        }

        public Guid CORPID { get; set; }
        public string GATENUMBER { get; set; } = null!;
        public bool? DIRECTION { get; set; }

        public virtual CORP CORP { get; set; } = null!;
        public virtual ICollection<TICKET_ACTIVATIONS> TICKET_ACTIVATIONS { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
