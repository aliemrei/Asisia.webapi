using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("PORTAL_AUTH_IPADDRESS")]
    [Index(nameof(Ipaddress), nameof(Portaluid), Name = "IX_PORTAL_AUTH_IPADDRESS")]
    public partial class PortalAuthIpaddress : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("PORTALUID")]
        public Guid Portaluid { get; set; }
        [Column("IPADDRESS")]
        [StringLength(35)]
        public string Ipaddress { get; set; } = null!;
        [Required]
        [Column("ISMANAGER")]
        public bool? Ismanager { get; set; }

        public virtual Portal Portalu { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
