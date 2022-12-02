using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("CORP")]
    [Index(nameof(Intid), Name = "IX_CORP")]
    public partial class Corp : EntityBase // My Handlebars Helper
    {
        public Corp()
        {
            Agency = new HashSet<Agency>();
            AgencyGroup = new HashSet<AgencyGroup>();
            BonusDef = new HashSet<BonusDef>();
            CallJobs = new HashSet<CallJobs>();
            Campaigns = new HashSet<Campaigns>();
            CashierHandover = new HashSet<CashierHandover>();
            ContactCategory = new HashSet<ContactCategory>();
            ContactForm = new HashSet<ContactForm>();
            CrmCardgroups = new HashSet<CrmCardgroups>();
            Currate = new HashSet<Currate>();
            PaymentEmails = new HashSet<PaymentEmails>();
            Payments = new HashSet<Payments>();
            Person = new HashSet<Person>();
            PersonBonusTypes = new HashSet<PersonBonusTypes>();
            PersonGroup = new HashSet<PersonGroup>();
            Portal = new HashSet<Portal>();
            ProjectGroup = new HashSet<ProjectGroup>();
            PromotionCodes = new HashSet<PromotionCodes>();
            PropertyProviders = new HashSet<PropertyProviders>();
            Request = new HashSet<Request>();
            ReservationEmails = new HashSet<ReservationEmails>();
            ResourceDetail = new HashSet<ResourceDetail>();
            Resources = new HashSet<Resources>();
            Roles = new HashSet<Roles>();
            SmsSettings = new HashSet<SmsSettings>();
            SmtpSettings = new HashSet<SmtpSettings>();
            StdParams = new HashSet<StdParams>();
            Stdhotel = new HashSet<Stdhotel>();
            StdhotelPricecondition = new HashSet<StdhotelPricecondition>();
            StdhotelRatecode = new HashSet<StdhotelRatecode>();
            StdhotelRoomtypesAvailability = new HashSet<StdhotelRoomtypesAvailability>();
            StdhotelStopsale = new HashSet<StdhotelStopsale>();
            Stdmarkets = new HashSet<Stdmarkets>();
            Stdstore = new HashSet<Stdstore>();
            Survey = new HashSet<Survey>();
            Ticket = new HashSet<Ticket>();
            TicketGifts = new HashSet<TicketGifts>();
            TicketMarket = new HashSet<TicketMarket>();
            Tour = new HashSet<Tour>();
            TransferLocations = new HashSet<TransferLocations>();
            TransferPrices = new HashSet<TransferPrices>();
            TransferProviders = new HashSet<TransferProviders>();
            Turnike = new HashSet<Turnike>();
            Users = new HashSet<Users>();
            Vehicletypes = new HashSet<Vehicletypes>();
            VirtualPos = new HashSet<VirtualPos>();
            VirtualPosAccounts = new HashSet<VirtualPosAccounts>();
            VirtualPosDefaults = new HashSet<VirtualPosDefaults>();
            VirtualPosPaymentMessageTemps = new HashSet<VirtualPosPaymentMessageTemps>();
            VirtualPosPaymentRequests = new HashSet<VirtualPosPaymentRequests>();
            VirtualPosPaymentTemps = new HashSet<VirtualPosPaymentTemps>();
            VirtualPosPayments = new HashSet<VirtualPosPayments>();
        }

        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("INTID")]
        public int Intid { get; set; }
        [Column("NAME")]
        [StringLength(200)]
        public string? Name { get; set; }
        [Column("ADDRESSID")]
        public Guid? Addressid { get; set; }
        [Column("TEL1")]
        public long? Tel1 { get; set; }
        [Column("TEL2")]
        public long? Tel2 { get; set; }
        [Column("EMAIL")]
        [StringLength(200)]
        public string? Email { get; set; }
        [Column("FAX")]
        public int? Fax { get; set; }
        [Column("ISDELETED")]
        public bool Isdeleted { get; set; }
        [Column("ISDISABLED")]
        public bool Isdisabled { get; set; }
        [Column("ADDUSER")]
        public Guid? Adduser { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("EDITUSER")]
        public Guid? Edituser { get; set; }
        [Column("EDITDATE", TypeName = "datetime")]
        public DateTime? Editdate { get; set; }
        [Column("CONTACT")]
        [StringLength(150)]
        public string? Contact { get; set; }
        [Column("TAXAUTH")]
        [StringLength(100)]
        public string? Taxauth { get; set; }
        [Column("TAXNO")]
        [StringLength(30)]
        public string? Taxno { get; set; }
        [Column("GA_CUSTOMERID")]
        [StringLength(15)]
        public string? GaCustomerid { get; set; }
        [Column("AUTO_RESMAIL_CLIENT")]
        public Guid? AutoResmailClient { get; set; }
        [Column("AUTO_RESMAIL_HOST")]
        public Guid? AutoResmailHost { get; set; }
        [Column("AUTO_PASSWORD_FORGET")]
        public Guid? AutoPasswordForget { get; set; }
        [Column("SWITCHBOARDID")]
        public Guid? Switchboardid { get; set; }

        [ForeignKey(nameof(Addressid))]
        [InverseProperty(nameof(LocationAddress.Corp))]
        public virtual LocationAddress? Address { get; set; }
        [ForeignKey(nameof(Adduser))]
        [InverseProperty("CorpAdduserNavigation")]
        public virtual Users? AdduserNavigation { get; set; }
        [ForeignKey(nameof(AutoPasswordForget))]
        [InverseProperty(nameof(Reports.CorpAutoPasswordForgetNavigation))]
        public virtual Reports? AutoPasswordForgetNavigation { get; set; }
        [ForeignKey(nameof(AutoResmailClient))]
        [InverseProperty(nameof(Reports.CorpAutoResmailClientNavigation))]
        public virtual Reports? AutoResmailClientNavigation { get; set; }
        [ForeignKey(nameof(AutoResmailHost))]
        [InverseProperty(nameof(Reports.CorpAutoResmailHostNavigation))]
        public virtual Reports? AutoResmailHostNavigation { get; set; }
        [ForeignKey(nameof(Edituser))]
        [InverseProperty("CorpEdituserNavigation")]
        public virtual Users? EdituserNavigation { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<Agency> Agency { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<AgencyGroup> AgencyGroup { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<BonusDef> BonusDef { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<CallJobs> CallJobs { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<Campaigns> Campaigns { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<CashierHandover> CashierHandover { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<ContactCategory> ContactCategory { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<ContactForm> ContactForm { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<CrmCardgroups> CrmCardgroups { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<Currate> Currate { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<PaymentEmails> PaymentEmails { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<Payments> Payments { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<Person> Person { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<PersonBonusTypes> PersonBonusTypes { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<PersonGroup> PersonGroup { get; set; }
        [InverseProperty("Corporation")]
        public virtual ICollection<Portal> Portal { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<ProjectGroup> ProjectGroup { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<PromotionCodes> PromotionCodes { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<PropertyProviders> PropertyProviders { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<Request> Request { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<ReservationEmails> ReservationEmails { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<ResourceDetail> ResourceDetail { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<Resources> Resources { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<Roles> Roles { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<SmsSettings> SmsSettings { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<SmtpSettings> SmtpSettings { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<StdParams> StdParams { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<Stdhotel> Stdhotel { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<StdhotelPricecondition> StdhotelPricecondition { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<StdhotelRatecode> StdhotelRatecode { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<StdhotelRoomtypesAvailability> StdhotelRoomtypesAvailability { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<StdhotelStopsale> StdhotelStopsale { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<Stdmarkets> Stdmarkets { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<Stdstore> Stdstore { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<Survey> Survey { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<Ticket> Ticket { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<TicketGifts> TicketGifts { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<TicketMarket> TicketMarket { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<Tour> Tour { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<TransferLocations> TransferLocations { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<TransferPrices> TransferPrices { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<TransferProviders> TransferProviders { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<Turnike> Turnike { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<Users> Users { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<Vehicletypes> Vehicletypes { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<VirtualPos> VirtualPos { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<VirtualPosAccounts> VirtualPosAccounts { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<VirtualPosDefaults> VirtualPosDefaults { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<VirtualPosPaymentMessageTemps> VirtualPosPaymentMessageTemps { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<VirtualPosPaymentRequests> VirtualPosPaymentRequests { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<VirtualPosPaymentTemps> VirtualPosPaymentTemps { get; set; }
        [InverseProperty("Corp")]
        public virtual ICollection<VirtualPosPayments> VirtualPosPayments { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
