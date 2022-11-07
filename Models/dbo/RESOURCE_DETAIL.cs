using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class RESOURCE_DETAIL : EntityBase // My Handlebars Helper
    {
        public RESOURCE_DETAIL()
        {
            SALES_REQ = new HashSet<SALES_REQ>();
        }

        public Guid ID { get; set; }
        public string DESCRIPTION { get; set; } = null!;
        public string DETAIL { get; set; } = null!;
        public Guid RESOURCEID { get; set; }
        public Guid CORPID { get; set; }
        public Guid PROJECT_GROUPDETAILID { get; set; }
        public bool ISDELETED { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual CORP CORP { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual PROJECT_GROUPDETAIL PROJECT_GROUPDETAIL { get; set; } = null!;
        public virtual ICollection<SALES_REQ> SALES_REQ { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
