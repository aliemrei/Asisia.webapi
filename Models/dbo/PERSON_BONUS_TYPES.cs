using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class PERSON_BONUS_TYPES : EntityBase // My Handlebars Helper
    {
        public PERSON_BONUS_TYPES()
        {
            PERSON_BONUS = new HashSet<PERSON_BONUS>();
        }

        public Guid ID { get; set; }
        public string NAME { get; set; } = null!;
        public bool ISNEGATIVE { get; set; }
        public bool ISDELETED { get; set; }
        public Guid CORPID { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual CORP CORP { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual ICollection<PERSON_BONUS> PERSON_BONUS { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
