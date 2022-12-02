using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("CASHIER_HANDOVER_ENTITY")]
    public partial class CashierHandoverEntity : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("CASHIER_HANDOVERID")]
        public Guid CashierHandoverid { get; set; }
        [Column("ENTITY_TYPE")]
        public byte EntityType { get; set; }
        [Column("DEBT")]
        public double Debt { get; set; }
        [Column("CURCODE")]
        [StringLength(5)]
        [Unicode(false)]
        public string Curcode { get; set; } = null!;

        [ForeignKey(nameof(CashierHandoverid))]
        [InverseProperty("CashierHandoverEntity")]
        public virtual CashierHandover CashierHandover { get; set; } = null!;
        [ForeignKey(nameof(Curcode))]
        [InverseProperty("CashierHandoverEntity")]
        public virtual Curcode CurcodeNavigation { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
