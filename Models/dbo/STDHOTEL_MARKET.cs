using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class STDHOTEL_MARKET : EntityBase // My Handlebars Helper
    {
        public STDHOTEL_MARKET()
        {
            REQUEST_DETAIL = new HashSet<REQUEST_DETAIL>();
            RESERVATION_SETTINGS_MARKET = new HashSet<RESERVATION_SETTINGS_MARKET>();
            STDHOTEL_PRICECONDITION = new HashSet<STDHOTEL_PRICECONDITION>();
            STDHOTEL_RATECODE_DISCOUNT_MARKET = new HashSet<STDHOTEL_RATECODE_DISCOUNT_MARKET>();
            STDHOTEL_RATECODE_MARKUP_MARKETS = new HashSet<STDHOTEL_RATECODE_MARKUP_MARKETS>();
        }

        public Guid ID { get; set; }
        public Guid HOTELID { get; set; }
        public string DEFINITION { get; set; } = null!;
        public string? ENT_ID { get; set; }
        public Guid? STDMARKETID { get; set; }
        public string? ENT_ETSID { get; set; }
        public string? ENT_TOURISTICAID { get; set; }
        public string? ENT_TATILBUDURID { get; set; }
        public string? ENT_IATIID { get; set; }
        public string? ENT_TRAVELCLICKID { get; set; }
        public string? ENT_JOLLYTOURID { get; set; }
        public string? ENT_SEDNAID { get; set; }
        public string? ENT_HOTELRUNNERID { get; set; }
        public string? ENT_SETURID { get; set; }

        public virtual STDHOTEL HOTEL { get; set; } = null!;
        public virtual STDMARKETS? STDMARKET { get; set; }
        public virtual ICollection<REQUEST_DETAIL> REQUEST_DETAIL { get; set; }
        public virtual ICollection<RESERVATION_SETTINGS_MARKET> RESERVATION_SETTINGS_MARKET { get; set; }
        public virtual ICollection<STDHOTEL_PRICECONDITION> STDHOTEL_PRICECONDITION { get; set; }
        public virtual ICollection<STDHOTEL_RATECODE_DISCOUNT_MARKET> STDHOTEL_RATECODE_DISCOUNT_MARKET { get; set; }
        public virtual ICollection<STDHOTEL_RATECODE_MARKUP_MARKETS> STDHOTEL_RATECODE_MARKUP_MARKETS { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
