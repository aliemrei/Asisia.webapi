using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class ReservationSettingsMarket : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public Guid Settingsid { get; set; }
        public Guid Marketid { get; set; }

        public virtual StdhotelMarket Market { get; set; } = null!;
        public virtual ReservationSettings Settings { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
