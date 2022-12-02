using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("VIRTUAL_POS_PAYMENT_REQUESTS")]
    [Index(nameof(Adddate), Name = "IX_VIRTUAL_POS_PAYMENT_REQUESTS")]
    [Index(nameof(Adddate), Name = "IX_VIRTUAL_POS_PAYMENT_REQUESTS_1")]
    [Index(nameof(Adddate), nameof(Isdeleted), nameof(Corpid), Name = "IX_VIRTUAL_POS_PAYMENT_REQUESTS_2")]
    [Index(nameof(Isdeleted), Name = "IX_VIRTUAL_POS_PAYMENT_REQUESTS_3")]
    public partial class VirtualPosPaymentRequests : EntityBase // My Handlebars Helper
    {
        public VirtualPosPaymentRequests()
        {
            VirtualPosPaymentEmails = new HashSet<VirtualPosPaymentEmails>();
            VirtualPosPaymentRequestsNotes = new HashSet<VirtualPosPaymentRequestsNotes>();
            VirtualPosPaymentVposes = new HashSet<VirtualPosPaymentVposes>();
            VirtualPosPayments = new HashSet<VirtualPosPayments>();
        }

        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("CORPID")]
        public Guid Corpid { get; set; }
        [Column("PORTALUID")]
        public Guid Portaluid { get; set; }
        [Column("LANGCODE")]
        [StringLength(6)]
        [Unicode(false)]
        public string Langcode { get; set; } = null!;
        [Column("DESCRIPTION")]
        [StringLength(150)]
        public string Description { get; set; } = null!;
        [Column("USEINSTALLMENTS")]
        public bool Useinstallments { get; set; }
        [Required]
        [Column("USEEMAIL")]
        public bool? Useemail { get; set; }
        [Column("USESMS")]
        public bool Usesms { get; set; }
        [Column("PRICECHANGEABLE")]
        public bool Pricechangeable { get; set; }
        [Column("EMAILTEMPID")]
        public Guid? Emailtempid { get; set; }
        [Column("SMSTEMPID")]
        public Guid? Smstempid { get; set; }
        [Column("EMAILTEXT")]
        public string? Emailtext { get; set; }
        [Column("SMSTEXT")]
        public string? Smstext { get; set; }
        [Column("ADDUSER")]
        public Guid Adduser { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("EDITUSER")]
        public Guid? Edituser { get; set; }
        [Column("EDITDATE", TypeName = "datetime")]
        public DateTime? Editdate { get; set; }
        [Column("ISDELETED")]
        public bool Isdeleted { get; set; }
        [Column("ISDISABLED")]
        public bool Isdisabled { get; set; }
        [Column("TITLE")]
        [StringLength(150)]
        public string? Title { get; set; }
        [Column("PRICE")]
        public double Price { get; set; }
        [Column("CURCODE")]
        [StringLength(4)]
        [Unicode(false)]
        public string Curcode { get; set; } = null!;
        [Column("PIECE")]
        public int Piece { get; set; }
        [Column("PAYMENT_DESCRIPTION")]
        public string? PaymentDescription { get; set; }
        [Column("PAYMENT_TEXT")]
        public string? PaymentText { get; set; }
        [Column("PAYMENT_SUCCESSTEXT")]
        public string? PaymentSuccesstext { get; set; }
        [Column("PAYMENT_ERRORTEXT")]
        public string? PaymentErrortext { get; set; }
        [Column("SMS_TEXT")]
        public string? SmsText1 { get; set; }
        [Column("SMS_SUCCESSTEXT")]
        public string? SmsSuccesstext { get; set; }
        [Column("SMS_ERRORTEXT")]
        public string? SmsErrortext { get; set; }
        [Column("SDATE", TypeName = "datetime")]
        public DateTime? Sdate { get; set; }
        [Column("FDATE", TypeName = "datetime")]
        public DateTime? Fdate { get; set; }
        [Column("PAYMENTTEMPID")]
        public Guid? Paymenttempid { get; set; }
        [Column("CANDIV_PAYMENT")]
        public bool? CandivPayment { get; set; }
        [Column("RESNUMBER")]
        [StringLength(50)]
        public string? Resnumber { get; set; }

        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.VirtualPosPaymentRequestsAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Corpid))]
        [InverseProperty("VirtualPosPaymentRequests")]
        public virtual Corp Corp { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.VirtualPosPaymentRequestsEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(Emailtempid))]
        [InverseProperty(nameof(VirtualPosPaymentMessageTemps.VirtualPosPaymentRequestsEmailtemp))]
        public virtual VirtualPosPaymentMessageTemps? Emailtemp { get; set; }
        [ForeignKey(nameof(Paymenttempid))]
        [InverseProperty(nameof(VirtualPosPaymentTemps.VirtualPosPaymentRequests))]
        public virtual VirtualPosPaymentTemps? Paymenttemp { get; set; }
        public virtual Portal Portalu { get; set; } = null!;
        [ForeignKey(nameof(Smstempid))]
        [InverseProperty(nameof(VirtualPosPaymentMessageTemps.VirtualPosPaymentRequestsSmstemp))]
        public virtual VirtualPosPaymentMessageTemps? Smstemp { get; set; }
        [InverseProperty("Payment")]
        public virtual ICollection<VirtualPosPaymentEmails> VirtualPosPaymentEmails { get; set; }
        [InverseProperty("Payment")]
        public virtual ICollection<VirtualPosPaymentRequestsNotes> VirtualPosPaymentRequestsNotes { get; set; }
        [InverseProperty("Payment")]
        public virtual ICollection<VirtualPosPaymentVposes> VirtualPosPaymentVposes { get; set; }
        [InverseProperty("PaymentRequest")]
        public virtual ICollection<VirtualPosPayments> VirtualPosPayments { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
