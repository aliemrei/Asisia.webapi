using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class DBContext : DbContext
    {
        private readonly IHttpContextAccessor _contextAccessor;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<Agency> Agency { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<AgencyGroup> AgencyGroup { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<AuditLogs> AuditLogs { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<BasketData> BasketData { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<BonusDef> BonusDef { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<BonusDefItems> BonusDefItems { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<BonusDefPrices> BonusDefPrices { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<BonusDefUsers> BonusDefUsers { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<Calendar> Calendar { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<CallJobs> CallJobs { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<CallList> CallList { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<Campaigns> Campaigns { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<CashierHandover> CashierHandover { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<CashierHandoverEntity> CashierHandoverEntity { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<City> City { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<ContactCategory> ContactCategory { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<ContactForm> ContactForm { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<Corp> Corp { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<Country> Country { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<CrmCardgroups> CrmCardgroups { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<CrmCardtypes> CrmCardtypes { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<Curcode> Curcode { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<Currate> Currate { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<Dashboard> Dashboard { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<DashboardItem> DashboardItem { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<DashboardItemYdk> DashboardItemYdk { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<DashboardYdk> DashboardYdk { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<DataDictionary> DataDictionary { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<DbLog> DbLog { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<District> District { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<EntegrationSettings> EntegrationSettings { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<HotelReservationDetails> HotelReservationDetails { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<HotelReservations> HotelReservations { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<IntegrationErrors> IntegrationErrors { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<LocationAddress> LocationAddress { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<MailContents> MailContents { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<PaymentEmails> PaymentEmails { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<Payments> Payments { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<Person> Person { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<PersonAddress> PersonAddress { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<PersonBonus> PersonBonus { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<PersonBonusTypes> PersonBonusTypes { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<PersonCcards> PersonCcards { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<PersonGroup> PersonGroup { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<Portal> Portal { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<PortalAuthIpaddress> PortalAuthIpaddress { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<PortalCategories> PortalCategories { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<PortalCategoryImages> PortalCategoryImages { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<PortalCategoryItems> PortalCategoryItems { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<PortalCurrencies> PortalCurrencies { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<PortalDescription> PortalDescription { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<PortalDomains> PortalDomains { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<PortalEmails> PortalEmails { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<PortalLangdictionary> PortalLangdictionary { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<PortalLanguages> PortalLanguages { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<PortalSeo> PortalSeo { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<PortalSettings> PortalSettings { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<PortalUrlrewrite> PortalUrlrewrite { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<PortalUser> PortalUser { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<PortalUserSocialaccount> PortalUserSocialaccount { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<ProjectGroup> ProjectGroup { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<ProjectGroupdetail> ProjectGroupdetail { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<ProjectGroupdetailBankdep> ProjectGroupdetailBankdep { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<ProjectGroupdetailSeo> ProjectGroupdetailSeo { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<ProjectGroupdetailVpos> ProjectGroupdetailVpos { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<PromotionCodes> PromotionCodes { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<PromotionCodesMarket> PromotionCodesMarket { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<PromotionCodesRoomtype> PromotionCodesRoomtype { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<PropertyMapping> PropertyMapping { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<PropertyProviders> PropertyProviders { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<Reports> Reports { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<Request> Request { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<RequestClients> RequestClients { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<RequestDetail> RequestDetail { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<RequestDetailOrgdata> RequestDetailOrgdata { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<RequestNotes> RequestNotes { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<RequestPayments> RequestPayments { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<RequestStatus> RequestStatus { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<RequestYdk> RequestYdk { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<ReservationEmails> ReservationEmails { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<ReservationRules> ReservationRules { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<ReservationSettings> ReservationSettings { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<ReservationSettingsMarket> ReservationSettingsMarket { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<ResourceBudget> ResourceBudget { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<ResourceDetail> ResourceDetail { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<Resources> Resources { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<RoleAuth> RoleAuth { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<Roles> Roles { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<RolesCustomauth> RolesCustomauth { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<RolesDashboards> RolesDashboards { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<SalesReq> SalesReq { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<Sil> Sil { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<SmsMessage> SmsMessage { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<SmsSettings> SmsSettings { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<SmtpMails> SmtpMails { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<SmtpSettings> SmtpSettings { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<SntAgentStatus> SntAgentStatus { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<SntCallDetail> SntCallDetail { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<SntCallJobs> SntCallJobs { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<SntCallList> SntCallList { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<SntCallListOrg> SntCallListOrg { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<SntCallStatus> SntCallStatus { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<SntCallSummary> SntCallSummary { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<SntCallTotals> SntCallTotals { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<SntCallbackIgnores> SntCallbackIgnores { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<SntCalls> SntCalls { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<SntCdr> SntCdr { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<SntCdrReport> SntCdrReport { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<SntDbs> SntDbs { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<SntDiagram> SntDiagram { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<SntDiagramChildkeys> SntDiagramChildkeys { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<SntDiagramShapes> SntDiagramShapes { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<SntDialPlan> SntDialPlan { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<SntLanguageCountries> SntLanguageCountries { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<SntMissedcalls> SntMissedcalls { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<SntMissedcallsAll> SntMissedcallsAll { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<SntQueueAbandon> SntQueueAbandon { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<SntQueueLog> SntQueueLog { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<SntQueueMembers> SntQueueMembers { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<SntQueues> SntQueues { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<SntReport> SntReport { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<SntRtSippeers> SntRtSippeers { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<SntSippeers> SntSippeers { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<SntSwitchboard> SntSwitchboard { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<StdParams> StdParams { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<Stdboardtypes> Stdboardtypes { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<Stdhotel> Stdhotel { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<StdhotelAnnouncement> StdhotelAnnouncement { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<StdhotelBoardtypes> StdhotelBoardtypes { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<StdhotelDescriptions> StdhotelDescriptions { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<StdhotelExtras> StdhotelExtras { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<StdhotelFecilities> StdhotelFecilities { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<StdhotelImages> StdhotelImages { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<StdhotelMarket> StdhotelMarket { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<StdhotelMarketCountry> StdhotelMarketCountry { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<StdhotelPricecondition> StdhotelPricecondition { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<StdhotelPriceconditionCalendar> StdhotelPriceconditionCalendar { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<StdhotelPriceconditionOccupancy> StdhotelPriceconditionOccupancy { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<StdhotelRatecode> StdhotelRatecode { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<StdhotelRatecodeDetail> StdhotelRatecodeDetail { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<StdhotelRatecodeDetailAgencygroups> StdhotelRatecodeDetailAgencygroups { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<StdhotelRatecodeDetailOccupancy> StdhotelRatecodeDetailOccupancy { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<StdhotelRatecodeDiscount> StdhotelRatecodeDiscount { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<StdhotelRatecodeDiscountContract> StdhotelRatecodeDiscountContract { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<StdhotelRatecodeDiscountDiscount> StdhotelRatecodeDiscountDiscount { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<StdhotelRatecodeDiscountMarket> StdhotelRatecodeDiscountMarket { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<StdhotelRatecodeDiscountRatetype> StdhotelRatecodeDiscountRatetype { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<StdhotelRatecodeDiscountRoomtype> StdhotelRatecodeDiscountRoomtype { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<StdhotelRatecodeMarkup> StdhotelRatecodeMarkup { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<StdhotelRatecodeMarkupMarkets> StdhotelRatecodeMarkupMarkets { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<StdhotelRatecodeMarkupRoomtype> StdhotelRatecodeMarkupRoomtype { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<StdhotelRatetype> StdhotelRatetype { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<StdhotelRatetypesAvailability> StdhotelRatetypesAvailability { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<StdhotelRoomtypes> StdhotelRoomtypes { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<StdhotelRoomtypesAvailability> StdhotelRoomtypesAvailability { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<StdhotelSeasons> StdhotelSeasons { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<StdhotelStopsale> StdhotelStopsale { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<Stdhoteldiscount> Stdhoteldiscount { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<Stdlanguages> Stdlanguages { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<StdmarketCountries> StdmarketCountries { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<Stdmarkets> Stdmarkets { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<Stdroomtypes> Stdroomtypes { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<Stdstore> Stdstore { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<StdstoreItemGroupItems> StdstoreItemGroupItems { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<StdstoreItemGroups> StdstoreItemGroups { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<StdstoreItemImages> StdstoreItemImages { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<StdstoreItemIngredients> StdstoreItemIngredients { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<StdstoreItemPrices> StdstoreItemPrices { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<StdstoreItemPricesIngredients> StdstoreItemPricesIngredients { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<StdstoreItemSizes> StdstoreItemSizes { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<StdstoreItems> StdstoreItems { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<StdstoreItemsGroups> StdstoreItemsGroups { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<Stdvehicletypes> Stdvehicletypes { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<Survey> Survey { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<SurveyAnsweroptions> SurveyAnsweroptions { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<SurveyAnswers> SurveyAnswers { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<Surveys> Surveys { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<SwicthboardLog> SwicthboardLog { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<Ticket> Ticket { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<TicketActivations> TicketActivations { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<TicketGifts> TicketGifts { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<TicketHours> TicketHours { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<TicketMarket> TicketMarket { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<TicketPrices> TicketPrices { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<TileItemoption> TileItemoption { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<Tour> Tour { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<TourDiscounts> TourDiscounts { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<TourImages> TourImages { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<TourPrices> TourPrices { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<TourProgram> TourProgram { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<Tourdiscount> Tourdiscount { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<TransferLocations> TransferLocations { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<TransferPrices> TransferPrices { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<TransferProviders> TransferProviders { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<Turnike> Turnike { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<UserHistory> UserHistory { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<UserProjectDetails> UserProjectDetails { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<UserProjects> UserProjects { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<UserRoleRequestStatus> UserRoleRequestStatus { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<UserRoles> UserRoles { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<Users> Users { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<UsersCustomauth> UsersCustomauth { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<Vehicletypes> Vehicletypes { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<VirtualPos> VirtualPos { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<VirtualPosAccountInstalments> VirtualPosAccountInstalments { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<VirtualPosAccounts> VirtualPosAccounts { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<VirtualPosAccountsCurcodes> VirtualPosAccountsCurcodes { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<VirtualPosBinnumbers> VirtualPosBinnumbers { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<VirtualPosDefaults> VirtualPosDefaults { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<VirtualPosDepAccounts> VirtualPosDepAccounts { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<VirtualPosDepPayments> VirtualPosDepPayments { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<VirtualPosDepPaymentsCancel> VirtualPosDepPaymentsCancel { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<VirtualPosPaymentEmails> VirtualPosPaymentEmails { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<VirtualPosPaymentMessageTemps> VirtualPosPaymentMessageTemps { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<VirtualPosPaymentRequests> VirtualPosPaymentRequests { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<VirtualPosPaymentRequestsNotes> VirtualPosPaymentRequestsNotes { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<VirtualPosPaymentTemps> VirtualPosPaymentTemps { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<VirtualPosPaymentVposes> VirtualPosPaymentVposes { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<VirtualPosPayments> VirtualPosPayments { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<VirtualPosPaymentsCancel> VirtualPosPaymentsCancel { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<VirtualPosSwap> VirtualPosSwap { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<VirtualPosbinnames> VirtualPosbinnames { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<VwBasketInfo> VwBasketInfo { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<VwBasketPayments> VwBasketPayments { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<VwCallJobs> VwCallJobs { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<VwCalljobReasons> VwCalljobReasons { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<VwCampaigns> VwCampaigns { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<VwHotelMarketCountry> VwHotelMarketCountry { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<VwIpcountrycodes> VwIpcountrycodes { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<VwIplocations> VwIplocations { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<VwLocations> VwLocations { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<VwMobPaymentReport> VwMobPaymentReport { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<VwProducts> VwProducts { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<VwProjectGroup> VwProjectGroup { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<VwPromotionCodes> VwPromotionCodes { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<VwRequestPaymentCancels> VwRequestPaymentCancels { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<VwRequestPayments> VwRequestPayments { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<VwSales> VwSales { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<VwSalesAll> VwSalesAll { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<VwSalesReport> VwSalesReport { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<VwSalesReportAll> VwSalesReportAll { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<VwSalesReportWithResourcepath> VwSalesReportWithResourcepath { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<VwStdhotelDiscountTypes> VwStdhotelDiscountTypes { get; set; } = null!;
        //System.Collections.Generic.Dictionary`2[System.String,System.Object]
        public virtual DbSet<VwStdhotelRatecodeDiscountDiscount> VwStdhotelRatecodeDiscountDiscount { get; set; } = null!;

        public DBContext()  
        {
        }

        public DBContext(DbContextOptions<DBContext> options,
            IHttpContextAccessor contextAccessor) : base(options)
        {
            _contextAccessor = contextAccessor;
            if (Guid.TryParse(contextAccessor.HttpContext.User.Claims.FirstOrDefault(x => x.Type == "corpId")?.Value, out var corpId))
            {
                _tenant = corpId;  
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var builder = WebApplication.CreateBuilder();

                optionsBuilder.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
                optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agency>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__AGENCY__3214EC26C02849A1")
                    .IsClustered(false);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DefaultCurcode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Intid).ValueGeneratedOnAdd();

                entity.Property(e => e.PaymentRate).HasDefaultValueSql("((100))");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

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
                entity.ToView("AuditLogs");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Type)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<BasketData>(entity =>
            {
                entity.HasOne(d => d.Request)
                    .WithMany(p => p.BasketData)
                    .HasForeignKey(d => d.Requestid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__BASKET_DA__REQUE__0F231F2D");
            });

            modelBuilder.Entity<BonusDef>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Curcode)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('TRY')")
                    .IsFixedLength();

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BonusDefUsers)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("FK__BONUS_DEF__USERI__2BF46805");
            });

            modelBuilder.Entity<Calendar>(entity =>
            {
                entity.HasKey(e => e.Date)
                    .HasName("PK__CALENDAR__1F7C70C4BA479CA1");
            });

            modelBuilder.Entity<CallJobs>(entity =>
            {
                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Campaigncode).IsFixedLength();

                entity.Property(e => e.Kind)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('J')")
                    .IsFixedLength();

                entity.Property(e => e.Priority).HasDefaultValueSql("((5))");

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
                entity.ToView("CALL_LIST");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Kind)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Campaigns>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Forallprojects).HasComputedColumnSql("(case when [PROJECT_DETAILID] IS NULL then (1) else (0) end)", false);

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Curcode)
                    .IsUnicode(false)
                    .IsFixedLength();

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
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

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
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Intid).ValueGeneratedOnAdd();

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
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Isocode2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CrmCardgroups>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__CRM_CARD__3214EC264ECA644E")
                    .IsClustered(false);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CardnumberMargin).HasDefaultValueSql("(N'40px 25px 10px')");

                entity.Property(e => e.ShowStripbottom).HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowStriptop).HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowcardBrand).HasDefaultValueSql("((1))");

                entity.Property(e => e.Showcardholdername).HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowchipIcon).HasDefaultValueSql("((1))");

                entity.Property(e => e.Showexpire).HasDefaultValueSql("((1))");

                entity.Property(e => e.Shownumbers).HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowwifiIcon).HasDefaultValueSql("((1))");

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
                entity.Property(e => e.Code)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Currate>(entity =>
            {
                entity.Property(e => e.Curcode)
                    .IsUnicode(false)
                    .IsFixedLength();

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

                entity.HasIndex(e => e.Sortorder, "IX_DASHBOARD")
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Columnwidths).HasDefaultValueSql("(N'1, 0.5, 0.5')");

                entity.Property(e => e.Maxcolumn).HasDefaultValueSql("((2))");
            });

            modelBuilder.Entity<DashboardItem>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Widgetname).HasDefaultValueSql("(N'widget')");

                entity.HasOne(d => d.Dashboard)
                    .WithMany(p => p.DashboardItem)
                    .HasForeignKey(d => d.Dashboardid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DASHBOARD__DASHB__24485945");
            });

            modelBuilder.Entity<DataDictionary>(entity =>
            {
                entity.Property(e => e.Langcode)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<DbLog>(entity =>
            {
                entity.ToView("DB_LOG");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.District)
                    .HasForeignKey(d => d.Cityid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DISTRICT__CITYID__60C757A0");
            });

            modelBuilder.Entity<HotelReservationDetails>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Dayofweek)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tempid).ValueGeneratedOnAdd();

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Resid).ValueGeneratedOnAdd();

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

            modelBuilder.Entity<LocationAddress>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

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
                entity.ToView("MAIL_CONTENTS");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PaymentEmails>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Curcode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TlAmount).HasComputedColumnSql("([dbo].[FN_CURRATE]([CORPID],[ADDDATE],[CURCODE],'TRY',[DEBT]+[CREDIT]))", false);

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
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Fullname).HasComputedColumnSql("((isnull([FIRSTNAME]+' ','')+isnull([SECONDNAME]+' ',''))+isnull([LASTNAME],''))", false);

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
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

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
                entity.Property(e => e.Uid).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonCcards)
                    .HasForeignKey(d => d.Personid)
                    .HasConstraintName("FK__PERSON_CC__PERSO__0F4D3C5F");
            });

            modelBuilder.Entity<PersonGroup>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

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
                entity.Property(e => e.AccountAutoCreateuserOnforgetpassform).HasDefaultValueSql("((1))");

                entity.Property(e => e.AccountLoginByPhone).HasDefaultValueSql("((1))");

                entity.Property(e => e.AccountLoginByVoucherno).HasDefaultValueSql("((1))");

                entity.Property(e => e.DefaultCurcode)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('TRY')")
                    .IsFixedLength();

                entity.Property(e => e.DefaultLang).HasDefaultValueSql("('tr-TR')");

                entity.Property(e => e.MultipleCurcodes).HasDefaultValueSql("((1))");

                entity.Property(e => e.Uid).HasDefaultValueSql("(newid())");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ismanager).HasDefaultValueSql("((1))");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Intid).ValueGeneratedOnAdd();

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Curcode)
                    .IsUnicode(false)
                    .IsFixedLength();

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
                entity.Property(e => e.Curcode)
                    .IsUnicode(false)
                    .IsFixedLength();

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Portalu)
                    .WithMany(p => p.PortalEmails)
                    .HasPrincipalKey(p => p.Uid)
                    .HasForeignKey(d => d.Portaluid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PORTAL_EM__PORTA__45F4312A");
            });

            modelBuilder.Entity<PortalLangdictionary>(entity =>
            {
                entity.ToView("PORTAL_LANGDICTIONARY");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Keyvalue).UseCollation("Turkish_CS_AS");
            });

            modelBuilder.Entity<PortalLanguages>(entity =>
            {
                entity.Property(e => e.Langcode).IsFixedLength();

                entity.HasOne(d => d.Portalu)
                    .WithMany(p => p.PortalLanguages)
                    .HasPrincipalKey(p => p.Uid)
                    .HasForeignKey(d => d.Portaluid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PORTAL_LANGUAGES_PORTAL");
            });

            modelBuilder.Entity<PortalSeo>(entity =>
            {
                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Lang)
                    .IsUnicode(false)
                    .IsFixedLength();

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Portal)
                    .WithMany(p => p.PortalSettings)
                    .HasPrincipalKey(p => p.Uid)
                    .HasForeignKey(d => d.Portalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PORTAL_SE__PORTA__58920452");
            });

            modelBuilder.Entity<PortalUrlrewrite>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<PortalUser>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Changekey).UseCollation("SQL_Latin1_General_CP1254_CI_AS");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PortalUser)
                    .HasForeignKey(d => d.Personid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__PORTAL_US__PERSO__0FC23DAB");
            });

            modelBuilder.Entity<PortalUserSocialaccount>(entity =>
            {
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

                entity.HasIndex(e => e.Name, "IX_PROJECT_GROUP_1")
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DontstoreCcards).HasDefaultValueSql("((0))");

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
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Intid).ValueGeneratedOnAdd();

                entity.Property(e => e.Productid).HasComputedColumnSql("(coalesce([HOTELID],[TOURID],[TICKETID]))", false);

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.UseInPortal).HasDefaultValueSql("((1))");

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
                entity.Property(e => e.Lang)
                    .IsUnicode(false)
                    .IsFixedLength();

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Curcode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Usecount).HasDefaultValueSql("((1))");

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
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Request>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Creationdate).HasComputedColumnSql("(CONVERT([date],[ADDDATE]))", true);

                entity.Property(e => e.Creationtime).HasComputedColumnSql("(CONVERT([time],[ADDDATE]))", true);

                entity.Property(e => e.Curcode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InvoiceKind).HasDefaultValueSql("((1))");

                entity.Property(e => e.Langcode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sellingdate).HasComputedColumnSql("(CONVERT([date],[SELL_DATE]))", true);

                entity.Property(e => e.Sellingtime).HasComputedColumnSql("(CONVERT([time],[SELL_DATE]))", true);

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
                entity.HasOne(d => d.RequestDetail)
                    .WithMany(p => p.RequestClients)
                    .HasForeignKey(d => d.RequestDetailid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__REQUEST_C__REQUE__18E19391");
            });

            modelBuilder.Entity<RequestDetail>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Creationdate).HasComputedColumnSql("(CONVERT([date],[ADDDATE]))", true);

                entity.Property(e => e.Creationtime).HasComputedColumnSql("(CONVERT([time],[ADDDATE]))", true);

                entity.Property(e => e.Curcode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DiscountReq).HasDefaultValueSql("((0))");

                entity.Property(e => e.DiscountTotal).HasComputedColumnSql("(case when [DISCOUNT_RESULT]=(1) AND [DISCOUNT_RATE]>(0) then case [DISCOUNT_REQ] when (1) then CONVERT([float],isnull([TOTAL],(0))+isnull([EXTRA_TOTAL],(0)))*(CONVERT([float],[DISCOUNT_RATE])/(100.0)) when (2) then [DISCOUNT_RATE] when (3) then (isnull([TOTAL],(0))+isnull([EXTRA_TOTAL],(0)))-[DISCOUNT_RATE] else (0) end else (0) end)", true);

                entity.Property(e => e.Editdate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GrandTotal).HasComputedColumnSql("((isnull([TOTAL],(0))+isnull([EXTRA_TOTAL],(0)))-case when [DISCOUNT_RESULT]=(1) AND [DISCOUNT_RATE]>(0) then case [DISCOUNT_REQ] when (1) then CONVERT([float],isnull([TOTAL],(0))+isnull([EXTRA_TOTAL],(0)))*(CONVERT([float],[DISCOUNT_RATE])/(100.0)) when (2) then [DISCOUNT_RATE] when (3) then (isnull([TOTAL],(0))+isnull([EXTRA_TOTAL],(0)))-[DISCOUNT_RATE] else (0) end else (0) end)", true);

                entity.Property(e => e.Intid).ValueGeneratedOnAdd();

                entity.Property(e => e.Isnotavailable).HasDefaultValueSql("((0))");

                entity.Property(e => e.Productid).HasComputedColumnSql("(coalesce([HOTELID],[TOURID],[TICKETID],[TICKETGIFTID],[TRANSFER_PRICEID]))", false);

                entity.Property(e => e.Roundtrip).HasDefaultValueSql("((1))");

                entity.Property(e => e.Sellingdate).HasComputedColumnSql("(CONVERT([date],[SELL_DATE]))", true);

                entity.Property(e => e.Sellingtime).HasComputedColumnSql("(CONVERT([time],[SELL_DATE]))", true);

                entity.Property(e => e.Total).HasDefaultValueSql("((0))");

                entity.Property(e => e.UseInoffer).HasDefaultValueSql("((1))");

                entity.Property(e => e.Validdate).HasComputedColumnSql("(dateadd(day,[VALIDDAY],[ADDDATE]))", true);

                entity.Property(e => e.Validday).HasDefaultValueSql("((3))");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.RequestDetail)
                    .WithMany(p => p.RequestDetailOrgdata)
                    .HasForeignKey(d => d.RequestDetailid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REQUEST_D__REQUE__26667738");
            });

            modelBuilder.Entity<RequestNotes>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

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
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Substatus).HasComment("0=Active,1=Pasive");
            });

            modelBuilder.Entity<RequestYdk>(entity =>
            {
                entity.Property(e => e.Curcode)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ReservationEmails>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CancellationWarrantyRateMaxDay).HasDefaultValueSql("((0))");

                entity.Property(e => e.PaymentRateMaxDay).HasDefaultValueSql("((0))");

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
                entity.Property(e => e.Amount).HasDefaultValueSql("((0))");

                entity.Property(e => e.Curcode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.IncomeAmount).HasDefaultValueSql("((0))");

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
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

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
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Resourcespath).HasComputedColumnSql("([DBO].[FN_RESOURCE_PATH]([CODE],[CORPID]))", false);

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
                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleAuth)
                    .HasForeignKey(d => d.Roleid)
                    .HasConstraintName("FK__ROLE_AUTH__ROLEI__40F9A68C");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<RolesDashboards>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

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
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

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
                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.DialCode).IsUnicode(false);

                entity.Property(e => e.Isocode2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<SmsMessage>(entity =>
            {
                entity.Property(e => e.Type).HasDefaultValueSql("((1))");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

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
                entity.Property(e => e.Uid).HasDefaultValueSql("(newid())");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Portno).HasDefaultValueSql("((25))");

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
                entity.ToView("SNT_AGENT_STATUS");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SntCallDetail>(entity =>
            {
                entity.ToView("SNT_CALL_DETAIL");

                entity.Property(e => e.Channel).IsUnicode(false);

                entity.Property(e => e.Clid).IsUnicode(false);

                entity.Property(e => e.Dcontext).IsUnicode(false);

                entity.Property(e => e.Disposition).IsUnicode(false);

                entity.Property(e => e.Dst).IsUnicode(false);

                entity.Property(e => e.Lastapp).IsUnicode(false);

                entity.Property(e => e.Lastdata).IsUnicode(false);

                entity.Property(e => e.Src).IsUnicode(false);

                entity.Property(e => e.Uniqueid).IsUnicode(false);

                entity.Property(e => e.Userfield).IsUnicode(false);
            });

            modelBuilder.Entity<SntCallJobs>(entity =>
            {
                entity.ToView("SNT_CALL_JOBS");

                entity.Property(e => e.Campaigncode).IsFixedLength();

                entity.Property(e => e.Kind)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Queuename).IsUnicode(false);

                entity.Property(e => e.Reason).IsUnicode(false);
            });

            modelBuilder.Entity<SntCallList>(entity =>
            {
                entity.ToView("SNT_CALL_LIST");

                entity.Property(e => e.Queuename).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<SntCallListOrg>(entity =>
            {
                entity.ToView("SNT_CALL_LIST_ORG");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Kind)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SntCallStatus>(entity =>
            {
                entity.ToView("SNT_CALL_STATUS");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SntCallSummary>(entity =>
            {
                entity.ToView("SNT_CALL_SUMMARY");
            });

            modelBuilder.Entity<SntCallTotals>(entity =>
            {
                entity.ToView("SNT_CALL_TOTALS");

                entity.Property(e => e.Cdayname).IsUnicode(false);

                entity.Property(e => e.Cmonthname).IsUnicode(false);
            });

            modelBuilder.Entity<SntCallbackIgnores>(entity =>
            {
                entity.ToView("SNT_CALLBACK_IGNORES");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SntCalls>(entity =>
            {
                entity.ToView("SNT_CALLS");

                entity.Property(e => e.Accountcode).IsUnicode(false);

                entity.Property(e => e.Agent).IsUnicode(false);

                entity.Property(e => e.Amaflags).IsUnicode(false);

                entity.Property(e => e.Channel).IsUnicode(false);

                entity.Property(e => e.Chn).IsUnicode(false);

                entity.Property(e => e.Clid).IsUnicode(false);

                entity.Property(e => e.Dcontext).IsUnicode(false);

                entity.Property(e => e.Disposition).IsUnicode(false);

                entity.Property(e => e.Dst).IsUnicode(false);

                entity.Property(e => e.Dstchannel).IsUnicode(false);

                entity.Property(e => e.Lastapp).IsUnicode(false);

                entity.Property(e => e.Lastdata).IsUnicode(false);

                entity.Property(e => e.Phn).IsUnicode(false);

                entity.Property(e => e.Src).IsUnicode(false);

                entity.Property(e => e.Uniqueid).IsUnicode(false);

                entity.Property(e => e.Userfield).IsUnicode(false);
            });

            modelBuilder.Entity<SntCdr>(entity =>
            {
                entity.ToView("SNT_CDR");

                entity.Property(e => e.Accountcode).IsUnicode(false);

                entity.Property(e => e.Amaflags).IsUnicode(false);

                entity.Property(e => e.Channel).IsUnicode(false);

                entity.Property(e => e.Clid).IsUnicode(false);

                entity.Property(e => e.Dcontext).IsUnicode(false);

                entity.Property(e => e.Disposition).IsUnicode(false);

                entity.Property(e => e.Dst).IsUnicode(false);

                entity.Property(e => e.Dstchannel).IsUnicode(false);

                entity.Property(e => e.Exten).IsUnicode(false);

                entity.Property(e => e.Lastapp).IsUnicode(false);

                entity.Property(e => e.Lastdata).IsUnicode(false);

                entity.Property(e => e.Peername).IsUnicode(false);

                entity.Property(e => e.Src).IsUnicode(false);

                entity.Property(e => e.Uniqueid).IsUnicode(false);

                entity.Property(e => e.Userfield).IsUnicode(false);
            });

            modelBuilder.Entity<SntCdrReport>(entity =>
            {
                entity.ToView("SNT_CDR_REPORT");

                entity.Property(e => e.Cdayname).IsUnicode(false);

                entity.Property(e => e.Cmonthname).IsUnicode(false);

                entity.Property(e => e.Disposition).IsUnicode(false);

                entity.Property(e => e.Exten).IsUnicode(false);

                entity.Property(e => e.Peername).IsUnicode(false);

                entity.Property(e => e.Src).IsUnicode(false);

                entity.Property(e => e.Uniqueid).IsUnicode(false);

                entity.Property(e => e.Userfield).IsUnicode(false);
            });

            modelBuilder.Entity<SntDbs>(entity =>
            {
                entity.ToView("SNT_DBS");
            });

            modelBuilder.Entity<SntDiagram>(entity =>
            {
                entity.ToView("SNT_DIAGRAM");
            });

            modelBuilder.Entity<SntDiagramChildkeys>(entity =>
            {
                entity.ToView("SNT_DIAGRAM_CHILDKEYS");

                entity.Property(e => e.Key).IsUnicode(false);
            });

            modelBuilder.Entity<SntDiagramShapes>(entity =>
            {
                entity.ToView("SNT_DIAGRAM_SHAPES");

                entity.Property(e => e.Key).IsUnicode(false);
            });

            modelBuilder.Entity<SntDialPlan>(entity =>
            {
                entity.ToView("SNT_DIAL_PLAN");
            });

            modelBuilder.Entity<SntLanguageCountries>(entity =>
            {
                entity.ToView("SNT_LANGUAGE_COUNTRIES");

                entity.Property(e => e.Countrycode)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SntMissedcalls>(entity =>
            {
                entity.ToView("SNT_MISSEDCALLS");

                entity.Property(e => e.Agent).IsUnicode(false);

                entity.Property(e => e.Kind)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Queuename).IsUnicode(false);
            });

            modelBuilder.Entity<SntMissedcallsAll>(entity =>
            {
                entity.ToView("SNT_MISSEDCALLS_ALL");

                entity.Property(e => e.Agent).IsUnicode(false);

                entity.Property(e => e.Kind)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Queuename).IsUnicode(false);

                entity.Property(e => e.Userfield).IsUnicode(false);
            });

            modelBuilder.Entity<SntQueueAbandon>(entity =>
            {
                entity.ToView("SNT_QUEUE_ABANDON");
            });

            modelBuilder.Entity<SntQueueLog>(entity =>
            {
                entity.ToView("SNT_QUEUE_LOG");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SntQueueMembers>(entity =>
            {
                entity.ToView("SNT_QUEUE_MEMBERS");

                entity.Property(e => e.Interface).IsUnicode(false);

                entity.Property(e => e.Membername).IsUnicode(false);

                entity.Property(e => e.QueueName).IsUnicode(false);

                entity.Property(e => e.Uniqueid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SntQueues>(entity =>
            {
                entity.ToView("SNT_QUEUES");

                entity.Property(e => e.Announce).IsUnicode(false);

                entity.Property(e => e.AnnounceHoldtime).IsUnicode(false);

                entity.Property(e => e.Context).IsUnicode(false);

                entity.Property(e => e.Joinempty).IsUnicode(false);

                entity.Property(e => e.Leavewhenempty).IsUnicode(false);

                entity.Property(e => e.MonitorFormat).IsUnicode(false);

                entity.Property(e => e.Musiconhold).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.PeriodicAnnounce).IsUnicode(false);

                entity.Property(e => e.QueueCallswaiting).IsUnicode(false);

                entity.Property(e => e.QueueHoldtime).IsUnicode(false);

                entity.Property(e => e.QueueLessthan).IsUnicode(false);

                entity.Property(e => e.QueueMinutes).IsUnicode(false);

                entity.Property(e => e.QueueReporthold).IsUnicode(false);

                entity.Property(e => e.QueueSeconds).IsUnicode(false);

                entity.Property(e => e.QueueThankyou).IsUnicode(false);

                entity.Property(e => e.QueueThereare).IsUnicode(false);

                entity.Property(e => e.QueueYouarenext).IsUnicode(false);

                entity.Property(e => e.Strategy).IsUnicode(false);
            });

            modelBuilder.Entity<SntReport>(entity =>
            {
                entity.ToView("SNT_REPORT");

                entity.Property(e => e.Accountcode).IsUnicode(false);

                entity.Property(e => e.Agent).IsUnicode(false);

                entity.Property(e => e.Amaflags).IsUnicode(false);

                entity.Property(e => e.Cdayname).IsUnicode(false);

                entity.Property(e => e.Channel).IsUnicode(false);

                entity.Property(e => e.Clid).IsUnicode(false);

                entity.Property(e => e.Cmonthname).IsUnicode(false);

                entity.Property(e => e.Dcontext).IsUnicode(false);

                entity.Property(e => e.Disposition).IsUnicode(false);

                entity.Property(e => e.Dst).IsUnicode(false);

                entity.Property(e => e.Dstchannel).IsUnicode(false);

                entity.Property(e => e.Exten).IsUnicode(false);

                entity.Property(e => e.Fromuser).IsUnicode(false);

                entity.Property(e => e.Hat).IsUnicode(false);

                entity.Property(e => e.Lastapp).IsUnicode(false);

                entity.Property(e => e.Lastdata).IsUnicode(false);

                entity.Property(e => e.Peername).IsUnicode(false);

                entity.Property(e => e.Src).IsUnicode(false);

                entity.Property(e => e.Uniqueid).IsUnicode(false);

                entity.Property(e => e.Userfield).IsUnicode(false);
            });

            modelBuilder.Entity<SntRtSippeers>(entity =>
            {
                entity.ToView("SNT_RT_SIPPEERS");

                entity.Property(e => e.Accountcode).IsUnicode(false);

                entity.Property(e => e.Allow).IsUnicode(false);

                entity.Property(e => e.Allowoverlap).IsUnicode(false);

                entity.Property(e => e.Allowsubscribe).IsUnicode(false);

                entity.Property(e => e.Allowtransfer).IsUnicode(false);

                entity.Property(e => e.Amaflags).IsUnicode(false);

                entity.Property(e => e.Auth).IsUnicode(false);

                entity.Property(e => e.Autoframing).IsUnicode(false);

                entity.Property(e => e.Buggymwi).IsUnicode(false);

                entity.Property(e => e.Callbackextension).IsUnicode(false);

                entity.Property(e => e.Callcounter).IsUnicode(false);

                entity.Property(e => e.Callerid).IsUnicode(false);

                entity.Property(e => e.Callgroup).IsUnicode(false);

                entity.Property(e => e.Callingpres).IsUnicode(false);

                entity.Property(e => e.CidNumber).IsUnicode(false);

                entity.Property(e => e.Constantssrc).IsUnicode(false);

                entity.Property(e => e.Contactdeny).IsUnicode(false);

                entity.Property(e => e.Contactpermit).IsUnicode(false);

                entity.Property(e => e.Context).IsUnicode(false);

                entity.Property(e => e.Defaultip).IsUnicode(false);

                entity.Property(e => e.Defaultuser).IsUnicode(false);

                entity.Property(e => e.Deny).IsUnicode(false);

                entity.Property(e => e.Directmedia).IsUnicode(false);

                entity.Property(e => e.Disallow).IsUnicode(false);

                entity.Property(e => e.Dtmfmode).IsUnicode(false);

                entity.Property(e => e.Dynamic).IsUnicode(false);

                entity.Property(e => e.Faxdetect).IsUnicode(false);

                entity.Property(e => e.Fromdomain).IsUnicode(false);

                entity.Property(e => e.Fromuser).IsUnicode(false);

                entity.Property(e => e.Fullcontact).IsUnicode(false);

                entity.Property(e => e.Fullname).IsUnicode(false);

                entity.Property(e => e.G726nonstandard).IsUnicode(false);

                entity.Property(e => e.Hasvoicemail).IsUnicode(false);

                entity.Property(e => e.Host).IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Ignoresdpversion).IsUnicode(false);

                entity.Property(e => e.Insecure).IsUnicode(false);

                entity.Property(e => e.Ipaddr).IsUnicode(false);

                entity.Property(e => e.Language).IsUnicode(false);

                entity.Property(e => e.Mailbox).IsUnicode(false);

                entity.Property(e => e.Md5secret).IsUnicode(false);

                entity.Property(e => e.Mohinterpret).IsUnicode(false);

                entity.Property(e => e.Mohsuggest).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Nat).IsUnicode(false);

                entity.Property(e => e.Outboundproxy).IsUnicode(false);

                entity.Property(e => e.Parkinglot).IsUnicode(false);

                entity.Property(e => e.Permit).IsUnicode(false);

                entity.Property(e => e.Pickupgroup).IsUnicode(false);

                entity.Property(e => e.Progressinband).IsUnicode(false);

                entity.Property(e => e.Promiscredir).IsUnicode(false);

                entity.Property(e => e.Qualify).IsUnicode(false);

                entity.Property(e => e.Regexten).IsUnicode(false);

                entity.Property(e => e.Regserver).IsUnicode(false);

                entity.Property(e => e.Remotesecret).IsUnicode(false);

                entity.Property(e => e.Rfc2833compensate).IsUnicode(false);

                entity.Property(e => e.Secret).IsUnicode(false);

                entity.Property(e => e.Sendrpid).IsUnicode(false);

                entity.Property(e => e.SessionRefresher).IsUnicode(false);

                entity.Property(e => e.SessionTimers).IsUnicode(false);

                entity.Property(e => e.Setvar).IsUnicode(false);

                entity.Property(e => e.Subscribemwi).IsUnicode(false);

                entity.Property(e => e.T38ptUsertpsource).IsUnicode(false);

                entity.Property(e => e.Textsupport).IsUnicode(false);

                entity.Property(e => e.Transport).IsUnicode(false);

                entity.Property(e => e.Trunkname).IsUnicode(false);

                entity.Property(e => e.Trustrpid).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);

                entity.Property(e => e.Useclientcode).IsUnicode(false);

                entity.Property(e => e.Useragent).IsUnicode(false);

                entity.Property(e => e.Usereqphone).IsUnicode(false);

                entity.Property(e => e.Videosupport).IsUnicode(false);

                entity.Property(e => e.Vmexten).IsUnicode(false);
            });

            modelBuilder.Entity<SntSippeers>(entity =>
            {
                entity.ToView("SNT_SIPPEERS");

                entity.Property(e => e.Accountcode).IsUnicode(false);

                entity.Property(e => e.Allow).IsUnicode(false);

                entity.Property(e => e.Allowoverlap).IsUnicode(false);

                entity.Property(e => e.Allowsubscribe).IsUnicode(false);

                entity.Property(e => e.Allowtransfer).IsUnicode(false);

                entity.Property(e => e.Amaflags).IsUnicode(false);

                entity.Property(e => e.Auth).IsUnicode(false);

                entity.Property(e => e.Autoframing).IsUnicode(false);

                entity.Property(e => e.Buggymwi).IsUnicode(false);

                entity.Property(e => e.Callbackextension).IsUnicode(false);

                entity.Property(e => e.Callcounter).IsUnicode(false);

                entity.Property(e => e.Callerid).IsUnicode(false);

                entity.Property(e => e.Callgroup).IsUnicode(false);

                entity.Property(e => e.Callingpres).IsUnicode(false);

                entity.Property(e => e.CidNumber).IsUnicode(false);

                entity.Property(e => e.Constantssrc).IsUnicode(false);

                entity.Property(e => e.Contactdeny).IsUnicode(false);

                entity.Property(e => e.Contactpermit).IsUnicode(false);

                entity.Property(e => e.Context).IsUnicode(false);

                entity.Property(e => e.Defaultip).IsUnicode(false);

                entity.Property(e => e.Defaultuser).IsUnicode(false);

                entity.Property(e => e.Deny).IsUnicode(false);

                entity.Property(e => e.Directmedia).IsUnicode(false);

                entity.Property(e => e.Disallow).IsUnicode(false);

                entity.Property(e => e.Dtmfmode).IsUnicode(false);

                entity.Property(e => e.Dynamic).IsUnicode(false);

                entity.Property(e => e.Faxdetect).IsUnicode(false);

                entity.Property(e => e.Fromdomain).IsUnicode(false);

                entity.Property(e => e.Fromuser).IsUnicode(false);

                entity.Property(e => e.Fullcontact).IsUnicode(false);

                entity.Property(e => e.Fullname).IsUnicode(false);

                entity.Property(e => e.G726nonstandard).IsUnicode(false);

                entity.Property(e => e.Hasvoicemail).IsUnicode(false);

                entity.Property(e => e.Host).IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Ignoresdpversion).IsUnicode(false);

                entity.Property(e => e.Insecure).IsUnicode(false);

                entity.Property(e => e.Ipaddr).IsUnicode(false);

                entity.Property(e => e.Language).IsUnicode(false);

                entity.Property(e => e.Mailbox).IsUnicode(false);

                entity.Property(e => e.Md5secret).IsUnicode(false);

                entity.Property(e => e.Mohinterpret).IsUnicode(false);

                entity.Property(e => e.Mohsuggest).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Nat).IsUnicode(false);

                entity.Property(e => e.Outboundproxy).IsUnicode(false);

                entity.Property(e => e.Parkinglot).IsUnicode(false);

                entity.Property(e => e.Permit).IsUnicode(false);

                entity.Property(e => e.Pickupgroup).IsUnicode(false);

                entity.Property(e => e.Progressinband).IsUnicode(false);

                entity.Property(e => e.Promiscredir).IsUnicode(false);

                entity.Property(e => e.Qualify).IsUnicode(false);

                entity.Property(e => e.Regexten).IsUnicode(false);

                entity.Property(e => e.Regserver).IsUnicode(false);

                entity.Property(e => e.Remotesecret).IsUnicode(false);

                entity.Property(e => e.Rfc2833compensate).IsUnicode(false);

                entity.Property(e => e.Secret).IsUnicode(false);

                entity.Property(e => e.Sendrpid).IsUnicode(false);

                entity.Property(e => e.SessionRefresher).IsUnicode(false);

                entity.Property(e => e.SessionTimers).IsUnicode(false);

                entity.Property(e => e.Setvar).IsUnicode(false);

                entity.Property(e => e.Subscribemwi).IsUnicode(false);

                entity.Property(e => e.T38ptUsertpsource).IsUnicode(false);

                entity.Property(e => e.Textsupport).IsUnicode(false);

                entity.Property(e => e.Transport).IsUnicode(false);

                entity.Property(e => e.Trunkname).IsUnicode(false);

                entity.Property(e => e.Trustrpid).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);

                entity.Property(e => e.Useclientcode).IsUnicode(false);

                entity.Property(e => e.Useragent).IsUnicode(false);

                entity.Property(e => e.Usereqphone).IsUnicode(false);

                entity.Property(e => e.Videosupport).IsUnicode(false);

                entity.Property(e => e.Vmexten).IsUnicode(false);
            });

            modelBuilder.Entity<SntSwitchboard>(entity =>
            {
                entity.ToView("SNT_SWITCHBOARD");
            });

            modelBuilder.Entity<StdParams>(entity =>
            {
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
            });

            modelBuilder.Entity<Stdhotel>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Thumbnailmaxwidth).HasDefaultValueSql("((110))");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

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
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

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
                entity.Property(e => e.Uid).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Hotel)
                    .WithMany(p => p.StdhotelDescriptions)
                    .HasForeignKey(d => d.Hotelid)
                    .HasConstraintName("FK__STDHOTEL___HOTEL__18178C8A");
            });

            modelBuilder.Entity<StdhotelExtras>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Curcode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Price).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Hotel)
                    .WithMany(p => p.StdhotelExtras)
                    .HasForeignKey(d => d.Hotelid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___HOTEL__3BFFE745");
            });

            modelBuilder.Entity<StdhotelFecilities>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

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
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Showinofferform).HasDefaultValueSql("((1))");

                entity.Property(e => e.Uid).HasDefaultValueSql("(newid())");

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
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

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
                entity.Property(e => e.Countrycode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

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
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AdultRate).HasDefaultValueSql("((1))");

                entity.Property(e => e.BabyRate1).HasDefaultValueSql("((1))");

                entity.Property(e => e.ChildRate).HasDefaultValueSql("((1))");

                entity.Property(e => e.Curcode)
                    .IsUnicode(false)
                    .IsFixedLength();

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
                entity.Property(e => e.Releasedate).HasComputedColumnSql("(case when [RELEASE_DAY]>(0) then dateadd(day, -[RELEASE_DAY],[DATE])  end)", true);

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

                entity.HasIndex(e => new { e.Priceconditionid, e.Adult, e.Chde, e.Chdy, e.Baby, e.Totalchd }, "UQ__STDHOTEL__506C296922C62C78")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Pricecondition)
                    .WithMany(p => p.StdhotelPriceconditionOccupancy)
                    .HasForeignKey(d => d.Priceconditionid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___PRICE__135DC465");
            });

            modelBuilder.Entity<StdhotelRatecode>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Curcode)
                    .IsUnicode(false)
                    .IsFixedLength();

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
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Checkindays)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Checkoutdays)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Pricesort).HasComputedColumnSql("(((((isnull((20)*datediff(day,[SELLFROM],[SELLTO]),(365))+isnull((10)*datediff(day,[STAYFROM],[STAYTO]),(365)))+isnull((1)*len(ltrim(rtrim([CHECKINDAYS]))),(7)))+isnull((2)*len(ltrim(rtrim([CHECKOUTDAYS]))),(7)))+isnull((3)*len(ltrim(rtrim([STAYINGDAYS]))),(7)))+isnull((4)*[MAXLOS]-[MINLOS],(0)))", true);

                entity.Property(e => e.Stayingdays)
                    .IsUnicode(false)
                    .IsFixedLength();

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

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
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

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
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AdditionalEffect).HasDefaultValueSql("((2))");

                entity.Property(e => e.Applyzone).HasDefaultValueSql("((2))");

                entity.Property(e => e.Checkindays)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Checkoutdays)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Stayingdays)
                    .IsUnicode(false)
                    .IsFixedLength();

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
                entity.HasOne(d => d.Contract)
                    .WithMany(p => p.StdhotelRatecodeDiscountContract)
                    .HasForeignKey(d => d.Contractid)
                    .HasConstraintName("FK__STDHOTEL___CONTR__5C77A3CF");

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.StdhotelRatecodeDiscountContract)
                    .HasForeignKey(d => d.Discountid)
                    .HasConstraintName("FK__STDHOTEL___DISCO__5B837F96");
            });

            modelBuilder.Entity<StdhotelRatecodeDiscountMarket>(entity =>
            {
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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Applyzone).HasDefaultValueSql("((2))");

                entity.Property(e => e.Curcode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Stayingdays)
                    .IsUnicode(false)
                    .IsFixedLength();

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
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Hotel)
                    .WithMany(p => p.StdhotelRatetype)
                    .HasForeignKey(d => d.Hotelid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___HOTEL__386F4D83");
            });

            modelBuilder.Entity<StdhotelRatetypesAvailability>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

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
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AdultRate).HasDefaultValueSql("((1))");

                entity.Property(e => e.BabyRate).HasDefaultValueSql("((1))");

                entity.Property(e => e.ChildRate).HasDefaultValueSql("((1))");

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
                entity.Property(e => e.Releasedate).HasComputedColumnSql("(dateadd(day, -[RELEASEDAYS],[DATE]))", true);

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
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Hotel)
                    .WithMany()
                    .HasForeignKey(d => d.Hotelid)
                    .HasConstraintName("FK__STDHOTEL___HOTEL__19FFD4FC");
            });

            modelBuilder.Entity<StdhotelStopsale>(entity =>
            {
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

            modelBuilder.Entity<Stdlanguages>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK__STDLANGU__AA1D4378C43472E9");

                entity.Property(e => e.Code)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<StdmarketCountries>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__STDMARKE__3214EC2683C5DABB")
                    .IsClustered(false);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Curcode).IsFixedLength();

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
            });

            modelBuilder.Entity<Stdstore>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__STDSTORE__3214EC26DBCE8B6A")
                    .IsClustered(false);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Typename)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(case [TYPE] when (0) then 'Restaurant'  end)", false);

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

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
                entity.Property(e => e.Uid).HasDefaultValueSql("(newid())");

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

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

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

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Curcode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Selldays)
                    .IsUnicode(false)
                    .IsFixedLength();

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

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<StdstoreItems>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__STDSTORE__3214EC267139131B")
                    .IsClustered(false);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<StdstoreItemsGroups>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__STDSTORE__3214EC26FE38D331")
                    .IsClustered(false);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

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
            });

            modelBuilder.Entity<Survey>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__SURVEY__3214EC2657C407BC")
                    .IsClustered(false);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Questionnumbers).HasDefaultValueSql("((1))");

                entity.Property(e => e.Requiredmarks).HasDefaultValueSql("((1))");

                entity.Property(e => e.Titlevisible).HasDefaultValueSql("((1))");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Editdate).HasDefaultValueSql("(getdate())");

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
                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__TICKET__3214EC269EB03149")
                    .IsClustered(false);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adultmandatory).HasDefaultValueSql("((1))");

                entity.Property(e => e.Tickettype).HasDefaultValueSql("((1))");

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
                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Curcode)
                    .IsUnicode(false)
                    .IsFixedLength();

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
                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Datesort).HasComputedColumnSql("(datediff(day,[STARTDATE],[ENDDATE]))", true);

                entity.Property(e => e.FridayEndtime).HasDefaultValueSql("((23))");

                entity.Property(e => e.FridayEndtimeM).HasDefaultValueSql("((0))");

                entity.Property(e => e.FridayStarttime).HasDefaultValueSql("((9))");

                entity.Property(e => e.FridayStarttimeM).HasDefaultValueSql("((0))");

                entity.Property(e => e.FridayUse).HasDefaultValueSql("((1))");

                entity.Property(e => e.Minuteperiod).HasDefaultValueSql("((30))");

                entity.Property(e => e.MondayEndtime).HasDefaultValueSql("((23))");

                entity.Property(e => e.MondayEndtimeM).HasDefaultValueSql("((0))");

                entity.Property(e => e.MondayStarttime).HasDefaultValueSql("((9))");

                entity.Property(e => e.MondayStarttimeM).HasDefaultValueSql("((0))");

                entity.Property(e => e.MondayUse).HasDefaultValueSql("((1))");

                entity.Property(e => e.SaturdayEndtime).HasDefaultValueSql("((23))");

                entity.Property(e => e.SaturdayEndtimeM).HasDefaultValueSql("((0))");

                entity.Property(e => e.SaturdayStarttime).HasDefaultValueSql("((9))");

                entity.Property(e => e.SaturdayStarttimeM).HasDefaultValueSql("((0))");

                entity.Property(e => e.SaturdayUse).HasDefaultValueSql("((1))");

                entity.Property(e => e.SundayEndtime).HasDefaultValueSql("((23))");

                entity.Property(e => e.SundayEndtimeM).HasDefaultValueSql("((0))");

                entity.Property(e => e.SundayStarttime).HasDefaultValueSql("((9))");

                entity.Property(e => e.SundayStarttimeM).HasDefaultValueSql("((0))");

                entity.Property(e => e.SundayUse).HasDefaultValueSql("((1))");

                entity.Property(e => e.ThursdayEndtime).HasDefaultValueSql("((23))");

                entity.Property(e => e.ThursdayEndtimeM).HasDefaultValueSql("((0))");

                entity.Property(e => e.ThursdayStarttime).HasDefaultValueSql("((9))");

                entity.Property(e => e.ThursdayStarttimeM).HasDefaultValueSql("((0))");

                entity.Property(e => e.ThursdayUse).HasDefaultValueSql("((1))");

                entity.Property(e => e.TuesdayEndtime).HasDefaultValueSql("((23))");

                entity.Property(e => e.TuesdayEndtimeM).HasDefaultValueSql("((0))");

                entity.Property(e => e.TuesdayStarttime).HasDefaultValueSql("((9))");

                entity.Property(e => e.TuesdayStarttimeM).HasDefaultValueSql("((0))");

                entity.Property(e => e.TuesdayUse).HasDefaultValueSql("((1))");

                entity.Property(e => e.WednesdayEndtime).HasDefaultValueSql("((23))");

                entity.Property(e => e.WednesdayEndtimeM).HasDefaultValueSql("((0))");

                entity.Property(e => e.WednesdayStarttime).HasDefaultValueSql("((9))");

                entity.Property(e => e.WednesdayStarttimeM).HasDefaultValueSql("((0))");

                entity.Property(e => e.WednesdayUse).HasDefaultValueSql("((1))");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

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
                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Checkindays)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Curcode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Pricekind).HasDefaultValueSql("((1))");

                entity.Property(e => e.Pricesort).HasComputedColumnSql("(((((case when [SELLFROM] IS NOT NULL then (1) else (0) end+case when [SELLTO] IS NOT NULL then (1) else (0) end)+case when [TICKETDATEFROM] IS NOT NULL then (1) else (0) end)+case when [TICKETDATETO] IS NOT NULL then (1) else (0) end)+case when [CHECKINDAYS] IS NOT NULL then (1) else (0) end)+case when [MAXVALIDCAPACITY] IS NOT NULL then (1) else (0) end)", true);

                entity.Property(e => e.Pricetype).HasDefaultValueSql("((1))");

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
                entity.Property(e => e.RowCount).HasDefaultValueSql("((2))");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Adultcapacity).HasDefaultValueSql("((1))");

                entity.Property(e => e.Intid).ValueGeneratedOnAdd();

                entity.Property(e => e.TotalDays).HasDefaultValueSql("((1))");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

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
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Commissionincluded).HasDefaultValueSql("((0))");

                entity.Property(e => e.Curcode)
                    .IsUnicode(false)
                    .IsFixedLength();

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Stepno).HasDefaultValueSql("((1))");

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

            modelBuilder.Entity<TransferLocations>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__TRANSFER__3214EC26B028FCA6")
                    .IsClustered(false);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Arrivaldays)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Curcode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Departuredays)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Pricesort).HasComputedColumnSql("(case when [VEHICLETYPEID] IS NOT NULL then (4) else (0) end+((((((case when [SELLFROM] IS NOT NULL then (1) else (0) end+case when [SELLTO] IS NOT NULL then (1) else (0) end)+case when [TICKETDATEFROM] IS NOT NULL then (1) else (0) end)+case when [TICKETDATETO] IS NOT NULL then (1) else (0) end)+case when [ARRIVALDAYS] IS NOT NULL then (1) else (0) end)+case when [DEPARTUREDAYS] IS NOT NULL then (1) else (0) end)+case when [SELLDAYS] IS NOT NULL then (1) else (0) end))", true);

                entity.Property(e => e.Pricetype).HasDefaultValueSql("((1))");

                entity.Property(e => e.Selldays)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Useonline).HasDefaultValueSql("((1))");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

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

                entity.Property(e => e.Direction).HasDefaultValueSql("((1))");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserHistory)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__USER_HIST__USERI__519AEE00");
            });

            modelBuilder.Entity<UserProjectDetails>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.ProjectGroupdetail)
                    .WithMany(p => p.UserProjectDetails)
                    .HasForeignKey(d => d.ProjectGroupdetailid)
                    .HasConstraintName("FK_USER_PROJECT_DETAILS_PROJECT_GROUPDETAIL");
            });

            modelBuilder.Entity<UserProjects>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.ProjectGroup)
                    .WithMany(p => p.UserProjects)
                    .HasForeignKey(d => d.ProjectGroupid)
                    .HasConstraintName("FK__USER_PROJ__PROJE__662B2B3B");
            });

            modelBuilder.Entity<UserRoleRequestStatus>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

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
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

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
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Fullname).HasComputedColumnSql("((isnull([FIRSTNAME],'')+' ')+isnull([LASTNAME],''))", false);

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Aircondition).HasDefaultValueSql("((1))");

                entity.Property(e => e.BaggageCapacity)
                    .HasDefaultValueSql("((3))")
                    .IsFixedLength();

                entity.Property(e => e.PersonCount).HasDefaultValueSql("((4))");

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
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Corpid).HasDefaultValueSql("('183D3B34-92F3-4A9B-B976-60F68FD1519B')");

                entity.Property(e => e.Intid).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Corp)
                    .WithMany(p => p.VirtualPos)
                    .HasForeignKey(d => d.Corpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__CORPI__6DF7358C");
            });

            modelBuilder.Entity<VirtualPosAccountInstalments>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

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
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Use3d).HasDefaultValueSql("((1))");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Curcode)
                    .IsUnicode(false)
                    .IsFixedLength();

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

            modelBuilder.Entity<VirtualPosDefaults>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__VIRTUAL___3214EC26FBDA7D1D")
                    .IsClustered(false);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Curcode)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VirtualPosDepPayments>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__VIRTUAL___3214EC26FF40B2D4")
                    .IsClustered(false);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Intid).ValueGeneratedOnAdd();

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Editdate).HasDefaultValueSql("(getdate())");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ResultMail).HasDefaultValueSql("((0))");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CandivPayment).HasDefaultValueSql("((0))");

                entity.Property(e => e.Curcode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Langcode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Piece).HasDefaultValueSql("((1))");

                entity.Property(e => e.Useemail).HasDefaultValueSql("((1))");

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
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CandivPayment).HasDefaultValueSql("((0))");

                entity.Property(e => e.Curcode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Langcode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Piece).HasDefaultValueSql("((1))");

                entity.Property(e => e.Useemail).HasDefaultValueSql("((1))");

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

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
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompletebasketAftersuccess).HasDefaultValueSql("((0))");

                entity.Property(e => e.Curcode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Instalment).HasDefaultValueSql("((1))");

                entity.Property(e => e.Intid).ValueGeneratedOnAdd();

                entity.Property(e => e.Isintegrated).HasComputedColumnSql("(case when [ENTID] IS NULL then (0) else (1) end)", true);

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

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Editdate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.RequestDetail)
                    .WithMany(p => p.VirtualPosPaymentsCancel)
                    .HasForeignKey(d => d.RequestDetailid)
                    .HasConstraintName("FK__VIRTUAL_P__REQUE__2D1D9668");
            });

            modelBuilder.Entity<VirtualPosSwap>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

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
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Pos)
                    .WithMany()
                    .HasForeignKey(d => d.Posid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__POSID__361CF0BD");
            });

            modelBuilder.Entity<VwBasketInfo>(entity =>
            {
                entity.ToView("VW_BASKET_INFO");

                entity.Property(e => e.Curcode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ReqCurcode)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwBasketPayments>(entity =>
            {
                entity.ToView("VW_BASKET_PAYMENTS");

                entity.Property(e => e.Ccurcode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Curcode)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwCallJobs>(entity =>
            {
                entity.ToView("VW_CALL_JOBS");

                entity.Property(e => e.Campaigncode).IsFixedLength();

                entity.Property(e => e.Kind)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Reason).IsUnicode(false);
            });

            modelBuilder.Entity<VwCalljobReasons>(entity =>
            {
                entity.ToView("VW_CALLJOB_REASONS");

                entity.Property(e => e.Reason).IsUnicode(false);
            });

            modelBuilder.Entity<VwCampaigns>(entity =>
            {
                entity.ToView("VW_CAMPAIGNS");
            });

            modelBuilder.Entity<VwHotelMarketCountry>(entity =>
            {
                entity.ToView("VW_HOTEL_MARKET_COUNTRY");
            });

            modelBuilder.Entity<VwIpcountrycodes>(entity =>
            {
                entity.ToView("VW_IPCOUNTRYCODES");
            });

            modelBuilder.Entity<VwIplocations>(entity =>
            {
                entity.ToView("VW_IPLOCATIONS");
            });

            modelBuilder.Entity<VwLocations>(entity =>
            {
                entity.ToView("VW_LOCATIONS");

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<VwMobPaymentReport>(entity =>
            {
                entity.ToView("VW_MOB_PAYMENT_REPORT");

                entity.Property(e => e.Curcode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Paytype).IsUnicode(false);

                entity.Property(e => e.Rcurcode)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwProducts>(entity =>
            {
                entity.ToView("VW_PRODUCTS");

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<VwProjectGroup>(entity =>
            {
                entity.ToView("VW_PROJECT_GROUP");
            });

            modelBuilder.Entity<VwPromotionCodes>(entity =>
            {
                entity.ToView("VW_PROMOTION_CODES");

                entity.Property(e => e.Discountkind).IsUnicode(false);

                entity.Property(e => e.Discounttype).IsUnicode(false);

                entity.Property(e => e.Kind).IsUnicode(false);

                entity.Property(e => e.Usetype).IsUnicode(false);
            });

            modelBuilder.Entity<VwRequestPaymentCancels>(entity =>
            {
                entity.ToView("VW_REQUEST_PAYMENT_CANCELS");

                entity.Property(e => e.Curcode)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwRequestPayments>(entity =>
            {
                entity.ToView("VW_REQUEST_PAYMENTS");

                entity.Property(e => e.Curcode)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwSales>(entity =>
            {
                entity.ToView("VW_SALES");

                entity.Property(e => e.Curcode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Producttype).IsUnicode(false);
            });

            modelBuilder.Entity<VwSalesAll>(entity =>
            {
                entity.ToView("VW_SALES_ALL");

                entity.Property(e => e.Curcode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Producttype).IsUnicode(false);
            });

            modelBuilder.Entity<VwSalesReport>(entity =>
            {
                entity.ToView("VW_SALES_REPORT");

                entity.Property(e => e.Curcode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Producttype).IsUnicode(false);
            });

            modelBuilder.Entity<VwSalesReportAll>(entity =>
            {
                entity.ToView("VW_SALES_REPORT_ALL");

                entity.Property(e => e.Curcode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Producttype).IsUnicode(false);
            });

            modelBuilder.Entity<VwSalesReportWithResourcepath>(entity =>
            {
                entity.ToView("VW_SALES_REPORT_WITH_RESOURCEPATH");

                entity.Property(e => e.Curcode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Producttype).IsUnicode(false);
            });

            modelBuilder.Entity<VwStdhotelDiscountTypes>(entity =>
            {
                entity.ToView("VW_STDHOTEL_DISCOUNT_TYPES");

                entity.Property(e => e.Description).IsUnicode(false);
            });

            modelBuilder.Entity<VwStdhotelRatecodeDiscountDiscount>(entity =>
            {
                entity.ToView("VW_STDHOTEL_RATECODE_DISCOUNT_DISCOUNT");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
