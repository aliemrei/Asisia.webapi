using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("VIRTUAL_POS_DEP_PAYMENTS_CANCEL")]
    [Index(nameof(Entid), Name = "IX_VIRTUAL_POS_DEP_PAYMENTS_CANCEL")]
    public partial class VirtualPosDepPaymentsCancel : EntityBase // My Handlebars Helper
    {
        public VirtualPosDepPaymentsCancel()
        {
            RequestPayments = new HashSet<RequestPayments>();
        }

        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("PAYMENTID")]
        public Guid Paymentid { get; set; }
        [Column("AMOUNT")]
        public double Amount { get; set; }
        [Column("ISREFUND")]
        public bool Isrefund { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("ADDUSER")]
        public Guid Adduser { get; set; }
        [Column("EDITDATE", TypeName = "datetime")]
        public DateTime? Editdate { get; set; }
        [Column("EDITUSER")]
        public Guid? Edituser { get; set; }
        [Column("SUCCESS")]
        public bool Success { get; set; }
        [Column("REQUEST_DETAILID")]
        public Guid? RequestDetailid { get; set; }
        [Column("ENTID")]
        [StringLength(100)]
        public string? Entid { get; set; }

        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.VirtualPosDepPaymentsCancelAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.VirtualPosDepPaymentsCancelEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(Paymentid))]
        [InverseProperty(nameof(VirtualPosDepPayments.VirtualPosDepPaymentsCancel))]
        public virtual VirtualPosDepPayments Payment { get; set; } = null!;
        [ForeignKey(nameof(RequestDetailid))]
        [InverseProperty("VirtualPosDepPaymentsCancel")]
        public virtual RequestDetail? RequestDetail { get; set; }
        [InverseProperty("VirtualPosDepPaymentCancel")]
        public virtual ICollection<RequestPayments> RequestPayments { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
