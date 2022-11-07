using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class VIRTUAL_POS_DEFAULTS : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid CORPID { get; set; }
        public Guid PORTALUID { get; set; }
        public Guid? VISA_POSID { get; set; }
        public Guid? MASTER_POSID { get; set; }
        public Guid? AMEX_POSID { get; set; }
        public Guid? JCB_POSID { get; set; }
        public Guid? UNIONPAY_POSID { get; set; }
        public Guid? MAESTRO_POSID { get; set; }
        public Guid? VISA_EX_POSID { get; set; }
        public Guid? MASTER_EX_POSID { get; set; }
        public Guid? AMEX_EX_POSID { get; set; }
        public Guid? JCB_EX_POSID { get; set; }
        public Guid? UNIONPAY_EX_POSID { get; set; }
        public Guid? MAESTRO_EX_POSID { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual VIRTUAL_POS? AMEX_EX_POS { get; set; }
        public virtual VIRTUAL_POS? AMEX_POS { get; set; }
        public virtual CORP CORP { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual VIRTUAL_POS? JCB_EX_POS { get; set; }
        public virtual VIRTUAL_POS? JCB_POS { get; set; }
        public virtual VIRTUAL_POS? MAESTRO_EX_POS { get; set; }
        public virtual VIRTUAL_POS? MAESTRO_POS { get; set; }
        public virtual VIRTUAL_POS? MASTER_EX_POS { get; set; }
        public virtual VIRTUAL_POS? MASTER_POS { get; set; }
        public virtual PORTAL PORTALU { get; set; } = null!;
        public virtual VIRTUAL_POS? UNIONPAY_EX_POS { get; set; }
        public virtual VIRTUAL_POS? UNIONPAY_POS { get; set; }
        public virtual VIRTUAL_POS? VISA_EX_POS { get; set; }
        public virtual VIRTUAL_POS? VISA_POS { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
