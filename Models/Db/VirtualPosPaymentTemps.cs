using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("VIRTUAL_POS_PAYMENT_TEMPS")]
    public partial class VirtualPosPaymentTemps : EntityBase 
    {
        public VirtualPosPaymentTemps()
        {
            VirtualPosPaymentEmails = new HashSet<VirtualPosPaymentEmails>();
            VirtualPosPaymentRequests = new HashSet<VirtualPosPaymentRequests>();
            VirtualPosPaymentVposes = new HashSet<VirtualPosPaymentVposes>();
        }

        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("CORPID")]
        [RequiredIf]
        public Guid Corpid { get; set; }


        [Column("DESCRIPTION")]
        [StringLength(150)]
        [RequiredIf]
        public string Description { get; set; } = null!;


        [Column("USEINSTALLMENTS")]
        [RequiredIf]
        public bool Useinstallments { get; set; }


        [Required]
        [Column("USEEMAIL")]
        
        public bool? Useemail { get; set; }


        [Column("USESMS")]
        [RequiredIf]
        public bool Usesms { get; set; }


        [Column("PRICECHANGEABLE")]
        [RequiredIf]
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
        [RequiredIf]
        public Guid Adduser { get; set; }


        [Column("ADDDATE", TypeName = "datetime")]
        [RequiredIf]
        public DateTime Adddate { get; set; }


        [Column("EDITUSER")]
        
        public Guid? Edituser { get; set; }


        [Column("EDITDATE", TypeName = "datetime")]
        
        public DateTime? Editdate { get; set; }


        [Column("ISDELETED")]
        [RequiredIf]
        public bool Isdeleted { get; set; }


        [Column("ISDISABLED")]
        [RequiredIf]
        public bool Isdisabled { get; set; }


        [Column("TITLE")]
        [StringLength(150)]
        
        public string? Title { get; set; }


        [Column("PRICE")]
        [RequiredIf]
        public double Price { get; set; }


        [Column("CURCODE")]
        [StringLength(4)]
        [Unicode(false)]
        [RequiredIf]
        public string Curcode { get; set; } = null!;


        [Column("PIECE")]
        [RequiredIf]
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


        [Column("CANDIV_PAYMENT")]
        
        public bool? CandivPayment { get; set; }


        [Column("RESNUMBER")]
        [StringLength(50)]
        
        public string? Resnumber { get; set; }


        [Column("LANGCODE")]
        [StringLength(6)]
        [Unicode(false)]
        
        public string? Langcode { get; set; }


        [Column("SEND_MAILS_ONLY_CREATEUSER")]
        [RequiredIf]
        public bool SendMailsOnlyCreateuser { get; set; }



        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.VirtualPosPaymentTempsAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Corpid))]
        [InverseProperty("VirtualPosPaymentTemps")]
        public virtual Corp Corp { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.VirtualPosPaymentTempsEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(Emailtempid))]
        [InverseProperty(nameof(VirtualPosPaymentMessageTemps.VirtualPosPaymentTempsEmailtemp))]
        public virtual VirtualPosPaymentMessageTemps? Emailtemp { get; set; }
        [ForeignKey(nameof(Langcode))]
        [InverseProperty(nameof(Stdlanguages.VirtualPosPaymentTemps))]
        public virtual Stdlanguages? LangcodeNavigation { get; set; }
        [ForeignKey(nameof(Smstempid))]
        [InverseProperty(nameof(VirtualPosPaymentMessageTemps.VirtualPosPaymentTempsSmstemp))]
        public virtual VirtualPosPaymentMessageTemps? Smstemp { get; set; }
        [InverseProperty("Temp")]
        public virtual ICollection<VirtualPosPaymentEmails> VirtualPosPaymentEmails { get; set; }
        [InverseProperty("Paymenttemp")]
        public virtual ICollection<VirtualPosPaymentRequests> VirtualPosPaymentRequests { get; set; }
        [InverseProperty("Temp")]
        public virtual ICollection<VirtualPosPaymentVposes> VirtualPosPaymentVposes { get; set; }

            }
}
