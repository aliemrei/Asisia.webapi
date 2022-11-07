using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class PAYMENTS : EntityBase // My Handlebars Helper
    {
        public PAYMENTS()
        {
            REQUEST_PAYMENTS = new HashSet<REQUEST_PAYMENTS>();
        }

        public Guid ID { get; set; }
        public Guid? REQUESTID { get; set; }
        public Guid? RESOURCEID { get; set; }
        public string? DESCRIPTION { get; set; }
        public bool ISCASH { get; set; }
        public bool ISCCARD { get; set; }
        public string? HARDPOSIDENTITY { get; set; }
        public double DEBT { get; set; }
        public double CREDIT { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public Guid CORPID { get; set; }
        public Guid STATUS { get; set; }
        public string CURCODE { get; set; } = null!;
        public byte PAYTYPE { get; set; }
        public bool ISBONUS { get; set; }
        public double? TL_AMOUNT { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual CORP CORP { get; set; } = null!;
        public virtual CURCODE CURCODENavigation { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual REQUEST? REQUEST { get; set; }
        public virtual RESOURCES? RESOURCE { get; set; }
        public virtual REQUEST_STATUS STATUSNavigation { get; set; } = null!;
        public virtual ICollection<REQUEST_PAYMENTS> REQUEST_PAYMENTS { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
