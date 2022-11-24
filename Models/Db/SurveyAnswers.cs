using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class SurveyAnswers : EntityBase // My Handlebars Helper
    {
        public SurveyAnswers()
        {
            SurveyAnsweroptions = new HashSet<SurveyAnsweroptions>();
        }

        public Guid Id { get; set; }
        public Guid Surveysid { get; set; }
        public Guid Questionid { get; set; }
        public string? Question { get; set; }
        public int? Type { get; set; }
        public bool Required { get; set; }
        public bool Useother { get; set; }
        public bool Otherisanswer { get; set; }
        public string? Otheranswer { get; set; }
        public string? Answer { get; set; }

        public virtual Surveys Surveys { get; set; } = null!;
        public virtual ICollection<SurveyAnsweroptions> SurveyAnsweroptions { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
