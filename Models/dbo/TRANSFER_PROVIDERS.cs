using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class TRANSFER_PROVIDERS : EntityBase // My Handlebars Helper
    {
        public TRANSFER_PROVIDERS()
        {
            TRANSFER_PRICES = new HashSet<TRANSFER_PRICES>();
        }

        public Guid ID { get; set; }
        public Guid CORPID { get; set; }
        public string DESCRIPTION { get; set; } = null!;
        public long? TEL1 { get; set; }
        public long? TEL2 { get; set; }
        public bool ISDELETED { get; set; }
        public bool ISDISABLED { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual CORP CORP { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual ICollection<TRANSFER_PRICES> TRANSFER_PRICES { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
