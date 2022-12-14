using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("USER_PROJECT_DETAILS")]
    public partial class UserProjectDetails : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("USERID")]
        [RequiredIf]
        public Guid Userid { get; set; }


        [Column("PROJECT_GROUPDETAILID")]
        
        public Guid? ProjectGroupdetailid { get; set; }


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



        [ForeignKey(nameof(ProjectGroupdetailid))]
        [InverseProperty("UserProjectDetails")]
        public virtual ProjectGroupdetail? ProjectGroupdetail { get; set; }

            }
}
