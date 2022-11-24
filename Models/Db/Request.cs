using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class Request : EntityBase // My Handlebars Helper
    {
        public Request()
        {
            BasketData = new HashSet<BasketData>();
            CallJobs = new HashSet<CallJobs>();
            Payments = new HashSet<Payments>();
            RequestDetail = new HashSet<RequestDetail>();
            RequestNotes = new HashSet<RequestNotes>();
            SmtpMails = new HashSet<SmtpMails>();
            VirtualPosDepPayments = new HashSet<VirtualPosDepPayments>();
            VirtualPosPayments = new HashSet<VirtualPosPayments>();
        }

        public Guid Id { get; set; }
        public Guid? Personid { get; set; }
        public Guid Corpid { get; set; }
        public Guid Resourceid { get; set; }
        public Guid? ProjectDetailid { get; set; }
        public string? ReqUrl { get; set; }
        public string? Campaigncode { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public DateTime? Creationdate { get; set; }
        public TimeSpan? Creationtime { get; set; }
        public Guid ProjectGroupid { get; set; }
        public Guid? Status { get; set; }
        public Guid? Substatus { get; set; }
        public string? RakamId { get; set; }
        public int? PersonCcardid { get; set; }
        public string? Curcode { get; set; }
        public Guid? Posaccountid { get; set; }
        public Guid? Posinstalmentid { get; set; }
        public bool Iscalltransfer { get; set; }
        public bool? Org { get; set; }
        public Guid? SellerUserid { get; set; }
        public DateTime? SellDate { get; set; }
        public string? Resno { get; set; }
        public DateTime? Sellingdate { get; set; }
        public TimeSpan? Sellingtime { get; set; }
        public string? DirectBranding { get; set; }
        public int? Entid { get; set; }
        public Guid? InvoiceAddressid { get; set; }
        public byte InvoiceType { get; set; }
        public string? InvoiceTaxno { get; set; }
        public string? InvoiceTaxplacename { get; set; }
        public string? InvoiceEmail { get; set; }
        public string? InvoiceTitle { get; set; }
        public string? InvoiceFirstname { get; set; }
        public string? InvoiceLastname { get; set; }
        public bool PayAtPlace { get; set; }
        public Guid? Campaignid { get; set; }
        public Guid? Agencyid { get; set; }
        public short InvoiceKind { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public bool? CancelationWarranty { get; set; }
        public bool? AllowSingleMen { get; set; }
        public string? OfferText { get; set; }
        public string? OfferRules { get; set; }
        public string? OfferDescription { get; set; }
        public string? Password { get; set; }
        public string? Langcode { get; set; }
        public string? ConversationId { get; set; }
        public string? ConversationCustomerid { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Agency? Agency { get; set; }
        public virtual Campaigns? Campaign { get; set; }
        public virtual Corp Corp { get; set; } = null!;
        public virtual LocationAddress? InvoiceAddress { get; set; }
        public virtual Stdlanguages? LangcodeNavigation { get; set; }
        public virtual Person? Person { get; set; }
        public virtual Users? SellerUser { get; set; }
        public virtual RequestStatus? StatusNavigation { get; set; }
        public virtual ICollection<BasketData> BasketData { get; set; }
        public virtual ICollection<CallJobs> CallJobs { get; set; }
        public virtual ICollection<Payments> Payments { get; set; }
        public virtual ICollection<RequestDetail> RequestDetail { get; set; }
        public virtual ICollection<RequestNotes> RequestNotes { get; set; }
        public virtual ICollection<SmtpMails> SmtpMails { get; set; }
        public virtual ICollection<VirtualPosDepPayments> VirtualPosDepPayments { get; set; }
        public virtual ICollection<VirtualPosPayments> VirtualPosPayments { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
