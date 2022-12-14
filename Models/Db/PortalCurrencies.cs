using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("PORTAL_CURRENCIES")]
    [Index(nameof(Curcode), nameof(Portaluid), Name = "IX_PORTAL_CURRENCIES", IsUnique = true)]
    public partial class PortalCurrencies : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public int Id { get; set; }


        [Column("PORTALUID")]
        [RequiredIf]
        public Guid Portaluid { get; set; }


        [Column("CURCODE")]
        [StringLength(5)]
        [Unicode(false)]
        [RequiredIf]
        public string Curcode { get; set; } = null!;



        [ForeignKey(nameof(Curcode))]
        [InverseProperty("PortalCurrencies")]
        public virtual Curcode CurcodeNavigation { get; set; } = null!;
        public virtual Portal Portalu { get; set; } = null!;

            }
}
