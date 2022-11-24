using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class Stdmarkets : EntityBase // My Handlebars Helper
    {
        public Stdmarkets()
        {
            PromotionCodesMarket = new HashSet<PromotionCodesMarket>();
            StdhotelMarket = new HashSet<StdhotelMarket>();
            StdmarketCountries = new HashSet<StdmarketCountries>();
            TicketMarket = new HashSet<TicketMarket>();
            TicketPrices = new HashSet<TicketPrices>();
            TransferPrices = new HashSet<TransferPrices>();
        }

        public Guid Id { get; set; }
        public Guid Corpid { get; set; }
        public string Definition { get; set; } = null!;
        public string? Curcode { get; set; }
        public string? Language { get; set; }
        public bool ForceBaskettocurcode { get; set; }

        public virtual Corp Corp { get; set; } = null!;
        public virtual ICollection<PromotionCodesMarket> PromotionCodesMarket { get; set; }
        public virtual ICollection<StdhotelMarket> StdhotelMarket { get; set; }
        public virtual ICollection<StdmarketCountries> StdmarketCountries { get; set; }
        public virtual ICollection<TicketMarket> TicketMarket { get; set; }
        public virtual ICollection<TicketPrices> TicketPrices { get; set; }
        public virtual ICollection<TransferPrices> TransferPrices { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
