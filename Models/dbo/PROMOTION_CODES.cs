using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class PROMOTION_CODES : EntityBase // My Handlebars Helper
    {
        public PROMOTION_CODES()
        {
            PROMOTION_CODES_MARKET = new HashSet<PROMOTION_CODES_MARKET>();
            REQUEST_DETAIL = new HashSet<REQUEST_DETAIL>();
        }

        public Guid ID { get; set; }
        public Guid CORPID { get; set; }
        public short KIND { get; set; }
        public short TYPE { get; set; }
        public string? EMAIL { get; set; }
        public string DEFINITION { get; set; } = null!;
        public string CODE { get; set; } = null!;
        public short USETYPE { get; set; }
        public int USECOUNT { get; set; }
        public short DISCOUNTTYPE { get; set; }
        public short DISCOUNTKIND { get; set; }
        public double DISCOUNT { get; set; }
        public string? CURCODE { get; set; }
        public DateTime? SELLFROM { get; set; }
        public DateTime? SELLTO { get; set; }
        public DateTime? STAYFROM { get; set; }
        public DateTime? STAYTO { get; set; }
        public string? DESCRIPTION { get; set; }
        public Guid? HOTELID { get; set; }
        public Guid? TOURID { get; set; }
        public Guid? TICKETID { get; set; }
        public bool ISDELETED { get; set; }
        public bool ISDISABLED { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual CORP CORP { get; set; } = null!;
        public virtual CURCODE? CURCODENavigation { get; set; }
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual STDHOTEL? HOTEL { get; set; }
        public virtual TICKET? TICKET { get; set; }
        public virtual TOUR? TOUR { get; set; }
        public virtual ICollection<PROMOTION_CODES_MARKET> PROMOTION_CODES_MARKET { get; set; }
        public virtual ICollection<REQUEST_DETAIL> REQUEST_DETAIL { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
