using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("USER_PROJECTS")]
    [Index(nameof(Userid), nameof(ProjectGroupid), Name = "IX_USER_PROJECTS", IsUnique = true)]
    public partial class UserProjects : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("USERID")]
        [RequiredIf]
        public Guid Userid { get; set; }


        [Column("PROJECT_GROUPID")]
        
        public Guid? ProjectGroupid { get; set; }


        [Column("ISDISABLED")]
        [RequiredIf]
        public bool Isdisabled { get; set; }


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



        [ForeignKey(nameof(ProjectGroupid))]
        [InverseProperty("UserProjects")]
        public virtual ProjectGroup? ProjectGroup { get; set; }

            }
}
