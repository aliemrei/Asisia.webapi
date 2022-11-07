using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class TOUR_PRICES : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid TOURID { get; set; }
        public DateTime DEPARTURE_DATE { get; set; }
        public string DEPARTURE_LOCATION { get; set; } = null!;
        public string? DESCRIPTION { get; set; }
        public double? COMMISSIONPERCENT { get; set; }
        public bool? COMMISSIONINCLUDED { get; set; }
        public decimal? SNG { get; set; }
        public decimal? DBL { get; set; }
        public decimal? TRP { get; set; }
        public decimal? QUAD { get; set; }
        public decimal? EXBED { get; set; }
        public decimal? BABY { get; set; }
        public decimal? CHDY { get; set; }
        public decimal? CHDE { get; set; }
        public string CURCODE { get; set; } = null!;
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual CURCODE CURCODENavigation { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual TOUR TOUR { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
