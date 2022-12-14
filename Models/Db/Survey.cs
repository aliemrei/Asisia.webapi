using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("SURVEY")]
    public partial class Survey : EntityBase 
    {
        public Survey()
        {
            Surveys = new HashSet<Surveys>();
        }

        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("CORPID")]
        [RequiredIf]
        public Guid Corpid { get; set; }


        [Column("NAME")]
        [StringLength(100)]
        
        public string? Name { get; set; }


        [Column("DESCRIPTION")]
        
        public string? Description { get; set; }


        [Column("TITLE")]
        [StringLength(250)]
        
        public string? Title { get; set; }


        [Required]
        [Column("TITLEVISIBLE")]
        
        public bool? Titlevisible { get; set; }


        [Column("EXITLINKVISIBLE")]
        [RequiredIf]
        public bool Exitlinkvisible { get; set; }


        [Required]
        [Column("REQUIREDMARKS")]
        
        public bool? Requiredmarks { get; set; }


        [Required]
        [Column("QUESTIONNUMBERS")]
        
        public bool? Questionnumbers { get; set; }


        [Column("ISDELETED")]
        [RequiredIf]
        public bool Isdeleted { get; set; }


        [Column("ADDUSER")]
        [RequiredIf]
        public Guid Adduser { get; set; }


        [Column("ADDDATE", TypeName = "datetime")]
        [RequiredIf]
        public DateTime Adddate { get; set; }


        [Column("EDITUSER")]
        
        public Guid? Edituser { get; set; }


        [Column("EDITDATE", TypeName = "datetime")]
        
        public DateTime? Editdate { get; set; }


        [Column("DESIGN")]
        
        public string? Design { get; set; }


        [Column("CONFIRMBEFORE")]
        [RequiredIf]
        public bool Confirmbefore { get; set; }



        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.SurveyAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Corpid))]
        [InverseProperty("Survey")]
        public virtual Corp Corp { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.SurveyEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [InverseProperty("Survey")]
        public virtual ICollection<Surveys> Surveys { get; set; }

            }
}
