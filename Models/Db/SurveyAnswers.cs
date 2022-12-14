using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("SURVEY_ANSWERS")]
    public partial class SurveyAnswers : EntityBase 
    {
        public SurveyAnswers()
        {
            SurveyAnsweroptions = new HashSet<SurveyAnsweroptions>();
        }

        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("SURVEYSID")]
        [RequiredIf]
        public Guid Surveysid { get; set; }


        [Column("QUESTIONID")]
        [RequiredIf]
        public Guid Questionid { get; set; }


        [Column("QUESTION")]
        [StringLength(250)]
        
        public string? Question { get; set; }


        [Column("TYPE")]
        
        public int? Type { get; set; }


        [Column("REQUIRED")]
        [RequiredIf]
        public bool Required { get; set; }


        [Column("USEOTHER")]
        [RequiredIf]
        public bool Useother { get; set; }


        [Column("OTHERISANSWER")]
        [RequiredIf]
        public bool Otherisanswer { get; set; }


        [Column("OTHERANSWER")]
        [StringLength(250)]
        
        public string? Otheranswer { get; set; }


        [Column("ANSWER")]
        [StringLength(250)]
        
        public string? Answer { get; set; }



        [ForeignKey(nameof(Surveysid))]
        [InverseProperty("SurveyAnswers")]
        public virtual Surveys Surveys { get; set; } = null!;
        [InverseProperty("Question")]
        public virtual ICollection<SurveyAnsweroptions> SurveyAnsweroptions { get; set; }

            }
}
