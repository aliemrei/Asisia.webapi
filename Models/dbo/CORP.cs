using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class CORP : EntityBase // My Handlebars Helper
    {
        public CORP()
        {
            AGENCY = new HashSet<AGENCY>();
            AGENCY_GROUP = new HashSet<AGENCY_GROUP>();
            BONUS_DEF = new HashSet<BONUS_DEF>();
            CALL_JOBS = new HashSet<CALL_JOBS>();
            CAMPAIGNS = new HashSet<CAMPAIGNS>();
            CASHIER_HANDOVER = new HashSet<CASHIER_HANDOVER>();
            CONTACT_CATEGORY = new HashSet<CONTACT_CATEGORY>();
            CONTACT_FORM = new HashSet<CONTACT_FORM>();
            CRM_CARDGROUPS = new HashSet<CRM_CARDGROUPS>();
            CURRATE = new HashSet<CURRATE>();
            PAYMENTS = new HashSet<PAYMENTS>();
            PAYMENT_EMAILS = new HashSet<PAYMENT_EMAILS>();
            PERSON = new HashSet<PERSON>();
            PERSON_BONUS_TYPES = new HashSet<PERSON_BONUS_TYPES>();
            PERSON_GROUP = new HashSet<PERSON_GROUP>();
            PORTAL = new HashSet<PORTAL>();
            PROJECT_GROUP = new HashSet<PROJECT_GROUP>();
            PROMOTION_CODES = new HashSet<PROMOTION_CODES>();
            PROPERTY_PROVIDERS = new HashSet<PROPERTY_PROVIDERS>();
            REQUEST = new HashSet<REQUEST>();
            RESERVATION_EMAILS = new HashSet<RESERVATION_EMAILS>();
            RESOURCES = new HashSet<RESOURCES>();
            RESOURCE_DETAIL = new HashSet<RESOURCE_DETAIL>();
            ROLES = new HashSet<ROLES>();
            SMS_SETTINGS = new HashSet<SMS_SETTINGS>();
            SMTP_SETTINGS = new HashSet<SMTP_SETTINGS>();
            STDHOTEL = new HashSet<STDHOTEL>();
            STDHOTEL_PRICECONDITION = new HashSet<STDHOTEL_PRICECONDITION>();
            STDHOTEL_RATECODE = new HashSet<STDHOTEL_RATECODE>();
            STDHOTEL_ROOMTYPES_AVAILABILITY = new HashSet<STDHOTEL_ROOMTYPES_AVAILABILITY>();
            STDHOTEL_STOPSALE = new HashSet<STDHOTEL_STOPSALE>();
            STDMARKETS = new HashSet<STDMARKETS>();
            STDSTORE = new HashSet<STDSTORE>();
            STD_PARAMS = new HashSet<STD_PARAMS>();
            SURVEY = new HashSet<SURVEY>();
            TICKET = new HashSet<TICKET>();
            TICKET_GIFTS = new HashSet<TICKET_GIFTS>();
            TICKET_MARKET = new HashSet<TICKET_MARKET>();
            TOUR = new HashSet<TOUR>();
            TRANSFER_LOCATIONS = new HashSet<TRANSFER_LOCATIONS>();
            TRANSFER_PRICES = new HashSet<TRANSFER_PRICES>();
            TRANSFER_PROVIDERS = new HashSet<TRANSFER_PROVIDERS>();
            TURNIKE = new HashSet<TURNIKE>();
            USERS = new HashSet<USERS>();
            VEHICLETYPES = new HashSet<VEHICLETYPES>();
            VIRTUAL_POS = new HashSet<VIRTUAL_POS>();
            VIRTUAL_POS_ACCOUNTS = new HashSet<VIRTUAL_POS_ACCOUNTS>();
            VIRTUAL_POS_DEFAULTS = new HashSet<VIRTUAL_POS_DEFAULTS>();
            VIRTUAL_POS_PAYMENTS = new HashSet<VIRTUAL_POS_PAYMENTS>();
            VIRTUAL_POS_PAYMENT_MESSAGE_TEMPS = new HashSet<VIRTUAL_POS_PAYMENT_MESSAGE_TEMPS>();
            VIRTUAL_POS_PAYMENT_REQUESTS = new HashSet<VIRTUAL_POS_PAYMENT_REQUESTS>();
            VIRTUAL_POS_PAYMENT_TEMPS = new HashSet<VIRTUAL_POS_PAYMENT_TEMPS>();
        }

        public Guid ID { get; set; }
        public int INTID { get; set; }
        public string? NAME { get; set; }
        public Guid? ADDRESSID { get; set; }
        public long? TEL1 { get; set; }
        public long? TEL2 { get; set; }
        public string? EMAIL { get; set; }
        public int? FAX { get; set; }
        public bool ISDELETED { get; set; }
        public bool ISDISABLED { get; set; }
        public Guid? ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public string? CONTACT { get; set; }
        public string? TAXAUTH { get; set; }
        public string? TAXNO { get; set; }
        public string? GA_CUSTOMERID { get; set; }
        public Guid? AUTO_RESMAIL_CLIENT { get; set; }
        public Guid? AUTO_RESMAIL_HOST { get; set; }
        public Guid? AUTO_PASSWORD_FORGET { get; set; }
        public Guid? SWITCHBOARDID { get; set; }

        public virtual LOCATION_ADDRESS? ADDRESS { get; set; }
        public virtual USERS? ADDUSERNavigation { get; set; }
        public virtual REPORTS? AUTO_PASSWORD_FORGETNavigation { get; set; }
        public virtual REPORTS? AUTO_RESMAIL_CLIENTNavigation { get; set; }
        public virtual REPORTS? AUTO_RESMAIL_HOSTNavigation { get; set; }
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual ICollection<AGENCY> AGENCY { get; set; }
        public virtual ICollection<AGENCY_GROUP> AGENCY_GROUP { get; set; }
        public virtual ICollection<BONUS_DEF> BONUS_DEF { get; set; }
        public virtual ICollection<CALL_JOBS> CALL_JOBS { get; set; }
        public virtual ICollection<CAMPAIGNS> CAMPAIGNS { get; set; }
        public virtual ICollection<CASHIER_HANDOVER> CASHIER_HANDOVER { get; set; }
        public virtual ICollection<CONTACT_CATEGORY> CONTACT_CATEGORY { get; set; }
        public virtual ICollection<CONTACT_FORM> CONTACT_FORM { get; set; }
        public virtual ICollection<CRM_CARDGROUPS> CRM_CARDGROUPS { get; set; }
        public virtual ICollection<CURRATE> CURRATE { get; set; }
        public virtual ICollection<PAYMENTS> PAYMENTS { get; set; }
        public virtual ICollection<PAYMENT_EMAILS> PAYMENT_EMAILS { get; set; }
        public virtual ICollection<PERSON> PERSON { get; set; }
        public virtual ICollection<PERSON_BONUS_TYPES> PERSON_BONUS_TYPES { get; set; }
        public virtual ICollection<PERSON_GROUP> PERSON_GROUP { get; set; }
        public virtual ICollection<PORTAL> PORTAL { get; set; }
        public virtual ICollection<PROJECT_GROUP> PROJECT_GROUP { get; set; }
        public virtual ICollection<PROMOTION_CODES> PROMOTION_CODES { get; set; }
        public virtual ICollection<PROPERTY_PROVIDERS> PROPERTY_PROVIDERS { get; set; }
        public virtual ICollection<REQUEST> REQUEST { get; set; }
        public virtual ICollection<RESERVATION_EMAILS> RESERVATION_EMAILS { get; set; }
        public virtual ICollection<RESOURCES> RESOURCES { get; set; }
        public virtual ICollection<RESOURCE_DETAIL> RESOURCE_DETAIL { get; set; }
        public virtual ICollection<ROLES> ROLES { get; set; }
        public virtual ICollection<SMS_SETTINGS> SMS_SETTINGS { get; set; }
        public virtual ICollection<SMTP_SETTINGS> SMTP_SETTINGS { get; set; }
        public virtual ICollection<STDHOTEL> STDHOTEL { get; set; }
        public virtual ICollection<STDHOTEL_PRICECONDITION> STDHOTEL_PRICECONDITION { get; set; }
        public virtual ICollection<STDHOTEL_RATECODE> STDHOTEL_RATECODE { get; set; }
        public virtual ICollection<STDHOTEL_ROOMTYPES_AVAILABILITY> STDHOTEL_ROOMTYPES_AVAILABILITY { get; set; }
        public virtual ICollection<STDHOTEL_STOPSALE> STDHOTEL_STOPSALE { get; set; }
        public virtual ICollection<STDMARKETS> STDMARKETS { get; set; }
        public virtual ICollection<STDSTORE> STDSTORE { get; set; }
        public virtual ICollection<STD_PARAMS> STD_PARAMS { get; set; }
        public virtual ICollection<SURVEY> SURVEY { get; set; }
        public virtual ICollection<TICKET> TICKET { get; set; }
        public virtual ICollection<TICKET_GIFTS> TICKET_GIFTS { get; set; }
        public virtual ICollection<TICKET_MARKET> TICKET_MARKET { get; set; }
        public virtual ICollection<TOUR> TOUR { get; set; }
        public virtual ICollection<TRANSFER_LOCATIONS> TRANSFER_LOCATIONS { get; set; }
        public virtual ICollection<TRANSFER_PRICES> TRANSFER_PRICES { get; set; }
        public virtual ICollection<TRANSFER_PROVIDERS> TRANSFER_PROVIDERS { get; set; }
        public virtual ICollection<TURNIKE> TURNIKE { get; set; }
        public virtual ICollection<USERS> USERS { get; set; }
        public virtual ICollection<VEHICLETYPES> VEHICLETYPES { get; set; }
        public virtual ICollection<VIRTUAL_POS> VIRTUAL_POS { get; set; }
        public virtual ICollection<VIRTUAL_POS_ACCOUNTS> VIRTUAL_POS_ACCOUNTS { get; set; }
        public virtual ICollection<VIRTUAL_POS_DEFAULTS> VIRTUAL_POS_DEFAULTS { get; set; }
        public virtual ICollection<VIRTUAL_POS_PAYMENTS> VIRTUAL_POS_PAYMENTS { get; set; }
        public virtual ICollection<VIRTUAL_POS_PAYMENT_MESSAGE_TEMPS> VIRTUAL_POS_PAYMENT_MESSAGE_TEMPS { get; set; }
        public virtual ICollection<VIRTUAL_POS_PAYMENT_REQUESTS> VIRTUAL_POS_PAYMENT_REQUESTS { get; set; }
        public virtual ICollection<VIRTUAL_POS_PAYMENT_TEMPS> VIRTUAL_POS_PAYMENT_TEMPS { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
