using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class TicketPrices : EntityBase // My Handlebars Helper
    {
        public TicketPrices()
        {
            RequestDetail = new HashSet<RequestDetail>();
        }

        public int Id { get; set; }
        public Guid Ticketid { get; set; }
        public short Pricetype { get; set; }
        public DateTime? Sellfrom { get; set; }
        public DateTime? Sellto { get; set; }
        public DateTime? Ticketdatefrom { get; set; }
        public DateTime? Ticketdateto { get; set; }
        public string? Checkindays { get; set; }
        public int? Maxvalidcapacity { get; set; }
        public int? Pricesort { get; set; }
        public decimal? Adultprice { get; set; }
        public decimal? Childprice { get; set; }
        public string? Curcode { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public Guid? Agencyid { get; set; }
        public Guid? Marketid { get; set; }
        public short Pricekind { get; set; }
        public double? Unitprice { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Agency? Agency { get; set; }
        public virtual Curcode? CurcodeNavigation { get; set; }
        public virtual Users? EdituserNavigation { get; set; }
        public virtual Stdmarkets? Market { get; set; }
        public virtual Ticket Ticket { get; set; } = null!;
        public virtual ICollection<RequestDetail> RequestDetail { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
