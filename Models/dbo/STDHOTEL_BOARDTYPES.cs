using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class STDHOTEL_BOARDTYPES : EntityBase // My Handlebars Helper
    {
        public STDHOTEL_BOARDTYPES()
        {
            PROPERTY_MAPPING = new HashSet<PROPERTY_MAPPING>();
            REQUEST_DETAIL = new HashSet<REQUEST_DETAIL>();
            STDHOTEL_PRICECONDITION = new HashSet<STDHOTEL_PRICECONDITION>();
        }

        public Guid ID { get; set; }
        public string BOARDTYPE { get; set; } = null!;
        public Guid HOTELID { get; set; }
        public string? DEFINITION { get; set; }
        public string? ENT_ID { get; set; }
        public string? ENT_ETSID { get; set; }
        public string? ENT_TOURISTICAID { get; set; }
        public string? ENT_TATILBUDURID { get; set; }
        public string? ENT_IATIID { get; set; }
        public string? ENT_TRAVELCLICKID { get; set; }
        public string? ENT_JOLLYTOURID { get; set; }
        public string? ENT_SEDNAID { get; set; }
        public string? ENT_HOTELRUNNERID { get; set; }
        public string? ENT_SETURID { get; set; }

        public virtual STDBOARDTYPES BOARDTYPENavigation { get; set; } = null!;
        public virtual STDHOTEL HOTEL { get; set; } = null!;
        public virtual ICollection<PROPERTY_MAPPING> PROPERTY_MAPPING { get; set; }
        public virtual ICollection<REQUEST_DETAIL> REQUEST_DETAIL { get; set; }
        public virtual ICollection<STDHOTEL_PRICECONDITION> STDHOTEL_PRICECONDITION { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
