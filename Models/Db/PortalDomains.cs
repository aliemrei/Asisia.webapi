using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("PORTAL_DOMAINS")]
    [Index(nameof(Portaluid), nameof(Domain), Name = "UQ__PORTAL_D__73E21ECAE3DDAF90", IsUnique = true)]
    public partial class PortalDomains : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("PORTALUID")]
        [RequiredIf]
        public Guid Portaluid { get; set; }


        [Column("DOMAIN")]
        [StringLength(250)]
        [RequiredIf]
        public string Domain { get; set; } = null!;


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


        [Column("ONLYBODY")]
        [RequiredIf]
        public bool Onlybody { get; set; }



        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.PortalDomainsAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.PortalDomainsEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        public virtual Portal Portalu { get; set; } = null!;

            }
}
