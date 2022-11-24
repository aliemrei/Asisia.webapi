using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class Users : EntityBase // My Handlebars Helper
    {
        public Users()
        {
            AgencyAdduserNavigation = new HashSet<Agency>();
            AgencyEdituserNavigation = new HashSet<Agency>();
            AgencyGroupAdduserNavigation = new HashSet<AgencyGroup>();
            AgencyGroupEdituserNavigation = new HashSet<AgencyGroup>();
            BonusDefAdduserNavigation = new HashSet<BonusDef>();
            BonusDefEdituserNavigation = new HashSet<BonusDef>();
            BonusDefItemsAdduserNavigation = new HashSet<BonusDefItems>();
            BonusDefItemsEdituserNavigation = new HashSet<BonusDefItems>();
            BonusDefPricesAdduserNavigation = new HashSet<BonusDefPrices>();
            BonusDefPricesEdituserNavigation = new HashSet<BonusDefPrices>();
            BonusDefUsers = new HashSet<BonusDefUsers>();
            CallJobsAdduserNavigation = new HashSet<CallJobs>();
            CallJobsEdituserNavigation = new HashSet<CallJobs>();
            CallJobsUser = new HashSet<CallJobs>();
            CampaignsAdduserNavigation = new HashSet<Campaigns>();
            CampaignsEdituserNavigation = new HashSet<Campaigns>();
            CashierHandoverAdduserNavigation = new HashSet<CashierHandover>();
            CashierHandoverEdituserNavigation = new HashSet<CashierHandover>();
            CashierHandoverUser = new HashSet<CashierHandover>();
            ContactFormAdduserNavigation = new HashSet<ContactForm>();
            ContactFormEdituserNavigation = new HashSet<ContactForm>();
            CorpAdduserNavigation = new HashSet<Corp>();
            CorpEdituserNavigation = new HashSet<Corp>();
            CrmCardgroupsAdduserNavigation = new HashSet<CrmCardgroups>();
            CrmCardgroupsEdituserNavigation = new HashSet<CrmCardgroups>();
            CrmCardtypesAdduserNavigation = new HashSet<CrmCardtypes>();
            CrmCardtypesEdituserNavigation = new HashSet<CrmCardtypes>();
            HotelReservationsAdduserNavigation = new HashSet<HotelReservations>();
            HotelReservationsEdituserNavigation = new HashSet<HotelReservations>();
            InverseAdduserNavigation = new HashSet<Users>();
            InverseEdituserNavigation = new HashSet<Users>();
            LocationAddressAdduserNavigation = new HashSet<LocationAddress>();
            LocationAddressEdituserNavigation = new HashSet<LocationAddress>();
            PaymentsAdduserNavigation = new HashSet<Payments>();
            PaymentsEdituserNavigation = new HashSet<Payments>();
            PersonAdduserNavigation = new HashSet<Person>();
            PersonBonusAdduserNavigation = new HashSet<PersonBonus>();
            PersonBonusEdituserNavigation = new HashSet<PersonBonus>();
            PersonBonusTypesAdduserNavigation = new HashSet<PersonBonusTypes>();
            PersonBonusTypesEdituserNavigation = new HashSet<PersonBonusTypes>();
            PersonEdituserNavigation = new HashSet<Person>();
            PersonGroupAdduserNavigation = new HashSet<PersonGroup>();
            PersonGroupEdituserNavigation = new HashSet<PersonGroup>();
            PortalCategoriesAdduserNavigation = new HashSet<PortalCategories>();
            PortalCategoriesEdituserNavigation = new HashSet<PortalCategories>();
            PortalCategoryImagesAdduserNavigation = new HashSet<PortalCategoryImages>();
            PortalCategoryImagesEdituserNavigation = new HashSet<PortalCategoryImages>();
            PortalCategoryItemsAdduserNavigation = new HashSet<PortalCategoryItems>();
            PortalCategoryItemsEdituserNavigation = new HashSet<PortalCategoryItems>();
            PortalDomainsAdduserNavigation = new HashSet<PortalDomains>();
            PortalDomainsEdituserNavigation = new HashSet<PortalDomains>();
            PortalSeoAdduserNavigation = new HashSet<PortalSeo>();
            PortalSeoEdituserNavigation = new HashSet<PortalSeo>();
            ProjectGroupAdduserNavigation = new HashSet<ProjectGroup>();
            ProjectGroupEdituserNavigation = new HashSet<ProjectGroup>();
            PromotionCodesAdduserNavigation = new HashSet<PromotionCodes>();
            PromotionCodesEdituserNavigation = new HashSet<PromotionCodes>();
            RequestAdduserNavigation = new HashSet<Request>();
            RequestDetailAdduserNavigation = new HashSet<RequestDetail>();
            RequestDetailCancellationUser = new HashSet<RequestDetail>();
            RequestDetailEdituserNavigation = new HashSet<RequestDetail>();
            RequestDetailSellerUser = new HashSet<RequestDetail>();
            RequestNotesAdduserNavigation = new HashSet<RequestNotes>();
            RequestNotesEdituserNavigation = new HashSet<RequestNotes>();
            RequestSellerUser = new HashSet<Request>();
            ReservationSettings = new HashSet<ReservationSettings>();
            ResourceDetailAdduserNavigation = new HashSet<ResourceDetail>();
            ResourceDetailEdituserNavigation = new HashSet<ResourceDetail>();
            ResourcesAdduserNavigation = new HashSet<Resources>();
            ResourcesEdituserNavigation = new HashSet<Resources>();
            RolesAdduserNavigation = new HashSet<Roles>();
            RolesEdituserNavigation = new HashSet<Roles>();
            SalesReqAdduserNavigation = new HashSet<SalesReq>();
            SalesReqEdituserNavigation = new HashSet<SalesReq>();
            SmsSettingsAdduserNavigation = new HashSet<SmsSettings>();
            SmsSettingsEdituserNavigation = new HashSet<SmsSettings>();
            SmtpSettingsAdduserNavigation = new HashSet<SmtpSettings>();
            SmtpSettingsEdituserNavigation = new HashSet<SmtpSettings>();
            StdhotelAdduserNavigation = new HashSet<Stdhotel>();
            StdhotelAnnouncementAdduserNavigation = new HashSet<StdhotelAnnouncement>();
            StdhotelAnnouncementEdituserNavigation = new HashSet<StdhotelAnnouncement>();
            StdhotelEdituserNavigation = new HashSet<Stdhotel>();
            StdhotelRatecodeAdduserNavigation = new HashSet<StdhotelRatecode>();
            StdhotelRatecodeDetailAgencygroupsAdduserNavigation = new HashSet<StdhotelRatecodeDetailAgencygroups>();
            StdhotelRatecodeDetailAgencygroupsEdituserNavigation = new HashSet<StdhotelRatecodeDetailAgencygroups>();
            StdhotelRatecodeEdituserNavigation = new HashSet<StdhotelRatecode>();
            StdhotelRatecodeMarkupAdduserNavigation = new HashSet<StdhotelRatecodeMarkup>();
            StdhotelRatecodeMarkupEdituserNavigation = new HashSet<StdhotelRatecodeMarkup>();
            StdhotelRoomtypesAdduserNavigation = new HashSet<StdhotelRoomtypes>();
            StdhotelRoomtypesEdituserNavigation = new HashSet<StdhotelRoomtypes>();
            StdstoreAdduserNavigation = new HashSet<Stdstore>();
            StdstoreEdituserNavigation = new HashSet<Stdstore>();
            StdstoreItemGroupItemsAdduserNavigation = new HashSet<StdstoreItemGroupItems>();
            StdstoreItemGroupItemsEdituserNavigation = new HashSet<StdstoreItemGroupItems>();
            StdstoreItemGroupsAdduserNavigation = new HashSet<StdstoreItemGroups>();
            StdstoreItemGroupsEdituserNavigation = new HashSet<StdstoreItemGroups>();
            StdstoreItemIngredients = new HashSet<StdstoreItemIngredients>();
            StdstoreItemPrices = new HashSet<StdstoreItemPrices>();
            StdstoreItemPricesIngredients = new HashSet<StdstoreItemPricesIngredients>();
            SurveyAdduserNavigation = new HashSet<Survey>();
            SurveyEdituserNavigation = new HashSet<Survey>();
            SurveysAdduserNavigation = new HashSet<Surveys>();
            SurveysEdituserNavigation = new HashSet<Surveys>();
            TicketAdduserNavigation = new HashSet<Ticket>();
            TicketEdituserNavigation = new HashSet<Ticket>();
            TicketHoursAdduserNavigation = new HashSet<TicketHours>();
            TicketHoursEdituserNavigation = new HashSet<TicketHours>();
            TicketMarketAdduserNavigation = new HashSet<TicketMarket>();
            TicketMarketEdituserNavigation = new HashSet<TicketMarket>();
            TicketPricesAdduserNavigation = new HashSet<TicketPrices>();
            TicketPricesEdituserNavigation = new HashSet<TicketPrices>();
            TourAdduserNavigation = new HashSet<Tour>();
            TourDiscountsAdduserNavigation = new HashSet<TourDiscounts>();
            TourDiscountsEdituserNavigation = new HashSet<TourDiscounts>();
            TourEdituserNavigation = new HashSet<Tour>();
            TourPricesAdduserNavigation = new HashSet<TourPrices>();
            TourPricesEdituserNavigation = new HashSet<TourPrices>();
            TourProgramAdduserNavigation = new HashSet<TourProgram>();
            TourProgramEdituserNavigation = new HashSet<TourProgram>();
            TransferLocationsAdduserNavigation = new HashSet<TransferLocations>();
            TransferLocationsEdituserNavigation = new HashSet<TransferLocations>();
            TransferPricesAdduserNavigation = new HashSet<TransferPrices>();
            TransferPricesEdituserNavigation = new HashSet<TransferPrices>();
            TransferProvidersAdduserNavigation = new HashSet<TransferProviders>();
            TransferProvidersEdituserNavigation = new HashSet<TransferProviders>();
            UserHistory = new HashSet<UserHistory>();
            UserRoles = new HashSet<UserRoles>();
            UsersCustomauth = new HashSet<UsersCustomauth>();
            VehicletypesAdduserNavigation = new HashSet<Vehicletypes>();
            VehicletypesEdituserNavigation = new HashSet<Vehicletypes>();
            VirtualPosAccountInstalmentsAdduserNavigation = new HashSet<VirtualPosAccountInstalments>();
            VirtualPosAccountInstalmentsEdituserNavigation = new HashSet<VirtualPosAccountInstalments>();
            VirtualPosAccountsAdduserNavigation = new HashSet<VirtualPosAccounts>();
            VirtualPosAccountsEdituserNavigation = new HashSet<VirtualPosAccounts>();
            VirtualPosDefaultsAdduserNavigation = new HashSet<VirtualPosDefaults>();
            VirtualPosDefaultsEdituserNavigation = new HashSet<VirtualPosDefaults>();
            VirtualPosDepPaymentsAdduserNavigation = new HashSet<VirtualPosDepPayments>();
            VirtualPosDepPaymentsCancelAdduserNavigation = new HashSet<VirtualPosDepPaymentsCancel>();
            VirtualPosDepPaymentsCancelEdituserNavigation = new HashSet<VirtualPosDepPaymentsCancel>();
            VirtualPosDepPaymentsEdituserNavigation = new HashSet<VirtualPosDepPayments>();
            VirtualPosPaymentEmailsAdduserNavigation = new HashSet<VirtualPosPaymentEmails>();
            VirtualPosPaymentEmailsEdituserNavigation = new HashSet<VirtualPosPaymentEmails>();
            VirtualPosPaymentMessageTempsAdduserNavigation = new HashSet<VirtualPosPaymentMessageTemps>();
            VirtualPosPaymentMessageTempsEdituserNavigation = new HashSet<VirtualPosPaymentMessageTemps>();
            VirtualPosPaymentRequestsAdduserNavigation = new HashSet<VirtualPosPaymentRequests>();
            VirtualPosPaymentRequestsEdituserNavigation = new HashSet<VirtualPosPaymentRequests>();
            VirtualPosPaymentRequestsNotesAdduserNavigation = new HashSet<VirtualPosPaymentRequestsNotes>();
            VirtualPosPaymentRequestsNotesEdituserNavigation = new HashSet<VirtualPosPaymentRequestsNotes>();
            VirtualPosPaymentTempsAdduserNavigation = new HashSet<VirtualPosPaymentTemps>();
            VirtualPosPaymentTempsEdituserNavigation = new HashSet<VirtualPosPaymentTemps>();
            VirtualPosPaymentVposesAdduserNavigation = new HashSet<VirtualPosPaymentVposes>();
            VirtualPosPaymentVposesEdituserNavigation = new HashSet<VirtualPosPaymentVposes>();
            VirtualPosPaymentsAdduserNavigation = new HashSet<VirtualPosPayments>();
            VirtualPosPaymentsEdituserNavigation = new HashSet<VirtualPosPayments>();
        }

        public Guid Id { get; set; }
        public Guid Corpid { get; set; }
        public string Username { get; set; } = null!;
        public string? Password { get; set; }
        public bool Systemadmin { get; set; }
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public string Fullname { get; set; } = null!;
        public long? Tel1 { get; set; }
        public long? Tel2 { get; set; }
        public string? Email { get; set; }
        public bool Isdeleted { get; set; }
        public bool Isdisabled { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public bool MustchangepaswordNextlogon { get; set; }
        public Guid? Moduleid { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Corp Corp { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual ICollection<Agency> AgencyAdduserNavigation { get; set; }
        public virtual ICollection<Agency> AgencyEdituserNavigation { get; set; }
        public virtual ICollection<AgencyGroup> AgencyGroupAdduserNavigation { get; set; }
        public virtual ICollection<AgencyGroup> AgencyGroupEdituserNavigation { get; set; }
        public virtual ICollection<BonusDef> BonusDefAdduserNavigation { get; set; }
        public virtual ICollection<BonusDef> BonusDefEdituserNavigation { get; set; }
        public virtual ICollection<BonusDefItems> BonusDefItemsAdduserNavigation { get; set; }
        public virtual ICollection<BonusDefItems> BonusDefItemsEdituserNavigation { get; set; }
        public virtual ICollection<BonusDefPrices> BonusDefPricesAdduserNavigation { get; set; }
        public virtual ICollection<BonusDefPrices> BonusDefPricesEdituserNavigation { get; set; }
        public virtual ICollection<BonusDefUsers> BonusDefUsers { get; set; }
        public virtual ICollection<CallJobs> CallJobsAdduserNavigation { get; set; }
        public virtual ICollection<CallJobs> CallJobsEdituserNavigation { get; set; }
        public virtual ICollection<CallJobs> CallJobsUser { get; set; }
        public virtual ICollection<Campaigns> CampaignsAdduserNavigation { get; set; }
        public virtual ICollection<Campaigns> CampaignsEdituserNavigation { get; set; }
        public virtual ICollection<CashierHandover> CashierHandoverAdduserNavigation { get; set; }
        public virtual ICollection<CashierHandover> CashierHandoverEdituserNavigation { get; set; }
        public virtual ICollection<CashierHandover> CashierHandoverUser { get; set; }
        public virtual ICollection<ContactForm> ContactFormAdduserNavigation { get; set; }
        public virtual ICollection<ContactForm> ContactFormEdituserNavigation { get; set; }
        public virtual ICollection<Corp> CorpAdduserNavigation { get; set; }
        public virtual ICollection<Corp> CorpEdituserNavigation { get; set; }
        public virtual ICollection<CrmCardgroups> CrmCardgroupsAdduserNavigation { get; set; }
        public virtual ICollection<CrmCardgroups> CrmCardgroupsEdituserNavigation { get; set; }
        public virtual ICollection<CrmCardtypes> CrmCardtypesAdduserNavigation { get; set; }
        public virtual ICollection<CrmCardtypes> CrmCardtypesEdituserNavigation { get; set; }
        public virtual ICollection<HotelReservations> HotelReservationsAdduserNavigation { get; set; }
        public virtual ICollection<HotelReservations> HotelReservationsEdituserNavigation { get; set; }
        public virtual ICollection<Users> InverseAdduserNavigation { get; set; }
        public virtual ICollection<Users> InverseEdituserNavigation { get; set; }
        public virtual ICollection<LocationAddress> LocationAddressAdduserNavigation { get; set; }
        public virtual ICollection<LocationAddress> LocationAddressEdituserNavigation { get; set; }
        public virtual ICollection<Payments> PaymentsAdduserNavigation { get; set; }
        public virtual ICollection<Payments> PaymentsEdituserNavigation { get; set; }
        public virtual ICollection<Person> PersonAdduserNavigation { get; set; }
        public virtual ICollection<PersonBonus> PersonBonusAdduserNavigation { get; set; }
        public virtual ICollection<PersonBonus> PersonBonusEdituserNavigation { get; set; }
        public virtual ICollection<PersonBonusTypes> PersonBonusTypesAdduserNavigation { get; set; }
        public virtual ICollection<PersonBonusTypes> PersonBonusTypesEdituserNavigation { get; set; }
        public virtual ICollection<Person> PersonEdituserNavigation { get; set; }
        public virtual ICollection<PersonGroup> PersonGroupAdduserNavigation { get; set; }
        public virtual ICollection<PersonGroup> PersonGroupEdituserNavigation { get; set; }
        public virtual ICollection<PortalCategories> PortalCategoriesAdduserNavigation { get; set; }
        public virtual ICollection<PortalCategories> PortalCategoriesEdituserNavigation { get; set; }
        public virtual ICollection<PortalCategoryImages> PortalCategoryImagesAdduserNavigation { get; set; }
        public virtual ICollection<PortalCategoryImages> PortalCategoryImagesEdituserNavigation { get; set; }
        public virtual ICollection<PortalCategoryItems> PortalCategoryItemsAdduserNavigation { get; set; }
        public virtual ICollection<PortalCategoryItems> PortalCategoryItemsEdituserNavigation { get; set; }
        public virtual ICollection<PortalDomains> PortalDomainsAdduserNavigation { get; set; }
        public virtual ICollection<PortalDomains> PortalDomainsEdituserNavigation { get; set; }
        public virtual ICollection<PortalSeo> PortalSeoAdduserNavigation { get; set; }
        public virtual ICollection<PortalSeo> PortalSeoEdituserNavigation { get; set; }
        public virtual ICollection<ProjectGroup> ProjectGroupAdduserNavigation { get; set; }
        public virtual ICollection<ProjectGroup> ProjectGroupEdituserNavigation { get; set; }
        public virtual ICollection<PromotionCodes> PromotionCodesAdduserNavigation { get; set; }
        public virtual ICollection<PromotionCodes> PromotionCodesEdituserNavigation { get; set; }
        public virtual ICollection<Request> RequestAdduserNavigation { get; set; }
        public virtual ICollection<RequestDetail> RequestDetailAdduserNavigation { get; set; }
        public virtual ICollection<RequestDetail> RequestDetailCancellationUser { get; set; }
        public virtual ICollection<RequestDetail> RequestDetailEdituserNavigation { get; set; }
        public virtual ICollection<RequestDetail> RequestDetailSellerUser { get; set; }
        public virtual ICollection<RequestNotes> RequestNotesAdduserNavigation { get; set; }
        public virtual ICollection<RequestNotes> RequestNotesEdituserNavigation { get; set; }
        public virtual ICollection<Request> RequestSellerUser { get; set; }
        public virtual ICollection<ReservationSettings> ReservationSettings { get; set; }
        public virtual ICollection<ResourceDetail> ResourceDetailAdduserNavigation { get; set; }
        public virtual ICollection<ResourceDetail> ResourceDetailEdituserNavigation { get; set; }
        public virtual ICollection<Resources> ResourcesAdduserNavigation { get; set; }
        public virtual ICollection<Resources> ResourcesEdituserNavigation { get; set; }
        public virtual ICollection<Roles> RolesAdduserNavigation { get; set; }
        public virtual ICollection<Roles> RolesEdituserNavigation { get; set; }
        public virtual ICollection<SalesReq> SalesReqAdduserNavigation { get; set; }
        public virtual ICollection<SalesReq> SalesReqEdituserNavigation { get; set; }
        public virtual ICollection<SmsSettings> SmsSettingsAdduserNavigation { get; set; }
        public virtual ICollection<SmsSettings> SmsSettingsEdituserNavigation { get; set; }
        public virtual ICollection<SmtpSettings> SmtpSettingsAdduserNavigation { get; set; }
        public virtual ICollection<SmtpSettings> SmtpSettingsEdituserNavigation { get; set; }
        public virtual ICollection<Stdhotel> StdhotelAdduserNavigation { get; set; }
        public virtual ICollection<StdhotelAnnouncement> StdhotelAnnouncementAdduserNavigation { get; set; }
        public virtual ICollection<StdhotelAnnouncement> StdhotelAnnouncementEdituserNavigation { get; set; }
        public virtual ICollection<Stdhotel> StdhotelEdituserNavigation { get; set; }
        public virtual ICollection<StdhotelRatecode> StdhotelRatecodeAdduserNavigation { get; set; }
        public virtual ICollection<StdhotelRatecodeDetailAgencygroups> StdhotelRatecodeDetailAgencygroupsAdduserNavigation { get; set; }
        public virtual ICollection<StdhotelRatecodeDetailAgencygroups> StdhotelRatecodeDetailAgencygroupsEdituserNavigation { get; set; }
        public virtual ICollection<StdhotelRatecode> StdhotelRatecodeEdituserNavigation { get; set; }
        public virtual ICollection<StdhotelRatecodeMarkup> StdhotelRatecodeMarkupAdduserNavigation { get; set; }
        public virtual ICollection<StdhotelRatecodeMarkup> StdhotelRatecodeMarkupEdituserNavigation { get; set; }
        public virtual ICollection<StdhotelRoomtypes> StdhotelRoomtypesAdduserNavigation { get; set; }
        public virtual ICollection<StdhotelRoomtypes> StdhotelRoomtypesEdituserNavigation { get; set; }
        public virtual ICollection<Stdstore> StdstoreAdduserNavigation { get; set; }
        public virtual ICollection<Stdstore> StdstoreEdituserNavigation { get; set; }
        public virtual ICollection<StdstoreItemGroupItems> StdstoreItemGroupItemsAdduserNavigation { get; set; }
        public virtual ICollection<StdstoreItemGroupItems> StdstoreItemGroupItemsEdituserNavigation { get; set; }
        public virtual ICollection<StdstoreItemGroups> StdstoreItemGroupsAdduserNavigation { get; set; }
        public virtual ICollection<StdstoreItemGroups> StdstoreItemGroupsEdituserNavigation { get; set; }
        public virtual ICollection<StdstoreItemIngredients> StdstoreItemIngredients { get; set; }
        public virtual ICollection<StdstoreItemPrices> StdstoreItemPrices { get; set; }
        public virtual ICollection<StdstoreItemPricesIngredients> StdstoreItemPricesIngredients { get; set; }
        public virtual ICollection<Survey> SurveyAdduserNavigation { get; set; }
        public virtual ICollection<Survey> SurveyEdituserNavigation { get; set; }
        public virtual ICollection<Surveys> SurveysAdduserNavigation { get; set; }
        public virtual ICollection<Surveys> SurveysEdituserNavigation { get; set; }
        public virtual ICollection<Ticket> TicketAdduserNavigation { get; set; }
        public virtual ICollection<Ticket> TicketEdituserNavigation { get; set; }
        public virtual ICollection<TicketHours> TicketHoursAdduserNavigation { get; set; }
        public virtual ICollection<TicketHours> TicketHoursEdituserNavigation { get; set; }
        public virtual ICollection<TicketMarket> TicketMarketAdduserNavigation { get; set; }
        public virtual ICollection<TicketMarket> TicketMarketEdituserNavigation { get; set; }
        public virtual ICollection<TicketPrices> TicketPricesAdduserNavigation { get; set; }
        public virtual ICollection<TicketPrices> TicketPricesEdituserNavigation { get; set; }
        public virtual ICollection<Tour> TourAdduserNavigation { get; set; }
        public virtual ICollection<TourDiscounts> TourDiscountsAdduserNavigation { get; set; }
        public virtual ICollection<TourDiscounts> TourDiscountsEdituserNavigation { get; set; }
        public virtual ICollection<Tour> TourEdituserNavigation { get; set; }
        public virtual ICollection<TourPrices> TourPricesAdduserNavigation { get; set; }
        public virtual ICollection<TourPrices> TourPricesEdituserNavigation { get; set; }
        public virtual ICollection<TourProgram> TourProgramAdduserNavigation { get; set; }
        public virtual ICollection<TourProgram> TourProgramEdituserNavigation { get; set; }
        public virtual ICollection<TransferLocations> TransferLocationsAdduserNavigation { get; set; }
        public virtual ICollection<TransferLocations> TransferLocationsEdituserNavigation { get; set; }
        public virtual ICollection<TransferPrices> TransferPricesAdduserNavigation { get; set; }
        public virtual ICollection<TransferPrices> TransferPricesEdituserNavigation { get; set; }
        public virtual ICollection<TransferProviders> TransferProvidersAdduserNavigation { get; set; }
        public virtual ICollection<TransferProviders> TransferProvidersEdituserNavigation { get; set; }
        public virtual ICollection<UserHistory> UserHistory { get; set; }
        public virtual ICollection<UserRoles> UserRoles { get; set; }
        public virtual ICollection<UsersCustomauth> UsersCustomauth { get; set; }
        public virtual ICollection<Vehicletypes> VehicletypesAdduserNavigation { get; set; }
        public virtual ICollection<Vehicletypes> VehicletypesEdituserNavigation { get; set; }
        public virtual ICollection<VirtualPosAccountInstalments> VirtualPosAccountInstalmentsAdduserNavigation { get; set; }
        public virtual ICollection<VirtualPosAccountInstalments> VirtualPosAccountInstalmentsEdituserNavigation { get; set; }
        public virtual ICollection<VirtualPosAccounts> VirtualPosAccountsAdduserNavigation { get; set; }
        public virtual ICollection<VirtualPosAccounts> VirtualPosAccountsEdituserNavigation { get; set; }
        public virtual ICollection<VirtualPosDefaults> VirtualPosDefaultsAdduserNavigation { get; set; }
        public virtual ICollection<VirtualPosDefaults> VirtualPosDefaultsEdituserNavigation { get; set; }
        public virtual ICollection<VirtualPosDepPayments> VirtualPosDepPaymentsAdduserNavigation { get; set; }
        public virtual ICollection<VirtualPosDepPaymentsCancel> VirtualPosDepPaymentsCancelAdduserNavigation { get; set; }
        public virtual ICollection<VirtualPosDepPaymentsCancel> VirtualPosDepPaymentsCancelEdituserNavigation { get; set; }
        public virtual ICollection<VirtualPosDepPayments> VirtualPosDepPaymentsEdituserNavigation { get; set; }
        public virtual ICollection<VirtualPosPaymentEmails> VirtualPosPaymentEmailsAdduserNavigation { get; set; }
        public virtual ICollection<VirtualPosPaymentEmails> VirtualPosPaymentEmailsEdituserNavigation { get; set; }
        public virtual ICollection<VirtualPosPaymentMessageTemps> VirtualPosPaymentMessageTempsAdduserNavigation { get; set; }
        public virtual ICollection<VirtualPosPaymentMessageTemps> VirtualPosPaymentMessageTempsEdituserNavigation { get; set; }
        public virtual ICollection<VirtualPosPaymentRequests> VirtualPosPaymentRequestsAdduserNavigation { get; set; }
        public virtual ICollection<VirtualPosPaymentRequests> VirtualPosPaymentRequestsEdituserNavigation { get; set; }
        public virtual ICollection<VirtualPosPaymentRequestsNotes> VirtualPosPaymentRequestsNotesAdduserNavigation { get; set; }
        public virtual ICollection<VirtualPosPaymentRequestsNotes> VirtualPosPaymentRequestsNotesEdituserNavigation { get; set; }
        public virtual ICollection<VirtualPosPaymentTemps> VirtualPosPaymentTempsAdduserNavigation { get; set; }
        public virtual ICollection<VirtualPosPaymentTemps> VirtualPosPaymentTempsEdituserNavigation { get; set; }
        public virtual ICollection<VirtualPosPaymentVposes> VirtualPosPaymentVposesAdduserNavigation { get; set; }
        public virtual ICollection<VirtualPosPaymentVposes> VirtualPosPaymentVposesEdituserNavigation { get; set; }
        public virtual ICollection<VirtualPosPayments> VirtualPosPaymentsAdduserNavigation { get; set; }
        public virtual ICollection<VirtualPosPayments> VirtualPosPaymentsEdituserNavigation { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
