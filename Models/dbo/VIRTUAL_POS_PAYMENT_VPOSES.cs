using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class VIRTUAL_POS_PAYMENT_VPOSES : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid? TEMPID { get; set; }
        public Guid? PAYMENTID { get; set; }
        public Guid? INSTALLMENTID { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual VIRTUAL_POS_ACCOUNT_INSTALMENTS? INSTALLMENT { get; set; }
        public virtual VIRTUAL_POS_PAYMENT_REQUESTS? PAYMENT { get; set; }
        public virtual VIRTUAL_POS_PAYMENT_TEMPS? TEMP { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
