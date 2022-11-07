using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class BONUS_DEF_ITEMS : EntityBase // My Handlebars Helper
    {
        public BONUS_DEF_ITEMS()
        {
            BONUS_DEF_PRICES = new HashSet<BONUS_DEF_PRICES>();
        }

        public Guid ID { get; set; }
        public Guid BONUS_DEFID { get; set; }
        public Guid PRODUCTID { get; set; }
        public Guid? PROPERTYID { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? ADDUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public Guid? EDITUSER { get; set; }

        public virtual USERS? ADDUSERNavigation { get; set; }
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual ICollection<BONUS_DEF_PRICES> BONUS_DEF_PRICES { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
