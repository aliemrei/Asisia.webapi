using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class TICKET : EntityBase // My Handlebars Helper
    {
        public TICKET()
        {
            PORTAL_CATEGORY_ITEMS = new HashSet<PORTAL_CATEGORY_ITEMS>();
            PROJECT_GROUPDETAIL = new HashSet<PROJECT_GROUPDETAIL>();
            PROMOTION_CODES = new HashSet<PROMOTION_CODES>();
            REQUEST_DETAIL = new HashSet<REQUEST_DETAIL>();
            RESERVATION_SETTINGS = new HashSet<RESERVATION_SETTINGS>();
            TICKET_HOURS = new HashSet<TICKET_HOURS>();
            TICKET_PRICES = new HashSet<TICKET_PRICES>();
            TILE_ITEMOPTION = new HashSet<TILE_ITEMOPTION>();
        }

        public Guid ID { get; set; }
        public Guid CORPID { get; set; }
        public string? DEFINITION { get; set; }
        public byte TICKETTYPE { get; set; }
        public byte? ENDOFMINUTE { get; set; }
        public int MAXSELLDATE { get; set; }
        public int ADULTMANDATORY { get; set; }
        public int CHILDMANDATORY { get; set; }
        public bool ISDISABLED { get; set; }
        public bool ISDELETED { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public string? PLU { get; set; }
        public string? DESCRIPTION { get; set; }
        public int SORTORDER { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual CORP CORP { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual ICollection<PORTAL_CATEGORY_ITEMS> PORTAL_CATEGORY_ITEMS { get; set; }
        public virtual ICollection<PROJECT_GROUPDETAIL> PROJECT_GROUPDETAIL { get; set; }
        public virtual ICollection<PROMOTION_CODES> PROMOTION_CODES { get; set; }
        public virtual ICollection<REQUEST_DETAIL> REQUEST_DETAIL { get; set; }
        public virtual ICollection<RESERVATION_SETTINGS> RESERVATION_SETTINGS { get; set; }
        public virtual ICollection<TICKET_HOURS> TICKET_HOURS { get; set; }
        public virtual ICollection<TICKET_PRICES> TICKET_PRICES { get; set; }
        public virtual ICollection<TILE_ITEMOPTION> TILE_ITEMOPTION { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
