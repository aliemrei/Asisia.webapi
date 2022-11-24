using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class VirtualPosPayments : EntityBase // My Handlebars Helper
    {
        public VirtualPosPayments()
        {
            RequestPayments = new HashSet<RequestPayments>();
        }

        public Guid Id { get; set; }
        public int Intid { get; set; }
        public Guid Posaccountid { get; set; }
        public Guid? Requestid { get; set; }
        public string? Cardowner { get; set; }
        public string? Cardnumber { get; set; }
        public int? Validyear { get; set; }
        public int? Validmonth { get; set; }
        public string? Cvv { get; set; }
        public double Amount { get; set; }
        public string Curcode { get; set; } = null!;
        public int Instalment { get; set; }
        public Guid? Status { get; set; }
        public string? Authcode { get; set; }
        public string? Retrefnumber { get; set; }
        public string? Trantype { get; set; }
        public string? Storetype { get; set; }
        public string? PayerAuthcode { get; set; }
        public string? PayerTnxid { get; set; }
        public string? Eci { get; set; }
        public string? Statustext { get; set; }
        public DateTime? Endtime { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public bool Preauth { get; set; }
        public bool Postauth { get; set; }
        public bool Void { get; set; }
        public bool Refund { get; set; }
        public Guid Posinstalmentid { get; set; }
        public bool Firststep { get; set; }
        public Guid Corpid { get; set; }
        public double? LastAmount { get; set; }
        public bool Isdeleted { get; set; }
        public string? Entid { get; set; }
        public int Isintegrated { get; set; }
        public string? Description { get; set; }
        public bool? CompletebasketAftersuccess { get; set; }
        public DateTime? Validdate { get; set; }
        public string? BasketDescription { get; set; }
        public bool Fixit { get; set; }
        public Guid? PaymentRequestid { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Corp Corp { get; set; } = null!;
        public virtual Curcode CurcodeNavigation { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual VirtualPosPaymentRequests? PaymentRequest { get; set; }
        public virtual VirtualPosAccounts Posaccount { get; set; } = null!;
        public virtual VirtualPosAccountInstalments Posinstalment { get; set; } = null!;
        public virtual Request? Request { get; set; }
        public virtual RequestStatus? StatusNavigation { get; set; }
        public virtual ICollection<RequestPayments> RequestPayments { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
