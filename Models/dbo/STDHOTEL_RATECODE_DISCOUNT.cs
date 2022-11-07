using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class STDHOTEL_RATECODE_DISCOUNT : EntityBase // My Handlebars Helper
    {
        public STDHOTEL_RATECODE_DISCOUNT()
        {
            STDHOTEL_RATECODE_DISCOUNT_CONTRACT = new HashSet<STDHOTEL_RATECODE_DISCOUNT_CONTRACT>();
            STDHOTEL_RATECODE_DISCOUNT_MARKET = new HashSet<STDHOTEL_RATECODE_DISCOUNT_MARKET>();
            STDHOTEL_RATECODE_DISCOUNT_RATETYPE = new HashSet<STDHOTEL_RATECODE_DISCOUNT_RATETYPE>();
            STDHOTEL_RATECODE_DISCOUNT_ROOMTYPE = new HashSet<STDHOTEL_RATECODE_DISCOUNT_ROOMTYPE>();
        }

        public Guid ID { get; set; }
        public Guid HOTELID { get; set; }
        public Guid RATECODEID { get; set; }
        public string? DEFINITION { get; set; }
        public byte? BASICTYPE { get; set; }
        public double DISCOUNT { get; set; }
        public byte DISCOUNTTYPE { get; set; }
        public bool APPLYALONE { get; set; }
        public byte APPLYORDER { get; set; }
        public DateTime? SELLFROM { get; set; }
        public DateTime? SELLTO { get; set; }
        public DateTime? STAYFROM { get; set; }
        public DateTime? STAYTO { get; set; }
        public DateTime? APPLYFROM { get; set; }
        public DateTime? APPLYTO { get; set; }
        public string? CHECKINDAYS { get; set; }
        public string? CHECKOUTDAYS { get; set; }
        public string? STAYINGDAYS { get; set; }
        public byte? MINLOS { get; set; }
        public byte? MAXLOS { get; set; }
        public byte? MINPAX { get; set; }
        public byte? MAXPAX { get; set; }
        public byte APPLYTYPE { get; set; }
        public byte APPLYZONE { get; set; }
        public bool ADDITIONAL_DISCOUNT { get; set; }
        public byte ADDITIONAL_EFFECT { get; set; }
        public string? APPLYDAYS { get; set; }
        public Guid? AGENCYID { get; set; }

        public virtual AGENCY? AGENCY { get; set; }
        public virtual STDHOTELDISCOUNT DISCOUNTTYPENavigation { get; set; } = null!;
        public virtual STDHOTEL HOTEL { get; set; } = null!;
        public virtual STDHOTEL_RATECODE RATECODE { get; set; } = null!;
        public virtual ICollection<STDHOTEL_RATECODE_DISCOUNT_CONTRACT> STDHOTEL_RATECODE_DISCOUNT_CONTRACT { get; set; }
        public virtual ICollection<STDHOTEL_RATECODE_DISCOUNT_MARKET> STDHOTEL_RATECODE_DISCOUNT_MARKET { get; set; }
        public virtual ICollection<STDHOTEL_RATECODE_DISCOUNT_RATETYPE> STDHOTEL_RATECODE_DISCOUNT_RATETYPE { get; set; }
        public virtual ICollection<STDHOTEL_RATECODE_DISCOUNT_ROOMTYPE> STDHOTEL_RATECODE_DISCOUNT_ROOMTYPE { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
