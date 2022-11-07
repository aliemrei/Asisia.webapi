using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class VIRTUAL_POS_ACCOUNT_INSTALMENTS : EntityBase // My Handlebars Helper
    {
        public VIRTUAL_POS_ACCOUNT_INSTALMENTS()
        {
            VIRTUAL_POS_PAYMENTS = new HashSet<VIRTUAL_POS_PAYMENTS>();
            VIRTUAL_POS_PAYMENT_VPOSES = new HashSet<VIRTUAL_POS_PAYMENT_VPOSES>();
        }

        public Guid ID { get; set; }
        public Guid ACCOUNTID { get; set; }
        public int OFFSET { get; set; }
        public double COMMISSION { get; set; }
        public double BANK_COMMISSION { get; set; }
        public bool ISDISABLED { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public int PLUS { get; set; }
        public int EXPIRYDAY { get; set; }

        public virtual VIRTUAL_POS_ACCOUNTS ACCOUNT { get; set; } = null!;
        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual ICollection<VIRTUAL_POS_PAYMENTS> VIRTUAL_POS_PAYMENTS { get; set; }
        public virtual ICollection<VIRTUAL_POS_PAYMENT_VPOSES> VIRTUAL_POS_PAYMENT_VPOSES { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
