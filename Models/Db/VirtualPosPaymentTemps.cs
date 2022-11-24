using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class VirtualPosPaymentTemps : EntityBase // My Handlebars Helper
    {
        public VirtualPosPaymentTemps()
        {
            VirtualPosPaymentEmails = new HashSet<VirtualPosPaymentEmails>();
            VirtualPosPaymentRequests = new HashSet<VirtualPosPaymentRequests>();
            VirtualPosPaymentVposes = new HashSet<VirtualPosPaymentVposes>();
        }

        public Guid Id { get; set; }
        public Guid Corpid { get; set; }
        public string Description { get; set; } = null!;
        public bool Useinstallments { get; set; }
        public bool? Useemail { get; set; }
        public bool Usesms { get; set; }
        public bool Pricechangeable { get; set; }
        public Guid? Emailtempid { get; set; }
        public Guid? Smstempid { get; set; }
        public string? Emailtext { get; set; }
        public string? Smstext { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public bool Isdeleted { get; set; }
        public bool Isdisabled { get; set; }
        public string? Title { get; set; }
        public double Price { get; set; }
        public string Curcode { get; set; } = null!;
        public int Piece { get; set; }
        public string? PaymentDescription { get; set; }
        public string? PaymentText { get; set; }
        public string? PaymentSuccesstext { get; set; }
        public string? PaymentErrortext { get; set; }
        public string? SmsText1 { get; set; }
        public string? SmsSuccesstext { get; set; }
        public string? SmsErrortext { get; set; }
        public bool? CandivPayment { get; set; }
        public string? Resnumber { get; set; }
        public string? Langcode { get; set; }
        public bool SendMailsOnlyCreateuser { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Corp Corp { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual VirtualPosPaymentMessageTemps? Emailtemp { get; set; }
        public virtual Stdlanguages? LangcodeNavigation { get; set; }
        public virtual VirtualPosPaymentMessageTemps? Smstemp { get; set; }
        public virtual ICollection<VirtualPosPaymentEmails> VirtualPosPaymentEmails { get; set; }
        public virtual ICollection<VirtualPosPaymentRequests> VirtualPosPaymentRequests { get; set; }
        public virtual ICollection<VirtualPosPaymentVposes> VirtualPosPaymentVposes { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
