using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("USERS")]
    [Index(nameof(Moduleid), Name = "IX_USERS")]
    [Index(nameof(Username), Name = "IX_USERS_1", IsUnique = true)]
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

        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("CORPID")]
        public Guid Corpid { get; set; }
        [Column("USERNAME")]
        [StringLength(100)]
        public string Username { get; set; } = null!;
        [Column("PASSWORD")]
        [StringLength(100)]
        public string? Password { get; set; }
        [Column("SYSTEMADMIN")]
        public bool Systemadmin { get; set; }
        [Column("FIRSTNAME")]
        [StringLength(100)]
        public string Firstname { get; set; } = null!;
        [Column("LASTNAME")]
        [StringLength(100)]
        public string Lastname { get; set; } = null!;
        [Column("FULLNAME")]
        [StringLength(201)]
        public string Fullname { get; set; } = null!;
        [Column("TEL1")]
        public long? Tel1 { get; set; }
        [Column("TEL2")]
        public long? Tel2 { get; set; }
        [Column("EMAIL")]
        [StringLength(200)]
        public string? Email { get; set; }
        [Column("ISDELETED")]
        public bool Isdeleted { get; set; }
        [Column("ISDISABLED")]
        public bool Isdisabled { get; set; }
        [Column("ADDUSER")]
        public Guid Adduser { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("EDITUSER")]
        public Guid? Edituser { get; set; }
        [Column("EDITDATE", TypeName = "datetime")]
        public DateTime? Editdate { get; set; }
        [Column("MUSTCHANGEPASWORD_NEXTLOGON")]
        public bool MustchangepaswordNextlogon { get; set; }
        [Column("MODULEID")]
        public Guid? Moduleid { get; set; }

        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.InverseAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Corpid))]
        [InverseProperty("Users")]
        public virtual Corp Corp { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.InverseEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [InverseProperty(nameof(Agency.AdduserNavigation))]
        public virtual ICollection<Agency> AgencyAdduserNavigation { get; set; }
        [InverseProperty(nameof(Agency.EdituserNavigation))]
        public virtual ICollection<Agency> AgencyEdituserNavigation { get; set; }
        [InverseProperty(nameof(AgencyGroup.AdduserNavigation))]
        public virtual ICollection<AgencyGroup> AgencyGroupAdduserNavigation { get; set; }
        [InverseProperty(nameof(AgencyGroup.EdituserNavigation))]
        public virtual ICollection<AgencyGroup> AgencyGroupEdituserNavigation { get; set; }
        [InverseProperty(nameof(BonusDef.AdduserNavigation))]
        public virtual ICollection<BonusDef> BonusDefAdduserNavigation { get; set; }
        [InverseProperty(nameof(BonusDef.EdituserNavigation))]
        public virtual ICollection<BonusDef> BonusDefEdituserNavigation { get; set; }
        [InverseProperty(nameof(BonusDefItems.AdduserNavigation))]
        public virtual ICollection<BonusDefItems> BonusDefItemsAdduserNavigation { get; set; }
        [InverseProperty(nameof(BonusDefItems.EdituserNavigation))]
        public virtual ICollection<BonusDefItems> BonusDefItemsEdituserNavigation { get; set; }
        [InverseProperty(nameof(BonusDefPrices.AdduserNavigation))]
        public virtual ICollection<BonusDefPrices> BonusDefPricesAdduserNavigation { get; set; }
        [InverseProperty(nameof(BonusDefPrices.EdituserNavigation))]
        public virtual ICollection<BonusDefPrices> BonusDefPricesEdituserNavigation { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<BonusDefUsers> BonusDefUsers { get; set; }
        [InverseProperty(nameof(CallJobs.AdduserNavigation))]
        public virtual ICollection<CallJobs> CallJobsAdduserNavigation { get; set; }
        [InverseProperty(nameof(CallJobs.EdituserNavigation))]
        public virtual ICollection<CallJobs> CallJobsEdituserNavigation { get; set; }
        [InverseProperty(nameof(CallJobs.User))]
        public virtual ICollection<CallJobs> CallJobsUser { get; set; }
        [InverseProperty(nameof(Campaigns.AdduserNavigation))]
        public virtual ICollection<Campaigns> CampaignsAdduserNavigation { get; set; }
        [InverseProperty(nameof(Campaigns.EdituserNavigation))]
        public virtual ICollection<Campaigns> CampaignsEdituserNavigation { get; set; }
        [InverseProperty(nameof(CashierHandover.AdduserNavigation))]
        public virtual ICollection<CashierHandover> CashierHandoverAdduserNavigation { get; set; }
        [InverseProperty(nameof(CashierHandover.EdituserNavigation))]
        public virtual ICollection<CashierHandover> CashierHandoverEdituserNavigation { get; set; }
        [InverseProperty(nameof(CashierHandover.User))]
        public virtual ICollection<CashierHandover> CashierHandoverUser { get; set; }
        [InverseProperty(nameof(ContactForm.AdduserNavigation))]
        public virtual ICollection<ContactForm> ContactFormAdduserNavigation { get; set; }
        [InverseProperty(nameof(ContactForm.EdituserNavigation))]
        public virtual ICollection<ContactForm> ContactFormEdituserNavigation { get; set; }
        [InverseProperty("AdduserNavigation")]
        public virtual ICollection<Corp> CorpAdduserNavigation { get; set; }
        [InverseProperty("EdituserNavigation")]
        public virtual ICollection<Corp> CorpEdituserNavigation { get; set; }
        [InverseProperty(nameof(CrmCardgroups.AdduserNavigation))]
        public virtual ICollection<CrmCardgroups> CrmCardgroupsAdduserNavigation { get; set; }
        [InverseProperty(nameof(CrmCardgroups.EdituserNavigation))]
        public virtual ICollection<CrmCardgroups> CrmCardgroupsEdituserNavigation { get; set; }
        [InverseProperty(nameof(CrmCardtypes.AdduserNavigation))]
        public virtual ICollection<CrmCardtypes> CrmCardtypesAdduserNavigation { get; set; }
        [InverseProperty(nameof(CrmCardtypes.EdituserNavigation))]
        public virtual ICollection<CrmCardtypes> CrmCardtypesEdituserNavigation { get; set; }
        [InverseProperty(nameof(HotelReservations.AdduserNavigation))]
        public virtual ICollection<HotelReservations> HotelReservationsAdduserNavigation { get; set; }
        [InverseProperty(nameof(HotelReservations.EdituserNavigation))]
        public virtual ICollection<HotelReservations> HotelReservationsEdituserNavigation { get; set; }
        [InverseProperty(nameof(Users.AdduserNavigation))]
        public virtual ICollection<Users> InverseAdduserNavigation { get; set; }
        [InverseProperty(nameof(Users.EdituserNavigation))]
        public virtual ICollection<Users> InverseEdituserNavigation { get; set; }
        [InverseProperty(nameof(LocationAddress.AdduserNavigation))]
        public virtual ICollection<LocationAddress> LocationAddressAdduserNavigation { get; set; }
        [InverseProperty(nameof(LocationAddress.EdituserNavigation))]
        public virtual ICollection<LocationAddress> LocationAddressEdituserNavigation { get; set; }
        [InverseProperty(nameof(Payments.AdduserNavigation))]
        public virtual ICollection<Payments> PaymentsAdduserNavigation { get; set; }
        [InverseProperty(nameof(Payments.EdituserNavigation))]
        public virtual ICollection<Payments> PaymentsEdituserNavigation { get; set; }
        [InverseProperty(nameof(Person.AdduserNavigation))]
        public virtual ICollection<Person> PersonAdduserNavigation { get; set; }
        [InverseProperty(nameof(PersonBonus.AdduserNavigation))]
        public virtual ICollection<PersonBonus> PersonBonusAdduserNavigation { get; set; }
        [InverseProperty(nameof(PersonBonus.EdituserNavigation))]
        public virtual ICollection<PersonBonus> PersonBonusEdituserNavigation { get; set; }
        [InverseProperty(nameof(PersonBonusTypes.AdduserNavigation))]
        public virtual ICollection<PersonBonusTypes> PersonBonusTypesAdduserNavigation { get; set; }
        [InverseProperty(nameof(PersonBonusTypes.EdituserNavigation))]
        public virtual ICollection<PersonBonusTypes> PersonBonusTypesEdituserNavigation { get; set; }
        [InverseProperty(nameof(Person.EdituserNavigation))]
        public virtual ICollection<Person> PersonEdituserNavigation { get; set; }
        [InverseProperty(nameof(PersonGroup.AdduserNavigation))]
        public virtual ICollection<PersonGroup> PersonGroupAdduserNavigation { get; set; }
        [InverseProperty(nameof(PersonGroup.EdituserNavigation))]
        public virtual ICollection<PersonGroup> PersonGroupEdituserNavigation { get; set; }
        [InverseProperty(nameof(PortalCategories.AdduserNavigation))]
        public virtual ICollection<PortalCategories> PortalCategoriesAdduserNavigation { get; set; }
        [InverseProperty(nameof(PortalCategories.EdituserNavigation))]
        public virtual ICollection<PortalCategories> PortalCategoriesEdituserNavigation { get; set; }
        [InverseProperty(nameof(PortalCategoryImages.AdduserNavigation))]
        public virtual ICollection<PortalCategoryImages> PortalCategoryImagesAdduserNavigation { get; set; }
        [InverseProperty(nameof(PortalCategoryImages.EdituserNavigation))]
        public virtual ICollection<PortalCategoryImages> PortalCategoryImagesEdituserNavigation { get; set; }
        [InverseProperty(nameof(PortalCategoryItems.AdduserNavigation))]
        public virtual ICollection<PortalCategoryItems> PortalCategoryItemsAdduserNavigation { get; set; }
        [InverseProperty(nameof(PortalCategoryItems.EdituserNavigation))]
        public virtual ICollection<PortalCategoryItems> PortalCategoryItemsEdituserNavigation { get; set; }
        [InverseProperty(nameof(PortalDomains.AdduserNavigation))]
        public virtual ICollection<PortalDomains> PortalDomainsAdduserNavigation { get; set; }
        [InverseProperty(nameof(PortalDomains.EdituserNavigation))]
        public virtual ICollection<PortalDomains> PortalDomainsEdituserNavigation { get; set; }
        [InverseProperty(nameof(PortalSeo.AdduserNavigation))]
        public virtual ICollection<PortalSeo> PortalSeoAdduserNavigation { get; set; }
        [InverseProperty(nameof(PortalSeo.EdituserNavigation))]
        public virtual ICollection<PortalSeo> PortalSeoEdituserNavigation { get; set; }
        [InverseProperty(nameof(ProjectGroup.AdduserNavigation))]
        public virtual ICollection<ProjectGroup> ProjectGroupAdduserNavigation { get; set; }
        [InverseProperty(nameof(ProjectGroup.EdituserNavigation))]
        public virtual ICollection<ProjectGroup> ProjectGroupEdituserNavigation { get; set; }
        [InverseProperty(nameof(PromotionCodes.AdduserNavigation))]
        public virtual ICollection<PromotionCodes> PromotionCodesAdduserNavigation { get; set; }
        [InverseProperty(nameof(PromotionCodes.EdituserNavigation))]
        public virtual ICollection<PromotionCodes> PromotionCodesEdituserNavigation { get; set; }
        [InverseProperty(nameof(Request.AdduserNavigation))]
        public virtual ICollection<Request> RequestAdduserNavigation { get; set; }
        [InverseProperty(nameof(RequestDetail.AdduserNavigation))]
        public virtual ICollection<RequestDetail> RequestDetailAdduserNavigation { get; set; }
        [InverseProperty(nameof(RequestDetail.CancellationUser))]
        public virtual ICollection<RequestDetail> RequestDetailCancellationUser { get; set; }
        [InverseProperty(nameof(RequestDetail.EdituserNavigation))]
        public virtual ICollection<RequestDetail> RequestDetailEdituserNavigation { get; set; }
        [InverseProperty(nameof(RequestDetail.SellerUser))]
        public virtual ICollection<RequestDetail> RequestDetailSellerUser { get; set; }
        [InverseProperty(nameof(RequestNotes.AdduserNavigation))]
        public virtual ICollection<RequestNotes> RequestNotesAdduserNavigation { get; set; }
        [InverseProperty(nameof(RequestNotes.EdituserNavigation))]
        public virtual ICollection<RequestNotes> RequestNotesEdituserNavigation { get; set; }
        [InverseProperty(nameof(Request.SellerUser))]
        public virtual ICollection<Request> RequestSellerUser { get; set; }
        [InverseProperty("AdduserNavigation")]
        public virtual ICollection<ReservationSettings> ReservationSettings { get; set; }
        [InverseProperty(nameof(ResourceDetail.AdduserNavigation))]
        public virtual ICollection<ResourceDetail> ResourceDetailAdduserNavigation { get; set; }
        [InverseProperty(nameof(ResourceDetail.EdituserNavigation))]
        public virtual ICollection<ResourceDetail> ResourceDetailEdituserNavigation { get; set; }
        [InverseProperty(nameof(Resources.AdduserNavigation))]
        public virtual ICollection<Resources> ResourcesAdduserNavigation { get; set; }
        [InverseProperty(nameof(Resources.EdituserNavigation))]
        public virtual ICollection<Resources> ResourcesEdituserNavigation { get; set; }
        [InverseProperty(nameof(Roles.AdduserNavigation))]
        public virtual ICollection<Roles> RolesAdduserNavigation { get; set; }
        [InverseProperty(nameof(Roles.EdituserNavigation))]
        public virtual ICollection<Roles> RolesEdituserNavigation { get; set; }
        [InverseProperty(nameof(SalesReq.AdduserNavigation))]
        public virtual ICollection<SalesReq> SalesReqAdduserNavigation { get; set; }
        [InverseProperty(nameof(SalesReq.EdituserNavigation))]
        public virtual ICollection<SalesReq> SalesReqEdituserNavigation { get; set; }
        [InverseProperty(nameof(SmsSettings.AdduserNavigation))]
        public virtual ICollection<SmsSettings> SmsSettingsAdduserNavigation { get; set; }
        [InverseProperty(nameof(SmsSettings.EdituserNavigation))]
        public virtual ICollection<SmsSettings> SmsSettingsEdituserNavigation { get; set; }
        [InverseProperty(nameof(SmtpSettings.AdduserNavigation))]
        public virtual ICollection<SmtpSettings> SmtpSettingsAdduserNavigation { get; set; }
        [InverseProperty(nameof(SmtpSettings.EdituserNavigation))]
        public virtual ICollection<SmtpSettings> SmtpSettingsEdituserNavigation { get; set; }
        [InverseProperty(nameof(Stdhotel.AdduserNavigation))]
        public virtual ICollection<Stdhotel> StdhotelAdduserNavigation { get; set; }
        [InverseProperty(nameof(StdhotelAnnouncement.AdduserNavigation))]
        public virtual ICollection<StdhotelAnnouncement> StdhotelAnnouncementAdduserNavigation { get; set; }
        [InverseProperty(nameof(StdhotelAnnouncement.EdituserNavigation))]
        public virtual ICollection<StdhotelAnnouncement> StdhotelAnnouncementEdituserNavigation { get; set; }
        [InverseProperty(nameof(Stdhotel.EdituserNavigation))]
        public virtual ICollection<Stdhotel> StdhotelEdituserNavigation { get; set; }
        [InverseProperty(nameof(StdhotelRatecode.AdduserNavigation))]
        public virtual ICollection<StdhotelRatecode> StdhotelRatecodeAdduserNavigation { get; set; }
        [InverseProperty(nameof(StdhotelRatecodeDetailAgencygroups.AdduserNavigation))]
        public virtual ICollection<StdhotelRatecodeDetailAgencygroups> StdhotelRatecodeDetailAgencygroupsAdduserNavigation { get; set; }
        [InverseProperty(nameof(StdhotelRatecodeDetailAgencygroups.EdituserNavigation))]
        public virtual ICollection<StdhotelRatecodeDetailAgencygroups> StdhotelRatecodeDetailAgencygroupsEdituserNavigation { get; set; }
        [InverseProperty(nameof(StdhotelRatecode.EdituserNavigation))]
        public virtual ICollection<StdhotelRatecode> StdhotelRatecodeEdituserNavigation { get; set; }
        [InverseProperty(nameof(StdhotelRatecodeMarkup.AdduserNavigation))]
        public virtual ICollection<StdhotelRatecodeMarkup> StdhotelRatecodeMarkupAdduserNavigation { get; set; }
        [InverseProperty(nameof(StdhotelRatecodeMarkup.EdituserNavigation))]
        public virtual ICollection<StdhotelRatecodeMarkup> StdhotelRatecodeMarkupEdituserNavigation { get; set; }
        [InverseProperty(nameof(StdhotelRoomtypes.AdduserNavigation))]
        public virtual ICollection<StdhotelRoomtypes> StdhotelRoomtypesAdduserNavigation { get; set; }
        [InverseProperty(nameof(StdhotelRoomtypes.EdituserNavigation))]
        public virtual ICollection<StdhotelRoomtypes> StdhotelRoomtypesEdituserNavigation { get; set; }
        [InverseProperty(nameof(Stdstore.AdduserNavigation))]
        public virtual ICollection<Stdstore> StdstoreAdduserNavigation { get; set; }
        [InverseProperty(nameof(Stdstore.EdituserNavigation))]
        public virtual ICollection<Stdstore> StdstoreEdituserNavigation { get; set; }
        [InverseProperty(nameof(StdstoreItemGroupItems.AdduserNavigation))]
        public virtual ICollection<StdstoreItemGroupItems> StdstoreItemGroupItemsAdduserNavigation { get; set; }
        [InverseProperty(nameof(StdstoreItemGroupItems.EdituserNavigation))]
        public virtual ICollection<StdstoreItemGroupItems> StdstoreItemGroupItemsEdituserNavigation { get; set; }
        [InverseProperty(nameof(StdstoreItemGroups.AdduserNavigation))]
        public virtual ICollection<StdstoreItemGroups> StdstoreItemGroupsAdduserNavigation { get; set; }
        [InverseProperty(nameof(StdstoreItemGroups.EdituserNavigation))]
        public virtual ICollection<StdstoreItemGroups> StdstoreItemGroupsEdituserNavigation { get; set; }
        [InverseProperty("AdduserNavigation")]
        public virtual ICollection<StdstoreItemIngredients> StdstoreItemIngredients { get; set; }
        [InverseProperty("AdduserNavigation")]
        public virtual ICollection<StdstoreItemPrices> StdstoreItemPrices { get; set; }
        [InverseProperty("AdduserNavigation")]
        public virtual ICollection<StdstoreItemPricesIngredients> StdstoreItemPricesIngredients { get; set; }
        [InverseProperty(nameof(Survey.AdduserNavigation))]
        public virtual ICollection<Survey> SurveyAdduserNavigation { get; set; }
        [InverseProperty(nameof(Survey.EdituserNavigation))]
        public virtual ICollection<Survey> SurveyEdituserNavigation { get; set; }
        [InverseProperty(nameof(Surveys.AdduserNavigation))]
        public virtual ICollection<Surveys> SurveysAdduserNavigation { get; set; }
        [InverseProperty(nameof(Surveys.EdituserNavigation))]
        public virtual ICollection<Surveys> SurveysEdituserNavigation { get; set; }
        [InverseProperty(nameof(Ticket.AdduserNavigation))]
        public virtual ICollection<Ticket> TicketAdduserNavigation { get; set; }
        [InverseProperty(nameof(Ticket.EdituserNavigation))]
        public virtual ICollection<Ticket> TicketEdituserNavigation { get; set; }
        [InverseProperty(nameof(TicketHours.AdduserNavigation))]
        public virtual ICollection<TicketHours> TicketHoursAdduserNavigation { get; set; }
        [InverseProperty(nameof(TicketHours.EdituserNavigation))]
        public virtual ICollection<TicketHours> TicketHoursEdituserNavigation { get; set; }
        [InverseProperty(nameof(TicketMarket.AdduserNavigation))]
        public virtual ICollection<TicketMarket> TicketMarketAdduserNavigation { get; set; }
        [InverseProperty(nameof(TicketMarket.EdituserNavigation))]
        public virtual ICollection<TicketMarket> TicketMarketEdituserNavigation { get; set; }
        [InverseProperty(nameof(TicketPrices.AdduserNavigation))]
        public virtual ICollection<TicketPrices> TicketPricesAdduserNavigation { get; set; }
        [InverseProperty(nameof(TicketPrices.EdituserNavigation))]
        public virtual ICollection<TicketPrices> TicketPricesEdituserNavigation { get; set; }
        [InverseProperty(nameof(Tour.AdduserNavigation))]
        public virtual ICollection<Tour> TourAdduserNavigation { get; set; }
        [InverseProperty(nameof(TourDiscounts.AdduserNavigation))]
        public virtual ICollection<TourDiscounts> TourDiscountsAdduserNavigation { get; set; }
        [InverseProperty(nameof(TourDiscounts.EdituserNavigation))]
        public virtual ICollection<TourDiscounts> TourDiscountsEdituserNavigation { get; set; }
        [InverseProperty(nameof(Tour.EdituserNavigation))]
        public virtual ICollection<Tour> TourEdituserNavigation { get; set; }
        [InverseProperty(nameof(TourPrices.AdduserNavigation))]
        public virtual ICollection<TourPrices> TourPricesAdduserNavigation { get; set; }
        [InverseProperty(nameof(TourPrices.EdituserNavigation))]
        public virtual ICollection<TourPrices> TourPricesEdituserNavigation { get; set; }
        [InverseProperty(nameof(TourProgram.AdduserNavigation))]
        public virtual ICollection<TourProgram> TourProgramAdduserNavigation { get; set; }
        [InverseProperty(nameof(TourProgram.EdituserNavigation))]
        public virtual ICollection<TourProgram> TourProgramEdituserNavigation { get; set; }
        [InverseProperty(nameof(TransferLocations.AdduserNavigation))]
        public virtual ICollection<TransferLocations> TransferLocationsAdduserNavigation { get; set; }
        [InverseProperty(nameof(TransferLocations.EdituserNavigation))]
        public virtual ICollection<TransferLocations> TransferLocationsEdituserNavigation { get; set; }
        [InverseProperty(nameof(TransferPrices.AdduserNavigation))]
        public virtual ICollection<TransferPrices> TransferPricesAdduserNavigation { get; set; }
        [InverseProperty(nameof(TransferPrices.EdituserNavigation))]
        public virtual ICollection<TransferPrices> TransferPricesEdituserNavigation { get; set; }
        [InverseProperty(nameof(TransferProviders.AdduserNavigation))]
        public virtual ICollection<TransferProviders> TransferProvidersAdduserNavigation { get; set; }
        [InverseProperty(nameof(TransferProviders.EdituserNavigation))]
        public virtual ICollection<TransferProviders> TransferProvidersEdituserNavigation { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<UserHistory> UserHistory { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<UserRoles> UserRoles { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<UsersCustomauth> UsersCustomauth { get; set; }
        [InverseProperty(nameof(Vehicletypes.AdduserNavigation))]
        public virtual ICollection<Vehicletypes> VehicletypesAdduserNavigation { get; set; }
        [InverseProperty(nameof(Vehicletypes.EdituserNavigation))]
        public virtual ICollection<Vehicletypes> VehicletypesEdituserNavigation { get; set; }
        [InverseProperty(nameof(VirtualPosAccountInstalments.AdduserNavigation))]
        public virtual ICollection<VirtualPosAccountInstalments> VirtualPosAccountInstalmentsAdduserNavigation { get; set; }
        [InverseProperty(nameof(VirtualPosAccountInstalments.EdituserNavigation))]
        public virtual ICollection<VirtualPosAccountInstalments> VirtualPosAccountInstalmentsEdituserNavigation { get; set; }
        [InverseProperty(nameof(VirtualPosAccounts.AdduserNavigation))]
        public virtual ICollection<VirtualPosAccounts> VirtualPosAccountsAdduserNavigation { get; set; }
        [InverseProperty(nameof(VirtualPosAccounts.EdituserNavigation))]
        public virtual ICollection<VirtualPosAccounts> VirtualPosAccountsEdituserNavigation { get; set; }
        [InverseProperty(nameof(VirtualPosDefaults.AdduserNavigation))]
        public virtual ICollection<VirtualPosDefaults> VirtualPosDefaultsAdduserNavigation { get; set; }
        [InverseProperty(nameof(VirtualPosDefaults.EdituserNavigation))]
        public virtual ICollection<VirtualPosDefaults> VirtualPosDefaultsEdituserNavigation { get; set; }
        [InverseProperty(nameof(VirtualPosDepPayments.AdduserNavigation))]
        public virtual ICollection<VirtualPosDepPayments> VirtualPosDepPaymentsAdduserNavigation { get; set; }
        [InverseProperty(nameof(VirtualPosDepPaymentsCancel.AdduserNavigation))]
        public virtual ICollection<VirtualPosDepPaymentsCancel> VirtualPosDepPaymentsCancelAdduserNavigation { get; set; }
        [InverseProperty(nameof(VirtualPosDepPaymentsCancel.EdituserNavigation))]
        public virtual ICollection<VirtualPosDepPaymentsCancel> VirtualPosDepPaymentsCancelEdituserNavigation { get; set; }
        [InverseProperty(nameof(VirtualPosDepPayments.EdituserNavigation))]
        public virtual ICollection<VirtualPosDepPayments> VirtualPosDepPaymentsEdituserNavigation { get; set; }
        [InverseProperty(nameof(VirtualPosPaymentEmails.AdduserNavigation))]
        public virtual ICollection<VirtualPosPaymentEmails> VirtualPosPaymentEmailsAdduserNavigation { get; set; }
        [InverseProperty(nameof(VirtualPosPaymentEmails.EdituserNavigation))]
        public virtual ICollection<VirtualPosPaymentEmails> VirtualPosPaymentEmailsEdituserNavigation { get; set; }
        [InverseProperty(nameof(VirtualPosPaymentMessageTemps.AdduserNavigation))]
        public virtual ICollection<VirtualPosPaymentMessageTemps> VirtualPosPaymentMessageTempsAdduserNavigation { get; set; }
        [InverseProperty(nameof(VirtualPosPaymentMessageTemps.EdituserNavigation))]
        public virtual ICollection<VirtualPosPaymentMessageTemps> VirtualPosPaymentMessageTempsEdituserNavigation { get; set; }
        [InverseProperty(nameof(VirtualPosPaymentRequests.AdduserNavigation))]
        public virtual ICollection<VirtualPosPaymentRequests> VirtualPosPaymentRequestsAdduserNavigation { get; set; }
        [InverseProperty(nameof(VirtualPosPaymentRequests.EdituserNavigation))]
        public virtual ICollection<VirtualPosPaymentRequests> VirtualPosPaymentRequestsEdituserNavigation { get; set; }
        [InverseProperty(nameof(VirtualPosPaymentRequestsNotes.AdduserNavigation))]
        public virtual ICollection<VirtualPosPaymentRequestsNotes> VirtualPosPaymentRequestsNotesAdduserNavigation { get; set; }
        [InverseProperty(nameof(VirtualPosPaymentRequestsNotes.EdituserNavigation))]
        public virtual ICollection<VirtualPosPaymentRequestsNotes> VirtualPosPaymentRequestsNotesEdituserNavigation { get; set; }
        [InverseProperty(nameof(VirtualPosPaymentTemps.AdduserNavigation))]
        public virtual ICollection<VirtualPosPaymentTemps> VirtualPosPaymentTempsAdduserNavigation { get; set; }
        [InverseProperty(nameof(VirtualPosPaymentTemps.EdituserNavigation))]
        public virtual ICollection<VirtualPosPaymentTemps> VirtualPosPaymentTempsEdituserNavigation { get; set; }
        [InverseProperty(nameof(VirtualPosPaymentVposes.AdduserNavigation))]
        public virtual ICollection<VirtualPosPaymentVposes> VirtualPosPaymentVposesAdduserNavigation { get; set; }
        [InverseProperty(nameof(VirtualPosPaymentVposes.EdituserNavigation))]
        public virtual ICollection<VirtualPosPaymentVposes> VirtualPosPaymentVposesEdituserNavigation { get; set; }
        [InverseProperty(nameof(VirtualPosPayments.AdduserNavigation))]
        public virtual ICollection<VirtualPosPayments> VirtualPosPaymentsAdduserNavigation { get; set; }
        [InverseProperty(nameof(VirtualPosPayments.EdituserNavigation))]
        public virtual ICollection<VirtualPosPayments> VirtualPosPaymentsEdituserNavigation { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
