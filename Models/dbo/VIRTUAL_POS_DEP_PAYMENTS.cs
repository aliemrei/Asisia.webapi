using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class VIRTUAL_POS_DEP_PAYMENTS : EntityBase // My Handlebars Helper
    {
        public VIRTUAL_POS_DEP_PAYMENTS()
        {
            REQUEST_PAYMENTS = new HashSet<REQUEST_PAYMENTS>();
            VIRTUAL_POS_DEP_PAYMENTS_CANCEL = new HashSet<VIRTUAL_POS_DEP_PAYMENTS_CANCEL>();
        }

        public Guid ID { get; set; }
        public Guid POSACCOUNTID { get; set; }
        public double AMOUNT { get; set; }
        public Guid STATUS { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public string? TRANSFERCODE { get; set; }
        public Guid? REQUESTID { get; set; }
        public bool ISDELETED { get; set; }
        public int INTID { get; set; }
        public DateTime? ENDTIME { get; set; }
        public string? BANKTRANSACTIONID { get; set; }
        public string? ENTID { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual VIRTUAL_POS_DEP_ACCOUNTS POSACCOUNT { get; set; } = null!;
        public virtual REQUEST? REQUEST { get; set; }
        public virtual REQUEST_STATUS STATUSNavigation { get; set; } = null!;
        public virtual ICollection<REQUEST_PAYMENTS> REQUEST_PAYMENTS { get; set; }
        public virtual ICollection<VIRTUAL_POS_DEP_PAYMENTS_CANCEL> VIRTUAL_POS_DEP_PAYMENTS_CANCEL { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
