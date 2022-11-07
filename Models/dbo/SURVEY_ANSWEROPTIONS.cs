using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class SURVEY_ANSWEROPTIONS : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid SURVEYSID { get; set; }
        public Guid QUESTIONID { get; set; }
        public string? ANSWER { get; set; }
        public int? POINT { get; set; }
        public bool? ISTRUEANSWER { get; set; }
        public bool? CHECKED { get; set; }
        public string? QANSWER { get; set; }

        public virtual SURVEY_ANSWERS QUESTION { get; set; } = null!;
        public virtual SURVEYS SURVEYS { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
