using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class TRANSFER_PRICES : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid CORPID { get; set; }
        public string VEHICLETYPE { get; set; } = null!;
        public Guid FROMLOCATIONID { get; set; }
        public Guid TOLOCATIONID { get; set; }
        public short PRICETYPE { get; set; }
        public DateTime? SELLFROM { get; set; }
        public DateTime? SELLTO { get; set; }
        public DateTime? TICKETDATEFROM { get; set; }
        public DateTime? TICKETDATETO { get; set; }
        public string? ARRIVALDAYS { get; set; }
        public string? DEPARTUREDAYS { get; set; }
        public string? SELLDAYS { get; set; }
        public int? PRICESORT { get; set; }
        public decimal? ADULTPRICE_ONEWAY { get; set; }
        public decimal? CHILDPRICE_ONEWAY { get; set; }
        public decimal? BABYPRICE_ONEWAY { get; set; }
        public decimal? ADULTPRICE_TWOWAY { get; set; }
        public decimal? CHILDPRICE_TWOWAY { get; set; }
        public decimal? BABYPRICE_TWOWAY { get; set; }
        public decimal? VEHICLEPRICE_ONEWAY { get; set; }
        public decimal? VEHICLEPRICE_TWOWAY { get; set; }
        public string? CURCODE { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public Guid? AGENCYID { get; set; }
        public Guid? MARKETID { get; set; }
        public Guid VEHICLETYPEID { get; set; }
        public Guid? PROVIDERID { get; set; }
        public short USEONLINE { get; set; }
        public bool USEINBASKET { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual AGENCY? AGENCY { get; set; }
        public virtual CORP CORP { get; set; } = null!;
        public virtual CURCODE? CURCODENavigation { get; set; }
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual STDMARKETS? MARKET { get; set; }
        public virtual TRANSFER_PROVIDERS? PROVIDER { get; set; }
        public virtual VEHICLETYPES VEHICLETYPE1 { get; set; } = null!;
        public virtual STDVEHICLETYPES VEHICLETYPENavigation { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
