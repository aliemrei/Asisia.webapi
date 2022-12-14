using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("CASHIER_HANDOVER_ENTITY")]
    public partial class CashierHandoverEntity : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("CASHIER_HANDOVERID")]
        [RequiredIf]
        public Guid CashierHandoverid { get; set; }


        [Column("ENTITY_TYPE")]
        [RequiredIf]
        public byte EntityType { get; set; }


        [Column("DEBT")]
        [RequiredIf]
        public double Debt { get; set; }


        [Column("CURCODE")]
        [StringLength(5)]
        [Unicode(false)]
        [RequiredIf]
        public string Curcode { get; set; } = null!;



        [ForeignKey(nameof(CashierHandoverid))]
        [InverseProperty("CashierHandoverEntity")]
        public virtual CashierHandover CashierHandover { get; set; } = null!;
        [ForeignKey(nameof(Curcode))]
        [InverseProperty("CashierHandoverEntity")]
        public virtual Curcode CurcodeNavigation { get; set; } = null!;

            }
}
