using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("VIRTUAL_POS_ACCOUNTS_CURCODES")]
    [Index(nameof(Accountid), nameof(Curcode), Name = "UQ__VIRTUAL___0ACA257EBD9DAF3E", IsUnique = true)]
    public partial class VirtualPosAccountsCurcodes : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("ACCOUNTID")]
        public Guid Accountid { get; set; }
        [Column("CURCODE")]
        [StringLength(5)]
        [Unicode(false)]
        public string Curcode { get; set; } = null!;
        [Column("SCHEMES")]
        [StringLength(220)]
        public string? Schemes { get; set; }

        [ForeignKey(nameof(Accountid))]
        [InverseProperty(nameof(VirtualPosAccounts.VirtualPosAccountsCurcodes))]
        public virtual VirtualPosAccounts Account { get; set; } = null!;
        [ForeignKey(nameof(Curcode))]
        [InverseProperty("VirtualPosAccountsCurcodes")]
        public virtual Curcode CurcodeNavigation { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
