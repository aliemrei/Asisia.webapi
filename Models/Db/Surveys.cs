using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class Surveys : EntityBase // My Handlebars Helper
    {
        public Surveys()
        {
            SurveyAnsweroptions = new HashSet<SurveyAnsweroptions>();
            SurveyAnswers = new HashSet<SurveyAnswers>();
        }

        public Guid Id { get; set; }
        public Guid? Personid { get; set; }
        public Guid Surveyid { get; set; }
        public DateTime? Starttime { get; set; }
        public DateTime Adddate { get; set; }
        public Guid Adduser { get; set; }
        public DateTime? Editdate { get; set; }
        public Guid? Edituser { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual Person? Person { get; set; }
        public virtual Survey Survey { get; set; } = null!;
        public virtual ICollection<SurveyAnsweroptions> SurveyAnsweroptions { get; set; }
        public virtual ICollection<SurveyAnswers> SurveyAnswers { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
