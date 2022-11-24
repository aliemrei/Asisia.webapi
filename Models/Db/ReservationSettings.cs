using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class ReservationSettings : EntityBase // My Handlebars Helper
    {
        public ReservationSettings()
        {
            RequestDetail = new HashSet<RequestDetail>();
            ReservationSettingsMarket = new HashSet<ReservationSettingsMarket>();
        }

        public Guid Id { get; set; }
        public Guid? Hotelid { get; set; }
        public Guid? Tourid { get; set; }
        public Guid? Ticketid { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Finishdate { get; set; }
        public double CancelationRate { get; set; }
        public int CancelationDays { get; set; }
        public string? CancelationDescription { get; set; }
        public DateTime Adddate { get; set; }
        public Guid Adduser { get; set; }
        public DateTime? Editdate { get; set; }
        public Guid? Edituser { get; set; }
        public double? PaymentRate { get; set; }
        public double? CancellationWarrantyRate { get; set; }
        public bool? MenAccommodationForbidden { get; set; }
        public bool? ChildrenAccommodationForbidden { get; set; }
        public int? ChildrenMaxage { get; set; }
        public int? PaymentRateMaxDay { get; set; }
        public int? CancellationWarrantyRateMaxDay { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Stdhotel? Hotel { get; set; }
        public virtual Ticket? Ticket { get; set; }
        public virtual Tour? Tour { get; set; }
        public virtual ICollection<RequestDetail> RequestDetail { get; set; }
        public virtual ICollection<ReservationSettingsMarket> ReservationSettingsMarket { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
