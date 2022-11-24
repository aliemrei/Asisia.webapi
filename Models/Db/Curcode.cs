using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class Curcode : EntityBase // My Handlebars Helper
    {
        public Curcode()
        {
            Agency = new HashSet<Agency>();
            BonusDef = new HashSet<BonusDef>();
            CashierHandoverEntity = new HashSet<CashierHandoverEntity>();
            Payments = new HashSet<Payments>();
            Portal = new HashSet<Portal>();
            PortalCurrencies = new HashSet<PortalCurrencies>();
            PromotionCodes = new HashSet<PromotionCodes>();
            StdhotelRatecodeMarkup = new HashSet<StdhotelRatecodeMarkup>();
            StdstoreItemPrices = new HashSet<StdstoreItemPrices>();
            TicketGifts = new HashSet<TicketGifts>();
            TicketPrices = new HashSet<TicketPrices>();
            TourPrices = new HashSet<TourPrices>();
            TransferPrices = new HashSet<TransferPrices>();
            VirtualPosAccountsCurcodes = new HashSet<VirtualPosAccountsCurcodes>();
            VirtualPosPayments = new HashSet<VirtualPosPayments>();
        }

        public string Code { get; set; } = null!;
        public int? LogoEntid { get; set; }

        public virtual ICollection<Agency> Agency { get; set; }
        public virtual ICollection<BonusDef> BonusDef { get; set; }
        public virtual ICollection<CashierHandoverEntity> CashierHandoverEntity { get; set; }
        public virtual ICollection<Payments> Payments { get; set; }
        public virtual ICollection<Portal> Portal { get; set; }
        public virtual ICollection<PortalCurrencies> PortalCurrencies { get; set; }
        public virtual ICollection<PromotionCodes> PromotionCodes { get; set; }
        public virtual ICollection<StdhotelRatecodeMarkup> StdhotelRatecodeMarkup { get; set; }
        public virtual ICollection<StdstoreItemPrices> StdstoreItemPrices { get; set; }
        public virtual ICollection<TicketGifts> TicketGifts { get; set; }
        public virtual ICollection<TicketPrices> TicketPrices { get; set; }
        public virtual ICollection<TourPrices> TourPrices { get; set; }
        public virtual ICollection<TransferPrices> TransferPrices { get; set; }
        public virtual ICollection<VirtualPosAccountsCurcodes> VirtualPosAccountsCurcodes { get; set; }
        public virtual ICollection<VirtualPosPayments> VirtualPosPayments { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
