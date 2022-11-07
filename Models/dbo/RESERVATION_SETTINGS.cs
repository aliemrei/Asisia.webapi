using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class RESERVATION_SETTINGS : EntityBase // My Handlebars Helper
    {
        public RESERVATION_SETTINGS()
        {
            REQUEST_DETAIL = new HashSet<REQUEST_DETAIL>();
            RESERVATION_SETTINGS_MARKET = new HashSet<RESERVATION_SETTINGS_MARKET>();
        }

        public Guid ID { get; set; }
        public Guid? HOTELID { get; set; }
        public Guid? TOURID { get; set; }
        public Guid? TICKETID { get; set; }
        public DateTime STARTDATE { get; set; }
        public DateTime FINISHDATE { get; set; }
        public double CANCELATION_RATE { get; set; }
        public int CANCELATION_DAYS { get; set; }
        public string? CANCELATION_DESCRIPTION { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public double? PAYMENT_RATE { get; set; }
        public double? CANCELLATION_WARRANTY_RATE { get; set; }
        public bool? MEN_ACCOMMODATION_FORBIDDEN { get; set; }
        public bool? CHILDREN_ACCOMMODATION_FORBIDDEN { get; set; }
        public int? CHILDREN_MAXAGE { get; set; }
        public int? PAYMENT_RATE_MAX_DAY { get; set; }
        public int? CANCELLATION_WARRANTY_RATE_MAX_DAY { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual STDHOTEL? HOTEL { get; set; }
        public virtual TICKET? TICKET { get; set; }
        public virtual TOUR? TOUR { get; set; }
        public virtual ICollection<REQUEST_DETAIL> REQUEST_DETAIL { get; set; }
        public virtual ICollection<RESERVATION_SETTINGS_MARKET> RESERVATION_SETTINGS_MARKET { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
