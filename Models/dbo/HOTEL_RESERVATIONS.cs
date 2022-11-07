using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class HOTEL_RESERVATIONS : EntityBase // My Handlebars Helper
    {
        public HOTEL_RESERVATIONS()
        {
            HOTEL_RESERVATION_DETAILS = new HashSet<HOTEL_RESERVATION_DETAILS>();
        }

        public Guid ID { get; set; }
        public int RESID { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public Guid? REQUEST_DETAILID { get; set; }
        public DateTime? CONTRACT_DATE { get; set; }
        public DateTime? LASTUPDATE_RESDETAIL { get; set; }
        public bool ISCONFIRMED_HOTEL { get; set; }
        public bool ISCONFIRMED_GUEST { get; set; }
        public bool ISCONFIRMED_OWNER { get; set; }
        public string? ENTID { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual REQUEST_DETAIL? REQUEST_DETAIL { get; set; }
        public virtual ICollection<HOTEL_RESERVATION_DETAILS> HOTEL_RESERVATION_DETAILS { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
