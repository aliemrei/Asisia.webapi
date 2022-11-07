using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class SURVEY : EntityBase // My Handlebars Helper
    {
        public SURVEY()
        {
            SURVEYS = new HashSet<SURVEYS>();
        }

        public Guid ID { get; set; }
        public Guid CORPID { get; set; }
        public string? NAME { get; set; }
        public string? DESCRIPTION { get; set; }
        public string? TITLE { get; set; }
        public bool? TITLEVISIBLE { get; set; }
        public bool EXITLINKVISIBLE { get; set; }
        public bool? REQUIREDMARKS { get; set; }
        public bool? QUESTIONNUMBERS { get; set; }
        public bool ISDELETED { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public string? DESIGN { get; set; }
        public bool CONFIRMBEFORE { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual CORP CORP { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual ICollection<SURVEYS> SURVEYS { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
