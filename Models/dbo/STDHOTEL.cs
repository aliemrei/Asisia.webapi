using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class STDHOTEL : EntityBase // My Handlebars Helper
    {
        public STDHOTEL()
        {
            PORTAL_CATEGORY_ITEMS = new HashSet<PORTAL_CATEGORY_ITEMS>();
            PROJECT_GROUPDETAIL = new HashSet<PROJECT_GROUPDETAIL>();
            PROMOTION_CODES = new HashSet<PROMOTION_CODES>();
            PROPERTY_MAPPING = new HashSet<PROPERTY_MAPPING>();
            REQUEST_DETAIL = new HashSet<REQUEST_DETAIL>();
            RESERVATION_SETTINGS = new HashSet<RESERVATION_SETTINGS>();
            STDHOTEL_ANNOUNCEMENT = new HashSet<STDHOTEL_ANNOUNCEMENT>();
            STDHOTEL_BOARDTYPES = new HashSet<STDHOTEL_BOARDTYPES>();
            STDHOTEL_DESCRIPTIONS = new HashSet<STDHOTEL_DESCRIPTIONS>();
            STDHOTEL_EXTRAS = new HashSet<STDHOTEL_EXTRAS>();
            STDHOTEL_MARKET = new HashSet<STDHOTEL_MARKET>();
            STDHOTEL_PRICECONDITION = new HashSet<STDHOTEL_PRICECONDITION>();
            STDHOTEL_RATECODE = new HashSet<STDHOTEL_RATECODE>();
            STDHOTEL_RATECODE_DISCOUNT = new HashSet<STDHOTEL_RATECODE_DISCOUNT>();
            STDHOTEL_RATETYPE = new HashSet<STDHOTEL_RATETYPE>();
            STDHOTEL_ROOMTYPES = new HashSet<STDHOTEL_ROOMTYPES>();
            TOUR_PROGRAM = new HashSet<TOUR_PROGRAM>();
        }

        public Guid ID { get; set; }
        public Guid CORPID { get; set; }
        public string NAME { get; set; } = null!;
        public Guid? ADDRESSID { get; set; }
        public long? TEL1 { get; set; }
        public long? TEL2 { get; set; }
        public string? EMAIL { get; set; }
        public long? FAX { get; set; }
        public bool ISDELETED { get; set; }
        public bool ISDISABLED { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public string? CONTACT { get; set; }
        public string? WEBADDRESS { get; set; }
        public string? HOMEPAGEURL { get; set; }
        public string? TEMPLATENAME { get; set; }
        public string? THUMBNAILURL { get; set; }
        public string? HOTEL_DESCRIPTION { get; set; }
        public string? RAKAM_ID { get; set; }
        public DateTime? CHECKINTIME { get; set; }
        public DateTime? CHECKOUTTIME { get; set; }
        public string? TRIPADVISORID { get; set; }
        public string? URL_BLOGGER { get; set; }
        public string? URL_FLICKER { get; set; }
        public string? URL_FOURSQUARE { get; set; }
        public string? URL_GOOGLEPLUS { get; set; }
        public string? URL_INSTAGRAM { get; set; }
        public string? URL_VINE { get; set; }
        public string? URL_FACEBOOK { get; set; }
        public string? FACTSHEETURL { get; set; }
        public double? STARS { get; set; }
        public string? FACTSHEETURL2 { get; set; }
        public int THUMBNAILMAXWIDTH { get; set; }
        public int? SETURID { get; set; }

        public virtual LOCATION_ADDRESS? ADDRESS { get; set; }
        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual CORP CORP { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual ICollection<PORTAL_CATEGORY_ITEMS> PORTAL_CATEGORY_ITEMS { get; set; }
        public virtual ICollection<PROJECT_GROUPDETAIL> PROJECT_GROUPDETAIL { get; set; }
        public virtual ICollection<PROMOTION_CODES> PROMOTION_CODES { get; set; }
        public virtual ICollection<PROPERTY_MAPPING> PROPERTY_MAPPING { get; set; }
        public virtual ICollection<REQUEST_DETAIL> REQUEST_DETAIL { get; set; }
        public virtual ICollection<RESERVATION_SETTINGS> RESERVATION_SETTINGS { get; set; }
        public virtual ICollection<STDHOTEL_ANNOUNCEMENT> STDHOTEL_ANNOUNCEMENT { get; set; }
        public virtual ICollection<STDHOTEL_BOARDTYPES> STDHOTEL_BOARDTYPES { get; set; }
        public virtual ICollection<STDHOTEL_DESCRIPTIONS> STDHOTEL_DESCRIPTIONS { get; set; }
        public virtual ICollection<STDHOTEL_EXTRAS> STDHOTEL_EXTRAS { get; set; }
        public virtual ICollection<STDHOTEL_MARKET> STDHOTEL_MARKET { get; set; }
        public virtual ICollection<STDHOTEL_PRICECONDITION> STDHOTEL_PRICECONDITION { get; set; }
        public virtual ICollection<STDHOTEL_RATECODE> STDHOTEL_RATECODE { get; set; }
        public virtual ICollection<STDHOTEL_RATECODE_DISCOUNT> STDHOTEL_RATECODE_DISCOUNT { get; set; }
        public virtual ICollection<STDHOTEL_RATETYPE> STDHOTEL_RATETYPE { get; set; }
        public virtual ICollection<STDHOTEL_ROOMTYPES> STDHOTEL_ROOMTYPES { get; set; }
        public virtual ICollection<TOUR_PROGRAM> TOUR_PROGRAM { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
