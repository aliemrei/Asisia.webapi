using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class TICKET_PRICES : EntityBase // My Handlebars Helper
    {
        public TICKET_PRICES()
        {
            REQUEST_DETAIL = new HashSet<REQUEST_DETAIL>();
        }

        public int ID { get; set; }
        public Guid TICKETID { get; set; }
        public short PRICETYPE { get; set; }
        public DateTime? SELLFROM { get; set; }
        public DateTime? SELLTO { get; set; }
        public DateTime? TICKETDATEFROM { get; set; }
        public DateTime? TICKETDATETO { get; set; }
        public string? CHECKINDAYS { get; set; }
        public int? MAXVALIDCAPACITY { get; set; }
        public int? PRICESORT { get; set; }
        public decimal? ADULTPRICE { get; set; }
        public decimal? CHILDPRICE { get; set; }
        public string? CURCODE { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public Guid? AGENCYID { get; set; }
        public Guid? MARKETID { get; set; }
        public short PRICEKIND { get; set; }
        public double? UNITPRICE { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual AGENCY? AGENCY { get; set; }
        public virtual CURCODE? CURCODENavigation { get; set; }
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual STDMARKETS? MARKET { get; set; }
        public virtual TICKET TICKET { get; set; } = null!;
        public virtual ICollection<REQUEST_DETAIL> REQUEST_DETAIL { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
