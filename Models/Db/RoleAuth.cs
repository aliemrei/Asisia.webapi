using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("ROLE_AUTH")]
    [Index(nameof(Roleid), nameof(Modulename), Name = "IX_ROLE_AUTH", IsUnique = true)]
    public partial class RoleAuth : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public int Id { get; set; }


        [Column("ROLEID")]
        [RequiredIf]
        public Guid Roleid { get; set; }


        [Column("MODULENAME")]
        [StringLength(150)]
        [RequiredIf]
        public string Modulename { get; set; } = null!;


        [Column("CANLIST")]
        [RequiredIf]
        public bool Canlist { get; set; }


        [Column("CANADD")]
        [RequiredIf]
        public bool Canadd { get; set; }


        [Column("CANEDIT")]
        [RequiredIf]
        public bool Canedit { get; set; }


        [Column("CANVIEW")]
        [RequiredIf]
        public bool Canview { get; set; }


        [Column("CANDELETE")]
        [RequiredIf]
        public bool Candelete { get; set; }


        [Column("CANPRINT")]
        [RequiredIf]
        public bool Canprint { get; set; }


        [Column("CANEXPORT")]
        [RequiredIf]
        public bool Canexport { get; set; }



        [ForeignKey(nameof(Roleid))]
        [InverseProperty(nameof(Roles.RoleAuth))]
        public virtual Roles Role { get; set; } = null!;

            }
}
