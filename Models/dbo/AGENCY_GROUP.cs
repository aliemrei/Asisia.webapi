using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class AGENCY_GROUP : EntityBase // My Handlebars Helper
    {
        public AGENCY_GROUP()
        {
            AGENCY = new HashSet<AGENCY>();
            STDHOTEL_RATECODE_DETAIL_AGENCYGROUPS = new HashSet<STDHOTEL_RATECODE_DETAIL_AGENCYGROUPS>();
        }

        public Guid ID { get; set; }
        public Guid CORPID { get; set; }
        public string GROUPNAME { get; set; } = null!;
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public bool ISDELETED { get; set; }
        public bool ISDISABLED { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual CORP CORP { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual ICollection<AGENCY> AGENCY { get; set; }
        public virtual ICollection<STDHOTEL_RATECODE_DETAIL_AGENCYGROUPS> STDHOTEL_RATECODE_DETAIL_AGENCYGROUPS { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
