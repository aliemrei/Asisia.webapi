using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class TOUR : EntityBase // My Handlebars Helper
    {
        public TOUR()
        {
            PORTAL_CATEGORY_ITEMS = new HashSet<PORTAL_CATEGORY_ITEMS>();
            PROJECT_GROUPDETAIL = new HashSet<PROJECT_GROUPDETAIL>();
            PROMOTION_CODES = new HashSet<PROMOTION_CODES>();
            REQUEST_DETAIL = new HashSet<REQUEST_DETAIL>();
            RESERVATION_SETTINGS = new HashSet<RESERVATION_SETTINGS>();
            TOUR_DISCOUNTS = new HashSet<TOUR_DISCOUNTS>();
            TOUR_PRICES = new HashSet<TOUR_PRICES>();
            TOUR_PROGRAM = new HashSet<TOUR_PROGRAM>();
        }

        public Guid ID { get; set; }
        public int INTID { get; set; }
        public Guid CORPID { get; set; }
        public string DESCRIPTION { get; set; } = null!;
        public bool ISDELETED { get; set; }
        public bool ISDISABLED { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public int ADULTCAPACITY { get; set; }
        public int CHILDCAPACITY { get; set; }
        public int BABYCAPACITY { get; set; }
        public int TOTAL_DAYS { get; set; }
        public string? BOARDTYPE { get; set; }
        public string? TRIP_LOCATIONS { get; set; }
        public short? BABY_MAXAGE { get; set; }
        public short? CHDY_MAXAGE { get; set; }
        public short? CHDE_MAXAGE { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual CORP CORP { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual ICollection<PORTAL_CATEGORY_ITEMS> PORTAL_CATEGORY_ITEMS { get; set; }
        public virtual ICollection<PROJECT_GROUPDETAIL> PROJECT_GROUPDETAIL { get; set; }
        public virtual ICollection<PROMOTION_CODES> PROMOTION_CODES { get; set; }
        public virtual ICollection<REQUEST_DETAIL> REQUEST_DETAIL { get; set; }
        public virtual ICollection<RESERVATION_SETTINGS> RESERVATION_SETTINGS { get; set; }
        public virtual ICollection<TOUR_DISCOUNTS> TOUR_DISCOUNTS { get; set; }
        public virtual ICollection<TOUR_PRICES> TOUR_PRICES { get; set; }
        public virtual ICollection<TOUR_PROGRAM> TOUR_PROGRAM { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
