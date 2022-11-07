using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class SURVEYS : EntityBase // My Handlebars Helper
    {
        public SURVEYS()
        {
            SURVEY_ANSWEROPTIONS = new HashSet<SURVEY_ANSWEROPTIONS>();
            SURVEY_ANSWERS = new HashSet<SURVEY_ANSWERS>();
        }

        public Guid ID { get; set; }
        public Guid? PERSONID { get; set; }
        public Guid SURVEYID { get; set; }
        public DateTime? STARTTIME { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public Guid? EDITUSER { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual PERSON? PERSON { get; set; }
        public virtual SURVEY SURVEY { get; set; } = null!;
        public virtual ICollection<SURVEY_ANSWEROPTIONS> SURVEY_ANSWEROPTIONS { get; set; }
        public virtual ICollection<SURVEY_ANSWERS> SURVEY_ANSWERS { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
