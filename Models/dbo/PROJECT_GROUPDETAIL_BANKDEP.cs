using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class PROJECT_GROUPDETAIL_BANKDEP : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid PROJECT_DETAILID { get; set; }
        public Guid DEPACCOUNTID { get; set; }
        public bool ISDISABLED { get; set; }
        public bool? USE_IN_PORTAL { get; set; }

        public virtual VIRTUAL_POS_DEP_ACCOUNTS DEPACCOUNT { get; set; } = null!;
        public virtual PROJECT_GROUPDETAIL PROJECT_DETAIL { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
