using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class BONUS_DEF_PRICES : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid BONUS_DEF_ITEMSID { get; set; }
        public double FIRST_AMOUNT { get; set; }
        public double LAST_AMOUNT { get; set; }
        public double RATE { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public Guid? EDITUSER { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual BONUS_DEF_ITEMS BONUS_DEF_ITEMS { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
