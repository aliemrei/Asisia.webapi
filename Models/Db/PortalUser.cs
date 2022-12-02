using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("PORTAL_USER")]
    public partial class PortalUser : EntityBase // My Handlebars Helper
    {
        public PortalUser()
        {
            PortalUserSocialaccount = new HashSet<PortalUserSocialaccount>();
        }

        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("PERSONID")]
        public Guid? Personid { get; set; }
        [Column("PWD")]
        [StringLength(200)]
        public string? Pwd { get; set; }
        [Column("CHANGEKEY")]
        [StringLength(50)]
        public string? Changekey { get; set; }
        [Column("CHANGEDATE", TypeName = "datetime")]
        public DateTime? Changedate { get; set; }
        [Column("EMAIL")]
        [StringLength(250)]
        public string? Email { get; set; }
        [Column("PHONE")]
        public long? Phone { get; set; }

        [ForeignKey(nameof(Personid))]
        [InverseProperty("PortalUser")]
        public virtual Person? Person { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<PortalUserSocialaccount> PortalUserSocialaccount { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
