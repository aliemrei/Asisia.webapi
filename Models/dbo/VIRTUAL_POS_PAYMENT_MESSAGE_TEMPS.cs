using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class VIRTUAL_POS_PAYMENT_MESSAGE_TEMPS : EntityBase // My Handlebars Helper
    {
        public VIRTUAL_POS_PAYMENT_MESSAGE_TEMPS()
        {
            VIRTUAL_POS_PAYMENT_REQUESTSEMAILTEMP = new HashSet<VIRTUAL_POS_PAYMENT_REQUESTS>();
            VIRTUAL_POS_PAYMENT_REQUESTSSMSTEMP = new HashSet<VIRTUAL_POS_PAYMENT_REQUESTS>();
            VIRTUAL_POS_PAYMENT_TEMPSEMAILTEMP = new HashSet<VIRTUAL_POS_PAYMENT_TEMPS>();
            VIRTUAL_POS_PAYMENT_TEMPSSMSTEMP = new HashSet<VIRTUAL_POS_PAYMENT_TEMPS>();
        }

        public Guid ID { get; set; }
        public Guid CORPID { get; set; }
        public short KIND { get; set; }
        public string DESCRIPTION { get; set; } = null!;
        public string? MESSAGETEXT { get; set; }
        public bool ISDISABLED { get; set; }
        public bool ISDELETED { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public string? SUCCESSTEXT { get; set; }
        public string? ERRORTEXT { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual CORP CORP { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual ICollection<VIRTUAL_POS_PAYMENT_REQUESTS> VIRTUAL_POS_PAYMENT_REQUESTSEMAILTEMP { get; set; }
        public virtual ICollection<VIRTUAL_POS_PAYMENT_REQUESTS> VIRTUAL_POS_PAYMENT_REQUESTSSMSTEMP { get; set; }
        public virtual ICollection<VIRTUAL_POS_PAYMENT_TEMPS> VIRTUAL_POS_PAYMENT_TEMPSEMAILTEMP { get; set; }
        public virtual ICollection<VIRTUAL_POS_PAYMENT_TEMPS> VIRTUAL_POS_PAYMENT_TEMPSSMSTEMP { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
