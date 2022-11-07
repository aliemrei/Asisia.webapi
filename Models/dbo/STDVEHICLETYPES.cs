using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class STDVEHICLETYPES : EntityBase // My Handlebars Helper
    {
        public STDVEHICLETYPES()
        {
            TRANSFER_PRICES = new HashSet<TRANSFER_PRICES>();
            VEHICLETYPES = new HashSet<VEHICLETYPES>();
        }

        public string VEHICLETYPE { get; set; } = null!;
        public string? IMGTYPE { get; set; }

        public virtual ICollection<TRANSFER_PRICES> TRANSFER_PRICES { get; set; }
        public virtual ICollection<VEHICLETYPES> VEHICLETYPES { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
