using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class SURVEY_ANSWERS : EntityBase // My Handlebars Helper
    {
        public SURVEY_ANSWERS()
        {
            SURVEY_ANSWEROPTIONS = new HashSet<SURVEY_ANSWEROPTIONS>();
        }

        public Guid ID { get; set; }
        public Guid SURVEYSID { get; set; }
        public Guid QUESTIONID { get; set; }
        public string? QUESTION { get; set; }
        public int? TYPE { get; set; }
        public bool REQUIRED { get; set; }
        public bool USEOTHER { get; set; }
        public bool OTHERISANSWER { get; set; }
        public string? OTHERANSWER { get; set; }
        public string? ANSWER { get; set; }

        public virtual SURVEYS SURVEYS { get; set; } = null!;
        public virtual ICollection<SURVEY_ANSWEROPTIONS> SURVEY_ANSWEROPTIONS { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
