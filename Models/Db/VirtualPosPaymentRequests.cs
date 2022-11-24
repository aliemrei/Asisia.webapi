using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class VirtualPosPaymentRequests : EntityBase // My Handlebars Helper
    {
        public VirtualPosPaymentRequests()
        {
            VirtualPosPaymentEmails = new HashSet<VirtualPosPaymentEmails>();
            VirtualPosPaymentRequestsNotes = new HashSet<VirtualPosPaymentRequestsNotes>();
            VirtualPosPaymentVposes = new HashSet<VirtualPosPaymentVposes>();
            VirtualPosPayments = new HashSet<VirtualPosPayments>();
        }

        public Guid Id { get; set; }
        public Guid Corpid { get; set; }
        public Guid Portaluid { get; set; }
        public string Langcode { get; set; } = null!;
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
        public DateTime? Sdate { get; set; }
        public DateTime? Fdate { get; set; }
        public Guid? Paymenttempid { get; set; }
        public bool? CandivPayment { get; set; }
        public string? Resnumber { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Corp Corp { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual VirtualPosPaymentMessageTemps? Emailtemp { get; set; }
        public virtual VirtualPosPaymentTemps? Paymenttemp { get; set; }
        public virtual Portal Portalu { get; set; } = null!;
        public virtual VirtualPosPaymentMessageTemps? Smstemp { get; set; }
        public virtual ICollection<VirtualPosPaymentEmails> VirtualPosPaymentEmails { get; set; }
        public virtual ICollection<VirtualPosPaymentRequestsNotes> VirtualPosPaymentRequestsNotes { get; set; }
        public virtual ICollection<VirtualPosPaymentVposes> VirtualPosPaymentVposes { get; set; }
        public virtual ICollection<VirtualPosPayments> VirtualPosPayments { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
