using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("CURCODE")]
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

        [Key]
        [Column("CODE")]
        [StringLength(5)]
        [Unicode(false)]
        public string Code { get; set; } = null!;
        [Column("LOGO_ENTID")]
        public int? LogoEntid { get; set; }

        [InverseProperty("DefaultCurcodeNavigation")]
        public virtual ICollection<Agency> Agency { get; set; }
        [InverseProperty("CurcodeNavigation")]
        public virtual ICollection<BonusDef> BonusDef { get; set; }
        [InverseProperty("CurcodeNavigation")]
        public virtual ICollection<CashierHandoverEntity> CashierHandoverEntity { get; set; }
        [InverseProperty("CurcodeNavigation")]
        public virtual ICollection<Payments> Payments { get; set; }
        [InverseProperty("DefaultCurcodeNavigation")]
        public virtual ICollection<Portal> Portal { get; set; }
        [InverseProperty("CurcodeNavigation")]
        public virtual ICollection<PortalCurrencies> PortalCurrencies { get; set; }
        [InverseProperty("CurcodeNavigation")]
        public virtual ICollection<PromotionCodes> PromotionCodes { get; set; }
        [InverseProperty("CurcodeNavigation")]
        public virtual ICollection<StdhotelRatecodeMarkup> StdhotelRatecodeMarkup { get; set; }
        [InverseProperty("CurcodeNavigation")]
        public virtual ICollection<StdstoreItemPrices> StdstoreItemPrices { get; set; }
        [InverseProperty("CurcodeNavigation")]
        public virtual ICollection<TicketGifts> TicketGifts { get; set; }
        [InverseProperty("CurcodeNavigation")]
        public virtual ICollection<TicketPrices> TicketPrices { get; set; }
        [InverseProperty("CurcodeNavigation")]
        public virtual ICollection<TourPrices> TourPrices { get; set; }
        [InverseProperty("CurcodeNavigation")]
        public virtual ICollection<TransferPrices> TransferPrices { get; set; }
        [InverseProperty("CurcodeNavigation")]
        public virtual ICollection<VirtualPosAccountsCurcodes> VirtualPosAccountsCurcodes { get; set; }
        [InverseProperty("CurcodeNavigation")]
        public virtual ICollection<VirtualPosPayments> VirtualPosPayments { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
