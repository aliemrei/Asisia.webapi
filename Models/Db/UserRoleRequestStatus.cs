using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("USER_ROLE_REQUEST_STATUS")]
    public partial class UserRoleRequestStatus : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("ROLEID")]
        [RequiredIf]
        public Guid Roleid { get; set; }


        [Column("STATUID")]
        [RequiredIf]
        public Guid Statuid { get; set; }


        [Column("ALLOW")]
        
        public bool? Allow { get; set; }



        [ForeignKey(nameof(Roleid))]
        [InverseProperty(nameof(Roles.UserRoleRequestStatus))]
        public virtual Roles Role { get; set; } = null!;
        [ForeignKey(nameof(Statuid))]
        [InverseProperty(nameof(RequestStatus.UserRoleRequestStatus))]
        public virtual RequestStatus Statu { get; set; } = null!;

            }
}
