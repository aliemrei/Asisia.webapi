using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class CRM_CARDGROUPS : EntityBase // My Handlebars Helper
    {
        public CRM_CARDGROUPS()
        {
            CRM_CARDTYPES = new HashSet<CRM_CARDTYPES>();
        }

        public Guid ID { get; set; }
        public Guid CORPID { get; set; }
        public string DEFINITION { get; set; } = null!;
        public bool ISDELETED { get; set; }
        public bool ISDISABLED { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual CORP CORP { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual ICollection<CRM_CARDTYPES> CRM_CARDTYPES { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
