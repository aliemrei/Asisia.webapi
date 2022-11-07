using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class CURCODE : EntityBase // My Handlebars Helper
    {
        public CURCODE()
        {
            AGENCY = new HashSet<AGENCY>();
            BONUS_DEF = new HashSet<BONUS_DEF>();
            CASHIER_HANDOVER_ENTITY = new HashSet<CASHIER_HANDOVER_ENTITY>();
            PAYMENTS = new HashSet<PAYMENTS>();
            PORTAL = new HashSet<PORTAL>();
            PORTAL_CURRENCIES = new HashSet<PORTAL_CURRENCIES>();
            PROMOTION_CODES = new HashSet<PROMOTION_CODES>();
            STDHOTEL_RATECODE_MARKUP = new HashSet<STDHOTEL_RATECODE_MARKUP>();
            STDSTORE_ITEM_PRICES = new HashSet<STDSTORE_ITEM_PRICES>();
            TICKET_GIFTS = new HashSet<TICKET_GIFTS>();
            TICKET_PRICES = new HashSet<TICKET_PRICES>();
            TOUR_PRICES = new HashSet<TOUR_PRICES>();
            TRANSFER_PRICES = new HashSet<TRANSFER_PRICES>();
            VIRTUAL_POS_ACCOUNTS_CURCODES = new HashSet<VIRTUAL_POS_ACCOUNTS_CURCODES>();
            VIRTUAL_POS_PAYMENTS = new HashSet<VIRTUAL_POS_PAYMENTS>();
        }

        public string CODE { get; set; } = null!;
        public int? LOGO_ENTID { get; set; }

        public virtual ICollection<AGENCY> AGENCY { get; set; }
        public virtual ICollection<BONUS_DEF> BONUS_DEF { get; set; }
        public virtual ICollection<CASHIER_HANDOVER_ENTITY> CASHIER_HANDOVER_ENTITY { get; set; }
        public virtual ICollection<PAYMENTS> PAYMENTS { get; set; }
        public virtual ICollection<PORTAL> PORTAL { get; set; }
        public virtual ICollection<PORTAL_CURRENCIES> PORTAL_CURRENCIES { get; set; }
        public virtual ICollection<PROMOTION_CODES> PROMOTION_CODES { get; set; }
        public virtual ICollection<STDHOTEL_RATECODE_MARKUP> STDHOTEL_RATECODE_MARKUP { get; set; }
        public virtual ICollection<STDSTORE_ITEM_PRICES> STDSTORE_ITEM_PRICES { get; set; }
        public virtual ICollection<TICKET_GIFTS> TICKET_GIFTS { get; set; }
        public virtual ICollection<TICKET_PRICES> TICKET_PRICES { get; set; }
        public virtual ICollection<TOUR_PRICES> TOUR_PRICES { get; set; }
        public virtual ICollection<TRANSFER_PRICES> TRANSFER_PRICES { get; set; }
        public virtual ICollection<VIRTUAL_POS_ACCOUNTS_CURCODES> VIRTUAL_POS_ACCOUNTS_CURCODES { get; set; }
        public virtual ICollection<VIRTUAL_POS_PAYMENTS> VIRTUAL_POS_PAYMENTS { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
