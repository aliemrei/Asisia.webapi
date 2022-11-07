using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class STDHOTEL_RATECODE_DETAIL_AGENCYGROUPS : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid GROUPID { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public Guid? DETAILID { get; set; }
        public bool ISDELETED { get; set; }
        public bool ISDISABLED { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual STDHOTEL_RATECODE_DETAIL? DETAIL { get; set; }
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual AGENCY_GROUP GROUP { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
