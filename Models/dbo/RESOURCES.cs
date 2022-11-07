using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class RESOURCES : EntityBase // My Handlebars Helper
    {
        public RESOURCES()
        {
            CAMPAIGNS = new HashSet<CAMPAIGNS>();
            CASHIER_HANDOVER = new HashSet<CASHIER_HANDOVER>();
            PAYMENTS = new HashSet<PAYMENTS>();
            REQUEST_DETAIL = new HashSet<REQUEST_DETAIL>();
        }

        public Guid ID { get; set; }
        public string CODE { get; set; } = null!;
        public string DESCRIPTION { get; set; } = null!;
        public Guid CORPID { get; set; }
        public Guid? MASTERID { get; set; }
        public bool ISDELETED { get; set; }
        public bool COST_BUDGET { get; set; }
        public string? DEFAULT_DIRECT_BRANDING { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public string? RAKAM_DESC { get; set; }
        public string? ICON { get; set; }
        public string? RESOURCESPATH { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual CORP CORP { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual ICollection<CAMPAIGNS> CAMPAIGNS { get; set; }
        public virtual ICollection<CASHIER_HANDOVER> CASHIER_HANDOVER { get; set; }
        public virtual ICollection<PAYMENTS> PAYMENTS { get; set; }
        public virtual ICollection<REQUEST_DETAIL> REQUEST_DETAIL { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
