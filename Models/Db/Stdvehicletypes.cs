using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class Stdvehicletypes : EntityBase // My Handlebars Helper
    {
        public Stdvehicletypes()
        {
            TransferPrices = new HashSet<TransferPrices>();
            Vehicletypes = new HashSet<Vehicletypes>();
        }

        public string Vehicletype { get; set; } = null!;
        public string? Imgtype { get; set; }

        public virtual ICollection<TransferPrices> TransferPrices { get; set; }
        public virtual ICollection<Vehicletypes> Vehicletypes { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
