using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("USER_ROLES")]
    public partial class UserRoles : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("USERID")]
        public Guid Userid { get; set; }
        [Column("ROLEID")]
        public Guid Roleid { get; set; }
        [Column("ISDELETED")]
        public bool Isdeleted { get; set; }
        [Column("ADDUSER")]
        public Guid Adduser { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
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

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
