using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class TourPrices : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid Tourid { get; set; }
        public DateTime DepartureDate { get; set; }
        public string DepartureLocation { get; set; } = null!;
        public string? Description { get; set; }
        public double? Commissionpercent { get; set; }
        public bool? Commissionincluded { get; set; }
        public decimal? Sng { get; set; }
        public decimal? Dbl { get; set; }
        public decimal? Trp { get; set; }
        public decimal? Quad { get; set; }
        public decimal? Exbed { get; set; }
        public decimal? Baby { get; set; }
        public decimal? Chdy { get; set; }
        public decimal? Chde { get; set; }
        public string Curcode { get; set; } = null!;
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Curcode CurcodeNavigation { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual Tour Tour { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
