using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class PERSON_GROUP : EntityBase // My Handlebars Helper
    {
        public PERSON_GROUP()
        {
            PERSON = new HashSet<PERSON>();
        }

        public Guid ID { get; set; }
        public string NAME { get; set; } = null!;
        public bool ISDELETED { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public Guid CORPID { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual CORP CORP { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual ICollection<PERSON> PERSON { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
