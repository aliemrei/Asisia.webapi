using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("SURVEY_ANSWEROPTIONS")]
    public partial class SurveyAnsweroptions : EntityBase 
    {
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


        [Column("ANSWER")]
        [StringLength(250)]
        
        public string? Answer { get; set; }


        [Column("POINT")]
        
        public int? Point { get; set; }


        [Column("ISTRUEANSWER")]
        
        public bool? Istrueanswer { get; set; }


        [Column("CHECKED")]
        
        public bool? Checked { get; set; }


        [Column("QANSWER")]
        [StringLength(250)]
        
        public string? Qanswer { get; set; }



        [ForeignKey(nameof(Questionid))]
        [InverseProperty(nameof(SurveyAnswers.SurveyAnsweroptions))]
        public virtual SurveyAnswers Question { get; set; } = null!;
        [ForeignKey(nameof(Surveysid))]
        [InverseProperty("SurveyAnsweroptions")]
        public virtual Surveys Surveys { get; set; } = null!;

            }
}
