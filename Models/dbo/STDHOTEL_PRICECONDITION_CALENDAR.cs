using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class STDHOTEL_PRICECONDITION_CALENDAR : EntityBase // My Handlebars Helper
    {
        public Guid PRICECONDITIONID { get; set; }
        public DateTime DATE { get; set; }
        public decimal? BASERATE { get; set; }
        public int? QUOTA { get; set; }
        public bool? STOP_CHECKIN { get; set; }
        public bool? STOP_CHECKOUT { get; set; }
        public bool? STOP_SELL { get; set; }
        public int? RELEASE_DAY { get; set; }
        public int? MIN_LOS { get; set; }
        public int? MAX_LOS { get; set; }
        public int? FREE_SELL { get; set; }
        public int ID { get; set; }
        public DateTime? RELEASEDATE { get; set; }

        public virtual STDHOTEL_PRICECONDITION PRICECONDITION { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
