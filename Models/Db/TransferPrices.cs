using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class TransferPrices : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid Corpid { get; set; }
        public string Vehicletype { get; set; } = null!;
        public Guid Fromlocationid { get; set; }
        public Guid Tolocationid { get; set; }
        public short Pricetype { get; set; }
        public DateTime? Sellfrom { get; set; }
        public DateTime? Sellto { get; set; }
        public DateTime? Ticketdatefrom { get; set; }
        public DateTime? Ticketdateto { get; set; }
        public string? Arrivaldays { get; set; }
        public string? Departuredays { get; set; }
        public string? Selldays { get; set; }
        public int? Pricesort { get; set; }
        public decimal? AdultpriceOneway { get; set; }
        public decimal? ChildpriceOneway { get; set; }
        public decimal? BabypriceOneway { get; set; }
        public decimal? AdultpriceTwoway { get; set; }
        public decimal? ChildpriceTwoway { get; set; }
        public decimal? BabypriceTwoway { get; set; }
        public decimal? VehiclepriceOneway { get; set; }
        public decimal? VehiclepriceTwoway { get; set; }
        public string? Curcode { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public Guid? Agencyid { get; set; }
        public Guid? Marketid { get; set; }
        public Guid Vehicletypeid { get; set; }
        public Guid? Providerid { get; set; }
        public short Useonline { get; set; }
        public bool Useinbasket { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Agency? Agency { get; set; }
        public virtual Corp Corp { get; set; } = null!;
        public virtual Curcode? CurcodeNavigation { get; set; }
        public virtual Users? EdituserNavigation { get; set; }
        public virtual Stdmarkets? Market { get; set; }
        public virtual TransferProviders? Provider { get; set; }
        public virtual Vehicletypes Vehicletype1 { get; set; } = null!;
        public virtual Stdvehicletypes VehicletypeNavigation { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
