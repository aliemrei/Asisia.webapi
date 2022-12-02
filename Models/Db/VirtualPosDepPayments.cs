using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("VIRTUAL_POS_DEP_PAYMENTS")]
    [Index(nameof(Adddate), Name = "IX_VIRTUAL_POS_DEP_PAYMENTS")]
    [Index(nameof(Adddate), Name = "IX_VIRTUAL_POS_DEP_PAYMENTS_1")]
    [Index(nameof(Editdate), Name = "IX_VIRTUAL_POS_DEP_PAYMENTS_2")]
    [Index(nameof(Editdate), Name = "IX_VIRTUAL_POS_DEP_PAYMENTS_3")]
    [Index(nameof(Status), Name = "IX_VIRTUAL_POS_DEP_PAYMENTS_4")]
    [Index(nameof(Transfercode), Name = "IX_VIRTUAL_POS_DEP_PAYMENTS_5")]
    [Index(nameof(Isdeleted), Name = "IX_VIRTUAL_POS_DEP_PAYMENTS_6")]
    [Index(nameof(Intid), Name = "IX_VIRTUAL_POS_DEP_PAYMENTS_7")]
    [Index(nameof(Entid), Name = "IX_VIRTUAL_POS_DEP_PAYMENTS_8")]
    public partial class VirtualPosDepPayments : EntityBase // My Handlebars Helper
    {
        public VirtualPosDepPayments()
        {
            RequestPayments = new HashSet<RequestPayments>();
            VirtualPosDepPaymentsCancel = new HashSet<VirtualPosDepPaymentsCancel>();
        }

        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("POSACCOUNTID")]
        public Guid Posaccountid { get; set; }
        [Column("AMOUNT")]
        public double Amount { get; set; }
        [Column("STATUS")]
        public Guid Status { get; set; }
        [Column("ADDUSER")]
        public Guid Adduser { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("EDITUSER")]
        public Guid? Edituser { get; set; }
        [Column("EDITDATE", TypeName = "datetime")]
        public DateTime? Editdate { get; set; }
        [Column("TRANSFERCODE")]
        [StringLength(10)]
        public string? Transfercode { get; set; }
        [Column("REQUESTID")]
        public Guid? Requestid { get; set; }
        [Column("ISDELETED")]
        public bool Isdeleted { get; set; }
        [Column("INTID")]
        public int Intid { get; set; }
        [Column("ENDTIME", TypeName = "datetime")]
        public DateTime? Endtime { get; set; }
        [Column("BANKTRANSACTIONID")]
        [StringLength(50)]
        public string? Banktransactionid { get; set; }
        [Column("ENTID")]
        [StringLength(100)]
        public string? Entid { get; set; }

        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.VirtualPosDepPaymentsAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.VirtualPosDepPaymentsEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(Posaccountid))]
        [InverseProperty(nameof(VirtualPosDepAccounts.VirtualPosDepPayments))]
        public virtual VirtualPosDepAccounts Posaccount { get; set; } = null!;
        [ForeignKey(nameof(Requestid))]
        [InverseProperty("VirtualPosDepPayments")]
        public virtual Request? Request { get; set; }
        [ForeignKey(nameof(Status))]
        [InverseProperty(nameof(RequestStatus.VirtualPosDepPayments))]
        public virtual RequestStatus StatusNavigation { get; set; } = null!;
        [InverseProperty("VirtualPosDepPayment")]
        public virtual ICollection<RequestPayments> RequestPayments { get; set; }
        [InverseProperty("Payment")]
        public virtual ICollection<VirtualPosDepPaymentsCancel> VirtualPosDepPaymentsCancel { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
