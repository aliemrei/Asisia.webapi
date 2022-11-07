using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class STDHOTEL_RATETYPE : EntityBase // My Handlebars Helper
    {
        public STDHOTEL_RATETYPE()
        {
            PROPERTY_MAPPING = new HashSet<PROPERTY_MAPPING>();
            REQUEST_DETAIL = new HashSet<REQUEST_DETAIL>();
            STDHOTEL_PRICECONDITION = new HashSet<STDHOTEL_PRICECONDITION>();
            STDHOTEL_RATECODE_DISCOUNT_RATETYPE = new HashSet<STDHOTEL_RATECODE_DISCOUNT_RATETYPE>();
        }

        public Guid ID { get; set; }
        public Guid HOTELID { get; set; }
        public string DEFINITION { get; set; } = null!;
        public bool ISREFUNDABLE { get; set; }
        public int? ENT_ID { get; set; }
        public byte USEONLINE { get; set; }
        public string? ENT_ETSID { get; set; }
        public string? ENT_TOURISTICAID { get; set; }
        public string? ENT_TATILBUDURID { get; set; }
        public string? ENT_IATIID { get; set; }
        public string? ENT_TRAVELCLICKID { get; set; }
        public string? ENT_JOLLYTOURID { get; set; }
        public string? ENT_SEDNAID { get; set; }
        public string? ENT_HOTELRUNNERID { get; set; }
        public string? ENT_SETURID { get; set; }
        public int? REFUND_DAY { get; set; }
        public TimeSpan? REFUND_LASTTIME { get; set; }

        public virtual STDHOTEL HOTEL { get; set; } = null!;
        public virtual ICollection<PROPERTY_MAPPING> PROPERTY_MAPPING { get; set; }
        public virtual ICollection<REQUEST_DETAIL> REQUEST_DETAIL { get; set; }
        public virtual ICollection<STDHOTEL_PRICECONDITION> STDHOTEL_PRICECONDITION { get; set; }
        public virtual ICollection<STDHOTEL_RATECODE_DISCOUNT_RATETYPE> STDHOTEL_RATECODE_DISCOUNT_RATETYPE { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
