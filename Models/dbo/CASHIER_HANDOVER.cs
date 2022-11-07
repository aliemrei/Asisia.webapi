using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class CASHIER_HANDOVER : EntityBase // My Handlebars Helper
    {
        public CASHIER_HANDOVER()
        {
            CASHIER_HANDOVER_ENTITY = new HashSet<CASHIER_HANDOVER_ENTITY>();
        }

        public Guid ID { get; set; }
        public Guid USERID { get; set; }
        public Guid RESOURCEID { get; set; }
        public Guid CORPID { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public bool ISENDDATE { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual CORP CORP { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual RESOURCES RESOURCE { get; set; } = null!;
        public virtual USERS USER { get; set; } = null!;
        public virtual ICollection<CASHIER_HANDOVER_ENTITY> CASHIER_HANDOVER_ENTITY { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
