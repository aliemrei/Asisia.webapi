using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class AGENCY : EntityBase // My Handlebars Helper
    {
        public AGENCY()
        {
            REQUEST = new HashSet<REQUEST>();
            STDHOTEL_RATECODE_DISCOUNT = new HashSet<STDHOTEL_RATECODE_DISCOUNT>();
            TICKET_PRICES = new HashSet<TICKET_PRICES>();
            TRANSFER_PRICES = new HashSet<TRANSFER_PRICES>();
        }

        public Guid ID { get; set; }
        public Guid CORPID { get; set; }
        public string FULLNAME { get; set; } = null!;
        public long? TEL1 { get; set; }
        public long? TEL2 { get; set; }
        public string? EMAIL { get; set; }
        public bool ISDISABLED { get; set; }
        public bool ISDELETED { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public Guid? AUTHORIZEDID { get; set; }
        public int INTID { get; set; }
        public Guid? GROUPID { get; set; }
        public string? DEFAULT_CURCODE { get; set; }
        public double QUOTA { get; set; }
        public double PAYMENT_RATE { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual PERSON? AUTHORIZED { get; set; }
        public virtual CORP CORP { get; set; } = null!;
        public virtual CURCODE? DEFAULT_CURCODENavigation { get; set; }
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual AGENCY_GROUP? GROUP { get; set; }
        public virtual ICollection<REQUEST> REQUEST { get; set; }
        public virtual ICollection<STDHOTEL_RATECODE_DISCOUNT> STDHOTEL_RATECODE_DISCOUNT { get; set; }
        public virtual ICollection<TICKET_PRICES> TICKET_PRICES { get; set; }
        public virtual ICollection<TRANSFER_PRICES> TRANSFER_PRICES { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
