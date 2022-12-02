using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("ROLE_AUTH")]
    [Index(nameof(Roleid), nameof(Modulename), Name = "IX_ROLE_AUTH", IsUnique = true)]
    public partial class RoleAuth : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("ROLEID")]
        public Guid Roleid { get; set; }
        [Column("MODULENAME")]
        [StringLength(150)]
        public string Modulename { get; set; } = null!;
        [Column("CANLIST")]
        public bool Canlist { get; set; }
        [Column("CANADD")]
        public bool Canadd { get; set; }
        [Column("CANEDIT")]
        public bool Canedit { get; set; }
        [Column("CANVIEW")]
        public bool Canview { get; set; }
        [Column("CANDELETE")]
        public bool Candelete { get; set; }
        [Column("CANPRINT")]
        public bool Canprint { get; set; }
        [Column("CANEXPORT")]
        public bool Canexport { get; set; }

        [ForeignKey(nameof(Roleid))]
        [InverseProperty(nameof(Roles.RoleAuth))]
        public virtual Roles Role { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
