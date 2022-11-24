using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
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

        public Guid Id { get; set; }
        public int Intid { get; set; }
        public string? Name { get; set; }
        public Guid? Addressid { get; set; }
        public long? Tel1 { get; set; }
        public long? Tel2 { get; set; }
        public string? Email { get; set; }
        public int? Fax { get; set; }
        public bool Isdeleted { get; set; }
        public bool Isdisabled { get; set; }
        public Guid? Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public string? Contact { get; set; }
        public string? Taxauth { get; set; }
        public string? Taxno { get; set; }
        public string? GaCustomerid { get; set; }
        public Guid? AutoResmailClient { get; set; }
        public Guid? AutoResmailHost { get; set; }
        public Guid? AutoPasswordForget { get; set; }
        public Guid? Switchboardid { get; set; }

        public virtual LocationAddress? Address { get; set; }
        public virtual Users? AdduserNavigation { get; set; }
        public virtual Reports? AutoPasswordForgetNavigation { get; set; }
        public virtual Reports? AutoResmailClientNavigation { get; set; }
        public virtual Reports? AutoResmailHostNavigation { get; set; }
        public virtual Users? EdituserNavigation { get; set; }
        public virtual ICollection<Agency> Agency { get; set; }
        public virtual ICollection<AgencyGroup> AgencyGroup { get; set; }
        public virtual ICollection<BonusDef> BonusDef { get; set; }
        public virtual ICollection<CallJobs> CallJobs { get; set; }
        public virtual ICollection<Campaigns> Campaigns { get; set; }
        public virtual ICollection<CashierHandover> CashierHandover { get; set; }
        public virtual ICollection<ContactCategory> ContactCategory { get; set; }
        public virtual ICollection<ContactForm> ContactForm { get; set; }
        public virtual ICollection<CrmCardgroups> CrmCardgroups { get; set; }
        public virtual ICollection<Currate> Currate { get; set; }
        public virtual ICollection<PaymentEmails> PaymentEmails { get; set; }
        public virtual ICollection<Payments> Payments { get; set; }
        public virtual ICollection<Person> Person { get; set; }
        public virtual ICollection<PersonBonusTypes> PersonBonusTypes { get; set; }
        public virtual ICollection<PersonGroup> PersonGroup { get; set; }
        public virtual ICollection<Portal> Portal { get; set; }
        public virtual ICollection<ProjectGroup> ProjectGroup { get; set; }
        public virtual ICollection<PromotionCodes> PromotionCodes { get; set; }
        public virtual ICollection<PropertyProviders> PropertyProviders { get; set; }
        public virtual ICollection<Request> Request { get; set; }
        public virtual ICollection<ReservationEmails> ReservationEmails { get; set; }
        public virtual ICollection<ResourceDetail> ResourceDetail { get; set; }
        public virtual ICollection<Resources> Resources { get; set; }
        public virtual ICollection<Roles> Roles { get; set; }
        public virtual ICollection<SmsSettings> SmsSettings { get; set; }
        public virtual ICollection<SmtpSettings> SmtpSettings { get; set; }
        public virtual ICollection<StdParams> StdParams { get; set; }
        public virtual ICollection<Stdhotel> Stdhotel { get; set; }
        public virtual ICollection<StdhotelPricecondition> StdhotelPricecondition { get; set; }
        public virtual ICollection<StdhotelRatecode> StdhotelRatecode { get; set; }
        public virtual ICollection<StdhotelRoomtypesAvailability> StdhotelRoomtypesAvailability { get; set; }
        public virtual ICollection<StdhotelStopsale> StdhotelStopsale { get; set; }
        public virtual ICollection<Stdmarkets> Stdmarkets { get; set; }
        public virtual ICollection<Stdstore> Stdstore { get; set; }
        public virtual ICollection<Survey> Survey { get; set; }
        public virtual ICollection<Ticket> Ticket { get; set; }
        public virtual ICollection<TicketGifts> TicketGifts { get; set; }
        public virtual ICollection<TicketMarket> TicketMarket { get; set; }
        public virtual ICollection<Tour> Tour { get; set; }
        public virtual ICollection<TransferLocations> TransferLocations { get; set; }
        public virtual ICollection<TransferPrices> TransferPrices { get; set; }
        public virtual ICollection<TransferProviders> TransferProviders { get; set; }
        public virtual ICollection<Turnike> Turnike { get; set; }
        public virtual ICollection<Users> Users { get; set; }
        public virtual ICollection<Vehicletypes> Vehicletypes { get; set; }
        public virtual ICollection<VirtualPos> VirtualPos { get; set; }
        public virtual ICollection<VirtualPosAccounts> VirtualPosAccounts { get; set; }
        public virtual ICollection<VirtualPosDefaults> VirtualPosDefaults { get; set; }
        public virtual ICollection<VirtualPosPaymentMessageTemps> VirtualPosPaymentMessageTemps { get; set; }
        public virtual ICollection<VirtualPosPaymentRequests> VirtualPosPaymentRequests { get; set; }
        public virtual ICollection<VirtualPosPaymentTemps> VirtualPosPaymentTemps { get; set; }
        public virtual ICollection<VirtualPosPayments> VirtualPosPayments { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
