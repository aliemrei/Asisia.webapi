using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class VIRTUAL_POS_DEP_ACCOUNTS : EntityBase // My Handlebars Helper
    {
        public VIRTUAL_POS_DEP_ACCOUNTS()
        {
            PROJECT_GROUPDETAIL_BANKDEP = new HashSet<PROJECT_GROUPDETAIL_BANKDEP>();
            VIRTUAL_POS_DEP_PAYMENTS = new HashSet<VIRTUAL_POS_DEP_PAYMENTS>();
        }

        public Guid ID { get; set; }
        public Guid POSID { get; set; }
        public string? DEFINITION { get; set; }
        public string? BRAND_CODE { get; set; }
        public string? ACCOUNT_NO { get; set; }
        public string? IBAN { get; set; }
        public string CURCODE { get; set; } = null!;
        public string? FIRMNAME { get; set; }
        public string? SWIFTCODE { get; set; }
        public string? ENTID { get; set; }

        public virtual ICollection<PROJECT_GROUPDETAIL_BANKDEP> PROJECT_GROUPDETAIL_BANKDEP { get; set; }
        public virtual ICollection<VIRTUAL_POS_DEP_PAYMENTS> VIRTUAL_POS_DEP_PAYMENTS { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
