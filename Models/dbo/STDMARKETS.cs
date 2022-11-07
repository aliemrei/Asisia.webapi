using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class STDMARKETS : EntityBase // My Handlebars Helper
    {
        public STDMARKETS()
        {
            PROMOTION_CODES_MARKET = new HashSet<PROMOTION_CODES_MARKET>();
            STDHOTEL_MARKET = new HashSet<STDHOTEL_MARKET>();
            STDMARKET_COUNTRIES = new HashSet<STDMARKET_COUNTRIES>();
            TICKET_MARKET = new HashSet<TICKET_MARKET>();
            TICKET_PRICES = new HashSet<TICKET_PRICES>();
            TRANSFER_PRICES = new HashSet<TRANSFER_PRICES>();
        }

        public Guid ID { get; set; }
        public Guid CORPID { get; set; }
        public string DEFINITION { get; set; } = null!;
        public string? CURCODE { get; set; }
        public string? LANGUAGE { get; set; }
        public bool FORCE_BASKETTOCURCODE { get; set; }

        public virtual CORP CORP { get; set; } = null!;
        public virtual ICollection<PROMOTION_CODES_MARKET> PROMOTION_CODES_MARKET { get; set; }
        public virtual ICollection<STDHOTEL_MARKET> STDHOTEL_MARKET { get; set; }
        public virtual ICollection<STDMARKET_COUNTRIES> STDMARKET_COUNTRIES { get; set; }
        public virtual ICollection<TICKET_MARKET> TICKET_MARKET { get; set; }
        public virtual ICollection<TICKET_PRICES> TICKET_PRICES { get; set; }
        public virtual ICollection<TRANSFER_PRICES> TRANSFER_PRICES { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
