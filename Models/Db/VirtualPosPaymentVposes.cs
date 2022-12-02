using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("VIRTUAL_POS_PAYMENT_VPOSES")]
    public partial class VirtualPosPaymentVposes : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("TEMPID")]
        public Guid? Tempid { get; set; }
        [Column("PAYMENTID")]
        public Guid? Paymentid { get; set; }
        [Column("INSTALLMENTID")]
        public Guid? Installmentid { get; set; }
        [Column("ADDUSER")]
        public Guid Adduser { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("EDITUSER")]
        public Guid? Edituser { get; set; }
        [Column("EDITDATE", TypeName = "datetime")]
        public DateTime? Editdate { get; set; }

        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.VirtualPosPaymentVposesAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.VirtualPosPaymentVposesEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(Installmentid))]
        [InverseProperty(nameof(VirtualPosAccountInstalments.VirtualPosPaymentVposes))]
        public virtual VirtualPosAccountInstalments? Installment { get; set; }
        [ForeignKey(nameof(Paymentid))]
        [InverseProperty(nameof(VirtualPosPaymentRequests.VirtualPosPaymentVposes))]
        public virtual VirtualPosPaymentRequests? Payment { get; set; }
        [ForeignKey(nameof(Tempid))]
        [InverseProperty(nameof(VirtualPosPaymentTemps.VirtualPosPaymentVposes))]
        public virtual VirtualPosPaymentTemps? Temp { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
