using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("REQUEST")]
    [Index(nameof(Corpid), Name = "IDX_MIS_DASHBOARD_REPORT2")]
    [Index(nameof(Adddate), Name = "IX_REQUEST")]
    [Index(nameof(RakamId), Name = "IX_REQUEST_1")]
    [Index(nameof(Adddate), nameof(Corpid), Name = "IX_REQUEST_2")]
    [Index(nameof(Creationdate), Name = "IX_REQUEST_3")]
    [Index(nameof(Editdate), Name = "IX_REQUEST_4")]
    [Index(nameof(Editdate), Name = "IX_REQUEST_5")]
    [Index(nameof(Editdate), nameof(Adddate), Name = "IX_REQUEST_6")]
    [Index(nameof(Resourceid), Name = "IX_REQUEST_7")]
    [Index(nameof(Corpid), nameof(ProjectGroupid), Name = "IX_REQUEST_CORPID_PGID")]
    public partial class Request : EntityBase 
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
            Person = new Person();
        }

        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("PERSONID")]
        
        public Guid? Personid { get; set; }


        [Column("CORPID")]
        [RequiredIf]
        public Guid Corpid { get; set; }


        [Column("RESOURCEID")]
        [RequiredIf]
        public Guid Resourceid { get; set; }


        [Column("PROJECT_DETAILID")]
        
        public Guid? ProjectDetailid { get; set; }


        [Column("REQ_URL")]
        [StringLength(500)]
        
        public string? ReqUrl { get; set; }


        [Column("CAMPAIGNCODE")]
        [StringLength(100)]
        
        public string? Campaigncode { get; set; }


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


        [Column("CREATIONDATE", TypeName = "date")]
        
        public DateTime? Creationdate { get; set; }


        [Column("CREATIONTIME")]
        
        public TimeSpan? Creationtime { get; set; }


        [Column("PROJECT_GROUPID")]
        [RequiredIf]
        public Guid ProjectGroupid { get; set; }


        [Column("STATUS")]
        
        public Guid? Status { get; set; }


        [Column("SUBSTATUS")]
        
        public Guid? Substatus { get; set; }


        [Column("RAKAM_ID")]
        [StringLength(15)]
        
        public string? RakamId { get; set; }


        [Column("PERSON_CCARDID")]
        
        public int? PersonCcardid { get; set; }


        [Column("CURCODE")]
        [StringLength(5)]
        [Unicode(false)]
        
        public string? Curcode { get; set; }


        [Column("POSACCOUNTID")]
        
        public Guid? Posaccountid { get; set; }


        [Column("POSINSTALMENTID")]
        
        public Guid? Posinstalmentid { get; set; }


        [Column("ISCALLTRANSFER")]
        [RequiredIf]
        public bool Iscalltransfer { get; set; }


        [Column("ORG")]
        
        public bool? Org { get; set; }


        [Column("SELLER_USERID")]
        
        public Guid? SellerUserid { get; set; }

        
        [Column("SELL_DATE", TypeName = "datetime")]
        
        public DateTime? SellDate { get; private set; }


        [Column("RESNO")]
        [StringLength(200)]
        
        public string? Resno { get; set; }


        [Column("SELLINGDATE", TypeName = "date")]
        
        public DateTime? Sellingdate { get; set; }


        [Column("SELLINGTIME")]
        
        public TimeSpan? Sellingtime { get; set; }


        [Column("DIRECT_BRANDING")]
        [StringLength(15)]
        
        public string? DirectBranding { get; set; }


        [Column("ENTID")]
        
        public int? Entid { get; set; }


        [Column("INVOICE_ADDRESSID")]
        
        public Guid? InvoiceAddressid { get; set; }


        [Column("INVOICE_TYPE")]
        [RequiredIf]
        public byte InvoiceType { get; set; }


        [Column("INVOICE_TAXNO")]
        [StringLength(25)]
        
        public string? InvoiceTaxno { get; set; }


        [Column("INVOICE_TAXPLACENAME")]
        [StringLength(100)]
        
        public string? InvoiceTaxplacename { get; set; }


        [Column("INVOICE_EMAIL")]
        [StringLength(200)]
        
        public string? InvoiceEmail { get; set; }


        [Column("INVOICE_TITLE")]
        [StringLength(200)]
        
        public string? InvoiceTitle { get; set; }


        [Column("INVOICE_FIRSTNAME")]
        [StringLength(50)]
        
        public string? InvoiceFirstname { get; set; }


        [Column("INVOICE_LASTNAME")]
        [StringLength(50)]
        
        public string? InvoiceLastname { get; set; }


        [Column("PAY_AT_PLACE")]
        [RequiredIf]
        public bool PayAtPlace { get; set; }


        [Column("CAMPAIGNID")]
        
        public Guid? Campaignid { get; set; }


        [Column("AGENCYID")]
        
        public Guid? Agencyid { get; set; }


        [Column("INVOICE_KIND")]
        [RequiredIf]
        public short InvoiceKind { get; set; }


        [Column("INVOICE_DATE", TypeName = "datetime")]
        
        public DateTime? InvoiceDate { get; set; }


        [Column("CANCELATION_WARRANTY")]
        
        public bool? CancelationWarranty { get; set; }


        [Column("ALLOW_SINGLE_MEN")]
        
        public bool? AllowSingleMen { get; set; }


        [Column("OFFER_TEXT")]
        
        public string? OfferText { get; set; }


        [Column("OFFER_RULES")]
        
        public string? OfferRules { get; set; }


        [Column("OFFER_DESCRIPTION")]
        
        public string? OfferDescription { get; set; }


        [Column("PASSWORD")]
        [StringLength(10)]
        
        public string? Password { get; set; }


        [Column("LANGCODE")]
        [StringLength(6)]
        [Unicode(false)]
        
        public string? Langcode { get; set; }


        [Column("CONVERSATION_ID")]
        [StringLength(50)]
        
        public string? ConversationId { get; set; }


        [Column("CONVERSATION_CUSTOMERID")]
        [StringLength(50)]
        
        public string? ConversationCustomerid { get; set; }



        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.RequestAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Agencyid))]
        [InverseProperty("Request")]
        public virtual Agency? Agency { get; set; }
        [ForeignKey(nameof(Campaignid))]
        [InverseProperty(nameof(Campaigns.Request))]
        public virtual Campaigns? Campaign { get; set; }
        [ForeignKey(nameof(Corpid))]
        [InverseProperty("Request")]
        public virtual Corp Corp { get; set; } = null!;
        [ForeignKey(nameof(InvoiceAddressid))]
        [InverseProperty(nameof(LocationAddress.Request))]
        public virtual LocationAddress? InvoiceAddress { get; set; }
        [ForeignKey(nameof(Langcode))]
        [InverseProperty(nameof(Stdlanguages.Request))]
        public virtual Stdlanguages? LangcodeNavigation { get; set; }
        [ForeignKey(nameof(Personid))]
        [InverseProperty("Request")]
        public virtual Person? Person { get; set; }
        [ForeignKey(nameof(SellerUserid))]
        [InverseProperty(nameof(Users.RequestSellerUser))]
        public virtual Users? SellerUser { get; set; }
        [ForeignKey(nameof(Status))]
        [InverseProperty(nameof(RequestStatus.Request))]
        public virtual RequestStatus? StatusNavigation { get; set; }
        [InverseProperty("Request")]
        public virtual ICollection<BasketData> BasketData { get; set; }
        [InverseProperty("Request")]
        public virtual ICollection<CallJobs> CallJobs { get; set; }
        [InverseProperty("Request")]
        public virtual ICollection<Payments> Payments { get; set; }
        [InverseProperty("Request")]
        public virtual ICollection<RequestDetail> RequestDetail { get; set; }
        [InverseProperty("Request")]
        public virtual ICollection<RequestNotes> RequestNotes { get; set; }
        [InverseProperty("Request")]
        public virtual ICollection<SmtpMails> SmtpMails { get; set; }
        [InverseProperty("Request")]
        public virtual ICollection<VirtualPosDepPayments> VirtualPosDepPayments { get; set; }
        [InverseProperty("Request")]
        public virtual ICollection<VirtualPosPayments> VirtualPosPayments { get; set; }

            }
}
