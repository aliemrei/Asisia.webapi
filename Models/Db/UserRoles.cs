using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("USER_ROLES")]
    public partial class UserRoles : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("USERID")]
        [RequiredIf]
        public Guid Userid { get; set; }


        [Column("ROLEID")]
        [RequiredIf]
        public Guid Roleid { get; set; }


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


        [Column("MODULEID")]
        
        public Guid? Moduleid { get; set; }



        [ForeignKey(nameof(Roleid))]
        [InverseProperty(nameof(Roles.UserRoles))]
        public virtual Roles Role { get; set; } = null!;
        [ForeignKey(nameof(Userid))]
        [InverseProperty(nameof(Users.UserRoles))]
        public virtual Users User { get; set; } = null!;

            }
}
