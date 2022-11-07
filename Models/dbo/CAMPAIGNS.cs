using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class CAMPAIGNS : EntityBase // My Handlebars Helper
    {
        public CAMPAIGNS()
        {
            REQUEST = new HashSet<REQUEST>();
            REQUEST_DETAIL = new HashSet<REQUEST_DETAIL>();
        }

        public Guid ID { get; set; }
        public string CODE { get; set; } = null!;
        public string DESCRIPTION { get; set; } = null!;
        public Guid CORPID { get; set; }
        public Guid? RESOURCEID { get; set; }
        public Guid PROJECTID { get; set; }
        public Guid? PROJECT_DETAILID { get; set; }
        public int FORALLPROJECTS { get; set; }
        public DateTime STARTDATE { get; set; }
        public DateTime ENDDATE { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public bool ISDELETED { get; set; }
        public string? RAKAM_ID { get; set; }
        public string? CALLBACK_TRUNK { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual CORP CORP { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual PROJECT_GROUP PROJECT { get; set; } = null!;
        public virtual RESOURCES? RESOURCE { get; set; }
        public virtual ICollection<REQUEST> REQUEST { get; set; }
        public virtual ICollection<REQUEST_DETAIL> REQUEST_DETAIL { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
