using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("PORTAL_CURRENCIES")]
    [Index(nameof(Curcode), nameof(Portaluid), Name = "IX_PORTAL_CURRENCIES", IsUnique = true)]
    public partial class PortalCurrencies : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("PORTALUID")]
        public Guid Portaluid { get; set; }
        [Column("CURCODE")]
        [StringLength(5)]
        [Unicode(false)]
        public string Curcode { get; set; } = null!;

        [ForeignKey(nameof(Curcode))]
        [InverseProperty("PortalCurrencies")]
        public virtual Curcode CurcodeNavigation { get; set; } = null!;
        public virtual Portal Portalu { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
