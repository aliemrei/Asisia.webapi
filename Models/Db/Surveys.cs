using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("SURVEYS")]
    public partial class Surveys : EntityBase // My Handlebars Helper
    {
        public Surveys()
        {
            SurveyAnsweroptions = new HashSet<SurveyAnsweroptions>();
            SurveyAnswers = new HashSet<SurveyAnswers>();
        }

        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("PERSONID")]
        public Guid? Personid { get; set; }
        [Column("SURVEYID")]
        public Guid Surveyid { get; set; }
        [Column("STARTTIME", TypeName = "datetime")]
        public DateTime? Starttime { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("ADDUSER")]
        public Guid Adduser { get; set; }
        [Column("EDITDATE", TypeName = "datetime")]
        public DateTime? Editdate { get; set; }
        [Column("EDITUSER")]
        public Guid? Edituser { get; set; }

        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.SurveysAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.SurveysEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(Personid))]
        [InverseProperty("Surveys")]
        public virtual Person? Person { get; set; }
        [ForeignKey(nameof(Surveyid))]
        [InverseProperty("Surveys")]
        public virtual Survey Survey { get; set; } = null!;
        [InverseProperty("Surveys")]
        public virtual ICollection<SurveyAnsweroptions> SurveyAnsweroptions { get; set; }
        [InverseProperty("Surveys")]
        public virtual ICollection<SurveyAnswers> SurveyAnswers { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
