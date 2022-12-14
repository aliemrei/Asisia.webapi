using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("VIRTUAL_POS_PAYMENTS")]
    [Index(nameof(Isdeleted), Name = "IX_VIRTUAL_POS_PAYMENTS")]
    [Index(nameof(Adddate), Name = "IX_VIRTUAL_POS_PAYMENTS_1")]
    [Index(nameof(Adddate), Name = "IX_VIRTUAL_POS_PAYMENTS_2")]
    [Index(nameof(Firststep), Name = "IX_VIRTUAL_POS_PAYMENTS_3")]
    [Index(nameof(Void), Name = "IX_VIRTUAL_POS_PAYMENTS_4")]
    [Index(nameof(Refund), Name = "IX_VIRTUAL_POS_PAYMENTS_5")]
    [Index(nameof(Entid), Name = "IX_VIRTUAL_POS_PAYMENTS_6")]
    [Index(nameof(Isdeleted), nameof(PaymentRequestid), nameof(Status), Name = "IX_VIRTUAL_POS_PAYMENTS_ISDELETED_PAYMENT_REQUESTID_STATUS")]
    [Index(nameof(Status), nameof(Isdeleted), Name = "MIS_IDX_01")]
    [Index(nameof(Isdeleted), Name = "MIS_IDX_2")]
    [Index(nameof(Isdeleted), Name = "MIS_IDX_VIRTUAL_POS_PAYMENTS_01")]
    public partial class VirtualPosPayments : EntityBase 
    {
        public VirtualPosPayments()
        {
            RequestPayments = new HashSet<RequestPayments>();
        }

        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("INTID")]
        [RequiredIf]
        public int Intid { get; set; }


        [Column("POSACCOUNTID")]
        [RequiredIf]
        public Guid Posaccountid { get; set; }


        [Column("REQUESTID")]
        
        public Guid? Requestid { get; set; }


        [Column("CARDOWNER")]
        [StringLength(200)]
        
        public string? Cardowner { get; set; }


        [Column("CARDNUMBER")]
        [StringLength(50)]
        
        public string? Cardnumber { get; set; }


        [Column("VALIDYEAR")]
        
        public int? Validyear { get; set; }


        [Column("VALIDMONTH")]
        
        public int? Validmonth { get; set; }


        [Column("CVV")]
        [StringLength(5)]
        
        public string? Cvv { get; set; }


        [Column("AMOUNT")]
        [RequiredIf]
        public double Amount { get; set; }


        [Column("CURCODE")]
        [StringLength(5)]
        [Unicode(false)]
        [RequiredIf]
        public string Curcode { get; set; } = null!;


        [Column("INSTALMENT")]
        [RequiredIf]
        public int Instalment { get; set; }


        [Column("STATUS")]
        
        public Guid? Status { get; set; }


        [Column("AUTHCODE")]
        [StringLength(200)]
        
        public string? Authcode { get; set; }


        [Column("RETREFNUMBER")]
        [StringLength(200)]
        
        public string? Retrefnumber { get; set; }


        [Column("TRANTYPE")]
        [StringLength(15)]
        
        public string? Trantype { get; set; }


        [Column("STORETYPE")]
        [StringLength(30)]
        
        public string? Storetype { get; set; }


        [Column("PAYER_AUTHCODE")]
        [StringLength(50)]
        
        public string? PayerAuthcode { get; set; }


        [Column("PAYER_TNXID")]
        [StringLength(50)]
        
        public string? PayerTnxid { get; set; }


        [Column("ECI")]
        [StringLength(50)]
        
        public string? Eci { get; set; }


        [Column("STATUSTEXT")]
        [StringLength(500)]
        
        public string? Statustext { get; set; }


        [Column("ENDTIME", TypeName = "datetime")]
        
        public DateTime? Endtime { get; set; }


        [Column("ADDUSER")]
        [RequiredIf]
        public Guid Adduser { get; set; }


        [Column("ADDDATE", TypeName = "datetime")]
        [RequiredIf]
        public DateTime Adddate { get; set; }


        [Column("EDITUSER")]
        
        public Guid? Edituser { get; set; }


        [Column("EDITDATE", TypeName = "datetime")]
        
        public DateTime? Editdate { get; set; }


        [Column("PREAUTH")]
        [RequiredIf]
        public bool Preauth { get; set; }


        [Column("POSTAUTH")]
        [RequiredIf]
        public bool Postauth { get; set; }


        [Column("VOID")]
        [RequiredIf]
        public bool Void { get; set; }


        [Column("REFUND")]
        [RequiredIf]
        public bool Refund { get; set; }


        [Column("POSINSTALMENTID")]
        [RequiredIf]
        public Guid Posinstalmentid { get; set; }


        [Column("FIRSTSTEP")]
        [RequiredIf]
        public bool Firststep { get; set; }


        [Column("CORPID")]
        [RequiredIf]
        public Guid Corpid { get; set; }


        [Column("LAST_AMOUNT")]
        
        public double? LastAmount { get; set; }


        [Column("ISDELETED")]
        [RequiredIf]
        public bool Isdeleted { get; set; }


        [Column("ENTID")]
        [StringLength(100)]
        
        public string? Entid { get; set; }


        [Column("ISINTEGRATED")]
        [RequiredIf]
        public int Isintegrated { get; set; }


        [Column("DESCRIPTION")]
        [StringLength(100)]
        
        public string? Description { get; set; }


        [Column("COMPLETEBASKET_AFTERSUCCESS")]
        
        public bool? CompletebasketAftersuccess { get; set; }


        [Column("VALIDDATE", TypeName = "datetime")]
        
        public DateTime? Validdate { get; set; }


        [Column("BASKET_DESCRIPTION")]
        
        public string? BasketDescription { get; set; }


        [Column("FIXIT")]
        [RequiredIf]
        public bool Fixit { get; set; }


        [Column("PAYMENT_REQUESTID")]
        
        public Guid? PaymentRequestid { get; set; }



        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.VirtualPosPaymentsAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Corpid))]
        [InverseProperty("VirtualPosPayments")]
        public virtual Corp Corp { get; set; } = null!;
        [ForeignKey(nameof(Curcode))]
        [InverseProperty("VirtualPosPayments")]
        public virtual Curcode CurcodeNavigation { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.VirtualPosPaymentsEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(PaymentRequestid))]
        [InverseProperty(nameof(VirtualPosPaymentRequests.VirtualPosPayments))]
        public virtual VirtualPosPaymentRequests? PaymentRequest { get; set; }
        [ForeignKey(nameof(Posaccountid))]
        [InverseProperty(nameof(VirtualPosAccounts.VirtualPosPayments))]
        public virtual VirtualPosAccounts Posaccount { get; set; } = null!;
        [ForeignKey(nameof(Posinstalmentid))]
        [InverseProperty(nameof(VirtualPosAccountInstalments.VirtualPosPayments))]
        public virtual VirtualPosAccountInstalments Posinstalment { get; set; } = null!;
        [ForeignKey(nameof(Requestid))]
        [InverseProperty("VirtualPosPayments")]
        public virtual Request? Request { get; set; }
        [ForeignKey(nameof(Status))]
        [InverseProperty(nameof(RequestStatus.VirtualPosPayments))]
        public virtual RequestStatus? StatusNavigation { get; set; }
        [InverseProperty("VirtualPosPayment")]
        public virtual ICollection<RequestPayments> RequestPayments { get; set; }

            }
}
