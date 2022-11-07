using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class VEHICLETYPES : EntityBase // My Handlebars Helper
    {
        public VEHICLETYPES()
        {
            REQUEST_DETAIL = new HashSet<REQUEST_DETAIL>();
            TRANSFER_PRICES = new HashSet<TRANSFER_PRICES>();
        }

        public Guid ID { get; set; }
        public Guid CORPID { get; set; }
        public string VEHICLETYPE { get; set; } = null!;
        public string DEFINITION { get; set; } = null!;
        public string? DESCRIPTION { get; set; }
        public int PERSON_COUNT { get; set; }
        public string? SPECIAL_CODE { get; set; }
        public bool ISDELETED { get; set; }
        public bool ISDISABLED { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public string? BAGGAGE_CAPACITY { get; set; }
        public bool? AIRCONDITION { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual CORP CORP { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual STDVEHICLETYPES VEHICLETYPENavigation { get; set; } = null!;
        public virtual ICollection<REQUEST_DETAIL> REQUEST_DETAIL { get; set; }
        public virtual ICollection<TRANSFER_PRICES> TRANSFER_PRICES { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
