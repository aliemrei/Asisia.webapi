using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class RESERVATION_SETTINGS_MARKET : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public Guid SETTINGSID { get; set; }
        public Guid MARKETID { get; set; }

        public virtual STDHOTEL_MARKET MARKET { get; set; } = null!;
        public virtual RESERVATION_SETTINGS SETTINGS { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
