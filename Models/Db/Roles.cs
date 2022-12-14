using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("ROLES")]
    public partial class Roles : EntityBase 
    {
        public Roles()
        {
            RoleAuth = new HashSet<RoleAuth>();
            RolesDashboards = new HashSet<RolesDashboards>();
            UserRoleRequestStatus = new HashSet<UserRoleRequestStatus>();
            UserRoles = new HashSet<UserRoles>();
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
        [RequiredIf]
        public string Name { get; set; } = null!;


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



        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.RolesAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Corpid))]
        [InverseProperty("Roles")]
        public virtual Corp Corp { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.RolesEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [InverseProperty("Role")]
        public virtual ICollection<RoleAuth> RoleAuth { get; set; }
        [InverseProperty("Role")]
        public virtual ICollection<RolesDashboards> RolesDashboards { get; set; }
        [InverseProperty("Role")]
        public virtual ICollection<UserRoleRequestStatus> UserRoleRequestStatus { get; set; }
        [InverseProperty("Role")]
        public virtual ICollection<UserRoles> UserRoles { get; set; }

            }
}
