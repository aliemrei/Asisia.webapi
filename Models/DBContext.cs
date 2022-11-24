using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata; // Comment
using Asisia.webapi.Models.Db;

namespace Asisia.webapi.Models
{ // Comment
    public partial class DBContext : DbContext
    {
        // My Handlebars Helper
        public virtual DbSet<Agency> Agency { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<AgencyGroup> AgencyGroup { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<AuditLogs> AuditLogs { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<BasketData> BasketData { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<BonusDef> BonusDef { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<BonusDefItems> BonusDefItems { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<BonusDefPrices> BonusDefPrices { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<BonusDefUsers> BonusDefUsers { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<Calendar> Calendar { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<CallJobs> CallJobs { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<CallList> CallList { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<Campaigns> Campaigns { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<CashierHandover> CashierHandover { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<CashierHandoverEntity> CashierHandoverEntity { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<City> City { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<ContactCategory> ContactCategory { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<ContactForm> ContactForm { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<Corp> Corp { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<Country> Country { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<CrmCardgroups> CrmCardgroups { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<CrmCardtypes> CrmCardtypes { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<Curcode> Curcode { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<Currate> Currate { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<Dashboard> Dashboard { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<DashboardItem> DashboardItem { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<DashboardItemYdk> DashboardItemYdk { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<DashboardYdk> DashboardYdk { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<DataDictionary> DataDictionary { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<DbLog> DbLog { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<District> District { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<EntegrationSettings> EntegrationSettings { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<HotelReservationDetails> HotelReservationDetails { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<HotelReservations> HotelReservations { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<IntegrationErrors> IntegrationErrors { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<LocationAddress> LocationAddress { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<MailContents> MailContents { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<PaymentEmails> PaymentEmails { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<Payments> Payments { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<Person> Person { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<PersonAddress> PersonAddress { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<PersonBonus> PersonBonus { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<PersonBonusTypes> PersonBonusTypes { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<PersonCcards> PersonCcards { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<PersonGroup> PersonGroup { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<Portal> Portal { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<PortalAuthIpaddress> PortalAuthIpaddress { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<PortalCategories> PortalCategories { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<PortalCategoryImages> PortalCategoryImages { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<PortalCategoryItems> PortalCategoryItems { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<PortalCurrencies> PortalCurrencies { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<PortalDescription> PortalDescription { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<PortalDomains> PortalDomains { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<PortalEmails> PortalEmails { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<PortalLangdictionary> PortalLangdictionary { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<PortalLanguages> PortalLanguages { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<PortalSeo> PortalSeo { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<PortalSettings> PortalSettings { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<PortalUrlrewrite> PortalUrlrewrite { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<PortalUser> PortalUser { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<PortalUserSocialaccount> PortalUserSocialaccount { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<ProjectGroup> ProjectGroup { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<ProjectGroupdetail> ProjectGroupdetail { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<ProjectGroupdetailBankdep> ProjectGroupdetailBankdep { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<ProjectGroupdetailSeo> ProjectGroupdetailSeo { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<ProjectGroupdetailVpos> ProjectGroupdetailVpos { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<PromotionCodes> PromotionCodes { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<PromotionCodesMarket> PromotionCodesMarket { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<PromotionCodesRoomtype> PromotionCodesRoomtype { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<PropertyMapping> PropertyMapping { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<PropertyProviders> PropertyProviders { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<Reports> Reports { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<Request> Request { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<RequestClients> RequestClients { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<RequestDetail> RequestDetail { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<RequestDetailOrgdata> RequestDetailOrgdata { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<RequestNotes> RequestNotes { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<RequestPayments> RequestPayments { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<RequestStatus> RequestStatus { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<RequestYdk> RequestYdk { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<ReservationEmails> ReservationEmails { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<ReservationRules> ReservationRules { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<ReservationSettings> ReservationSettings { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<ReservationSettingsMarket> ReservationSettingsMarket { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<ResourceBudget> ResourceBudget { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<ResourceDetail> ResourceDetail { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<Resources> Resources { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<RoleAuth> RoleAuth { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<Roles> Roles { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<RolesCustomauth> RolesCustomauth { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<RolesDashboards> RolesDashboards { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<SalesReq> SalesReq { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<Sil> Sil { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<SmsMessage> SmsMessage { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<SmsSettings> SmsSettings { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<SmtpMails> SmtpMails { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<SmtpSettings> SmtpSettings { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<SntAgentStatus> SntAgentStatus { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<SntCallDetail> SntCallDetail { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<SntCallJobs> SntCallJobs { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<SntCallList> SntCallList { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<SntCallListOrg> SntCallListOrg { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<SntCallStatus> SntCallStatus { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<SntCallSummary> SntCallSummary { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<SntCallTotals> SntCallTotals { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<SntCallbackIgnores> SntCallbackIgnores { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<SntCalls> SntCalls { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<SntCdr> SntCdr { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<SntCdrReport> SntCdrReport { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<SntDbs> SntDbs { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<SntDiagram> SntDiagram { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<SntDiagramChildkeys> SntDiagramChildkeys { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<SntDiagramShapes> SntDiagramShapes { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<SntDialPlan> SntDialPlan { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<SntLanguageCountries> SntLanguageCountries { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<SntMissedcalls> SntMissedcalls { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<SntMissedcallsAll> SntMissedcallsAll { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<SntQueueAbandon> SntQueueAbandon { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<SntQueueLog> SntQueueLog { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<SntQueueMembers> SntQueueMembers { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<SntQueues> SntQueues { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<SntReport> SntReport { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<SntRtSippeers> SntRtSippeers { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<SntSippeers> SntSippeers { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<SntSwitchboard> SntSwitchboard { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<StdParams> StdParams { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<Stdboardtypes> Stdboardtypes { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<Stdhotel> Stdhotel { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<StdhotelAnnouncement> StdhotelAnnouncement { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<StdhotelBoardtypes> StdhotelBoardtypes { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<StdhotelDescriptions> StdhotelDescriptions { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<StdhotelExtras> StdhotelExtras { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<StdhotelFecilities> StdhotelFecilities { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<StdhotelImages> StdhotelImages { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<StdhotelMarket> StdhotelMarket { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<StdhotelMarketCountry> StdhotelMarketCountry { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<StdhotelPricecondition> StdhotelPricecondition { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<StdhotelPriceconditionCalendar> StdhotelPriceconditionCalendar { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<StdhotelPriceconditionOccupancy> StdhotelPriceconditionOccupancy { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<StdhotelRatecode> StdhotelRatecode { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<StdhotelRatecodeDetail> StdhotelRatecodeDetail { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<StdhotelRatecodeDetailAgencygroups> StdhotelRatecodeDetailAgencygroups { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<StdhotelRatecodeDetailOccupancy> StdhotelRatecodeDetailOccupancy { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<StdhotelRatecodeDiscount> StdhotelRatecodeDiscount { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<StdhotelRatecodeDiscountContract> StdhotelRatecodeDiscountContract { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<StdhotelRatecodeDiscountDiscount> StdhotelRatecodeDiscountDiscount { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<StdhotelRatecodeDiscountMarket> StdhotelRatecodeDiscountMarket { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<StdhotelRatecodeDiscountRatetype> StdhotelRatecodeDiscountRatetype { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<StdhotelRatecodeDiscountRoomtype> StdhotelRatecodeDiscountRoomtype { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<StdhotelRatecodeMarkup> StdhotelRatecodeMarkup { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<StdhotelRatecodeMarkupMarkets> StdhotelRatecodeMarkupMarkets { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<StdhotelRatecodeMarkupRoomtype> StdhotelRatecodeMarkupRoomtype { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<StdhotelRatetype> StdhotelRatetype { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<StdhotelRatetypesAvailability> StdhotelRatetypesAvailability { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<StdhotelRoomtypes> StdhotelRoomtypes { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<StdhotelRoomtypesAvailability> StdhotelRoomtypesAvailability { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<StdhotelSeasons> StdhotelSeasons { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<StdhotelStopsale> StdhotelStopsale { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<Stdhoteldiscount> Stdhoteldiscount { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<Stdlanguages> Stdlanguages { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<StdmarketCountries> StdmarketCountries { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<Stdmarkets> Stdmarkets { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<Stdroomtypes> Stdroomtypes { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<Stdstore> Stdstore { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<StdstoreItemGroupItems> StdstoreItemGroupItems { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<StdstoreItemGroups> StdstoreItemGroups { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<StdstoreItemImages> StdstoreItemImages { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<StdstoreItemIngredients> StdstoreItemIngredients { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<StdstoreItemPrices> StdstoreItemPrices { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<StdstoreItemPricesIngredients> StdstoreItemPricesIngredients { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<StdstoreItemSizes> StdstoreItemSizes { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<StdstoreItems> StdstoreItems { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<StdstoreItemsGroups> StdstoreItemsGroups { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<Stdvehicletypes> Stdvehicletypes { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<Survey> Survey { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<SurveyAnsweroptions> SurveyAnsweroptions { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<SurveyAnswers> SurveyAnswers { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<Surveys> Surveys { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<SwicthboardLog> SwicthboardLog { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<Ticket> Ticket { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<TicketActivations> TicketActivations { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<TicketGifts> TicketGifts { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<TicketHours> TicketHours { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<TicketMarket> TicketMarket { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<TicketPrices> TicketPrices { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<TileItemoption> TileItemoption { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<Tour> Tour { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<TourDiscounts> TourDiscounts { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<TourImages> TourImages { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<TourPrices> TourPrices { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<TourProgram> TourProgram { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<Tourdiscount> Tourdiscount { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<TransferLocations> TransferLocations { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<TransferPrices> TransferPrices { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<TransferProviders> TransferProviders { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<Turnike> Turnike { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<UserHistory> UserHistory { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<UserProjectDetails> UserProjectDetails { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<UserProjects> UserProjects { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<UserRoleRequestStatus> UserRoleRequestStatus { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<UserRoles> UserRoles { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<Users> Users { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<UsersCustomauth> UsersCustomauth { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<Vehicletypes> Vehicletypes { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<VirtualPos> VirtualPos { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<VirtualPosAccountInstalments> VirtualPosAccountInstalments { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<VirtualPosAccounts> VirtualPosAccounts { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<VirtualPosAccountsCurcodes> VirtualPosAccountsCurcodes { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<VirtualPosBinnumbers> VirtualPosBinnumbers { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<VirtualPosDefaults> VirtualPosDefaults { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<VirtualPosDepAccounts> VirtualPosDepAccounts { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<VirtualPosDepPayments> VirtualPosDepPayments { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<VirtualPosDepPaymentsCancel> VirtualPosDepPaymentsCancel { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<VirtualPosPaymentEmails> VirtualPosPaymentEmails { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<VirtualPosPaymentMessageTemps> VirtualPosPaymentMessageTemps { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<VirtualPosPaymentRequests> VirtualPosPaymentRequests { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<VirtualPosPaymentRequestsNotes> VirtualPosPaymentRequestsNotes { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<VirtualPosPaymentTemps> VirtualPosPaymentTemps { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<VirtualPosPaymentVposes> VirtualPosPaymentVposes { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<VirtualPosPayments> VirtualPosPayments { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<VirtualPosPaymentsCancel> VirtualPosPaymentsCancel { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<VirtualPosSwap> VirtualPosSwap { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<VirtualPosbinnames> VirtualPosbinnames { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<VwBasketInfo> VwBasketInfo { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<VwBasketPayments> VwBasketPayments { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<VwCallJobs> VwCallJobs { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<VwCalljobReasons> VwCalljobReasons { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<VwCampaigns> VwCampaigns { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<VwHotelMarketCountry> VwHotelMarketCountry { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<VwIpcountrycodes> VwIpcountrycodes { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<VwIplocations> VwIplocations { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<VwLocations> VwLocations { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<VwMobPaymentReport> VwMobPaymentReport { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<VwProducts> VwProducts { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<VwProjectGroup> VwProjectGroup { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<VwPromotionCodes> VwPromotionCodes { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<VwRequestPaymentCancels> VwRequestPaymentCancels { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<VwRequestPayments> VwRequestPayments { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<VwSales> VwSales { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<VwSalesAll> VwSalesAll { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<VwSalesReport> VwSalesReport { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<VwSalesReportAll> VwSalesReportAll { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<VwSalesReportWithResourcepath> VwSalesReportWithResourcepath { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<VwStdhotelDiscountTypes> VwStdhotelDiscountTypes { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<VwStdhotelRatecodeDiscountDiscount> VwStdhotelRatecodeDiscountDiscount { get; set; } = null!;

        public DBContext()  
        {
        }

        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=192.168.1.121;initial catalog=ASISIA_DEMO;user id=asisia;password=a.e.i1980;persist security info=True;MultipleActiveResultSets=True;App=asisia.webapi");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agency>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__AGENCY__3214EC26C02849A1")
                    .IsClustered(false);

                entity.ToTable("AGENCY");

                entity.HasIndex(e => new { e.Corpid, e.Fullname, e.Isdeleted }, "UQ__AGENCY__E0A4B5DC409567EB")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Authorizedid).HasColumnName("AUTHORIZEDID");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.DefaultCurcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("DEFAULT_CURCODE")
                    .IsFixedLength();

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(250)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Groupid).HasColumnName("GROUPID");

                entity.Property(e => e.Intid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("INTID");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.PaymentRate)
                    .HasColumnName("PAYMENT_RATE")
                    .HasDefaultValueSql("((100))");

                entity.Property(e => e.Quota).HasColumnName("QUOTA");

                entity.Property(e => e.Tel1).HasColumnName("TEL1");

                entity.Property(e => e.Tel2).HasColumnName("TEL2");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.AgencyAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AGENCY__ADDUSER__414EAC47");

                entity.HasOne(d => d.Authorized)
                    .WithMany(p => p.Agency)
                    .HasForeignKey(d => d.Authorizedid)
                    .HasConstraintName("FK__AGENCY__AUTHORIZ__4242D080");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.Agency)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AGENCY__CORPID__4336F4B9");

                entity.HasOne(d => d.DefaultCurcodeNavigation)
                    .WithMany(p => p.Agency)
                    .HasForeignKey(d => d.DefaultCurcode)
                    .HasConstraintName("FK__AGENCY__DEFAULT___10422BEF");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.AgencyEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__AGENCY__EDITUSER__442B18F2");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Agency)
                    .HasForeignKey(d => d.Groupid)
                    .HasConstraintName("FK__AGENCY__GROUPID__689E4EE9");
            });

            modelBuilder.Entity<AgencyGroup>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__AGENCY_G__3214EC26B8FF14FD")
                    .IsClustered(false);

                entity.ToTable("AGENCY_GROUP");

                entity.HasIndex(e => new { e.Corpid, e.Groupname }, "UQ__AGENCY_G__13040B821987821B")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Groupname)
                    .HasMaxLength(200)
                    .HasColumnName("GROUPNAME");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.AgencyGroupAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AGENCY_GR__ADDUS__65C1E23E");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.AgencyGroup)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AGENCY_GR__CORPI__64CDBE05");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.AgencyGroupEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__AGENCY_GR__EDITU__67AA2AB0");
            });

            modelBuilder.Entity<AuditLogs>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AuditLogs");

                entity.Property(e => e.DatabaseName).HasMaxLength(200);

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.PrimaryKey).HasMaxLength(200);

                entity.Property(e => e.TableName).HasMaxLength(200);

                entity.Property(e => e.Type)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<BasketData>(entity =>
            {
                entity.ToTable("BASKET_DATA");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Data)
                    .HasColumnType("ntext")
                    .HasColumnName("DATA");

                entity.Property(e => e.Requestid).HasColumnName("REQUESTID");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.BasketData)
                    .HasForeignKey(d => d.Requestid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__BASKET_DA__REQUE__0F231F2D");
            });

            modelBuilder.Entity<BonusDef>(entity =>
            {
                entity.ToTable("BONUS_DEF");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.ApplyType).HasColumnName("APPLY_TYPE");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Curcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CURCODE")
                    .HasDefaultValueSql("('TRY')")
                    .IsFixedLength();

                entity.Property(e => e.Definition)
                    .HasMaxLength(100)
                    .HasColumnName("DEFINITION");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.FirstDate)
                    .HasColumnType("datetime")
                    .HasColumnName("FIRST_DATE");

                entity.Property(e => e.LastDate)
                    .HasColumnType("datetime")
                    .HasColumnName("LAST_DATE");

                entity.Property(e => e.ProjectGroupid).HasColumnName("PROJECT_GROUPID");

                entity.Property(e => e.Rate).HasColumnName("RATE");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.BonusDefAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .HasConstraintName("FK__BONUS_DEF__ADDUS__42D7CD5D");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.BonusDef)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BONUS_DEF__CORPI__0856260D");

                entity.HasOne(d => d.CurcodeNavigation)
                    .WithMany(p => p.BonusDef)
                    .HasForeignKey(d => d.Curcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BONUS_DEF_CURCODE");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.BonusDefEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__BONUS_DEF__EDITU__43CBF196");

                entity.HasOne(d => d.ProjectGroup)
                    .WithMany(p => p.BonusDef)
                    .HasForeignKey(d => d.ProjectGroupid)
                    .HasConstraintName("FK__BONUS_DEF__PROJE__30EE274C");
            });

            modelBuilder.Entity<BonusDefItems>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__BONUS_DE__3214EC265B6D78FC")
                    .IsClustered(false);

                entity.ToTable("BONUS_DEF_ITEMS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.BonusDefid).HasColumnName("BONUS_DEFID");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Productid).HasColumnName("PRODUCTID");

                entity.Property(e => e.Propertyid).HasColumnName("PROPERTYID");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.BonusDefItemsAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .HasConstraintName("FK__BONUS_DEF__ADDUS__45B43A08");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.BonusDefItemsEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__BONUS_DEF__EDITU__46A85E41");
            });

            modelBuilder.Entity<BonusDefPrices>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__BONUS_DE__3214EC26EFA5C371")
                    .IsClustered(false);

                entity.ToTable("BONUS_DEF_PRICES");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.BonusDefItemsid).HasColumnName("BONUS_DEF_ITEMSID");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.FirstAmount).HasColumnName("FIRST_AMOUNT");

                entity.Property(e => e.LastAmount).HasColumnName("LAST_AMOUNT");

                entity.Property(e => e.Rate).HasColumnName("RATE");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.BonusDefPricesAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BONUS_DEF__ADDUS__3FFB60B2");

                entity.HasOne(d => d.BonusDefItems)
                    .WithMany(p => p.BonusDefPrices)
                    .HasForeignKey(d => d.BonusDefItemsid)
                    .HasConstraintName("FK__BONUS_DEF__BONUS__3E131840");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.BonusDefPricesEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__BONUS_DEF__EDITU__40EF84EB");
            });

            modelBuilder.Entity<BonusDefUsers>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__BONUS_DE__3214EC26AC720DE4")
                    .IsClustered(false);

                entity.ToTable("BONUS_DEF_USERS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BonusDefid).HasColumnName("BONUS_DEFID");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BonusDefUsers)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("FK__BONUS_DEF__USERI__2BF46805");
            });

            modelBuilder.Entity<Calendar>(entity =>
            {
                entity.HasKey(e => e.Date)
                    .HasName("PK__CALENDAR__1F7C70C4BA479CA1");

                entity.ToTable("CALENDAR");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("DATE");

                entity.Property(e => e.Dayofweek).HasColumnName("DAYOFWEEK");
            });

            modelBuilder.Entity<CallJobs>(entity =>
            {
                entity.ToTable("CALL_JOBS");

                entity.HasIndex(e => e.Adddate, "IX_CALL_JOBS");

                entity.HasIndex(e => new { e.Isdeleted, e.Isdisabled }, "IX_CALL_JOBS_1");

                entity.HasIndex(e => new { e.Reason, e.Result }, "IX_CALL_JOBS_2");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Calldate)
                    .HasColumnType("datetime")
                    .HasColumnName("CALLDATE");

                entity.Property(e => e.Callnumber).HasColumnName("CALLNUMBER");

                entity.Property(e => e.Campaigncode)
                    .HasMaxLength(100)
                    .HasColumnName("CAMPAIGNCODE")
                    .IsFixedLength();

                entity.Property(e => e.Cancelation).HasColumnName("CANCELATION");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Description).HasColumnName("DESCRIPTION");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.EntId)
                    .HasMaxLength(25)
                    .HasColumnName("ENT_ID");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(70)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(200)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.Kind)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("KIND")
                    .HasDefaultValueSql("('J')")
                    .IsFixedLength();

                entity.Property(e => e.Lastname)
                    .HasMaxLength(70)
                    .HasColumnName("LASTNAME");

                entity.Property(e => e.OutputExten)
                    .HasMaxLength(150)
                    .HasColumnName("OUTPUT_EXTEN");

                entity.Property(e => e.Personid).HasColumnName("PERSONID");

                entity.Property(e => e.Priority)
                    .HasColumnName("PRIORITY")
                    .HasDefaultValueSql("((5))");

                entity.Property(e => e.ProjectDetailid).HasColumnName("PROJECT_DETAILID");

                entity.Property(e => e.ProjectGroupid).HasColumnName("PROJECT_GROUPID");

                entity.Property(e => e.Qaid).HasColumnName("QAID");

                entity.Property(e => e.Reason).HasColumnName("REASON");

                entity.Property(e => e.Requestid).HasColumnName("REQUESTID");

                entity.Property(e => e.Result).HasColumnName("RESULT");

                entity.Property(e => e.ResultText).HasColumnName("RESULT_TEXT");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.CallJobsAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CALL_JOBS__ADDUS__62E4AA3C");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.CallJobs)
                    .HasForeignKey(d => d.Corpid)
                    .HasConstraintName("FK__CALL_JOBS__CORPI__2AAB3E11");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.CallJobsEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__CALL_JOBS__EDITU__64CCF2AE");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.CallJobs)
                    .HasForeignKey(d => d.Personid)
                    .HasConstraintName("FK__CALL_JOBS__PERSO__60083D91");

                entity.HasOne(d => d.ProjectDetail)
                    .WithMany(p => p.CallJobs)
                    .HasForeignKey(d => d.ProjectDetailid)
                    .HasConstraintName("FK__CALL_JOBS__PROJE__116B5A52");

                entity.HasOne(d => d.ProjectGroup)
                    .WithMany(p => p.CallJobs)
                    .HasForeignKey(d => d.ProjectGroupid)
                    .HasConstraintName("FK__CALL_JOBS__PROJE__10773619");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.CallJobs)
                    .HasForeignKey(d => d.Requestid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__CALL_JOBS__REQUE__5F141958");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CallJobsUser)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("FK_CALL_JOBS_USERS");
            });

            modelBuilder.Entity<CallList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CALL_LIST");

                entity.Property(e => e.Callid)
                    .HasMaxLength(32)
                    .HasColumnName("CALLID");

                entity.Property(e => e.Calltime)
                    .HasColumnType("datetime")
                    .HasColumnName("CALLTIME");

                entity.Property(e => e.Dontcall).HasColumnName("DONTCALL");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Jobid).HasColumnName("JOBID");

                entity.Property(e => e.Kind)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("KIND")
                    .IsFixedLength();

                entity.Property(e => e.Maxtrycount).HasColumnName("MAXTRYCOUNT");

                entity.Property(e => e.MaxtrycountBusy).HasColumnName("MAXTRYCOUNT_BUSY");

                entity.Property(e => e.OutputExten)
                    .HasMaxLength(150)
                    .HasColumnName("OUTPUT_EXTEN");

                entity.Property(e => e.Phonenumber)
                    .HasMaxLength(50)
                    .HasColumnName("PHONENUMBER");

                entity.Property(e => e.Priority).HasColumnName("PRIORITY");

                entity.Property(e => e.Qaid).HasColumnName("QAID");

                entity.Property(e => e.Queuelogid).HasColumnName("QUEUELOGID");

                entity.Property(e => e.Sdate)
                    .HasColumnType("datetime")
                    .HasColumnName("SDATE");

                entity.Property(e => e.Statu).HasColumnName("STATU");

                entity.Property(e => e.Trycount).HasColumnName("TRYCOUNT");

                entity.Property(e => e.TrycountBusy).HasColumnName("TRYCOUNT_BUSY");
            });

            modelBuilder.Entity<Campaigns>(entity =>
            {
                entity.ToTable("CAMPAIGNS");

                entity.HasIndex(e => e.Code, "IX_CAMPAIGNS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.CallbackTrunk)
                    .HasMaxLength(150)
                    .HasColumnName("CALLBACK_TRUNK");

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .HasColumnName("CODE");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Enddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ENDDATE");

                entity.Property(e => e.Forallprojects)
                    .HasColumnName("FORALLPROJECTS")
                    .HasComputedColumnSql("(case when [PROJECT_DETAILID] IS NULL then (1) else (0) end)", false);

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.ProjectDetailid).HasColumnName("PROJECT_DETAILID");

                entity.Property(e => e.Projectid).HasColumnName("PROJECTID");

                entity.Property(e => e.RakamId)
                    .HasMaxLength(15)
                    .HasColumnName("RAKAM_ID");

                entity.Property(e => e.Resourceid).HasColumnName("RESOURCEID");

                entity.Property(e => e.Startdate)
                    .HasColumnType("datetime")
                    .HasColumnName("STARTDATE");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.CampaignsAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CAMPAIGNS__ADDUS__14270015");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.Campaigns)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CAMPAIGNS__CORPI__1E6F845E");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.CampaignsEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__CAMPAIGNS__EDITU__160F4887");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Campaigns)
                    .HasForeignKey(d => d.Projectid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CAMPAIGNS_PROJECT_GROUP");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.Campaigns)
                    .HasForeignKey(d => d.Resourceid)
                    .HasConstraintName("FK__CAMPAIGNS__RESOU__17F790F9");
            });

            modelBuilder.Entity<CashierHandover>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__CASHIER___3214EC263744268B")
                    .IsClustered(false);

                entity.ToTable("CASHIER_HANDOVER");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Isenddate).HasColumnName("ISENDDATE");

                entity.Property(e => e.Resourceid).HasColumnName("RESOURCEID");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.CashierHandoverAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CASHIER_H__ADDUS__51851410");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.CashierHandover)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CASHIER_H__CORPI__52793849");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.CashierHandoverEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__CASHIER_H__EDITU__536D5C82");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.CashierHandover)
                    .HasForeignKey(d => d.Resourceid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CASHIER_H__RESOU__546180BB");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CashierHandoverUser)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CASHIER_H__USERI__5555A4F4");
            });

            modelBuilder.Entity<CashierHandoverEntity>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__CASHIER___3214EC26829369B8")
                    .IsClustered(false);

                entity.ToTable("CASHIER_HANDOVER_ENTITY");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CashierHandoverid).HasColumnName("CASHIER_HANDOVERID");

                entity.Property(e => e.Curcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CURCODE")
                    .IsFixedLength();

                entity.Property(e => e.Debt).HasColumnName("DEBT");

                entity.Property(e => e.EntityType).HasColumnName("ENTITY_TYPE");

                entity.HasOne(d => d.CashierHandover)
                    .WithMany(p => p.CashierHandoverEntity)
                    .HasForeignKey(d => d.CashierHandoverid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CASHIER_H__CASHI__4297D63B");

                entity.HasOne(d => d.CurcodeNavigation)
                    .WithMany(p => p.CashierHandoverEntity)
                    .HasForeignKey(d => d.Curcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CASHIER_H__CURCO__438BFA74");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("CITY");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Countryid).HasColumnName("COUNTRYID");

                entity.Property(e => e.Name)
                    .HasMaxLength(70)
                    .HasColumnName("NAME");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.Countryid)
                    .HasConstraintName("FK__CITY__COUNTRYID__5832119F");
            });

            modelBuilder.Entity<ContactCategory>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__CONTACT___3214EC26D22EAE2D")
                    .IsClustered(false);

                entity.ToTable("CONTACT_CATEGORY");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Definition)
                    .HasMaxLength(150)
                    .HasColumnName("DEFINITION");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.ContactCategory)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CONTACT_C__CORPI__30F91444");
            });

            modelBuilder.Entity<ContactForm>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__CONTACT___3214EC26B90220D6")
                    .IsClustered(false);

                entity.ToTable("CONTACT_FORM");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Category).HasColumnName("CATEGORY");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Messagetext).HasColumnName("MESSAGETEXT");

                entity.Property(e => e.Personid).HasColumnName("PERSONID");

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .HasColumnName("TITLE");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.ContactFormAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CONTACT_F__ADDUS__389A360C");

                entity.HasOne(d => d.CategoryNavigation)
                    .WithMany(p => p.ContactForm)
                    .HasForeignKey(d => d.Category)
                    .HasConstraintName("FK__CONTACT_F__CATEG__35BDC961");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.ContactForm)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CONTACT_F__CORPI__36B1ED9A");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.ContactFormEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__CONTACT_F__EDITU__398E5A45");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.ContactForm)
                    .HasForeignKey(d => d.Personid)
                    .HasConstraintName("FK__CONTACT_F__PERSO__34C9A528");
            });

            modelBuilder.Entity<Corp>(entity =>
            {
                entity.ToTable("CORP");

                entity.HasIndex(e => e.Intid, "IX_CORP");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Addressid).HasColumnName("ADDRESSID");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.AutoPasswordForget).HasColumnName("AUTO_PASSWORD_FORGET");

                entity.Property(e => e.AutoResmailClient).HasColumnName("AUTO_RESMAIL_CLIENT");

                entity.Property(e => e.AutoResmailHost).HasColumnName("AUTO_RESMAIL_HOST");

                entity.Property(e => e.Contact)
                    .HasMaxLength(150)
                    .HasColumnName("CONTACT");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Fax).HasColumnName("FAX");

                entity.Property(e => e.GaCustomerid)
                    .HasMaxLength(15)
                    .HasColumnName("GA_CUSTOMERID");

                entity.Property(e => e.Intid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("INTID");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .HasColumnName("NAME");

                entity.Property(e => e.Switchboardid).HasColumnName("SWITCHBOARDID");

                entity.Property(e => e.Taxauth)
                    .HasMaxLength(100)
                    .HasColumnName("TAXAUTH");

                entity.Property(e => e.Taxno)
                    .HasMaxLength(30)
                    .HasColumnName("TAXNO");

                entity.Property(e => e.Tel1).HasColumnName("TEL1");

                entity.Property(e => e.Tel2).HasColumnName("TEL2");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Corp)
                    .HasForeignKey(d => d.Addressid)
                    .HasConstraintName("FK__CORP__ADDRESSID__5EBF139D");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.CorpAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .HasConstraintName("FK__CORP__ADDUSER__619B8048");

                entity.HasOne(d => d.AutoPasswordForgetNavigation)
                    .WithMany(p => p.CorpAutoPasswordForgetNavigation)
                    .HasForeignKey(d => d.AutoPasswordForget)
                    .HasConstraintName("FK__CORP__AUTO_PASSW__592635D8");

                entity.HasOne(d => d.AutoResmailClientNavigation)
                    .WithMany(p => p.CorpAutoResmailClientNavigation)
                    .HasForeignKey(d => d.AutoResmailClient)
                    .HasConstraintName("FK__CORP__AUTO_RESMA__5A1A5A11");

                entity.HasOne(d => d.AutoResmailHostNavigation)
                    .WithMany(p => p.CorpAutoResmailHostNavigation)
                    .HasForeignKey(d => d.AutoResmailHost)
                    .HasConstraintName("FK__CORP__AUTO_RESMA__5B0E7E4A");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.CorpEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__CORP__EDITUSER__6383C8BA");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("COUNTRY");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DialCode)
                    .HasMaxLength(15)
                    .HasColumnName("DIAL_CODE");

                entity.Property(e => e.Isocode2)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ISOCODE2")
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(70)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<CrmCardgroups>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__CRM_CARD__3214EC264ECA644E")
                    .IsClustered(false);

                entity.ToTable("CRM_CARDGROUPS");

                entity.HasIndex(e => new { e.Corpid, e.Definition }, "UQ__CRM_CARD__D0FAF6086F855A68")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Definition)
                    .HasMaxLength(100)
                    .HasColumnName("DEFINITION");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.CrmCardgroupsAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CRM_CARDG__ADDUS__1B73E779");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.CrmCardgroups)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CRM_CARDG__CORPI__18977ACE");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.CrmCardgroupsEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__CRM_CARDG__EDITU__1D5C2FEB");
            });

            modelBuilder.Entity<CrmCardtypes>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__CRM_CARD__3214EC26CBABAEF5")
                    .IsClustered(false);

                entity.ToTable("CRM_CARDTYPES");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Backcolor1)
                    .HasMaxLength(20)
                    .HasColumnName("BACKCOLOR1");

                entity.Property(e => e.Backcolor2)
                    .HasMaxLength(20)
                    .HasColumnName("BACKCOLOR2");

                entity.Property(e => e.Backgroundlogo)
                    .HasMaxLength(255)
                    .HasColumnName("BACKGROUNDLOGO");

                entity.Property(e => e.Cardbrandiconurl)
                    .HasMaxLength(250)
                    .HasColumnName("CARDBRANDICONURL");

                entity.Property(e => e.Cardbrandlogo).HasColumnName("CARDBRANDLOGO");

                entity.Property(e => e.Cardgroupid).HasColumnName("CARDGROUPID");

                entity.Property(e => e.CardnumberMargin)
                    .HasMaxLength(50)
                    .HasColumnName("CARDNUMBER_MARGIN")
                    .HasDefaultValueSql("(N'40px 25px 10px')");

                entity.Property(e => e.CarduseRules).HasColumnName("CARDUSE_RULES");

                entity.Property(e => e.Colorgroup1)
                    .HasMaxLength(20)
                    .HasColumnName("COLORGROUP1");

                entity.Property(e => e.Colorgroup2)
                    .HasMaxLength(20)
                    .HasColumnName("COLORGROUP2");

                entity.Property(e => e.Colorgroup3)
                    .HasMaxLength(20)
                    .HasColumnName("COLORGROUP3");

                entity.Property(e => e.Colorgroup4)
                    .HasMaxLength(20)
                    .HasColumnName("COLORGROUP4");

                entity.Property(e => e.Definition)
                    .HasMaxLength(100)
                    .HasColumnName("DEFINITION");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.ShowStripbottom)
                    .IsRequired()
                    .HasColumnName("SHOW_STRIPBOTTOM")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowStriptop)
                    .IsRequired()
                    .HasColumnName("SHOW_STRIPTOP")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowcardBrand)
                    .IsRequired()
                    .HasColumnName("SHOWCARD_BRAND")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Showcardholdername)
                    .IsRequired()
                    .HasColumnName("SHOWCARDHOLDERNAME")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowchipIcon)
                    .IsRequired()
                    .HasColumnName("SHOWCHIP_ICON")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Showexpire)
                    .IsRequired()
                    .HasColumnName("SHOWEXPIRE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Shownumbers)
                    .IsRequired()
                    .HasColumnName("SHOWNUMBERS")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowwifiIcon)
                    .IsRequired()
                    .HasColumnName("SHOWWIFI_ICON")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .HasColumnName("TITLE");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.CrmCardtypesAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CRM_CARDT__ADDUS__26E59A25");

                entity.HasOne(d => d.Cardgroup)
                    .WithMany(p => p.CrmCardtypes)
                    .HasForeignKey(d => d.Cardgroupid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CRM_CARDT__CARDG__212CC0CF");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.CrmCardtypesEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__CRM_CARDT__EDITU__28CDE297");
            });

            modelBuilder.Entity<Curcode>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("CURCODE");

                entity.Property(e => e.Code)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CODE")
                    .IsFixedLength();

                entity.Property(e => e.LogoEntid).HasColumnName("LOGO_ENTID");
            });

            modelBuilder.Entity<Currate>(entity =>
            {
                entity.ToTable("CURRATE");

                entity.HasIndex(e => new { e.Corpid, e.Curcode, e.Ratedate }, "IX_CURRATE");

                entity.HasIndex(e => e.Ratedate, "IX_CURRATE_1");

                entity.HasIndex(e => e.Ratedate, "IX_CURRATE_2");

                entity.HasIndex(e => new { e.Corpid, e.Curcode, e.Ratedate }, "IX_CURRATE_4");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Curcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CURCODE")
                    .IsFixedLength();

                entity.Property(e => e.Rate).HasColumnName("RATE");

                entity.Property(e => e.Ratedate)
                    .HasColumnType("datetime")
                    .HasColumnName("RATEDATE");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.Currate)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CURRATE__CORPID__42ACE4D4");
            });

            modelBuilder.Entity<Dashboard>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__DASHBOAR__3214EC27E2539AD9")
                    .IsClustered(false);

                entity.ToTable("DASHBOARD");

                entity.HasIndex(e => e.Sortorder, "IX_DASHBOARD")
                    .IsClustered();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Columnwidths)
                    .HasMaxLength(50)
                    .HasColumnName("COLUMNWIDTHS")
                    .HasDefaultValueSql("(N'1, 0.5, 0.5')");

                entity.Property(e => e.Design).HasColumnName("DESIGN");

                entity.Property(e => e.Maxcolumn)
                    .HasColumnName("MAXCOLUMN")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.Sortorder).HasColumnName("SORTORDER");

                entity.Property(e => e.Stateid)
                    .HasMaxLength(50)
                    .HasColumnName("STATEID");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasColumnName("TITLE");
            });

            modelBuilder.Entity<DashboardItem>(entity =>
            {
                entity.ToTable("DASHBOARD_ITEM");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Columnindex).HasColumnName("COLUMNINDEX");

                entity.Property(e => e.Dashboardid).HasColumnName("DASHBOARDID");

                entity.Property(e => e.Design).HasColumnName("DESIGN");

                entity.Property(e => e.DetailSql).HasColumnName("DETAIL_SQL");

                entity.Property(e => e.Qsql).HasColumnName("QSQL");

                entity.Property(e => e.Sortorder).HasColumnName("SORTORDER");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasColumnName("TITLE");

                entity.Property(e => e.Widgetname)
                    .HasMaxLength(50)
                    .HasColumnName("WIDGETNAME")
                    .HasDefaultValueSql("(N'widget')");

                entity.HasOne(d => d.Dashboard)
                    .WithMany(p => p.DashboardItem)
                    .HasForeignKey(d => d.Dashboardid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DASHBOARD__DASHB__24485945");
            });

            modelBuilder.Entity<DashboardItemYdk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DASHBOARD_ITEM_YDK");

                entity.Property(e => e.Columnindex).HasColumnName("COLUMNINDEX");

                entity.Property(e => e.Dashboardid).HasColumnName("DASHBOARDID");

                entity.Property(e => e.Design).HasColumnName("DESIGN");

                entity.Property(e => e.DetailSql).HasColumnName("DETAIL_SQL");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Qsql).HasColumnName("QSQL");

                entity.Property(e => e.Sortorder).HasColumnName("SORTORDER");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasColumnName("TITLE");

                entity.Property(e => e.Widgetname)
                    .HasMaxLength(50)
                    .HasColumnName("WIDGETNAME");
            });

            modelBuilder.Entity<DashboardYdk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DASHBOARD_YDK");

                entity.Property(e => e.Columnwidths)
                    .HasMaxLength(50)
                    .HasColumnName("COLUMNWIDTHS");

                entity.Property(e => e.Design).HasColumnName("DESIGN");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Maxcolumn).HasColumnName("MAXCOLUMN");

                entity.Property(e => e.Sortorder).HasColumnName("SORTORDER");

                entity.Property(e => e.Stateid)
                    .HasMaxLength(50)
                    .HasColumnName("STATEID");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasColumnName("TITLE");
            });

            modelBuilder.Entity<DataDictionary>(entity =>
            {
                entity.ToTable("DATA_DICTIONARY");

                entity.HasIndex(e => new { e.Recid, e.Tablename, e.Fieldname, e.Langcode }, "UQ__DATA_DIC__54F85D1A5F1C9BBD")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Fieldname)
                    .HasMaxLength(150)
                    .HasColumnName("FIELDNAME");

                entity.Property(e => e.Langcode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("LANGCODE")
                    .IsFixedLength();

                entity.Property(e => e.Recid).HasColumnName("RECID");

                entity.Property(e => e.Tablename)
                    .HasMaxLength(100)
                    .HasColumnName("TABLENAME");

                entity.Property(e => e.Val).HasColumnName("VAL");
            });

            modelBuilder.Entity<DbLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DB_LOG");

                entity.Property(e => e.Groupid).HasColumnName("GROUPID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Logtext)
                    .HasColumnType("ntext")
                    .HasColumnName("LOGTEXT");

                entity.Property(e => e.Logtime)
                    .HasColumnType("datetime")
                    .HasColumnName("LOGTIME");

                entity.Property(e => e.Recid)
                    .HasMaxLength(45)
                    .HasColumnName("RECID");

                entity.Property(e => e.Tablename)
                    .HasMaxLength(150)
                    .HasColumnName("TABLENAME");

                entity.Property(e => e.Traceflag)
                    .HasMaxLength(25)
                    .HasColumnName("TRACEFLAG");

                entity.Property(e => e.Usercode)
                    .HasMaxLength(150)
                    .HasColumnName("USERCODE");
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.ToTable("DISTRICT");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Cityid).HasColumnName("CITYID");

                entity.Property(e => e.Name)
                    .HasMaxLength(70)
                    .HasColumnName("NAME");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.District)
                    .HasForeignKey(d => d.Cityid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DISTRICT__CITYID__60C757A0");
            });

            modelBuilder.Entity<EntegrationSettings>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ENTEGRATION_SETTINGS");

                entity.Property(e => e.Enttype)
                    .HasMaxLength(50)
                    .HasColumnName("ENTTYPE");

                entity.Property(e => e.FirstDate)
                    .HasColumnType("date")
                    .HasColumnName("FIRST_DATE");

                entity.Property(e => e.LastDate)
                    .HasColumnType("date")
                    .HasColumnName("LAST_DATE");
            });

            modelBuilder.Entity<HotelReservationDetails>(entity =>
            {
                entity.ToTable("HOTEL_RESERVATION_DETAILS");

                entity.HasIndex(e => e.Id, "IX_HOTEL_RESERVATION_DETAILS");

                entity.HasIndex(e => e.Resid, "IX_MISS_HOTELSEARCH_2");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adult).HasColumnName("ADULT");

                entity.Property(e => e.Avail)
                    .HasMaxLength(150)
                    .HasColumnName("AVAIL");

                entity.Property(e => e.Baby).HasColumnName("BABY");

                entity.Property(e => e.Chde).HasColumnName("CHDE");

                entity.Property(e => e.Chdy).HasColumnName("CHDY");

                entity.Property(e => e.Combid).HasColumnName("COMBID");

                entity.Property(e => e.Costprice)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("COSTPRICE");

                entity.Property(e => e.Daln1).HasColumnName("DALN1");

                entity.Property(e => e.Daln2).HasColumnName("DALN2");

                entity.Property(e => e.Daln3).HasColumnName("DALN3");

                entity.Property(e => e.Daln4).HasColumnName("DALN4");

                entity.Property(e => e.Daln5).HasColumnName("DALN5");

                entity.Property(e => e.Damt1).HasColumnName("DAMT1");

                entity.Property(e => e.Damt2).HasColumnName("DAMT2");

                entity.Property(e => e.Damt3).HasColumnName("DAMT3");

                entity.Property(e => e.Damt4).HasColumnName("DAMT4");

                entity.Property(e => e.Damt5).HasColumnName("DAMT5");

                entity.Property(e => e.Dat1).HasColumnName("DAT1");

                entity.Property(e => e.Dat2).HasColumnName("DAT2");

                entity.Property(e => e.Dat3).HasColumnName("DAT3");

                entity.Property(e => e.Dat4).HasColumnName("DAT4");

                entity.Property(e => e.Dat5).HasColumnName("DAT5");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("DATE");

                entity.Property(e => e.Dayofweek)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DAYOFWEEK")
                    .IsFixedLength();

                entity.Property(e => e.Dexp1)
                    .HasMaxLength(50)
                    .HasColumnName("DEXP1");

                entity.Property(e => e.Dexp2)
                    .HasMaxLength(50)
                    .HasColumnName("DEXP2");

                entity.Property(e => e.Dexp3)
                    .HasMaxLength(50)
                    .HasColumnName("DEXP3");

                entity.Property(e => e.Dexp4)
                    .HasMaxLength(50)
                    .HasColumnName("DEXP4");

                entity.Property(e => e.Dexp5)
                    .HasMaxLength(50)
                    .HasColumnName("DEXP5");

                entity.Property(e => e.Did1).HasColumnName("DID1");

                entity.Property(e => e.Did2).HasColumnName("DID2");

                entity.Property(e => e.Did3).HasColumnName("DID3");

                entity.Property(e => e.Did4).HasColumnName("DID4");

                entity.Property(e => e.Did5).HasColumnName("DID5");

                entity.Property(e => e.Dt1).HasColumnName("DT1");

                entity.Property(e => e.Dt2).HasColumnName("DT2");

                entity.Property(e => e.Dt3).HasColumnName("DT3");

                entity.Property(e => e.Dt4).HasColumnName("DT4");

                entity.Property(e => e.Dt5).HasColumnName("DT5");

                entity.Property(e => e.Finalcost)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("FINALCOST");

                entity.Property(e => e.Finalprice)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("FINALPRICE");

                entity.Property(e => e.Fixprice).HasColumnName("FIXPRICE");

                entity.Property(e => e.Guestprice)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("GUESTPRICE");

                entity.Property(e => e.Maxlos).HasColumnName("MAXLOS");

                entity.Property(e => e.Minlos).HasColumnName("MINLOS");

                entity.Property(e => e.Pricedebuginfo)
                    .HasMaxLength(100)
                    .HasColumnName("PRICEDEBUGINFO");

                entity.Property(e => e.Pricesort).HasColumnName("PRICESORT");

                entity.Property(e => e.Quota).HasColumnName("QUOTA");

                entity.Property(e => e.Ratecodedetailid).HasColumnName("RATECODEDETAILID");

                entity.Property(e => e.Ratecodeid).HasColumnName("RATECODEID");

                entity.Property(e => e.Remainingquota).HasColumnName("REMAININGQUOTA");

                entity.Property(e => e.Resid).HasColumnName("RESID");

                entity.Property(e => e.StopCheckin).HasColumnName("STOP_CHECKIN");

                entity.Property(e => e.StopCheckout).HasColumnName("STOP_CHECKOUT");

                entity.Property(e => e.StopSell).HasColumnName("STOP_SELL");

                entity.Property(e => e.Tempid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TEMPID");

                entity.HasOne(d => d.Comb)
                    .WithMany(p => p.HotelReservationDetails)
                    .HasForeignKey(d => d.Combid)
                    .HasConstraintName("FK_HOTEL_RESERVATION_DETAILS_STDHOTEL_PRICECONDITION");

                entity.HasOne(d => d.Ratecode)
                    .WithMany(p => p.HotelReservationDetails)
                    .HasForeignKey(d => d.Ratecodeid)
                    .HasConstraintName("FK__HOTEL_RES__RATEC__61BB7BD9");

                entity.HasOne(d => d.Res)
                    .WithMany(p => p.HotelReservationDetails)
                    .HasForeignKey(d => d.Resid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_HOTEL_RESERVATION_DETAILS_HOTEL_RESERVATIONS");
            });

            modelBuilder.Entity<HotelReservations>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__HOTEL_RE__3214EC260D15FE65")
                    .IsClustered(false);

                entity.ToTable("HOTEL_RESERVATIONS");

                entity.HasIndex(e => e.Resid, "UQ__HOTEL_RE__4D969333596EF86E")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.ContractDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CONTRACT_DATE");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Entid)
                    .HasMaxLength(40)
                    .HasColumnName("ENTID");

                entity.Property(e => e.IsconfirmedGuest).HasColumnName("ISCONFIRMED_GUEST");

                entity.Property(e => e.IsconfirmedHotel).HasColumnName("ISCONFIRMED_HOTEL");

                entity.Property(e => e.IsconfirmedOwner).HasColumnName("ISCONFIRMED_OWNER");

                entity.Property(e => e.LastupdateResdetail)
                    .HasColumnType("datetime")
                    .HasColumnName("LASTUPDATE_RESDETAIL");

                entity.Property(e => e.RequestDetailid).HasColumnName("REQUEST_DETAILID");

                entity.Property(e => e.Resid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RESID");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.HotelReservationsAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HOTEL_RES__ADDUS__6497E884");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.HotelReservationsEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__HOTEL_RES__EDITU__658C0CBD");

                entity.HasOne(d => d.RequestDetail)
                    .WithMany(p => p.HotelReservations)
                    .HasForeignKey(d => d.RequestDetailid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__HOTEL_RES__REQUE__625078B6");
            });

            modelBuilder.Entity<IntegrationErrors>(entity =>
            {
                entity.ToTable("INTEGRATION_ERRORS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Errortext)
                    .HasMaxLength(255)
                    .HasColumnName("ERRORTEXT");

                entity.Property(e => e.Insertid).HasColumnName("INSERTID");
            });

            modelBuilder.Entity<LocationAddress>(entity =>
            {
                entity.ToTable("LOCATION_ADDRESS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Cityid).HasColumnName("CITYID");

                entity.Property(e => e.Countryid).HasColumnName("COUNTRYID");

                entity.Property(e => e.Districtid).HasColumnName("DISTRICTID");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.InvoiceEmail)
                    .HasMaxLength(200)
                    .HasColumnName("INVOICE_EMAIL");

                entity.Property(e => e.InvoiceTaxno)
                    .HasMaxLength(25)
                    .HasColumnName("INVOICE_TAXNO");

                entity.Property(e => e.InvoiceTaxplacename)
                    .HasMaxLength(100)
                    .HasColumnName("INVOICE_TAXPLACENAME");

                entity.Property(e => e.InvoiceTitle)
                    .HasMaxLength(200)
                    .HasColumnName("INVOICE_TITLE");

                entity.Property(e => e.InvoiceType).HasColumnName("INVOICE_TYPE");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Latitude).HasColumnName("LATITUDE");

                entity.Property(e => e.Line1)
                    .HasMaxLength(100)
                    .HasColumnName("LINE1");

                entity.Property(e => e.Line2)
                    .HasMaxLength(100)
                    .HasColumnName("LINE2");

                entity.Property(e => e.Longitude).HasColumnName("LONGITUDE");

                entity.Property(e => e.Type).HasColumnName("TYPE");

                entity.Property(e => e.Zipcode)
                    .HasMaxLength(30)
                    .HasColumnName("ZIPCODE");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.LocationAddressAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LOCATION___ADDUS__59063A47");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.LocationAddress)
                    .HasForeignKey(d => d.Cityid)
                    .HasConstraintName("FK__LOCATION___CITYI__6774552F");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.LocationAddress)
                    .HasForeignKey(d => d.Countryid)
                    .HasConstraintName("FK__LOCATION___COUNT__68687968");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.LocationAddress)
                    .HasForeignKey(d => d.Districtid)
                    .HasConstraintName("FK__LOCATION___DISTR__695C9DA1");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.LocationAddressEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__LOCATION___EDITU__5AEE82B9");
            });

            modelBuilder.Entity<MailContents>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MAIL_CONTENTS");

                entity.Property(e => e.Content).HasColumnName("CONTENT");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Mailid).HasColumnName("MAILID");

                entity.Property(e => e.Mailuid).HasColumnName("MAILUID");
            });

            modelBuilder.Entity<PaymentEmails>(entity =>
            {
                entity.ToTable("PAYMENT_EMAILS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BccEmails)
                    .HasMaxLength(500)
                    .HasColumnName("BCC_EMAILS");

                entity.Property(e => e.CcEmails)
                    .HasMaxLength(500)
                    .HasColumnName("CC_EMAILS");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.FailText).HasColumnName("FAIL_TEXT");

                entity.Property(e => e.Hotelid).HasColumnName("HOTELID");

                entity.Property(e => e.ProjectDetailid).HasColumnName("PROJECT_DETAILID");

                entity.Property(e => e.Projectid).HasColumnName("PROJECTID");

                entity.Property(e => e.SuccessText).HasColumnName("SUCCESS_TEXT");

                entity.Property(e => e.ToEmails)
                    .HasMaxLength(500)
                    .HasColumnName("TO_EMAILS");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.PaymentEmails)
                    .HasForeignKey(d => d.Corpid)
                    .HasConstraintName("FK__PAYMENT__CORPI__38845C1C");

                entity.HasOne(d => d.ProjectDetail)
                    .WithMany(p => p.PaymentEmails)
                    .HasForeignKey(d => d.ProjectDetailid)
                    .HasConstraintName("FK_PAYMENT_EMAILS_PROJECT_GROUPDETAIL");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.PaymentEmails)
                    .HasForeignKey(d => d.Projectid)
                    .HasConstraintName("FK__PAYMENT__PROJE__39788055");
            });

            modelBuilder.Entity<Payments>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__PAYMENTS__3214EC26489EFB7F")
                    .IsClustered(false);

                entity.ToTable("PAYMENTS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Credit).HasColumnName("CREDIT");

                entity.Property(e => e.Curcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CURCODE")
                    .IsFixedLength();

                entity.Property(e => e.Debt).HasColumnName("DEBT");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Hardposidentity)
                    .HasMaxLength(50)
                    .HasColumnName("HARDPOSIDENTITY");

                entity.Property(e => e.Isbonus).HasColumnName("ISBONUS");

                entity.Property(e => e.Iscash).HasColumnName("ISCASH");

                entity.Property(e => e.Isccard).HasColumnName("ISCCARD");

                entity.Property(e => e.Paytype).HasColumnName("PAYTYPE");

                entity.Property(e => e.Requestid).HasColumnName("REQUESTID");

                entity.Property(e => e.Resourceid).HasColumnName("RESOURCEID");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.TlAmount)
                    .HasColumnName("TL_AMOUNT")
                    .HasComputedColumnSql("([dbo].[FN_CURRATE]([CORPID],[ADDDATE],[CURCODE],'TRY',[DEBT]+[CREDIT]))", false);

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.PaymentsAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PAYMENTS__ADDUSE__6C390A4C");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PAYMENTS__CORPID__6D2D2E85");

                entity.HasOne(d => d.CurcodeNavigation)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.Curcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PAYMENTS__CURCOD__6E2152BE");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.PaymentsEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__PAYMENTS__EDITUS__6F1576F7");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.Requestid)
                    .HasConstraintName("FK__PAYMENTS__REQUES__70099B30");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.Resourceid)
                    .HasConstraintName("FK__PAYMENTS__RESOUR__70FDBF69");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PAYMENTS__STATUS__71F1E3A2");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("PERSON");

                entity.HasIndex(e => e.RakamId, "IX_PERSON");

                entity.HasIndex(e => e.Firstname, "IX_PERSON_1");

                entity.HasIndex(e => e.Nationality, "IX_PERSON_10");

                entity.HasIndex(e => e.Isdeleted, "IX_PERSON_11");

                entity.HasIndex(e => e.Kvkk, "IX_PERSON_12");

                entity.HasIndex(e => e.Email, "IX_PERSON_13");

                entity.HasIndex(e => e.Lastname, "IX_PERSON_2");

                entity.HasIndex(e => e.Secondname, "IX_PERSON_3");

                entity.HasIndex(e => e.Firstname, "IX_PERSON_4");

                entity.HasIndex(e => e.Lastname, "IX_PERSON_5");

                entity.HasIndex(e => e.Fullname, "IX_PERSON_6");

                entity.HasIndex(e => e.Tel1, "IX_PERSON_7");

                entity.HasIndex(e => e.Tel2, "IX_PERSON_8");

                entity.HasIndex(e => e.Type, "IX_PERSON_9");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Birthdate)
                    .HasColumnType("date")
                    .HasColumnName("BIRTHDATE");

                entity.Property(e => e.BonusCardtype)
                    .HasMaxLength(150)
                    .HasColumnName("BONUS_CARDTYPE");

                entity.Property(e => e.BonusExpried).HasColumnName("BONUS_EXPRIED");

                entity.Property(e => e.BonusGained).HasColumnName("BONUS_GAINED");

                entity.Property(e => e.BonusLeft).HasColumnName("BONUS_LEFT");

                entity.Property(e => e.BonusLeftamount).HasColumnName("BONUS_LEFTAMOUNT");

                entity.Property(e => e.BonusUsed).HasColumnName("BONUS_USED");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Defaultname).HasColumnName("DEFAULTNAME");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.EntId)
                    .HasMaxLength(150)
                    .HasColumnName("ENT_ID");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(70)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(212)
                    .HasColumnName("FULLNAME")
                    .HasComputedColumnSql("((isnull([FIRSTNAME]+' ','')+isnull([SECONDNAME]+' ',''))+isnull([LASTNAME],''))", false);

                entity.Property(e => e.Gender).HasColumnName("GENDER");

                entity.Property(e => e.Groupid).HasColumnName("GROUPID");

                entity.Property(e => e.Identityno)
                    .HasMaxLength(15)
                    .HasColumnName("IDENTITYNO");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Kvkk).HasColumnName("KVKK");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(70)
                    .HasColumnName("LASTNAME");

                entity.Property(e => e.Nationality).HasColumnName("NATIONALITY");

                entity.Property(e => e.NewslatterFromemail).HasColumnName("NEWSLATTER_FROMEMAIL");

                entity.Property(e => e.NewslatterFromsms).HasColumnName("NEWSLATTER_FROMSMS");

                entity.Property(e => e.RakamId)
                    .HasMaxLength(15)
                    .HasColumnName("RAKAM_ID");

                entity.Property(e => e.RepeatGuest).HasColumnName("REPEAT_GUEST");

                entity.Property(e => e.Secondname)
                    .HasMaxLength(70)
                    .HasColumnName("SECONDNAME");

                entity.Property(e => e.Tel1).HasColumnName("TEL1");

                entity.Property(e => e.Tel2).HasColumnName("TEL2");

                entity.Property(e => e.Title)
                    .HasMaxLength(10)
                    .HasColumnName("TITLE");

                entity.Property(e => e.Type).HasColumnName("TYPE");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.PersonAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PERSON__ADDUSER__14270015");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.Person)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PERSON_CORP");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.PersonEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__PERSON__EDITUSER__160F4887");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Person)
                    .HasForeignKey(d => d.Groupid)
                    .HasConstraintName("FK__PERSON__GROUPID__123EB7A3");

                entity.HasOne(d => d.NationalityNavigation)
                    .WithMany(p => p.Person)
                    .HasForeignKey(d => d.Nationality)
                    .HasConstraintName("FK__PERSON__NATIONAL__0F624AF8");
            });

            modelBuilder.Entity<PersonAddress>(entity =>
            {
                entity.ToTable("PERSON_ADDRESS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Addressid).HasColumnName("ADDRESSID");

                entity.Property(e => e.Personid).HasColumnName("PERSONID");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.PersonAddress)
                    .HasForeignKey(d => d.Addressid)
                    .HasConstraintName("FK__PERSON_AD__ADDRE__77AABCF8");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonAddress)
                    .HasForeignKey(d => d.Personid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PERSON_AD__PERSO__208CD6FA");
            });

            modelBuilder.Entity<PersonBonus>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__PERSON_B__3214EC26FC14D486")
                    .IsClustered(false);

                entity.ToTable("PERSON_BONUS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("DATE");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Personid).HasColumnName("PERSONID");

                entity.Property(e => e.Point).HasColumnName("POINT");

                entity.Property(e => e.Productid).HasColumnName("PRODUCTID");

                entity.Property(e => e.RequestDetailid).HasColumnName("REQUEST_DETAILID");

                entity.Property(e => e.Typeid).HasColumnName("TYPEID");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.PersonBonusAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PERSON_BO__ADDUS__082C08DB");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.PersonBonusEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__PERSON_BO__EDITU__0A14514D");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonBonus)
                    .HasForeignKey(d => d.Personid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PERSON_BO__PERSO__036753BE");

                entity.HasOne(d => d.RequestDetail)
                    .WithMany(p => p.PersonBonus)
                    .HasForeignKey(d => d.RequestDetailid)
                    .HasConstraintName("FK__PERSON_BO__REQUE__0643C069");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.PersonBonus)
                    .HasForeignKey(d => d.Typeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PERSON_BO__TYPEI__045B77F7");
            });

            modelBuilder.Entity<PersonBonusTypes>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__PERSON_B__3214EC263CFE324A")
                    .IsClustered(false);

                entity.ToTable("PERSON_BONUS_TYPES");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Isnegative).HasColumnName("ISNEGATIVE");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.PersonBonusTypesAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PERSON_BO__ADDUS__7DAE7A68");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.PersonBonusTypes)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PERSON_BO__CORPI__7CBA562F");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.PersonBonusTypesEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__PERSON_BO__EDITU__7F96C2DA");
            });

            modelBuilder.Entity<PersonCcards>(entity =>
            {
                entity.ToTable("PERSON_CCARDS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cardnumber)
                    .HasMaxLength(50)
                    .HasColumnName("CARDNUMBER");

                entity.Property(e => e.Cardowner)
                    .HasMaxLength(200)
                    .HasColumnName("CARDOWNER");

                entity.Property(e => e.Cvv)
                    .HasMaxLength(5)
                    .HasColumnName("CVV");

                entity.Property(e => e.Personid).HasColumnName("PERSONID");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Validmonth).HasColumnName("VALIDMONTH");

                entity.Property(e => e.Validyear).HasColumnName("VALIDYEAR");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonCcards)
                    .HasForeignKey(d => d.Personid)
                    .HasConstraintName("FK__PERSON_CC__PERSO__0F4D3C5F");
            });

            modelBuilder.Entity<PersonGroup>(entity =>
            {
                entity.ToTable("PERSON_GROUP");

                entity.HasIndex(e => new { e.Corpid, e.Name }, "IX_PERSON_GROUP")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .HasColumnName("NAME");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.PersonGroupAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PERSON_GR__ADDUS__1AD3FDA4");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.PersonGroup)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PERSON_GROUP_CORP");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.PersonGroupEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__PERSON_GR__EDITU__1CBC4616");
            });

            modelBuilder.Entity<Portal>(entity =>
            {
                entity.ToTable("PORTAL");

                entity.HasIndex(e => e.Uid, "IX_PORTAL")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountAutoCreateuserOnforgetpassform)
                    .IsRequired()
                    .HasColumnName("ACCOUNT_AUTO_CREATEUSER_ONFORGETPASSFORM")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AccountBackgroundurl)
                    .HasMaxLength(350)
                    .HasColumnName("ACCOUNT_BACKGROUNDURL");

                entity.Property(e => e.AccountCopyright)
                    .HasMaxLength(150)
                    .HasColumnName("ACCOUNT_COPYRIGHT");

                entity.Property(e => e.AccountLoginByPhone)
                    .IsRequired()
                    .HasColumnName("ACCOUNT_LOGIN_BY_PHONE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AccountLoginByRoomno).HasColumnName("ACCOUNT_LOGIN_BY_ROOMNO");

                entity.Property(e => e.AccountLoginByVoucherno)
                    .IsRequired()
                    .HasColumnName("ACCOUNT_LOGIN_BY_VOUCHERNO")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AccountLogo)
                    .HasMaxLength(350)
                    .HasColumnName("ACCOUNT_LOGO");

                entity.Property(e => e.AccountUse).HasColumnName("ACCOUNT_USE");

                entity.Property(e => e.ContactEmail)
                    .HasMaxLength(240)
                    .HasColumnName("CONTACT_EMAIL");

                entity.Property(e => e.ContactMapurl)
                    .HasMaxLength(400)
                    .HasColumnName("CONTACT_MAPURL");

                entity.Property(e => e.ContactPhone)
                    .HasMaxLength(40)
                    .HasColumnName("CONTACT_PHONE");

                entity.Property(e => e.Corporationid).HasColumnName("CORPORATIONID");

                entity.Property(e => e.CrmActive).HasColumnName("CRM_ACTIVE");

                entity.Property(e => e.DefaultCurcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("DEFAULT_CURCODE")
                    .HasDefaultValueSql("('TRY')")
                    .IsFixedLength();

                entity.Property(e => e.DefaultLang)
                    .HasMaxLength(5)
                    .HasColumnName("DEFAULT_LANG")
                    .HasDefaultValueSql("('tr-TR')");

                entity.Property(e => e.Displayname)
                    .HasMaxLength(100)
                    .HasColumnName("DISPLAYNAME");

                entity.Property(e => e.Domain)
                    .HasMaxLength(100)
                    .HasColumnName("DOMAIN");

                entity.Property(e => e.Favicon)
                    .HasMaxLength(250)
                    .HasColumnName("FAVICON");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.Logininfo)
                    .HasColumnType("ntext")
                    .HasColumnName("LOGININFO");

                entity.Property(e => e.Logo)
                    .HasMaxLength(250)
                    .HasColumnName("LOGO");

                entity.Property(e => e.Mode).HasColumnName("MODE");

                entity.Property(e => e.MultipleCurcodes)
                    .IsRequired()
                    .HasColumnName("MULTIPLE_CURCODES")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.OfferBanner)
                    .HasMaxLength(350)
                    .HasColumnName("OFFER_BANNER");

                entity.Property(e => e.OfferRules).HasColumnName("OFFER_RULES");

                entity.Property(e => e.OfferText).HasColumnName("OFFER_TEXT");

                entity.Property(e => e.PortalGroupname)
                    .HasMaxLength(50)
                    .HasColumnName("PORTAL_GROUPNAME");

                entity.Property(e => e.PostekDomain)
                    .HasMaxLength(100)
                    .HasColumnName("POSTEK_DOMAIN");

                entity.Property(e => e.ProjectDetailid).HasColumnName("PROJECT_DETAILID");

                entity.Property(e => e.Projectid).HasColumnName("PROJECTID");

                entity.Property(e => e.Resourceid).HasColumnName("RESOURCEID");

                entity.Property(e => e.SetCurcodeBymarket).HasColumnName("SET_CURCODE_BYMARKET");

                entity.Property(e => e.SetLangBymarket).HasColumnName("SET_LANG_BYMARKET");

                entity.Property(e => e.Templatename)
                    .HasMaxLength(50)
                    .HasColumnName("TEMPLATENAME");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Corporation)
                    .WithMany(p => p.Portal)
                    .HasForeignKey(d => d.Corporationid)
                    .HasConstraintName("FK_PORTAL_CORP");

                entity.HasOne(d => d.DefaultCurcodeNavigation)
                    .WithMany(p => p.Portal)
                    .HasForeignKey(d => d.DefaultCurcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PORTAL_CURCODE");

                entity.HasOne(d => d.ProjectDetail)
                    .WithMany(p => p.Portal)
                    .HasForeignKey(d => d.ProjectDetailid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PORTAL_PROJECT_GROUPDETAIL");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Portal)
                    .HasForeignKey(d => d.Projectid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PORTAL_PROJECT_GROUP");
            });

            modelBuilder.Entity<PortalAuthIpaddress>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__PORTAL_A__3214EC263CD31959")
                    .IsClustered(false);

                entity.ToTable("PORTAL_AUTH_IPADDRESS");

                entity.HasIndex(e => new { e.Ipaddress, e.Portaluid }, "IX_PORTAL_AUTH_IPADDRESS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(35)
                    .HasColumnName("IPADDRESS");

                entity.Property(e => e.Ismanager)
                    .IsRequired()
                    .HasColumnName("ISMANAGER")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Portaluid).HasColumnName("PORTALUID");

                entity.HasOne(d => d.Portalu)
                    .WithMany(p => p.PortalAuthIpaddress)
                    .HasPrincipalKey(p => p.Uid)
                    .HasForeignKey(d => d.Portaluid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PORTAL_AU__PORTA__605321AB");
            });

            modelBuilder.Entity<PortalCategories>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__PORTAL_C__3214EC26899D975F")
                    .IsClustered(false);

                entity.ToTable("PORTAL_CATEGORIES");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Definition)
                    .HasMaxLength(150)
                    .HasColumnName("DEFINITION");

                entity.Property(e => e.Description).HasColumnName("DESCRIPTION");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Intid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("INTID");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.Portalid).HasColumnName("PORTALID");

                entity.Property(e => e.Type)
                    .HasMaxLength(150)
                    .HasColumnName("TYPE");

                entity.Property(e => e.Url)
                    .HasMaxLength(250)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.PortalCategoriesAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PORTAL_CA__ADDUS__004002F9");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.PortalCategoriesEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__PORTAL_CA__EDITU__01342732");

                entity.HasOne(d => d.Portal)
                    .WithMany(p => p.PortalCategories)
                    .HasForeignKey(d => d.Portalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PORTAL_CA__PORTA__02284B6B");
            });

            modelBuilder.Entity<PortalCategoryImages>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__PORTAL_C__3214EC2620C60564")
                    .IsClustered(false);

                entity.ToTable("PORTAL_CATEGORY_IMAGES");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Catid).HasColumnName("CATID");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Groupname)
                    .HasMaxLength(100)
                    .HasColumnName("GROUPNAME");

                entity.Property(e => e.Imageurl)
                    .HasMaxLength(350)
                    .HasColumnName("IMAGEURL");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.Sortindex).HasColumnName("SORTINDEX");

                entity.Property(e => e.Thumbnailurl)
                    .HasMaxLength(350)
                    .HasColumnName("THUMBNAILURL");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.PortalCategoryImagesAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PORTAL_CA__ADDUS__0EE3280B");

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.PortalCategoryImages)
                    .HasForeignKey(d => d.Catid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PORTAL_CATEGORY_IMAGES_PORTAL_CATEGORIES");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.PortalCategoryImagesEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__PORTAL_CA__EDITU__0FD74C44");
            });

            modelBuilder.Entity<PortalCategoryItems>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__PORTAL_C__3214EC26CDAF71B5")
                    .IsClustered(false);

                entity.ToTable("PORTAL_CATEGORY_ITEMS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Catid).HasColumnName("CATID");

                entity.Property(e => e.Curcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CURCODE")
                    .IsFixedLength();

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Discount).HasColumnName("DISCOUNT");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Hotelid).HasColumnName("HOTELID");

                entity.Property(e => e.Imageurl)
                    .HasMaxLength(250)
                    .HasColumnName("IMAGEURL");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.Price).HasColumnName("PRICE");

                entity.Property(e => e.Sortindex).HasColumnName("SORTINDEX");

                entity.Property(e => e.Thumbnailurl)
                    .HasMaxLength(250)
                    .HasColumnName("THUMBNAILURL");

                entity.Property(e => e.Ticketid).HasColumnName("TICKETID");

                entity.Property(e => e.Tourid).HasColumnName("TOURID");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.PortalCategoryItemsAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PORTAL_CA__ADDUS__17786E0C");

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.PortalCategoryItems)
                    .HasForeignKey(d => d.Catid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PORTAL_CATEGORY_ITEMS_PORTAL_CATEGORIES");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.PortalCategoryItemsEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__PORTAL_CA__EDITU__186C9245");

                entity.HasOne(d => d.Hotel)
                    .WithMany(p => p.PortalCategoryItems)
                    .HasForeignKey(d => d.Hotelid)
                    .HasConstraintName("FK__PORTAL_CA__HOTEL__23DE44F1");

                entity.HasOne(d => d.Ticket)
                    .WithMany(p => p.PortalCategoryItems)
                    .HasForeignKey(d => d.Ticketid)
                    .HasConstraintName("FK_PORTAL_CATEGORY_ITEMS_TICKET");

                entity.HasOne(d => d.Tour)
                    .WithMany(p => p.PortalCategoryItems)
                    .HasForeignKey(d => d.Tourid)
                    .HasConstraintName("FK__PORTAL_CA__TOURI__24D2692A");
            });

            modelBuilder.Entity<PortalCurrencies>(entity =>
            {
                entity.ToTable("PORTAL_CURRENCIES");

                entity.HasIndex(e => new { e.Curcode, e.Portaluid }, "IX_PORTAL_CURRENCIES")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Curcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CURCODE")
                    .IsFixedLength();

                entity.Property(e => e.Portaluid).HasColumnName("PORTALUID");

                entity.HasOne(d => d.CurcodeNavigation)
                    .WithMany(p => p.PortalCurrencies)
                    .HasForeignKey(d => d.Curcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PORTAL_CU__CURCO__031C6FA4");

                entity.HasOne(d => d.Portalu)
                    .WithMany(p => p.PortalCurrencies)
                    .HasPrincipalKey(p => p.Uid)
                    .HasForeignKey(d => d.Portaluid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PORTAL_CU__PORTA__041093DD");
            });

            modelBuilder.Entity<PortalDescription>(entity =>
            {
                entity.ToTable("PORTAL_DESCRIPTION");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Caption)
                    .HasMaxLength(100)
                    .HasColumnName("CAPTION");

                entity.Property(e => e.Description).HasColumnName("DESCRIPTION");

                entity.Property(e => e.Icon)
                    .HasMaxLength(50)
                    .HasColumnName("ICON");

                entity.Property(e => e.Portaluid).HasColumnName("PORTALUID");

                entity.Property(e => e.Type).HasColumnName("TYPE");

                entity.HasOne(d => d.Portalu)
                    .WithMany(p => p.PortalDescription)
                    .HasPrincipalKey(p => p.Uid)
                    .HasForeignKey(d => d.Portaluid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PORTAL_DESCRIPTION_PORTAL");
            });

            modelBuilder.Entity<PortalDomains>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__PORTAL_D__3214EC267E745450")
                    .IsClustered(false);

                entity.ToTable("PORTAL_DOMAINS");

                entity.HasIndex(e => new { e.Portaluid, e.Domain }, "UQ__PORTAL_D__73E21ECAE3DDAF90")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Domain)
                    .HasMaxLength(250)
                    .HasColumnName("DOMAIN");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.Onlybody).HasColumnName("ONLYBODY");

                entity.Property(e => e.Portaluid).HasColumnName("PORTALUID");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.PortalDomainsAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PORTAL_DO__ADDUS__05F8DC4F");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.PortalDomainsEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__PORTAL_DO__EDITU__06ED0088");

                entity.HasOne(d => d.Portalu)
                    .WithMany(p => p.PortalDomains)
                    .HasPrincipalKey(p => p.Uid)
                    .HasForeignKey(d => d.Portaluid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PORTAL_DO__PORTAL__363CEC4E");
            });

            modelBuilder.Entity<PortalEmails>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__PORTAL_E__3214EC2617569B3F")
                    .IsClustered(false);

                entity.ToTable("PORTAL_EMAILS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BccEmails)
                    .HasMaxLength(500)
                    .HasColumnName("BCC_EMAILS");

                entity.Property(e => e.CcEmails)
                    .HasMaxLength(500)
                    .HasColumnName("CC_EMAILS");

                entity.Property(e => e.Portaluid).HasColumnName("PORTALUID");

                entity.Property(e => e.ToEmails)
                    .HasMaxLength(500)
                    .HasColumnName("TO_EMAILS");

                entity.HasOne(d => d.Portalu)
                    .WithMany(p => p.PortalEmails)
                    .HasPrincipalKey(p => p.Uid)
                    .HasForeignKey(d => d.Portaluid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PORTAL_EM__PORTA__45F4312A");
            });

            modelBuilder.Entity<PortalLangdictionary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PORTAL_LANGDICTIONARY");

                entity.Property(e => e.ArSa)
                    .HasMaxLength(250)
                    .HasColumnName("ar-SA");

                entity.Property(e => e.DeDe)
                    .HasMaxLength(250)
                    .HasColumnName("de-DE");

                entity.Property(e => e.EnUs)
                    .HasMaxLength(250)
                    .HasColumnName("en-US");

                entity.Property(e => e.FiFi)
                    .HasMaxLength(150)
                    .HasColumnName("fi-FI");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Keyvalue)
                    .HasMaxLength(150)
                    .HasColumnName("KEYVALUE")
                    .UseCollation("Turkish_CS_AS");

                entity.Property(e => e.Keyvalue2)
                    .HasMaxLength(150)
                    .HasColumnName("KEYVALUE2");

                entity.Property(e => e.RuRu)
                    .HasMaxLength(250)
                    .HasColumnName("ru-RU");

                entity.Property(e => e.TrTr)
                    .HasMaxLength(250)
                    .HasColumnName("tr-TR");
            });

            modelBuilder.Entity<PortalLanguages>(entity =>
            {
                entity.ToTable("PORTAL_LANGUAGES");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Langcode)
                    .HasMaxLength(5)
                    .HasColumnName("LANGCODE")
                    .IsFixedLength();

                entity.Property(e => e.Portaluid).HasColumnName("PORTALUID");

                entity.HasOne(d => d.Portalu)
                    .WithMany(p => p.PortalLanguages)
                    .HasPrincipalKey(p => p.Uid)
                    .HasForeignKey(d => d.Portaluid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PORTAL_LANGUAGES_PORTAL");
            });

            modelBuilder.Entity<PortalSeo>(entity =>
            {
                entity.ToTable("PORTAL_SEO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Description).HasColumnName("DESCRIPTION");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Keywords).HasColumnName("KEYWORDS");

                entity.Property(e => e.Lang)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("LANG")
                    .IsFixedLength();

                entity.Property(e => e.Portalid).HasColumnName("PORTALID");

                entity.Property(e => e.Portaluid).HasColumnName("PORTALUID");

                entity.Property(e => e.ProjectDetailid).HasColumnName("PROJECT_DETAILID");

                entity.Property(e => e.Title)
                    .HasMaxLength(250)
                    .HasColumnName("TITLE");

                entity.Property(e => e.Url)
                    .HasMaxLength(150)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.PortalSeoAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PORTAL_SE__ADDUS__09C96D33");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.PortalSeoEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__PORTAL_SE__EDITU__0ABD916C");

                entity.HasOne(d => d.LangNavigation)
                    .WithMany(p => p.PortalSeo)
                    .HasForeignKey(d => d.Lang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PORTAL_SEO__LANG__0BB1B5A5");

                entity.HasOne(d => d.ProjectDetail)
                    .WithMany(p => p.PortalSeo)
                    .HasForeignKey(d => d.ProjectDetailid)
                    .HasConstraintName("FK__PORTAL_SE__PROJE__0E8E2250");
            });

            modelBuilder.Entity<PortalSettings>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__PORTAL_S__3214EC260BC297DC")
                    .IsClustered(false);

                entity.ToTable("PORTAL_SETTINGS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BasketHideClientDetails).HasColumnName("BASKET_HIDE_CLIENT_DETAILS");

                entity.Property(e => e.BasketShowClientGender).HasColumnName("BASKET_SHOW_CLIENT_GENDER");

                entity.Property(e => e.BasketShowTransferOptions).HasColumnName("BASKET_SHOW_TRANSFER_OPTIONS");

                entity.Property(e => e.CancelationRules).HasColumnName("CANCELATION_RULES");

                entity.Property(e => e.Kvkk).HasColumnName("KVKK");

                entity.Property(e => e.Policies).HasColumnName("POLICIES");

                entity.Property(e => e.Portalid).HasColumnName("PORTALID");

                entity.Property(e => e.Privacy).HasColumnName("PRIVACY");

                entity.Property(e => e.SalesRules).HasColumnName("SALES_RULES");

                entity.HasOne(d => d.Portal)
                    .WithMany(p => p.PortalSettings)
                    .HasPrincipalKey(p => p.Uid)
                    .HasForeignKey(d => d.Portalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PORTAL_SE__PORTA__58920452");
            });

            modelBuilder.Entity<PortalUrlrewrite>(entity =>
            {
                entity.ToTable("PORTAL_URLREWRITE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Link).HasColumnName("LINK");

                entity.Property(e => e.Validdate)
                    .HasColumnType("datetime")
                    .HasColumnName("VALIDDATE");
            });

            modelBuilder.Entity<PortalUser>(entity =>
            {
                entity.ToTable("PORTAL_USER");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Changedate)
                    .HasColumnType("datetime")
                    .HasColumnName("CHANGEDATE");

                entity.Property(e => e.Changekey)
                    .HasMaxLength(50)
                    .HasColumnName("CHANGEKEY")
                    .UseCollation("SQL_Latin1_General_CP1254_CI_AS");

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Personid).HasColumnName("PERSONID");

                entity.Property(e => e.Phone).HasColumnName("PHONE");

                entity.Property(e => e.Pwd)
                    .HasMaxLength(200)
                    .HasColumnName("PWD");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PortalUser)
                    .HasForeignKey(d => d.Personid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__PORTAL_US__PERSO__0FC23DAB");
            });

            modelBuilder.Entity<PortalUserSocialaccount>(entity =>
            {
                entity.ToTable("PORTAL_USER_SOCIALACCOUNT");

                entity.HasIndex(e => new { e.Userid, e.Providername, e.Providerid }, "UQ__PORTAL_U__47F26347B2CE65E0")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Providerid)
                    .HasMaxLength(200)
                    .HasColumnName("PROVIDERID");

                entity.Property(e => e.Providername)
                    .HasMaxLength(50)
                    .HasColumnName("PROVIDERNAME");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PortalUserSocialaccount)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("FK__PORTAL_US__USERI__129EAA56");
            });

            modelBuilder.Entity<ProjectGroup>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__PRODUCT___3214EC27CD324AEE")
                    .IsClustered(false);

                entity.ToTable("PROJECT_GROUP");

                entity.HasIndex(e => e.RakamId, "IX_PROJECT_GROUP");

                entity.HasIndex(e => e.Name, "IX_PROJECT_GROUP_1")
                    .IsClustered();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AccCode)
                    .HasMaxLength(30)
                    .HasColumnName("ACC_CODE");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Addressid).HasColumnName("ADDRESSID");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.DontstoreCcards)
                    .HasColumnName("DONTSTORE_CCARDS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.EntId)
                    .HasMaxLength(25)
                    .HasColumnName("ENT_ID");

                entity.Property(e => e.EntSeturapikey)
                    .HasMaxLength(150)
                    .HasColumnName("ENT_SETURAPIKEY");

                entity.Property(e => e.EntSetururl)
                    .HasMaxLength(250)
                    .HasColumnName("ENT_SETURURL");

                entity.Property(e => e.EntUrl)
                    .HasMaxLength(150)
                    .HasColumnName("ENT_URL");

                entity.Property(e => e.EntUse).HasColumnName("ENT_USE");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.Mergeclients).HasColumnName("MERGECLIENTS");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .HasColumnName("NAME");

                entity.Property(e => e.RakamId)
                    .HasMaxLength(15)
                    .HasColumnName("RAKAM_ID");

                entity.Property(e => e.ResMailurl)
                    .HasMaxLength(250)
                    .HasColumnName("RES_MAILURL");

                entity.Property(e => e.Usealternates).HasColumnName("USEALTERNATES");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.ProjectGroup)
                    .HasForeignKey(d => d.Addressid)
                    .HasConstraintName("FK_PROJECT_GROUP_LOCATION_ADDRESS");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.ProjectGroupAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PRODUCT_G__ADDUS__7A672E12");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.ProjectGroup)
                    .HasForeignKey(d => d.Corpid)
                    .HasConstraintName("FK__PRODUCT_G__CORPI__76969D2E");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.ProjectGroupEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__PRODUCT_G__EDITU__7C4F7684");
            });

            modelBuilder.Entity<ProjectGroupdetail>(entity =>
            {
                entity.ToTable("PROJECT_GROUPDETAIL");

                entity.HasIndex(e => e.Intid, "IX_PROJECT_GROUPDETAIL")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AccInvCode)
                    .HasMaxLength(30)
                    .HasColumnName("ACC_INV_CODE");

                entity.Property(e => e.AccPayCode)
                    .HasMaxLength(30)
                    .HasColumnName("ACC_PAY_CODE");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.DontMerge).HasColumnName("DONT_MERGE");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.EntEtsid)
                    .HasMaxLength(50)
                    .HasColumnName("ENT_ETSID");

                entity.Property(e => e.EntEtsurl)
                    .HasMaxLength(350)
                    .HasColumnName("ENT_ETSURL");

                entity.Property(e => e.EntHotelrunnerid)
                    .HasMaxLength(150)
                    .HasColumnName("ENT_HOTELRUNNERID");

                entity.Property(e => e.EntHotelrunnerurl)
                    .HasMaxLength(150)
                    .HasColumnName("ENT_HOTELRUNNERURL");

                entity.Property(e => e.EntIatiid)
                    .HasMaxLength(50)
                    .HasColumnName("ENT_IATIID");

                entity.Property(e => e.EntIatiurl)
                    .HasMaxLength(350)
                    .HasColumnName("ENT_IATIURL");

                entity.Property(e => e.EntId)
                    .HasMaxLength(25)
                    .HasColumnName("ENT_ID");

                entity.Property(e => e.EntJollytourid)
                    .HasMaxLength(150)
                    .HasColumnName("ENT_JOLLYTOURID");

                entity.Property(e => e.EntJollytoururl)
                    .HasMaxLength(250)
                    .HasColumnName("ENT_JOLLYTOURURL");

                entity.Property(e => e.EntPortalid).HasColumnName("ENT_PORTALID");

                entity.Property(e => e.EntSednaid)
                    .HasMaxLength(250)
                    .HasColumnName("ENT_SEDNAID");

                entity.Property(e => e.EntSednaurl)
                    .HasMaxLength(250)
                    .HasColumnName("ENT_SEDNAURL");

                entity.Property(e => e.EntSeturid)
                    .HasMaxLength(150)
                    .HasColumnName("ENT_SETURID");

                entity.Property(e => e.EntSetururl)
                    .HasMaxLength(150)
                    .HasColumnName("ENT_SETURURL");

                entity.Property(e => e.EntTatilbudurid)
                    .HasMaxLength(20)
                    .HasColumnName("ENT_TATILBUDURID");

                entity.Property(e => e.EntTatilbudururl)
                    .HasMaxLength(350)
                    .HasColumnName("ENT_TATILBUDURURL");

                entity.Property(e => e.EntTouristicaid)
                    .HasMaxLength(50)
                    .HasColumnName("ENT_TOURISTICAID");

                entity.Property(e => e.EntTouristicaurl)
                    .HasMaxLength(350)
                    .HasColumnName("ENT_TOURISTICAURL");

                entity.Property(e => e.EntTravelclcikurl)
                    .HasMaxLength(350)
                    .HasColumnName("ENT_TRAVELCLCIKURL");

                entity.Property(e => e.EntTravelclickid)
                    .HasMaxLength(50)
                    .HasColumnName("ENT_TRAVELCLICKID");

                entity.Property(e => e.EntUrl)
                    .HasMaxLength(250)
                    .HasColumnName("ENT_URL");

                entity.Property(e => e.GaCustomerid)
                    .HasMaxLength(15)
                    .HasColumnName("GA_CUSTOMERID");

                entity.Property(e => e.HideContracttabFromagents).HasColumnName("HIDE_CONTRACTTAB_FROMAGENTS");

                entity.Property(e => e.Hotelid).HasColumnName("HOTELID");

                entity.Property(e => e.Intid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("INTID");

                entity.Property(e => e.InvoiceDueday).HasColumnName("INVOICE_DUEDAY");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.Productid)
                    .HasColumnName("PRODUCTID")
                    .HasComputedColumnSql("(coalesce([HOTELID],[TOURID],[TICKETID]))", false);

                entity.Property(e => e.ProfitPercent).HasColumnName("PROFIT_PERCENT");

                entity.Property(e => e.ProjectGroupid).HasColumnName("PROJECT_GROUPID");

                entity.Property(e => e.ResMailurl)
                    .HasMaxLength(250)
                    .HasColumnName("RES_MAILURL");

                entity.Property(e => e.Storeid).HasColumnName("STOREID");

                entity.Property(e => e.Tel1).HasColumnName("TEL1");

                entity.Property(e => e.Tel2).HasColumnName("TEL2");

                entity.Property(e => e.Ticketid).HasColumnName("TICKETID");

                entity.Property(e => e.Tourid).HasColumnName("TOURID");

                entity.HasOne(d => d.Hotel)
                    .WithMany(p => p.ProjectGroupdetail)
                    .HasForeignKey(d => d.Hotelid)
                    .HasConstraintName("FK__PRODUCT_G__HOTEL__01142BA1");

                entity.HasOne(d => d.ProjectGroup)
                    .WithMany(p => p.ProjectGroupdetail)
                    .HasForeignKey(d => d.ProjectGroupid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PRODUCT_G__PRODU__00200768");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.ProjectGroupdetail)
                    .HasForeignKey(d => d.Storeid)
                    .HasConstraintName("FK__PROJECT_G__STORE__7350E786");

                entity.HasOne(d => d.Ticket)
                    .WithMany(p => p.ProjectGroupdetail)
                    .HasForeignKey(d => d.Ticketid)
                    .HasConstraintName("FK_PROJECT_GROUPDETAIL_TICKET");

                entity.HasOne(d => d.Tour)
                    .WithMany(p => p.ProjectGroupdetail)
                    .HasForeignKey(d => d.Tourid)
                    .HasConstraintName("FK__PROJECT_G__TOURI__1446FBA6");
            });

            modelBuilder.Entity<ProjectGroupdetailBankdep>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__PROJECT___3214EC26C3F1EA7D")
                    .IsClustered(false);

                entity.ToTable("PROJECT_GROUPDETAIL_BANKDEP");

                entity.HasIndex(e => new { e.ProjectDetailid, e.Depaccountid }, "UQ__PROJECT___6EB8113D889D7241")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Depaccountid).HasColumnName("DEPACCOUNTID");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.ProjectDetailid).HasColumnName("PROJECT_DETAILID");

                entity.Property(e => e.UseInPortal)
                    .IsRequired()
                    .HasColumnName("USE_IN_PORTAL")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Depaccount)
                    .WithMany(p => p.ProjectGroupdetailBankdep)
                    .HasForeignKey(d => d.Depaccountid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PROJECT_G__DEPAC__75985754");

                entity.HasOne(d => d.ProjectDetail)
                    .WithMany(p => p.ProjectGroupdetailBankdep)
                    .HasForeignKey(d => d.ProjectDetailid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PROJECT_G__PROJE__74A4331B");
            });

            modelBuilder.Entity<ProjectGroupdetailSeo>(entity =>
            {
                entity.ToTable("PROJECT_GROUPDETAIL_SEO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasColumnName("DESCRIPTION");

                entity.Property(e => e.Keywords).HasColumnName("KEYWORDS");

                entity.Property(e => e.Lang)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("LANG")
                    .IsFixedLength();

                entity.Property(e => e.ProjectDetailid).HasColumnName("PROJECT_DETAILID");

                entity.Property(e => e.Title)
                    .HasMaxLength(250)
                    .HasColumnName("TITLE");

                entity.Property(e => e.Url)
                    .HasMaxLength(150)
                    .HasColumnName("URL");

                entity.HasOne(d => d.LangNavigation)
                    .WithMany(p => p.ProjectGroupdetailSeo)
                    .HasForeignKey(d => d.Lang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PROJECT_GR__LANG__19FFD4FC");
            });

            modelBuilder.Entity<ProjectGroupdetailVpos>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__PROJECT___3214EC2674987CD5")
                    .IsClustered(false);

                entity.ToTable("PROJECT_GROUPDETAIL_VPOS");

                entity.HasIndex(e => new { e.ProjectDetailid, e.Accountid }, "UQ__PROJECT___F7CFBB35722A2BCA")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Accountid).HasColumnName("ACCOUNTID");

                entity.Property(e => e.Cardbrands)
                    .HasMaxLength(220)
                    .HasColumnName("CARDBRANDS");

                entity.Property(e => e.Curcodes)
                    .HasMaxLength(220)
                    .HasColumnName("CURCODES");

                entity.Property(e => e.Isdefault).HasColumnName("ISDEFAULT");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.ProjectDetailid).HasColumnName("PROJECT_DETAILID");

                entity.HasOne(d => d.ProjectDetail)
                    .WithMany(p => p.ProjectGroupdetailVpos)
                    .HasForeignKey(d => d.ProjectDetailid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PROJECT_G__PROJE__48C5B0DD");
            });

            modelBuilder.Entity<PromotionCodes>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__PROMOTIO__3214EC26C010043A")
                    .IsClustered(false);

                entity.ToTable("PROMOTION_CODES");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .HasColumnName("CODE");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Curcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CURCODE")
                    .IsFixedLength();

                entity.Property(e => e.Definition)
                    .HasMaxLength(150)
                    .HasColumnName("DEFINITION");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Discount).HasColumnName("DISCOUNT");

                entity.Property(e => e.Discountkind).HasColumnName("DISCOUNTKIND");

                entity.Property(e => e.Discounttype).HasColumnName("DISCOUNTTYPE");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Hotelid).HasColumnName("HOTELID");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.Kind).HasColumnName("KIND");

                entity.Property(e => e.Sellfrom)
                    .HasColumnType("datetime")
                    .HasColumnName("SELLFROM");

                entity.Property(e => e.Sellto)
                    .HasColumnType("datetime")
                    .HasColumnName("SELLTO");

                entity.Property(e => e.Stayfrom)
                    .HasColumnType("datetime")
                    .HasColumnName("STAYFROM");

                entity.Property(e => e.Stayto)
                    .HasColumnType("datetime")
                    .HasColumnName("STAYTO");

                entity.Property(e => e.Ticketid).HasColumnName("TICKETID");

                entity.Property(e => e.Tourid).HasColumnName("TOURID");

                entity.Property(e => e.Type).HasColumnName("TYPE");

                entity.Property(e => e.Usecount)
                    .HasColumnName("USECOUNT")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Usetype).HasColumnName("USETYPE");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.PromotionCodesAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PROMOTION__ADDUS__31C24FF4");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.PromotionCodes)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PROMOTION__CORPI__2744C181");

                entity.HasOne(d => d.CurcodeNavigation)
                    .WithMany(p => p.PromotionCodes)
                    .HasForeignKey(d => d.Curcode)
                    .HasConstraintName("FK_PROMOTION_CODES_CURCODE");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.PromotionCodesEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__PROMOTION__EDITU__33AA9866");

                entity.HasOne(d => d.Hotel)
                    .WithMany(p => p.PromotionCodes)
                    .HasForeignKey(d => d.Hotelid)
                    .HasConstraintName("FK__PROMOTION__HOTEL__2CFD9AD7");

                entity.HasOne(d => d.Ticket)
                    .WithMany(p => p.PromotionCodes)
                    .HasForeignKey(d => d.Ticketid)
                    .HasConstraintName("FK__PROMOTION__TICKE__2EE5E349");

                entity.HasOne(d => d.Tour)
                    .WithMany(p => p.PromotionCodes)
                    .HasForeignKey(d => d.Tourid)
                    .HasConstraintName("FK__PROMOTION__TOURI__2DF1BF10");
            });

            modelBuilder.Entity<PromotionCodesMarket>(entity =>
            {
                entity.ToTable("PROMOTION_CODES_MARKET");

                entity.HasIndex(e => new { e.Promotionid, e.Marketid }, "UQ__PROMOTION_CODES_MARKET__4B96FBB176D8588E")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Marketid).HasColumnName("MARKETID");

                entity.Property(e => e.Promotionid).HasColumnName("PROMOTIONID");

                entity.HasOne(d => d.Market)
                    .WithMany(p => p.PromotionCodesMarket)
                    .HasForeignKey(d => d.Marketid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROMOTION_CODES_MARKET__54D68207");

                entity.HasOne(d => d.Promotion)
                    .WithMany(p => p.PromotionCodesMarket)
                    .HasForeignKey(d => d.Promotionid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROMOTION_CODES_MARKET__53E25DCE");
            });

            modelBuilder.Entity<PromotionCodesRoomtype>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PROMOTION_CODES_ROOMTYPE");

                entity.HasIndex(e => new { e.Promotionid, e.Roomtype }, "UQ__PROMOTIO__C1C5A5FA64991A60")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Promotionid).HasColumnName("PROMOTIONID");

                entity.Property(e => e.Roomtype)
                    .HasMaxLength(6)
                    .HasColumnName("ROOMTYPE");

                entity.HasOne(d => d.Promotion)
                    .WithMany()
                    .HasForeignKey(d => d.Promotionid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PROMOTION__PROMO__18C19800");

                entity.HasOne(d => d.RoomtypeNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Roomtype)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PROMOTION__ROOMT__19B5BC39");
            });

            modelBuilder.Entity<PropertyMapping>(entity =>
            {
                entity.ToTable("PROPERTY_MAPPING");

                entity.HasIndex(e => new { e.Hotelid, e.Boardtypeid, e.Providerid }, "IX_PROPERTY_MAPPING");

                entity.HasIndex(e => new { e.Hotelid, e.Roomid, e.Providerid }, "IX_PROPERTY_MAPPING_1");

                entity.HasIndex(e => new { e.Hotelid, e.Providerid, e.Ratetypeid }, "IX_PROPERTY_MAPPING_2");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Boardtypeid).HasColumnName("BOARDTYPEID");

                entity.Property(e => e.Code)
                    .HasMaxLength(150)
                    .HasColumnName("CODE");

                entity.Property(e => e.Hotelid).HasColumnName("HOTELID");

                entity.Property(e => e.Providerid).HasColumnName("PROVIDERID");

                entity.Property(e => e.Ratetypeid).HasColumnName("RATETYPEID");

                entity.Property(e => e.Roomid).HasColumnName("ROOMID");

                entity.HasOne(d => d.Boardtype)
                    .WithMany(p => p.PropertyMapping)
                    .HasForeignKey(d => d.Boardtypeid)
                    .HasConstraintName("FK__PROPERTY___BOARD__17593DD2");

                entity.HasOne(d => d.Hotel)
                    .WithMany(p => p.PropertyMapping)
                    .HasForeignKey(d => d.Hotelid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PROPERTY___HOTEL__1570F560");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.PropertyMapping)
                    .HasForeignKey(d => d.Providerid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PROPERTY___PROVI__147CD127");

                entity.HasOne(d => d.Ratetype)
                    .WithMany(p => p.PropertyMapping)
                    .HasForeignKey(d => d.Ratetypeid)
                    .HasConstraintName("FK__PROPERTY___RATET__184D620B");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.PropertyMapping)
                    .HasForeignKey(d => d.Roomid)
                    .HasConstraintName("FK__PROPERTY___ROOMI__16651999");
            });

            modelBuilder.Entity<PropertyProviders>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__PROPERTY__3214EC262A9FEFB2")
                    .IsClustered(false);

                entity.ToTable("PROPERTY_PROVIDERS");

                entity.HasIndex(e => new { e.Code, e.Corpid }, "UQ__PROPERTY__A871B86AD3936B19")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .HasColumnName("CODE");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .HasColumnName("NAME");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.PropertyProviders)
                    .HasForeignKey(d => d.Corpid)
                    .HasConstraintName("FK__PROPERTY___CORPI__10AC4043");
            });

            modelBuilder.Entity<Reports>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__REPORTS__3214EC2687F3CD71")
                    .IsClustered(false);

                entity.ToTable("REPORTS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Classname)
                    .HasMaxLength(50)
                    .HasColumnName("CLASSNAME");

                entity.Property(e => e.Design).HasColumnName("DESIGN");

                entity.Property(e => e.Exporttype)
                    .HasMaxLength(25)
                    .HasColumnName("EXPORTTYPE");

                entity.Property(e => e.Kind).HasColumnName("KIND");

                entity.Property(e => e.Parentid).HasColumnName("PARENTID");

                entity.Property(e => e.Reportname)
                    .HasMaxLength(150)
                    .HasColumnName("REPORTNAME");
            });

            modelBuilder.Entity<Request>(entity =>
            {
                entity.ToTable("REQUEST");

                entity.HasIndex(e => e.Corpid, "IDX_MIS_DASHBOARD_REPORT2");

                entity.HasIndex(e => e.Adddate, "IX_REQUEST");

                entity.HasIndex(e => e.RakamId, "IX_REQUEST_1");

                entity.HasIndex(e => new { e.Adddate, e.Corpid }, "IX_REQUEST_2");

                entity.HasIndex(e => e.Creationdate, "IX_REQUEST_3");

                entity.HasIndex(e => e.Editdate, "IX_REQUEST_4");

                entity.HasIndex(e => e.Editdate, "IX_REQUEST_5");

                entity.HasIndex(e => new { e.Editdate, e.Adddate }, "IX_REQUEST_6");

                entity.HasIndex(e => e.Resourceid, "IX_REQUEST_7");

                entity.HasIndex(e => new { e.Corpid, e.ProjectGroupid }, "IX_REQUEST_CORPID_PGID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Agencyid).HasColumnName("AGENCYID");

                entity.Property(e => e.AllowSingleMen).HasColumnName("ALLOW_SINGLE_MEN");

                entity.Property(e => e.Campaigncode)
                    .HasMaxLength(100)
                    .HasColumnName("CAMPAIGNCODE");

                entity.Property(e => e.Campaignid).HasColumnName("CAMPAIGNID");

                entity.Property(e => e.CancelationWarranty).HasColumnName("CANCELATION_WARRANTY");

                entity.Property(e => e.ConversationCustomerid)
                    .HasMaxLength(50)
                    .HasColumnName("CONVERSATION_CUSTOMERID");

                entity.Property(e => e.ConversationId)
                    .HasMaxLength(50)
                    .HasColumnName("CONVERSATION_ID");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Creationdate)
                    .HasColumnType("date")
                    .HasColumnName("CREATIONDATE")
                    .HasComputedColumnSql("(CONVERT([date],[ADDDATE]))", true);

                entity.Property(e => e.Creationtime)
                    .HasColumnName("CREATIONTIME")
                    .HasComputedColumnSql("(CONVERT([time],[ADDDATE]))", true);

                entity.Property(e => e.Curcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CURCODE")
                    .IsFixedLength();

                entity.Property(e => e.DirectBranding)
                    .HasMaxLength(15)
                    .HasColumnName("DIRECT_BRANDING");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Entid).HasColumnName("ENTID");

                entity.Property(e => e.InvoiceAddressid).HasColumnName("INVOICE_ADDRESSID");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnType("datetime")
                    .HasColumnName("INVOICE_DATE");

                entity.Property(e => e.InvoiceEmail)
                    .HasMaxLength(200)
                    .HasColumnName("INVOICE_EMAIL");

                entity.Property(e => e.InvoiceFirstname)
                    .HasMaxLength(50)
                    .HasColumnName("INVOICE_FIRSTNAME");

                entity.Property(e => e.InvoiceKind)
                    .HasColumnName("INVOICE_KIND")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.InvoiceLastname)
                    .HasMaxLength(50)
                    .HasColumnName("INVOICE_LASTNAME");

                entity.Property(e => e.InvoiceTaxno)
                    .HasMaxLength(25)
                    .HasColumnName("INVOICE_TAXNO");

                entity.Property(e => e.InvoiceTaxplacename)
                    .HasMaxLength(100)
                    .HasColumnName("INVOICE_TAXPLACENAME");

                entity.Property(e => e.InvoiceTitle)
                    .HasMaxLength(200)
                    .HasColumnName("INVOICE_TITLE");

                entity.Property(e => e.InvoiceType).HasColumnName("INVOICE_TYPE");

                entity.Property(e => e.Iscalltransfer).HasColumnName("ISCALLTRANSFER");

                entity.Property(e => e.Langcode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("LANGCODE")
                    .IsFixedLength();

                entity.Property(e => e.OfferDescription).HasColumnName("OFFER_DESCRIPTION");

                entity.Property(e => e.OfferRules).HasColumnName("OFFER_RULES");

                entity.Property(e => e.OfferText).HasColumnName("OFFER_TEXT");

                entity.Property(e => e.Org).HasColumnName("ORG");

                entity.Property(e => e.Password)
                    .HasMaxLength(10)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.PayAtPlace).HasColumnName("PAY_AT_PLACE");

                entity.Property(e => e.PersonCcardid).HasColumnName("PERSON_CCARDID");

                entity.Property(e => e.Personid).HasColumnName("PERSONID");

                entity.Property(e => e.Posaccountid).HasColumnName("POSACCOUNTID");

                entity.Property(e => e.Posinstalmentid).HasColumnName("POSINSTALMENTID");

                entity.Property(e => e.ProjectDetailid).HasColumnName("PROJECT_DETAILID");

                entity.Property(e => e.ProjectGroupid).HasColumnName("PROJECT_GROUPID");

                entity.Property(e => e.RakamId)
                    .HasMaxLength(15)
                    .HasColumnName("RAKAM_ID");

                entity.Property(e => e.ReqUrl)
                    .HasMaxLength(500)
                    .HasColumnName("REQ_URL");

                entity.Property(e => e.Resno)
                    .HasMaxLength(200)
                    .HasColumnName("RESNO");

                entity.Property(e => e.Resourceid).HasColumnName("RESOURCEID");

                entity.Property(e => e.SellDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SELL_DATE");

                entity.Property(e => e.SellerUserid).HasColumnName("SELLER_USERID");

                entity.Property(e => e.Sellingdate)
                    .HasColumnType("date")
                    .HasColumnName("SELLINGDATE")
                    .HasComputedColumnSql("(CONVERT([date],[SELL_DATE]))", true);

                entity.Property(e => e.Sellingtime)
                    .HasColumnName("SELLINGTIME")
                    .HasComputedColumnSql("(CONVERT([time],[SELL_DATE]))", true);

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Substatus).HasColumnName("SUBSTATUS");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.RequestAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REQUEST_USERS");

                entity.HasOne(d => d.Agency)
                    .WithMany(p => p.Request)
                    .HasForeignKey(d => d.Agencyid)
                    .HasConstraintName("FK__REQUEST__AGENCYI__1BE81D6E");

                entity.HasOne(d => d.Campaign)
                    .WithMany(p => p.Request)
                    .HasForeignKey(d => d.Campaignid)
                    .HasConstraintName("FK__REQUEST__CAMPAIG__1CDC41A7");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.Request)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REQUEST_CORP");

                entity.HasOne(d => d.InvoiceAddress)
                    .WithMany(p => p.Request)
                    .HasForeignKey(d => d.InvoiceAddressid)
                    .HasConstraintName("FK__REQUEST__INVOICE__257C74A0");

                entity.HasOne(d => d.LangcodeNavigation)
                    .WithMany(p => p.Request)
                    .HasForeignKey(d => d.Langcode)
                    .HasConstraintName("FK_REQUEST_STDLANGUAGES");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Request)
                    .HasForeignKey(d => d.Personid)
                    .HasConstraintName("FK_REQUEST_PERSON");

                entity.HasOne(d => d.SellerUser)
                    .WithMany(p => p.RequestSellerUser)
                    .HasForeignKey(d => d.SellerUserid)
                    .HasConstraintName("FK__REQUEST__SELLER___70B3A6A6");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.Request)
                    .HasForeignKey(d => d.Status)
                    .HasConstraintName("FK_REQUEST_REQUEST_STATUS");
            });

            modelBuilder.Entity<RequestClients>(entity =>
            {
                entity.ToTable("REQUEST_CLIENTS");

                entity.HasIndex(e => e.Firstname, "IX_REQUEST_CLIENTS");

                entity.HasIndex(e => e.Lastname, "IX_REQUEST_CLIENTS_1");

                entity.HasIndex(e => e.RequestDetailid, "MISS_IDX_POS_PAYMENTS_LIST");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Birthdate)
                    .HasColumnType("datetime")
                    .HasColumnName("BIRTHDATE");

                entity.Property(e => e.Entid)
                    .HasMaxLength(100)
                    .HasColumnName("ENTID");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(100)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.Gender).HasColumnName("GENDER");

                entity.Property(e => e.Hescode)
                    .HasMaxLength(60)
                    .HasColumnName("HESCODE");

                entity.Property(e => e.Kind).HasColumnName("KIND");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(100)
                    .HasColumnName("LASTNAME");

                entity.Property(e => e.RequestDetailid).HasColumnName("REQUEST_DETAILID");

                entity.HasOne(d => d.RequestDetail)
                    .WithMany(p => p.RequestClients)
                    .HasForeignKey(d => d.RequestDetailid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__REQUEST_C__REQUE__18E19391");
            });

            modelBuilder.Entity<RequestDetail>(entity =>
            {
                entity.ToTable("REQUEST_DETAIL");

                entity.HasIndex(e => e.Kind, "IDX_MIS_DASHBOARD_REPORT");

                entity.HasIndex(e => new { e.Status, e.Roomtypeid, e.Date1 }, "IX_MISSING_HOTELSEARCH1");

                entity.HasIndex(e => new { e.Kind, e.Correlationid }, "IX_RD_KIND_CORRELATIOIN");

                entity.HasIndex(e => new { e.Kind, e.Status }, "IX_RD_KIND_STATUS");

                entity.HasIndex(e => new { e.Kind, e.Sellingdate }, "IX_RECOMMEND_RD_KIND_SELLINGDATE");

                entity.HasIndex(e => new { e.Requestid, e.Kind }, "IX_REQUEST_DETAIL");

                entity.HasIndex(e => new { e.Adduser, e.Edituser, e.Requestid }, "IX_REQUEST_DETAIL_1");

                entity.HasIndex(e => e.DiscountReq, "IX_REQUEST_DETAIL_2");

                entity.HasIndex(e => e.DiscountResult, "IX_REQUEST_DETAIL_3");

                entity.HasIndex(e => e.SellDate, "IX_REQUEST_DETAIL_4");

                entity.HasIndex(e => e.Intid, "IX_REQUEST_DETAIL_5");

                entity.HasIndex(e => new { e.Requestid, e.Adduser, e.Edituser }, "IX_REQUEST_DETAIL_IMP");

                entity.HasIndex(e => e.Kind, "MIS_INDEX_DASHBOARD_SALES_ANALYSIS_1");

                entity.HasIndex(e => e.SwLogid, "MIS_IX_REQUESTID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AdditionalDiscountid).HasColumnName("ADDITIONAL_DISCOUNTID");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Adult).HasColumnName("ADULT");

                entity.Property(e => e.AdultPrice).HasColumnName("ADULT_PRICE");

                entity.Property(e => e.Age1).HasColumnName("AGE1");

                entity.Property(e => e.Age2).HasColumnName("AGE2");

                entity.Property(e => e.Age3).HasColumnName("AGE3");

                entity.Property(e => e.Age4).HasColumnName("AGE4");

                entity.Property(e => e.Baby).HasColumnName("BABY");

                entity.Property(e => e.Bedcount).HasColumnName("BEDCOUNT");

                entity.Property(e => e.Boardtype)
                    .HasMaxLength(100)
                    .HasColumnName("BOARDTYPE");

                entity.Property(e => e.Boardtypeid).HasColumnName("BOARDTYPEID");

                entity.Property(e => e.BonusTotal).HasColumnName("BONUS_TOTAL");

                entity.Property(e => e.Campaignid).HasColumnName("CAMPAIGNID");

                entity.Property(e => e.CancelationDays).HasColumnName("CANCELATION_DAYS");

                entity.Property(e => e.CancelationRate).HasColumnName("CANCELATION_RATE");

                entity.Property(e => e.CancellationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CANCELLATION_DATE");

                entity.Property(e => e.CancellationUserid).HasColumnName("CANCELLATION_USERID");

                entity.Property(e => e.CancellationWarrantyRate).HasColumnName("CANCELLATION_WARRANTY_RATE");

                entity.Property(e => e.Cancellationid)
                    .HasMaxLength(50)
                    .HasColumnName("CANCELLATIONID");

                entity.Property(e => e.Chd1).HasColumnName("CHD1");

                entity.Property(e => e.Chd1Birthdate)
                    .HasColumnType("date")
                    .HasColumnName("CHD1_BIRTHDATE");

                entity.Property(e => e.Chd2).HasColumnName("CHD2");

                entity.Property(e => e.Chd2Birthdate)
                    .HasColumnType("date")
                    .HasColumnName("CHD2_BIRTHDATE");

                entity.Property(e => e.Chd3Birthdate)
                    .HasColumnType("date")
                    .HasColumnName("CHD3_BIRTHDATE");

                entity.Property(e => e.Chd4Birthdate)
                    .HasColumnType("date")
                    .HasColumnName("CHD4_BIRTHDATE");

                entity.Property(e => e.ChdPrice).HasColumnName("CHD_PRICE");

                entity.Property(e => e.Chde).HasColumnName("CHDE");

                entity.Property(e => e.Chdy).HasColumnName("CHDY");

                entity.Property(e => e.Childages)
                    .HasMaxLength(40)
                    .HasColumnName("CHILDAGES");

                entity.Property(e => e.ContractPrice).HasColumnName("CONTRACT_PRICE");

                entity.Property(e => e.Correlationid).HasColumnName("CORRELATIONID");

                entity.Property(e => e.Country)
                    .HasMaxLength(120)
                    .HasColumnName("COUNTRY");

                entity.Property(e => e.Creationdate)
                    .HasColumnType("date")
                    .HasColumnName("CREATIONDATE")
                    .HasComputedColumnSql("(CONVERT([date],[ADDDATE]))", true);

                entity.Property(e => e.Creationtime)
                    .HasColumnName("CREATIONTIME")
                    .HasComputedColumnSql("(CONVERT([time],[ADDDATE]))", true);

                entity.Property(e => e.Curcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CURCODE")
                    .IsFixedLength();

                entity.Property(e => e.Currate).HasColumnName("CURRATE");

                entity.Property(e => e.Date1)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE1");

                entity.Property(e => e.Date2)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE2");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.DiscountCombination)
                    .HasMaxLength(150)
                    .HasColumnName("DISCOUNT_COMBINATION");

                entity.Property(e => e.DiscountDescription)
                    .HasMaxLength(250)
                    .HasColumnName("DISCOUNT_DESCRIPTION");

                entity.Property(e => e.DiscountPercent).HasColumnName("DISCOUNT_PERCENT");

                entity.Property(e => e.DiscountRate).HasColumnName("DISCOUNT_RATE");

                entity.Property(e => e.DiscountReq)
                    .HasColumnName("DISCOUNT_REQ")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiscountResult).HasColumnName("DISCOUNT_RESULT");

                entity.Property(e => e.DiscountResultdesc)
                    .HasMaxLength(250)
                    .HasColumnName("DISCOUNT_RESULTDESC");

                entity.Property(e => e.DiscountTotal)
                    .HasColumnName("DISCOUNT_TOTAL")
                    .HasComputedColumnSql("(case when [DISCOUNT_RESULT]=(1) AND [DISCOUNT_RATE]>(0) then case [DISCOUNT_REQ] when (1) then CONVERT([float],isnull([TOTAL],(0))+isnull([EXTRA_TOTAL],(0)))*(CONVERT([float],[DISCOUNT_RATE])/(100.0)) when (2) then [DISCOUNT_RATE] when (3) then (isnull([TOTAL],(0))+isnull([EXTRA_TOTAL],(0)))-[DISCOUNT_RATE] else (0) end else (0) end)", true);

                entity.Property(e => e.EBoardtypeid)
                    .HasMaxLength(25)
                    .HasColumnName("E_BOARDTYPEID");

                entity.Property(e => e.ERoomtypeid)
                    .HasMaxLength(25)
                    .HasColumnName("E_ROOMTYPEID");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Entid).HasColumnName("ENTID");

                entity.Property(e => e.Extnotes)
                    .HasMaxLength(250)
                    .HasColumnName("EXTNOTES");

                entity.Property(e => e.Extra).HasColumnName("EXTRA");

                entity.Property(e => e.ExtraTotal).HasColumnName("EXTRA_TOTAL");

                entity.Property(e => e.Finalprices)
                    .HasMaxLength(350)
                    .HasColumnName("FINALPRICES");

                entity.Property(e => e.Fromlocationid).HasColumnName("FROMLOCATIONID");

                entity.Property(e => e.GrandTotal)
                    .HasColumnName("GRAND_TOTAL")
                    .HasComputedColumnSql("((isnull([TOTAL],(0))+isnull([EXTRA_TOTAL],(0)))-case when [DISCOUNT_RESULT]=(1) AND [DISCOUNT_RATE]>(0) then case [DISCOUNT_REQ] when (1) then CONVERT([float],isnull([TOTAL],(0))+isnull([EXTRA_TOTAL],(0)))*(CONVERT([float],[DISCOUNT_RATE])/(100.0)) when (2) then [DISCOUNT_RATE] when (3) then (isnull([TOTAL],(0))+isnull([EXTRA_TOTAL],(0)))-[DISCOUNT_RATE] else (0) end else (0) end)", true);

                entity.Property(e => e.Hotelid).HasColumnName("HOTELID");

                entity.Property(e => e.Icon)
                    .HasMaxLength(250)
                    .HasColumnName("ICON");

                entity.Property(e => e.InterviewDate)
                    .HasColumnType("datetime")
                    .HasColumnName("INTERVIEW_DATE");

                entity.Property(e => e.Intid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("INTID");

                entity.Property(e => e.InvoiceEntid).HasColumnName("INVOICE_ENTID");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(25)
                    .HasColumnName("IPADDRESS");

                entity.Property(e => e.Isnotavailable)
                    .HasColumnName("ISNOTAVAILABLE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Kind).HasColumnName("KIND");

                entity.Property(e => e.ManualPrice)
                    .HasMaxLength(50)
                    .HasColumnName("MANUAL_PRICE");

                entity.Property(e => e.Marketid).HasColumnName("MARKETID");

                entity.Property(e => e.MenAccommodationForbidden).HasColumnName("MEN_ACCOMMODATION_FORBIDDEN");

                entity.Property(e => e.National)
                    .HasMaxLength(10)
                    .HasColumnName("NATIONAL");

                entity.Property(e => e.PaymentRate).HasColumnName("PAYMENT_RATE");

                entity.Property(e => e.Pnr1)
                    .HasMaxLength(15)
                    .HasColumnName("PNR1");

                entity.Property(e => e.Pnr2)
                    .HasMaxLength(15)
                    .HasColumnName("PNR2");

                entity.Property(e => e.Possibility).HasColumnName("POSSIBILITY");

                entity.Property(e => e.PriceConditionid).HasColumnName("PRICE_CONDITIONID");

                entity.Property(e => e.Productid)
                    .HasColumnName("PRODUCTID")
                    .HasComputedColumnSql("(coalesce([HOTELID],[TOURID],[TICKETID],[TICKETGIFTID],[TRANSFER_PRICEID]))", false);

                entity.Property(e => e.ProjectDetailid).HasColumnName("PROJECT_DETAILID");

                entity.Property(e => e.Promotionid).HasColumnName("PROMOTIONID");

                entity.Property(e => e.Quantity).HasColumnName("QUANTITY");

                entity.Property(e => e.Ratecodeid).HasColumnName("RATECODEID");

                entity.Property(e => e.Ratetypeid).HasColumnName("RATETYPEID");

                entity.Property(e => e.Requestid).HasColumnName("REQUESTID");

                entity.Property(e => e.ReservationSettingsid).HasColumnName("RESERVATION_SETTINGSID");

                entity.Property(e => e.Resno)
                    .HasMaxLength(50)
                    .HasColumnName("RESNO");

                entity.Property(e => e.Resourceid).HasColumnName("RESOURCEID");

                entity.Property(e => e.Roomcount).HasColumnName("ROOMCOUNT");

                entity.Property(e => e.Roomtype)
                    .HasMaxLength(60)
                    .HasColumnName("ROOMTYPE");

                entity.Property(e => e.Roomtypeid).HasColumnName("ROOMTYPEID");

                entity.Property(e => e.Roundtrip)
                    .IsRequired()
                    .HasColumnName("ROUNDTRIP")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SellDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SELL_DATE");

                entity.Property(e => e.SellerUserid).HasColumnName("SELLER_USERID");

                entity.Property(e => e.Sellingdate)
                    .HasColumnType("date")
                    .HasColumnName("SELLINGDATE")
                    .HasComputedColumnSql("(CONVERT([date],[SELL_DATE]))", true);

                entity.Property(e => e.Sellingtime)
                    .HasColumnName("SELLINGTIME")
                    .HasComputedColumnSql("(CONVERT([time],[SELL_DATE]))", true);

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Substatus).HasColumnName("SUBSTATUS");

                entity.Property(e => e.SwLogid).HasColumnName("SW_LOGID");

                entity.Property(e => e.TicketPriceid).HasColumnName("TICKET_PRICEID");

                entity.Property(e => e.Ticketgiftid).HasColumnName("TICKETGIFTID");

                entity.Property(e => e.Ticketid).HasColumnName("TICKETID");

                entity.Property(e => e.Tolocationid).HasColumnName("TOLOCATIONID");

                entity.Property(e => e.Total)
                    .HasColumnName("TOTAL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tourid).HasColumnName("TOURID");

                entity.Property(e => e.TransferPriceid).HasColumnName("TRANSFER_PRICEID");

                entity.Property(e => e.UseInoffer)
                    .HasColumnName("USE_INOFFER")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Validdate)
                    .HasColumnType("datetime")
                    .HasColumnName("VALIDDATE")
                    .HasComputedColumnSql("(dateadd(day,[VALIDDAY],[ADDDATE]))", true);

                entity.Property(e => e.Validday)
                    .HasColumnName("VALIDDAY")
                    .HasDefaultValueSql("((3))");

                entity.Property(e => e.Vehicleid).HasColumnName("VEHICLEID");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.RequestDetailAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REQUEST_D__ADDUS__73501C2F");

                entity.HasOne(d => d.BoardtypeNavigation)
                    .WithMany(p => p.RequestDetail)
                    .HasForeignKey(d => d.Boardtypeid)
                    .HasConstraintName("FK__REQUEST_D__BOARD__265B8A40");

                entity.HasOne(d => d.Campaign)
                    .WithMany(p => p.RequestDetail)
                    .HasForeignKey(d => d.Campaignid)
                    .HasConstraintName("FK__REQUEST_D__CAMPA__2C538F61");

                entity.HasOne(d => d.CancellationUser)
                    .WithMany(p => p.RequestDetailCancellationUser)
                    .HasForeignKey(d => d.CancellationUserid)
                    .HasConstraintName("FK_REQUEST_DETAIL_USERS");

                entity.HasOne(d => d.Correlation)
                    .WithMany(p => p.InverseCorrelation)
                    .HasForeignKey(d => d.Correlationid)
                    .HasConstraintName("FK__REQUEST_D__CORRE__274FAE79");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.RequestDetailEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__REQUEST_D__EDITU__753864A1");

                entity.HasOne(d => d.Hotel)
                    .WithMany(p => p.RequestDetail)
                    .HasForeignKey(d => d.Hotelid)
                    .HasConstraintName("FK__REQUEST_D__HOTEL__7167D3BD");

                entity.HasOne(d => d.Market)
                    .WithMany(p => p.RequestDetail)
                    .HasForeignKey(d => d.Marketid)
                    .HasConstraintName("FK__REQUEST_D__MARKE__2843D2B2");

                entity.HasOne(d => d.PriceCondition)
                    .WithMany(p => p.RequestDetail)
                    .HasForeignKey(d => d.PriceConditionid)
                    .HasConstraintName("FK__REQUEST_D__PRICE__652CE561");

                entity.HasOne(d => d.ProjectDetail)
                    .WithMany(p => p.RequestDetail)
                    .HasForeignKey(d => d.ProjectDetailid)
                    .HasConstraintName("FK__REQUEST_D__PROJE__5B638405");

                entity.HasOne(d => d.Promotion)
                    .WithMany(p => p.RequestDetail)
                    .HasForeignKey(d => d.Promotionid)
                    .HasConstraintName("FK__REQUEST_D__PROMO__1E7A7156");

                entity.HasOne(d => d.Ratecode)
                    .WithMany(p => p.RequestDetail)
                    .HasForeignKey(d => d.Ratecodeid)
                    .HasConstraintName("FK__REQUEST_D__RATEC__2937F6EB");

                entity.HasOne(d => d.Ratetype)
                    .WithMany(p => p.RequestDetail)
                    .HasForeignKey(d => d.Ratetypeid)
                    .HasConstraintName("FK__REQUEST_D__RATET__530E3526");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.RequestDetail)
                    .HasForeignKey(d => d.Requestid)
                    .HasConstraintName("FK__REQUEST_D__REQUE__7073AF84");

                entity.HasOne(d => d.ReservationSettings)
                    .WithMany(p => p.RequestDetail)
                    .HasForeignKey(d => d.ReservationSettingsid)
                    .HasConstraintName("FK__REQUEST_D__RESER__6418C597");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.RequestDetail)
                    .HasForeignKey(d => d.Resourceid)
                    .HasConstraintName("FK__REQUEST_D__RESOU__4C214075");

                entity.HasOne(d => d.RoomtypeNavigation)
                    .WithMany(p => p.RequestDetail)
                    .HasForeignKey(d => d.Roomtypeid)
                    .HasConstraintName("FK__REQUEST_D__ROOMT__2A2C1B24");

                entity.HasOne(d => d.SellerUser)
                    .WithMany(p => p.RequestDetailSellerUser)
                    .HasForeignKey(d => d.SellerUserid)
                    .HasConstraintName("FK__REQUEST_D__SELLE__2B203F5D");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.RequestDetailStatusNavigation)
                    .HasForeignKey(d => d.Status)
                    .HasConstraintName("FK__REQUEST_D__STATU__05A3D694");

                entity.HasOne(d => d.SubstatusNavigation)
                    .WithMany(p => p.RequestDetailSubstatusNavigation)
                    .HasForeignKey(d => d.Substatus)
                    .HasConstraintName("FK__REQUEST_D__SUBST__0697FACD");

                entity.HasOne(d => d.TicketPrice)
                    .WithMany(p => p.RequestDetail)
                    .HasForeignKey(d => d.TicketPriceid)
                    .HasConstraintName("FK__REQUEST_D__TICKE__2C146396");

                entity.HasOne(d => d.Ticketgift)
                    .WithMany(p => p.RequestDetail)
                    .HasForeignKey(d => d.Ticketgiftid)
                    .HasConstraintName("FK__REQUEST_D__TICKE__2D0887CF");

                entity.HasOne(d => d.Ticket)
                    .WithMany(p => p.RequestDetail)
                    .HasForeignKey(d => d.Ticketid)
                    .HasConstraintName("FK__REQUEST_D__TICKE__2DFCAC08");

                entity.HasOne(d => d.Tour)
                    .WithMany(p => p.RequestDetail)
                    .HasForeignKey(d => d.Tourid)
                    .HasConstraintName("FK__REQUEST_D__TOURI__1F798287");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.RequestDetail)
                    .HasForeignKey(d => d.Vehicleid)
                    .HasConstraintName("FK__REQUEST_D__VEHIC__40106F4B");
            });

            modelBuilder.Entity<RequestDetailOrgdata>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__REQUEST___3214EC267DBA7FEF")
                    .IsClustered(false);

                entity.ToTable("REQUEST_DETAIL_ORGDATA");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Jsondata).HasColumnName("JSONDATA");

                entity.Property(e => e.RequestDetailid).HasColumnName("REQUEST_DETAILID");

                entity.HasOne(d => d.RequestDetail)
                    .WithMany(p => p.RequestDetailOrgdata)
                    .HasForeignKey(d => d.RequestDetailid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REQUEST_D__REQUE__26667738");
            });

            modelBuilder.Entity<RequestNotes>(entity =>
            {
                entity.ToTable("REQUEST_NOTES");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.Nottype).HasColumnName("NOTTYPE");

                entity.Property(e => e.RequestDetailid).HasColumnName("REQUEST_DETAILID");

                entity.Property(e => e.Requestid).HasColumnName("REQUESTID");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.RequestNotesAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REQUEST_N__ADDUS__78BEDCC2");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.RequestNotesEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK_REQUEST_NOTES_USERS");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.RequestNotes)
                    .HasForeignKey(d => d.Requestid)
                    .HasConstraintName("FK__REQUEST_N__REQUE__76D69450");
            });

            modelBuilder.Entity<RequestPayments>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__REQUEST___3214EC2642FAFE10")
                    .IsClustered(false);

                entity.ToTable("REQUEST_PAYMENTS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CancelRate).HasColumnName("CANCEL_RATE");

                entity.Property(e => e.Entid)
                    .HasMaxLength(150)
                    .HasColumnName("ENTID");

                entity.Property(e => e.Paymentid).HasColumnName("PAYMENTID");

                entity.Property(e => e.Rate).HasColumnName("RATE");

                entity.Property(e => e.RequestDetailid).HasColumnName("REQUEST_DETAILID");

                entity.Property(e => e.VirtualPosDepPaymentCancelid).HasColumnName("VIRTUAL_POS_DEP_PAYMENT_CANCELID");

                entity.Property(e => e.VirtualPosDepPaymentid).HasColumnName("VIRTUAL_POS_DEP_PAYMENTID");

                entity.Property(e => e.VirtualPosPaymentCancelid).HasColumnName("VIRTUAL_POS_PAYMENT_CANCELID");

                entity.Property(e => e.VirtualPosPaymentid).HasColumnName("VIRTUAL_POS_PAYMENTID");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.RequestPayments)
                    .HasForeignKey(d => d.Paymentid)
                    .HasConstraintName("FK_REQUEST_PAYMENTS_PAYMENTS");

                entity.HasOne(d => d.RequestDetail)
                    .WithMany(p => p.RequestPayments)
                    .HasForeignKey(d => d.RequestDetailid)
                    .HasConstraintName("FK__REQUEST_P__REQUE__43E1002F");

                entity.HasOne(d => d.VirtualPosDepPaymentCancel)
                    .WithMany(p => p.RequestPayments)
                    .HasForeignKey(d => d.VirtualPosDepPaymentCancelid)
                    .HasConstraintName("FK__REQUEST_P__VIRTU__2764BD12");

                entity.HasOne(d => d.VirtualPosDepPayment)
                    .WithMany(p => p.RequestPayments)
                    .HasForeignKey(d => d.VirtualPosDepPaymentid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__REQUEST_P__VIRTU__31233176");

                entity.HasOne(d => d.VirtualPosPaymentCancel)
                    .WithMany(p => p.RequestPayments)
                    .HasForeignKey(d => d.VirtualPosPaymentCancelid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__REQUEST_P__VIRTU__267098D9");

                entity.HasOne(d => d.VirtualPosPayment)
                    .WithMany(p => p.RequestPayments)
                    .HasForeignKey(d => d.VirtualPosPaymentid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__REQUEST_P__VIRTU__44D52468");
            });

            modelBuilder.Entity<RequestStatus>(entity =>
            {
                entity.ToTable("REQUEST_STATUS");

                entity.HasIndex(e => e.Substatus, "IX_REQUEST_STATUS");

                entity.HasIndex(e => e.Type, "IX_REQUEST_STATUS_1");

                entity.HasIndex(e => e.Sortorder, "IX_REQUEST_STATUS_2");

                entity.HasIndex(e => new { e.Sortorder, e.Type }, "IX_REQUEST_STATUS_3");

                entity.HasIndex(e => new { e.Substatus, e.Type }, "IX_REQUEST_STATUS_4");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AllowedSubstatus)
                    .HasMaxLength(20)
                    .HasColumnName("ALLOWED_SUBSTATUS");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.RakamId)
                    .HasMaxLength(15)
                    .HasColumnName("RAKAM_ID");

                entity.Property(e => e.RakamType).HasColumnName("RAKAM_TYPE");

                entity.Property(e => e.Sortorder).HasColumnName("SORTORDER");

                entity.Property(e => e.Substatus)
                    .HasColumnName("SUBSTATUS")
                    .HasComment("0=Active,1=Pasive");

                entity.Property(e => e.Type).HasColumnName("TYPE");
            });

            modelBuilder.Entity<RequestYdk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("REQUEST_YDK");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Campaigncode)
                    .HasMaxLength(100)
                    .HasColumnName("CAMPAIGNCODE");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Creationdate)
                    .HasColumnType("date")
                    .HasColumnName("CREATIONDATE");

                entity.Property(e => e.Creationtime).HasColumnName("CREATIONTIME");

                entity.Property(e => e.Curcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CURCODE")
                    .IsFixedLength();

                entity.Property(e => e.DirectBranding)
                    .HasMaxLength(15)
                    .HasColumnName("DIRECT_BRANDING");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Iscalltransfer).HasColumnName("ISCALLTRANSFER");

                entity.Property(e => e.Org).HasColumnName("ORG");

                entity.Property(e => e.PersonCcardid).HasColumnName("PERSON_CCARDID");

                entity.Property(e => e.Personid).HasColumnName("PERSONID");

                entity.Property(e => e.Posaccountid).HasColumnName("POSACCOUNTID");

                entity.Property(e => e.Posinstalmentid).HasColumnName("POSINSTALMENTID");

                entity.Property(e => e.ProjectDetailid).HasColumnName("PROJECT_DETAILID");

                entity.Property(e => e.ProjectGroupid).HasColumnName("PROJECT_GROUPID");

                entity.Property(e => e.RakamId)
                    .HasMaxLength(15)
                    .HasColumnName("RAKAM_ID");

                entity.Property(e => e.ReqUrl)
                    .HasMaxLength(500)
                    .HasColumnName("REQ_URL");

                entity.Property(e => e.Resno)
                    .HasMaxLength(200)
                    .HasColumnName("RESNO");

                entity.Property(e => e.Resourceid).HasColumnName("RESOURCEID");

                entity.Property(e => e.SellDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SELL_DATE");

                entity.Property(e => e.SellerUserid).HasColumnName("SELLER_USERID");

                entity.Property(e => e.Sellingdate)
                    .HasColumnType("date")
                    .HasColumnName("SELLINGDATE");

                entity.Property(e => e.Sellingtime).HasColumnName("SELLINGTIME");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Substatus).HasColumnName("SUBSTATUS");
            });

            modelBuilder.Entity<ReservationEmails>(entity =>
            {
                entity.ToTable("RESERVATION_EMAILS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BccEmails)
                    .HasMaxLength(500)
                    .HasColumnName("BCC_EMAILS");

                entity.Property(e => e.CcEmails)
                    .HasMaxLength(500)
                    .HasColumnName("CC_EMAILS");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Productid).HasColumnName("PRODUCTID");

                entity.Property(e => e.ProjectDetailid).HasColumnName("PROJECT_DETAILID");

                entity.Property(e => e.ToEmails)
                    .HasMaxLength(500)
                    .HasColumnName("TO_EMAILS");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.ReservationEmails)
                    .HasForeignKey(d => d.Corpid)
                    .HasConstraintName("FK__RESERVATI__CORPI__38845C1C");

                entity.HasOne(d => d.ProjectDetail)
                    .WithMany(p => p.ReservationEmails)
                    .HasForeignKey(d => d.ProjectDetailid)
                    .HasConstraintName("FK__RESERVATI__PROJE__39788055");
            });

            modelBuilder.Entity<ReservationRules>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__RESERVAT__3214EC267337F112")
                    .IsClustered(false);

                entity.ToTable("RESERVATION_RULES");

                entity.HasIndex(e => e.ProjectDetailid, "UQ__RESERVAT__2639F4EA0E443A89")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.GeneralRules)
                    .HasColumnType("ntext")
                    .HasColumnName("GENERAL_RULES");

                entity.Property(e => e.ProjectDetailid).HasColumnName("PROJECT_DETAILID");

                entity.Property(e => e.RefundRules)
                    .HasColumnType("ntext")
                    .HasColumnName("REFUND_RULES");

                entity.HasOne(d => d.ProjectDetail)
                    .WithOne(p => p.ReservationRules)
                    .HasForeignKey<ReservationRules>(d => d.ProjectDetailid)
                    .HasConstraintName("FK__RESERVATI__PROJE__22A007F5");
            });

            modelBuilder.Entity<ReservationSettings>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__RESERVAT__3214EC26B5F16E6C")
                    .IsClustered(false);

                entity.ToTable("RESERVATION_SETTINGS");

                entity.HasIndex(e => new { e.Startdate, e.Finishdate }, "IX_RESERVATION_SETTINGS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.CancelationDays).HasColumnName("CANCELATION_DAYS");

                entity.Property(e => e.CancelationDescription).HasColumnName("CANCELATION_DESCRIPTION");

                entity.Property(e => e.CancelationRate).HasColumnName("CANCELATION_RATE");

                entity.Property(e => e.CancellationWarrantyRate).HasColumnName("CANCELLATION_WARRANTY_RATE");

                entity.Property(e => e.CancellationWarrantyRateMaxDay)
                    .HasColumnName("CANCELLATION_WARRANTY_RATE_MAX_DAY")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ChildrenAccommodationForbidden).HasColumnName("CHILDREN_ACCOMMODATION_FORBIDDEN");

                entity.Property(e => e.ChildrenMaxage).HasColumnName("CHILDREN_MAXAGE");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Finishdate)
                    .HasColumnType("datetime")
                    .HasColumnName("FINISHDATE");

                entity.Property(e => e.Hotelid).HasColumnName("HOTELID");

                entity.Property(e => e.MenAccommodationForbidden).HasColumnName("MEN_ACCOMMODATION_FORBIDDEN");

                entity.Property(e => e.PaymentRate).HasColumnName("PAYMENT_RATE");

                entity.Property(e => e.PaymentRateMaxDay)
                    .HasColumnName("PAYMENT_RATE_MAX_DAY")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Startdate)
                    .HasColumnType("datetime")
                    .HasColumnName("STARTDATE");

                entity.Property(e => e.Ticketid).HasColumnName("TICKETID");

                entity.Property(e => e.Tourid).HasColumnName("TOURID");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.ReservationSettings)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RESERVATI__ADDUS__66010E09");

                entity.HasOne(d => d.Hotel)
                    .WithMany(p => p.ReservationSettings)
                    .HasForeignKey(d => d.Hotelid)
                    .HasConstraintName("FK__RESERVATI__HOTEL__5A8F5B5D");

                entity.HasOne(d => d.Ticket)
                    .WithMany(p => p.ReservationSettings)
                    .HasForeignKey(d => d.Ticketid)
                    .HasConstraintName("FK__RESERVATI__TICKE__5C77A3CF");

                entity.HasOne(d => d.Tour)
                    .WithMany(p => p.ReservationSettings)
                    .HasForeignKey(d => d.Tourid)
                    .HasConstraintName("FK__RESERVATI__TOURI__5B837F96");
            });

            modelBuilder.Entity<ReservationSettingsMarket>(entity =>
            {
                entity.ToTable("RESERVATION_SETTINGS_MARKET");

                entity.HasIndex(e => new { e.Settingsid, e.Marketid }, "UQ__RESERVATION_SETTINGS__4B96FBB176D8588E")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Marketid).HasColumnName("MARKETID");

                entity.Property(e => e.Settingsid).HasColumnName("SETTINGSID");

                entity.HasOne(d => d.Market)
                    .WithMany(p => p.ReservationSettingsMarket)
                    .HasForeignKey(d => d.Marketid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RESERVATION_SETTINGS___MARKE__54D68207");

                entity.HasOne(d => d.Settings)
                    .WithMany(p => p.ReservationSettingsMarket)
                    .HasForeignKey(d => d.Settingsid)
                    .HasConstraintName("FK__RESERVATION_SETTINGS___DISCO__53E25DCE");
            });

            modelBuilder.Entity<ResourceBudget>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RESOURCE_BUDGET");

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Curcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CURCODE")
                    .IsFixedLength();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.IncomeAmount)
                    .HasColumnName("INCOME_AMOUNT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProjectDetailid).HasColumnName("PROJECT_DETAILID");

                entity.Property(e => e.Ramount).HasColumnName("RAMOUNT");

                entity.Property(e => e.Resourceid).HasColumnName("RESOURCEID");

                entity.Property(e => e.Tdate)
                    .HasColumnType("date")
                    .HasColumnName("TDATE");

                entity.HasOne(d => d.Corp)
                    .WithMany()
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RESOURCE___CORPI__3B60C8C7");

                entity.HasOne(d => d.ProjectDetail)
                    .WithMany()
                    .HasForeignKey(d => d.ProjectDetailid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RESOURCE___PROJE__3C89F72A");

                entity.HasOne(d => d.Resource)
                    .WithMany()
                    .HasForeignKey(d => d.Resourceid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RESOURCE___RESOU__3AA1AEB8");
            });

            modelBuilder.Entity<ResourceDetail>(entity =>
            {
                entity.ToTable("RESOURCE_DETAIL");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Description)
                    .HasMaxLength(150)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Detail)
                    .HasMaxLength(150)
                    .HasColumnName("DETAIL");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.ProjectGroupdetailid).HasColumnName("PROJECT_GROUPDETAILID");

                entity.Property(e => e.Resourceid).HasColumnName("RESOURCEID");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.ResourceDetailAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RESOURCE___ADDUS__08B54D69");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.ResourceDetail)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RESOURCE___CORPI__3B40CD36");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.ResourceDetailEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__RESOURCE___EDITU__0A9D95DB");

                entity.HasOne(d => d.ProjectGroupdetail)
                    .WithMany(p => p.ResourceDetail)
                    .HasForeignKey(d => d.ProjectGroupdetailid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RESOURCE___PROJE__3D2915A8");
            });

            modelBuilder.Entity<Resources>(entity =>
            {
                entity.ToTable("RESOURCES");

                entity.HasIndex(e => new { e.Code, e.Corpid }, "IX_RESOURCES")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Code)
                    .HasMaxLength(30)
                    .HasColumnName("CODE");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.CostBudget).HasColumnName("COST_BUDGET");

                entity.Property(e => e.DefaultDirectBranding)
                    .HasMaxLength(15)
                    .HasColumnName("DEFAULT_DIRECT_BRANDING");

                entity.Property(e => e.Description)
                    .HasMaxLength(150)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Icon)
                    .HasMaxLength(35)
                    .HasColumnName("ICON");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Masterid).HasColumnName("MASTERID");

                entity.Property(e => e.RakamDesc)
                    .HasMaxLength(50)
                    .HasColumnName("RAKAM_DESC");

                entity.Property(e => e.Resourcespath)
                    .HasMaxLength(500)
                    .HasColumnName("RESOURCESPATH")
                    .HasComputedColumnSql("([DBO].[FN_RESOURCE_PATH]([CODE],[CORPID]))", false);

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.ResourcesAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RESOURCES__ADDUS__70DDC3D8");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.Resources)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RESOURCES_CORP");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.ResourcesEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__RESOURCES__EDITU__72C60C4A");
            });

            modelBuilder.Entity<RoleAuth>(entity =>
            {
                entity.ToTable("ROLE_AUTH");

                entity.HasIndex(e => new { e.Roleid, e.Modulename }, "IX_ROLE_AUTH")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Canadd).HasColumnName("CANADD");

                entity.Property(e => e.Candelete).HasColumnName("CANDELETE");

                entity.Property(e => e.Canedit).HasColumnName("CANEDIT");

                entity.Property(e => e.Canexport).HasColumnName("CANEXPORT");

                entity.Property(e => e.Canlist).HasColumnName("CANLIST");

                entity.Property(e => e.Canprint).HasColumnName("CANPRINT");

                entity.Property(e => e.Canview).HasColumnName("CANVIEW");

                entity.Property(e => e.Modulename)
                    .HasMaxLength(150)
                    .HasColumnName("MODULENAME");

                entity.Property(e => e.Roleid).HasColumnName("ROLEID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleAuth)
                    .HasForeignKey(d => d.Roleid)
                    .HasConstraintName("FK__ROLE_AUTH__ROLEI__40F9A68C");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.ToTable("ROLES");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Moduleid).HasColumnName("MODULEID");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.RolesAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ROLES__ADDUSER__412EB0B6");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.Roles)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ROLES_CORP");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.RolesEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__ROLES__EDITUSER__4316F928");
            });

            modelBuilder.Entity<RolesCustomauth>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("ROLES_CUSTOMAUTH");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreditcardAdmin).HasColumnName("CREDITCARD_ADMIN");

                entity.Property(e => e.DiscountAdmin).HasColumnName("DISCOUNT_ADMIN");

                entity.Property(e => e.Roleid).HasColumnName("ROLEID");
            });

            modelBuilder.Entity<RolesDashboards>(entity =>
            {
                entity.ToTable("ROLES_DASHBOARDS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Allow).HasColumnName("ALLOW");

                entity.Property(e => e.Dashboardid).HasColumnName("DASHBOARDID");

                entity.Property(e => e.Roleid).HasColumnName("ROLEID");

                entity.HasOne(d => d.Dashboard)
                    .WithMany(p => p.RolesDashboards)
                    .HasForeignKey(d => d.Dashboardid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ROLES_DAS__DASHB__4A38F803");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RolesDashboards)
                    .HasForeignKey(d => d.Roleid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ROLES_DAS__ROLEI__4944D3CA");
            });

            modelBuilder.Entity<SalesReq>(entity =>
            {
                entity.ToTable("SALES_REQ");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Personid).HasColumnName("PERSONID");

                entity.Property(e => e.ResourceDetailid).HasColumnName("RESOURCE_DETAILID");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.SalesReqAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SALES_REQ__ADDUS__282DF8C2");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.SalesReqEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__SALES_REQ__EDITU__2A164134");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.SalesReq)
                    .HasForeignKey(d => d.Personid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SALES_REQ__PERSO__25518C17");

                entity.HasOne(d => d.ResourceDetail)
                    .WithMany(p => p.SalesReq)
                    .HasForeignKey(d => d.ResourceDetailid)
                    .HasConstraintName("FK__SALES_REQ__RESOU__4AA30C57");
            });

            modelBuilder.Entity<Sil>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SIL");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.DialCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dial_code");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Isocode2)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ISOCODE2")
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<SmsMessage>(entity =>
            {
                entity.ToTable("SMS_MESSAGE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Issent).HasColumnName("ISSENT");

                entity.Property(e => e.Messagebody)
                    .HasMaxLength(400)
                    .HasColumnName("MESSAGEBODY");

                entity.Property(e => e.Numbers).HasColumnName("NUMBERS");

                entity.Property(e => e.RequestDetailid).HasColumnName("REQUEST_DETAILID");

                entity.Property(e => e.Senddate)
                    .HasColumnType("datetime")
                    .HasColumnName("SENDDATE");

                entity.Property(e => e.Senderror)
                    .HasMaxLength(250)
                    .HasColumnName("SENDERROR");

                entity.Property(e => e.Smsid).HasColumnName("SMSID");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.RequestDetail)
                    .WithMany(p => p.SmsMessage)
                    .HasForeignKey(d => d.RequestDetailid)
                    .HasConstraintName("FK__SMS_MAIL__REQUE__3A6282ED");

                entity.HasOne(d => d.Sms)
                    .WithMany(p => p.SmsMessage)
                    .HasForeignKey(d => d.Smsid)
                    .HasConstraintName("FK__SMS_MESSA__SMSID__4E739D3B");
            });

            modelBuilder.Entity<SmsSettings>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__SMS_SETT__3214EC268E118F99")
                    .IsClustered(false);

                entity.ToTable("SMS_SETTINGS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.Param)
                    .HasMaxLength(100)
                    .HasColumnName("PARAM");

                entity.Property(e => e.Pass)
                    .HasMaxLength(100)
                    .HasColumnName("PASS");

                entity.Property(e => e.ProjectDetailid).HasColumnName("PROJECT_DETAILID");

                entity.Property(e => e.Projectid).HasColumnName("PROJECTID");

                entity.Property(e => e.Sender)
                    .HasMaxLength(100)
                    .HasColumnName("SENDER");

                entity.Property(e => e.Smsclassname)
                    .HasMaxLength(100)
                    .HasColumnName("SMSCLASSNAME");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("USERNAME");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.SmsSettingsAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SMS_SETTI__ADDUS__03E676AB");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.SmsSettings)
                    .HasForeignKey(d => d.Corpid)
                    .HasConstraintName("FK__SMS_SETTI__CORPI__04DA9AE4");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.SmsSettingsEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__SMS_SETTI__EDITU__05CEBF1D");

                entity.HasOne(d => d.ProjectDetail)
                    .WithMany(p => p.SmsSettings)
                    .HasForeignKey(d => d.ProjectDetailid)
                    .HasConstraintName("FK__SMS_SETT__PROJE__3C5FD9F8");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.SmsSettings)
                    .HasForeignKey(d => d.Projectid)
                    .HasConstraintName("FK__SMS_SETT__PROJE__3B6BB5BF");
            });

            modelBuilder.Entity<SmtpMails>(entity =>
            {
                entity.ToTable("SMTP_MAILS");

                entity.HasIndex(e => e.Senddate, "IX_SMTP_MAILS");

                entity.HasIndex(e => e.Senddate, "IX_SMTP_MAILS_1");

                entity.HasIndex(e => e.Issent, "IX_SMTP_MAILS_2");

                entity.HasIndex(e => new { e.Requestid, e.To }, "IX_SMTP_MAILS_3");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cc)
                    .HasMaxLength(350)
                    .HasColumnName("_CC");

                entity.Property(e => e.Host)
                    .HasMaxLength(100)
                    .HasColumnName("HOST");

                entity.Property(e => e.Issent).HasColumnName("ISSENT");

                entity.Property(e => e.Reportid).HasColumnName("REPORTID");

                entity.Property(e => e.RequestDetailid).HasColumnName("REQUEST_DETAILID");

                entity.Property(e => e.Requestid).HasColumnName("REQUESTID");

                entity.Property(e => e.Senddate)
                    .HasColumnType("datetime")
                    .HasColumnName("SENDDATE");

                entity.Property(e => e.Sendermail)
                    .HasMaxLength(200)
                    .HasColumnName("SENDERMAIL");

                entity.Property(e => e.Sendername)
                    .HasMaxLength(150)
                    .HasColumnName("SENDERNAME");

                entity.Property(e => e.Senderror)
                    .HasMaxLength(250)
                    .HasColumnName("SENDERROR");

                entity.Property(e => e.Smtpid).HasColumnName("SMTPID");

                entity.Property(e => e.To)
                    .HasMaxLength(350)
                    .HasColumnName("_TO");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.SmtpMails)
                    .HasForeignKey(d => d.Reportid)
                    .HasConstraintName("FK__SMTP_MAIL__REPOR__55209ACA");

                entity.HasOne(d => d.RequestDetail)
                    .WithMany(p => p.SmtpMails)
                    .HasForeignKey(d => d.RequestDetailid)
                    .HasConstraintName("FK__SMTP_MAIL__REQUE__3A6282ED");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.SmtpMails)
                    .HasForeignKey(d => d.Requestid)
                    .HasConstraintName("FK__SMTP_MAIL__REQUE__54A177DD");

                entity.HasOne(d => d.Smtp)
                    .WithMany(p => p.SmtpMails)
                    .HasForeignKey(d => d.Smtpid)
                    .HasConstraintName("FK__SMTP_MAIL__SMTPI__5614BF03");
            });

            modelBuilder.Entity<SmtpSettings>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__SMTP_SET__3214EC2647672D81")
                    .IsClustered(false);

                entity.ToTable("SMTP_SETTINGS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Domain)
                    .HasMaxLength(100)
                    .HasColumnName("DOMAIN");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Host)
                    .HasMaxLength(100)
                    .HasColumnName("HOST");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.Pass)
                    .HasMaxLength(100)
                    .HasColumnName("PASS");

                entity.Property(e => e.Portno)
                    .HasColumnName("PORTNO")
                    .HasDefaultValueSql("((25))");

                entity.Property(e => e.ProjectDetailid).HasColumnName("PROJECT_DETAILID");

                entity.Property(e => e.Projectid).HasColumnName("PROJECTID");

                entity.Property(e => e.Sendermail)
                    .HasMaxLength(100)
                    .HasColumnName("SENDERMAIL");

                entity.Property(e => e.Sendername)
                    .HasMaxLength(150)
                    .HasColumnName("SENDERNAME");

                entity.Property(e => e.Tsl)
                    .HasMaxLength(25)
                    .HasColumnName("TSL");

                entity.Property(e => e.Type).HasColumnName("TYPE");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("USERNAME");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.SmtpSettingsAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SMTP_SETT__ADDUS__57FD0775");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.SmtpSettings)
                    .HasForeignKey(d => d.Corpid)
                    .HasConstraintName("FK__SMTP_SETT__CORPI__07B7078F");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.SmtpSettingsEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__SMTP_SETT__EDITU__08AB2BC8");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.SmtpSettings)
                    .HasForeignKey(d => d.Projectid)
                    .HasConstraintName("FK__SMTP_SETT__PROJE__3B6BB5BF");
            });

            modelBuilder.Entity<SntAgentStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_AGENT_STATUS");

                entity.Property(e => e.Agentname)
                    .HasMaxLength(150)
                    .HasColumnName("AGENTNAME");

                entity.Property(e => e.Endtime)
                    .HasColumnType("datetime")
                    .HasColumnName("ENDTIME");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Isbreak).HasColumnName("ISBREAK");

                entity.Property(e => e.Starttime)
                    .HasColumnType("datetime")
                    .HasColumnName("STARTTIME");

                entity.Property(e => e.Statu)
                    .HasMaxLength(30)
                    .HasColumnName("STATU");

                entity.Property(e => e.Statuid).HasColumnName("STATUID");
            });

            modelBuilder.Entity<SntCallDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_CALL_DETAIL");

                entity.Property(e => e.Abandon).HasColumnName("ABANDON");

                entity.Property(e => e.Agent)
                    .HasMaxLength(32)
                    .HasColumnName("agent");

                entity.Property(e => e.Answer)
                    .HasColumnType("datetime")
                    .HasColumnName("answer");

                entity.Property(e => e.Answered).HasColumnName("ANSWERED");

                entity.Property(e => e.Billsec).HasColumnName("billsec");

                entity.Property(e => e.Busy).HasColumnName("BUSY");

                entity.Property(e => e.Calldate)
                    .HasColumnType("datetime")
                    .HasColumnName("calldate");

                entity.Property(e => e.Cdate)
                    .HasColumnType("date")
                    .HasColumnName("CDATE");

                entity.Property(e => e.Cday).HasColumnName("CDAY");

                entity.Property(e => e.Channel)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("channel");

                entity.Property(e => e.Clid)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("clid");

                entity.Property(e => e.Cmonth).HasColumnName("CMONTH");

                entity.Property(e => e.Cyear).HasColumnName("CYEAR");

                entity.Property(e => e.Dcontext)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("dcontext");

                entity.Property(e => e.Disposition)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("disposition");

                entity.Property(e => e.Dst)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("dst");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.End)
                    .HasColumnType("datetime")
                    .HasColumnName("end");

                entity.Property(e => e.Enterqueue).HasColumnName("ENTERQUEUE");

                entity.Property(e => e.Event)
                    .HasMaxLength(32)
                    .HasColumnName("event");

                entity.Property(e => e.Failed).HasColumnName("FAILED");

                entity.Property(e => e.Inbound).HasColumnName("INBOUND");

                entity.Property(e => e.Lastapp)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("lastapp");

                entity.Property(e => e.Lastdata)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("lastdata");

                entity.Property(e => e.Noanswer).HasColumnName("NOANSWER");

                entity.Property(e => e.Otherdepartment).HasColumnName("OTHERDEPARTMENT");

                entity.Property(e => e.Outbound).HasColumnName("OUTBOUND");

                entity.Property(e => e.Queuename)
                    .HasMaxLength(32)
                    .HasColumnName("queuename");

                entity.Property(e => e.Resabandon).HasColumnName("RESABANDON");

                entity.Property(e => e.Resinbound).HasColumnName("RESINBOUND");

                entity.Property(e => e.Resoutbound).HasColumnName("RESOUTBOUND");

                entity.Property(e => e.Sentqueue).HasColumnName("SENTQUEUE");

                entity.Property(e => e.Src)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("src");

                entity.Property(e => e.Start)
                    .HasColumnType("datetime")
                    .HasColumnName("start");

                entity.Property(e => e.Transfercall).HasColumnName("TRANSFERCALL");

                entity.Property(e => e.Uniqueid)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("uniqueid");

                entity.Property(e => e.Userfield)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("userfield");
            });

            modelBuilder.Entity<SntCallJobs>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_CALL_JOBS");

                entity.Property(e => e.Callnumber).HasColumnName("CALLNUMBER");

                entity.Property(e => e.Calltime)
                    .HasColumnType("datetime")
                    .HasColumnName("CALLTIME");

                entity.Property(e => e.Campaigncode)
                    .HasMaxLength(100)
                    .HasColumnName("CAMPAIGNCODE")
                    .IsFixedLength();

                entity.Property(e => e.Dontcall).HasColumnName("DONTCALL");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(212)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Isfinished).HasColumnName("ISFINISHED");

                entity.Property(e => e.Jobend).HasColumnName("jobend");

                entity.Property(e => e.Jobstart).HasColumnName("jobstart");

                entity.Property(e => e.Kind)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("KIND")
                    .IsFixedLength();

                entity.Property(e => e.Maxtrycount).HasColumnName("MAXTRYCOUNT");

                entity.Property(e => e.MaxtrycountBusy).HasColumnName("MAXTRYCOUNT_BUSY");

                entity.Property(e => e.OutputExten)
                    .HasMaxLength(150)
                    .HasColumnName("OUTPUT_EXTEN");

                entity.Property(e => e.Phonenumber)
                    .HasMaxLength(50)
                    .HasColumnName("PHONENUMBER");

                entity.Property(e => e.Priority).HasColumnName("PRIORITY");

                entity.Property(e => e.ProjectDetailid).HasColumnName("PROJECT_DETAILID");

                entity.Property(e => e.ProjectGroupid).HasColumnName("PROJECT_GROUPID");

                entity.Property(e => e.Qaid).HasColumnName("QAID");

                entity.Property(e => e.Queuelogid).HasColumnName("QUEUELOGID");

                entity.Property(e => e.Queuename)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("QUEUENAME");

                entity.Property(e => e.Reason)
                    .HasMaxLength(33)
                    .IsUnicode(false)
                    .HasColumnName("REASON");

                entity.Property(e => e.Sdate)
                    .HasColumnType("datetime")
                    .HasColumnName("SDATE");

                entity.Property(e => e.Sortfld)
                    .HasColumnType("datetime")
                    .HasColumnName("SORTFLD");

                entity.Property(e => e.State)
                    .HasMaxLength(25)
                    .HasColumnName("STATE");

                entity.Property(e => e.Trycount).HasColumnName("TRYCOUNT");

                entity.Property(e => e.TrycountBusy).HasColumnName("TRYCOUNT_BUSY");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<SntCallList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_CALL_LIST");

                entity.Property(e => e.Agent)
                    .HasMaxLength(100)
                    .HasColumnName("AGENT");

                entity.Property(e => e.Calltime)
                    .HasColumnType("datetime")
                    .HasColumnName("CALLTIME");

                entity.Property(e => e.Dontcall).HasColumnName("DONTCALL");

                entity.Property(e => e.Isfinished).HasColumnName("ISFINISHED");

                entity.Property(e => e.Jobend).HasColumnName("JOBEND");

                entity.Property(e => e.Jostart).HasColumnName("JOSTART");

                entity.Property(e => e.LastCalltime)
                    .HasColumnType("datetime")
                    .HasColumnName("LAST_CALLTIME");

                entity.Property(e => e.OutputExten)
                    .HasMaxLength(150)
                    .HasColumnName("OUTPUT_EXTEN");

                entity.Property(e => e.Phone)
                    .HasMaxLength(255)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Phonenumber)
                    .HasMaxLength(50)
                    .HasColumnName("PHONENUMBER");

                entity.Property(e => e.Priority).HasColumnName("PRIORITY");

                entity.Property(e => e.Qaid).HasColumnName("QAID");

                entity.Property(e => e.Queueid).HasColumnName("QUEUEID");

                entity.Property(e => e.Queuename)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("QUEUENAME");

                entity.Property(e => e.State)
                    .HasMaxLength(25)
                    .HasColumnName("STATE");

                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TYPE");
            });

            modelBuilder.Entity<SntCallListOrg>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_CALL_LIST_ORG");

                entity.Property(e => e.Callid)
                    .HasMaxLength(32)
                    .HasColumnName("CALLID");

                entity.Property(e => e.Calltime)
                    .HasColumnType("datetime")
                    .HasColumnName("CALLTIME");

                entity.Property(e => e.Dontcall).HasColumnName("DONTCALL");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Jobid).HasColumnName("JOBID");

                entity.Property(e => e.Kind)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("KIND")
                    .IsFixedLength();

                entity.Property(e => e.Maxtrycount).HasColumnName("MAXTRYCOUNT");

                entity.Property(e => e.MaxtrycountBusy).HasColumnName("MAXTRYCOUNT_BUSY");

                entity.Property(e => e.OutputExten)
                    .HasMaxLength(150)
                    .HasColumnName("OUTPUT_EXTEN");

                entity.Property(e => e.Phonenumber)
                    .HasMaxLength(50)
                    .HasColumnName("PHONENUMBER");

                entity.Property(e => e.Priority).HasColumnName("PRIORITY");

                entity.Property(e => e.Qaid).HasColumnName("QAID");

                entity.Property(e => e.Queuelogid).HasColumnName("QUEUELOGID");

                entity.Property(e => e.Sdate)
                    .HasColumnType("datetime")
                    .HasColumnName("SDATE");

                entity.Property(e => e.Statu).HasColumnName("STATU");

                entity.Property(e => e.Trycount).HasColumnName("TRYCOUNT");

                entity.Property(e => e.TrycountBusy).HasColumnName("TRYCOUNT_BUSY");
            });

            modelBuilder.Entity<SntCallStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_CALL_STATUS");

                entity.Property(e => e.Description)
                    .HasMaxLength(25)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Isfinished).HasColumnName("ISFINISHED");
            });

            modelBuilder.Entity<SntCallSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_CALL_SUMMARY");

                entity.Property(e => e.Abandon).HasColumnName("ABANDON");

                entity.Property(e => e.Answered).HasColumnName("ANSWERED");

                entity.Property(e => e.Busy).HasColumnName("BUSY");

                entity.Property(e => e.Callcount).HasColumnName("CALLCOUNT");

                entity.Property(e => e.Calltime)
                    .HasMaxLength(53)
                    .HasColumnName("CALLTIME");

                entity.Property(e => e.Cdate)
                    .HasColumnType("date")
                    .HasColumnName("CDATE");

                entity.Property(e => e.Duration).HasColumnName("DURATION");

                entity.Property(e => e.Failed).HasColumnName("FAILED");

                entity.Property(e => e.Inbound).HasColumnName("INBOUND");

                entity.Property(e => e.InboundSingle).HasColumnName("INBOUND_SINGLE");

                entity.Property(e => e.Noanswer).HasColumnName("NOANSWER");

                entity.Property(e => e.Otherdepartment).HasColumnName("OTHERDEPARTMENT");

                entity.Property(e => e.Rescalltime)
                    .HasMaxLength(53)
                    .HasColumnName("RESCALLTIME");

                entity.Property(e => e.Resinbound).HasColumnName("RESINBOUND");

                entity.Property(e => e.ResinboundDuration).HasColumnName("RESINBOUND_DURATION");

                entity.Property(e => e.Resoutbound).HasColumnName("RESOUTBOUND");

                entity.Property(e => e.Transfercall).HasColumnName("TRANSFERCALL");
            });

            modelBuilder.Entity<SntCallTotals>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_CALL_TOTALS");

                entity.Property(e => e.AbandonAvgwait).HasColumnName("ABANDON_AVGWAIT");

                entity.Property(e => e.AbandonMaxwait).HasColumnName("ABANDON_MAXWAIT");

                entity.Property(e => e.AbandonTotalwait).HasColumnName("ABANDON_TOTALWAIT");

                entity.Property(e => e.Abandoncall).HasColumnName("ABANDONCALL");

                entity.Property(e => e.AnsweredAvgwait).HasColumnName("ANSWERED_AVGWAIT");

                entity.Property(e => e.AnsweredMaxwait).HasColumnName("ANSWERED_MAXWAIT");

                entity.Property(e => e.AnsweredTotalwait).HasColumnName("ANSWERED_TOTALWAIT");

                entity.Property(e => e.Answeredcall).HasColumnName("ANSWEREDCALL");

                entity.Property(e => e.Avgduration).HasColumnName("AVGDURATION");

                entity.Property(e => e.Avgrealduration).HasColumnName("AVGREALDURATION");

                entity.Property(e => e.Avgwait).HasColumnName("AVGWAIT");

                entity.Property(e => e.Callcount).HasColumnName("CALLCOUNT");

                entity.Property(e => e.Campaign)
                    .HasMaxLength(100)
                    .HasColumnName("CAMPAIGN");

                entity.Property(e => e.Cdate)
                    .HasColumnType("date")
                    .HasColumnName("CDATE");

                entity.Property(e => e.Cday).HasColumnName("CDAY");

                entity.Property(e => e.Cdayname)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("CDAYNAME");

                entity.Property(e => e.Cmonthname)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("CMONTHNAME");

                entity.Property(e => e.Cweek).HasColumnName("CWEEK");

                entity.Property(e => e.Cyear).HasColumnName("CYEAR");

                entity.Property(e => e.Maxduration).HasColumnName("MAXDURATION");

                entity.Property(e => e.Maxrealduration).HasColumnName("MAXREALDURATION");

                entity.Property(e => e.Maxwait).HasColumnName("MAXWAIT");

                entity.Property(e => e.Productname)
                    .HasMaxLength(200)
                    .HasColumnName("PRODUCTNAME");

                entity.Property(e => e.Projectname)
                    .HasMaxLength(150)
                    .HasColumnName("PROJECTNAME");

                entity.Property(e => e.Totalduration).HasColumnName("TOTALDURATION");

                entity.Property(e => e.Totalrealduration).HasColumnName("TOTALREALDURATION");

                entity.Property(e => e.Totalwait).HasColumnName("TOTALWAIT");
            });

            modelBuilder.Entity<SntCallbackIgnores>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_CALLBACK_IGNORES");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Number).HasMaxLength(25);
            });

            modelBuilder.Entity<SntCalls>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_CALLS");

                entity.Property(e => e.Accountcode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("accountcode");

                entity.Property(e => e.Agent)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("AGENT");

                entity.Property(e => e.Amaflags)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("amaflags");

                entity.Property(e => e.Answer)
                    .HasColumnType("datetime")
                    .HasColumnName("answer");

                entity.Property(e => e.Billsec).HasColumnName("billsec");

                entity.Property(e => e.Calldate)
                    .HasColumnType("datetime")
                    .HasColumnName("calldate");

                entity.Property(e => e.Callednumber)
                    .HasMaxLength(50)
                    .HasColumnName("callednumber");

                entity.Property(e => e.Callerid)
                    .HasMaxLength(30)
                    .HasColumnName("callerid");

                entity.Property(e => e.Channel)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("channel");

                entity.Property(e => e.Chn)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("CHN");

                entity.Property(e => e.Clid)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("clid");

                entity.Property(e => e.Dcontext)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("dcontext");

                entity.Property(e => e.Disposition)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("disposition");

                entity.Property(e => e.Dst)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("dst");

                entity.Property(e => e.Dstchannel)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("dstchannel");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.End)
                    .HasColumnType("datetime")
                    .HasColumnName("end");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(212)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Lastapp)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("lastapp");

                entity.Property(e => e.Lastdata)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("lastdata");

                entity.Property(e => e.Phn)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("PHN");

                entity.Property(e => e.Phonenumber)
                    .HasMaxLength(30)
                    .HasColumnName("PHONENUMBER");

                entity.Property(e => e.Projectgroup)
                    .HasMaxLength(150)
                    .HasColumnName("PROJECTGROUP");

                entity.Property(e => e.Src)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("src");

                entity.Property(e => e.Start)
                    .HasColumnType("datetime")
                    .HasColumnName("start");

                entity.Property(e => e.Uniqueid)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("uniqueid");

                entity.Property(e => e.Userfield)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("userfield");
            });

            modelBuilder.Entity<SntCdr>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_CDR");

                entity.Property(e => e.Accountcode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("accountcode");

                entity.Property(e => e.Amaflags)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("amaflags");

                entity.Property(e => e.Answer)
                    .HasColumnType("datetime")
                    .HasColumnName("answer");

                entity.Property(e => e.Billsec).HasColumnName("billsec");

                entity.Property(e => e.Calldate)
                    .HasColumnType("datetime")
                    .HasColumnName("calldate");

                entity.Property(e => e.Callednumber)
                    .HasMaxLength(50)
                    .HasColumnName("callednumber");

                entity.Property(e => e.Callerid)
                    .HasMaxLength(30)
                    .HasColumnName("callerid");

                entity.Property(e => e.Channel)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("channel");

                entity.Property(e => e.Clid)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("clid");

                entity.Property(e => e.Dcontext)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("dcontext");

                entity.Property(e => e.Disposition)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("disposition");

                entity.Property(e => e.Dst)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("dst");

                entity.Property(e => e.Dstchannel)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("dstchannel");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.End)
                    .HasColumnType("datetime")
                    .HasColumnName("end");

                entity.Property(e => e.Exten)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("exten");

                entity.Property(e => e.Lastapp)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("lastapp");

                entity.Property(e => e.Lastdata)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("lastdata");

                entity.Property(e => e.Peername)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("peername");

                entity.Property(e => e.Src)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("src");

                entity.Property(e => e.Start)
                    .HasColumnType("datetime")
                    .HasColumnName("start");

                entity.Property(e => e.Tdate)
                    .HasColumnType("date")
                    .HasColumnName("tdate");

                entity.Property(e => e.Uniqueid)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("uniqueid");

                entity.Property(e => e.Userfield)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("userfield");
            });

            modelBuilder.Entity<SntCdrReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_CDR_REPORT");

                entity.Property(e => e.Answer)
                    .HasColumnType("datetime")
                    .HasColumnName("answer");

                entity.Property(e => e.Billsec).HasColumnName("billsec");

                entity.Property(e => e.Callednumber)
                    .HasMaxLength(50)
                    .HasColumnName("callednumber");

                entity.Property(e => e.Campaign)
                    .HasMaxLength(100)
                    .HasColumnName("CAMPAIGN");

                entity.Property(e => e.Cdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CDATE");

                entity.Property(e => e.Cday).HasColumnName("CDAY");

                entity.Property(e => e.Cdayname)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("CDAYNAME");

                entity.Property(e => e.Cdayofyear).HasColumnName("CDAYOFYEAR");

                entity.Property(e => e.Chour).HasColumnName("CHOUR");

                entity.Property(e => e.Cminute).HasColumnName("CMINUTE");

                entity.Property(e => e.Cmonth).HasColumnName("CMONTH");

                entity.Property(e => e.Cmonthname)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("CMONTHNAME");

                entity.Property(e => e.Cweek).HasColumnName("CWEEK");

                entity.Property(e => e.Cweekday).HasColumnName("CWEEKDAY");

                entity.Property(e => e.Cyear).HasColumnName("CYEAR");

                entity.Property(e => e.Dayofweek).HasColumnName("DAYOFWEEK");

                entity.Property(e => e.Disposition)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("disposition");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.End)
                    .HasColumnType("datetime")
                    .HasColumnName("end");

                entity.Property(e => e.Exten)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("exten");

                entity.Property(e => e.Isoutbound).HasColumnName("ISOUTBOUND");

                entity.Property(e => e.Peername)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("PEERNAME");

                entity.Property(e => e.Personid).HasColumnName("PERSONID");

                entity.Property(e => e.Personname)
                    .HasMaxLength(212)
                    .HasColumnName("PERSONNAME");

                entity.Property(e => e.Productname)
                    .HasMaxLength(200)
                    .HasColumnName("PRODUCTNAME");

                entity.Property(e => e.Projectname)
                    .HasMaxLength(150)
                    .HasColumnName("PROJECTNAME");

                entity.Property(e => e.Src)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("src");

                entity.Property(e => e.Start)
                    .HasColumnType("datetime")
                    .HasColumnName("start");

                entity.Property(e => e.Uniqueid)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("uniqueid");

                entity.Property(e => e.Userfield)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("userfield");
            });

            modelBuilder.Entity<SntDbs>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_DBS");

                entity.Property(e => e.CdrTds).HasColumnName("cdr_tds");

                entity.Property(e => e.Databasename)
                    .HasMaxLength(50)
                    .HasColumnName("DATABASENAME");

                entity.Property(e => e.Denifition)
                    .HasMaxLength(100)
                    .HasColumnName("DENIFITION");

                entity.Property(e => e.Extensions).HasColumnName("extensions");

                entity.Property(e => e.ExtraParams).HasColumnName("EXTRA_PARAMS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(30)
                    .HasColumnName("IPADDRESS");

                entity.Property(e => e.Pass)
                    .HasMaxLength(30)
                    .HasColumnName("PASS");

                entity.Property(e => e.Port).HasColumnName("PORT");

                entity.Property(e => e.QueueLog).HasColumnName("queue_log");

                entity.Property(e => e.QueueMembers).HasColumnName("queue_members");

                entity.Property(e => e.Queues).HasColumnName("queues");

                entity.Property(e => e.Sippeers).HasColumnName("sippeers");

                entity.Property(e => e.Sipregs).HasColumnName("sipregs");

                entity.Property(e => e.Swid).HasColumnName("SWID");

                entity.Property(e => e.Type)
                    .HasMaxLength(15)
                    .HasColumnName("TYPE");

                entity.Property(e => e.Username)
                    .HasMaxLength(30)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<SntDiagram>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_DIAGRAM");

                entity.Property(e => e.Connectors).HasColumnName("connectors");

                entity.Property(e => e.DataKey).HasColumnName("dataKey");

                entity.Property(e => e.Description)
                    .HasMaxLength(40)
                    .HasColumnName("description");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Page).HasColumnName("page");

                entity.Property(e => e.Shapes).HasColumnName("shapes");
            });

            modelBuilder.Entity<SntDiagramChildkeys>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_DIAGRAM_CHILDKEYS");

                entity.Property(e => e.DataKey).HasColumnName("dataKey");

                entity.Property(e => e.Key)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("key");
            });

            modelBuilder.Entity<SntDiagramShapes>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_DIAGRAM_SHAPES");

                entity.Property(e => e.DataKey).HasColumnName("dataKey");

                entity.Property(e => e.DiagramKey).HasColumnName("diagramKey");

                entity.Property(e => e.HeadId).HasColumnName("Head_ID");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.Key)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("key");

                entity.Property(e => e.Locked).HasColumnName("locked");

                entity.Property(e => e.SortIndex).HasColumnName("sortIndex");

                entity.Property(e => e.TargetContainerId).HasColumnName("targetContainerId");

                entity.Property(e => e.TargetId).HasColumnName("targetId");

                entity.Property(e => e.Text)
                    .HasMaxLength(254)
                    .HasColumnName("text");

                entity.Property(e => e.Type)
                    .HasMaxLength(200)
                    .HasColumnName("type");

                entity.Property(e => e.Width).HasColumnName("width");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.ZIndex).HasColumnName("zIndex");
            });

            modelBuilder.Entity<SntDialPlan>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_DIAL_PLAN");

                entity.Property(e => e.App)
                    .HasMaxLength(100)
                    .HasColumnName("APP");

                entity.Property(e => e.Appdata)
                    .HasMaxLength(250)
                    .HasColumnName("APPDATA");

                entity.Property(e => e.Groupname)
                    .HasMaxLength(150)
                    .HasColumnName("GROUPNAME");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Parentid).HasColumnName("PARENTID");

                entity.Property(e => e.Priority).HasColumnName("PRIORITY");

                entity.Property(e => e.Swid).HasColumnName("SWID");
            });

            modelBuilder.Entity<SntLanguageCountries>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_LANGUAGE_COUNTRIES");

                entity.Property(e => e.Countrycode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("COUNTRYCODE")
                    .IsFixedLength();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Langcode)
                    .HasMaxLength(5)
                    .HasColumnName("LANGCODE");
            });

            modelBuilder.Entity<SntMissedcalls>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_MISSEDCALLS");

                entity.Property(e => e.Agent)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("agent");

                entity.Property(e => e.Callednumber)
                    .HasMaxLength(50)
                    .HasColumnName("callednumber");

                entity.Property(e => e.Calltime)
                    .HasColumnType("datetime")
                    .HasColumnName("CALLTIME");

                entity.Property(e => e.Dontcall).HasColumnName("DONTCALL");

                entity.Property(e => e.Event)
                    .HasMaxLength(32)
                    .HasColumnName("event");

                entity.Property(e => e.Isfinished).HasColumnName("ISFINISHED");

                entity.Property(e => e.Kind)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("KIND")
                    .IsFixedLength();

                entity.Property(e => e.Maxtrycount).HasColumnName("MAXTRYCOUNT");

                entity.Property(e => e.MaxtrycountBusy).HasColumnName("MAXTRYCOUNT_BUSY");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.OutputExten)
                    .HasMaxLength(150)
                    .HasColumnName("OUTPUT_EXTEN");

                entity.Property(e => e.Phone)
                    .HasMaxLength(255)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Phonenumber)
                    .HasMaxLength(50)
                    .HasColumnName("PHONENUMBER");

                entity.Property(e => e.Priority).HasColumnName("PRIORITY");

                entity.Property(e => e.Qaid).HasColumnName("QAID");

                entity.Property(e => e.Queueid).HasColumnName("QUEUEID");

                entity.Property(e => e.Queuelogid).HasColumnName("QUEUELOGID");

                entity.Property(e => e.Queuename)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("QUEUENAME");

                entity.Property(e => e.Sdate)
                    .HasColumnType("datetime")
                    .HasColumnName("SDATE");

                entity.Property(e => e.Sortfld)
                    .HasColumnType("datetime")
                    .HasColumnName("SORTFLD");

                entity.Property(e => e.State)
                    .HasMaxLength(25)
                    .HasColumnName("STATE");

                entity.Property(e => e.Trycount).HasColumnName("TRYCOUNT");

                entity.Property(e => e.TrycountBusy).HasColumnName("TRYCOUNT_BUSY");
            });

            modelBuilder.Entity<SntMissedcallsAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_MISSEDCALLS_ALL");

                entity.Property(e => e.Agent)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("agent");

                entity.Property(e => e.Callednumber)
                    .HasMaxLength(50)
                    .HasColumnName("callednumber");

                entity.Property(e => e.Calltime)
                    .HasColumnType("datetime")
                    .HasColumnName("CALLTIME");

                entity.Property(e => e.Dontcall).HasColumnName("DONTCALL");

                entity.Property(e => e.Event)
                    .HasMaxLength(32)
                    .HasColumnName("event");

                entity.Property(e => e.Isfinished).HasColumnName("ISFINISHED");

                entity.Property(e => e.Kind)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("KIND")
                    .IsFixedLength();

                entity.Property(e => e.Maxtrycount).HasColumnName("MAXTRYCOUNT");

                entity.Property(e => e.MaxtrycountBusy).HasColumnName("MAXTRYCOUNT_BUSY");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.OutputExten)
                    .HasMaxLength(150)
                    .HasColumnName("OUTPUT_EXTEN");

                entity.Property(e => e.Phone)
                    .HasMaxLength(255)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Phonenumber)
                    .HasMaxLength(50)
                    .HasColumnName("PHONENUMBER");

                entity.Property(e => e.Priority).HasColumnName("PRIORITY");

                entity.Property(e => e.Qaid).HasColumnName("QAID");

                entity.Property(e => e.Queueid).HasColumnName("QUEUEID");

                entity.Property(e => e.Queuelogid).HasColumnName("QUEUELOGID");

                entity.Property(e => e.Queuename)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("QUEUENAME");

                entity.Property(e => e.Sdate)
                    .HasColumnType("datetime")
                    .HasColumnName("SDATE");

                entity.Property(e => e.Sortfld)
                    .HasColumnType("datetime")
                    .HasColumnName("SORTFLD");

                entity.Property(e => e.State)
                    .HasMaxLength(25)
                    .HasColumnName("STATE");

                entity.Property(e => e.Trycount).HasColumnName("TRYCOUNT");

                entity.Property(e => e.TrycountBusy).HasColumnName("TRYCOUNT_BUSY");

                entity.Property(e => e.Userfield)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("userfield");
            });

            modelBuilder.Entity<SntQueueAbandon>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_QUEUE_ABANDON");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IncHour).HasColumnName("INC_HOUR");

                entity.Property(e => e.MaxHour).HasColumnName("MAX_HOUR");

                entity.Property(e => e.MaxMin).HasColumnName("MAX_MIN");

                entity.Property(e => e.Maxtrycount).HasColumnName("MAXTRYCOUNT");

                entity.Property(e => e.MaxtrycountForbusy).HasColumnName("MAXTRYCOUNT_FORBUSY");

                entity.Property(e => e.Queueid).HasColumnName("QUEUEID");

                entity.Property(e => e.Try1minutelater).HasColumnName("TRY1MINUTELATER");

                entity.Property(e => e.Try1minutelaterForbusy).HasColumnName("TRY1MINUTELATER_FORBUSY");

                entity.Property(e => e.Try2minutelater).HasColumnName("TRY2MINUTELATER");

                entity.Property(e => e.Try2minutelaterForbusy).HasColumnName("TRY2MINUTELATER_FORBUSY");

                entity.Property(e => e.Try3minutelater).HasColumnName("TRY3MINUTELATER");

                entity.Property(e => e.Try3minutelaterForbusy).HasColumnName("TRY3MINUTELATER_FORBUSY");

                entity.Property(e => e.Try4minutelater).HasColumnName("TRY4MINUTELATER");

                entity.Property(e => e.Try4minutelaterForbusy).HasColumnName("TRY4MINUTELATER_FORBUSY");

                entity.Property(e => e.Try5minutelater).HasColumnName("TRY5MINUTELATER");

                entity.Property(e => e.Try5minutelaterForbusy).HasColumnName("TRY5MINUTELATER_FORBUSY");

                entity.Property(e => e.WeekendIncHour).HasColumnName("WEEKEND_INC_HOUR");

                entity.Property(e => e.WeekendMaxHour).HasColumnName("WEEKEND_MAX_HOUR");

                entity.Property(e => e.WeekendMaxMin).HasColumnName("WEEKEND_MAX_MIN");
            });

            modelBuilder.Entity<SntQueueLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_QUEUE_LOG");

                entity.Property(e => e.Agent)
                    .HasMaxLength(32)
                    .HasColumnName("agent");

                entity.Property(e => e.Callid)
                    .HasMaxLength(32)
                    .HasColumnName("callid");

                entity.Property(e => e.Data)
                    .HasMaxLength(255)
                    .HasColumnName("data");

                entity.Property(e => e.Data1)
                    .HasMaxLength(255)
                    .HasColumnName("data1");

                entity.Property(e => e.Data2)
                    .HasMaxLength(255)
                    .HasColumnName("data2");

                entity.Property(e => e.Data3)
                    .HasMaxLength(255)
                    .HasColumnName("data3");

                entity.Property(e => e.Data4)
                    .HasMaxLength(255)
                    .HasColumnName("data4");

                entity.Property(e => e.Data5)
                    .HasMaxLength(255)
                    .HasColumnName("data5");

                entity.Property(e => e.Event)
                    .HasMaxLength(32)
                    .HasColumnName("event");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Logdate)
                    .HasColumnType("date")
                    .HasColumnName("logdate");

                entity.Property(e => e.Queuename)
                    .HasMaxLength(32)
                    .HasColumnName("queuename");

                entity.Property(e => e.Time).HasColumnName("time");
            });

            modelBuilder.Entity<SntQueueMembers>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_QUEUE_MEMBERS");

                entity.Property(e => e.Interface)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("interface");

                entity.Property(e => e.Membername)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("membername");

                entity.Property(e => e.Paused).HasColumnName("paused");

                entity.Property(e => e.Penalty).HasColumnName("penalty");

                entity.Property(e => e.QueueName)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("queue_name");

                entity.Property(e => e.Queueid).HasColumnName("queueid");

                entity.Property(e => e.Uniqueid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("uniqueid");
            });

            modelBuilder.Entity<SntQueues>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_QUEUES");

                entity.Property(e => e.AbandoncallbackExten).HasColumnName("abandoncallback_exten");

                entity.Property(e => e.Announce)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("announce");

                entity.Property(e => e.AnnounceFrequency).HasColumnName("announce_frequency");

                entity.Property(e => e.AnnounceHoldtime)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("announce_holdtime");

                entity.Property(e => e.AnnounceRoundSeconds).HasColumnName("announce_round_seconds");

                entity.Property(e => e.Autofill)
                    .HasMaxLength(15)
                    .HasColumnName("autofill");

                entity.Property(e => e.Autopause)
                    .HasMaxLength(15)
                    .HasColumnName("autopause");

                entity.Property(e => e.Context)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("context");

                entity.Property(e => e.Corpid).HasColumnName("corpid");

                entity.Property(e => e.Eventmemberstatus).HasColumnName("eventmemberstatus");

                entity.Property(e => e.Eventwhencalled).HasColumnName("eventwhencalled");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Isdisabled).HasColumnName("isdisabled");

                entity.Property(e => e.Jobend).HasColumnName("jobend");

                entity.Property(e => e.Jobstart).HasColumnName("jobstart");

                entity.Property(e => e.Joinempty)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("joinempty");

                entity.Property(e => e.Leavewhenempty)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("leavewhenempty");

                entity.Property(e => e.Maxlen).HasColumnName("maxlen");

                entity.Property(e => e.Memberdelay).HasColumnName("memberdelay");

                entity.Property(e => e.MonitorFormat)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("monitor_format");

                entity.Property(e => e.MonitorJoin).HasColumnName("monitor_join");

                entity.Property(e => e.Musiconhold)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("musiconhold");

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.PeriodicAnnounce)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("periodic_announce");

                entity.Property(e => e.PeriodicAnnounceFrequency).HasColumnName("periodic_announce_frequency");

                entity.Property(e => e.QueueCallswaiting)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("queue_callswaiting");

                entity.Property(e => e.QueueHoldtime)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("queue_holdtime");

                entity.Property(e => e.QueueLessthan)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("queue_lessthan");

                entity.Property(e => e.QueueMinutes)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("queue_minutes");

                entity.Property(e => e.QueueReporthold)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("queue_reporthold");

                entity.Property(e => e.QueueSeconds)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("queue_seconds");

                entity.Property(e => e.QueueThankyou)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("queue_thankyou");

                entity.Property(e => e.QueueThereare)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("queue_thereare");

                entity.Property(e => e.QueueYouarenext)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("queue_youarenext");

                entity.Property(e => e.Reportholdtime).HasColumnName("reportholdtime");

                entity.Property(e => e.Retry).HasColumnName("retry");

                entity.Property(e => e.Ringinuse).HasColumnName("ringinuse");

                entity.Property(e => e.Servicelevel).HasColumnName("servicelevel");

                entity.Property(e => e.Setinterfacevar).HasColumnName("setinterfacevar");

                entity.Property(e => e.Strategy)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("strategy");

                entity.Property(e => e.Swid).HasColumnName("swid");

                entity.Property(e => e.Timeout).HasColumnName("timeout");

                entity.Property(e => e.Timeoutrestart).HasColumnName("timeoutrestart");

                entity.Property(e => e.Weight).HasColumnName("weight");

                entity.Property(e => e.Wrapuptime).HasColumnName("wrapuptime");
            });

            modelBuilder.Entity<SntReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_REPORT");

                entity.Property(e => e.Accountcode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("accountcode");

                entity.Property(e => e.Agent)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("agent");

                entity.Property(e => e.Amaflags)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("amaflags");

                entity.Property(e => e.Answer)
                    .HasColumnType("datetime")
                    .HasColumnName("answer");

                entity.Property(e => e.Billsec).HasColumnName("billsec");

                entity.Property(e => e.Calldate)
                    .HasColumnType("datetime")
                    .HasColumnName("calldate");

                entity.Property(e => e.Callednumber)
                    .HasMaxLength(50)
                    .HasColumnName("callednumber");

                entity.Property(e => e.Callerid)
                    .HasMaxLength(30)
                    .HasColumnName("callerid");

                entity.Property(e => e.Campaign)
                    .HasMaxLength(100)
                    .HasColumnName("CAMPAIGN");

                entity.Property(e => e.Cday).HasColumnName("CDAY");

                entity.Property(e => e.Cdayname)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("CDAYNAME");

                entity.Property(e => e.Cdayofyear).HasColumnName("CDAYOFYEAR");

                entity.Property(e => e.Channel)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("channel");

                entity.Property(e => e.Chour).HasColumnName("CHOUR");

                entity.Property(e => e.Clid)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("clid");

                entity.Property(e => e.Cminute).HasColumnName("CMINUTE");

                entity.Property(e => e.Cmonth).HasColumnName("CMONTH");

                entity.Property(e => e.Cmonthname)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("CMONTHNAME");

                entity.Property(e => e.Cweek).HasColumnName("CWEEK");

                entity.Property(e => e.Cweekday).HasColumnName("CWEEKDAY");

                entity.Property(e => e.Cyear).HasColumnName("CYEAR");

                entity.Property(e => e.Dayofweek).HasColumnName("DAYOFWEEK");

                entity.Property(e => e.Dcontext)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("dcontext");

                entity.Property(e => e.Disposition)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("disposition");

                entity.Property(e => e.Dst)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("dst");

                entity.Property(e => e.Dstchannel)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("dstchannel");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.End)
                    .HasColumnType("datetime")
                    .HasColumnName("end");

                entity.Property(e => e.Event)
                    .HasMaxLength(32)
                    .HasColumnName("event");

                entity.Property(e => e.Exten)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("exten");

                entity.Property(e => e.Fromuser)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("fromuser");

                entity.Property(e => e.Hat)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("HAT");

                entity.Property(e => e.Isoutbound).HasColumnName("ISOUTBOUND");

                entity.Property(e => e.Istransfer).HasColumnName("ISTRANSFER");

                entity.Property(e => e.Lastapp)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("lastapp");

                entity.Property(e => e.Lastdata)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("lastdata");

                entity.Property(e => e.Peername)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("peername");

                entity.Property(e => e.Productname)
                    .HasMaxLength(250)
                    .HasColumnName("PRODUCTNAME");

                entity.Property(e => e.Projectname)
                    .HasMaxLength(150)
                    .HasColumnName("PROJECTNAME");

                entity.Property(e => e.Queuelogid).HasColumnName("queuelogid");

                entity.Property(e => e.Queuename)
                    .HasMaxLength(32)
                    .HasColumnName("queuename");

                entity.Property(e => e.Src)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("src");

                entity.Property(e => e.Start)
                    .HasColumnType("datetime")
                    .HasColumnName("start");

                entity.Property(e => e.Summaryfield).HasColumnName("SUMMARYFIELD");

                entity.Property(e => e.Swid).HasColumnName("SWID");

                entity.Property(e => e.Tdate)
                    .HasColumnType("date")
                    .HasColumnName("tdate");

                entity.Property(e => e.Uniqueid)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("uniqueid");

                entity.Property(e => e.Userfield)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("userfield");
            });

            modelBuilder.Entity<SntRtSippeers>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_RT_SIPPEERS");

                entity.Property(e => e.Accountcode)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("accountcode");

                entity.Property(e => e.Allow)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("allow");

                entity.Property(e => e.Allowoverlap)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("allowoverlap");

                entity.Property(e => e.Allowsubscribe)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("allowsubscribe");

                entity.Property(e => e.Allowtransfer)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("allowtransfer");

                entity.Property(e => e.Amaflags)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("amaflags");

                entity.Property(e => e.Auth)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("auth");

                entity.Property(e => e.Autoframing)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("autoframing");

                entity.Property(e => e.Buggymwi)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("buggymwi");

                entity.Property(e => e.Busylevel).HasColumnName("busylevel");

                entity.Property(e => e.CallLimit).HasColumnName("call-limit");

                entity.Property(e => e.Callbackextension)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("callbackextension");

                entity.Property(e => e.Callcounter)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("callcounter");

                entity.Property(e => e.Callerid)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("callerid");

                entity.Property(e => e.Callgroup)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("callgroup");

                entity.Property(e => e.Callingpres)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("callingpres");

                entity.Property(e => e.CidNumber)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("cid_number");

                entity.Property(e => e.Constantssrc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("constantssrc");

                entity.Property(e => e.Contactdeny)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("contactdeny");

                entity.Property(e => e.Contactpermit)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("contactpermit");

                entity.Property(e => e.Context)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("context");

                entity.Property(e => e.Corpid).HasColumnName("corpid");

                entity.Property(e => e.Defaultip)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("defaultip");

                entity.Property(e => e.Defaultuser)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("defaultuser");

                entity.Property(e => e.Deny)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("deny");

                entity.Property(e => e.Directmedia)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("directmedia");

                entity.Property(e => e.Disallow)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("disallow");

                entity.Property(e => e.Dtmfmode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dtmfmode");

                entity.Property(e => e.Dynamic)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dynamic");

                entity.Property(e => e.Extension)
                    .HasMaxLength(50)
                    .HasColumnName("extension");

                entity.Property(e => e.Faxdetect)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("faxdetect");

                entity.Property(e => e.Fromdomain)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("fromdomain");

                entity.Property(e => e.Fromuser)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("fromuser");

                entity.Property(e => e.Fullcontact)
                    .HasMaxLength(135)
                    .IsUnicode(false)
                    .HasColumnName("fullcontact");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("fullname");

                entity.Property(e => e.G726nonstandard)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("g726nonstandard");

                entity.Property(e => e.Hasvoicemail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("hasvoicemail");

                entity.Property(e => e.Host)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("host");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Ignoresdpversion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ignoresdpversion");

                entity.Property(e => e.Insecure)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("insecure");

                entity.Property(e => e.Ipaddr)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ipaddr");

                entity.Property(e => e.Language)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("language");

                entity.Property(e => e.Lastms).HasColumnName("lastms");

                entity.Property(e => e.Mailbox)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("mailbox");

                entity.Property(e => e.Maxcallbitrate).HasColumnName("maxcallbitrate");

                entity.Property(e => e.Md5secret)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("md5secret");

                entity.Property(e => e.Mohinterpret)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("mohinterpret");

                entity.Property(e => e.Mohsuggest)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("mohsuggest");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Nat)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nat");

                entity.Property(e => e.Outboundproxy)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("outboundproxy");

                entity.Property(e => e.Parkinglot)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("parkinglot");

                entity.Property(e => e.Permit)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("permit");

                entity.Property(e => e.Pickupgroup)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("pickupgroup");

                entity.Property(e => e.Port).HasColumnName("port");

                entity.Property(e => e.Progressinband)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("progressinband");

                entity.Property(e => e.Promiscredir)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("promiscredir");

                entity.Property(e => e.Qualify)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("qualify");

                entity.Property(e => e.Qualifyfreq).HasColumnName("qualifyfreq");

                entity.Property(e => e.Regexten)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("regexten");

                entity.Property(e => e.Regseconds).HasColumnName("regseconds");

                entity.Property(e => e.Regserver)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("regserver");

                entity.Property(e => e.Remotesecret)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("remotesecret");

                entity.Property(e => e.Rfc2833compensate)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("rfc2833compensate");

                entity.Property(e => e.Rtpholdtimeout).HasColumnName("rtpholdtimeout");

                entity.Property(e => e.Rtpkeepalive).HasColumnName("rtpkeepalive");

                entity.Property(e => e.Rtptimeout).HasColumnName("rtptimeout");

                entity.Property(e => e.Secret)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("secret");

                entity.Property(e => e.Sendrpid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("sendrpid");

                entity.Property(e => e.SessionExpires).HasColumnName("session-expires");

                entity.Property(e => e.SessionMinse).HasColumnName("session-minse");

                entity.Property(e => e.SessionRefresher)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("session-refresher");

                entity.Property(e => e.SessionTimers)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("session-timers");

                entity.Property(e => e.Setvar)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("setvar");

                entity.Property(e => e.Subscribemwi)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("subscribemwi");

                entity.Property(e => e.Swid).HasColumnName("swid");

                entity.Property(e => e.T38ptUsertpsource)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("t38pt_usertpsource");

                entity.Property(e => e.Textsupport)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("textsupport");

                entity.Property(e => e.Timerb).HasColumnName("timerb");

                entity.Property(e => e.Timert1).HasColumnName("timert1");

                entity.Property(e => e.Transport)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("transport");

                entity.Property(e => e.Trunkname)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("trunkname");

                entity.Property(e => e.Trustrpid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("trustrpid");

                entity.Property(e => e.Type)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("type");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.Useclientcode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("useclientcode");

                entity.Property(e => e.Useragent)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("useragent");

                entity.Property(e => e.Usereqphone)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("usereqphone");

                entity.Property(e => e.Videosupport)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("videosupport");

                entity.Property(e => e.Vmexten)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("vmexten");
            });

            modelBuilder.Entity<SntSippeers>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_SIPPEERS");

                entity.Property(e => e.Accountcode)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("accountcode");

                entity.Property(e => e.Allow)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("allow");

                entity.Property(e => e.Allowoverlap)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("allowoverlap");

                entity.Property(e => e.Allowsubscribe)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("allowsubscribe");

                entity.Property(e => e.Allowtransfer)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("allowtransfer");

                entity.Property(e => e.Amaflags)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("amaflags");

                entity.Property(e => e.Auth)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("auth");

                entity.Property(e => e.Autoframing)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("autoframing");

                entity.Property(e => e.Buggymwi)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("buggymwi");

                entity.Property(e => e.Busylevel).HasColumnName("busylevel");

                entity.Property(e => e.CallLimit).HasColumnName("call-limit");

                entity.Property(e => e.Callbackextension)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("callbackextension");

                entity.Property(e => e.Callcounter)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("callcounter");

                entity.Property(e => e.Callerid)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("callerid");

                entity.Property(e => e.Callgroup)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("callgroup");

                entity.Property(e => e.Callingpres)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("callingpres");

                entity.Property(e => e.CidNumber)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("cid_number");

                entity.Property(e => e.Constantssrc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("constantssrc");

                entity.Property(e => e.Contactdeny)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("contactdeny");

                entity.Property(e => e.Contactpermit)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("contactpermit");

                entity.Property(e => e.Context)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("context");

                entity.Property(e => e.Corpid).HasColumnName("corpid");

                entity.Property(e => e.Defaultip)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("defaultip");

                entity.Property(e => e.Defaultuser)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("defaultuser");

                entity.Property(e => e.Deny)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("deny");

                entity.Property(e => e.Directmedia)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("directmedia");

                entity.Property(e => e.Disallow)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("disallow");

                entity.Property(e => e.Dtmfmode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dtmfmode");

                entity.Property(e => e.Dynamic)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dynamic");

                entity.Property(e => e.Extension)
                    .HasMaxLength(50)
                    .HasColumnName("extension");

                entity.Property(e => e.ExtensionsFix).HasColumnName("extensions_fix");

                entity.Property(e => e.ExtensionsOutoundFix).HasColumnName("extensions_outound_fix");

                entity.Property(e => e.Faxdetect)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("faxdetect");

                entity.Property(e => e.Fromdomain)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("fromdomain");

                entity.Property(e => e.Fromuser)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("fromuser");

                entity.Property(e => e.Fullcontact)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("fullcontact");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("fullname");

                entity.Property(e => e.G726nonstandard)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("g726nonstandard");

                entity.Property(e => e.Hasvoicemail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("hasvoicemail");

                entity.Property(e => e.Host)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("host");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Ignoresdpversion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ignoresdpversion");

                entity.Property(e => e.Insecure)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("insecure");

                entity.Property(e => e.Ipaddr)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ipaddr");

                entity.Property(e => e.Ispeertopeer).HasColumnName("ispeertopeer");

                entity.Property(e => e.Isregister).HasColumnName("isregister");

                entity.Property(e => e.Language)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("language");

                entity.Property(e => e.Lastms).HasColumnName("lastms");

                entity.Property(e => e.Mailbox)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("mailbox");

                entity.Property(e => e.Maxcallbitrate).HasColumnName("maxcallbitrate");

                entity.Property(e => e.Md5secret)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("md5secret");

                entity.Property(e => e.Mohinterpret)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("mohinterpret");

                entity.Property(e => e.Mohsuggest)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("mohsuggest");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Nat)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nat");

                entity.Property(e => e.OutboundExtension)
                    .HasMaxLength(50)
                    .HasColumnName("outbound_extension");

                entity.Property(e => e.Outboundproxy)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("outboundproxy");

                entity.Property(e => e.Parkinglot)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("parkinglot");

                entity.Property(e => e.Permit)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("permit");

                entity.Property(e => e.Pickupgroup)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("pickupgroup");

                entity.Property(e => e.Port).HasColumnName("port");

                entity.Property(e => e.Prefix)
                    .HasMaxLength(10)
                    .HasColumnName("prefix");

                entity.Property(e => e.PrefixNational)
                    .HasMaxLength(10)
                    .HasColumnName("prefix_national");

                entity.Property(e => e.Progressinband)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("progressinband");

                entity.Property(e => e.Promiscredir)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("promiscredir");

                entity.Property(e => e.Qualify)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("qualify");

                entity.Property(e => e.Qualifyfreq).HasColumnName("qualifyfreq");

                entity.Property(e => e.Regexten)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("regexten");

                entity.Property(e => e.Regseconds).HasColumnName("regseconds");

                entity.Property(e => e.Regserver)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("regserver");

                entity.Property(e => e.Remotesecret)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("remotesecret");

                entity.Property(e => e.Rfc2833compensate)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("rfc2833compensate");

                entity.Property(e => e.Rtpholdtimeout).HasColumnName("rtpholdtimeout");

                entity.Property(e => e.Rtpkeepalive).HasColumnName("rtpkeepalive");

                entity.Property(e => e.Rtptimeout).HasColumnName("rtptimeout");

                entity.Property(e => e.Secret)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("secret");

                entity.Property(e => e.Sendrpid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("sendrpid");

                entity.Property(e => e.SessionExpires).HasColumnName("session-expires");

                entity.Property(e => e.SessionMinse).HasColumnName("session-minse");

                entity.Property(e => e.SessionRefresher)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("session-refresher");

                entity.Property(e => e.SessionTimers)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("session-timers");

                entity.Property(e => e.Setvar)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("setvar");

                entity.Property(e => e.Subscribemwi)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("subscribemwi");

                entity.Property(e => e.Swid).HasColumnName("swid");

                entity.Property(e => e.T38ptUsertpsource)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("t38pt_usertpsource");

                entity.Property(e => e.Textsupport)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("textsupport");

                entity.Property(e => e.Timerb).HasColumnName("timerb");

                entity.Property(e => e.Timert1).HasColumnName("timert1");

                entity.Property(e => e.Transport)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("transport");

                entity.Property(e => e.Trunkname)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("trunkname");

                entity.Property(e => e.Trustrpid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("trustrpid");

                entity.Property(e => e.Type)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("type");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.Useclientcode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("useclientcode");

                entity.Property(e => e.Useragent)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("useragent");

                entity.Property(e => e.Usereqphone)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("usereqphone");

                entity.Property(e => e.Videosupport)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("videosupport");

                entity.Property(e => e.Vmexten)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("vmexten");
            });

            modelBuilder.Entity<SntSwitchboard>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_SWITCHBOARD");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.ExtensionsFix).HasColumnName("EXTENSIONS_FIX");

                entity.Property(e => e.ExtensionsOutboundFix).HasColumnName("EXTENSIONS_OUTBOUND_FIX");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(30)
                    .HasColumnName("IPADDRESS");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.Pass)
                    .HasMaxLength(50)
                    .HasColumnName("PASS");

                entity.Property(e => e.Port).HasColumnName("PORT");

                entity.Property(e => e.Username)
                    .HasMaxLength(40)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<StdParams>(entity =>
            {
                entity.ToTable("STD_PARAMS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Groupname)
                    .HasMaxLength(50)
                    .HasColumnName("GROUPNAME");

                entity.Property(e => e.Paramname)
                    .HasMaxLength(200)
                    .HasColumnName("PARAMNAME");

                entity.Property(e => e.Paramvalue)
                    .HasMaxLength(250)
                    .HasColumnName("PARAMVALUE");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.StdParams)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STD_PARAM__CORPI__5CC1BC92");
            });

            modelBuilder.Entity<Stdboardtypes>(entity =>
            {
                entity.HasKey(e => e.Boardtype)
                    .HasName("PK__STDBOARD__9CD382A3B16C0FCE");

                entity.ToTable("STDBOARDTYPES");

                entity.Property(e => e.Boardtype)
                    .HasMaxLength(10)
                    .HasColumnName("BOARDTYPE");
            });

            modelBuilder.Entity<Stdhotel>(entity =>
            {
                entity.ToTable("STDHOTEL");

                entity.HasIndex(e => e.Seturid, "IX_STDHOTEL");

                entity.HasIndex(e => new { e.Isdeleted, e.Isdisabled }, "IX_STDHOTEL_1");

                entity.HasIndex(e => e.Name, "IX_STDHOTEL_2");

                entity.HasIndex(e => e.Name, "IX_STDHOTEL_3");

                entity.HasIndex(e => e.Adddate, "IX_STDHOTEL_4");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Addressid).HasColumnName("ADDRESSID");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Checkintime)
                    .HasColumnType("datetime")
                    .HasColumnName("CHECKINTIME");

                entity.Property(e => e.Checkouttime)
                    .HasColumnType("datetime")
                    .HasColumnName("CHECKOUTTIME");

                entity.Property(e => e.Contact)
                    .HasMaxLength(200)
                    .HasColumnName("CONTACT");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Factsheeturl)
                    .HasMaxLength(250)
                    .HasColumnName("FACTSHEETURL");

                entity.Property(e => e.Factsheeturl2)
                    .HasMaxLength(250)
                    .HasColumnName("FACTSHEETURL2");

                entity.Property(e => e.Fax).HasColumnName("FAX");

                entity.Property(e => e.Homepageurl)
                    .HasMaxLength(350)
                    .HasColumnName("HOMEPAGEURL");

                entity.Property(e => e.HotelDescription).HasColumnName("HOTEL_DESCRIPTION");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.Name)
                    .HasMaxLength(70)
                    .HasColumnName("NAME");

                entity.Property(e => e.RakamId)
                    .HasMaxLength(15)
                    .HasColumnName("RAKAM_ID");

                entity.Property(e => e.Seturid).HasColumnName("SETURID");

                entity.Property(e => e.Stars).HasColumnName("STARS");

                entity.Property(e => e.Tel1).HasColumnName("TEL1");

                entity.Property(e => e.Tel2).HasColumnName("TEL2");

                entity.Property(e => e.Templatename)
                    .HasMaxLength(50)
                    .HasColumnName("TEMPLATENAME");

                entity.Property(e => e.Thumbnailmaxwidth)
                    .HasColumnName("THUMBNAILMAXWIDTH")
                    .HasDefaultValueSql("((110))");

                entity.Property(e => e.Thumbnailurl)
                    .HasMaxLength(350)
                    .HasColumnName("THUMBNAILURL");

                entity.Property(e => e.Tripadvisorid)
                    .HasMaxLength(50)
                    .HasColumnName("TRIPADVISORID");

                entity.Property(e => e.UrlBlogger)
                    .HasMaxLength(250)
                    .HasColumnName("URL_BLOGGER");

                entity.Property(e => e.UrlFacebook)
                    .HasMaxLength(250)
                    .HasColumnName("URL_FACEBOOK");

                entity.Property(e => e.UrlFlicker)
                    .HasMaxLength(250)
                    .HasColumnName("URL_FLICKER");

                entity.Property(e => e.UrlFoursquare)
                    .HasMaxLength(250)
                    .HasColumnName("URL_FOURSQUARE");

                entity.Property(e => e.UrlGoogleplus)
                    .HasMaxLength(250)
                    .HasColumnName("URL_GOOGLEPLUS");

                entity.Property(e => e.UrlInstagram)
                    .HasMaxLength(250)
                    .HasColumnName("URL_INSTAGRAM");

                entity.Property(e => e.UrlVine)
                    .HasMaxLength(250)
                    .HasColumnName("URL_VINE");

                entity.Property(e => e.Webaddress)
                    .HasMaxLength(250)
                    .HasColumnName("WEBADDRESS");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Stdhotel)
                    .HasForeignKey(d => d.Addressid)
                    .HasConstraintName("FK__STDHOTEL__ADDRES__6754599E");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.StdhotelAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL__ADDUSE__6A30C649");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.Stdhotel)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STDHOTEL_CORP");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.StdhotelEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__STDHOTEL__EDITUS__6C190EBB");
            });

            modelBuilder.Entity<StdhotelAnnouncement>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__STDHOTEL__3214EC2639831F6E")
                    .IsClustered(false);

                entity.ToTable("STDHOTEL_ANNOUNCEMENT");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Definition)
                    .HasMaxLength(150)
                    .HasColumnName("DEFINITION");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Enddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ENDDATE");

                entity.Property(e => e.Hotelid).HasColumnName("HOTELID");

                entity.Property(e => e.Innerhtml).HasColumnName("INNERHTML");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.Kind).HasColumnName("KIND");

                entity.Property(e => e.Markets).HasColumnName("MARKETS");

                entity.Property(e => e.Startdate)
                    .HasColumnType("datetime")
                    .HasColumnName("STARTDATE");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.StdhotelAnnouncementAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___ADDUS__71A7CADF");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.StdhotelAnnouncementEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__STDHOTEL___EDITU__729BEF18");

                entity.HasOne(d => d.Hotel)
                    .WithMany(p => p.StdhotelAnnouncement)
                    .HasForeignKey(d => d.Hotelid)
                    .HasConstraintName("FK__STDHOTEL___HOTEL__70B3A6A6");
            });

            modelBuilder.Entity<StdhotelBoardtypes>(entity =>
            {
                entity.ToTable("STDHOTEL_BOARDTYPES");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Boardtype)
                    .HasMaxLength(10)
                    .HasColumnName("BOARDTYPE");

                entity.Property(e => e.Definition)
                    .HasMaxLength(25)
                    .HasColumnName("DEFINITION");

                entity.Property(e => e.EntEtsid)
                    .HasMaxLength(50)
                    .HasColumnName("ENT_ETSID");

                entity.Property(e => e.EntHotelrunnerid)
                    .HasMaxLength(100)
                    .HasColumnName("ENT_HOTELRUNNERID");

                entity.Property(e => e.EntIatiid)
                    .HasMaxLength(50)
                    .HasColumnName("ENT_IATIID");

                entity.Property(e => e.EntId)
                    .HasMaxLength(25)
                    .HasColumnName("ENT_ID");

                entity.Property(e => e.EntJollytourid)
                    .HasMaxLength(150)
                    .HasColumnName("ENT_JOLLYTOURID");

                entity.Property(e => e.EntSednaid)
                    .HasMaxLength(250)
                    .HasColumnName("ENT_SEDNAID");

                entity.Property(e => e.EntSeturid)
                    .HasMaxLength(150)
                    .HasColumnName("ENT_SETURID");

                entity.Property(e => e.EntTatilbudurid)
                    .HasMaxLength(50)
                    .HasColumnName("ENT_TATILBUDURID");

                entity.Property(e => e.EntTouristicaid)
                    .HasMaxLength(50)
                    .HasColumnName("ENT_TOURISTICAID");

                entity.Property(e => e.EntTravelclickid)
                    .HasMaxLength(50)
                    .HasColumnName("ENT_TRAVELCLICKID");

                entity.Property(e => e.Hotelid).HasColumnName("HOTELID");

                entity.HasOne(d => d.BoardtypeNavigation)
                    .WithMany(p => p.StdhotelBoardtypes)
                    .HasForeignKey(d => d.Boardtype)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___BOARD__618671AF");

                entity.HasOne(d => d.Hotel)
                    .WithMany(p => p.StdhotelBoardtypes)
                    .HasForeignKey(d => d.Hotelid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___HOTEL__214BF109");
            });

            modelBuilder.Entity<StdhotelDescriptions>(entity =>
            {
                entity.ToTable("STDHOTEL_DESCRIPTIONS");

                entity.HasIndex(e => e.Uid, "IX_STDHOTEL_DESCRIPTIONS")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Category)
                    .HasMaxLength(150)
                    .HasColumnName("CATEGORY");

                entity.Property(e => e.Description).HasColumnName("DESCRIPTION");

                entity.Property(e => e.Hotelid).HasColumnName("HOTELID");

                entity.Property(e => e.Season)
                    .HasMaxLength(10)
                    .HasColumnName("SEASON");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Hotel)
                    .WithMany(p => p.StdhotelDescriptions)
                    .HasForeignKey(d => d.Hotelid)
                    .HasConstraintName("FK__STDHOTEL___HOTEL__18178C8A");
            });

            modelBuilder.Entity<StdhotelExtras>(entity =>
            {
                entity.ToTable("STDHOTEL_EXTRAS");

                entity.HasIndex(e => e.Exserviceid, "IX_STDHOTEL_EXTRAS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Curcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CURCODE")
                    .IsFixedLength();

                entity.Property(e => e.Definition)
                    .HasMaxLength(150)
                    .HasColumnName("DEFINITION");

                entity.Property(e => e.Exserviceid).HasColumnName("EXSERVICEID");

                entity.Property(e => e.Hotelid).HasColumnName("HOTELID");

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Hotel)
                    .WithMany(p => p.StdhotelExtras)
                    .HasForeignKey(d => d.Hotelid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___HOTEL__3BFFE745");
            });

            modelBuilder.Entity<StdhotelFecilities>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STDHOTEL_FECILITIES");

                entity.Property(e => e.Category)
                    .HasMaxLength(100)
                    .HasColumnName("CATEGORY");

                entity.Property(e => e.Definition)
                    .HasMaxLength(100)
                    .HasColumnName("DEFINITION");

                entity.Property(e => e.Description).HasColumnName("DESCRIPTION");

                entity.Property(e => e.Hotelid).HasColumnName("HOTELID");

                entity.Property(e => e.Icon)
                    .HasMaxLength(75)
                    .HasColumnName("ICON");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Isfree).HasColumnName("ISFREE");

                entity.Property(e => e.Roomtypeid).HasColumnName("ROOMTYPEID");

                entity.Property(e => e.Seasontype)
                    .HasMaxLength(10)
                    .HasColumnName("SEASONTYPE");

                entity.HasOne(d => d.Hotel)
                    .WithMany()
                    .HasForeignKey(d => d.Hotelid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__STDHOTEL___HOTEL__1DD065E0");

                entity.HasOne(d => d.Roomtype)
                    .WithMany()
                    .HasForeignKey(d => d.Roomtypeid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__STDHOTEL___ROOMT__066DDD9B");
            });

            modelBuilder.Entity<StdhotelImages>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STDHOTEL_IMAGES");

                entity.Property(e => e.Default).HasColumnName("DEFAULT");

                entity.Property(e => e.Definition)
                    .HasMaxLength(100)
                    .HasColumnName("DEFINITION");

                entity.Property(e => e.Description).HasColumnName("DESCRIPTION");

                entity.Property(e => e.Hotelid).HasColumnName("HOTELID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Roomtypeid).HasColumnName("ROOMTYPEID");

                entity.Property(e => e.Showinofferform)
                    .IsRequired()
                    .HasColumnName("SHOWINOFFERFORM")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Sortorder).HasColumnName("SORTORDER");

                entity.Property(e => e.Thumbnail)
                    .HasMaxLength(250)
                    .HasColumnName("THUMBNAIL");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Url)
                    .HasMaxLength(250)
                    .HasColumnName("URL");

                entity.HasOne(d => d.Hotel)
                    .WithMany()
                    .HasForeignKey(d => d.Hotelid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__STDHOTEL___HOTEL__1BE81D6E");

                entity.HasOne(d => d.Roomtype)
                    .WithMany()
                    .HasForeignKey(d => d.Roomtypeid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__STDHOTEL___ROOMT__55CAA640");
            });

            modelBuilder.Entity<StdhotelMarket>(entity =>
            {
                entity.ToTable("STDHOTEL_MARKET");

                entity.HasIndex(e => e.Id, "UQ__STDHOTEL__3214EC26A7DB71ED")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Definition)
                    .HasMaxLength(50)
                    .HasColumnName("DEFINITION");

                entity.Property(e => e.EntEtsid)
                    .HasMaxLength(50)
                    .HasColumnName("ENT_ETSID");

                entity.Property(e => e.EntHotelrunnerid)
                    .HasMaxLength(100)
                    .HasColumnName("ENT_HOTELRUNNERID");

                entity.Property(e => e.EntIatiid)
                    .HasMaxLength(50)
                    .HasColumnName("ENT_IATIID");

                entity.Property(e => e.EntId)
                    .HasMaxLength(25)
                    .HasColumnName("ENT_ID");

                entity.Property(e => e.EntJollytourid)
                    .HasMaxLength(150)
                    .HasColumnName("ENT_JOLLYTOURID");

                entity.Property(e => e.EntSednaid)
                    .HasMaxLength(250)
                    .HasColumnName("ENT_SEDNAID");

                entity.Property(e => e.EntSeturid)
                    .HasMaxLength(150)
                    .HasColumnName("ENT_SETURID");

                entity.Property(e => e.EntTatilbudurid)
                    .HasMaxLength(50)
                    .HasColumnName("ENT_TATILBUDURID");

                entity.Property(e => e.EntTouristicaid)
                    .HasMaxLength(50)
                    .HasColumnName("ENT_TOURISTICAID");

                entity.Property(e => e.EntTravelclickid)
                    .HasMaxLength(50)
                    .HasColumnName("ENT_TRAVELCLICKID");

                entity.Property(e => e.Hotelid).HasColumnName("HOTELID");

                entity.Property(e => e.Stdmarketid).HasColumnName("STDMARKETID");

                entity.HasOne(d => d.Hotel)
                    .WithMany(p => p.StdhotelMarket)
                    .HasForeignKey(d => d.Hotelid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___HOTEL__3C3FDE67");

                entity.HasOne(d => d.Stdmarket)
                    .WithMany(p => p.StdhotelMarket)
                    .HasForeignKey(d => d.Stdmarketid)
                    .HasConstraintName("FK__STDHOTEL___STDMA__673F4B05");
            });

            modelBuilder.Entity<StdhotelMarketCountry>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STDHOTEL_MARKET_COUNTRY");

                entity.HasIndex(e => e.Id, "UQ__STDHOTEL__3214EC26E0FACD80")
                    .IsUnique();

                entity.HasIndex(e => new { e.Countrycode, e.Marketid }, "UQ__STDHOTEL__DF754A0EFCBD2DB3")
                    .IsUnique();

                entity.Property(e => e.Countrycode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("COUNTRYCODE")
                    .IsFixedLength();

                entity.Property(e => e.Hotelid).HasColumnName("HOTELID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Marketid).HasColumnName("MARKETID");

                entity.HasOne(d => d.Hotel)
                    .WithMany()
                    .HasForeignKey(d => d.Hotelid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___HOTEL__41049384");

                entity.HasOne(d => d.Market)
                    .WithMany()
                    .HasForeignKey(d => d.Marketid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___MARKE__69279377");
            });

            modelBuilder.Entity<StdhotelPricecondition>(entity =>
            {
                entity.ToTable("STDHOTEL_PRICECONDITION");

                entity.HasIndex(e => new { e.Ratetypeid, e.Boardtypeid, e.Roomtypeid, e.Marketid, e.Curcode }, "IX_STDHOTEL_PRICECONDITION")
                    .IsUnique();

                entity.HasIndex(e => e.Id, "UQ__STDHOTEL__3214EC261CABA467")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AdultRate)
                    .HasColumnName("ADULT_RATE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BabyMaxage).HasColumnName("BABY_MAXAGE");

                entity.Property(e => e.BabyRate1)
                    .HasColumnName("BABY_RATE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Babyamount)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("BABYAMOUNT");

                entity.Property(e => e.BabycountsIncToBeds).HasColumnName("BABYCOUNTS_INC_TO_BEDS");

                entity.Property(e => e.Babyrate).HasColumnName("BABYRATE");

                entity.Property(e => e.Boardtypeid).HasColumnName("BOARDTYPEID");

                entity.Property(e => e.ChdeMaxage).HasColumnName("CHDE_MAXAGE");

                entity.Property(e => e.Chdeamount)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("CHDEAMOUNT");

                entity.Property(e => e.Chderate).HasColumnName("CHDERATE");

                entity.Property(e => e.ChdyMaxage).HasColumnName("CHDY_MAXAGE");

                entity.Property(e => e.Chdyamount)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("CHDYAMOUNT");

                entity.Property(e => e.Chdyrate).HasColumnName("CHDYRATE");

                entity.Property(e => e.ChildRate)
                    .HasColumnName("CHILD_RATE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Curcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CURCODE")
                    .IsFixedLength();

                entity.Property(e => e.Dblamount)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("DBLAMOUNT");

                entity.Property(e => e.Dblrate).HasColumnName("DBLRATE");

                entity.Property(e => e.Definition)
                    .HasMaxLength(150)
                    .HasColumnName("DEFINITION");

                entity.Property(e => e.Hotelid).HasColumnName("HOTELID");

                entity.Property(e => e.Marketid).HasColumnName("MARKETID");

                entity.Property(e => e.Maxadultcount).HasColumnName("MAXADULTCOUNT");

                entity.Property(e => e.Maxbabycount).HasColumnName("MAXBABYCOUNT");

                entity.Property(e => e.Maxbedcount).HasColumnName("MAXBEDCOUNT");

                entity.Property(e => e.Maxchildcount).HasColumnName("MAXCHILDCOUNT");

                entity.Property(e => e.Minadultcount).HasColumnName("MINADULTCOUNT");

                entity.Property(e => e.Minbabycount).HasColumnName("MINBABYCOUNT");

                entity.Property(e => e.Minbedcount).HasColumnName("MINBEDCOUNT");

                entity.Property(e => e.Minchildcount).HasColumnName("MINCHILDCOUNT");

                entity.Property(e => e.Quadamount)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("QUADAMOUNT");

                entity.Property(e => e.Quadrate).HasColumnName("QUADRATE");

                entity.Property(e => e.Ratetypeid).HasColumnName("RATETYPEID");

                entity.Property(e => e.Roomtypeid).HasColumnName("ROOMTYPEID");

                entity.Property(e => e.ShareNullmarketToAllmarkets).HasColumnName("SHARE_NULLMARKET_TO_ALLMARKETS");

                entity.Property(e => e.Sngamount)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("SNGAMOUNT");

                entity.Property(e => e.Sngrate).HasColumnName("SNGRATE");

                entity.Property(e => e.Trpamount)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("TRPAMOUNT");

                entity.Property(e => e.Trprate).HasColumnName("TRPRATE");

                entity.Property(e => e.UseCapacity).HasColumnName("USE_CAPACITY");

                entity.Property(e => e.UseMaxages).HasColumnName("USE_MAXAGES");

                entity.HasOne(d => d.Boardtype)
                    .WithMany(p => p.StdhotelPricecondition)
                    .HasForeignKey(d => d.Boardtypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___BOARD__46BD6CDA");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.StdhotelPricecondition)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___CORPI__3FDB6521");

                entity.HasOne(d => d.Hotel)
                    .WithMany(p => p.StdhotelPricecondition)
                    .HasForeignKey(d => d.Hotelid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___HOTEL__44D52468");

                entity.HasOne(d => d.Market)
                    .WithMany(p => p.StdhotelPricecondition)
                    .HasForeignKey(d => d.Marketid)
                    .HasConstraintName("FK__STDHOTEL___MARKE__48A5B54C");

                entity.HasOne(d => d.Ratetype)
                    .WithMany(p => p.StdhotelPricecondition)
                    .HasForeignKey(d => d.Ratetypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___RATET__47B19113");

                entity.HasOne(d => d.Roomtype)
                    .WithMany(p => p.StdhotelPricecondition)
                    .HasForeignKey(d => d.Roomtypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___ROOMT__45C948A1");
            });

            modelBuilder.Entity<StdhotelPriceconditionCalendar>(entity =>
            {
                entity.ToTable("STDHOTEL_PRICECONDITION_CALENDAR");

                entity.HasIndex(e => new { e.Date, e.Priceconditionid }, "UQ__STDHOTEL__BC35458659EA38AD")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Baserate)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("BASERATE");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("DATE");

                entity.Property(e => e.FreeSell).HasColumnName("FREE_SELL");

                entity.Property(e => e.MaxLos).HasColumnName("MAX_LOS");

                entity.Property(e => e.MinLos).HasColumnName("MIN_LOS");

                entity.Property(e => e.Priceconditionid).HasColumnName("PRICECONDITIONID");

                entity.Property(e => e.Quota).HasColumnName("QUOTA");

                entity.Property(e => e.ReleaseDay).HasColumnName("RELEASE_DAY");

                entity.Property(e => e.Releasedate)
                    .HasColumnType("date")
                    .HasColumnName("RELEASEDATE")
                    .HasComputedColumnSql("(case when [RELEASE_DAY]>(0) then dateadd(day, -[RELEASE_DAY],[DATE])  end)", true);

                entity.Property(e => e.StopCheckin).HasColumnName("STOP_CHECKIN");

                entity.Property(e => e.StopCheckout).HasColumnName("STOP_CHECKOUT");

                entity.Property(e => e.StopSell).HasColumnName("STOP_SELL");

                entity.HasOne(d => d.Pricecondition)
                    .WithMany(p => p.StdhotelPriceconditionCalendar)
                    .HasForeignKey(d => d.Priceconditionid)
                    .HasConstraintName("FK__STDHOTEL___PRICE__42B7D1CC");
            });

            modelBuilder.Entity<StdhotelPriceconditionOccupancy>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__STDHOTEL__3214EC269C63FEBC")
                    .IsClustered(false);

                entity.ToTable("STDHOTEL_PRICECONDITION_OCCUPANCY");

                entity.HasIndex(e => new { e.Priceconditionid, e.Adult, e.Chde, e.Chdy, e.Baby, e.Totalchd }, "UQ__STDHOTEL__506C296922C62C78")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adult).HasColumnName("ADULT");

                entity.Property(e => e.Baby).HasColumnName("BABY");

                entity.Property(e => e.Chde).HasColumnName("CHDE");

                entity.Property(e => e.Chdy).HasColumnName("CHDY");

                entity.Property(e => e.CostpriceRate).HasColumnName("COSTPRICE_RATE");

                entity.Property(e => e.GuestpriceRate).HasColumnName("GUESTPRICE_RATE");

                entity.Property(e => e.Priceconditionid).HasColumnName("PRICECONDITIONID");

                entity.Property(e => e.Totalchd).HasColumnName("TOTALCHD");

                entity.HasOne(d => d.Pricecondition)
                    .WithMany(p => p.StdhotelPriceconditionOccupancy)
                    .HasForeignKey(d => d.Priceconditionid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___PRICE__135DC465");
            });

            modelBuilder.Entity<StdhotelRatecode>(entity =>
            {
                entity.ToTable("STDHOTEL_RATECODE");

                entity.HasIndex(e => new { e.Hotelid, e.Corpid }, "IX_STDHOTEL_RATECODE")
                    .IsUnique();

                entity.HasIndex(e => e.Id, "UQ__STDHOTEL__3214EC26D34E1904")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Baby).HasColumnName("BABY");

                entity.Property(e => e.BabyMaxage).HasColumnName("BABY_MAXAGE");

                entity.Property(e => e.Chde).HasColumnName("CHDE");

                entity.Property(e => e.ChdeMaxage).HasColumnName("CHDE_MAXAGE");

                entity.Property(e => e.Chdy).HasColumnName("CHDY");

                entity.Property(e => e.ChdyMaxage).HasColumnName("CHDY_MAXAGE");

                entity.Property(e => e.Commissionincluded).HasColumnName("COMMISSIONINCLUDED");

                entity.Property(e => e.Commissionpercent).HasColumnName("COMMISSIONPERCENT");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Curcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CURCODE")
                    .IsFixedLength();

                entity.Property(e => e.Dbl).HasColumnName("DBL");

                entity.Property(e => e.Definition)
                    .HasMaxLength(50)
                    .HasColumnName("DEFINITION");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Exbed).HasColumnName("EXBED");

                entity.Property(e => e.Firstbaby).HasColumnName("FIRSTBABY");

                entity.Property(e => e.Firstchde).HasColumnName("FIRSTCHDE");

                entity.Property(e => e.Firstchdy).HasColumnName("FIRSTCHDY");

                entity.Property(e => e.Hotelid).HasColumnName("HOTELID");

                entity.Property(e => e.Quad).HasColumnName("QUAD");

                entity.Property(e => e.Sng).HasColumnName("SNG");

                entity.Property(e => e.Sngbaby).HasColumnName("SNGBABY");

                entity.Property(e => e.Sngchde).HasColumnName("SNGCHDE");

                entity.Property(e => e.Sngchdy).HasColumnName("SNGCHDY");

                entity.Property(e => e.Sngfirstbaby).HasColumnName("SNGFIRSTBABY");

                entity.Property(e => e.Sngfirstchde).HasColumnName("SNGFIRSTCHDE");

                entity.Property(e => e.Sngfirstchdy).HasColumnName("SNGFIRSTCHDY");

                entity.Property(e => e.Trp).HasColumnName("TRP");

                entity.Property(e => e.Trpbaby).HasColumnName("TRPBABY");

                entity.Property(e => e.Trpchde).HasColumnName("TRPCHDE");

                entity.Property(e => e.Trpchdy).HasColumnName("TRPCHDY");

                entity.Property(e => e.Trpfirstbaby).HasColumnName("TRPFIRSTBABY");

                entity.Property(e => e.Trpfirstchde).HasColumnName("TRPFIRSTCHDE");

                entity.Property(e => e.Trpfirstchdy).HasColumnName("TRPFIRSTCHDY");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.StdhotelRatecodeAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___ADDUS__11DF9047");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.StdhotelRatecode)
                    .HasForeignKey(d => d.Corpid)
                    .HasConstraintName("FK__STDHOTEL___CORPI__66010E09");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.StdhotelRatecodeEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__STDHOTEL___EDITU__12D3B480");

                entity.HasOne(d => d.Hotel)
                    .WithMany(p => p.StdhotelRatecode)
                    .HasForeignKey(d => d.Hotelid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___HOTEL__3592E0D8");
            });

            modelBuilder.Entity<StdhotelRatecodeDetail>(entity =>
            {
                entity.ToTable("STDHOTEL_RATECODE_DETAIL");

                entity.HasIndex(e => new { e.Ratecodeid, e.Priceconditionid, e.Stayfrom, e.Stayto, e.Minlos, e.Maxlos }, "IX_MISS_HOTELSEARCH");

                entity.HasIndex(e => e.Id, "UQ__STDHOTEL__3214EC2632A733C7")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Baby)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("BABY");

                entity.Property(e => e.Chde)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("CHDE");

                entity.Property(e => e.Chdy)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("CHDY");

                entity.Property(e => e.Checkindays)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("CHECKINDAYS")
                    .IsFixedLength();

                entity.Property(e => e.Checkoutdays)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("CHECKOUTDAYS")
                    .IsFixedLength();

                entity.Property(e => e.Childcalckind).HasColumnName("CHILDCALCKIND");

                entity.Property(e => e.Commissionincluded).HasColumnName("COMMISSIONINCLUDED");

                entity.Property(e => e.Commissionpercent).HasColumnName("COMMISSIONPERCENT");

                entity.Property(e => e.Dbl)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("DBL");

                entity.Property(e => e.Definition)
                    .HasMaxLength(50)
                    .HasColumnName("DEFINITION");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Exbed)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("EXBED");

                entity.Property(e => e.Firstbaby)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("FIRSTBABY");

                entity.Property(e => e.Firstchde)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("FIRSTCHDE");

                entity.Property(e => e.Firstchdy)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("FIRSTCHDY");

                entity.Property(e => e.Fixprice).HasColumnName("FIXPRICE");

                entity.Property(e => e.Hotelid).HasColumnName("HOTELID");

                entity.Property(e => e.Maxlos).HasColumnName("MAXLOS");

                entity.Property(e => e.MindayRate).HasColumnName("MINDAY_RATE");

                entity.Property(e => e.Minlos).HasColumnName("MINLOS");

                entity.Property(e => e.Priceconditionid).HasColumnName("PRICECONDITIONID");

                entity.Property(e => e.Pricesort)
                    .HasColumnName("PRICESORT")
                    .HasComputedColumnSql("(((((isnull((20)*datediff(day,[SELLFROM],[SELLTO]),(365))+isnull((10)*datediff(day,[STAYFROM],[STAYTO]),(365)))+isnull((1)*len(ltrim(rtrim([CHECKINDAYS]))),(7)))+isnull((2)*len(ltrim(rtrim([CHECKOUTDAYS]))),(7)))+isnull((3)*len(ltrim(rtrim([STAYINGDAYS]))),(7)))+isnull((4)*[MAXLOS]-[MINLOS],(0)))", true);

                entity.Property(e => e.Quad)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("QUAD");

                entity.Property(e => e.Ratecodeid).HasColumnName("RATECODEID");

                entity.Property(e => e.Sellfrom)
                    .HasColumnType("datetime")
                    .HasColumnName("SELLFROM");

                entity.Property(e => e.Sellto)
                    .HasColumnType("datetime")
                    .HasColumnName("SELLTO");

                entity.Property(e => e.Sng)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("SNG");

                entity.Property(e => e.Sngbaby)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("SNGBABY");

                entity.Property(e => e.Sngchde)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("SNGCHDE");

                entity.Property(e => e.Sngchdy)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("SNGCHDY");

                entity.Property(e => e.Sngchildcalckind).HasColumnName("SNGCHILDCALCKIND");

                entity.Property(e => e.Sngfirstbaby)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("SNGFIRSTBABY");

                entity.Property(e => e.Sngfirstchde)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("SNGFIRSTCHDE");

                entity.Property(e => e.Sngfirstchdy)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("SNGFIRSTCHDY");

                entity.Property(e => e.Stayfrom)
                    .HasColumnType("datetime")
                    .HasColumnName("STAYFROM");

                entity.Property(e => e.Stayingdays)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("STAYINGDAYS")
                    .IsFixedLength();

                entity.Property(e => e.Stayto)
                    .HasColumnType("datetime")
                    .HasColumnName("STAYTO");

                entity.Property(e => e.Trp)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("TRP");

                entity.Property(e => e.Trpbaby)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("TRPBABY");

                entity.Property(e => e.Trpchde)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("TRPCHDE");

                entity.Property(e => e.Trpchdy)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("TRPCHDY");

                entity.Property(e => e.Trpchildcalckind).HasColumnName("TRPCHILDCALCKIND");

                entity.Property(e => e.Trpfirstbaby)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("TRPFIRSTBABY");

                entity.Property(e => e.Trpfirstchde)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("TRPFIRSTCHDE");

                entity.Property(e => e.Trpfirstchdy)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("TRPFIRSTCHDY");

                entity.Property(e => e.Type).HasColumnName("TYPE");

                entity.HasOne(d => d.Pricecondition)
                    .WithMany(p => p.StdhotelRatecodeDetail)
                    .HasForeignKey(d => d.Priceconditionid)
                    .HasConstraintName("FK_STDHOTEL_RATECODE_DETAIL_STDHOTEL_PRICECONDITION");
            });

            modelBuilder.Entity<StdhotelRatecodeDetailAgencygroups>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__STDHOTEL__3214EC268DDA1218")
                    .IsClustered(false);

                entity.ToTable("STDHOTEL_RATECODE_DETAIL_AGENCYGROUPS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Detailid).HasColumnName("DETAILID");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Groupid).HasColumnName("GROUPID");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.StdhotelRatecodeDetailAgencygroupsAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___ADDUS__6D630406");

                entity.HasOne(d => d.Detail)
                    .WithMany(p => p.StdhotelRatecodeDetailAgencygroups)
                    .HasForeignKey(d => d.Detailid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__STDHOTEL___DETAI__703F70B1");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.StdhotelRatecodeDetailAgencygroupsEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__STDHOTEL___EDITU__6F4B4C78");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.StdhotelRatecodeDetailAgencygroups)
                    .HasForeignKey(d => d.Groupid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___GROUP__6C6EDFCD");
            });

            modelBuilder.Entity<StdhotelRatecodeDetailOccupancy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STDHOTEL_RATECODE_DETAIL_OCCUPANCY");

                entity.HasIndex(e => e.Id, "UQ__STDHOTEL__3214EC264DFD2C06")
                    .IsUnique();

                entity.HasIndex(e => new { e.Ratecodedetailid, e.Adult, e.Chde, e.Chdy, e.Baby, e.Totalchd }, "UQ__STDHOTEL__57C4B69A2CE4E4FF")
                    .IsUnique();

                entity.Property(e => e.Adult).HasColumnName("ADULT");

                entity.Property(e => e.Baby).HasColumnName("BABY");

                entity.Property(e => e.Chde).HasColumnName("CHDE");

                entity.Property(e => e.Chdy).HasColumnName("CHDY");

                entity.Property(e => e.Costprice)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("COSTPRICE");

                entity.Property(e => e.Guestprice)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("GUESTPRICE");

                entity.Property(e => e.Hotelid).HasColumnName("HOTELID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ratecodedetailid).HasColumnName("RATECODEDETAILID");

                entity.Property(e => e.Totalchd).HasColumnName("TOTALCHD");

                entity.HasOne(d => d.Hotel)
                    .WithMany()
                    .HasForeignKey(d => d.Hotelid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___HOTEL__513AFB4D");

                entity.HasOne(d => d.Ratecodedetail)
                    .WithMany()
                    .HasForeignKey(d => d.Ratecodedetailid)
                    .HasConstraintName("FK__STDHOTEL___RATEC__522F1F86");
            });

            modelBuilder.Entity<StdhotelRatecodeDiscount>(entity =>
            {
                entity.ToTable("STDHOTEL_RATECODE_DISCOUNT");

                entity.HasIndex(e => e.AdditionalDiscount, "IX_STDHOTEL_RATECODE_DISCOUNT");

                entity.HasIndex(e => new { e.Sellfrom, e.Sellto }, "IX_STDHOTEL_RATECODE_DISCOUNT_1");

                entity.HasIndex(e => new { e.Stayfrom, e.Stayto }, "IX_STDHOTEL_RATECODE_DISCOUNT_2");

                entity.HasIndex(e => e.Id, "UQ__STDHOTEL__3214EC267A852001")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AdditionalDiscount).HasColumnName("ADDITIONAL_DISCOUNT");

                entity.Property(e => e.AdditionalEffect)
                    .HasColumnName("ADDITIONAL_EFFECT")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.Agencyid).HasColumnName("AGENCYID");

                entity.Property(e => e.Applyalone).HasColumnName("APPLYALONE");

                entity.Property(e => e.Applydays)
                    .HasMaxLength(100)
                    .HasColumnName("APPLYDAYS");

                entity.Property(e => e.Applyfrom)
                    .HasColumnType("datetime")
                    .HasColumnName("APPLYFROM");

                entity.Property(e => e.Applyorder).HasColumnName("APPLYORDER");

                entity.Property(e => e.Applyto)
                    .HasColumnType("datetime")
                    .HasColumnName("APPLYTO");

                entity.Property(e => e.Applytype).HasColumnName("APPLYTYPE");

                entity.Property(e => e.Applyzone)
                    .HasColumnName("APPLYZONE")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.Basictype).HasColumnName("BASICTYPE");

                entity.Property(e => e.Checkindays)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("CHECKINDAYS")
                    .IsFixedLength();

                entity.Property(e => e.Checkoutdays)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("CHECKOUTDAYS")
                    .IsFixedLength();

                entity.Property(e => e.Definition)
                    .HasMaxLength(50)
                    .HasColumnName("DEFINITION");

                entity.Property(e => e.Discount).HasColumnName("DISCOUNT");

                entity.Property(e => e.Discounttype).HasColumnName("DISCOUNTTYPE");

                entity.Property(e => e.Hotelid).HasColumnName("HOTELID");

                entity.Property(e => e.Maxlos).HasColumnName("MAXLOS");

                entity.Property(e => e.Maxpax).HasColumnName("MAXPAX");

                entity.Property(e => e.Minlos).HasColumnName("MINLOS");

                entity.Property(e => e.Minpax).HasColumnName("MINPAX");

                entity.Property(e => e.Ratecodeid).HasColumnName("RATECODEID");

                entity.Property(e => e.Sellfrom)
                    .HasColumnType("datetime")
                    .HasColumnName("SELLFROM");

                entity.Property(e => e.Sellto)
                    .HasColumnType("datetime")
                    .HasColumnName("SELLTO");

                entity.Property(e => e.Stayfrom)
                    .HasColumnType("datetime")
                    .HasColumnName("STAYFROM");

                entity.Property(e => e.Stayingdays)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("STAYINGDAYS")
                    .IsFixedLength();

                entity.Property(e => e.Stayto)
                    .HasColumnType("datetime")
                    .HasColumnName("STAYTO");

                entity.HasOne(d => d.Agency)
                    .WithMany(p => p.StdhotelRatecodeDiscount)
                    .HasForeignKey(d => d.Agencyid)
                    .HasConstraintName("FK_STDHOTEL_RATECODE_DISCOUNT_AGENCY");

                entity.HasOne(d => d.DiscounttypeNavigation)
                    .WithMany(p => p.StdhotelRatecodeDiscount)
                    .HasForeignKey(d => d.Discounttype)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___DISCO__7869D707");

                entity.HasOne(d => d.Hotel)
                    .WithMany(p => p.StdhotelRatecodeDiscount)
                    .HasForeignKey(d => d.Hotelid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___HOTEL__4964CF5B");

                entity.HasOne(d => d.Ratecode)
                    .WithMany(p => p.StdhotelRatecodeDiscount)
                    .HasForeignKey(d => d.Ratecodeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___RATEC__4A58F394");
            });

            modelBuilder.Entity<StdhotelRatecodeDiscountContract>(entity =>
            {
                entity.ToTable("STDHOTEL_RATECODE_DISCOUNT_CONTRACT");

                entity.HasIndex(e => new { e.Discountid, e.Contractid }, "UQ__STDHOTEL__100A09E2B088803D")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Contractid).HasColumnName("CONTRACTID");

                entity.Property(e => e.Discountid).HasColumnName("DISCOUNTID");

                entity.HasOne(d => d.Contract)
                    .WithMany(p => p.StdhotelRatecodeDiscountContract)
                    .HasForeignKey(d => d.Contractid)
                    .HasConstraintName("FK__STDHOTEL___CONTR__5C77A3CF");

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.StdhotelRatecodeDiscountContract)
                    .HasForeignKey(d => d.Discountid)
                    .HasConstraintName("FK__STDHOTEL___DISCO__5B837F96");
            });

            modelBuilder.Entity<StdhotelRatecodeDiscountDiscount>(entity =>
            {
                entity.ToTable("STDHOTEL_RATECODE_DISCOUNT_DISCOUNT");

                entity.HasIndex(e => new { e.Discountid, e.Otherdiscountid }, "UQ__STDHOTEL__649F0431A924ADCC")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Discountid).HasColumnName("DISCOUNTID");

                entity.Property(e => e.Otherdiscountid).HasColumnName("OTHERDISCOUNTID");
            });

            modelBuilder.Entity<StdhotelRatecodeDiscountMarket>(entity =>
            {
                entity.ToTable("STDHOTEL_RATECODE_DISCOUNT_MARKET");

                entity.HasIndex(e => new { e.Discountid, e.Marketid }, "UQ__STDHOTEL__4B96FBB176D8588E")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Discountid).HasColumnName("DISCOUNTID");

                entity.Property(e => e.Marketid).HasColumnName("MARKETID");

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.StdhotelRatecodeDiscountMarket)
                    .HasForeignKey(d => d.Discountid)
                    .HasConstraintName("FK__STDHOTEL___DISCO__53E25DCE");

                entity.HasOne(d => d.Market)
                    .WithMany(p => p.StdhotelRatecodeDiscountMarket)
                    .HasForeignKey(d => d.Marketid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___MARKE__54D68207");
            });

            modelBuilder.Entity<StdhotelRatecodeDiscountRatetype>(entity =>
            {
                entity.ToTable("STDHOTEL_RATECODE_DISCOUNT_RATETYPE");

                entity.HasIndex(e => new { e.Discountid, e.Ratetypeid }, "UQ__STDHOTEL__050B357DD8B8D23E")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Discountid).HasColumnName("DISCOUNTID");

                entity.Property(e => e.Ratetypeid).HasColumnName("RATETYPEID");

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.StdhotelRatecodeDiscountRatetype)
                    .HasForeignKey(d => d.Discountid)
                    .HasConstraintName("FK__STDHOTEL___DISCO__57B2EEB2");

                entity.HasOne(d => d.Ratetype)
                    .WithMany(p => p.StdhotelRatecodeDiscountRatetype)
                    .HasForeignKey(d => d.Ratetypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___RATET__58A712EB");
            });

            modelBuilder.Entity<StdhotelRatecodeDiscountRoomtype>(entity =>
            {
                entity.ToTable("STDHOTEL_RATECODE_DISCOUNT_ROOMTYPE");

                entity.HasIndex(e => new { e.Discountid, e.Roomtypeid }, "UQ__STDHOTEL__46861580EC62108A")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Discountid).HasColumnName("DISCOUNTID");

                entity.Property(e => e.Roomtypeid).HasColumnName("ROOMTYPEID");

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.StdhotelRatecodeDiscountRoomtype)
                    .HasForeignKey(d => d.Discountid)
                    .HasConstraintName("FK__STDHOTEL___DISCO__5011CCEA");

                entity.HasOne(d => d.Roomtype)
                    .WithMany(p => p.StdhotelRatecodeDiscountRoomtype)
                    .HasForeignKey(d => d.Roomtypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___ROOMT__5105F123");
            });

            modelBuilder.Entity<StdhotelRatecodeMarkup>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__STDHOTEL__3214EC266A363F9F")
                    .IsClustered(false);

                entity.ToTable("STDHOTEL_RATECODE_MARKUP");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Agencyid).HasColumnName("AGENCYID");

                entity.Property(e => e.ApplyType).HasColumnName("APPLY_TYPE");

                entity.Property(e => e.Applyzone)
                    .HasColumnName("APPLYZONE")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.Curcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CURCODE")
                    .IsFixedLength();

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Rate).HasColumnName("RATE");

                entity.Property(e => e.Ratecodeid).HasColumnName("RATECODEID");

                entity.Property(e => e.Stayfrom)
                    .HasColumnType("datetime")
                    .HasColumnName("STAYFROM");

                entity.Property(e => e.Stayingdays)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("STAYINGDAYS")
                    .IsFixedLength();

                entity.Property(e => e.Stayto)
                    .HasColumnType("datetime")
                    .HasColumnName("STAYTO");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.StdhotelRatecodeMarkupAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___ADDUS__7948ECA7");

                entity.HasOne(d => d.CurcodeNavigation)
                    .WithMany(p => p.StdhotelRatecodeMarkup)
                    .HasForeignKey(d => d.Curcode)
                    .HasConstraintName("FK__STDHOTEL___CURCO__7266E4EE");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.StdhotelRatecodeMarkupEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__STDHOTEL___EDITU__7A3D10E0");

                entity.HasOne(d => d.Ratecode)
                    .WithMany(p => p.StdhotelRatecodeMarkup)
                    .HasForeignKey(d => d.Ratecodeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___RATEC__7760A435");
            });

            modelBuilder.Entity<StdhotelRatecodeMarkupMarkets>(entity =>
            {
                entity.ToTable("STDHOTEL_RATECODE_MARKUP_MARKETS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Marketid).HasColumnName("MARKETID");

                entity.Property(e => e.Markupid).HasColumnName("MARKUPID");

                entity.HasOne(d => d.Market)
                    .WithMany(p => p.StdhotelRatecodeMarkupMarkets)
                    .HasForeignKey(d => d.Marketid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___MARKE__1B9E04AB");

                entity.HasOne(d => d.Markup)
                    .WithMany(p => p.StdhotelRatecodeMarkupMarkets)
                    .HasForeignKey(d => d.Markupid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___MARKU__1AA9E072");
            });

            modelBuilder.Entity<StdhotelRatecodeMarkupRoomtype>(entity =>
            {
                entity.ToTable("STDHOTEL_RATECODE_MARKUP_ROOMTYPE");

                entity.HasIndex(e => e.BeforeDiscount, "IX_STDHOTEL_RATECODE_MARKUP_ROOMTYPE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdultPrice).HasColumnName("ADULT_PRICE");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.BabyPrice).HasColumnName("BABY_PRICE");

                entity.Property(e => e.BeforeDiscount).HasColumnName("BEFORE_DISCOUNT");

                entity.Property(e => e.ChdePrice).HasColumnName("CHDE_PRICE");

                entity.Property(e => e.ChdyPrice).HasColumnName("CHDY_PRICE");

                entity.Property(e => e.LastRate).HasColumnName("LAST_RATE");

                entity.Property(e => e.Markupid).HasColumnName("MARKUPID");

                entity.Property(e => e.Rate).HasColumnName("RATE");

                entity.Property(e => e.Roomtypeid).HasColumnName("ROOMTYPEID");

                entity.HasOne(d => d.Markup)
                    .WithMany(p => p.StdhotelRatecodeMarkupRoomtype)
                    .HasForeignKey(d => d.Markupid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___MARKU__1C9228E4");

                entity.HasOne(d => d.Roomtype)
                    .WithMany(p => p.StdhotelRatecodeMarkupRoomtype)
                    .HasForeignKey(d => d.Roomtypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___ROOMT__1D864D1D");
            });

            modelBuilder.Entity<StdhotelRatetype>(entity =>
            {
                entity.ToTable("STDHOTEL_RATETYPE");

                entity.HasIndex(e => e.Id, "UQ__STDHOTEL__3214EC26E6CD802C")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Definition)
                    .HasMaxLength(50)
                    .HasColumnName("DEFINITION");

                entity.Property(e => e.EntEtsid)
                    .HasMaxLength(50)
                    .HasColumnName("ENT_ETSID");

                entity.Property(e => e.EntHotelrunnerid)
                    .HasMaxLength(100)
                    .HasColumnName("ENT_HOTELRUNNERID");

                entity.Property(e => e.EntIatiid)
                    .HasMaxLength(50)
                    .HasColumnName("ENT_IATIID");

                entity.Property(e => e.EntId).HasColumnName("ENT_ID");

                entity.Property(e => e.EntJollytourid)
                    .HasMaxLength(150)
                    .HasColumnName("ENT_JOLLYTOURID");

                entity.Property(e => e.EntSednaid)
                    .HasMaxLength(250)
                    .HasColumnName("ENT_SEDNAID");

                entity.Property(e => e.EntSeturid)
                    .HasMaxLength(150)
                    .HasColumnName("ENT_SETURID");

                entity.Property(e => e.EntTatilbudurid)
                    .HasMaxLength(50)
                    .HasColumnName("ENT_TATILBUDURID");

                entity.Property(e => e.EntTouristicaid)
                    .HasMaxLength(50)
                    .HasColumnName("ENT_TOURISTICAID");

                entity.Property(e => e.EntTravelclickid)
                    .HasMaxLength(50)
                    .HasColumnName("ENT_TRAVELCLICKID");

                entity.Property(e => e.Hotelid).HasColumnName("HOTELID");

                entity.Property(e => e.Isrefundable).HasColumnName("ISREFUNDABLE");

                entity.Property(e => e.RefundDay).HasColumnName("REFUND_DAY");

                entity.Property(e => e.RefundLasttime).HasColumnName("REFUND_LASTTIME");

                entity.Property(e => e.Useonline).HasColumnName("USEONLINE");

                entity.HasOne(d => d.Hotel)
                    .WithMany(p => p.StdhotelRatetype)
                    .HasForeignKey(d => d.Hotelid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___HOTEL__386F4D83");
            });

            modelBuilder.Entity<StdhotelRatetypesAvailability>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STDHOTEL_RATETYPES_AVAILABILITY");

                entity.HasIndex(e => new { e.Corpid, e.Roomtypeid, e.Ratetypeid, e.Date, e.Marketid }, "UQ__STDHOTEL__448ED8D9FD7F18D1")
                    .IsUnique();

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("DATE");

                entity.Property(e => e.Definedquota).HasColumnName("DEFINEDQUOTA");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Marketid).HasColumnName("MARKETID");

                entity.Property(e => e.Ratetypeid).HasColumnName("RATETYPEID");

                entity.Property(e => e.Roomtypeid).HasColumnName("ROOMTYPEID");

                entity.HasOne(d => d.Market)
                    .WithMany()
                    .HasForeignKey(d => d.Marketid)
                    .HasConstraintName("FK__STDHOTEL___MARKE__05C3D225");

                entity.HasOne(d => d.Ratetype)
                    .WithMany()
                    .HasForeignKey(d => d.Ratetypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___RATET__7EECB764");

                entity.HasOne(d => d.Roomtype)
                    .WithMany()
                    .HasForeignKey(d => d.Roomtypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___ROOMT__06B7F65E");
            });

            modelBuilder.Entity<StdhotelRoomtypes>(entity =>
            {
                entity.ToTable("STDHOTEL_ROOMTYPES");

                entity.HasIndex(e => e.Roomgroup, "IX_STDHOTEL_ROOMTYPES");

                entity.HasIndex(e => e.Roomtype, "IX_STDHOTEL_ROOMTYPES_1");

                entity.HasIndex(e => e.Isdeleted, "IX_STDHOTEL_ROOMTYPES_2");

                entity.HasIndex(e => e.Isdisabled, "IX_STDHOTEL_ROOMTYPES_3");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.AdultRate)
                    .HasColumnName("ADULT_RATE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BabyRate)
                    .HasColumnName("BABY_RATE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BabycountsIncToBeds).HasColumnName("BABYCOUNTS_INC_TO_BEDS");

                entity.Property(e => e.ChildRate)
                    .HasColumnName("CHILD_RATE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Definition)
                    .HasMaxLength(50)
                    .HasColumnName("DEFINITION");

                entity.Property(e => e.Description).HasColumnName("DESCRIPTION");

                entity.Property(e => e.DisplayPersonCount).HasColumnName("DISPLAY_PERSON_COUNT");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.EntEtsid)
                    .HasMaxLength(50)
                    .HasColumnName("ENT_ETSID");

                entity.Property(e => e.EntHotelrunnerid)
                    .HasMaxLength(100)
                    .HasColumnName("ENT_HOTELRUNNERID");

                entity.Property(e => e.EntIatiid)
                    .HasMaxLength(50)
                    .HasColumnName("ENT_IATIID");

                entity.Property(e => e.EntId)
                    .HasMaxLength(50)
                    .HasColumnName("ENT_ID");

                entity.Property(e => e.EntJollytourid)
                    .HasMaxLength(150)
                    .HasColumnName("ENT_JOLLYTOURID");

                entity.Property(e => e.EntSednaid)
                    .HasMaxLength(250)
                    .HasColumnName("ENT_SEDNAID");

                entity.Property(e => e.EntSeturid)
                    .HasMaxLength(150)
                    .HasColumnName("ENT_SETURID");

                entity.Property(e => e.EntTatilbudurid)
                    .HasMaxLength(50)
                    .HasColumnName("ENT_TATILBUDURID");

                entity.Property(e => e.EntTouristicaid)
                    .HasMaxLength(50)
                    .HasColumnName("ENT_TOURISTICAID");

                entity.Property(e => e.EntTravelclickid)
                    .HasMaxLength(50)
                    .HasColumnName("ENT_TRAVELCLICKID");

                entity.Property(e => e.Hotelid).HasColumnName("HOTELID");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.Maxadultcount).HasColumnName("MAXADULTCOUNT");

                entity.Property(e => e.Maxbabycount).HasColumnName("MAXBABYCOUNT");

                entity.Property(e => e.Maxbedcount).HasColumnName("MAXBEDCOUNT");

                entity.Property(e => e.Maxchildcount).HasColumnName("MAXCHILDCOUNT");

                entity.Property(e => e.Minadultcount).HasColumnName("MINADULTCOUNT");

                entity.Property(e => e.Minbabycount).HasColumnName("MINBABYCOUNT");

                entity.Property(e => e.Minbedcount).HasColumnName("MINBEDCOUNT");

                entity.Property(e => e.Minchildcount).HasColumnName("MINCHILDCOUNT");

                entity.Property(e => e.Roomcount).HasColumnName("ROOMCOUNT");

                entity.Property(e => e.Roomgroup)
                    .HasMaxLength(50)
                    .HasColumnName("ROOMGROUP");

                entity.Property(e => e.Roomtype)
                    .HasMaxLength(6)
                    .HasColumnName("ROOMTYPE");

                entity.Property(e => e.Thumbnailimg)
                    .HasMaxLength(250)
                    .HasColumnName("THUMBNAILIMG");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.StdhotelRoomtypesAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .HasConstraintName("FK_STDHOTEL_ROOMTYPES_USERS");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.StdhotelRoomtypesEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK_STDHOTEL_ROOMTYPES_USERS1");

                entity.HasOne(d => d.Hotel)
                    .WithMany(p => p.StdhotelRoomtypes)
                    .HasForeignKey(d => d.Hotelid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___HOTEL__4A8310C6");

                entity.HasOne(d => d.RoomtypeNavigation)
                    .WithMany(p => p.StdhotelRoomtypes)
                    .HasForeignKey(d => d.Roomtype)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___ROOMT__4B7734FF");
            });

            modelBuilder.Entity<StdhotelRoomtypesAvailability>(entity =>
            {
                entity.ToTable("STDHOTEL_ROOMTYPES_AVAILABILITY");

                entity.HasIndex(e => new { e.Corpid, e.Date, e.Roomtypeid }, "UQ__STDHOTEL__E5B25094C12D3A70")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("DATE");

                entity.Property(e => e.Definedquota).HasColumnName("DEFINEDQUOTA");

                entity.Property(e => e.Releasedate)
                    .HasColumnType("date")
                    .HasColumnName("RELEASEDATE")
                    .HasComputedColumnSql("(dateadd(day, -[RELEASEDAYS],[DATE]))", true);

                entity.Property(e => e.Releasedays).HasColumnName("RELEASEDAYS");

                entity.Property(e => e.Roomtypeid).HasColumnName("ROOMTYPEID");

                entity.Property(e => e.Soldquota).HasColumnName("SOLDQUOTA");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.StdhotelRoomtypesAvailability)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___CORPI__0A888742");

                entity.HasOne(d => d.Roomtype)
                    .WithMany(p => p.StdhotelRoomtypesAvailability)
                    .HasForeignKey(d => d.Roomtypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___ROOMT__0B7CAB7B");
            });

            modelBuilder.Entity<StdhotelSeasons>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STDHOTEL_SEASONS");

                entity.Property(e => e.Hotelid).HasColumnName("HOTELID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Seasonfinish)
                    .HasColumnType("datetime")
                    .HasColumnName("SEASONFINISH");

                entity.Property(e => e.Seasonstart)
                    .HasColumnType("datetime")
                    .HasColumnName("SEASONSTART");

                entity.HasOne(d => d.Hotel)
                    .WithMany()
                    .HasForeignKey(d => d.Hotelid)
                    .HasConstraintName("FK__STDHOTEL___HOTEL__19FFD4FC");
            });

            modelBuilder.Entity<StdhotelStopsale>(entity =>
            {
                entity.ToTable("STDHOTEL_STOPSALE");

                entity.HasIndex(e => e.Corpid, "IX_CORP");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Fromdate)
                    .HasColumnType("date")
                    .HasColumnName("FROMDATE");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.Priceconditionid).HasColumnName("PRICECONDITIONID");

                entity.Property(e => e.Todate)
                    .HasColumnType("date")
                    .HasColumnName("TODATE");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.StdhotelStopsale)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___CORPI__0D64F3ED");

                entity.HasOne(d => d.Pricecondition)
                    .WithMany(p => p.StdhotelStopsale)
                    .HasForeignKey(d => d.Priceconditionid)
                    .HasConstraintName("FK__STDHOTEL___PRICE__6F8A7843");
            });

            modelBuilder.Entity<Stdhoteldiscount>(entity =>
            {
                entity.ToTable("STDHOTELDISCOUNT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Definition)
                    .HasMaxLength(50)
                    .HasColumnName("DEFINITION");
            });

            modelBuilder.Entity<Stdlanguages>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK__STDLANGU__AA1D4378C43472E9");

                entity.ToTable("STDLANGUAGES");

                entity.Property(e => e.Code)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CODE")
                    .IsFixedLength();

                entity.Property(e => e.Definition)
                    .HasMaxLength(100)
                    .HasColumnName("DEFINITION");
            });

            modelBuilder.Entity<StdmarketCountries>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__STDMARKE__3214EC2683C5DABB")
                    .IsClustered(false);

                entity.ToTable("STDMARKET_COUNTRIES");

                entity.HasIndex(e => e.Countrycode, "UQ__STDMARKE__FAC7CEB6C9F85917")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Countrycode)
                    .HasMaxLength(2)
                    .HasColumnName("COUNTRYCODE");

                entity.Property(e => e.Stdmarketid).HasColumnName("STDMARKETID");

                entity.HasOne(d => d.Stdmarket)
                    .WithMany(p => p.StdmarketCountries)
                    .HasForeignKey(d => d.Stdmarketid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDMARKET__STDMA__4A8DFDBE");
            });

            modelBuilder.Entity<Stdmarkets>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__STDMARKE__3214EC2650F9EF41")
                    .IsClustered(false);

                entity.ToTable("STDMARKETS");

                entity.HasIndex(e => new { e.Corpid, e.Definition }, "UQ__STDMARKE__D0FAF608463C925A")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Curcode)
                    .HasMaxLength(4)
                    .HasColumnName("CURCODE")
                    .IsFixedLength();

                entity.Property(e => e.Definition)
                    .HasMaxLength(50)
                    .HasColumnName("DEFINITION");

                entity.Property(e => e.ForceBaskettocurcode).HasColumnName("FORCE_BASKETTOCURCODE");

                entity.Property(e => e.Language)
                    .HasMaxLength(5)
                    .HasColumnName("LANGUAGE");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.Stdmarkets)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDMARKET__CORPI__0F4D3C5F");
            });

            modelBuilder.Entity<Stdroomtypes>(entity =>
            {
                entity.HasKey(e => e.Roomtype)
                    .HasName("PK__STDROOMT__D28E9DD16E29EB50");

                entity.ToTable("STDROOMTYPES");

                entity.Property(e => e.Roomtype)
                    .HasMaxLength(6)
                    .HasColumnName("ROOMTYPE");

                entity.Property(e => e.EntRoomtype)
                    .HasMaxLength(50)
                    .HasColumnName("ENT_ROOMTYPE");
            });

            modelBuilder.Entity<Stdstore>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__STDSTORE__3214EC26DBCE8B6A")
                    .IsClustered(false);

                entity.ToTable("STDSTORE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Addressid).HasColumnName("ADDRESSID");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Contact)
                    .HasMaxLength(200)
                    .HasColumnName("CONTACT");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Fax).HasColumnName("FAX");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .HasColumnName("NAME");

                entity.Property(e => e.Tel1).HasColumnName("TEL1");

                entity.Property(e => e.Tel2).HasColumnName("TEL2");

                entity.Property(e => e.Thumbnailurl)
                    .HasMaxLength(350)
                    .HasColumnName("THUMBNAILURL");

                entity.Property(e => e.Type).HasColumnName("TYPE");

                entity.Property(e => e.Typename)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TYPENAME")
                    .HasComputedColumnSql("(case [TYPE] when (0) then 'Restaurant'  end)", false);

                entity.Property(e => e.Webaddress)
                    .HasMaxLength(250)
                    .HasColumnName("WEBADDRESS");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Stdstore)
                    .HasForeignKey(d => d.Addressid)
                    .HasConstraintName("FK__STDSTORE__ADDRES__6ABBA185");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.StdstoreAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDSTORE__ADDUSE__6BAFC5BE");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.Stdstore)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDSTORE__CORPID__69C77D4C");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.StdstoreEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__STDSTORE__EDITUS__6CA3E9F7");
            });

            modelBuilder.Entity<StdstoreItemGroupItems>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__STDSTORE__3214EC2655910A0A")
                    .IsClustered(false);

                entity.ToTable("STDSTORE_ITEM_GROUP_ITEMS");

                entity.HasIndex(e => new { e.Groupid, e.Itemid }, "UQ__STDSTORE__98E91DBD6E833329")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Groupid).HasColumnName("GROUPID");

                entity.Property(e => e.Itemid).HasColumnName("ITEMID");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.StdstoreItemGroupItemsAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDSTORE___ADDUS__02932B16");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.StdstoreItemGroupItemsEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__STDSTORE___EDITU__03874F4F");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.StdstoreItemGroupItems)
                    .HasForeignKey(d => d.Groupid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDSTORE___GROUP__00AAE2A4");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.StdstoreItemGroupItems)
                    .HasForeignKey(d => d.Itemid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDSTORE___ITEMI__019F06DD");
            });

            modelBuilder.Entity<StdstoreItemGroups>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__STDSTORE__3214EC26253554E9")
                    .IsClustered(false);

                entity.ToTable("STDSTORE_ITEM_GROUPS");

                entity.HasIndex(e => new { e.Storeid, e.Definition }, "UQ__STDSTORE__C467D422F9DABF61")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Definition)
                    .HasMaxLength(120)
                    .HasColumnName("DEFINITION");

                entity.Property(e => e.Description).HasColumnName("DESCRIPTION");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.Showinportal).HasColumnName("SHOWINPORTAL");

                entity.Property(e => e.Sortindex).HasColumnName("SORTINDEX");

                entity.Property(e => e.Storeid).HasColumnName("STOREID");

                entity.Property(e => e.Thumbnailurl)
                    .HasMaxLength(350)
                    .HasColumnName("THUMBNAILURL");

                entity.Property(e => e.Title).HasColumnName("TITLE");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.StdstoreItemGroupsAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDSTORE___ADDUS__056F97C1");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.StdstoreItemGroupsEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__STDSTORE___EDITU__0663BBFA");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.StdstoreItemGroups)
                    .HasForeignKey(d => d.Storeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDSTORE___STORE__047B7388");
            });

            modelBuilder.Entity<StdstoreItemImages>(entity =>
            {
                entity.ToTable("STDSTORE_ITEM_IMAGES");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Default).HasColumnName("DEFAULT");

                entity.Property(e => e.Definition)
                    .HasMaxLength(100)
                    .HasColumnName("DEFINITION");

                entity.Property(e => e.Description).HasColumnName("DESCRIPTION");

                entity.Property(e => e.Sortorder).HasColumnName("SORTORDER");

                entity.Property(e => e.StoreItemSizesid).HasColumnName("STORE_ITEM_SIZESID");

                entity.Property(e => e.StoreItemid).HasColumnName("STORE_ITEMID");

                entity.Property(e => e.Thumbnail)
                    .HasMaxLength(250)
                    .HasColumnName("THUMBNAIL");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Url)
                    .HasMaxLength(250)
                    .HasColumnName("URL");

                entity.HasOne(d => d.StoreItemSizes)
                    .WithMany(p => p.StdstoreItemImages)
                    .HasForeignKey(d => d.StoreItemSizesid)
                    .HasConstraintName("FK_STDSTORE_ITEM_IMAGES_STDSTORE_ITEM_SIZES");

                entity.HasOne(d => d.StoreItem)
                    .WithMany(p => p.StdstoreItemImages)
                    .HasForeignKey(d => d.StoreItemid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__STDSTORE___STORE__52EE3995");
            });

            modelBuilder.Entity<StdstoreItemIngredients>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__STDSTORE__3214EC26D03F377E")
                    .IsClustered(false);

                entity.ToTable("STDSTORE_ITEM_INGREDIENTS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Definition)
                    .HasMaxLength(75)
                    .HasColumnName("DEFINITION");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.StoreItemSizesid).HasColumnName("STORE_ITEM_SIZESID");

                entity.Property(e => e.StoreItemid).HasColumnName("STORE_ITEMID");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.StdstoreItemIngredients)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDSTORE___ADDUS__4278A601");

                entity.HasOne(d => d.StoreItemSizes)
                    .WithMany(p => p.StdstoreItemIngredients)
                    .HasForeignKey(d => d.StoreItemSizesid)
                    .HasConstraintName("FK__STDSTORE___STORE__4460EE73");

                entity.HasOne(d => d.StoreItem)
                    .WithMany(p => p.StdstoreItemIngredients)
                    .HasForeignKey(d => d.StoreItemid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDSTORE___STORE__436CCA3A");
            });

            modelBuilder.Entity<StdstoreItemPrices>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__STDSTORE__3214EC26971CC529")
                    .IsClustered(false);

                entity.ToTable("STDSTORE_ITEM_PRICES");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Curcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CURCODE")
                    .IsFixedLength();

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.OnlinePrice).HasColumnName("ONLINE_PRICE");

                entity.Property(e => e.Selldays)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("SELLDAYS")
                    .IsFixedLength();

                entity.Property(e => e.Sellend)
                    .HasColumnType("date")
                    .HasColumnName("SELLEND");

                entity.Property(e => e.Sellstart)
                    .HasColumnType("date")
                    .HasColumnName("SELLSTART");

                entity.Property(e => e.StoreItemSizesid).HasColumnName("STORE_ITEM_SIZESID");

                entity.Property(e => e.StoreItemid).HasColumnName("STORE_ITEMID");

                entity.Property(e => e.StorePrice).HasColumnName("STORE_PRICE");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.StdstoreItemPrices)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDSTORE___ADDUS__725CC34D");

                entity.HasOne(d => d.CurcodeNavigation)
                    .WithMany(p => p.StdstoreItemPrices)
                    .HasForeignKey(d => d.Curcode)
                    .HasConstraintName("FK__STDSTORE___CURCO__71689F14");

                entity.HasOne(d => d.StoreItemSizes)
                    .WithMany(p => p.StdstoreItemPrices)
                    .HasForeignKey(d => d.StoreItemSizesid)
                    .HasConstraintName("FK__STDSTORE___STORE__70747ADB");

                entity.HasOne(d => d.StoreItem)
                    .WithMany(p => p.StdstoreItemPrices)
                    .HasForeignKey(d => d.StoreItemid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDSTORE___STORE__6F8056A2");
            });

            modelBuilder.Entity<StdstoreItemPricesIngredients>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__STDSTORE__3214EC2654ABE1A8")
                    .IsClustered(false);

                entity.ToTable("STDSTORE_ITEM_PRICES_INGREDIENTS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Ingredientid).HasColumnName("INGREDIENTID");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Price).HasColumnName("PRICE");

                entity.Property(e => e.Priceid).HasColumnName("PRICEID");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.StdstoreItemPricesIngredients)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDSTORE___ADDUS__4A19C7C9");

                entity.HasOne(d => d.Ingredient)
                    .WithMany(p => p.StdstoreItemPricesIngredients)
                    .HasForeignKey(d => d.Ingredientid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDSTORE___INGRE__473D5B1E");

                entity.HasOne(d => d.PriceNavigation)
                    .WithMany(p => p.StdstoreItemPricesIngredients)
                    .HasForeignKey(d => d.Priceid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDSTORE___PRICE__4B0DEC02");
            });

            modelBuilder.Entity<StdstoreItemSizes>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__STDSTORE__3214EC26C8131450")
                    .IsClustered(false);

                entity.ToTable("STDSTORE_ITEM_SIZES");

                entity.HasIndex(e => new { e.StoreItemid, e.Definition }, "UQ__STDSTORE__92B9D130B75A427A")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Definition)
                    .HasMaxLength(200)
                    .HasColumnName("DEFINITION");

                entity.Property(e => e.Description).HasColumnName("DESCRIPTION");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.StoreItemid).HasColumnName("STORE_ITEMID");
            });

            modelBuilder.Entity<StdstoreItems>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__STDSTORE__3214EC267139131B")
                    .IsClustered(false);

                entity.ToTable("STDSTORE_ITEMS");

                entity.HasIndex(e => new { e.Storeid, e.Definition }, "UQ__STDSTORE__C467D422F4172951")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Definition)
                    .HasMaxLength(200)
                    .HasColumnName("DEFINITION");

                entity.Property(e => e.Description).HasColumnName("DESCRIPTION");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.Storeid).HasColumnName("STOREID");
            });

            modelBuilder.Entity<StdstoreItemsGroups>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__STDSTORE__3214EC26FE38D331")
                    .IsClustered(false);

                entity.ToTable("STDSTORE_ITEMS_GROUPS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Groupid).HasColumnName("GROUPID");

                entity.Property(e => e.Itemid).HasColumnName("ITEMID");

                entity.Property(e => e.Sortindex).HasColumnName("SORTINDEX");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.StdstoreItemsGroups)
                    .HasForeignKey(d => d.Groupid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDSTORE___GROUP__470850F4");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.StdstoreItemsGroups)
                    .HasForeignKey(d => d.Itemid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDSTORE___ITEMI__47FC752D");
            });

            modelBuilder.Entity<Stdvehicletypes>(entity =>
            {
                entity.HasKey(e => e.Vehicletype)
                    .HasName("PK__STDVEHIC__560C00BC2A4F60DA");

                entity.ToTable("STDVEHICLETYPES");

                entity.Property(e => e.Vehicletype)
                    .HasMaxLength(40)
                    .HasColumnName("VEHICLETYPE");

                entity.Property(e => e.Imgtype)
                    .HasMaxLength(30)
                    .HasColumnName("IMGTYPE");
            });

            modelBuilder.Entity<Survey>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__SURVEY__3214EC2657C407BC")
                    .IsClustered(false);

                entity.ToTable("SURVEY");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Confirmbefore).HasColumnName("CONFIRMBEFORE");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Description).HasColumnName("DESCRIPTION");

                entity.Property(e => e.Design).HasColumnName("DESIGN");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Exitlinkvisible).HasColumnName("EXITLINKVISIBLE");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.Questionnumbers)
                    .IsRequired()
                    .HasColumnName("QUESTIONNUMBERS")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Requiredmarks)
                    .IsRequired()
                    .HasColumnName("REQUIREDMARKS")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Title)
                    .HasMaxLength(250)
                    .HasColumnName("TITLE");

                entity.Property(e => e.Titlevisible)
                    .IsRequired()
                    .HasColumnName("TITLEVISIBLE")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.SurveyAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SURVEY__ADDUSER__3BB5CE82");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.Survey)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SURVEY__CORPID__35FCF52C");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.SurveyEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__SURVEY__EDITUSER__3D9E16F4");
            });

            modelBuilder.Entity<SurveyAnsweroptions>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__SURVEY_A__3214EC26FB0AD76D")
                    .IsClustered(false);

                entity.ToTable("SURVEY_ANSWEROPTIONS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Answer)
                    .HasMaxLength(250)
                    .HasColumnName("ANSWER");

                entity.Property(e => e.Checked).HasColumnName("CHECKED");

                entity.Property(e => e.Istrueanswer).HasColumnName("ISTRUEANSWER");

                entity.Property(e => e.Point).HasColumnName("POINT");

                entity.Property(e => e.Qanswer)
                    .HasMaxLength(250)
                    .HasColumnName("QANSWER");

                entity.Property(e => e.Questionid).HasColumnName("QUESTIONID");

                entity.Property(e => e.Surveysid).HasColumnName("SURVEYSID");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.SurveyAnsweroptions)
                    .HasForeignKey(d => d.Questionid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SURVEY_AN__QUEST__73FA27A5");

                entity.HasOne(d => d.Surveys)
                    .WithMany(p => p.SurveyAnsweroptions)
                    .HasForeignKey(d => d.Surveysid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SURVEY_AN__SURVE__7306036C");
            });

            modelBuilder.Entity<SurveyAnswers>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__SURVEY_A__3214EC26CA6CFBBC")
                    .IsClustered(false);

                entity.ToTable("SURVEY_ANSWERS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Answer)
                    .HasMaxLength(250)
                    .HasColumnName("ANSWER");

                entity.Property(e => e.Otheranswer)
                    .HasMaxLength(250)
                    .HasColumnName("OTHERANSWER");

                entity.Property(e => e.Otherisanswer).HasColumnName("OTHERISANSWER");

                entity.Property(e => e.Question)
                    .HasMaxLength(250)
                    .HasColumnName("QUESTION");

                entity.Property(e => e.Questionid).HasColumnName("QUESTIONID");

                entity.Property(e => e.Required).HasColumnName("REQUIRED");

                entity.Property(e => e.Surveysid).HasColumnName("SURVEYSID");

                entity.Property(e => e.Type).HasColumnName("TYPE");

                entity.Property(e => e.Useother).HasColumnName("USEOTHER");

                entity.HasOne(d => d.Surveys)
                    .WithMany(p => p.SurveyAnswers)
                    .HasForeignKey(d => d.Surveysid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SURVEY_AN__SURVE__6C5905DD");
            });

            modelBuilder.Entity<Surveys>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__SURVEYS__3214EC2690F7C131")
                    .IsClustered(false);

                entity.ToTable("SURVEYS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Personid).HasColumnName("PERSONID");

                entity.Property(e => e.Starttime)
                    .HasColumnType("datetime")
                    .HasColumnName("STARTTIME");

                entity.Property(e => e.Surveyid).HasColumnName("SURVEYID");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.SurveysAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SURVEYS__ADDUSER__66A02C87");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.SurveysEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__SURVEYS__EDITUSE__688874F9");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Surveys)
                    .HasForeignKey(d => d.Personid)
                    .HasConstraintName("FK__SURVEYS__PERSONI__63C3BFDC");

                entity.HasOne(d => d.Survey)
                    .WithMany(p => p.Surveys)
                    .HasForeignKey(d => d.Surveyid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SURVEYS__SURVEYI__64B7E415");
            });

            modelBuilder.Entity<SwicthboardLog>(entity =>
            {
                entity.ToTable("SWICTHBOARD_LOG");

                entity.HasIndex(e => e.Adddate, "IX_SWICTHBOARD_LOG");

                entity.HasIndex(e => e.Logkey, "IX_SWICTHBOARD_LOG_1");

                entity.HasIndex(e => new { e.Logkey, e.Adddate }, "IX_SWICTHBOARD_LOG_2");

                entity.HasIndex(e => e.Linkedid, "IX_SWICTHBOARD_LOG_3");

                entity.HasIndex(e => e.Dstchannel, "IX_SWICTHBOARD_LOG_4");

                entity.HasIndex(e => new { e.Clid, e.Dstchannel }, "IX_SWICTHBOARD_LOG_5");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accountcode)
                    .HasMaxLength(50)
                    .HasColumnName("ACCOUNTCODE");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Campaignname)
                    .HasMaxLength(150)
                    .HasColumnName("CAMPAIGNNAME");

                entity.Property(e => e.Cause).HasColumnName("CAUSE");

                entity.Property(e => e.Causetxt)
                    .HasMaxLength(150)
                    .HasColumnName("CAUSETXT");

                entity.Property(e => e.Channelstate).HasColumnName("CHANNELSTATE");

                entity.Property(e => e.Channelstatedesc)
                    .HasMaxLength(90)
                    .HasColumnName("CHANNELSTATEDESC");

                entity.Property(e => e.Clid)
                    .HasMaxLength(80)
                    .HasColumnName("CLID");

                entity.Property(e => e.Dst)
                    .HasMaxLength(80)
                    .HasColumnName("DST");

                entity.Property(e => e.Dstchannel)
                    .HasMaxLength(80)
                    .HasColumnName("DSTCHANNEL");

                entity.Property(e => e.Jsondata).HasColumnName("JSONDATA");

                entity.Property(e => e.Linkedid)
                    .HasMaxLength(50)
                    .HasColumnName("LINKEDID");

                entity.Property(e => e.Logkey)
                    .HasMaxLength(50)
                    .HasColumnName("LOGKEY");
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__TICKET__3214EC269EB03149")
                    .IsClustered(false);

                entity.ToTable("TICKET");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Adultmandatory)
                    .HasColumnName("ADULTMANDATORY")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Childmandatory).HasColumnName("CHILDMANDATORY");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Definition)
                    .HasMaxLength(200)
                    .HasColumnName("DEFINITION");

                entity.Property(e => e.Description).HasColumnName("DESCRIPTION");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Endofminute).HasColumnName("ENDOFMINUTE");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.Maxselldate).HasColumnName("MAXSELLDATE");

                entity.Property(e => e.Plu)
                    .HasMaxLength(10)
                    .HasColumnName("PLU");

                entity.Property(e => e.Sortorder).HasColumnName("SORTORDER");

                entity.Property(e => e.Tickettype)
                    .HasColumnName("TICKETTYPE")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.TicketAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TICKET__ADDUSER__4FA7B896");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.Ticket)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TICKET__CORPID__4BD727B2");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.TicketEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__TICKET__EDITUSER__51900108");
            });

            modelBuilder.Entity<TicketActivations>(entity =>
            {
                entity.ToTable("TICKET_ACTIVATIONS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Direction).HasColumnName("DIRECTION");

                entity.Property(e => e.Gatenumber)
                    .HasMaxLength(30)
                    .HasColumnName("GATENUMBER");

                entity.Property(e => e.Isallow).HasColumnName("ISALLOW");

                entity.Property(e => e.Personno).HasColumnName("PERSONNO");

                entity.Property(e => e.Persontype)
                    .HasMaxLength(15)
                    .HasColumnName("PERSONTYPE");

                entity.Property(e => e.Reason)
                    .HasMaxLength(250)
                    .HasColumnName("REASON");

                entity.Property(e => e.RequestDetailid).HasColumnName("REQUEST_DETAILID");

                entity.HasOne(d => d.GatenumberNavigation)
                    .WithMany(p => p.TicketActivations)
                    .HasForeignKey(d => d.Gatenumber)
                    .HasConstraintName("FK__TICKET_AC__GATEN__131DCD43");

                entity.HasOne(d => d.RequestDetail)
                    .WithMany(p => p.TicketActivations)
                    .HasForeignKey(d => d.RequestDetailid)
                    .HasConstraintName("FK__TICKET_AC__REQUE__5110DE1B");
            });

            modelBuilder.Entity<TicketGifts>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__TICKET_G__3214EC26E60638C6")
                    .IsClustered(false);

                entity.ToTable("TICKET_GIFTS");

                entity.HasIndex(e => new { e.Corpid, e.Definition }, "UQ__TICKET_G__D0FAF60846C03765")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Curcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CURCODE")
                    .IsFixedLength();

                entity.Property(e => e.Definition)
                    .HasMaxLength(100)
                    .HasColumnName("DEFINITION");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.Plu)
                    .HasMaxLength(10)
                    .HasColumnName("PLU");

                entity.Property(e => e.Price).HasColumnName("PRICE");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.TicketGifts)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TICKET_GI__CORPI__150615B5");

                entity.HasOne(d => d.CurcodeNavigation)
                    .WithMany(p => p.TicketGifts)
                    .HasForeignKey(d => d.Curcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TICKET_GI__CURCO__15FA39EE");
            });

            modelBuilder.Entity<TicketHours>(entity =>
            {
                entity.ToTable("TICKET_HOURS");

                entity.HasIndex(e => e.Datesort, "IX_TICKET_HOURS");

                entity.HasIndex(e => new { e.Startdate, e.Enddate }, "IX_TICKET_HOURS_1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Capacity).HasColumnName("CAPACITY");

                entity.Property(e => e.Datesort)
                    .HasColumnName("DATESORT")
                    .HasComputedColumnSql("(datediff(day,[STARTDATE],[ENDDATE]))", true);

                entity.Property(e => e.Definition)
                    .HasMaxLength(100)
                    .HasColumnName("DEFINITION");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Enddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ENDDATE");

                entity.Property(e => e.FridayEndtime)
                    .HasColumnName("FRIDAY_ENDTIME")
                    .HasDefaultValueSql("((23))");

                entity.Property(e => e.FridayEndtimeM)
                    .HasColumnName("FRIDAY_ENDTIME_M")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FridayMaxrescount).HasColumnName("FRIDAY_MAXRESCOUNT");

                entity.Property(e => e.FridayStarttime)
                    .HasColumnName("FRIDAY_STARTTIME")
                    .HasDefaultValueSql("((9))");

                entity.Property(e => e.FridayStarttimeM)
                    .HasColumnName("FRIDAY_STARTTIME_M")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FridayUse)
                    .IsRequired()
                    .HasColumnName("FRIDAY_USE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Minuteperiod)
                    .HasColumnName("MINUTEPERIOD")
                    .HasDefaultValueSql("((30))");

                entity.Property(e => e.MondayEndtime)
                    .HasColumnName("MONDAY_ENDTIME")
                    .HasDefaultValueSql("((23))");

                entity.Property(e => e.MondayEndtimeM)
                    .HasColumnName("MONDAY_ENDTIME_M")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MondayMaxrescount).HasColumnName("MONDAY_MAXRESCOUNT");

                entity.Property(e => e.MondayStarttime)
                    .HasColumnName("MONDAY_STARTTIME")
                    .HasDefaultValueSql("((9))");

                entity.Property(e => e.MondayStarttimeM)
                    .HasColumnName("MONDAY_STARTTIME_M")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MondayUse)
                    .IsRequired()
                    .HasColumnName("MONDAY_USE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SaturdayEndtime)
                    .HasColumnName("SATURDAY_ENDTIME")
                    .HasDefaultValueSql("((23))");

                entity.Property(e => e.SaturdayEndtimeM)
                    .HasColumnName("SATURDAY_ENDTIME_M")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SaturdayMaxrescount).HasColumnName("SATURDAY_MAXRESCOUNT");

                entity.Property(e => e.SaturdayStarttime)
                    .HasColumnName("SATURDAY_STARTTIME")
                    .HasDefaultValueSql("((9))");

                entity.Property(e => e.SaturdayStarttimeM)
                    .HasColumnName("SATURDAY_STARTTIME_M")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SaturdayUse)
                    .IsRequired()
                    .HasColumnName("SATURDAY_USE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Startdate)
                    .HasColumnType("datetime")
                    .HasColumnName("STARTDATE");

                entity.Property(e => e.SundayEndtime)
                    .HasColumnName("SUNDAY_ENDTIME")
                    .HasDefaultValueSql("((23))");

                entity.Property(e => e.SundayEndtimeM)
                    .HasColumnName("SUNDAY_ENDTIME_M")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SundayMaxrescount).HasColumnName("SUNDAY_MAXRESCOUNT");

                entity.Property(e => e.SundayStarttime)
                    .HasColumnName("SUNDAY_STARTTIME")
                    .HasDefaultValueSql("((9))");

                entity.Property(e => e.SundayStarttimeM)
                    .HasColumnName("SUNDAY_STARTTIME_M")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SundayUse)
                    .IsRequired()
                    .HasColumnName("SUNDAY_USE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ThursdayEndtime)
                    .HasColumnName("THURSDAY_ENDTIME")
                    .HasDefaultValueSql("((23))");

                entity.Property(e => e.ThursdayEndtimeM)
                    .HasColumnName("THURSDAY_ENDTIME_M")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ThursdayMaxrescount).HasColumnName("THURSDAY_MAXRESCOUNT");

                entity.Property(e => e.ThursdayStarttime)
                    .HasColumnName("THURSDAY_STARTTIME")
                    .HasDefaultValueSql("((9))");

                entity.Property(e => e.ThursdayStarttimeM)
                    .HasColumnName("THURSDAY_STARTTIME_M")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ThursdayUse)
                    .IsRequired()
                    .HasColumnName("THURSDAY_USE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Ticketid).HasColumnName("TICKETID");

                entity.Property(e => e.TuesdayEndtime)
                    .HasColumnName("TUESDAY_ENDTIME")
                    .HasDefaultValueSql("((23))");

                entity.Property(e => e.TuesdayEndtimeM)
                    .HasColumnName("TUESDAY_ENDTIME_M")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TuesdayMaxrescount).HasColumnName("TUESDAY_MAXRESCOUNT");

                entity.Property(e => e.TuesdayStarttime)
                    .HasColumnName("TUESDAY_STARTTIME")
                    .HasDefaultValueSql("((9))");

                entity.Property(e => e.TuesdayStarttimeM)
                    .HasColumnName("TUESDAY_STARTTIME_M")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TuesdayUse)
                    .IsRequired()
                    .HasColumnName("TUESDAY_USE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.WednesdayEndtime)
                    .HasColumnName("WEDNESDAY_ENDTIME")
                    .HasDefaultValueSql("((23))");

                entity.Property(e => e.WednesdayEndtimeM)
                    .HasColumnName("WEDNESDAY_ENDTIME_M")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WednesdayMaxrescount).HasColumnName("WEDNESDAY_MAXRESCOUNT");

                entity.Property(e => e.WednesdayStarttime)
                    .HasColumnName("WEDNESDAY_STARTTIME")
                    .HasDefaultValueSql("((9))");

                entity.Property(e => e.WednesdayStarttimeM)
                    .HasColumnName("WEDNESDAY_STARTTIME_M")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WednesdayUse)
                    .IsRequired()
                    .HasColumnName("WEDNESDAY_USE")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.TicketHoursAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TICKET_HO__ADDUS__5DF5D7ED");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.TicketHoursEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__TICKET_HO__EDITU__5EE9FC26");

                entity.HasOne(d => d.Ticket)
                    .WithMany(p => p.TicketHours)
                    .HasForeignKey(d => d.Ticketid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TICKET_HO__TICKE__546C6DB3");
            });

            modelBuilder.Entity<TicketMarket>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__TICKET_M__3214EC260690C17D")
                    .IsClustered(false);

                entity.ToTable("TICKET_MARKET");

                entity.HasIndex(e => new { e.Corpid, e.Definition, e.Isdeleted }, "UQ__TICKET_M__BDFB08EC06F75109")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Definition)
                    .HasMaxLength(250)
                    .HasColumnName("DEFINITION");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Stdmarketid).HasColumnName("STDMARKETID");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.TicketMarketAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TICKET_MA__ADDUS__19CACAD2");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.TicketMarket)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TICKET_MA__CORPI__1ABEEF0B");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.TicketMarketEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__TICKET_MA__EDITU__1BB31344");

                entity.HasOne(d => d.Stdmarket)
                    .WithMany(p => p.TicketMarket)
                    .HasForeignKey(d => d.Stdmarketid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TICKET_MARKET_STDMARKETS");
            });

            modelBuilder.Entity<TicketPrices>(entity =>
            {
                entity.ToTable("TICKET_PRICES");

                entity.HasIndex(e => e.Pricesort, "IX_TICKET_PRICES");

                entity.HasIndex(e => new { e.Sellfrom, e.Sellto, e.Ticketdatefrom, e.Ticketdateto, e.Checkindays, e.Maxvalidcapacity }, "IX_TICKET_PRICES_1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Adultprice)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("ADULTPRICE");

                entity.Property(e => e.Agencyid).HasColumnName("AGENCYID");

                entity.Property(e => e.Checkindays)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("CHECKINDAYS")
                    .IsFixedLength();

                entity.Property(e => e.Childprice)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("CHILDPRICE");

                entity.Property(e => e.Curcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CURCODE")
                    .IsFixedLength();

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Marketid).HasColumnName("MARKETID");

                entity.Property(e => e.Maxvalidcapacity).HasColumnName("MAXVALIDCAPACITY");

                entity.Property(e => e.Pricekind)
                    .HasColumnName("PRICEKIND")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Pricesort)
                    .HasColumnName("PRICESORT")
                    .HasComputedColumnSql("(((((case when [SELLFROM] IS NOT NULL then (1) else (0) end+case when [SELLTO] IS NOT NULL then (1) else (0) end)+case when [TICKETDATEFROM] IS NOT NULL then (1) else (0) end)+case when [TICKETDATETO] IS NOT NULL then (1) else (0) end)+case when [CHECKINDAYS] IS NOT NULL then (1) else (0) end)+case when [MAXVALIDCAPACITY] IS NOT NULL then (1) else (0) end)", true);

                entity.Property(e => e.Pricetype)
                    .HasColumnName("PRICETYPE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Sellfrom)
                    .HasColumnType("datetime")
                    .HasColumnName("SELLFROM");

                entity.Property(e => e.Sellto)
                    .HasColumnType("datetime")
                    .HasColumnName("SELLTO");

                entity.Property(e => e.Ticketdatefrom)
                    .HasColumnType("datetime")
                    .HasColumnName("TICKETDATEFROM");

                entity.Property(e => e.Ticketdateto)
                    .HasColumnType("datetime")
                    .HasColumnName("TICKETDATETO");

                entity.Property(e => e.Ticketid).HasColumnName("TICKETID");

                entity.Property(e => e.Unitprice).HasColumnName("UNITPRICE");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.TicketPricesAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TICKET_PR__ADDUS__60D24498");

                entity.HasOne(d => d.Agency)
                    .WithMany(p => p.TicketPrices)
                    .HasForeignKey(d => d.Agencyid)
                    .HasConstraintName("FK__TICKET_PR__AGENC__1CA7377D");

                entity.HasOne(d => d.CurcodeNavigation)
                    .WithMany(p => p.TicketPrices)
                    .HasForeignKey(d => d.Curcode)
                    .HasConstraintName("FK__TICKET_PR__CURCO__593122D0");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.TicketPricesEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__TICKET_PR__EDITU__61C668D1");

                entity.HasOne(d => d.Market)
                    .WithMany(p => p.TicketPrices)
                    .HasForeignKey(d => d.Marketid)
                    .HasConstraintName("FK_TICKET_PRICES_STDMARKETS");

                entity.HasOne(d => d.Ticket)
                    .WithMany(p => p.TicketPrices)
                    .HasForeignKey(d => d.Ticketid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TICKET_PR__TICKE__5748DA5E");
            });

            modelBuilder.Entity<TileItemoption>(entity =>
            {
                entity.ToTable("TILE_ITEMOPTION");

                entity.HasIndex(e => e.Ticketid, "UQ__TILE_ITE__19441072D123C1A9");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bgimage)
                    .HasColumnType("image")
                    .HasColumnName("BGIMAGE");

                entity.Property(e => e.Bgimage2)
                    .HasColumnType("image")
                    .HasColumnName("BGIMAGE2");

                entity.Property(e => e.BgimageAlign)
                    .HasMaxLength(35)
                    .HasColumnName("BGIMAGE_ALIGN");

                entity.Property(e => e.BgimageAlign2)
                    .HasMaxLength(25)
                    .HasColumnName("BGIMAGE_ALIGN2");

                entity.Property(e => e.BgimageMode)
                    .HasMaxLength(25)
                    .HasColumnName("BGIMAGE_MODE");

                entity.Property(e => e.BgimageMode2)
                    .HasMaxLength(25)
                    .HasColumnName("BGIMAGE_MODE2");

                entity.Property(e => e.Giftid).HasColumnName("GIFTID");

                entity.Property(e => e.GradientBegincolor).HasColumnName("GRADIENT_BEGINCOLOR");

                entity.Property(e => e.GradientEndcolor).HasColumnName("GRADIENT_ENDCOLOR");

                entity.Property(e => e.Groupid).HasColumnName("GROUPID");

                entity.Property(e => e.RowCount)
                    .HasColumnName("ROW_COUNT")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.Size).HasColumnName("SIZE");

                entity.Property(e => e.Sortorder).HasColumnName("SORTORDER");

                entity.Property(e => e.Ticketid).HasColumnName("TICKETID");

                entity.HasOne(d => d.Gift)
                    .WithMany(p => p.TileItemoption)
                    .HasForeignKey(d => d.Giftid)
                    .HasConstraintName("FK__TILE_ITEM__GIFTI__41E3A924");

                entity.HasOne(d => d.Ticket)
                    .WithMany(p => p.TileItemoption)
                    .HasForeignKey(d => d.Ticketid)
                    .HasConstraintName("FK__TILE_ITEM__TICKE__6379A719");
            });

            modelBuilder.Entity<Tour>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__TOUR__3214EC26A3D5EF82")
                    .IsClustered(false);

                entity.ToTable("TOUR");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Adultcapacity)
                    .HasColumnName("ADULTCAPACITY")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BabyMaxage).HasColumnName("BABY_MAXAGE");

                entity.Property(e => e.Babycapacity).HasColumnName("BABYCAPACITY");

                entity.Property(e => e.Boardtype)
                    .HasMaxLength(100)
                    .HasColumnName("BOARDTYPE");

                entity.Property(e => e.ChdeMaxage).HasColumnName("CHDE_MAXAGE");

                entity.Property(e => e.ChdyMaxage).HasColumnName("CHDY_MAXAGE");

                entity.Property(e => e.Childcapacity).HasColumnName("CHILDCAPACITY");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Description)
                    .HasMaxLength(70)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Intid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("INTID");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.TotalDays)
                    .HasColumnName("TOTAL_DAYS")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TripLocations).HasColumnName("TRIP_LOCATIONS");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.TourAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TOUR__ADDUSER__24485945");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.Tour)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TOUR__CORPID__253C7D7E");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.TourEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__TOUR__EDITUSER__2630A1B7");
            });

            modelBuilder.Entity<TourDiscounts>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__TOUR_DIS__3214EC26B2016A5E")
                    .IsClustered(false);

                entity.ToTable("TOUR_DISCOUNTS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Applytype).HasColumnName("APPLYTYPE");

                entity.Property(e => e.Definition)
                    .HasMaxLength(50)
                    .HasColumnName("DEFINITION");

                entity.Property(e => e.Discount).HasColumnName("DISCOUNT");

                entity.Property(e => e.Discounttype).HasColumnName("DISCOUNTTYPE");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Maxpax).HasColumnName("MAXPAX");

                entity.Property(e => e.Maxprice).HasColumnName("MAXPRICE");

                entity.Property(e => e.Minpax).HasColumnName("MINPAX");

                entity.Property(e => e.Minprice).HasColumnName("MINPRICE");

                entity.Property(e => e.Sellfrom)
                    .HasColumnType("datetime")
                    .HasColumnName("SELLFROM");

                entity.Property(e => e.Sellto)
                    .HasColumnType("datetime")
                    .HasColumnName("SELLTO");

                entity.Property(e => e.Tourfrom)
                    .HasColumnType("datetime")
                    .HasColumnName("TOURFROM");

                entity.Property(e => e.Tourid).HasColumnName("TOURID");

                entity.Property(e => e.Tourto)
                    .HasColumnType("datetime")
                    .HasColumnName("TOURTO");

                entity.Property(e => e.Validcount).HasColumnName("VALIDCOUNT");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.TourDiscountsAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TOUR_DISC__ADDUS__66161CA2");

                entity.HasOne(d => d.DiscounttypeNavigation)
                    .WithMany(p => p.TourDiscounts)
                    .HasForeignKey(d => d.Discounttype)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TOUR_DISC__DISCO__61516785");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.TourDiscountsEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__TOUR_DISC__EDITU__670A40DB");

                entity.HasOne(d => d.Tour)
                    .WithMany(p => p.TourDiscounts)
                    .HasForeignKey(d => d.Tourid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TOUR_DISC__TOURI__605D434C");
            });

            modelBuilder.Entity<TourImages>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TOUR_IMAGES");

                entity.Property(e => e.Default).HasColumnName("DEFAULT");

                entity.Property(e => e.Definition)
                    .HasMaxLength(100)
                    .HasColumnName("DEFINITION");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Sortorder).HasColumnName("SORTORDER");

                entity.Property(e => e.Thumbnail)
                    .HasMaxLength(250)
                    .HasColumnName("THUMBNAIL");

                entity.Property(e => e.TourProgramid).HasColumnName("TOUR_PROGRAMID");

                entity.Property(e => e.Tourid).HasColumnName("TOURID");

                entity.Property(e => e.Url)
                    .HasMaxLength(250)
                    .HasColumnName("URL");

                entity.HasOne(d => d.TourProgram)
                    .WithMany()
                    .HasForeignKey(d => d.TourProgramid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__TOUR_IMAG__TOUR___2AF556D4");

                entity.HasOne(d => d.Tour)
                    .WithMany()
                    .HasForeignKey(d => d.Tourid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TOUR_IMAG__TOURI__2BE97B0D");
            });

            modelBuilder.Entity<TourPrices>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__TOUR_PRI__3214EC262F119988")
                    .IsClustered(false);

                entity.ToTable("TOUR_PRICES");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Baby)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("BABY");

                entity.Property(e => e.Chde)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("CHDE");

                entity.Property(e => e.Chdy)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("CHDY");

                entity.Property(e => e.Commissionincluded)
                    .HasColumnName("COMMISSIONINCLUDED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Commissionpercent).HasColumnName("COMMISSIONPERCENT");

                entity.Property(e => e.Curcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CURCODE")
                    .IsFixedLength();

                entity.Property(e => e.Dbl)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("DBL");

                entity.Property(e => e.DepartureDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DEPARTURE_DATE");

                entity.Property(e => e.DepartureLocation)
                    .HasMaxLength(100)
                    .HasColumnName("DEPARTURE_LOCATION");

                entity.Property(e => e.Description).HasColumnName("DESCRIPTION");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Exbed)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("EXBED");

                entity.Property(e => e.Quad)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("QUAD");

                entity.Property(e => e.Sng)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("SNG");

                entity.Property(e => e.Tourid).HasColumnName("TOURID");

                entity.Property(e => e.Trp)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("TRP");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.TourPricesAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TOUR_PRIC__ADDUS__0D8FDC76");

                entity.HasOne(d => d.CurcodeNavigation)
                    .WithMany(p => p.TourPrices)
                    .HasForeignKey(d => d.Curcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TOUR_PRIC__CURCO__0C9BB83D");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.TourPricesEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__TOUR_PRIC__EDITU__0F7824E8");

                entity.HasOne(d => d.Tour)
                    .WithMany(p => p.TourPrices)
                    .HasForeignKey(d => d.Tourid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TOUR_PRIC__TOURI__04FA9675");
            });

            modelBuilder.Entity<TourProgram>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__TOUR_PRO__3214EC26DD8FA3AC")
                    .IsClustered(false);

                entity.ToTable("TOUR_PROGRAM");

                entity.HasIndex(e => new { e.Stepno, e.Sortorder }, "IX_TOUR_PROGRAM");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Description).HasColumnName("DESCRIPTION");

                entity.Property(e => e.Duration).HasColumnName("DURATION");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Hotelid).HasColumnName("HOTELID");

                entity.Property(e => e.Interval).HasColumnName("INTERVAL");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.Sortorder).HasColumnName("SORTORDER");

                entity.Property(e => e.Stepno)
                    .HasColumnName("STEPNO")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .HasColumnName("TITLE");

                entity.Property(e => e.Tourid).HasColumnName("TOURID");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.TourProgramAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TOUR_PROG__ADDUS__30AE302A");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.TourProgramEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__TOUR_PROG__EDITU__31A25463");

                entity.HasOne(d => d.Hotel)
                    .WithMany(p => p.TourProgram)
                    .HasForeignKey(d => d.Hotelid)
                    .HasConstraintName("FK__TOUR_PROG__HOTEL__3296789C");

                entity.HasOne(d => d.Tour)
                    .WithMany(p => p.TourProgram)
                    .HasForeignKey(d => d.Tourid)
                    .HasConstraintName("FK__TOUR_PROG__TOURI__338A9CD5");
            });

            modelBuilder.Entity<Tourdiscount>(entity =>
            {
                entity.ToTable("TOURDISCOUNT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Definition)
                    .HasMaxLength(50)
                    .HasColumnName("DEFINITION");
            });

            modelBuilder.Entity<TransferLocations>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__TRANSFER__3214EC26B028FCA6")
                    .IsClustered(false);

                entity.ToTable("TRANSFER_LOCATIONS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Airportcode)
                    .HasMaxLength(5)
                    .HasColumnName("AIRPORTCODE");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Definition)
                    .HasMaxLength(170)
                    .HasColumnName("DEFINITION");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.Latitude).HasColumnName("LATITUDE");

                entity.Property(e => e.Longitude).HasColumnName("LONGITUDE");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.TransferLocationsAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TRANSFER___ADDUS__629A9179");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.TransferLocations)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TRANSFER___CORPI__638EB5B2");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.TransferLocationsEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__TRANSFER___EDITU__6482D9EB");
            });

            modelBuilder.Entity<TransferPrices>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__TRANSFER__3214EC261C147107")
                    .IsClustered(false);

                entity.ToTable("TRANSFER_PRICES");

                entity.HasIndex(e => e.Tolocationid, "IX_TRANSFER_PRICES");

                entity.HasIndex(e => e.Fromlocationid, "IX_TRANSFER_PRICES_1");

                entity.HasIndex(e => e.Pricesort, "IX_TRANSFER_PRICES_2");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.AdultpriceOneway)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("ADULTPRICE_ONEWAY");

                entity.Property(e => e.AdultpriceTwoway)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("ADULTPRICE_TWOWAY");

                entity.Property(e => e.Agencyid).HasColumnName("AGENCYID");

                entity.Property(e => e.Arrivaldays)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("ARRIVALDAYS")
                    .IsFixedLength();

                entity.Property(e => e.BabypriceOneway)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("BABYPRICE_ONEWAY");

                entity.Property(e => e.BabypriceTwoway)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("BABYPRICE_TWOWAY");

                entity.Property(e => e.ChildpriceOneway)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("CHILDPRICE_ONEWAY");

                entity.Property(e => e.ChildpriceTwoway)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("CHILDPRICE_TWOWAY");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Curcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CURCODE")
                    .IsFixedLength();

                entity.Property(e => e.Departuredays)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTUREDAYS")
                    .IsFixedLength();

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Fromlocationid).HasColumnName("FROMLOCATIONID");

                entity.Property(e => e.Marketid).HasColumnName("MARKETID");

                entity.Property(e => e.Pricesort)
                    .HasColumnName("PRICESORT")
                    .HasComputedColumnSql("(case when [VEHICLETYPEID] IS NOT NULL then (4) else (0) end+((((((case when [SELLFROM] IS NOT NULL then (1) else (0) end+case when [SELLTO] IS NOT NULL then (1) else (0) end)+case when [TICKETDATEFROM] IS NOT NULL then (1) else (0) end)+case when [TICKETDATETO] IS NOT NULL then (1) else (0) end)+case when [ARRIVALDAYS] IS NOT NULL then (1) else (0) end)+case when [DEPARTUREDAYS] IS NOT NULL then (1) else (0) end)+case when [SELLDAYS] IS NOT NULL then (1) else (0) end))", true);

                entity.Property(e => e.Pricetype)
                    .HasColumnName("PRICETYPE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Providerid).HasColumnName("PROVIDERID");

                entity.Property(e => e.Selldays)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("SELLDAYS")
                    .IsFixedLength();

                entity.Property(e => e.Sellfrom)
                    .HasColumnType("datetime")
                    .HasColumnName("SELLFROM");

                entity.Property(e => e.Sellto)
                    .HasColumnType("datetime")
                    .HasColumnName("SELLTO");

                entity.Property(e => e.Ticketdatefrom)
                    .HasColumnType("datetime")
                    .HasColumnName("TICKETDATEFROM");

                entity.Property(e => e.Ticketdateto)
                    .HasColumnType("datetime")
                    .HasColumnName("TICKETDATETO");

                entity.Property(e => e.Tolocationid).HasColumnName("TOLOCATIONID");

                entity.Property(e => e.Useinbasket).HasColumnName("USEINBASKET");

                entity.Property(e => e.Useonline)
                    .HasColumnName("USEONLINE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.VehiclepriceOneway)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("VEHICLEPRICE_ONEWAY");

                entity.Property(e => e.VehiclepriceTwoway)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("VEHICLEPRICE_TWOWAY");

                entity.Property(e => e.Vehicletype)
                    .HasMaxLength(40)
                    .HasColumnName("VEHICLETYPE");

                entity.Property(e => e.Vehicletypeid).HasColumnName("VEHICLETYPEID");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.TransferPricesAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TRANSFER_PR__ADDUS__60D24498");

                entity.HasOne(d => d.Agency)
                    .WithMany(p => p.TransferPrices)
                    .HasForeignKey(d => d.Agencyid)
                    .HasConstraintName("FK__TRANSFER___AGENC__6E414E4F");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.TransferPrices)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TRANSFER_PRICES_CORP");

                entity.HasOne(d => d.CurcodeNavigation)
                    .WithMany(p => p.TransferPrices)
                    .HasForeignKey(d => d.Curcode)
                    .HasConstraintName("FK__TRANSFER_PR__CURCO__593122D0");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.TransferPricesEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__TRANSFER_PR__EDITU__61C668D1");

                entity.HasOne(d => d.Market)
                    .WithMany(p => p.TransferPrices)
                    .HasForeignKey(d => d.Marketid)
                    .HasConstraintName("FK__TRANSFER___MARKE__711DBAFA");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.TransferPrices)
                    .HasForeignKey(d => d.Providerid)
                    .HasConstraintName("FK__TRANSFER___PROVI__7F8BD5E2");

                entity.HasOne(d => d.VehicletypeNavigation)
                    .WithMany(p => p.TransferPrices)
                    .HasForeignKey(d => d.Vehicletype)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TRANSFER___VEHIC__688874F9");

                entity.HasOne(d => d.Vehicletype1)
                    .WithMany(p => p.TransferPrices)
                    .HasForeignKey(d => d.Vehicletypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TRANSFER___VEHIC__08012052");
            });

            modelBuilder.Entity<TransferProviders>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__TRANSFER__3214EC26E0C4BD3E")
                    .IsClustered(false);

                entity.ToTable("TRANSFER_PROVIDERS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Description)
                    .HasMaxLength(170)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.Tel1).HasColumnName("TEL1");

                entity.Property(e => e.Tel2).HasColumnName("TEL2");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.TransferProvidersAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TRANSFER___ADDUS__7CAF6937");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.TransferProviders)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TRANSFER___CORPI__7DA38D70");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.TransferProvidersEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__TRANSFER___EDITU__7E97B1A9");
            });

            modelBuilder.Entity<Turnike>(entity =>
            {
                entity.HasKey(e => e.Gatenumber)
                    .HasName("PK__TURNIKE__686C874524E067A2")
                    .IsClustered(false);

                entity.ToTable("TURNIKE");

                entity.HasIndex(e => new { e.Corpid, e.Gatenumber }, "UQ__TURNIKE__7049794427ADDDCD")
                    .IsUnique();

                entity.Property(e => e.Gatenumber)
                    .HasMaxLength(30)
                    .HasColumnName("GATENUMBER");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Direction)
                    .IsRequired()
                    .HasColumnName("DIRECTION")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.Turnike)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TURNIKE__CORPID__347EC10E");
            });

            modelBuilder.Entity<UserHistory>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__USER_HIS__3214EC261AE2A58D")
                    .IsClustered(false);

                entity.ToTable("USER_HISTORY");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Corptid).HasColumnName("CORPTID");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(25)
                    .HasColumnName("IPADDRESS");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserHistory)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__USER_HIST__USERI__519AEE00");
            });

            modelBuilder.Entity<UserProjectDetails>(entity =>
            {
                entity.ToTable("USER_PROJECT_DETAILS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.ProjectGroupdetailid).HasColumnName("PROJECT_GROUPDETAILID");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.ProjectGroupdetail)
                    .WithMany(p => p.UserProjectDetails)
                    .HasForeignKey(d => d.ProjectGroupdetailid)
                    .HasConstraintName("FK_USER_PROJECT_DETAILS_PROJECT_GROUPDETAIL");
            });

            modelBuilder.Entity<UserProjects>(entity =>
            {
                entity.ToTable("USER_PROJECTS");

                entity.HasIndex(e => new { e.Userid, e.ProjectGroupid }, "IX_USER_PROJECTS")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.ProjectGroupid).HasColumnName("PROJECT_GROUPID");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.ProjectGroup)
                    .WithMany(p => p.UserProjects)
                    .HasForeignKey(d => d.ProjectGroupid)
                    .HasConstraintName("FK__USER_PROJ__PROJE__662B2B3B");
            });

            modelBuilder.Entity<UserRoleRequestStatus>(entity =>
            {
                entity.ToTable("USER_ROLE_REQUEST_STATUS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Allow).HasColumnName("ALLOW");

                entity.Property(e => e.Roleid).HasColumnName("ROLEID");

                entity.Property(e => e.Statuid).HasColumnName("STATUID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoleRequestStatus)
                    .HasForeignKey(d => d.Roleid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__USER_ROLE__ROLEI__7E8CC4B1");

                entity.HasOne(d => d.Statu)
                    .WithMany(p => p.UserRoleRequestStatus)
                    .HasForeignKey(d => d.Statuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__USER_ROLE__STATU__7F80E8EA");
            });

            modelBuilder.Entity<UserRoles>(entity =>
            {
                entity.ToTable("USER_ROLES");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Moduleid).HasColumnName("MODULEID");

                entity.Property(e => e.Roleid).HasColumnName("ROLEID");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.Roleid)
                    .HasConstraintName("FK__USER_ROLE__ROLEI__5224328E");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("FK__USER_ROLE__USERI__46E78A0C");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("USERS");

                entity.HasIndex(e => e.Moduleid, "IX_USERS");

                entity.HasIndex(e => e.Username, "IX_USERS_1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(100)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(201)
                    .HasColumnName("FULLNAME")
                    .HasComputedColumnSql("((isnull([FIRSTNAME],'')+' ')+isnull([LASTNAME],''))", false);

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(100)
                    .HasColumnName("LASTNAME");

                entity.Property(e => e.Moduleid).HasColumnName("MODULEID");

                entity.Property(e => e.MustchangepaswordNextlogon).HasColumnName("MUSTCHANGEPASWORD_NEXTLOGON");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Systemadmin).HasColumnName("SYSTEMADMIN");

                entity.Property(e => e.Tel1).HasColumnName("TEL1");

                entity.Property(e => e.Tel2).HasColumnName("TEL2");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("USERNAME");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.InverseAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__USERS__ADDUSER__3A81B327");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USERS_CORP");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.InverseEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__USERS__EDITUSER__3C69FB99");
            });

            modelBuilder.Entity<UsersCustomauth>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__USERS_CU__3214EC264938BA04")
                    .IsClustered(false);

                entity.ToTable("USERS_CUSTOMAUTH");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AllowbutgetOnreelgrid).HasColumnName("ALLOWBUTGET_ONREELGRID");

                entity.Property(e => e.AllowclientInvoiceIntegration).HasColumnName("ALLOWCLIENT_INVOICE_INTEGRATION");

                entity.Property(e => e.ExternalPassword)
                    .HasMaxLength(50)
                    .HasColumnName("EXTERNAL_PASSWORD");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersCustomauth)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("FK__USERS_CUS__USERI__5654B625");
            });

            modelBuilder.Entity<Vehicletypes>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__VEHICLET__3214EC26E4D43FAB")
                    .IsClustered(false);

                entity.ToTable("VEHICLETYPES");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Aircondition)
                    .IsRequired()
                    .HasColumnName("AIRCONDITION")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BaggageCapacity)
                    .HasMaxLength(10)
                    .HasColumnName("BAGGAGE_CAPACITY")
                    .HasDefaultValueSql("((3))")
                    .IsFixedLength();

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Definition)
                    .HasMaxLength(70)
                    .HasColumnName("DEFINITION");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.PersonCount)
                    .HasColumnName("PERSON_COUNT")
                    .HasDefaultValueSql("((4))");

                entity.Property(e => e.SpecialCode)
                    .HasMaxLength(15)
                    .HasColumnName("SPECIAL_CODE");

                entity.Property(e => e.Vehicletype)
                    .HasMaxLength(40)
                    .HasColumnName("VEHICLETYPE");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.VehicletypesAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VEHICLETY__ADDUS__30441BD6");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.Vehicletypes)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VEHICLETY__CORPI__3138400F");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.VehicletypesEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__VEHICLETY__EDITU__322C6448");

                entity.HasOne(d => d.VehicletypeNavigation)
                    .WithMany(p => p.Vehicletypes)
                    .HasForeignKey(d => d.Vehicletype)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VEHICLETY__VEHIC__2C738AF2");
            });

            modelBuilder.Entity<VirtualPos>(entity =>
            {
                entity.ToTable("VIRTUAL_POS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AccInvCode)
                    .HasMaxLength(30)
                    .HasColumnName("ACC_INV_CODE");

                entity.Property(e => e.AccPayCode)
                    .HasMaxLength(30)
                    .HasColumnName("ACC_PAY_CODE");

                entity.Property(e => e.BinnumberName)
                    .HasMaxLength(50)
                    .HasColumnName("BINNUMBER_NAME");

                entity.Property(e => e.Class)
                    .HasMaxLength(150)
                    .HasColumnName("CLASS");

                entity.Property(e => e.Corpid)
                    .HasColumnName("CORPID")
                    .HasDefaultValueSql("('183D3B34-92F3-4A9B-B976-60F68FD1519B')");

                entity.Property(e => e.Description)
                    .HasMaxLength(150)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Fontcolor)
                    .HasMaxLength(20)
                    .HasColumnName("FONTCOLOR");

                entity.Property(e => e.Forecolor)
                    .HasMaxLength(20)
                    .HasColumnName("FORECOLOR");

                entity.Property(e => e.Iconurl)
                    .HasMaxLength(250)
                    .HasColumnName("ICONURL");

                entity.Property(e => e.Intid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("INTID");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .HasColumnName("NAME");

                entity.Property(e => e.Xmlpassword)
                    .HasMaxLength(150)
                    .HasColumnName("XMLPASSWORD");

                entity.Property(e => e.Xmlusername)
                    .HasMaxLength(150)
                    .HasColumnName("XMLUSERNAME");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.VirtualPos)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__CORPI__6DF7358C");
            });

            modelBuilder.Entity<VirtualPosAccountInstalments>(entity =>
            {
                entity.ToTable("VIRTUAL_POS_ACCOUNT_INSTALMENTS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Accountid).HasColumnName("ACCOUNTID");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.BankCommission).HasColumnName("BANK_COMMISSION");

                entity.Property(e => e.Commission).HasColumnName("COMMISSION");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Expiryday).HasColumnName("EXPIRYDAY");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.Offset).HasColumnName("OFFSET");

                entity.Property(e => e.Plus).HasColumnName("PLUS");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.VirtualPosAccountInstalments)
                    .HasForeignKey(d => d.Accountid)
                    .HasConstraintName("FK__VIRTUAL_P__ACCOU__10CB707D");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.VirtualPosAccountInstalmentsAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__ADDUS__43C1049E");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.VirtualPosAccountInstalmentsEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__VIRTUAL_P__EDITU__44B528D7");
            });

            modelBuilder.Entity<VirtualPosAccounts>(entity =>
            {
                entity.ToTable("VIRTUAL_POS_ACCOUNTS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Accountname)
                    .HasMaxLength(50)
                    .HasColumnName("ACCOUNTNAME");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.BinnumberName)
                    .HasMaxLength(50)
                    .HasColumnName("BINNUMBER_NAME");

                entity.Property(e => e.Clientid)
                    .HasMaxLength(50)
                    .HasColumnName("CLIENTID");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Definition)
                    .HasMaxLength(150)
                    .HasColumnName("DEFINITION");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.EntHotelid)
                    .HasMaxLength(25)
                    .HasColumnName("ENT_HOTELID");

                entity.Property(e => e.Entid)
                    .HasMaxLength(100)
                    .HasColumnName("ENTID");

                entity.Property(e => e.InstalmentMerge).HasColumnName("INSTALMENT_MERGE");

                entity.Property(e => e.IsforeignPos).HasColumnName("ISFOREIGN_POS");

                entity.Property(e => e.Params)
                    .HasMaxLength(350)
                    .HasColumnName("PARAMS");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Password3d)
                    .HasMaxLength(50)
                    .HasColumnName("PASSWORD_3D");

                entity.Property(e => e.Posid).HasColumnName("POSID");

                entity.Property(e => e.Posturl)
                    .HasMaxLength(250)
                    .HasColumnName("POSTURL");

                entity.Property(e => e.Terminalid)
                    .HasMaxLength(50)
                    .HasColumnName("TERMINALID");

                entity.Property(e => e.Use3d)
                    .HasColumnName("USE3D")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.VirtualPosAccountsAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__ADDUS__0A1E72EE");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.VirtualPosAccounts)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__CORPI__08362A7C");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.VirtualPosAccountsEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__VIRTUAL_P__EDITU__0C06BB60");

                entity.HasOne(d => d.Pos)
                    .WithMany(p => p.VirtualPosAccounts)
                    .HasForeignKey(d => d.Posid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__POSID__07420643");
            });

            modelBuilder.Entity<VirtualPosAccountsCurcodes>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__VIRTUAL___3214EC263FC4CE80")
                    .IsClustered(false);

                entity.ToTable("VIRTUAL_POS_ACCOUNTS_CURCODES");

                entity.HasIndex(e => new { e.Accountid, e.Curcode }, "UQ__VIRTUAL___0ACA257EBD9DAF3E")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Accountid).HasColumnName("ACCOUNTID");

                entity.Property(e => e.Curcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CURCODE")
                    .IsFixedLength();

                entity.Property(e => e.Schemes)
                    .HasMaxLength(220)
                    .HasColumnName("SCHEMES");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.VirtualPosAccountsCurcodes)
                    .HasForeignKey(d => d.Accountid)
                    .HasConstraintName("FK__VIRTUAL_P__ACCOU__5807F46D");

                entity.HasOne(d => d.CurcodeNavigation)
                    .WithMany(p => p.VirtualPosAccountsCurcodes)
                    .HasForeignKey(d => d.Curcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__CURCO__4A6E022D");
            });

            modelBuilder.Entity<VirtualPosBinnumbers>(entity =>
            {
                entity.ToTable("VIRTUAL_POS_BINNUMBERS");

                entity.HasIndex(e => e.Binno, "IX_VIRTUAL_POS_BINNUMBERS");

                entity.HasIndex(e => e.Binno, "UQ__VIRTUAL___5D92CF0E5E919BD3")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bankname)
                    .HasMaxLength(100)
                    .HasColumnName("BANKNAME");

                entity.Property(e => e.Binno)
                    .HasMaxLength(7)
                    .HasColumnName("BINNO");

                entity.Property(e => e.Schema)
                    .HasMaxLength(30)
                    .HasColumnName("SCHEMA");

                entity.Property(e => e.Type)
                    .HasMaxLength(30)
                    .HasColumnName("TYPE");
            });

            modelBuilder.Entity<VirtualPosDefaults>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__VIRTUAL___3214EC26FBDA7D1D")
                    .IsClustered(false);

                entity.ToTable("VIRTUAL_POS_DEFAULTS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.AmexExPosid).HasColumnName("AMEX_EX_POSID");

                entity.Property(e => e.AmexPosid).HasColumnName("AMEX_POSID");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.JcbExPosid).HasColumnName("JCB_EX_POSID");

                entity.Property(e => e.JcbPosid).HasColumnName("JCB_POSID");

                entity.Property(e => e.MaestroExPosid).HasColumnName("MAESTRO_EX_POSID");

                entity.Property(e => e.MaestroPosid).HasColumnName("MAESTRO_POSID");

                entity.Property(e => e.MasterExPosid).HasColumnName("MASTER_EX_POSID");

                entity.Property(e => e.MasterPosid).HasColumnName("MASTER_POSID");

                entity.Property(e => e.Portaluid).HasColumnName("PORTALUID");

                entity.Property(e => e.UnionpayExPosid).HasColumnName("UNIONPAY_EX_POSID");

                entity.Property(e => e.UnionpayPosid).HasColumnName("UNIONPAY_POSID");

                entity.Property(e => e.VisaExPosid).HasColumnName("VISA_EX_POSID");

                entity.Property(e => e.VisaPosid).HasColumnName("VISA_POSID");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.VirtualPosDefaultsAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__ADDUS__1D913A15");

                entity.HasOne(d => d.AmexExPos)
                    .WithMany(p => p.VirtualPosDefaultsAmexExPos)
                    .HasForeignKey(d => d.AmexExPosid)
                    .HasConstraintName("FK__VIRTUAL_P__AMEX___19C0A931");

                entity.HasOne(d => d.AmexPos)
                    .WithMany(p => p.VirtualPosDefaultsAmexPos)
                    .HasForeignKey(d => d.AmexPosid)
                    .HasConstraintName("FK__VIRTUAL_P__AMEX___1407CFDB");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.VirtualPosDefaults)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__CORPI__10373EF7");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.VirtualPosDefaultsEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__VIRTUAL_P__EDITU__1F798287");

                entity.HasOne(d => d.JcbExPos)
                    .WithMany(p => p.VirtualPosDefaultsJcbExPos)
                    .HasForeignKey(d => d.JcbExPosid)
                    .HasConstraintName("FK__VIRTUAL_P__JCB_E__1AB4CD6A");

                entity.HasOne(d => d.JcbPos)
                    .WithMany(p => p.VirtualPosDefaultsJcbPos)
                    .HasForeignKey(d => d.JcbPosid)
                    .HasConstraintName("FK__VIRTUAL_P__JCB_P__14FBF414");

                entity.HasOne(d => d.MaestroExPos)
                    .WithMany(p => p.VirtualPosDefaultsMaestroExPos)
                    .HasForeignKey(d => d.MaestroExPosid)
                    .HasConstraintName("FK__VIRTUAL_P__MAEST__1C9D15DC");

                entity.HasOne(d => d.MaestroPos)
                    .WithMany(p => p.VirtualPosDefaultsMaestroPos)
                    .HasForeignKey(d => d.MaestroPosid)
                    .HasConstraintName("FK__VIRTUAL_P__MAEST__16E43C86");

                entity.HasOne(d => d.MasterExPos)
                    .WithMany(p => p.VirtualPosDefaultsMasterExPos)
                    .HasForeignKey(d => d.MasterExPosid)
                    .HasConstraintName("FK__VIRTUAL_P__MASTE__18CC84F8");

                entity.HasOne(d => d.MasterPos)
                    .WithMany(p => p.VirtualPosDefaultsMasterPos)
                    .HasForeignKey(d => d.MasterPosid)
                    .HasConstraintName("FK__VIRTUAL_P__MASTE__1313ABA2");

                entity.HasOne(d => d.Portalu)
                    .WithMany(p => p.VirtualPosDefaults)
                    .HasPrincipalKey(p => p.Uid)
                    .HasForeignKey(d => d.Portaluid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__PORTA__112B6330");

                entity.HasOne(d => d.UnionpayExPos)
                    .WithMany(p => p.VirtualPosDefaultsUnionpayExPos)
                    .HasForeignKey(d => d.UnionpayExPosid)
                    .HasConstraintName("FK__VIRTUAL_P__UNION__1BA8F1A3");

                entity.HasOne(d => d.UnionpayPos)
                    .WithMany(p => p.VirtualPosDefaultsUnionpayPos)
                    .HasForeignKey(d => d.UnionpayPosid)
                    .HasConstraintName("FK__VIRTUAL_P__UNION__15F0184D");

                entity.HasOne(d => d.VisaExPos)
                    .WithMany(p => p.VirtualPosDefaultsVisaExPos)
                    .HasForeignKey(d => d.VisaExPosid)
                    .HasConstraintName("FK__VIRTUAL_P__VISA___17D860BF");

                entity.HasOne(d => d.VisaPos)
                    .WithMany(p => p.VirtualPosDefaultsVisaPos)
                    .HasForeignKey(d => d.VisaPosid)
                    .HasConstraintName("FK__VIRTUAL_P__VISA___121F8769");
            });

            modelBuilder.Entity<VirtualPosDepAccounts>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__VIRTUAL___3214EC2631497AA5")
                    .IsClustered(false);

                entity.ToTable("VIRTUAL_POS_DEP_ACCOUNTS");

                entity.HasIndex(e => e.Iban, "UQ__VIRTUAL___8235CCBCC71928CD")
                    .IsUnique();

                entity.HasIndex(e => new { e.Posid, e.BrandCode, e.AccountNo }, "UQ__VIRTUAL___FB82C868314D95A7")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(35)
                    .HasColumnName("ACCOUNT_NO");

                entity.Property(e => e.BrandCode)
                    .HasMaxLength(25)
                    .HasColumnName("BRAND_CODE");

                entity.Property(e => e.Curcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CURCODE")
                    .IsFixedLength();

                entity.Property(e => e.Definition)
                    .HasMaxLength(100)
                    .HasColumnName("DEFINITION");

                entity.Property(e => e.Entid)
                    .HasMaxLength(100)
                    .HasColumnName("ENTID");

                entity.Property(e => e.Firmname)
                    .HasMaxLength(250)
                    .HasColumnName("FIRMNAME");

                entity.Property(e => e.Iban)
                    .HasMaxLength(35)
                    .HasColumnName("IBAN");

                entity.Property(e => e.Posid).HasColumnName("POSID");

                entity.Property(e => e.Swiftcode)
                    .HasMaxLength(50)
                    .HasColumnName("SWIFTCODE");
            });

            modelBuilder.Entity<VirtualPosDepPayments>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__VIRTUAL___3214EC26FF40B2D4")
                    .IsClustered(false);

                entity.ToTable("VIRTUAL_POS_DEP_PAYMENTS");

                entity.HasIndex(e => e.Adddate, "IX_VIRTUAL_POS_DEP_PAYMENTS");

                entity.HasIndex(e => e.Adddate, "IX_VIRTUAL_POS_DEP_PAYMENTS_1");

                entity.HasIndex(e => e.Editdate, "IX_VIRTUAL_POS_DEP_PAYMENTS_2");

                entity.HasIndex(e => e.Editdate, "IX_VIRTUAL_POS_DEP_PAYMENTS_3");

                entity.HasIndex(e => e.Status, "IX_VIRTUAL_POS_DEP_PAYMENTS_4");

                entity.HasIndex(e => e.Transfercode, "IX_VIRTUAL_POS_DEP_PAYMENTS_5");

                entity.HasIndex(e => e.Isdeleted, "IX_VIRTUAL_POS_DEP_PAYMENTS_6");

                entity.HasIndex(e => e.Intid, "IX_VIRTUAL_POS_DEP_PAYMENTS_7");

                entity.HasIndex(e => e.Entid, "IX_VIRTUAL_POS_DEP_PAYMENTS_8");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Banktransactionid)
                    .HasMaxLength(50)
                    .HasColumnName("BANKTRANSACTIONID");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Endtime)
                    .HasColumnType("datetime")
                    .HasColumnName("ENDTIME");

                entity.Property(e => e.Entid)
                    .HasMaxLength(100)
                    .HasColumnName("ENTID");

                entity.Property(e => e.Intid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("INTID");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Posaccountid).HasColumnName("POSACCOUNTID");

                entity.Property(e => e.Requestid).HasColumnName("REQUESTID");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Transfercode)
                    .HasMaxLength(10)
                    .HasColumnName("TRANSFERCODE");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.VirtualPosDepPaymentsAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__ADDUS__4C564A9F");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.VirtualPosDepPaymentsEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__VIRTUAL_P__EDITU__4D4A6ED8");

                entity.HasOne(d => d.Posaccount)
                    .WithMany(p => p.VirtualPosDepPayments)
                    .HasForeignKey(d => d.Posaccountid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__POSAC__0D6FE0E5");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.VirtualPosDepPayments)
                    .HasForeignKey(d => d.Requestid)
                    .HasConstraintName("FK__VIRTUAL_P__REQUE__12349602");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.VirtualPosDepPayments)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__STATU__4E3E9311");
            });

            modelBuilder.Entity<VirtualPosDepPaymentsCancel>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__VIRTUAL___3214EC261F2CCB2B")
                    .IsClustered(false);

                entity.ToTable("VIRTUAL_POS_DEP_PAYMENTS_CANCEL");

                entity.HasIndex(e => e.Entid, "IX_VIRTUAL_POS_DEP_PAYMENTS_CANCEL");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Entid)
                    .HasMaxLength(100)
                    .HasColumnName("ENTID");

                entity.Property(e => e.Isrefund).HasColumnName("ISREFUND");

                entity.Property(e => e.Paymentid).HasColumnName("PAYMENTID");

                entity.Property(e => e.RequestDetailid).HasColumnName("REQUEST_DETAILID");

                entity.Property(e => e.Success).HasColumnName("SUCCESS");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.VirtualPosDepPaymentsCancelAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__ADDUS__4341E1B1");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.VirtualPosDepPaymentsCancelEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__VIRTUAL_P__EDITU__443605EA");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.VirtualPosDepPaymentsCancel)
                    .HasForeignKey(d => d.Paymentid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__PAYME__452A2A23");

                entity.HasOne(d => d.RequestDetail)
                    .WithMany(p => p.VirtualPosDepPaymentsCancel)
                    .HasForeignKey(d => d.RequestDetailid)
                    .HasConstraintName("FK__VIRTUAL_P__REQUE__2E11BAA1");
            });

            modelBuilder.Entity<VirtualPosPaymentEmails>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__VIRTUAL___3214EC26319DB2DB")
                    .IsClustered(false);

                entity.ToTable("VIRTUAL_POS_PAYMENT_EMAILS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(70)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(70)
                    .HasColumnName("LASTNAME");

                entity.Property(e => e.Paymentid).HasColumnName("PAYMENTID");

                entity.Property(e => e.Phonenumber)
                    .HasMaxLength(50)
                    .HasColumnName("PHONENUMBER");

                entity.Property(e => e.ResultMail)
                    .HasColumnName("RESULT_MAIL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tempid).HasColumnName("TEMPID");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.VirtualPosPaymentEmailsAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__ADDUS__332B7579");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.VirtualPosPaymentEmailsEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__VIRTUAL_P__EDITU__3513BDEB");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.VirtualPosPaymentEmails)
                    .HasForeignKey(d => d.Paymentid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_VIRTUAL_POS_PAYMENT_EMAILS_VIRTUAL_POS_PAYMENT_REQUESTS");

                entity.HasOne(d => d.Temp)
                    .WithMany(p => p.VirtualPosPaymentEmails)
                    .HasForeignKey(d => d.Tempid)
                    .HasConstraintName("FK__VIRTUAL_P__TEMPI__31432D07");
            });

            modelBuilder.Entity<VirtualPosPaymentMessageTemps>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__VIRTUAL___3214EC26B5BF55CC")
                    .IsClustered(false);

                entity.ToTable("VIRTUAL_POS_PAYMENT_MESSAGE_TEMPS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Description)
                    .HasMaxLength(150)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Errortext).HasColumnName("ERRORTEXT");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.Kind).HasColumnName("KIND");

                entity.Property(e => e.Messagetext).HasColumnName("MESSAGETEXT");

                entity.Property(e => e.Successtext).HasColumnName("SUCCESSTEXT");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.VirtualPosPaymentMessageTempsAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__ADDUS__13B2CA20");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.VirtualPosPaymentMessageTemps)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__CORPI__0FE2393C");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.VirtualPosPaymentMessageTempsEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__VIRTUAL_P__EDITU__159B1292");
            });

            modelBuilder.Entity<VirtualPosPaymentRequests>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__VIR_REQTUAL___3214EC2615C97ABF")
                    .IsClustered(false);

                entity.ToTable("VIRTUAL_POS_PAYMENT_REQUESTS");

                entity.HasIndex(e => e.Adddate, "IX_VIRTUAL_POS_PAYMENT_REQUESTS");

                entity.HasIndex(e => e.Adddate, "IX_VIRTUAL_POS_PAYMENT_REQUESTS_1");

                entity.HasIndex(e => new { e.Adddate, e.Isdeleted, e.Corpid }, "IX_VIRTUAL_POS_PAYMENT_REQUESTS_2");

                entity.HasIndex(e => e.Isdeleted, "IX_VIRTUAL_POS_PAYMENT_REQUESTS_3");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.CandivPayment)
                    .HasColumnName("CANDIV_PAYMENT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Curcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CURCODE")
                    .IsFixedLength();

                entity.Property(e => e.Description)
                    .HasMaxLength(150)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Emailtempid).HasColumnName("EMAILTEMPID");

                entity.Property(e => e.Emailtext).HasColumnName("EMAILTEXT");

                entity.Property(e => e.Fdate)
                    .HasColumnType("datetime")
                    .HasColumnName("FDATE");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.Langcode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("LANGCODE")
                    .IsFixedLength();

                entity.Property(e => e.PaymentDescription).HasColumnName("PAYMENT_DESCRIPTION");

                entity.Property(e => e.PaymentErrortext).HasColumnName("PAYMENT_ERRORTEXT");

                entity.Property(e => e.PaymentSuccesstext).HasColumnName("PAYMENT_SUCCESSTEXT");

                entity.Property(e => e.PaymentText).HasColumnName("PAYMENT_TEXT");

                entity.Property(e => e.Paymenttempid).HasColumnName("PAYMENTTEMPID");

                entity.Property(e => e.Piece)
                    .HasColumnName("PIECE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Portaluid).HasColumnName("PORTALUID");

                entity.Property(e => e.Price).HasColumnName("PRICE");

                entity.Property(e => e.Pricechangeable).HasColumnName("PRICECHANGEABLE");

                entity.Property(e => e.Resnumber)
                    .HasMaxLength(50)
                    .HasColumnName("RESNUMBER");

                entity.Property(e => e.Sdate)
                    .HasColumnType("datetime")
                    .HasColumnName("SDATE");

                entity.Property(e => e.SmsErrortext).HasColumnName("SMS_ERRORTEXT");

                entity.Property(e => e.SmsSuccesstext).HasColumnName("SMS_SUCCESSTEXT");

                entity.Property(e => e.SmsText1).HasColumnName("SMS_TEXT");

                entity.Property(e => e.Smstempid).HasColumnName("SMSTEMPID");

                entity.Property(e => e.Smstext).HasColumnName("SMSTEXT");

                entity.Property(e => e.Title)
                    .HasMaxLength(150)
                    .HasColumnName("TITLE");

                entity.Property(e => e.Useemail)
                    .IsRequired()
                    .HasColumnName("USEEMAIL")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Useinstallments).HasColumnName("USEINSTALLMENTS");

                entity.Property(e => e.Usesms).HasColumnName("USESMS");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.VirtualPosPaymentRequestsAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REQVIRTUAL_P__ADDUS__29A20B3F");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.VirtualPosPaymentRequests)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REQVIRTUAL_P__CORPI__22F50DB0");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.VirtualPosPaymentRequestsEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__REQVIRTUAL_P__EDITU__2B8A53B1");

                entity.HasOne(d => d.Emailtemp)
                    .WithMany(p => p.VirtualPosPaymentRequestsEmailtemp)
                    .HasForeignKey(d => d.Emailtempid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__REQVIRTUAL_P__EMAIL__27B9C2CD");

                entity.HasOne(d => d.Paymenttemp)
                    .WithMany(p => p.VirtualPosPaymentRequests)
                    .HasForeignKey(d => d.Paymenttempid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_VIRTUAL_POS_PAYMENT_REQUESTS_VIRTUAL_POS_PAYMENT_TEMPS");

                entity.HasOne(d => d.Portalu)
                    .WithMany(p => p.VirtualPosPaymentRequests)
                    .HasPrincipalKey(p => p.Uid)
                    .HasForeignKey(d => d.Portaluid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VIRTUAL_POS_PAYMENT_REQUESTS_PORTAL");

                entity.HasOne(d => d.Smstemp)
                    .WithMany(p => p.VirtualPosPaymentRequestsSmstemp)
                    .HasForeignKey(d => d.Smstempid)
                    .HasConstraintName("FK__REQVIRTUAL_P__SMSTE__28ADE706");
            });

            modelBuilder.Entity<VirtualPosPaymentRequestsNotes>(entity =>
            {
                entity.ToTable("VIRTUAL_POS_PAYMENT_REQUESTS_NOTES");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.Nottype).HasColumnName("NOTTYPE");

                entity.Property(e => e.Paymentid).HasColumnName("PAYMENTID");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.VirtualPosPaymentRequestsNotesAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__POS___REQUEST_N__ADDUS__78BEDCC2");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.VirtualPosPaymentRequestsNotesEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK_pos_VIRTUAL_POS_PAYMENT_REQUESTS_NOTES_USERS");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.VirtualPosPaymentRequestsNotes)
                    .HasForeignKey(d => d.Paymentid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VIRTUAL_POS_PAYMENT_REQUESTS_NOTES_VIRTUAL_POS_PAYMENT_REQUESTS");
            });

            modelBuilder.Entity<VirtualPosPaymentTemps>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__VIRTUAL___3214EC2615C97ABF")
                    .IsClustered(false);

                entity.ToTable("VIRTUAL_POS_PAYMENT_TEMPS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.CandivPayment)
                    .HasColumnName("CANDIV_PAYMENT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Curcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CURCODE")
                    .IsFixedLength();

                entity.Property(e => e.Description)
                    .HasMaxLength(150)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Emailtempid).HasColumnName("EMAILTEMPID");

                entity.Property(e => e.Emailtext).HasColumnName("EMAILTEXT");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.Langcode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("LANGCODE")
                    .IsFixedLength();

                entity.Property(e => e.PaymentDescription).HasColumnName("PAYMENT_DESCRIPTION");

                entity.Property(e => e.PaymentErrortext).HasColumnName("PAYMENT_ERRORTEXT");

                entity.Property(e => e.PaymentSuccesstext).HasColumnName("PAYMENT_SUCCESSTEXT");

                entity.Property(e => e.PaymentText).HasColumnName("PAYMENT_TEXT");

                entity.Property(e => e.Piece)
                    .HasColumnName("PIECE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Price).HasColumnName("PRICE");

                entity.Property(e => e.Pricechangeable).HasColumnName("PRICECHANGEABLE");

                entity.Property(e => e.Resnumber)
                    .HasMaxLength(50)
                    .HasColumnName("RESNUMBER");

                entity.Property(e => e.SendMailsOnlyCreateuser).HasColumnName("SEND_MAILS_ONLY_CREATEUSER");

                entity.Property(e => e.SmsErrortext).HasColumnName("SMS_ERRORTEXT");

                entity.Property(e => e.SmsSuccesstext).HasColumnName("SMS_SUCCESSTEXT");

                entity.Property(e => e.SmsText1).HasColumnName("SMS_TEXT");

                entity.Property(e => e.Smstempid).HasColumnName("SMSTEMPID");

                entity.Property(e => e.Smstext).HasColumnName("SMSTEXT");

                entity.Property(e => e.Title)
                    .HasMaxLength(150)
                    .HasColumnName("TITLE");

                entity.Property(e => e.Useemail)
                    .IsRequired()
                    .HasColumnName("USEEMAIL")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Useinstallments).HasColumnName("USEINSTALLMENTS");

                entity.Property(e => e.Usesms).HasColumnName("USESMS");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.VirtualPosPaymentTempsAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__ADDUS__29A20B3F");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.VirtualPosPaymentTemps)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__CORPI__22F50DB0");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.VirtualPosPaymentTempsEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__VIRTUAL_P__EDITU__2B8A53B1");

                entity.HasOne(d => d.Emailtemp)
                    .WithMany(p => p.VirtualPosPaymentTempsEmailtemp)
                    .HasForeignKey(d => d.Emailtempid)
                    .HasConstraintName("FK__VIRTUAL_P__EMAIL__27B9C2CD");

                entity.HasOne(d => d.LangcodeNavigation)
                    .WithMany(p => p.VirtualPosPaymentTemps)
                    .HasForeignKey(d => d.Langcode)
                    .HasConstraintName("FK_VIRTUAL_POS_PAYMENT_TEMPS_STDLANGUAGES");

                entity.HasOne(d => d.Smstemp)
                    .WithMany(p => p.VirtualPosPaymentTempsSmstemp)
                    .HasForeignKey(d => d.Smstempid)
                    .HasConstraintName("FK__VIRTUAL_P__SMSTE__28ADE706");
            });

            modelBuilder.Entity<VirtualPosPaymentVposes>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__VIRTUAL___3214EC266D8BF4C0")
                    .IsClustered(false);

                entity.ToTable("VIRTUAL_POS_PAYMENT_VPOSES");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Installmentid).HasColumnName("INSTALLMENTID");

                entity.Property(e => e.Paymentid).HasColumnName("PAYMENTID");

                entity.Property(e => e.Tempid).HasColumnName("TEMPID");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.VirtualPosPaymentVposesAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__ADDUS__3BC0BB7A");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.VirtualPosPaymentVposesEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__VIRTUAL_P__EDITU__3DA903EC");

                entity.HasOne(d => d.Installment)
                    .WithMany(p => p.VirtualPosPaymentVposes)
                    .HasForeignKey(d => d.Installmentid)
                    .HasConstraintName("FK_VIRTUAL_POS_PAYMENT_VPOSES_VIRTUAL_POS_ACCOUNT_INSTALMENTS");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.VirtualPosPaymentVposes)
                    .HasForeignKey(d => d.Paymentid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_VIRTUAL_POS_PAYMENT_VPOSES_VIRTUAL_POS_PAYMENT_REQUESTS");

                entity.HasOne(d => d.Temp)
                    .WithMany(p => p.VirtualPosPaymentVposes)
                    .HasForeignKey(d => d.Tempid)
                    .HasConstraintName("FK__VIRTUAL_P__TEMPI__38E44ECF");
            });

            modelBuilder.Entity<VirtualPosPayments>(entity =>
            {
                entity.ToTable("VIRTUAL_POS_PAYMENTS");

                entity.HasIndex(e => e.Isdeleted, "IX_VIRTUAL_POS_PAYMENTS");

                entity.HasIndex(e => e.Adddate, "IX_VIRTUAL_POS_PAYMENTS_1");

                entity.HasIndex(e => e.Adddate, "IX_VIRTUAL_POS_PAYMENTS_2");

                entity.HasIndex(e => e.Firststep, "IX_VIRTUAL_POS_PAYMENTS_3");

                entity.HasIndex(e => e.Void, "IX_VIRTUAL_POS_PAYMENTS_4");

                entity.HasIndex(e => e.Refund, "IX_VIRTUAL_POS_PAYMENTS_5");

                entity.HasIndex(e => e.Entid, "IX_VIRTUAL_POS_PAYMENTS_6");

                entity.HasIndex(e => new { e.Isdeleted, e.PaymentRequestid, e.Status }, "IX_VIRTUAL_POS_PAYMENTS_ISDELETED_PAYMENT_REQUESTID_STATUS");

                entity.HasIndex(e => new { e.Status, e.Isdeleted }, "MIS_IDX_01");

                entity.HasIndex(e => e.Isdeleted, "MIS_IDX_2");

                entity.HasIndex(e => e.Isdeleted, "MIS_IDX_VIRTUAL_POS_PAYMENTS_01");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Authcode)
                    .HasMaxLength(200)
                    .HasColumnName("AUTHCODE");

                entity.Property(e => e.BasketDescription).HasColumnName("BASKET_DESCRIPTION");

                entity.Property(e => e.Cardnumber)
                    .HasMaxLength(50)
                    .HasColumnName("CARDNUMBER");

                entity.Property(e => e.Cardowner)
                    .HasMaxLength(200)
                    .HasColumnName("CARDOWNER");

                entity.Property(e => e.CompletebasketAftersuccess)
                    .HasColumnName("COMPLETEBASKET_AFTERSUCCESS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Curcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CURCODE")
                    .IsFixedLength();

                entity.Property(e => e.Cvv)
                    .HasMaxLength(5)
                    .HasColumnName("CVV");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Eci)
                    .HasMaxLength(50)
                    .HasColumnName("ECI");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Endtime)
                    .HasColumnType("datetime")
                    .HasColumnName("ENDTIME");

                entity.Property(e => e.Entid)
                    .HasMaxLength(100)
                    .HasColumnName("ENTID");

                entity.Property(e => e.Firststep).HasColumnName("FIRSTSTEP");

                entity.Property(e => e.Fixit).HasColumnName("FIXIT");

                entity.Property(e => e.Instalment)
                    .HasColumnName("INSTALMENT")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Intid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("INTID");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Isintegrated)
                    .HasColumnName("ISINTEGRATED")
                    .HasComputedColumnSql("(case when [ENTID] IS NULL then (0) else (1) end)", true);

                entity.Property(e => e.LastAmount).HasColumnName("LAST_AMOUNT");

                entity.Property(e => e.PayerAuthcode)
                    .HasMaxLength(50)
                    .HasColumnName("PAYER_AUTHCODE");

                entity.Property(e => e.PayerTnxid)
                    .HasMaxLength(50)
                    .HasColumnName("PAYER_TNXID");

                entity.Property(e => e.PaymentRequestid).HasColumnName("PAYMENT_REQUESTID");

                entity.Property(e => e.Posaccountid).HasColumnName("POSACCOUNTID");

                entity.Property(e => e.Posinstalmentid).HasColumnName("POSINSTALMENTID");

                entity.Property(e => e.Postauth).HasColumnName("POSTAUTH");

                entity.Property(e => e.Preauth).HasColumnName("PREAUTH");

                entity.Property(e => e.Refund).HasColumnName("REFUND");

                entity.Property(e => e.Requestid).HasColumnName("REQUESTID");

                entity.Property(e => e.Retrefnumber)
                    .HasMaxLength(200)
                    .HasColumnName("RETREFNUMBER");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Statustext)
                    .HasMaxLength(500)
                    .HasColumnName("STATUSTEXT");

                entity.Property(e => e.Storetype)
                    .HasMaxLength(30)
                    .HasColumnName("STORETYPE");

                entity.Property(e => e.Trantype)
                    .HasMaxLength(15)
                    .HasColumnName("TRANTYPE");

                entity.Property(e => e.Validdate)
                    .HasColumnType("datetime")
                    .HasColumnName("VALIDDATE");

                entity.Property(e => e.Validmonth).HasColumnName("VALIDMONTH");

                entity.Property(e => e.Validyear).HasColumnName("VALIDYEAR");

                entity.Property(e => e.Void).HasColumnName("VOID");

                entity.HasOne(d => d.AdduserNavigation)
                    .WithMany(p => p.VirtualPosPaymentsAdduserNavigation)
                    .HasForeignKey(d => d.Adduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REQUEST_P__ADDUS__25C68D63");

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.VirtualPosPayments)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__CORPI__511AFFBC");

                entity.HasOne(d => d.CurcodeNavigation)
                    .WithMany(p => p.VirtualPosPayments)
                    .HasForeignKey(d => d.Curcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REQUEST_P__CURCO__23DE44F1");

                entity.HasOne(d => d.EdituserNavigation)
                    .WithMany(p => p.VirtualPosPaymentsEdituserNavigation)
                    .HasForeignKey(d => d.Edituser)
                    .HasConstraintName("FK__REQUEST_P__EDITU__26BAB19C");

                entity.HasOne(d => d.PaymentRequest)
                    .WithMany(p => p.VirtualPosPayments)
                    .HasForeignKey(d => d.PaymentRequestid)
                    .HasConstraintName("FK_VIRTUAL_POS_PAYMENTS_VIRTUAL_POS_PAYMENT_REQUESTS");

                entity.HasOne(d => d.Posaccount)
                    .WithMany(p => p.VirtualPosPayments)
                    .HasForeignKey(d => d.Posaccountid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VIRTUAL_POS_PAYMENTS_VIRTUAL_POS_ACCOUNTS");

                entity.HasOne(d => d.Posinstalment)
                    .WithMany(p => p.VirtualPosPayments)
                    .HasForeignKey(d => d.Posinstalmentid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__POSIN__520F23F5");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.VirtualPosPayments)
                    .HasForeignKey(d => d.Requestid)
                    .HasConstraintName("FK__REQUEST_P__REQUE__22EA20B8");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.VirtualPosPayments)
                    .HasForeignKey(d => d.Status)
                    .HasConstraintName("FK__REQUEST_P__STATU__24D2692A");
            });

            modelBuilder.Entity<VirtualPosPaymentsCancel>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__VIRTUAL___3214EC2696B31157")
                    .IsClustered(false);

                entity.ToTable("VIRTUAL_POS_PAYMENTS_CANCEL");

                entity.HasIndex(e => e.Success, "IX_VIRTUAL_POS_PAYMENTS_CANCEL");

                entity.HasIndex(e => e.Adddate, "IX_VIRTUAL_POS_PAYMENTS_CANCEL_1");

                entity.HasIndex(e => e.Adddate, "IX_VIRTUAL_POS_PAYMENTS_CANCEL_2");

                entity.HasIndex(e => new { e.Paymentid, e.Success }, "IX_VIRTUAL_POS_PAYMENTS_CANCEL_3");

                entity.HasIndex(e => e.Entid, "IX_VIRTUAL_POS_PAYMENTS_CANCEL_4");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Entid)
                    .HasMaxLength(100)
                    .HasColumnName("ENTID");

                entity.Property(e => e.Isrefund).HasColumnName("ISREFUND");

                entity.Property(e => e.Isvoid).HasColumnName("ISVOID");

                entity.Property(e => e.Paymentid).HasColumnName("PAYMENTID");

                entity.Property(e => e.RequestDetailid).HasColumnName("REQUEST_DETAILID");

                entity.Property(e => e.Success).HasColumnName("SUCCESS");

                entity.HasOne(d => d.RequestDetail)
                    .WithMany(p => p.VirtualPosPaymentsCancel)
                    .HasForeignKey(d => d.RequestDetailid)
                    .HasConstraintName("FK__VIRTUAL_P__REQUE__2D1D9668");
            });

            modelBuilder.Entity<VirtualPosSwap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VIRTUAL_POS_SWAP");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Posid1).HasColumnName("POSID1");

                entity.Property(e => e.Posid2).HasColumnName("POSID2");

                entity.HasOne(d => d.Posid1Navigation)
                    .WithMany()
                    .HasForeignKey(d => d.Posid1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__POSID__38F95D68");

                entity.HasOne(d => d.Posid2Navigation)
                    .WithMany()
                    .HasForeignKey(d => d.Posid2)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__POSID__39ED81A1");
            });

            modelBuilder.Entity<VirtualPosbinnames>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VIRTUAL_POSBINNAMES");

                entity.Property(e => e.BinnumberName)
                    .HasMaxLength(50)
                    .HasColumnName("BINNUMBER_NAME");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Posid).HasColumnName("POSID");

                entity.HasOne(d => d.Pos)
                    .WithMany()
                    .HasForeignKey(d => d.Posid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__POSID__361CF0BD");
            });

            modelBuilder.Entity<VwBasketInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_BASKET_INFO");

                entity.Property(e => e.Adult).HasColumnName("ADULT");

                entity.Property(e => e.AllowSingleMen).HasColumnName("ALLOW_SINGLE_MEN");

                entity.Property(e => e.Baby).HasColumnName("BABY");

                entity.Property(e => e.BabyMaxage).HasColumnName("BABY_MAXAGE");

                entity.Property(e => e.Boardtype)
                    .HasMaxLength(25)
                    .HasColumnName("BOARDTYPE");

                entity.Property(e => e.Boardtypeid).HasColumnName("BOARDTYPEID");

                entity.Property(e => e.CancelationDays).HasColumnName("CANCELATION_DAYS");

                entity.Property(e => e.CancelationRate).HasColumnName("CANCELATION_RATE");

                entity.Property(e => e.CancellationWarrantyRate).HasColumnName("CANCELLATION_WARRANTY_RATE");

                entity.Property(e => e.Chde).HasColumnName("CHDE");

                entity.Property(e => e.ChdeMaxage).HasColumnName("CHDE_MAXAGE");

                entity.Property(e => e.Chdy).HasColumnName("CHDY");

                entity.Property(e => e.ChdyMaxage).HasColumnName("CHDY_MAXAGE");

                entity.Property(e => e.Checkintime)
                    .HasColumnType("datetime")
                    .HasColumnName("CHECKINTIME");

                entity.Property(e => e.Checkouttime)
                    .HasColumnType("datetime")
                    .HasColumnName("CHECKOUTTIME");

                entity.Property(e => e.City)
                    .HasMaxLength(70)
                    .HasColumnName("CITY");

                entity.Property(e => e.Correlationid).HasColumnName("CORRELATIONID");

                entity.Property(e => e.Country)
                    .HasMaxLength(70)
                    .HasColumnName("COUNTRY");

                entity.Property(e => e.Curcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CURCODE")
                    .IsFixedLength();

                entity.Property(e => e.DGrandTotal).HasColumnName("D_GRAND_TOTAL");

                entity.Property(e => e.Date1)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE1");

                entity.Property(e => e.Date2)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE2");

                entity.Property(e => e.DiscountRate).HasColumnName("DISCOUNT_RATE");

                entity.Property(e => e.DiscountReq).HasColumnName("DISCOUNT_REQ");

                entity.Property(e => e.DiscountResult).HasColumnName("DISCOUNT_RESULT");

                entity.Property(e => e.ExtraTotal).HasColumnName("EXTRA_TOTAL");

                entity.Property(e => e.Fromloc)
                    .HasMaxLength(170)
                    .HasColumnName("FROMLOC");

                entity.Property(e => e.Fromlocationid).HasColumnName("FROMLOCATIONID");

                entity.Property(e => e.GrandTotal).HasColumnName("GRAND_TOTAL");

                entity.Property(e => e.Hotelid).HasColumnName("HOTELID");

                entity.Property(e => e.Marketid).HasColumnName("MARKETID");

                entity.Property(e => e.MenAccommodationForbidden).HasColumnName("MEN_ACCOMMODATION_FORBIDDEN");

                entity.Property(e => e.PayAtPlace).HasColumnName("PAY_AT_PLACE");

                entity.Property(e => e.PaymentRate).HasColumnName("PAYMENT_RATE");

                entity.Property(e => e.Pnr1)
                    .HasMaxLength(15)
                    .HasColumnName("PNR1");

                entity.Property(e => e.Pnr2)
                    .HasMaxLength(15)
                    .HasColumnName("PNR2");

                entity.Property(e => e.Productname)
                    .HasMaxLength(200)
                    .HasColumnName("PRODUCTNAME");

                entity.Property(e => e.ProjectDetailid).HasColumnName("PROJECT_DETAILID");

                entity.Property(e => e.Promotion)
                    .HasMaxLength(150)
                    .HasColumnName("PROMOTION");

                entity.Property(e => e.Promotioncode)
                    .HasMaxLength(255)
                    .HasColumnName("PROMOTIONCODE");

                entity.Property(e => e.Promotionid).HasColumnName("PROMOTIONID");

                entity.Property(e => e.Ratecodeid).HasColumnName("RATECODEID");

                entity.Property(e => e.Ratetype)
                    .HasMaxLength(50)
                    .HasColumnName("RATETYPE");

                entity.Property(e => e.Ratetypeid).HasColumnName("RATETYPEID");

                entity.Property(e => e.ReqCurcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("REQ_CURCODE")
                    .IsFixedLength();

                entity.Property(e => e.Requestdetailid).HasColumnName("REQUESTDETAILID");

                entity.Property(e => e.Requestid).HasColumnName("REQUESTID");

                entity.Property(e => e.ReservationSettingsid).HasColumnName("RESERVATION_SETTINGSID");

                entity.Property(e => e.Roomcount).HasColumnName("ROOMCOUNT");

                entity.Property(e => e.Roomtype)
                    .HasMaxLength(50)
                    .HasColumnName("ROOMTYPE");

                entity.Property(e => e.Roomtypeid).HasColumnName("ROOMTYPEID");

                entity.Property(e => e.Roundtrip).HasColumnName("ROUNDTRIP");

                entity.Property(e => e.SpecialCode)
                    .HasMaxLength(15)
                    .HasColumnName("SPECIAL_CODE");

                entity.Property(e => e.Stars).HasColumnName("STARS");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Substatus).HasColumnName("SUBSTATUS");

                entity.Property(e => e.Thumbnailurl)
                    .HasMaxLength(350)
                    .HasColumnName("THUMBNAILURL");

                entity.Property(e => e.Toloc)
                    .HasMaxLength(170)
                    .HasColumnName("TOLOC");

                entity.Property(e => e.Tolocationid).HasColumnName("TOLOCATIONID");

                entity.Property(e => e.Total).HasColumnName("TOTAL");

                entity.Property(e => e.TotalPayments).HasColumnName("TOTAL_PAYMENTS");

                entity.Property(e => e.TransferPriceid).HasColumnName("TRANSFER_PRICEID");

                entity.Property(e => e.Validdate)
                    .HasColumnType("datetime")
                    .HasColumnName("VALIDDATE");

                entity.Property(e => e.Validday).HasColumnName("VALIDDAY");

                entity.Property(e => e.Vehicle)
                    .HasMaxLength(70)
                    .HasColumnName("VEHICLE");

                entity.Property(e => e.VehiclePersonCount).HasColumnName("VEHICLE_PERSON_COUNT");

                entity.Property(e => e.Vehicleid).HasColumnName("VEHICLEID");

                entity.Property(e => e.Vehicletype)
                    .HasMaxLength(40)
                    .HasColumnName("VEHICLETYPE");
            });

            modelBuilder.Entity<VwBasketPayments>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_BASKET_PAYMENTS");

                entity.Property(e => e.Accountname)
                    .HasMaxLength(50)
                    .HasColumnName("ACCOUNTNAME");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Authcode)
                    .HasMaxLength(200)
                    .HasColumnName("AUTHCODE");

                entity.Property(e => e.Camount).HasColumnName("CAMOUNT");

                entity.Property(e => e.CancelAmount).HasColumnName("CANCEL_AMOUNT");

                entity.Property(e => e.Cardno)
                    .HasMaxLength(24)
                    .HasColumnName("CARDNO");

                entity.Property(e => e.Cardowner)
                    .HasMaxLength(200)
                    .HasColumnName("CARDOWNER");

                entity.Property(e => e.Ccurcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CCURCODE")
                    .IsFixedLength();

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Ctotal).HasColumnName("CTOTAL");

                entity.Property(e => e.Curcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CURCODE")
                    .IsFixedLength();

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Endtime)
                    .HasColumnType("datetime")
                    .HasColumnName("ENDTIME");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Instalment).HasColumnName("INSTALMENT");

                entity.Property(e => e.Intid).HasColumnName("INTID");

                entity.Property(e => e.LastAmount).HasColumnName("LAST_AMOUNT");

                entity.Property(e => e.Paytpe).HasColumnName("PAYTPE");

                entity.Property(e => e.Pos)
                    .HasMaxLength(150)
                    .HasColumnName("POS");

                entity.Property(e => e.Postauth).HasColumnName("POSTAUTH");

                entity.Property(e => e.Preauth).HasColumnName("PREAUTH");

                entity.Property(e => e.Refund).HasColumnName("REFUND");

                entity.Property(e => e.Requestid).HasColumnName("REQUESTID");

                entity.Property(e => e.Retrefnumber)
                    .HasMaxLength(200)
                    .HasColumnName("RETREFNUMBER");

                entity.Property(e => e.Statuid).HasColumnName("STATUID");

                entity.Property(e => e.Storetype)
                    .HasMaxLength(30)
                    .HasColumnName("STORETYPE");

                entity.Property(e => e.Substatus).HasColumnName("SUBSTATUS");

                entity.Property(e => e.Terminalid)
                    .HasMaxLength(50)
                    .HasColumnName("TERMINALID");

                entity.Property(e => e.Trantype)
                    .HasMaxLength(15)
                    .HasColumnName("TRANTYPE");

                entity.Property(e => e.Void).HasColumnName("VOID");
            });

            modelBuilder.Entity<VwCallJobs>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_CALL_JOBS");

                entity.Property(e => e.Callnumber).HasColumnName("CALLNUMBER");

                entity.Property(e => e.Calltime)
                    .HasColumnType("datetime")
                    .HasColumnName("CALLTIME");

                entity.Property(e => e.Campaigncode)
                    .HasMaxLength(100)
                    .HasColumnName("CAMPAIGNCODE")
                    .IsFixedLength();

                entity.Property(e => e.Description).HasColumnName("DESCRIPTION");

                entity.Property(e => e.Dontcall).HasColumnName("DONTCALL");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(70)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(200)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Isfinished).HasColumnName("ISFINISHED");

                entity.Property(e => e.Jobend).HasColumnName("jobend");

                entity.Property(e => e.Jobid).HasColumnName("JOBID");

                entity.Property(e => e.Jobstart).HasColumnName("jobstart");

                entity.Property(e => e.Kind)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("KIND")
                    .IsFixedLength();

                entity.Property(e => e.Lastname)
                    .HasMaxLength(70)
                    .HasColumnName("LASTNAME");

                entity.Property(e => e.Maxtrycount).HasColumnName("MAXTRYCOUNT");

                entity.Property(e => e.MaxtrycountBusy).HasColumnName("MAXTRYCOUNT_BUSY");

                entity.Property(e => e.OutputExten)
                    .HasMaxLength(150)
                    .HasColumnName("OUTPUT_EXTEN");

                entity.Property(e => e.Personid).HasColumnName("PERSONID");

                entity.Property(e => e.Phonenumber)
                    .HasMaxLength(50)
                    .HasColumnName("PHONENUMBER");

                entity.Property(e => e.Priority).HasColumnName("PRIORITY");

                entity.Property(e => e.ProjectDetailid).HasColumnName("PROJECT_DETAILID");

                entity.Property(e => e.ProjectGroupid).HasColumnName("PROJECT_GROUPID");

                entity.Property(e => e.Queuelogid).HasColumnName("QUEUELOGID");

                entity.Property(e => e.Reason)
                    .HasMaxLength(33)
                    .IsUnicode(false)
                    .HasColumnName("REASON");

                entity.Property(e => e.Sdate)
                    .HasColumnType("datetime")
                    .HasColumnName("SDATE");

                entity.Property(e => e.Sortfld)
                    .HasColumnType("datetime")
                    .HasColumnName("SORTFLD");

                entity.Property(e => e.State)
                    .HasMaxLength(25)
                    .HasColumnName("STATE");

                entity.Property(e => e.Trycount).HasColumnName("TRYCOUNT");

                entity.Property(e => e.TrycountBusy).HasColumnName("TRYCOUNT_BUSY");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<VwCalljobReasons>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_CALLJOB_REASONS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Reason)
                    .HasMaxLength(33)
                    .IsUnicode(false)
                    .HasColumnName("REASON");
            });

            modelBuilder.Entity<VwCampaigns>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_CAMPAIGNS");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .HasColumnName("CODE");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Enddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ENDDATE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.ProjectDetailid).HasColumnName("PROJECT_DETAILID");

                entity.Property(e => e.Projectid).HasColumnName("PROJECTID");

                entity.Property(e => e.Resourceid).HasColumnName("RESOURCEID");

                entity.Property(e => e.Startdate)
                    .HasColumnType("datetime")
                    .HasColumnName("STARTDATE");
            });

            modelBuilder.Entity<VwHotelMarketCountry>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_HOTEL_MARKET_COUNTRY");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Countrycode)
                    .HasMaxLength(2)
                    .HasColumnName("COUNTRYCODE");

                entity.Property(e => e.Hotelid).HasColumnName("HOTELID");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<VwIpcountrycodes>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_IPCOUNTRYCODES");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(2)
                    .HasColumnName("country_code");

                entity.Property(e => e.CountryName)
                    .HasMaxLength(64)
                    .HasColumnName("country_name");
            });

            modelBuilder.Entity<VwIplocations>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_IPLOCATIONS");

                entity.Property(e => e.CityName)
                    .HasMaxLength(128)
                    .HasColumnName("city_name");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(2)
                    .HasColumnName("country_code");

                entity.Property(e => e.CountryName)
                    .HasMaxLength(64)
                    .HasColumnName("country_name");

                entity.Property(e => e.IpFrom).HasColumnName("ip_from");

                entity.Property(e => e.IpTo).HasColumnName("ip_to");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.RegionName)
                    .HasMaxLength(128)
                    .HasColumnName("region_name");
            });

            modelBuilder.Entity<VwLocations>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_LOCATIONS");

                entity.Property(e => e.Code)
                    .HasMaxLength(5)
                    .HasColumnName("CODE");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Definition)
                    .HasMaxLength(170)
                    .HasColumnName("DEFINITION");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Type)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("TYPE");
            });

            modelBuilder.Entity<VwMobPaymentReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_MOB_PAYMENT_REPORT");

                entity.Property(e => e.Authcode)
                    .HasMaxLength(200)
                    .HasColumnName("AUTHCODE");

                entity.Property(e => e.CancelAmount).HasColumnName("CANCEL_AMOUNT");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Ctotal).HasColumnName("CTOTAL");

                entity.Property(e => e.Curcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CURCODE")
                    .IsFixedLength();

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Endtime)
                    .HasColumnType("datetime")
                    .HasColumnName("ENDTIME");

                entity.Property(e => e.Intid).HasColumnName("INTID");

                entity.Property(e => e.LastAmount).HasColumnName("LAST_AMOUNT");

                entity.Property(e => e.Paytype)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("PAYTYPE");

                entity.Property(e => e.Personname)
                    .HasMaxLength(212)
                    .HasColumnName("PERSONNAME");

                entity.Property(e => e.Pos)
                    .HasMaxLength(150)
                    .HasColumnName("POS");

                entity.Property(e => e.Productname)
                    .HasMaxLength(150)
                    .HasColumnName("PRODUCTNAME");

                entity.Property(e => e.ProjectGroupdetail)
                    .HasMaxLength(200)
                    .HasColumnName("PROJECT_GROUPDETAIL");

                entity.Property(e => e.ProjectGroupid).HasColumnName("PROJECT_GROUPID");

                entity.Property(e => e.Projectgroup)
                    .HasMaxLength(150)
                    .HasColumnName("PROJECTGROUP");

                entity.Property(e => e.Rcurcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("RCURCODE")
                    .IsFixedLength();

                entity.Property(e => e.Resids)
                    .HasMaxLength(100)
                    .HasColumnName("RESIDS");

                entity.Property(e => e.Statu)
                    .HasMaxLength(200)
                    .HasColumnName("STATU");

                entity.Property(e => e.Statuid).HasColumnName("STATUID");

                entity.Property(e => e.Substatu)
                    .HasMaxLength(200)
                    .HasColumnName("SUBSTATU");

                entity.Property(e => e.Total).HasColumnName("TOTAL");
            });

            modelBuilder.Entity<VwProducts>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_PRODUCTS");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .HasColumnName("NAME");

                entity.Property(e => e.Type)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TYPE");
            });

            modelBuilder.Entity<VwProjectGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_PROJECT_GROUP");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.Mergeclients).HasColumnName("MERGECLIENTS");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .HasColumnName("NAME");

                entity.Property(e => e.Usealternates).HasColumnName("USEALTERNATES");
            });

            modelBuilder.Entity<VwPromotionCodes>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_PROMOTION_CODES");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .HasColumnName("CODE");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Definition)
                    .HasMaxLength(150)
                    .HasColumnName("DEFINITION");

                entity.Property(e => e.Discountkind)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("DISCOUNTKIND");

                entity.Property(e => e.Discounttype)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("DISCOUNTTYPE");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Edituser).HasColumnName("EDITUSER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.Kind)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("KIND");

                entity.Property(e => e.Sellfrom)
                    .HasColumnType("datetime")
                    .HasColumnName("SELLFROM");

                entity.Property(e => e.Sellto)
                    .HasColumnType("datetime")
                    .HasColumnName("SELLTO");

                entity.Property(e => e.Stayfrom)
                    .HasColumnType("datetime")
                    .HasColumnName("STAYFROM");

                entity.Property(e => e.Stayto)
                    .HasColumnType("datetime")
                    .HasColumnName("STAYTO");

                entity.Property(e => e.Usetype)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("USETYPE");
            });

            modelBuilder.Entity<VwRequestPaymentCancels>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_REQUEST_PAYMENT_CANCELS");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE");

                entity.Property(e => e.Cancelid).HasColumnName("CANCELID");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Curcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CURCODE")
                    .IsFixedLength();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Paymentid).HasColumnName("PAYMENTID");

                entity.Property(e => e.Refund).HasColumnName("REFUND");

                entity.Property(e => e.RequestDetailid).HasColumnName("REQUEST_DETAILID");

                entity.Property(e => e.Requestid).HasColumnName("REQUESTID");

                entity.Property(e => e.Type).HasColumnName("TYPE");

                entity.Property(e => e.Void).HasColumnName("VOID");
            });

            modelBuilder.Entity<VwRequestPayments>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_REQUEST_PAYMENTS");

                entity.Property(e => e.Adddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADDDATE");

                entity.Property(e => e.Adduser).HasColumnName("ADDUSER");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Cardno)
                    .HasMaxLength(250)
                    .HasColumnName("CARDNO");

                entity.Property(e => e.Curcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CURCODE")
                    .IsFixedLength();

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Endtime)
                    .HasColumnType("datetime")
                    .HasColumnName("ENDTIME");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(201)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Instalment).HasColumnName("INSTALMENT");

                entity.Property(e => e.Intid).HasColumnName("INTID");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Paytpe).HasColumnName("PAYTPE");

                entity.Property(e => e.Pos)
                    .HasMaxLength(150)
                    .HasColumnName("POS");

                entity.Property(e => e.Postauth).HasColumnName("POSTAUTH");

                entity.Property(e => e.Preauth).HasColumnName("PREAUTH");

                entity.Property(e => e.Refund).HasColumnName("REFUND");

                entity.Property(e => e.Requestid).HasColumnName("REQUESTID");

                entity.Property(e => e.Statustext)
                    .HasMaxLength(500)
                    .HasColumnName("STATUSTEXT");

                entity.Property(e => e.Storetype)
                    .HasMaxLength(30)
                    .HasColumnName("STORETYPE");

                entity.Property(e => e.Substatus).HasColumnName("SUBSTATUS");

                entity.Property(e => e.Trantype)
                    .HasMaxLength(15)
                    .HasColumnName("TRANTYPE");

                entity.Property(e => e.Void).HasColumnName("VOID");
            });

            modelBuilder.Entity<VwSales>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_SALES");

                entity.Property(e => e.Adult).HasColumnName("ADULT");

                entity.Property(e => e.Agentid).HasColumnName("AGENTID");

                entity.Property(e => e.Baby).HasColumnName("BABY");

                entity.Property(e => e.CancelationWarranty).HasColumnName("CANCELATION_WARRANTY");

                entity.Property(e => e.CancellationWarrantyRate).HasColumnName("CANCELLATION_WARRANTY_RATE");

                entity.Property(e => e.Chd1).HasColumnName("CHD1");

                entity.Property(e => e.Chd2).HasColumnName("CHD2");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Country)
                    .HasMaxLength(70)
                    .HasColumnName("COUNTRY");

                entity.Property(e => e.Curcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CURCODE")
                    .IsFixedLength();

                entity.Property(e => e.Date1)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE1");

                entity.Property(e => e.Date2)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE2");

                entity.Property(e => e.DirectBranding)
                    .HasMaxLength(15)
                    .HasColumnName("DIRECT_BRANDING");

                entity.Property(e => e.GrandTotal).HasColumnName("GRAND_TOTAL");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Market)
                    .HasMaxLength(50)
                    .HasColumnName("MARKET");

                entity.Property(e => e.Nights).HasColumnName("NIGHTS");

                entity.Property(e => e.Pax).HasColumnName("PAX");

                entity.Property(e => e.Personid).HasColumnName("PERSONID");

                entity.Property(e => e.Personname)
                    .HasMaxLength(212)
                    .HasColumnName("PERSONNAME");

                entity.Property(e => e.Productid).HasColumnName("PRODUCTID");

                entity.Property(e => e.Productname)
                    .HasMaxLength(250)
                    .HasColumnName("PRODUCTNAME");

                entity.Property(e => e.Producttype)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCTTYPE");

                entity.Property(e => e.ProfitPercent).HasColumnName("PROFIT_PERCENT");

                entity.Property(e => e.ProjectDetailIntid).HasColumnName("PROJECT_DETAIL_INTID");

                entity.Property(e => e.ProjectDetailid).HasColumnName("PROJECT_DETAILID");

                entity.Property(e => e.ProjectGroupid).HasColumnName("PROJECT_GROUPID");

                entity.Property(e => e.Rdaddate)
                    .HasColumnType("date")
                    .HasColumnName("RDADDATE");

                entity.Property(e => e.Reqaddate)
                    .HasColumnType("date")
                    .HasColumnName("REQADDATE");

                entity.Property(e => e.Requestid).HasColumnName("REQUESTID");

                entity.Property(e => e.Resourceid).HasColumnName("RESOURCEID");

                entity.Property(e => e.Roomcount).HasColumnName("ROOMCOUNT");

                entity.Property(e => e.SellDate)
                    .HasColumnType("date")
                    .HasColumnName("SELL_DATE");

                entity.Property(e => e.SellerUserid).HasColumnName("SELLER_USERID");

                entity.Property(e => e.Status)
                    .HasMaxLength(200)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Statuscode).HasColumnName("STATUSCODE");

                entity.Property(e => e.Subproduct)
                    .HasMaxLength(50)
                    .HasColumnName("SUBPRODUCT");

                entity.Property(e => e.Substatus)
                    .HasMaxLength(200)
                    .HasColumnName("SUBSTATUS");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<VwSalesAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_SALES_ALL");

                entity.Property(e => e.Adult).HasColumnName("ADULT");

                entity.Property(e => e.Agentid).HasColumnName("AGENTID");

                entity.Property(e => e.Baby).HasColumnName("BABY");

                entity.Property(e => e.Boardtype)
                    .HasMaxLength(25)
                    .HasColumnName("BOARDTYPE");

                entity.Property(e => e.Chd1).HasColumnName("CHD1");

                entity.Property(e => e.Chd2).HasColumnName("CHD2");

                entity.Property(e => e.Chde).HasColumnName("CHDE");

                entity.Property(e => e.Chdy).HasColumnName("CHDY");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Cost)
                    .HasColumnType("decimal(38, 2)")
                    .HasColumnName("COST");

                entity.Property(e => e.Curcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CURCODE")
                    .IsFixedLength();

                entity.Property(e => e.Date1)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE1");

                entity.Property(e => e.Date2)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE2");

                entity.Property(e => e.DirectBranding)
                    .HasMaxLength(15)
                    .HasColumnName("DIRECT_BRANDING");

                entity.Property(e => e.ExtraTotal).HasColumnName("EXTRA_TOTAL");

                entity.Property(e => e.GrandTotal).HasColumnName("GRAND_TOTAL");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Market)
                    .HasMaxLength(50)
                    .HasColumnName("MARKET");

                entity.Property(e => e.National)
                    .HasMaxLength(70)
                    .HasColumnName("NATIONAL");

                entity.Property(e => e.Personid).HasColumnName("PERSONID");

                entity.Property(e => e.Personname)
                    .HasMaxLength(212)
                    .HasColumnName("PERSONNAME");

                entity.Property(e => e.Productid).HasColumnName("PRODUCTID");

                entity.Property(e => e.Productname)
                    .HasMaxLength(250)
                    .HasColumnName("PRODUCTNAME");

                entity.Property(e => e.Producttype)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCTTYPE");

                entity.Property(e => e.ProfitPercent).HasColumnName("PROFIT_PERCENT");

                entity.Property(e => e.ProjectDetailIntid).HasColumnName("PROJECT_DETAIL_INTID");

                entity.Property(e => e.ProjectDetailid).HasColumnName("PROJECT_DETAILID");

                entity.Property(e => e.ProjectGroupid).HasColumnName("PROJECT_GROUPID");

                entity.Property(e => e.Requestid).HasColumnName("REQUESTID");

                entity.Property(e => e.Resid)
                    .HasMaxLength(22)
                    .HasColumnName("RESID");

                entity.Property(e => e.Resourcecode)
                    .HasMaxLength(30)
                    .HasColumnName("RESOURCECODE");

                entity.Property(e => e.Resourceid).HasColumnName("RESOURCEID");

                entity.Property(e => e.Resourcename)
                    .HasMaxLength(150)
                    .HasColumnName("RESOURCENAME");

                entity.Property(e => e.Roomcount).HasColumnName("ROOMCOUNT");

                entity.Property(e => e.Roomtype)
                    .HasMaxLength(50)
                    .HasColumnName("ROOMTYPE");

                entity.Property(e => e.Status)
                    .HasMaxLength(200)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Statuscode).HasColumnName("STATUSCODE");

                entity.Property(e => e.Statusid).HasColumnName("STATUSID");

                entity.Property(e => e.Substatus)
                    .HasMaxLength(200)
                    .HasColumnName("SUBSTATUS");

                entity.Property(e => e.Tdate)
                    .HasColumnType("datetime")
                    .HasColumnName("TDATE");

                entity.Property(e => e.Total).HasColumnName("TOTAL");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<VwSalesReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_SALES_REPORT");

                entity.Property(e => e.Agentid).HasColumnName("AGENTID");

                entity.Property(e => e.Baby).HasColumnName("BABY");

                entity.Property(e => e.Chd1).HasColumnName("CHD1");

                entity.Property(e => e.Chd2).HasColumnName("CHD2");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Count).HasColumnName("COUNT");

                entity.Property(e => e.Country)
                    .HasMaxLength(70)
                    .HasColumnName("COUNTRY");

                entity.Property(e => e.Curcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CURCODE")
                    .IsFixedLength();

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("DATE");

                entity.Property(e => e.Day).HasColumnName("DAY");

                entity.Property(e => e.DirectBranding)
                    .HasMaxLength(15)
                    .HasColumnName("DIRECT_BRANDING");

                entity.Property(e => e.Market)
                    .HasMaxLength(50)
                    .HasColumnName("MARKET");

                entity.Property(e => e.Month).HasColumnName("MONTH");

                entity.Property(e => e.Nights).HasColumnName("NIGHTS");

                entity.Property(e => e.Pax).HasColumnName("PAX");

                entity.Property(e => e.Productid).HasColumnName("PRODUCTID");

                entity.Property(e => e.Productname)
                    .HasMaxLength(250)
                    .HasColumnName("PRODUCTNAME");

                entity.Property(e => e.Producttype)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCTTYPE");

                entity.Property(e => e.ProfitPercent).HasColumnName("PROFIT_PERCENT");

                entity.Property(e => e.ProjectDetailIntid).HasColumnName("PROJECT_DETAIL_INTID");

                entity.Property(e => e.ProjectDetailid).HasColumnName("PROJECT_DETAILID");

                entity.Property(e => e.ProjectGroupid).HasColumnName("PROJECT_GROUPID");

                entity.Property(e => e.Resourceid).HasColumnName("RESOURCEID");

                entity.Property(e => e.Roomcount).HasColumnName("ROOMCOUNT");

                entity.Property(e => e.SellerUserid).HasColumnName("SELLER_USERID");

                entity.Property(e => e.Status)
                    .HasMaxLength(200)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Statuscode).HasColumnName("STATUSCODE");

                entity.Property(e => e.Subproduct)
                    .HasMaxLength(50)
                    .HasColumnName("SUBPRODUCT");

                entity.Property(e => e.Substatus)
                    .HasMaxLength(200)
                    .HasColumnName("SUBSTATUS");

                entity.Property(e => e.Total).HasColumnName("TOTAL");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("USERNAME");

                entity.Property(e => e.WarrantyAmount).HasColumnName("WARRANTY_AMOUNT");

                entity.Property(e => e.Year).HasColumnName("YEAR");
            });

            modelBuilder.Entity<VwSalesReportAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_SALES_REPORT_ALL");

                entity.Property(e => e.Agentid).HasColumnName("AGENTID");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Cost)
                    .HasColumnType("decimal(38, 2)")
                    .HasColumnName("COST");

                entity.Property(e => e.Count).HasColumnName("COUNT");

                entity.Property(e => e.Curcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CURCODE")
                    .IsFixedLength();

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("DATE");

                entity.Property(e => e.Day).HasColumnName("DAY");

                entity.Property(e => e.DirectBranding)
                    .HasMaxLength(15)
                    .HasColumnName("DIRECT_BRANDING");

                entity.Property(e => e.Month).HasColumnName("MONTH");

                entity.Property(e => e.Pax).HasColumnName("PAX");

                entity.Property(e => e.Productname)
                    .HasMaxLength(200)
                    .HasColumnName("PRODUCTNAME");

                entity.Property(e => e.Producttype)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCTTYPE");

                entity.Property(e => e.ProfitPercent).HasColumnName("PROFIT_PERCENT");

                entity.Property(e => e.ProjectDetailIntid).HasColumnName("PROJECT_DETAIL_INTID");

                entity.Property(e => e.ProjectDetailid).HasColumnName("PROJECT_DETAILID");

                entity.Property(e => e.ProjectGroupid).HasColumnName("PROJECT_GROUPID");

                entity.Property(e => e.Resourceid).HasColumnName("RESOURCEID");

                entity.Property(e => e.Roomcount).HasColumnName("ROOMCOUNT");

                entity.Property(e => e.Status)
                    .HasMaxLength(200)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Statuscode).HasColumnName("STATUSCODE");

                entity.Property(e => e.Substatus)
                    .HasMaxLength(200)
                    .HasColumnName("SUBSTATUS");

                entity.Property(e => e.Total).HasColumnName("TOTAL");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("USERNAME");

                entity.Property(e => e.Year).HasColumnName("YEAR");
            });

            modelBuilder.Entity<VwSalesReportWithResourcepath>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_SALES_REPORT_WITH_RESOURCEPATH");

                entity.Property(e => e.Agentid).HasColumnName("AGENTID");

                entity.Property(e => e.Baby).HasColumnName("BABY");

                entity.Property(e => e.Chd1).HasColumnName("CHD1");

                entity.Property(e => e.Chd2).HasColumnName("CHD2");

                entity.Property(e => e.Code)
                    .HasMaxLength(30)
                    .HasColumnName("CODE");

                entity.Property(e => e.Corpid).HasColumnName("CORPID");

                entity.Property(e => e.Count).HasColumnName("COUNT");

                entity.Property(e => e.Country)
                    .HasMaxLength(70)
                    .HasColumnName("COUNTRY");

                entity.Property(e => e.Curcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CURCODE")
                    .IsFixedLength();

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("DATE");

                entity.Property(e => e.Day).HasColumnName("DAY");

                entity.Property(e => e.DirectBranding)
                    .HasMaxLength(15)
                    .HasColumnName("DIRECT_BRANDING");

                entity.Property(e => e.Market)
                    .HasMaxLength(50)
                    .HasColumnName("MARKET");

                entity.Property(e => e.Month).HasColumnName("MONTH");

                entity.Property(e => e.Nights).HasColumnName("NIGHTS");

                entity.Property(e => e.Pax).HasColumnName("PAX");

                entity.Property(e => e.Productid).HasColumnName("PRODUCTID");

                entity.Property(e => e.Productname)
                    .HasMaxLength(250)
                    .HasColumnName("PRODUCTNAME");

                entity.Property(e => e.Producttype)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCTTYPE");

                entity.Property(e => e.ProfitPercent).HasColumnName("PROFIT_PERCENT");

                entity.Property(e => e.ProjectDetailIntid).HasColumnName("PROJECT_DETAIL_INTID");

                entity.Property(e => e.ProjectDetailid).HasColumnName("PROJECT_DETAILID");

                entity.Property(e => e.ProjectGroupid).HasColumnName("PROJECT_GROUPID");

                entity.Property(e => e.ResourcePath)
                    .HasMaxLength(500)
                    .HasColumnName("RESOURCE_PATH");

                entity.Property(e => e.Resourceid).HasColumnName("RESOURCEID");

                entity.Property(e => e.Roomcount).HasColumnName("ROOMCOUNT");

                entity.Property(e => e.SellerUserid).HasColumnName("SELLER_USERID");

                entity.Property(e => e.Status)
                    .HasMaxLength(200)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Statuscode).HasColumnName("STATUSCODE");

                entity.Property(e => e.Subproduct)
                    .HasMaxLength(50)
                    .HasColumnName("SUBPRODUCT");

                entity.Property(e => e.Substatus)
                    .HasMaxLength(200)
                    .HasColumnName("SUBSTATUS");

                entity.Property(e => e.Total).HasColumnName("TOTAL");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("USERNAME");

                entity.Property(e => e.Year).HasColumnName("YEAR");
            });

            modelBuilder.Entity<VwStdhotelDiscountTypes>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_STDHOTEL_DISCOUNT_TYPES");

                entity.Property(e => e.Description)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Typeid).HasColumnName("TYPEID");
            });

            modelBuilder.Entity<VwStdhotelRatecodeDiscountDiscount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_STDHOTEL_RATECODE_DISCOUNT_DISCOUNT");

                entity.Property(e => e.Discountid).HasColumnName("DISCOUNTID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Otherdiscountid).HasColumnName("OTHERDISCOUNTID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
