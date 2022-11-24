using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class SurveyAnsweroptions : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid Surveysid { get; set; }
        public Guid Questionid { get; set; }
        public string? Answer { get; set; }
        public int? Point { get; set; }
        public bool? Istrueanswer { get; set; }
        public bool? Checked { get; set; }
        public string? Qanswer { get; set; }

        public virtual SurveyAnswers Question { get; set; } = null!;
        public virtual Surveys Surveys { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
