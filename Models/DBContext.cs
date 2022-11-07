using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata; // Comment
using Asisia.webapi.Models;

namespace Asisia.webapi.Models
{ // Comment
    public partial class DBContext : DbContext
    {
        // My Handlebars Helper
        public virtual DbSet<dbo.AGENCY> AGENCY { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.AGENCY_GROUP> AGENCY_GROUP { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.AuditLogs> AuditLogs { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.BASKET_DATA> BASKET_DATA { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.BONUS_DEF> BONUS_DEF { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.BONUS_DEF_ITEMS> BONUS_DEF_ITEMS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.BONUS_DEF_PRICES> BONUS_DEF_PRICES { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.BONUS_DEF_USERS> BONUS_DEF_USERS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.CALENDAR> CALENDAR { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.CALL_JOBS> CALL_JOBS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.CALL_LIST> CALL_LIST { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.CAMPAIGNS> CAMPAIGNS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.CASHIER_HANDOVER> CASHIER_HANDOVER { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.CASHIER_HANDOVER_ENTITY> CASHIER_HANDOVER_ENTITY { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.CITY> CITY { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.CONTACT_CATEGORY> CONTACT_CATEGORY { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.CONTACT_FORM> CONTACT_FORM { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.CORP> CORP { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.COUNTRY> COUNTRY { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.CRM_CARDGROUPS> CRM_CARDGROUPS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.CRM_CARDTYPES> CRM_CARDTYPES { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.CURCODE> CURCODE { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.CURRATE> CURRATE { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.DASHBOARD> DASHBOARD { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.DASHBOARD_ITEM> DASHBOARD_ITEM { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.DASHBOARD_ITEM_YDK> DASHBOARD_ITEM_YDK { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.DASHBOARD_YDK> DASHBOARD_YDK { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.DATA_DICTIONARY> DATA_DICTIONARY { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.DB_LOG> DB_LOG { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.DISTRICT> DISTRICT { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.ENTEGRATION_SETTINGS> ENTEGRATION_SETTINGS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.HOTEL_RESERVATIONS> HOTEL_RESERVATIONS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.HOTEL_RESERVATION_DETAILS> HOTEL_RESERVATION_DETAILS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.INTEGRATION_ERRORS> INTEGRATION_ERRORS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.LOCATION_ADDRESS> LOCATION_ADDRESS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.MAIL_CONTENTS> MAIL_CONTENTS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.PAYMENTS> PAYMENTS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.PAYMENT_EMAILS> PAYMENT_EMAILS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.PERSON> PERSON { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.PERSON_ADDRESS> PERSON_ADDRESS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.PERSON_BONUS> PERSON_BONUS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.PERSON_BONUS_TYPES> PERSON_BONUS_TYPES { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.PERSON_CCARDS> PERSON_CCARDS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.PERSON_GROUP> PERSON_GROUP { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.PORTAL> PORTAL { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.PORTAL_AUTH_IPADDRESS> PORTAL_AUTH_IPADDRESS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.PORTAL_CATEGORIES> PORTAL_CATEGORIES { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.PORTAL_CATEGORY_IMAGES> PORTAL_CATEGORY_IMAGES { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.PORTAL_CATEGORY_ITEMS> PORTAL_CATEGORY_ITEMS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.PORTAL_CURRENCIES> PORTAL_CURRENCIES { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.PORTAL_DESCRIPTION> PORTAL_DESCRIPTION { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.PORTAL_DOMAINS> PORTAL_DOMAINS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.PORTAL_EMAILS> PORTAL_EMAILS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.PORTAL_LANGDICTIONARY> PORTAL_LANGDICTIONARY { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.PORTAL_LANGUAGES> PORTAL_LANGUAGES { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.PORTAL_SEO> PORTAL_SEO { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.PORTAL_SETTINGS> PORTAL_SETTINGS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.PORTAL_URLREWRITE> PORTAL_URLREWRITE { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.PORTAL_USER> PORTAL_USER { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.PORTAL_USER_SOCIALACCOUNT> PORTAL_USER_SOCIALACCOUNT { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.PROJECT_GROUP> PROJECT_GROUP { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.PROJECT_GROUPDETAIL> PROJECT_GROUPDETAIL { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.PROJECT_GROUPDETAIL_BANKDEP> PROJECT_GROUPDETAIL_BANKDEP { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.PROJECT_GROUPDETAIL_SEO> PROJECT_GROUPDETAIL_SEO { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.PROJECT_GROUPDETAIL_VPOS> PROJECT_GROUPDETAIL_VPOS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.PROMOTION_CODES> PROMOTION_CODES { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.PROMOTION_CODES_MARKET> PROMOTION_CODES_MARKET { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.PROMOTION_CODES_ROOMTYPE> PROMOTION_CODES_ROOMTYPE { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.PROPERTY_MAPPING> PROPERTY_MAPPING { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.PROPERTY_PROVIDERS> PROPERTY_PROVIDERS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.REPORTS> REPORTS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.REQUEST> REQUEST { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.REQUEST_CLIENTS> REQUEST_CLIENTS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.REQUEST_DETAIL> REQUEST_DETAIL { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.REQUEST_DETAIL_ORGDATA> REQUEST_DETAIL_ORGDATA { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.REQUEST_NOTES> REQUEST_NOTES { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.REQUEST_PAYMENTS> REQUEST_PAYMENTS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.REQUEST_STATUS> REQUEST_STATUS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.REQUEST_YDK> REQUEST_YDK { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.RESERVATION_EMAILS> RESERVATION_EMAILS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.RESERVATION_RULES> RESERVATION_RULES { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.RESERVATION_SETTINGS> RESERVATION_SETTINGS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.RESERVATION_SETTINGS_MARKET> RESERVATION_SETTINGS_MARKET { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.RESOURCES> RESOURCES { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.RESOURCE_BUDGET> RESOURCE_BUDGET { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.RESOURCE_DETAIL> RESOURCE_DETAIL { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.ROLES> ROLES { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.ROLES_CUSTOMAUTH> ROLES_CUSTOMAUTH { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.ROLES_DASHBOARDS> ROLES_DASHBOARDS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.ROLE_AUTH> ROLE_AUTH { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.SALES_REQ> SALES_REQ { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.SIL> SIL { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.SMS_MESSAGE> SMS_MESSAGE { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.SMS_SETTINGS> SMS_SETTINGS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.SMTP_MAILS> SMTP_MAILS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.SMTP_SETTINGS> SMTP_SETTINGS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.SNT_AGENT_STATUS> SNT_AGENT_STATUS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.SNT_CALLBACK_IGNORES> SNT_CALLBACK_IGNORES { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.SNT_CALLS> SNT_CALLS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.SNT_CALL_DETAIL> SNT_CALL_DETAIL { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.SNT_CALL_JOBS> SNT_CALL_JOBS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.SNT_CALL_LIST> SNT_CALL_LIST { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.SNT_CALL_LIST_ORG> SNT_CALL_LIST_ORG { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.SNT_CALL_STATUS> SNT_CALL_STATUS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.SNT_CALL_SUMMARY> SNT_CALL_SUMMARY { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.SNT_CALL_TOTALS> SNT_CALL_TOTALS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.SNT_CDR> SNT_CDR { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.SNT_CDR_REPORT> SNT_CDR_REPORT { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.SNT_DBS> SNT_DBS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.SNT_DIAGRAM> SNT_DIAGRAM { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.SNT_DIAGRAM_CHILDKEYS> SNT_DIAGRAM_CHILDKEYS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.SNT_DIAGRAM_SHAPES> SNT_DIAGRAM_SHAPES { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.SNT_DIAL_PLAN> SNT_DIAL_PLAN { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.SNT_LANGUAGE_COUNTRIES> SNT_LANGUAGE_COUNTRIES { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.SNT_MISSEDCALLS> SNT_MISSEDCALLS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.SNT_MISSEDCALLS_ALL> SNT_MISSEDCALLS_ALL { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.SNT_QUEUES> SNT_QUEUES { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.SNT_QUEUE_ABANDON> SNT_QUEUE_ABANDON { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.SNT_QUEUE_LOG> SNT_QUEUE_LOG { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.SNT_QUEUE_MEMBERS> SNT_QUEUE_MEMBERS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.SNT_REPORT> SNT_REPORT { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.SNT_RT_SIPPEERS> SNT_RT_SIPPEERS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.SNT_SIPPEERS> SNT_SIPPEERS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.SNT_SWITCHBOARD> SNT_SWITCHBOARD { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDBOARDTYPES> STDBOARDTYPES { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDHOTEL> STDHOTEL { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDHOTELDISCOUNT> STDHOTELDISCOUNT { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDHOTEL_ANNOUNCEMENT> STDHOTEL_ANNOUNCEMENT { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDHOTEL_BOARDTYPES> STDHOTEL_BOARDTYPES { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDHOTEL_DESCRIPTIONS> STDHOTEL_DESCRIPTIONS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDHOTEL_EXTRAS> STDHOTEL_EXTRAS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDHOTEL_FECILITIES> STDHOTEL_FECILITIES { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDHOTEL_IMAGES> STDHOTEL_IMAGES { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDHOTEL_MARKET> STDHOTEL_MARKET { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDHOTEL_MARKET_COUNTRY> STDHOTEL_MARKET_COUNTRY { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDHOTEL_PRICECONDITION> STDHOTEL_PRICECONDITION { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDHOTEL_PRICECONDITION_CALENDAR> STDHOTEL_PRICECONDITION_CALENDAR { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDHOTEL_PRICECONDITION_OCCUPANCY> STDHOTEL_PRICECONDITION_OCCUPANCY { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDHOTEL_RATECODE> STDHOTEL_RATECODE { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDHOTEL_RATECODE_DETAIL> STDHOTEL_RATECODE_DETAIL { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDHOTEL_RATECODE_DETAIL_AGENCYGROUPS> STDHOTEL_RATECODE_DETAIL_AGENCYGROUPS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDHOTEL_RATECODE_DETAIL_OCCUPANCY> STDHOTEL_RATECODE_DETAIL_OCCUPANCY { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDHOTEL_RATECODE_DISCOUNT> STDHOTEL_RATECODE_DISCOUNT { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDHOTEL_RATECODE_DISCOUNT_CONTRACT> STDHOTEL_RATECODE_DISCOUNT_CONTRACT { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDHOTEL_RATECODE_DISCOUNT_DISCOUNT> STDHOTEL_RATECODE_DISCOUNT_DISCOUNT { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDHOTEL_RATECODE_DISCOUNT_MARKET> STDHOTEL_RATECODE_DISCOUNT_MARKET { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDHOTEL_RATECODE_DISCOUNT_RATETYPE> STDHOTEL_RATECODE_DISCOUNT_RATETYPE { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDHOTEL_RATECODE_DISCOUNT_ROOMTYPE> STDHOTEL_RATECODE_DISCOUNT_ROOMTYPE { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDHOTEL_RATECODE_MARKUP> STDHOTEL_RATECODE_MARKUP { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDHOTEL_RATECODE_MARKUP_MARKETS> STDHOTEL_RATECODE_MARKUP_MARKETS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDHOTEL_RATECODE_MARKUP_ROOMTYPE> STDHOTEL_RATECODE_MARKUP_ROOMTYPE { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDHOTEL_RATETYPE> STDHOTEL_RATETYPE { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDHOTEL_RATETYPES_AVAILABILITY> STDHOTEL_RATETYPES_AVAILABILITY { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDHOTEL_ROOMTYPES> STDHOTEL_ROOMTYPES { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDHOTEL_ROOMTYPES_AVAILABILITY> STDHOTEL_ROOMTYPES_AVAILABILITY { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDHOTEL_SEASONS> STDHOTEL_SEASONS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDHOTEL_STOPSALE> STDHOTEL_STOPSALE { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDLANGUAGES> STDLANGUAGES { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDMARKETS> STDMARKETS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDMARKET_COUNTRIES> STDMARKET_COUNTRIES { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDROOMTYPES> STDROOMTYPES { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDSTORE> STDSTORE { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDSTORE_ITEMS> STDSTORE_ITEMS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDSTORE_ITEMS_GROUPS> STDSTORE_ITEMS_GROUPS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDSTORE_ITEM_GROUPS> STDSTORE_ITEM_GROUPS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDSTORE_ITEM_GROUP_ITEMS> STDSTORE_ITEM_GROUP_ITEMS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDSTORE_ITEM_IMAGES> STDSTORE_ITEM_IMAGES { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDSTORE_ITEM_INGREDIENTS> STDSTORE_ITEM_INGREDIENTS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDSTORE_ITEM_PRICES> STDSTORE_ITEM_PRICES { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDSTORE_ITEM_PRICES_INGREDIENTS> STDSTORE_ITEM_PRICES_INGREDIENTS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDSTORE_ITEM_SIZES> STDSTORE_ITEM_SIZES { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STDVEHICLETYPES> STDVEHICLETYPES { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.STD_PARAMS> STD_PARAMS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.SURVEY> SURVEY { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.SURVEYS> SURVEYS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.SURVEY_ANSWEROPTIONS> SURVEY_ANSWEROPTIONS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.SURVEY_ANSWERS> SURVEY_ANSWERS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.SWICTHBOARD_LOG> SWICTHBOARD_LOG { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.TICKET> TICKET { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.TICKET_ACTIVATIONS> TICKET_ACTIVATIONS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.TICKET_GIFTS> TICKET_GIFTS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.TICKET_HOURS> TICKET_HOURS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.TICKET_MARKET> TICKET_MARKET { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.TICKET_PRICES> TICKET_PRICES { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.TILE_ITEMOPTION> TILE_ITEMOPTION { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.TOUR> TOUR { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.TOURDISCOUNT> TOURDISCOUNT { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.TOUR_DISCOUNTS> TOUR_DISCOUNTS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.TOUR_IMAGES> TOUR_IMAGES { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.TOUR_PRICES> TOUR_PRICES { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.TOUR_PROGRAM> TOUR_PROGRAM { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.TRANSFER_LOCATIONS> TRANSFER_LOCATIONS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.TRANSFER_PRICES> TRANSFER_PRICES { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.TRANSFER_PROVIDERS> TRANSFER_PROVIDERS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.TURNIKE> TURNIKE { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.USERS> USERS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.USERS_CUSTOMAUTH> USERS_CUSTOMAUTH { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.USER_HISTORY> USER_HISTORY { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.USER_PROJECTS> USER_PROJECTS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.USER_PROJECT_DETAILS> USER_PROJECT_DETAILS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.USER_ROLES> USER_ROLES { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.USER_ROLE_REQUEST_STATUS> USER_ROLE_REQUEST_STATUS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.VEHICLETYPES> VEHICLETYPES { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.VIRTUAL_POS> VIRTUAL_POS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.VIRTUAL_POSBINNAMES> VIRTUAL_POSBINNAMES { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.VIRTUAL_POS_ACCOUNTS> VIRTUAL_POS_ACCOUNTS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.VIRTUAL_POS_ACCOUNTS_CURCODES> VIRTUAL_POS_ACCOUNTS_CURCODES { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.VIRTUAL_POS_ACCOUNT_INSTALMENTS> VIRTUAL_POS_ACCOUNT_INSTALMENTS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.VIRTUAL_POS_BINNUMBERS> VIRTUAL_POS_BINNUMBERS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.VIRTUAL_POS_DEFAULTS> VIRTUAL_POS_DEFAULTS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.VIRTUAL_POS_DEP_ACCOUNTS> VIRTUAL_POS_DEP_ACCOUNTS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.VIRTUAL_POS_DEP_PAYMENTS> VIRTUAL_POS_DEP_PAYMENTS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.VIRTUAL_POS_DEP_PAYMENTS_CANCEL> VIRTUAL_POS_DEP_PAYMENTS_CANCEL { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.VIRTUAL_POS_PAYMENTS> VIRTUAL_POS_PAYMENTS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.VIRTUAL_POS_PAYMENTS_CANCEL> VIRTUAL_POS_PAYMENTS_CANCEL { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.VIRTUAL_POS_PAYMENT_EMAILS> VIRTUAL_POS_PAYMENT_EMAILS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.VIRTUAL_POS_PAYMENT_MESSAGE_TEMPS> VIRTUAL_POS_PAYMENT_MESSAGE_TEMPS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.VIRTUAL_POS_PAYMENT_REQUESTS> VIRTUAL_POS_PAYMENT_REQUESTS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.VIRTUAL_POS_PAYMENT_REQUESTS_NOTES> VIRTUAL_POS_PAYMENT_REQUESTS_NOTES { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.VIRTUAL_POS_PAYMENT_TEMPS> VIRTUAL_POS_PAYMENT_TEMPS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.VIRTUAL_POS_PAYMENT_VPOSES> VIRTUAL_POS_PAYMENT_VPOSES { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.VIRTUAL_POS_SWAP> VIRTUAL_POS_SWAP { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.VW_BASKET_INFO> VW_BASKET_INFO { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.VW_BASKET_PAYMENTS> VW_BASKET_PAYMENTS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.VW_CALLJOB_REASONS> VW_CALLJOB_REASONS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.VW_CALL_JOBS> VW_CALL_JOBS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.VW_CAMPAIGNS> VW_CAMPAIGNS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.VW_HOTEL_MARKET_COUNTRY> VW_HOTEL_MARKET_COUNTRY { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.VW_IPCOUNTRYCODES> VW_IPCOUNTRYCODES { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.VW_IPLOCATIONS> VW_IPLOCATIONS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.VW_LOCATIONS> VW_LOCATIONS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.VW_MOB_PAYMENT_REPORT> VW_MOB_PAYMENT_REPORT { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.VW_PRODUCTS> VW_PRODUCTS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.VW_PROJECT_GROUP> VW_PROJECT_GROUP { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.VW_PROMOTION_CODES> VW_PROMOTION_CODES { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.VW_REQUEST_PAYMENTS> VW_REQUEST_PAYMENTS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.VW_REQUEST_PAYMENT_CANCELS> VW_REQUEST_PAYMENT_CANCELS { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.VW_SALES> VW_SALES { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.VW_SALES_ALL> VW_SALES_ALL { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.VW_SALES_REPORT> VW_SALES_REPORT { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.VW_SALES_REPORT_ALL> VW_SALES_REPORT_ALL { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.VW_SALES_REPORT_WITH_RESOURCEPATH> VW_SALES_REPORT_WITH_RESOURCEPATH { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.VW_STDHOTEL_DISCOUNT_TYPES> VW_STDHOTEL_DISCOUNT_TYPES { get; set; } = null!;
        // My Handlebars Helper
        public virtual DbSet<dbo.VW_STDHOTEL_RATECODE_DISCOUNT_DISCOUNT> VW_STDHOTEL_RATECODE_DISCOUNT_DISCOUNT { get; set; } = null!;

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
            modelBuilder.Entity<dbo.AGENCY>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__AGENCY__3214EC26C02849A1")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.CORPID, e.FULLNAME, e.ISDELETED }, "UQ__AGENCY__E0A4B5DC409567EB")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DEFAULT_CURCODE)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.EMAIL).HasMaxLength(200);

                entity.Property(e => e.FULLNAME).HasMaxLength(250);

                entity.Property(e => e.INTID).ValueGeneratedOnAdd();

                entity.Property(e => e.PAYMENT_RATE).HasDefaultValueSql("((100))");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.AGENCYADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AGENCY__ADDUSER__414EAC47");

                entity.HasOne(d => d.AUTHORIZED)
                    .WithMany(p => p.AGENCY)
                    .HasForeignKey(d => d.AUTHORIZEDID)
                    .HasConstraintName("FK__AGENCY__AUTHORIZ__4242D080");

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.AGENCY)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AGENCY__CORPID__4336F4B9");

                entity.HasOne(d => d.DEFAULT_CURCODENavigation)
                    .WithMany(p => p.AGENCY)
                    .HasForeignKey(d => d.DEFAULT_CURCODE)
                    .HasConstraintName("FK__AGENCY__DEFAULT___10422BEF");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.AGENCYEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__AGENCY__EDITUSER__442B18F2");

                entity.HasOne(d => d.GROUP)
                    .WithMany(p => p.AGENCY)
                    .HasForeignKey(d => d.GROUPID)
                    .HasConstraintName("FK__AGENCY__GROUPID__689E4EE9");
            });

            modelBuilder.Entity<dbo.AGENCY_GROUP>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__AGENCY_G__3214EC26B8FF14FD")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.CORPID, e.GROUPNAME }, "UQ__AGENCY_G__13040B821987821B")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.GROUPNAME).HasMaxLength(200);

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.AGENCY_GROUPADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AGENCY_GR__ADDUS__65C1E23E");

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.AGENCY_GROUP)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AGENCY_GR__CORPI__64CDBE05");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.AGENCY_GROUPEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__AGENCY_GR__EDITU__67AA2AB0");
            });

            modelBuilder.Entity<dbo.AuditLogs>(entity =>
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

            modelBuilder.Entity<dbo.BASKET_DATA>(entity =>
            {
                entity.Property(e => e.DATA).HasColumnType("ntext");

                entity.HasOne(d => d.REQUEST)
                    .WithMany(p => p.BASKET_DATA)
                    .HasForeignKey(d => d.REQUESTID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__BASKET_DA__REQUE__0F231F2D");
            });

            modelBuilder.Entity<dbo.BONUS_DEF>(entity =>
            {
                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CURCODE)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('TRY')")
                    .IsFixedLength();

                entity.Property(e => e.DEFINITION).HasMaxLength(100);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.FIRST_DATE).HasColumnType("datetime");

                entity.Property(e => e.LAST_DATE).HasColumnType("datetime");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.BONUS_DEFADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .HasConstraintName("FK__BONUS_DEF__ADDUS__42D7CD5D");

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.BONUS_DEF)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BONUS_DEF__CORPI__0856260D");

                entity.HasOne(d => d.CURCODENavigation)
                    .WithMany(p => p.BONUS_DEF)
                    .HasForeignKey(d => d.CURCODE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BONUS_DEF_CURCODE");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.BONUS_DEFEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__BONUS_DEF__EDITU__43CBF196");

                entity.HasOne(d => d.PROJECT_GROUP)
                    .WithMany(p => p.BONUS_DEF)
                    .HasForeignKey(d => d.PROJECT_GROUPID)
                    .HasConstraintName("FK__BONUS_DEF__PROJE__30EE274C");
            });

            modelBuilder.Entity<dbo.BONUS_DEF_ITEMS>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__BONUS_DE__3214EC265B6D78FC")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.BONUS_DEF_ITEMSADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .HasConstraintName("FK__BONUS_DEF__ADDUS__45B43A08");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.BONUS_DEF_ITEMSEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__BONUS_DEF__EDITU__46A85E41");
            });

            modelBuilder.Entity<dbo.BONUS_DEF_PRICES>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__BONUS_DE__3214EC26EFA5C371")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.BONUS_DEF_PRICESADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BONUS_DEF__ADDUS__3FFB60B2");

                entity.HasOne(d => d.BONUS_DEF_ITEMS)
                    .WithMany(p => p.BONUS_DEF_PRICES)
                    .HasForeignKey(d => d.BONUS_DEF_ITEMSID)
                    .HasConstraintName("FK__BONUS_DEF__BONUS__3E131840");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.BONUS_DEF_PRICESEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__BONUS_DEF__EDITU__40EF84EB");
            });

            modelBuilder.Entity<dbo.BONUS_DEF_USERS>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__BONUS_DE__3214EC26AC720DE4")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.USER)
                    .WithMany(p => p.BONUS_DEF_USERS)
                    .HasForeignKey(d => d.USERID)
                    .HasConstraintName("FK__BONUS_DEF__USERI__2BF46805");
            });

            modelBuilder.Entity<dbo.CALENDAR>(entity =>
            {
                entity.HasKey(e => e.DATE)
                    .HasName("PK__CALENDAR__1F7C70C4BA479CA1");

                entity.Property(e => e.DATE).HasColumnType("date");
            });

            modelBuilder.Entity<dbo.CALL_JOBS>(entity =>
            {
                entity.HasIndex(e => e.ADDDATE, "IX_CALL_JOBS");

                entity.HasIndex(e => new { e.ISDELETED, e.ISDISABLED }, "IX_CALL_JOBS_1");

                entity.HasIndex(e => new { e.REASON, e.RESULT }, "IX_CALL_JOBS_2");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CALLDATE).HasColumnType("datetime");

                entity.Property(e => e.CAMPAIGNCODE)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.ENT_ID).HasMaxLength(25);

                entity.Property(e => e.FIRSTNAME).HasMaxLength(70);

                entity.Property(e => e.FULLNAME).HasMaxLength(200);

                entity.Property(e => e.KIND)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('J')")
                    .IsFixedLength();

                entity.Property(e => e.LASTNAME).HasMaxLength(70);

                entity.Property(e => e.OUTPUT_EXTEN).HasMaxLength(150);

                entity.Property(e => e.PRIORITY).HasDefaultValueSql("((5))");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.CALL_JOBSADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CALL_JOBS__ADDUS__62E4AA3C");

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.CALL_JOBS)
                    .HasForeignKey(d => d.CORPID)
                    .HasConstraintName("FK__CALL_JOBS__CORPI__2AAB3E11");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.CALL_JOBSEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__CALL_JOBS__EDITU__64CCF2AE");

                entity.HasOne(d => d.PERSON)
                    .WithMany(p => p.CALL_JOBS)
                    .HasForeignKey(d => d.PERSONID)
                    .HasConstraintName("FK__CALL_JOBS__PERSO__60083D91");

                entity.HasOne(d => d.PROJECT_DETAIL)
                    .WithMany(p => p.CALL_JOBS)
                    .HasForeignKey(d => d.PROJECT_DETAILID)
                    .HasConstraintName("FK__CALL_JOBS__PROJE__116B5A52");

                entity.HasOne(d => d.PROJECT_GROUP)
                    .WithMany(p => p.CALL_JOBS)
                    .HasForeignKey(d => d.PROJECT_GROUPID)
                    .HasConstraintName("FK__CALL_JOBS__PROJE__10773619");

                entity.HasOne(d => d.REQUEST)
                    .WithMany(p => p.CALL_JOBS)
                    .HasForeignKey(d => d.REQUESTID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__CALL_JOBS__REQUE__5F141958");

                entity.HasOne(d => d.USER)
                    .WithMany(p => p.CALL_JOBSUSER)
                    .HasForeignKey(d => d.USERID)
                    .HasConstraintName("FK_CALL_JOBS_USERS");
            });

            modelBuilder.Entity<dbo.CALL_LIST>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CALL_LIST");

                entity.Property(e => e.CALLID).HasMaxLength(32);

                entity.Property(e => e.CALLTIME).HasColumnType("datetime");

                entity.Property(e => e.ID).ValueGeneratedOnAdd();

                entity.Property(e => e.KIND)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OUTPUT_EXTEN).HasMaxLength(150);

                entity.Property(e => e.PHONENUMBER).HasMaxLength(50);

                entity.Property(e => e.SDATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<dbo.CAMPAIGNS>(entity =>
            {
                entity.HasIndex(e => e.CODE, "IX_CAMPAIGNS");

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CALLBACK_TRUNK).HasMaxLength(150);

                entity.Property(e => e.CODE).HasMaxLength(100);

                entity.Property(e => e.DESCRIPTION).HasMaxLength(100);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.ENDDATE).HasColumnType("datetime");

                entity.Property(e => e.FORALLPROJECTS).HasComputedColumnSql("(case when [PROJECT_DETAILID] IS NULL then (1) else (0) end)", false);

                entity.Property(e => e.RAKAM_ID).HasMaxLength(15);

                entity.Property(e => e.STARTDATE).HasColumnType("datetime");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.CAMPAIGNSADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CAMPAIGNS__ADDUS__14270015");

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.CAMPAIGNS)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CAMPAIGNS__CORPI__1E6F845E");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.CAMPAIGNSEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__CAMPAIGNS__EDITU__160F4887");

                entity.HasOne(d => d.PROJECT)
                    .WithMany(p => p.CAMPAIGNS)
                    .HasForeignKey(d => d.PROJECTID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CAMPAIGNS_PROJECT_GROUP");

                entity.HasOne(d => d.RESOURCE)
                    .WithMany(p => p.CAMPAIGNS)
                    .HasForeignKey(d => d.RESOURCEID)
                    .HasConstraintName("FK__CAMPAIGNS__RESOU__17F790F9");
            });

            modelBuilder.Entity<dbo.CASHIER_HANDOVER>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__CASHIER___3214EC263744268B")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.CASHIER_HANDOVERADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CASHIER_H__ADDUS__51851410");

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.CASHIER_HANDOVER)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CASHIER_H__CORPI__52793849");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.CASHIER_HANDOVEREDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__CASHIER_H__EDITU__536D5C82");

                entity.HasOne(d => d.RESOURCE)
                    .WithMany(p => p.CASHIER_HANDOVER)
                    .HasForeignKey(d => d.RESOURCEID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CASHIER_H__RESOU__546180BB");

                entity.HasOne(d => d.USER)
                    .WithMany(p => p.CASHIER_HANDOVERUSER)
                    .HasForeignKey(d => d.USERID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CASHIER_H__USERI__5555A4F4");
            });

            modelBuilder.Entity<dbo.CASHIER_HANDOVER_ENTITY>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__CASHIER___3214EC26829369B8")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CURCODE)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.CASHIER_HANDOVER)
                    .WithMany(p => p.CASHIER_HANDOVER_ENTITY)
                    .HasForeignKey(d => d.CASHIER_HANDOVERID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CASHIER_H__CASHI__4297D63B");

                entity.HasOne(d => d.CURCODENavigation)
                    .WithMany(p => p.CASHIER_HANDOVER_ENTITY)
                    .HasForeignKey(d => d.CURCODE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CASHIER_H__CURCO__438BFA74");
            });

            modelBuilder.Entity<dbo.CITY>(entity =>
            {
                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.NAME).HasMaxLength(70);

                entity.HasOne(d => d.COUNTRY)
                    .WithMany(p => p.CITY)
                    .HasForeignKey(d => d.COUNTRYID)
                    .HasConstraintName("FK__CITY__COUNTRYID__5832119F");
            });

            modelBuilder.Entity<dbo.CONTACT_CATEGORY>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__CONTACT___3214EC26D22EAE2D")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DEFINITION).HasMaxLength(150);

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.CONTACT_CATEGORY)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CONTACT_C__CORPI__30F91444");
            });

            modelBuilder.Entity<dbo.CONTACT_FORM>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__CONTACT___3214EC26B90220D6")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.TITLE).HasMaxLength(200);

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.CONTACT_FORMADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CONTACT_F__ADDUS__389A360C");

                entity.HasOne(d => d.CATEGORYNavigation)
                    .WithMany(p => p.CONTACT_FORM)
                    .HasForeignKey(d => d.CATEGORY)
                    .HasConstraintName("FK__CONTACT_F__CATEG__35BDC961");

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.CONTACT_FORM)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CONTACT_F__CORPI__36B1ED9A");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.CONTACT_FORMEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__CONTACT_F__EDITU__398E5A45");

                entity.HasOne(d => d.PERSON)
                    .WithMany(p => p.CONTACT_FORM)
                    .HasForeignKey(d => d.PERSONID)
                    .HasConstraintName("FK__CONTACT_F__PERSO__34C9A528");
            });

            modelBuilder.Entity<dbo.CORP>(entity =>
            {
                entity.HasIndex(e => e.INTID, "IX_CORP");

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CONTACT).HasMaxLength(150);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.EMAIL).HasMaxLength(200);

                entity.Property(e => e.GA_CUSTOMERID).HasMaxLength(15);

                entity.Property(e => e.INTID).ValueGeneratedOnAdd();

                entity.Property(e => e.NAME).HasMaxLength(200);

                entity.Property(e => e.TAXAUTH).HasMaxLength(100);

                entity.Property(e => e.TAXNO).HasMaxLength(30);

                entity.HasOne(d => d.ADDRESS)
                    .WithMany(p => p.CORP)
                    .HasForeignKey(d => d.ADDRESSID)
                    .HasConstraintName("FK__CORP__ADDRESSID__5EBF139D");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.CORPADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .HasConstraintName("FK__CORP__ADDUSER__619B8048");

                entity.HasOne(d => d.AUTO_PASSWORD_FORGETNavigation)
                    .WithMany(p => p.CORPAUTO_PASSWORD_FORGETNavigation)
                    .HasForeignKey(d => d.AUTO_PASSWORD_FORGET)
                    .HasConstraintName("FK__CORP__AUTO_PASSW__592635D8");

                entity.HasOne(d => d.AUTO_RESMAIL_CLIENTNavigation)
                    .WithMany(p => p.CORPAUTO_RESMAIL_CLIENTNavigation)
                    .HasForeignKey(d => d.AUTO_RESMAIL_CLIENT)
                    .HasConstraintName("FK__CORP__AUTO_RESMA__5A1A5A11");

                entity.HasOne(d => d.AUTO_RESMAIL_HOSTNavigation)
                    .WithMany(p => p.CORPAUTO_RESMAIL_HOSTNavigation)
                    .HasForeignKey(d => d.AUTO_RESMAIL_HOST)
                    .HasConstraintName("FK__CORP__AUTO_RESMA__5B0E7E4A");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.CORPEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__CORP__EDITUSER__6383C8BA");
            });

            modelBuilder.Entity<dbo.COUNTRY>(entity =>
            {
                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DIAL_CODE).HasMaxLength(15);

                entity.Property(e => e.ISOCODE2)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NAME).HasMaxLength(70);
            });

            modelBuilder.Entity<dbo.CRM_CARDGROUPS>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__CRM_CARD__3214EC264ECA644E")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.CORPID, e.DEFINITION }, "UQ__CRM_CARD__D0FAF6086F855A68")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DEFINITION).HasMaxLength(100);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.CRM_CARDGROUPSADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CRM_CARDG__ADDUS__1B73E779");

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.CRM_CARDGROUPS)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CRM_CARDG__CORPI__18977ACE");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.CRM_CARDGROUPSEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__CRM_CARDG__EDITU__1D5C2FEB");
            });

            modelBuilder.Entity<dbo.CRM_CARDTYPES>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__CRM_CARD__3214EC26CBABAEF5")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.BACKCOLOR1).HasMaxLength(20);

                entity.Property(e => e.BACKCOLOR2).HasMaxLength(20);

                entity.Property(e => e.BACKGROUNDLOGO).HasMaxLength(255);

                entity.Property(e => e.CARDBRANDICONURL).HasMaxLength(250);

                entity.Property(e => e.CARDNUMBER_MARGIN)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'40px 25px 10px')");

                entity.Property(e => e.COLORGROUP1).HasMaxLength(20);

                entity.Property(e => e.COLORGROUP2).HasMaxLength(20);

                entity.Property(e => e.COLORGROUP3).HasMaxLength(20);

                entity.Property(e => e.COLORGROUP4).HasMaxLength(20);

                entity.Property(e => e.DEFINITION).HasMaxLength(100);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.SHOWCARDHOLDERNAME)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SHOWCARD_BRAND)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SHOWCHIP_ICON)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SHOWEXPIRE)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SHOWNUMBERS)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SHOWWIFI_ICON)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SHOW_STRIPBOTTOM)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SHOW_STRIPTOP)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TITLE).HasMaxLength(100);

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.CRM_CARDTYPESADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CRM_CARDT__ADDUS__26E59A25");

                entity.HasOne(d => d.CARDGROUP)
                    .WithMany(p => p.CRM_CARDTYPES)
                    .HasForeignKey(d => d.CARDGROUPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CRM_CARDT__CARDG__212CC0CF");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.CRM_CARDTYPESEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__CRM_CARDT__EDITU__28CDE297");
            });

            modelBuilder.Entity<dbo.CURCODE>(entity =>
            {
                entity.HasKey(e => e.CODE);

                entity.Property(e => e.CODE)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<dbo.CURRATE>(entity =>
            {
                entity.HasIndex(e => new { e.CORPID, e.CURCODE, e.RATEDATE }, "IX_CURRATE");

                entity.HasIndex(e => e.RATEDATE, "IX_CURRATE_1");

                entity.HasIndex(e => e.RATEDATE, "IX_CURRATE_2");

                entity.HasIndex(e => new { e.CORPID, e.CURCODE, e.RATEDATE }, "IX_CURRATE_4");

                entity.Property(e => e.CURCODE)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RATEDATE).HasColumnType("datetime");

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.CURRATE)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CURRATE__CORPID__42ACE4D4");
            });

            modelBuilder.Entity<dbo.DASHBOARD>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__DASHBOAR__3214EC27E2539AD9")
                    .IsClustered(false);

                entity.HasIndex(e => e.SORTORDER, "IX_DASHBOARD")
                    .IsClustered();

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.COLUMNWIDTHS)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'1, 0.5, 0.5')");

                entity.Property(e => e.MAXCOLUMN).HasDefaultValueSql("((2))");

                entity.Property(e => e.STATEID).HasMaxLength(50);

                entity.Property(e => e.TITLE).HasMaxLength(50);
            });

            modelBuilder.Entity<dbo.DASHBOARD_ITEM>(entity =>
            {
                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.TITLE).HasMaxLength(50);

                entity.Property(e => e.WIDGETNAME)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'widget')");

                entity.HasOne(d => d.DASHBOARD)
                    .WithMany(p => p.DASHBOARD_ITEM)
                    .HasForeignKey(d => d.DASHBOARDID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DASHBOARD__DASHB__24485945");
            });

            modelBuilder.Entity<dbo.DASHBOARD_ITEM_YDK>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.TITLE).HasMaxLength(50);

                entity.Property(e => e.WIDGETNAME).HasMaxLength(50);
            });

            modelBuilder.Entity<dbo.DASHBOARD_YDK>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.COLUMNWIDTHS).HasMaxLength(50);

                entity.Property(e => e.STATEID).HasMaxLength(50);

                entity.Property(e => e.TITLE).HasMaxLength(50);
            });

            modelBuilder.Entity<dbo.DATA_DICTIONARY>(entity =>
            {
                entity.HasIndex(e => new { e.RECID, e.TABLENAME, e.FIELDNAME, e.LANGCODE }, "UQ__DATA_DIC__54F85D1A5F1C9BBD")
                    .IsUnique();

                entity.Property(e => e.FIELDNAME).HasMaxLength(150);

                entity.Property(e => e.LANGCODE)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TABLENAME).HasMaxLength(100);
            });

            modelBuilder.Entity<dbo.DB_LOG>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DB_LOG");

                entity.Property(e => e.ID).ValueGeneratedOnAdd();

                entity.Property(e => e.LOGTEXT).HasColumnType("ntext");

                entity.Property(e => e.LOGTIME).HasColumnType("datetime");

                entity.Property(e => e.RECID).HasMaxLength(45);

                entity.Property(e => e.TABLENAME).HasMaxLength(150);

                entity.Property(e => e.TRACEFLAG).HasMaxLength(25);

                entity.Property(e => e.USERCODE).HasMaxLength(150);
            });

            modelBuilder.Entity<dbo.DISTRICT>(entity =>
            {
                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.NAME).HasMaxLength(70);

                entity.HasOne(d => d.CITY)
                    .WithMany(p => p.DISTRICT)
                    .HasForeignKey(d => d.CITYID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DISTRICT__CITYID__60C757A0");
            });

            modelBuilder.Entity<dbo.ENTEGRATION_SETTINGS>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ENTTYPE).HasMaxLength(50);

                entity.Property(e => e.FIRST_DATE).HasColumnType("date");

                entity.Property(e => e.LAST_DATE).HasColumnType("date");
            });

            modelBuilder.Entity<dbo.HOTEL_RESERVATIONS>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__HOTEL_RE__3214EC260D15FE65")
                    .IsClustered(false);

                entity.HasIndex(e => e.RESID, "UQ__HOTEL_RE__4D969333596EF86E")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CONTRACT_DATE).HasColumnType("datetime");

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.ENTID).HasMaxLength(40);

                entity.Property(e => e.LASTUPDATE_RESDETAIL).HasColumnType("datetime");

                entity.Property(e => e.RESID).ValueGeneratedOnAdd();

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.HOTEL_RESERVATIONSADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HOTEL_RES__ADDUS__6497E884");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.HOTEL_RESERVATIONSEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__HOTEL_RES__EDITU__658C0CBD");

                entity.HasOne(d => d.REQUEST_DETAIL)
                    .WithMany(p => p.HOTEL_RESERVATIONS)
                    .HasForeignKey(d => d.REQUEST_DETAILID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__HOTEL_RES__REQUE__625078B6");
            });

            modelBuilder.Entity<dbo.HOTEL_RESERVATION_DETAILS>(entity =>
            {
                entity.HasIndex(e => e.ID, "IX_HOTEL_RESERVATION_DETAILS");

                entity.HasIndex(e => e.RESID, "IX_MISS_HOTELSEARCH_2");

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AVAIL).HasMaxLength(150);

                entity.Property(e => e.COSTPRICE).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.DATE).HasColumnType("date");

                entity.Property(e => e.DAYOFWEEK)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEXP1).HasMaxLength(50);

                entity.Property(e => e.DEXP2).HasMaxLength(50);

                entity.Property(e => e.DEXP3).HasMaxLength(50);

                entity.Property(e => e.DEXP4).HasMaxLength(50);

                entity.Property(e => e.DEXP5).HasMaxLength(50);

                entity.Property(e => e.FINALCOST).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.FINALPRICE).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.GUESTPRICE).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.PRICEDEBUGINFO).HasMaxLength(100);

                entity.Property(e => e.TEMPID).ValueGeneratedOnAdd();

                entity.HasOne(d => d.COMB)
                    .WithMany(p => p.HOTEL_RESERVATION_DETAILS)
                    .HasForeignKey(d => d.COMBID)
                    .HasConstraintName("FK_HOTEL_RESERVATION_DETAILS_STDHOTEL_PRICECONDITION");

                entity.HasOne(d => d.RATECODE)
                    .WithMany(p => p.HOTEL_RESERVATION_DETAILS)
                    .HasForeignKey(d => d.RATECODEID)
                    .HasConstraintName("FK__HOTEL_RES__RATEC__61BB7BD9");

                entity.HasOne(d => d.RES)
                    .WithMany(p => p.HOTEL_RESERVATION_DETAILS)
                    .HasForeignKey(d => d.RESID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_HOTEL_RESERVATION_DETAILS_HOTEL_RESERVATIONS");
            });

            modelBuilder.Entity<dbo.INTEGRATION_ERRORS>(entity =>
            {
                entity.Property(e => e.ERRORTEXT).HasMaxLength(255);
            });

            modelBuilder.Entity<dbo.LOCATION_ADDRESS>(entity =>
            {
                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.INVOICE_EMAIL).HasMaxLength(200);

                entity.Property(e => e.INVOICE_TAXNO).HasMaxLength(25);

                entity.Property(e => e.INVOICE_TAXPLACENAME).HasMaxLength(100);

                entity.Property(e => e.INVOICE_TITLE).HasMaxLength(200);

                entity.Property(e => e.LINE1).HasMaxLength(100);

                entity.Property(e => e.LINE2).HasMaxLength(100);

                entity.Property(e => e.ZIPCODE).HasMaxLength(30);

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.LOCATION_ADDRESSADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LOCATION___ADDUS__59063A47");

                entity.HasOne(d => d.CITY)
                    .WithMany(p => p.LOCATION_ADDRESS)
                    .HasForeignKey(d => d.CITYID)
                    .HasConstraintName("FK__LOCATION___CITYI__6774552F");

                entity.HasOne(d => d.COUNTRY)
                    .WithMany(p => p.LOCATION_ADDRESS)
                    .HasForeignKey(d => d.COUNTRYID)
                    .HasConstraintName("FK__LOCATION___COUNT__68687968");

                entity.HasOne(d => d.DISTRICT)
                    .WithMany(p => p.LOCATION_ADDRESS)
                    .HasForeignKey(d => d.DISTRICTID)
                    .HasConstraintName("FK__LOCATION___DISTR__695C9DA1");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.LOCATION_ADDRESSEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__LOCATION___EDITU__5AEE82B9");
            });

            modelBuilder.Entity<dbo.MAIL_CONTENTS>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MAIL_CONTENTS");

                entity.Property(e => e.ID).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<dbo.PAYMENTS>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__PAYMENTS__3214EC26489EFB7F")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CURCODE)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DESCRIPTION).HasMaxLength(250);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.HARDPOSIDENTITY).HasMaxLength(50);

                entity.Property(e => e.TL_AMOUNT).HasComputedColumnSql("([dbo].[FN_CURRATE]([CORPID],[ADDDATE],[CURCODE],'TRY',[DEBT]+[CREDIT]))", false);

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.PAYMENTSADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PAYMENTS__ADDUSE__6C390A4C");

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.PAYMENTS)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PAYMENTS__CORPID__6D2D2E85");

                entity.HasOne(d => d.CURCODENavigation)
                    .WithMany(p => p.PAYMENTS)
                    .HasForeignKey(d => d.CURCODE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PAYMENTS__CURCOD__6E2152BE");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.PAYMENTSEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__PAYMENTS__EDITUS__6F1576F7");

                entity.HasOne(d => d.REQUEST)
                    .WithMany(p => p.PAYMENTS)
                    .HasForeignKey(d => d.REQUESTID)
                    .HasConstraintName("FK__PAYMENTS__REQUES__70099B30");

                entity.HasOne(d => d.RESOURCE)
                    .WithMany(p => p.PAYMENTS)
                    .HasForeignKey(d => d.RESOURCEID)
                    .HasConstraintName("FK__PAYMENTS__RESOUR__70FDBF69");

                entity.HasOne(d => d.STATUSNavigation)
                    .WithMany(p => p.PAYMENTS)
                    .HasForeignKey(d => d.STATUS)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PAYMENTS__STATUS__71F1E3A2");
            });

            modelBuilder.Entity<dbo.PAYMENT_EMAILS>(entity =>
            {
                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.BCC_EMAILS).HasMaxLength(500);

                entity.Property(e => e.CC_EMAILS).HasMaxLength(500);

                entity.Property(e => e.TO_EMAILS).HasMaxLength(500);

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.PAYMENT_EMAILS)
                    .HasForeignKey(d => d.CORPID)
                    .HasConstraintName("FK__PAYMENT__CORPI__38845C1C");

                entity.HasOne(d => d.PROJECT)
                    .WithMany(p => p.PAYMENT_EMAILS)
                    .HasForeignKey(d => d.PROJECTID)
                    .HasConstraintName("FK__PAYMENT__PROJE__39788055");

                entity.HasOne(d => d.PROJECT_DETAIL)
                    .WithMany(p => p.PAYMENT_EMAILS)
                    .HasForeignKey(d => d.PROJECT_DETAILID)
                    .HasConstraintName("FK_PAYMENT_EMAILS_PROJECT_GROUPDETAIL");
            });

            modelBuilder.Entity<dbo.PERSON>(entity =>
            {
                entity.HasIndex(e => e.RAKAM_ID, "IX_PERSON");

                entity.HasIndex(e => e.FIRSTNAME, "IX_PERSON_1");

                entity.HasIndex(e => e.NATIONALITY, "IX_PERSON_10");

                entity.HasIndex(e => e.ISDELETED, "IX_PERSON_11");

                entity.HasIndex(e => e.KVKK, "IX_PERSON_12");

                entity.HasIndex(e => e.EMAIL, "IX_PERSON_13");

                entity.HasIndex(e => e.LASTNAME, "IX_PERSON_2");

                entity.HasIndex(e => e.SECONDNAME, "IX_PERSON_3");

                entity.HasIndex(e => e.FIRSTNAME, "IX_PERSON_4");

                entity.HasIndex(e => e.LASTNAME, "IX_PERSON_5");

                entity.HasIndex(e => e.FULLNAME, "IX_PERSON_6");

                entity.HasIndex(e => e.TEL1, "IX_PERSON_7");

                entity.HasIndex(e => e.TEL2, "IX_PERSON_8");

                entity.HasIndex(e => e.TYPE, "IX_PERSON_9");

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.BIRTHDATE).HasColumnType("date");

                entity.Property(e => e.BONUS_CARDTYPE).HasMaxLength(150);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.EMAIL).HasMaxLength(200);

                entity.Property(e => e.ENT_ID).HasMaxLength(150);

                entity.Property(e => e.FIRSTNAME).HasMaxLength(70);

                entity.Property(e => e.FULLNAME)
                    .HasMaxLength(212)
                    .HasComputedColumnSql("((isnull([FIRSTNAME]+' ','')+isnull([SECONDNAME]+' ',''))+isnull([LASTNAME],''))", false);

                entity.Property(e => e.IDENTITYNO).HasMaxLength(15);

                entity.Property(e => e.LASTNAME).HasMaxLength(70);

                entity.Property(e => e.RAKAM_ID).HasMaxLength(15);

                entity.Property(e => e.SECONDNAME).HasMaxLength(70);

                entity.Property(e => e.TITLE).HasMaxLength(10);

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.PERSONADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PERSON__ADDUSER__14270015");

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.PERSON)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PERSON_CORP");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.PERSONEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__PERSON__EDITUSER__160F4887");

                entity.HasOne(d => d.GROUP)
                    .WithMany(p => p.PERSON)
                    .HasForeignKey(d => d.GROUPID)
                    .HasConstraintName("FK__PERSON__GROUPID__123EB7A3");

                entity.HasOne(d => d.NATIONALITYNavigation)
                    .WithMany(p => p.PERSON)
                    .HasForeignKey(d => d.NATIONALITY)
                    .HasConstraintName("FK__PERSON__NATIONAL__0F624AF8");
            });

            modelBuilder.Entity<dbo.PERSON_ADDRESS>(entity =>
            {
                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.ADDRESS)
                    .WithMany(p => p.PERSON_ADDRESS)
                    .HasForeignKey(d => d.ADDRESSID)
                    .HasConstraintName("FK__PERSON_AD__ADDRE__77AABCF8");

                entity.HasOne(d => d.PERSON)
                    .WithMany(p => p.PERSON_ADDRESS)
                    .HasForeignKey(d => d.PERSONID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PERSON_AD__PERSO__208CD6FA");
            });

            modelBuilder.Entity<dbo.PERSON_BONUS>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__PERSON_B__3214EC26FC14D486")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DATE).HasColumnType("date");

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.PERSON_BONUSADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PERSON_BO__ADDUS__082C08DB");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.PERSON_BONUSEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__PERSON_BO__EDITU__0A14514D");

                entity.HasOne(d => d.PERSON)
                    .WithMany(p => p.PERSON_BONUS)
                    .HasForeignKey(d => d.PERSONID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PERSON_BO__PERSO__036753BE");

                entity.HasOne(d => d.REQUEST_DETAIL)
                    .WithMany(p => p.PERSON_BONUS)
                    .HasForeignKey(d => d.REQUEST_DETAILID)
                    .HasConstraintName("FK__PERSON_BO__REQUE__0643C069");

                entity.HasOne(d => d.TYPE)
                    .WithMany(p => p.PERSON_BONUS)
                    .HasForeignKey(d => d.TYPEID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PERSON_BO__TYPEI__045B77F7");
            });

            modelBuilder.Entity<dbo.PERSON_BONUS_TYPES>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__PERSON_B__3214EC263CFE324A")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.NAME).HasMaxLength(100);

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.PERSON_BONUS_TYPESADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PERSON_BO__ADDUS__7DAE7A68");

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.PERSON_BONUS_TYPES)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PERSON_BO__CORPI__7CBA562F");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.PERSON_BONUS_TYPESEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__PERSON_BO__EDITU__7F96C2DA");
            });

            modelBuilder.Entity<dbo.PERSON_CCARDS>(entity =>
            {
                entity.Property(e => e.CARDNUMBER).HasMaxLength(50);

                entity.Property(e => e.CARDOWNER).HasMaxLength(200);

                entity.Property(e => e.CVV).HasMaxLength(5);

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.PERSON)
                    .WithMany(p => p.PERSON_CCARDS)
                    .HasForeignKey(d => d.PERSONID)
                    .HasConstraintName("FK__PERSON_CC__PERSO__0F4D3C5F");
            });

            modelBuilder.Entity<dbo.PERSON_GROUP>(entity =>
            {
                entity.HasIndex(e => new { e.CORPID, e.NAME }, "IX_PERSON_GROUP")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.NAME).HasMaxLength(150);

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.PERSON_GROUPADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PERSON_GR__ADDUS__1AD3FDA4");

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.PERSON_GROUP)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PERSON_GROUP_CORP");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.PERSON_GROUPEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__PERSON_GR__EDITU__1CBC4616");
            });

            modelBuilder.Entity<dbo.PORTAL>(entity =>
            {
                entity.HasIndex(e => e.UID, "IX_PORTAL")
                    .IsUnique();

                entity.Property(e => e.ACCOUNT_AUTO_CREATEUSER_ONFORGETPASSFORM)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ACCOUNT_BACKGROUNDURL).HasMaxLength(350);

                entity.Property(e => e.ACCOUNT_COPYRIGHT).HasMaxLength(150);

                entity.Property(e => e.ACCOUNT_LOGIN_BY_PHONE)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ACCOUNT_LOGIN_BY_VOUCHERNO)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ACCOUNT_LOGO).HasMaxLength(350);

                entity.Property(e => e.CONTACT_EMAIL).HasMaxLength(240);

                entity.Property(e => e.CONTACT_MAPURL).HasMaxLength(400);

                entity.Property(e => e.CONTACT_PHONE).HasMaxLength(40);

                entity.Property(e => e.DEFAULT_CURCODE)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('TRY')")
                    .IsFixedLength();

                entity.Property(e => e.DEFAULT_LANG)
                    .HasMaxLength(5)
                    .HasDefaultValueSql("('tr-TR')");

                entity.Property(e => e.DISPLAYNAME).HasMaxLength(100);

                entity.Property(e => e.DOMAIN).HasMaxLength(100);

                entity.Property(e => e.FAVICON).HasMaxLength(250);

                entity.Property(e => e.LOGININFO).HasColumnType("ntext");

                entity.Property(e => e.LOGO).HasMaxLength(250);

                entity.Property(e => e.MULTIPLE_CURCODES)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.OFFER_BANNER).HasMaxLength(350);

                entity.Property(e => e.PORTAL_GROUPNAME).HasMaxLength(50);

                entity.Property(e => e.POSTEK_DOMAIN).HasMaxLength(100);

                entity.Property(e => e.TEMPLATENAME).HasMaxLength(50);

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.CORPORATION)
                    .WithMany(p => p.PORTAL)
                    .HasForeignKey(d => d.CORPORATIONID)
                    .HasConstraintName("FK_PORTAL_CORP");

                entity.HasOne(d => d.DEFAULT_CURCODENavigation)
                    .WithMany(p => p.PORTAL)
                    .HasForeignKey(d => d.DEFAULT_CURCODE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PORTAL_CURCODE");

                entity.HasOne(d => d.PROJECT)
                    .WithMany(p => p.PORTAL)
                    .HasForeignKey(d => d.PROJECTID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PORTAL_PROJECT_GROUP");

                entity.HasOne(d => d.PROJECT_DETAIL)
                    .WithMany(p => p.PORTAL)
                    .HasForeignKey(d => d.PROJECT_DETAILID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PORTAL_PROJECT_GROUPDETAIL");
            });

            modelBuilder.Entity<dbo.PORTAL_AUTH_IPADDRESS>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__PORTAL_A__3214EC263CD31959")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.IPADDRESS, e.PORTALUID }, "IX_PORTAL_AUTH_IPADDRESS");

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.IPADDRESS).HasMaxLength(35);

                entity.Property(e => e.ISMANAGER)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.PORTALU)
                    .WithMany(p => p.PORTAL_AUTH_IPADDRESS)
                    .HasPrincipalKey(p => p.UID)
                    .HasForeignKey(d => d.PORTALUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PORTAL_AU__PORTA__605321AB");
            });

            modelBuilder.Entity<dbo.PORTAL_CATEGORIES>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__PORTAL_C__3214EC26899D975F")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DEFINITION).HasMaxLength(150);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.INTID).ValueGeneratedOnAdd();

                entity.Property(e => e.TYPE).HasMaxLength(150);

                entity.Property(e => e.URL).HasMaxLength(250);

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.PORTAL_CATEGORIESADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PORTAL_CA__ADDUS__004002F9");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.PORTAL_CATEGORIESEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__PORTAL_CA__EDITU__01342732");

                entity.HasOne(d => d.PORTAL)
                    .WithMany(p => p.PORTAL_CATEGORIES)
                    .HasForeignKey(d => d.PORTALID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PORTAL_CA__PORTA__02284B6B");
            });

            modelBuilder.Entity<dbo.PORTAL_CATEGORY_IMAGES>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__PORTAL_C__3214EC2620C60564")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DESCRIPTION).HasMaxLength(255);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.GROUPNAME).HasMaxLength(100);

                entity.Property(e => e.IMAGEURL).HasMaxLength(350);

                entity.Property(e => e.THUMBNAILURL).HasMaxLength(350);

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.PORTAL_CATEGORY_IMAGESADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PORTAL_CA__ADDUS__0EE3280B");

                entity.HasOne(d => d.CAT)
                    .WithMany(p => p.PORTAL_CATEGORY_IMAGES)
                    .HasForeignKey(d => d.CATID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PORTAL_CATEGORY_IMAGES_PORTAL_CATEGORIES");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.PORTAL_CATEGORY_IMAGESEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__PORTAL_CA__EDITU__0FD74C44");
            });

            modelBuilder.Entity<dbo.PORTAL_CATEGORY_ITEMS>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__PORTAL_C__3214EC26CDAF71B5")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE).HasColumnType("datetime");

                entity.Property(e => e.CURCODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DESCRIPTION).HasMaxLength(100);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.IMAGEURL).HasMaxLength(250);

                entity.Property(e => e.THUMBNAILURL).HasMaxLength(250);

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.PORTAL_CATEGORY_ITEMSADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PORTAL_CA__ADDUS__17786E0C");

                entity.HasOne(d => d.CAT)
                    .WithMany(p => p.PORTAL_CATEGORY_ITEMS)
                    .HasForeignKey(d => d.CATID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PORTAL_CATEGORY_ITEMS_PORTAL_CATEGORIES");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.PORTAL_CATEGORY_ITEMSEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__PORTAL_CA__EDITU__186C9245");

                entity.HasOne(d => d.HOTEL)
                    .WithMany(p => p.PORTAL_CATEGORY_ITEMS)
                    .HasForeignKey(d => d.HOTELID)
                    .HasConstraintName("FK__PORTAL_CA__HOTEL__23DE44F1");

                entity.HasOne(d => d.TICKET)
                    .WithMany(p => p.PORTAL_CATEGORY_ITEMS)
                    .HasForeignKey(d => d.TICKETID)
                    .HasConstraintName("FK_PORTAL_CATEGORY_ITEMS_TICKET");

                entity.HasOne(d => d.TOUR)
                    .WithMany(p => p.PORTAL_CATEGORY_ITEMS)
                    .HasForeignKey(d => d.TOURID)
                    .HasConstraintName("FK__PORTAL_CA__TOURI__24D2692A");
            });

            modelBuilder.Entity<dbo.PORTAL_CURRENCIES>(entity =>
            {
                entity.HasIndex(e => new { e.CURCODE, e.PORTALUID }, "IX_PORTAL_CURRENCIES")
                    .IsUnique();

                entity.Property(e => e.CURCODE)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.CURCODENavigation)
                    .WithMany(p => p.PORTAL_CURRENCIES)
                    .HasForeignKey(d => d.CURCODE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PORTAL_CU__CURCO__031C6FA4");

                entity.HasOne(d => d.PORTALU)
                    .WithMany(p => p.PORTAL_CURRENCIES)
                    .HasPrincipalKey(p => p.UID)
                    .HasForeignKey(d => d.PORTALUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PORTAL_CU__PORTA__041093DD");
            });

            modelBuilder.Entity<dbo.PORTAL_DESCRIPTION>(entity =>
            {
                entity.Property(e => e.CAPTION).HasMaxLength(100);

                entity.Property(e => e.ICON).HasMaxLength(50);

                entity.HasOne(d => d.PORTALU)
                    .WithMany(p => p.PORTAL_DESCRIPTION)
                    .HasPrincipalKey(p => p.UID)
                    .HasForeignKey(d => d.PORTALUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PORTAL_DESCRIPTION_PORTAL");
            });

            modelBuilder.Entity<dbo.PORTAL_DOMAINS>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__PORTAL_D__3214EC267E745450")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.PORTALUID, e.DOMAIN }, "UQ__PORTAL_D__73E21ECAE3DDAF90")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DOMAIN).HasMaxLength(250);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.PORTAL_DOMAINSADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PORTAL_DO__ADDUS__05F8DC4F");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.PORTAL_DOMAINSEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__PORTAL_DO__EDITU__06ED0088");

                entity.HasOne(d => d.PORTALU)
                    .WithMany(p => p.PORTAL_DOMAINS)
                    .HasPrincipalKey(p => p.UID)
                    .HasForeignKey(d => d.PORTALUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PORTAL_DO__PORTAL__363CEC4E");
            });

            modelBuilder.Entity<dbo.PORTAL_EMAILS>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__PORTAL_E__3214EC2617569B3F")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.BCC_EMAILS).HasMaxLength(500);

                entity.Property(e => e.CC_EMAILS).HasMaxLength(500);

                entity.Property(e => e.TO_EMAILS).HasMaxLength(500);

                entity.HasOne(d => d.PORTALU)
                    .WithMany(p => p.PORTAL_EMAILS)
                    .HasPrincipalKey(p => p.UID)
                    .HasForeignKey(d => d.PORTALUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PORTAL_EM__PORTA__45F4312A");
            });

            modelBuilder.Entity<dbo.PORTAL_LANGDICTIONARY>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PORTAL_LANGDICTIONARY");

                entity.Property(e => e.ID).ValueGeneratedOnAdd();

                entity.Property(e => e.KEYVALUE)
                    .HasMaxLength(150)
                    .UseCollation("Turkish_CS_AS");

                entity.Property(e => e.KEYVALUE2).HasMaxLength(150);

                entity.Property(e => e.ar_SA)
                    .HasMaxLength(250)
                    .HasColumnName("ar-SA");

                entity.Property(e => e.de_DE)
                    .HasMaxLength(250)
                    .HasColumnName("de-DE");

                entity.Property(e => e.en_US)
                    .HasMaxLength(250)
                    .HasColumnName("en-US");

                entity.Property(e => e.fi_FI)
                    .HasMaxLength(150)
                    .HasColumnName("fi-FI");

                entity.Property(e => e.ru_RU)
                    .HasMaxLength(250)
                    .HasColumnName("ru-RU");

                entity.Property(e => e.tr_TR)
                    .HasMaxLength(250)
                    .HasColumnName("tr-TR");
            });

            modelBuilder.Entity<dbo.PORTAL_LANGUAGES>(entity =>
            {
                entity.Property(e => e.LANGCODE)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.HasOne(d => d.PORTALU)
                    .WithMany(p => p.PORTAL_LANGUAGES)
                    .HasPrincipalKey(p => p.UID)
                    .HasForeignKey(d => d.PORTALUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PORTAL_LANGUAGES_PORTAL");
            });

            modelBuilder.Entity<dbo.PORTAL_SEO>(entity =>
            {
                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.LANG)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TITLE).HasMaxLength(250);

                entity.Property(e => e.URL).HasMaxLength(150);

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.PORTAL_SEOADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PORTAL_SE__ADDUS__09C96D33");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.PORTAL_SEOEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__PORTAL_SE__EDITU__0ABD916C");

                entity.HasOne(d => d.LANGNavigation)
                    .WithMany(p => p.PORTAL_SEO)
                    .HasForeignKey(d => d.LANG)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PORTAL_SEO__LANG__0BB1B5A5");

                entity.HasOne(d => d.PROJECT_DETAIL)
                    .WithMany(p => p.PORTAL_SEO)
                    .HasForeignKey(d => d.PROJECT_DETAILID)
                    .HasConstraintName("FK__PORTAL_SE__PROJE__0E8E2250");
            });

            modelBuilder.Entity<dbo.PORTAL_SETTINGS>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__PORTAL_S__3214EC260BC297DC")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.PORTAL)
                    .WithMany(p => p.PORTAL_SETTINGS)
                    .HasPrincipalKey(p => p.UID)
                    .HasForeignKey(d => d.PORTALID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PORTAL_SE__PORTA__58920452");
            });

            modelBuilder.Entity<dbo.PORTAL_URLREWRITE>(entity =>
            {
                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VALIDDATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<dbo.PORTAL_USER>(entity =>
            {
                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CHANGEDATE).HasColumnType("datetime");

                entity.Property(e => e.CHANGEKEY)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1254_CI_AS");

                entity.Property(e => e.EMAIL).HasMaxLength(250);

                entity.Property(e => e.PWD).HasMaxLength(200);

                entity.HasOne(d => d.PERSON)
                    .WithMany(p => p.PORTAL_USER)
                    .HasForeignKey(d => d.PERSONID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__PORTAL_US__PERSO__0FC23DAB");
            });

            modelBuilder.Entity<dbo.PORTAL_USER_SOCIALACCOUNT>(entity =>
            {
                entity.HasIndex(e => new { e.USERID, e.PROVIDERNAME, e.PROVIDERID }, "UQ__PORTAL_U__47F26347B2CE65E0")
                    .IsUnique();

                entity.Property(e => e.PROVIDERID).HasMaxLength(200);

                entity.Property(e => e.PROVIDERNAME).HasMaxLength(50);

                entity.HasOne(d => d.USER)
                    .WithMany(p => p.PORTAL_USER_SOCIALACCOUNT)
                    .HasForeignKey(d => d.USERID)
                    .HasConstraintName("FK__PORTAL_US__USERI__129EAA56");
            });

            modelBuilder.Entity<dbo.PROJECT_GROUP>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__PRODUCT___3214EC27CD324AEE")
                    .IsClustered(false);

                entity.HasIndex(e => e.RAKAM_ID, "IX_PROJECT_GROUP");

                entity.HasIndex(e => e.NAME, "IX_PROJECT_GROUP_1")
                    .IsClustered();

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ACC_CODE).HasMaxLength(30);

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DONTSTORE_CCARDS).HasDefaultValueSql("((0))");

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.ENT_ID).HasMaxLength(25);

                entity.Property(e => e.ENT_SETURAPIKEY).HasMaxLength(150);

                entity.Property(e => e.ENT_SETURURL).HasMaxLength(250);

                entity.Property(e => e.ENT_URL).HasMaxLength(150);

                entity.Property(e => e.NAME).HasMaxLength(150);

                entity.Property(e => e.RAKAM_ID).HasMaxLength(15);

                entity.Property(e => e.RES_MAILURL).HasMaxLength(250);

                entity.HasOne(d => d.ADDRESS)
                    .WithMany(p => p.PROJECT_GROUP)
                    .HasForeignKey(d => d.ADDRESSID)
                    .HasConstraintName("FK_PROJECT_GROUP_LOCATION_ADDRESS");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.PROJECT_GROUPADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PRODUCT_G__ADDUS__7A672E12");

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.PROJECT_GROUP)
                    .HasForeignKey(d => d.CORPID)
                    .HasConstraintName("FK__PRODUCT_G__CORPI__76969D2E");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.PROJECT_GROUPEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__PRODUCT_G__EDITU__7C4F7684");
            });

            modelBuilder.Entity<dbo.PROJECT_GROUPDETAIL>(entity =>
            {
                entity.HasIndex(e => e.INTID, "IX_PROJECT_GROUPDETAIL")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ACC_INV_CODE).HasMaxLength(30);

                entity.Property(e => e.ACC_PAY_CODE).HasMaxLength(30);

                entity.Property(e => e.DESCRIPTION).HasMaxLength(200);

                entity.Property(e => e.EMAIL).HasMaxLength(150);

                entity.Property(e => e.ENT_ETSID).HasMaxLength(50);

                entity.Property(e => e.ENT_ETSURL).HasMaxLength(350);

                entity.Property(e => e.ENT_HOTELRUNNERID).HasMaxLength(150);

                entity.Property(e => e.ENT_HOTELRUNNERURL).HasMaxLength(150);

                entity.Property(e => e.ENT_IATIID).HasMaxLength(50);

                entity.Property(e => e.ENT_IATIURL).HasMaxLength(350);

                entity.Property(e => e.ENT_ID).HasMaxLength(25);

                entity.Property(e => e.ENT_JOLLYTOURID).HasMaxLength(150);

                entity.Property(e => e.ENT_JOLLYTOURURL).HasMaxLength(250);

                entity.Property(e => e.ENT_SEDNAID).HasMaxLength(250);

                entity.Property(e => e.ENT_SEDNAURL).HasMaxLength(250);

                entity.Property(e => e.ENT_SETURID).HasMaxLength(150);

                entity.Property(e => e.ENT_SETURURL).HasMaxLength(150);

                entity.Property(e => e.ENT_TATILBUDURID).HasMaxLength(20);

                entity.Property(e => e.ENT_TATILBUDURURL).HasMaxLength(350);

                entity.Property(e => e.ENT_TOURISTICAID).HasMaxLength(50);

                entity.Property(e => e.ENT_TOURISTICAURL).HasMaxLength(350);

                entity.Property(e => e.ENT_TRAVELCLCIKURL).HasMaxLength(350);

                entity.Property(e => e.ENT_TRAVELCLICKID).HasMaxLength(50);

                entity.Property(e => e.ENT_URL).HasMaxLength(250);

                entity.Property(e => e.GA_CUSTOMERID).HasMaxLength(15);

                entity.Property(e => e.INTID).ValueGeneratedOnAdd();

                entity.Property(e => e.PRODUCTID).HasComputedColumnSql("(coalesce([HOTELID],[TOURID],[TICKETID]))", false);

                entity.Property(e => e.RES_MAILURL).HasMaxLength(250);

                entity.HasOne(d => d.HOTEL)
                    .WithMany(p => p.PROJECT_GROUPDETAIL)
                    .HasForeignKey(d => d.HOTELID)
                    .HasConstraintName("FK__PRODUCT_G__HOTEL__01142BA1");

                entity.HasOne(d => d.PROJECT_GROUP)
                    .WithMany(p => p.PROJECT_GROUPDETAIL)
                    .HasForeignKey(d => d.PROJECT_GROUPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PRODUCT_G__PRODU__00200768");

                entity.HasOne(d => d.STORE)
                    .WithMany(p => p.PROJECT_GROUPDETAIL)
                    .HasForeignKey(d => d.STOREID)
                    .HasConstraintName("FK__PROJECT_G__STORE__7350E786");

                entity.HasOne(d => d.TICKET)
                    .WithMany(p => p.PROJECT_GROUPDETAIL)
                    .HasForeignKey(d => d.TICKETID)
                    .HasConstraintName("FK_PROJECT_GROUPDETAIL_TICKET");

                entity.HasOne(d => d.TOUR)
                    .WithMany(p => p.PROJECT_GROUPDETAIL)
                    .HasForeignKey(d => d.TOURID)
                    .HasConstraintName("FK__PROJECT_G__TOURI__1446FBA6");
            });

            modelBuilder.Entity<dbo.PROJECT_GROUPDETAIL_BANKDEP>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__PROJECT___3214EC26C3F1EA7D")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.PROJECT_DETAILID, e.DEPACCOUNTID }, "UQ__PROJECT___6EB8113D889D7241")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.USE_IN_PORTAL)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.DEPACCOUNT)
                    .WithMany(p => p.PROJECT_GROUPDETAIL_BANKDEP)
                    .HasForeignKey(d => d.DEPACCOUNTID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PROJECT_G__DEPAC__75985754");

                entity.HasOne(d => d.PROJECT_DETAIL)
                    .WithMany(p => p.PROJECT_GROUPDETAIL_BANKDEP)
                    .HasForeignKey(d => d.PROJECT_DETAILID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PROJECT_G__PROJE__74A4331B");
            });

            modelBuilder.Entity<dbo.PROJECT_GROUPDETAIL_SEO>(entity =>
            {
                entity.Property(e => e.LANG)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TITLE).HasMaxLength(250);

                entity.Property(e => e.URL).HasMaxLength(150);

                entity.HasOne(d => d.LANGNavigation)
                    .WithMany(p => p.PROJECT_GROUPDETAIL_SEO)
                    .HasForeignKey(d => d.LANG)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PROJECT_GR__LANG__19FFD4FC");
            });

            modelBuilder.Entity<dbo.PROJECT_GROUPDETAIL_VPOS>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__PROJECT___3214EC2674987CD5")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.PROJECT_DETAILID, e.ACCOUNTID }, "UQ__PROJECT___F7CFBB35722A2BCA")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CARDBRANDS).HasMaxLength(220);

                entity.Property(e => e.CURCODES).HasMaxLength(220);

                entity.HasOne(d => d.PROJECT_DETAIL)
                    .WithMany(p => p.PROJECT_GROUPDETAIL_VPOS)
                    .HasForeignKey(d => d.PROJECT_DETAILID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PROJECT_G__PROJE__48C5B0DD");
            });

            modelBuilder.Entity<dbo.PROMOTION_CODES>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__PROMOTIO__3214EC26C010043A")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CODE).HasMaxLength(255);

                entity.Property(e => e.CURCODE)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEFINITION).HasMaxLength(150);

                entity.Property(e => e.DESCRIPTION).HasMaxLength(255);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.EMAIL).HasMaxLength(250);

                entity.Property(e => e.SELLFROM).HasColumnType("datetime");

                entity.Property(e => e.SELLTO).HasColumnType("datetime");

                entity.Property(e => e.STAYFROM).HasColumnType("datetime");

                entity.Property(e => e.STAYTO).HasColumnType("datetime");

                entity.Property(e => e.USECOUNT).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.PROMOTION_CODESADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PROMOTION__ADDUS__31C24FF4");

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.PROMOTION_CODES)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PROMOTION__CORPI__2744C181");

                entity.HasOne(d => d.CURCODENavigation)
                    .WithMany(p => p.PROMOTION_CODES)
                    .HasForeignKey(d => d.CURCODE)
                    .HasConstraintName("FK_PROMOTION_CODES_CURCODE");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.PROMOTION_CODESEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__PROMOTION__EDITU__33AA9866");

                entity.HasOne(d => d.HOTEL)
                    .WithMany(p => p.PROMOTION_CODES)
                    .HasForeignKey(d => d.HOTELID)
                    .HasConstraintName("FK__PROMOTION__HOTEL__2CFD9AD7");

                entity.HasOne(d => d.TICKET)
                    .WithMany(p => p.PROMOTION_CODES)
                    .HasForeignKey(d => d.TICKETID)
                    .HasConstraintName("FK__PROMOTION__TICKE__2EE5E349");

                entity.HasOne(d => d.TOUR)
                    .WithMany(p => p.PROMOTION_CODES)
                    .HasForeignKey(d => d.TOURID)
                    .HasConstraintName("FK__PROMOTION__TOURI__2DF1BF10");
            });

            modelBuilder.Entity<dbo.PROMOTION_CODES_MARKET>(entity =>
            {
                entity.HasIndex(e => new { e.PROMOTIONID, e.MARKETID }, "UQ__PROMOTION_CODES_MARKET__4B96FBB176D8588E")
                    .IsUnique();

                entity.HasOne(d => d.MARKET)
                    .WithMany(p => p.PROMOTION_CODES_MARKET)
                    .HasForeignKey(d => d.MARKETID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROMOTION_CODES_MARKET__54D68207");

                entity.HasOne(d => d.PROMOTION)
                    .WithMany(p => p.PROMOTION_CODES_MARKET)
                    .HasForeignKey(d => d.PROMOTIONID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROMOTION_CODES_MARKET__53E25DCE");
            });

            modelBuilder.Entity<dbo.PROMOTION_CODES_ROOMTYPE>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.PROMOTIONID, e.ROOMTYPE }, "UQ__PROMOTIO__C1C5A5FA64991A60")
                    .IsUnique();

                entity.Property(e => e.ID).ValueGeneratedOnAdd();

                entity.Property(e => e.ROOMTYPE).HasMaxLength(6);

                entity.HasOne(d => d.PROMOTION)
                    .WithMany()
                    .HasForeignKey(d => d.PROMOTIONID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PROMOTION__PROMO__18C19800");

                entity.HasOne(d => d.ROOMTYPENavigation)
                    .WithMany()
                    .HasForeignKey(d => d.ROOMTYPE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PROMOTION__ROOMT__19B5BC39");
            });

            modelBuilder.Entity<dbo.PROPERTY_MAPPING>(entity =>
            {
                entity.HasIndex(e => new { e.HOTELID, e.BOARDTYPEID, e.PROVIDERID }, "IX_PROPERTY_MAPPING");

                entity.HasIndex(e => new { e.HOTELID, e.ROOMID, e.PROVIDERID }, "IX_PROPERTY_MAPPING_1");

                entity.HasIndex(e => new { e.HOTELID, e.PROVIDERID, e.RATETYPEID }, "IX_PROPERTY_MAPPING_2");

                entity.Property(e => e.CODE).HasMaxLength(150);

                entity.HasOne(d => d.BOARDTYPE)
                    .WithMany(p => p.PROPERTY_MAPPING)
                    .HasForeignKey(d => d.BOARDTYPEID)
                    .HasConstraintName("FK__PROPERTY___BOARD__17593DD2");

                entity.HasOne(d => d.HOTEL)
                    .WithMany(p => p.PROPERTY_MAPPING)
                    .HasForeignKey(d => d.HOTELID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PROPERTY___HOTEL__1570F560");

                entity.HasOne(d => d.PROVIDER)
                    .WithMany(p => p.PROPERTY_MAPPING)
                    .HasForeignKey(d => d.PROVIDERID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PROPERTY___PROVI__147CD127");

                entity.HasOne(d => d.RATETYPE)
                    .WithMany(p => p.PROPERTY_MAPPING)
                    .HasForeignKey(d => d.RATETYPEID)
                    .HasConstraintName("FK__PROPERTY___RATET__184D620B");

                entity.HasOne(d => d.ROOM)
                    .WithMany(p => p.PROPERTY_MAPPING)
                    .HasForeignKey(d => d.ROOMID)
                    .HasConstraintName("FK__PROPERTY___ROOMI__16651999");
            });

            modelBuilder.Entity<dbo.PROPERTY_PROVIDERS>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__PROPERTY__3214EC262A9FEFB2")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.CODE, e.CORPID }, "UQ__PROPERTY__A871B86AD3936B19")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CODE).HasMaxLength(20);

                entity.Property(e => e.NAME).HasMaxLength(150);

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.PROPERTY_PROVIDERS)
                    .HasForeignKey(d => d.CORPID)
                    .HasConstraintName("FK__PROPERTY___CORPI__10AC4043");
            });

            modelBuilder.Entity<dbo.REPORTS>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__REPORTS__3214EC2687F3CD71")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CLASSNAME).HasMaxLength(50);

                entity.Property(e => e.EXPORTTYPE).HasMaxLength(25);

                entity.Property(e => e.REPORTNAME).HasMaxLength(150);
            });

            modelBuilder.Entity<dbo.REQUEST>(entity =>
            {
                entity.HasIndex(e => e.CORPID, "IDX_MIS_DASHBOARD_REPORT2");

                entity.HasIndex(e => e.ADDDATE, "IX_REQUEST");

                entity.HasIndex(e => e.RAKAM_ID, "IX_REQUEST_1");

                entity.HasIndex(e => new { e.ADDDATE, e.CORPID }, "IX_REQUEST_2");

                entity.HasIndex(e => e.CREATIONDATE, "IX_REQUEST_3");

                entity.HasIndex(e => e.EDITDATE, "IX_REQUEST_4");

                entity.HasIndex(e => e.EDITDATE, "IX_REQUEST_5");

                entity.HasIndex(e => new { e.EDITDATE, e.ADDDATE }, "IX_REQUEST_6");

                entity.HasIndex(e => e.RESOURCEID, "IX_REQUEST_7");

                entity.HasIndex(e => new { e.CORPID, e.PROJECT_GROUPID }, "IX_REQUEST_CORPID_PGID");

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CAMPAIGNCODE).HasMaxLength(100);

                entity.Property(e => e.CONVERSATION_CUSTOMERID).HasMaxLength(50);

                entity.Property(e => e.CONVERSATION_ID).HasMaxLength(50);

                entity.Property(e => e.CREATIONDATE)
                    .HasColumnType("date")
                    .HasComputedColumnSql("(CONVERT([date],[ADDDATE]))", true);

                entity.Property(e => e.CREATIONTIME).HasComputedColumnSql("(CONVERT([time],[ADDDATE]))", true);

                entity.Property(e => e.CURCODE)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DIRECT_BRANDING).HasMaxLength(15);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.INVOICE_DATE).HasColumnType("datetime");

                entity.Property(e => e.INVOICE_EMAIL).HasMaxLength(200);

                entity.Property(e => e.INVOICE_FIRSTNAME).HasMaxLength(50);

                entity.Property(e => e.INVOICE_KIND).HasDefaultValueSql("((1))");

                entity.Property(e => e.INVOICE_LASTNAME).HasMaxLength(50);

                entity.Property(e => e.INVOICE_TAXNO).HasMaxLength(25);

                entity.Property(e => e.INVOICE_TAXPLACENAME).HasMaxLength(100);

                entity.Property(e => e.INVOICE_TITLE).HasMaxLength(200);

                entity.Property(e => e.LANGCODE)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PASSWORD).HasMaxLength(10);

                entity.Property(e => e.RAKAM_ID).HasMaxLength(15);

                entity.Property(e => e.REQ_URL).HasMaxLength(500);

                entity.Property(e => e.RESNO).HasMaxLength(200);

                entity.Property(e => e.SELLINGDATE)
                    .HasColumnType("date")
                    .HasComputedColumnSql("(CONVERT([date],[SELL_DATE]))", true);

                entity.Property(e => e.SELLINGTIME).HasComputedColumnSql("(CONVERT([time],[SELL_DATE]))", true);

                entity.Property(e => e.SELL_DATE).HasColumnType("datetime");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.REQUESTADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REQUEST_USERS");

                entity.HasOne(d => d.AGENCY)
                    .WithMany(p => p.REQUEST)
                    .HasForeignKey(d => d.AGENCYID)
                    .HasConstraintName("FK__REQUEST__AGENCYI__1BE81D6E");

                entity.HasOne(d => d.CAMPAIGN)
                    .WithMany(p => p.REQUEST)
                    .HasForeignKey(d => d.CAMPAIGNID)
                    .HasConstraintName("FK__REQUEST__CAMPAIG__1CDC41A7");

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.REQUEST)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REQUEST_CORP");

                entity.HasOne(d => d.INVOICE_ADDRESS)
                    .WithMany(p => p.REQUEST)
                    .HasForeignKey(d => d.INVOICE_ADDRESSID)
                    .HasConstraintName("FK__REQUEST__INVOICE__257C74A0");

                entity.HasOne(d => d.LANGCODENavigation)
                    .WithMany(p => p.REQUEST)
                    .HasForeignKey(d => d.LANGCODE)
                    .HasConstraintName("FK_REQUEST_STDLANGUAGES");

                entity.HasOne(d => d.PERSON)
                    .WithMany(p => p.REQUEST)
                    .HasForeignKey(d => d.PERSONID)
                    .HasConstraintName("FK_REQUEST_PERSON");

                entity.HasOne(d => d.SELLER_USER)
                    .WithMany(p => p.REQUESTSELLER_USER)
                    .HasForeignKey(d => d.SELLER_USERID)
                    .HasConstraintName("FK__REQUEST__SELLER___70B3A6A6");

                entity.HasOne(d => d.STATUSNavigation)
                    .WithMany(p => p.REQUEST)
                    .HasForeignKey(d => d.STATUS)
                    .HasConstraintName("FK_REQUEST_REQUEST_STATUS");
            });

            modelBuilder.Entity<dbo.REQUEST_CLIENTS>(entity =>
            {
                entity.HasIndex(e => e.FIRSTNAME, "IX_REQUEST_CLIENTS");

                entity.HasIndex(e => e.LASTNAME, "IX_REQUEST_CLIENTS_1");

                entity.HasIndex(e => e.REQUEST_DETAILID, "MISS_IDX_POS_PAYMENTS_LIST");

                entity.Property(e => e.BIRTHDATE).HasColumnType("datetime");

                entity.Property(e => e.ENTID).HasMaxLength(100);

                entity.Property(e => e.FIRSTNAME).HasMaxLength(100);

                entity.Property(e => e.HESCODE).HasMaxLength(60);

                entity.Property(e => e.LASTNAME).HasMaxLength(100);

                entity.HasOne(d => d.REQUEST_DETAIL)
                    .WithMany(p => p.REQUEST_CLIENTS)
                    .HasForeignKey(d => d.REQUEST_DETAILID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__REQUEST_C__REQUE__18E19391");
            });

            modelBuilder.Entity<dbo.REQUEST_DETAIL>(entity =>
            {
                entity.HasIndex(e => e.KIND, "IDX_MIS_DASHBOARD_REPORT");

                entity.HasIndex(e => new { e.STATUS, e.ROOMTYPEID, e.DATE1 }, "IX_MISSING_HOTELSEARCH1");

                entity.HasIndex(e => new { e.KIND, e.CORRELATIONID }, "IX_RD_KIND_CORRELATIOIN");

                entity.HasIndex(e => new { e.KIND, e.STATUS }, "IX_RD_KIND_STATUS");

                entity.HasIndex(e => new { e.KIND, e.SELLINGDATE }, "IX_RECOMMEND_RD_KIND_SELLINGDATE");

                entity.HasIndex(e => new { e.REQUESTID, e.KIND }, "IX_REQUEST_DETAIL");

                entity.HasIndex(e => new { e.ADDUSER, e.EDITUSER, e.REQUESTID }, "IX_REQUEST_DETAIL_1");

                entity.HasIndex(e => e.DISCOUNT_REQ, "IX_REQUEST_DETAIL_2");

                entity.HasIndex(e => e.DISCOUNT_RESULT, "IX_REQUEST_DETAIL_3");

                entity.HasIndex(e => e.SELL_DATE, "IX_REQUEST_DETAIL_4");

                entity.HasIndex(e => e.INTID, "IX_REQUEST_DETAIL_5");

                entity.HasIndex(e => new { e.REQUESTID, e.ADDUSER, e.EDITUSER }, "IX_REQUEST_DETAIL_IMP");

                entity.HasIndex(e => e.KIND, "MIS_INDEX_DASHBOARD_SALES_ANALYSIS_1");

                entity.HasIndex(e => e.SW_LOGID, "MIS_IX_REQUESTID");

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.BOARDTYPE).HasMaxLength(100);

                entity.Property(e => e.CANCELLATIONID).HasMaxLength(50);

                entity.Property(e => e.CANCELLATION_DATE).HasColumnType("datetime");

                entity.Property(e => e.CHD1_BIRTHDATE).HasColumnType("date");

                entity.Property(e => e.CHD2_BIRTHDATE).HasColumnType("date");

                entity.Property(e => e.CHD3_BIRTHDATE).HasColumnType("date");

                entity.Property(e => e.CHD4_BIRTHDATE).HasColumnType("date");

                entity.Property(e => e.CHILDAGES).HasMaxLength(40);

                entity.Property(e => e.COUNTRY).HasMaxLength(120);

                entity.Property(e => e.CREATIONDATE)
                    .HasColumnType("date")
                    .HasComputedColumnSql("(CONVERT([date],[ADDDATE]))", true);

                entity.Property(e => e.CREATIONTIME).HasComputedColumnSql("(CONVERT([time],[ADDDATE]))", true);

                entity.Property(e => e.CURCODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DATE1).HasColumnType("datetime");

                entity.Property(e => e.DATE2).HasColumnType("datetime");

                entity.Property(e => e.DESCRIPTION).HasMaxLength(250);

                entity.Property(e => e.DISCOUNT_COMBINATION).HasMaxLength(150);

                entity.Property(e => e.DISCOUNT_DESCRIPTION).HasMaxLength(250);

                entity.Property(e => e.DISCOUNT_REQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.DISCOUNT_RESULTDESC).HasMaxLength(250);

                entity.Property(e => e.DISCOUNT_TOTAL).HasComputedColumnSql("(case when [DISCOUNT_RESULT]=(1) AND [DISCOUNT_RATE]>(0) then case [DISCOUNT_REQ] when (1) then CONVERT([float],isnull([TOTAL],(0))+isnull([EXTRA_TOTAL],(0)))*(CONVERT([float],[DISCOUNT_RATE])/(100.0)) when (2) then [DISCOUNT_RATE] when (3) then (isnull([TOTAL],(0))+isnull([EXTRA_TOTAL],(0)))-[DISCOUNT_RATE] else (0) end else (0) end)", true);

                entity.Property(e => e.EDITDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EXTNOTES).HasMaxLength(250);

                entity.Property(e => e.E_BOARDTYPEID).HasMaxLength(25);

                entity.Property(e => e.E_ROOMTYPEID).HasMaxLength(25);

                entity.Property(e => e.FINALPRICES).HasMaxLength(350);

                entity.Property(e => e.GRAND_TOTAL).HasComputedColumnSql("((isnull([TOTAL],(0))+isnull([EXTRA_TOTAL],(0)))-case when [DISCOUNT_RESULT]=(1) AND [DISCOUNT_RATE]>(0) then case [DISCOUNT_REQ] when (1) then CONVERT([float],isnull([TOTAL],(0))+isnull([EXTRA_TOTAL],(0)))*(CONVERT([float],[DISCOUNT_RATE])/(100.0)) when (2) then [DISCOUNT_RATE] when (3) then (isnull([TOTAL],(0))+isnull([EXTRA_TOTAL],(0)))-[DISCOUNT_RATE] else (0) end else (0) end)", true);

                entity.Property(e => e.ICON).HasMaxLength(250);

                entity.Property(e => e.INTERVIEW_DATE).HasColumnType("datetime");

                entity.Property(e => e.INTID).ValueGeneratedOnAdd();

                entity.Property(e => e.IPADDRESS).HasMaxLength(25);

                entity.Property(e => e.ISNOTAVAILABLE).HasDefaultValueSql("((0))");

                entity.Property(e => e.MANUAL_PRICE).HasMaxLength(50);

                entity.Property(e => e.NATIONAL).HasMaxLength(10);

                entity.Property(e => e.PNR1).HasMaxLength(15);

                entity.Property(e => e.PNR2).HasMaxLength(15);

                entity.Property(e => e.PRODUCTID).HasComputedColumnSql("(coalesce([HOTELID],[TOURID],[TICKETID],[TICKETGIFTID],[TRANSFER_PRICEID]))", false);

                entity.Property(e => e.RESNO).HasMaxLength(50);

                entity.Property(e => e.ROOMTYPE).HasMaxLength(60);

                entity.Property(e => e.ROUNDTRIP)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SELLINGDATE)
                    .HasColumnType("date")
                    .HasComputedColumnSql("(CONVERT([date],[SELL_DATE]))", true);

                entity.Property(e => e.SELLINGTIME).HasComputedColumnSql("(CONVERT([time],[SELL_DATE]))", true);

                entity.Property(e => e.SELL_DATE).HasColumnType("datetime");

                entity.Property(e => e.TOTAL).HasDefaultValueSql("((0))");

                entity.Property(e => e.USE_INOFFER).HasDefaultValueSql("((1))");

                entity.Property(e => e.VALIDDATE)
                    .HasColumnType("datetime")
                    .HasComputedColumnSql("(dateadd(day,[VALIDDAY],[ADDDATE]))", true);

                entity.Property(e => e.VALIDDAY).HasDefaultValueSql("((3))");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.REQUEST_DETAILADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REQUEST_D__ADDUS__73501C2F");

                entity.HasOne(d => d.BOARDTYPENavigation)
                    .WithMany(p => p.REQUEST_DETAIL)
                    .HasForeignKey(d => d.BOARDTYPEID)
                    .HasConstraintName("FK__REQUEST_D__BOARD__265B8A40");

                entity.HasOne(d => d.CAMPAIGN)
                    .WithMany(p => p.REQUEST_DETAIL)
                    .HasForeignKey(d => d.CAMPAIGNID)
                    .HasConstraintName("FK__REQUEST_D__CAMPA__2C538F61");

                entity.HasOne(d => d.CANCELLATION_USER)
                    .WithMany(p => p.REQUEST_DETAILCANCELLATION_USER)
                    .HasForeignKey(d => d.CANCELLATION_USERID)
                    .HasConstraintName("FK_REQUEST_DETAIL_USERS");

                entity.HasOne(d => d.CORRELATION)
                    .WithMany(p => p.InverseCORRELATION)
                    .HasForeignKey(d => d.CORRELATIONID)
                    .HasConstraintName("FK__REQUEST_D__CORRE__274FAE79");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.REQUEST_DETAILEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__REQUEST_D__EDITU__753864A1");

                entity.HasOne(d => d.HOTEL)
                    .WithMany(p => p.REQUEST_DETAIL)
                    .HasForeignKey(d => d.HOTELID)
                    .HasConstraintName("FK__REQUEST_D__HOTEL__7167D3BD");

                entity.HasOne(d => d.MARKET)
                    .WithMany(p => p.REQUEST_DETAIL)
                    .HasForeignKey(d => d.MARKETID)
                    .HasConstraintName("FK__REQUEST_D__MARKE__2843D2B2");

                entity.HasOne(d => d.PRICE_CONDITION)
                    .WithMany(p => p.REQUEST_DETAIL)
                    .HasForeignKey(d => d.PRICE_CONDITIONID)
                    .HasConstraintName("FK__REQUEST_D__PRICE__652CE561");

                entity.HasOne(d => d.PROJECT_DETAIL)
                    .WithMany(p => p.REQUEST_DETAIL)
                    .HasForeignKey(d => d.PROJECT_DETAILID)
                    .HasConstraintName("FK__REQUEST_D__PROJE__5B638405");

                entity.HasOne(d => d.PROMOTION)
                    .WithMany(p => p.REQUEST_DETAIL)
                    .HasForeignKey(d => d.PROMOTIONID)
                    .HasConstraintName("FK__REQUEST_D__PROMO__1E7A7156");

                entity.HasOne(d => d.RATECODE)
                    .WithMany(p => p.REQUEST_DETAIL)
                    .HasForeignKey(d => d.RATECODEID)
                    .HasConstraintName("FK__REQUEST_D__RATEC__2937F6EB");

                entity.HasOne(d => d.RATETYPE)
                    .WithMany(p => p.REQUEST_DETAIL)
                    .HasForeignKey(d => d.RATETYPEID)
                    .HasConstraintName("FK__REQUEST_D__RATET__530E3526");

                entity.HasOne(d => d.REQUEST)
                    .WithMany(p => p.REQUEST_DETAIL)
                    .HasForeignKey(d => d.REQUESTID)
                    .HasConstraintName("FK__REQUEST_D__REQUE__7073AF84");

                entity.HasOne(d => d.RESERVATION_SETTINGS)
                    .WithMany(p => p.REQUEST_DETAIL)
                    .HasForeignKey(d => d.RESERVATION_SETTINGSID)
                    .HasConstraintName("FK__REQUEST_D__RESER__6418C597");

                entity.HasOne(d => d.RESOURCE)
                    .WithMany(p => p.REQUEST_DETAIL)
                    .HasForeignKey(d => d.RESOURCEID)
                    .HasConstraintName("FK__REQUEST_D__RESOU__4C214075");

                entity.HasOne(d => d.ROOMTYPENavigation)
                    .WithMany(p => p.REQUEST_DETAIL)
                    .HasForeignKey(d => d.ROOMTYPEID)
                    .HasConstraintName("FK__REQUEST_D__ROOMT__2A2C1B24");

                entity.HasOne(d => d.SELLER_USER)
                    .WithMany(p => p.REQUEST_DETAILSELLER_USER)
                    .HasForeignKey(d => d.SELLER_USERID)
                    .HasConstraintName("FK__REQUEST_D__SELLE__2B203F5D");

                entity.HasOne(d => d.STATUSNavigation)
                    .WithMany(p => p.REQUEST_DETAILSTATUSNavigation)
                    .HasForeignKey(d => d.STATUS)
                    .HasConstraintName("FK__REQUEST_D__STATU__05A3D694");

                entity.HasOne(d => d.SUBSTATUSNavigation)
                    .WithMany(p => p.REQUEST_DETAILSUBSTATUSNavigation)
                    .HasForeignKey(d => d.SUBSTATUS)
                    .HasConstraintName("FK__REQUEST_D__SUBST__0697FACD");

                entity.HasOne(d => d.TICKETGIFT)
                    .WithMany(p => p.REQUEST_DETAIL)
                    .HasForeignKey(d => d.TICKETGIFTID)
                    .HasConstraintName("FK__REQUEST_D__TICKE__2D0887CF");

                entity.HasOne(d => d.TICKET)
                    .WithMany(p => p.REQUEST_DETAIL)
                    .HasForeignKey(d => d.TICKETID)
                    .HasConstraintName("FK__REQUEST_D__TICKE__2DFCAC08");

                entity.HasOne(d => d.TICKET_PRICE)
                    .WithMany(p => p.REQUEST_DETAIL)
                    .HasForeignKey(d => d.TICKET_PRICEID)
                    .HasConstraintName("FK__REQUEST_D__TICKE__2C146396");

                entity.HasOne(d => d.TOUR)
                    .WithMany(p => p.REQUEST_DETAIL)
                    .HasForeignKey(d => d.TOURID)
                    .HasConstraintName("FK__REQUEST_D__TOURI__1F798287");

                entity.HasOne(d => d.VEHICLE)
                    .WithMany(p => p.REQUEST_DETAIL)
                    .HasForeignKey(d => d.VEHICLEID)
                    .HasConstraintName("FK__REQUEST_D__VEHIC__40106F4B");
            });

            modelBuilder.Entity<dbo.REQUEST_DETAIL_ORGDATA>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__REQUEST___3214EC267DBA7FEF")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.REQUEST_DETAIL)
                    .WithMany(p => p.REQUEST_DETAIL_ORGDATA)
                    .HasForeignKey(d => d.REQUEST_DETAILID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REQUEST_D__REQUE__26667738");
            });

            modelBuilder.Entity<dbo.REQUEST_NOTES>(entity =>
            {
                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.REQUEST_NOTESADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REQUEST_N__ADDUS__78BEDCC2");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.REQUEST_NOTESEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK_REQUEST_NOTES_USERS");

                entity.HasOne(d => d.REQUEST)
                    .WithMany(p => p.REQUEST_NOTES)
                    .HasForeignKey(d => d.REQUESTID)
                    .HasConstraintName("FK__REQUEST_N__REQUE__76D69450");
            });

            modelBuilder.Entity<dbo.REQUEST_PAYMENTS>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__REQUEST___3214EC2642FAFE10")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ENTID).HasMaxLength(150);

                entity.HasOne(d => d.PAYMENT)
                    .WithMany(p => p.REQUEST_PAYMENTS)
                    .HasForeignKey(d => d.PAYMENTID)
                    .HasConstraintName("FK_REQUEST_PAYMENTS_PAYMENTS");

                entity.HasOne(d => d.REQUEST_DETAIL)
                    .WithMany(p => p.REQUEST_PAYMENTS)
                    .HasForeignKey(d => d.REQUEST_DETAILID)
                    .HasConstraintName("FK__REQUEST_P__REQUE__43E1002F");

                entity.HasOne(d => d.VIRTUAL_POS_DEP_PAYMENT)
                    .WithMany(p => p.REQUEST_PAYMENTS)
                    .HasForeignKey(d => d.VIRTUAL_POS_DEP_PAYMENTID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__REQUEST_P__VIRTU__31233176");

                entity.HasOne(d => d.VIRTUAL_POS_DEP_PAYMENT_CANCEL)
                    .WithMany(p => p.REQUEST_PAYMENTS)
                    .HasForeignKey(d => d.VIRTUAL_POS_DEP_PAYMENT_CANCELID)
                    .HasConstraintName("FK__REQUEST_P__VIRTU__2764BD12");

                entity.HasOne(d => d.VIRTUAL_POS_PAYMENT)
                    .WithMany(p => p.REQUEST_PAYMENTS)
                    .HasForeignKey(d => d.VIRTUAL_POS_PAYMENTID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__REQUEST_P__VIRTU__44D52468");

                entity.HasOne(d => d.VIRTUAL_POS_PAYMENT_CANCEL)
                    .WithMany(p => p.REQUEST_PAYMENTS)
                    .HasForeignKey(d => d.VIRTUAL_POS_PAYMENT_CANCELID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__REQUEST_P__VIRTU__267098D9");
            });

            modelBuilder.Entity<dbo.REQUEST_STATUS>(entity =>
            {
                entity.HasIndex(e => e.SUBSTATUS, "IX_REQUEST_STATUS");

                entity.HasIndex(e => e.TYPE, "IX_REQUEST_STATUS_1");

                entity.HasIndex(e => e.SORTORDER, "IX_REQUEST_STATUS_2");

                entity.HasIndex(e => new { e.SORTORDER, e.TYPE }, "IX_REQUEST_STATUS_3");

                entity.HasIndex(e => new { e.SUBSTATUS, e.TYPE }, "IX_REQUEST_STATUS_4");

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ALLOWED_SUBSTATUS).HasMaxLength(20);

                entity.Property(e => e.DESCRIPTION).HasMaxLength(200);

                entity.Property(e => e.RAKAM_ID).HasMaxLength(15);

                entity.Property(e => e.SUBSTATUS).HasComment("0=Active,1=Pasive");
            });

            modelBuilder.Entity<dbo.REQUEST_YDK>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ADDDATE).HasColumnType("datetime");

                entity.Property(e => e.CAMPAIGNCODE).HasMaxLength(100);

                entity.Property(e => e.CREATIONDATE).HasColumnType("date");

                entity.Property(e => e.CURCODE)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DIRECT_BRANDING).HasMaxLength(15);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.RAKAM_ID).HasMaxLength(15);

                entity.Property(e => e.REQ_URL).HasMaxLength(500);

                entity.Property(e => e.RESNO).HasMaxLength(200);

                entity.Property(e => e.SELLINGDATE).HasColumnType("date");

                entity.Property(e => e.SELL_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<dbo.RESERVATION_EMAILS>(entity =>
            {
                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.BCC_EMAILS).HasMaxLength(500);

                entity.Property(e => e.CC_EMAILS).HasMaxLength(500);

                entity.Property(e => e.TO_EMAILS).HasMaxLength(500);

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.RESERVATION_EMAILS)
                    .HasForeignKey(d => d.CORPID)
                    .HasConstraintName("FK__RESERVATI__CORPI__38845C1C");

                entity.HasOne(d => d.PROJECT_DETAIL)
                    .WithMany(p => p.RESERVATION_EMAILS)
                    .HasForeignKey(d => d.PROJECT_DETAILID)
                    .HasConstraintName("FK__RESERVATI__PROJE__39788055");
            });

            modelBuilder.Entity<dbo.RESERVATION_RULES>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__RESERVAT__3214EC267337F112")
                    .IsClustered(false);

                entity.HasIndex(e => e.PROJECT_DETAILID, "UQ__RESERVAT__2639F4EA0E443A89")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.GENERAL_RULES).HasColumnType("ntext");

                entity.Property(e => e.REFUND_RULES).HasColumnType("ntext");

                entity.HasOne(d => d.PROJECT_DETAIL)
                    .WithOne(p => p.RESERVATION_RULES)
                    .HasForeignKey<dbo.RESERVATION_RULES>(d => d.PROJECT_DETAILID)
                    .HasConstraintName("FK__RESERVATI__PROJE__22A007F5");
            });

            modelBuilder.Entity<dbo.RESERVATION_SETTINGS>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__RESERVAT__3214EC26B5F16E6C")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.STARTDATE, e.FINISHDATE }, "IX_RESERVATION_SETTINGS");

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CANCELLATION_WARRANTY_RATE_MAX_DAY).HasDefaultValueSql("((0))");

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.FINISHDATE).HasColumnType("datetime");

                entity.Property(e => e.PAYMENT_RATE_MAX_DAY).HasDefaultValueSql("((0))");

                entity.Property(e => e.STARTDATE).HasColumnType("datetime");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.RESERVATION_SETTINGS)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RESERVATI__ADDUS__66010E09");

                entity.HasOne(d => d.HOTEL)
                    .WithMany(p => p.RESERVATION_SETTINGS)
                    .HasForeignKey(d => d.HOTELID)
                    .HasConstraintName("FK__RESERVATI__HOTEL__5A8F5B5D");

                entity.HasOne(d => d.TICKET)
                    .WithMany(p => p.RESERVATION_SETTINGS)
                    .HasForeignKey(d => d.TICKETID)
                    .HasConstraintName("FK__RESERVATI__TICKE__5C77A3CF");

                entity.HasOne(d => d.TOUR)
                    .WithMany(p => p.RESERVATION_SETTINGS)
                    .HasForeignKey(d => d.TOURID)
                    .HasConstraintName("FK__RESERVATI__TOURI__5B837F96");
            });

            modelBuilder.Entity<dbo.RESERVATION_SETTINGS_MARKET>(entity =>
            {
                entity.HasIndex(e => new { e.SETTINGSID, e.MARKETID }, "UQ__RESERVATION_SETTINGS__4B96FBB176D8588E")
                    .IsUnique();

                entity.HasOne(d => d.MARKET)
                    .WithMany(p => p.RESERVATION_SETTINGS_MARKET)
                    .HasForeignKey(d => d.MARKETID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RESERVATION_SETTINGS___MARKE__54D68207");

                entity.HasOne(d => d.SETTINGS)
                    .WithMany(p => p.RESERVATION_SETTINGS_MARKET)
                    .HasForeignKey(d => d.SETTINGSID)
                    .HasConstraintName("FK__RESERVATION_SETTINGS___DISCO__53E25DCE");
            });

            modelBuilder.Entity<dbo.RESOURCES>(entity =>
            {
                entity.HasIndex(e => new { e.CODE, e.CORPID }, "IX_RESOURCES")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CODE).HasMaxLength(30);

                entity.Property(e => e.DEFAULT_DIRECT_BRANDING).HasMaxLength(15);

                entity.Property(e => e.DESCRIPTION).HasMaxLength(150);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.ICON).HasMaxLength(35);

                entity.Property(e => e.RAKAM_DESC).HasMaxLength(50);

                entity.Property(e => e.RESOURCESPATH)
                    .HasMaxLength(500)
                    .HasComputedColumnSql("([DBO].[FN_RESOURCE_PATH]([CODE],[CORPID]))", false);

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.RESOURCESADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RESOURCES__ADDUS__70DDC3D8");

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.RESOURCES)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RESOURCES_CORP");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.RESOURCESEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__RESOURCES__EDITU__72C60C4A");
            });

            modelBuilder.Entity<dbo.RESOURCE_BUDGET>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AMOUNT).HasDefaultValueSql("((0))");

                entity.Property(e => e.CURCODE)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.INCOME_AMOUNT).HasDefaultValueSql("((0))");

                entity.Property(e => e.TDATE).HasColumnType("date");

                entity.HasOne(d => d.CORP)
                    .WithMany()
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RESOURCE___CORPI__3B60C8C7");

                entity.HasOne(d => d.PROJECT_DETAIL)
                    .WithMany()
                    .HasForeignKey(d => d.PROJECT_DETAILID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RESOURCE___PROJE__3C89F72A");

                entity.HasOne(d => d.RESOURCE)
                    .WithMany()
                    .HasForeignKey(d => d.RESOURCEID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RESOURCE___RESOU__3AA1AEB8");
            });

            modelBuilder.Entity<dbo.RESOURCE_DETAIL>(entity =>
            {
                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DESCRIPTION).HasMaxLength(150);

                entity.Property(e => e.DETAIL).HasMaxLength(150);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.RESOURCE_DETAILADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RESOURCE___ADDUS__08B54D69");

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.RESOURCE_DETAIL)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RESOURCE___CORPI__3B40CD36");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.RESOURCE_DETAILEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__RESOURCE___EDITU__0A9D95DB");

                entity.HasOne(d => d.PROJECT_GROUPDETAIL)
                    .WithMany(p => p.RESOURCE_DETAIL)
                    .HasForeignKey(d => d.PROJECT_GROUPDETAILID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RESOURCE___PROJE__3D2915A8");
            });

            modelBuilder.Entity<dbo.ROLES>(entity =>
            {
                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.NAME).HasMaxLength(100);

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.ROLESADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ROLES__ADDUSER__412EB0B6");

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.ROLES)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ROLES_CORP");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.ROLESEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__ROLES__EDITUSER__4316F928");
            });

            modelBuilder.Entity<dbo.ROLES_CUSTOMAUTH>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<dbo.ROLES_DASHBOARDS>(entity =>
            {
                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.DASHBOARD)
                    .WithMany(p => p.ROLES_DASHBOARDS)
                    .HasForeignKey(d => d.DASHBOARDID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ROLES_DAS__DASHB__4A38F803");

                entity.HasOne(d => d.ROLE)
                    .WithMany(p => p.ROLES_DASHBOARDS)
                    .HasForeignKey(d => d.ROLEID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ROLES_DAS__ROLEI__4944D3CA");
            });

            modelBuilder.Entity<dbo.ROLE_AUTH>(entity =>
            {
                entity.HasIndex(e => new { e.ROLEID, e.MODULENAME }, "IX_ROLE_AUTH")
                    .IsUnique();

                entity.Property(e => e.MODULENAME).HasMaxLength(150);

                entity.HasOne(d => d.ROLE)
                    .WithMany(p => p.ROLE_AUTH)
                    .HasForeignKey(d => d.ROLEID)
                    .HasConstraintName("FK__ROLE_AUTH__ROLEI__40F9A68C");
            });

            modelBuilder.Entity<dbo.SALES_REQ>(entity =>
            {
                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.SALES_REQADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SALES_REQ__ADDUS__282DF8C2");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.SALES_REQEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__SALES_REQ__EDITU__2A164134");

                entity.HasOne(d => d.PERSON)
                    .WithMany(p => p.SALES_REQ)
                    .HasForeignKey(d => d.PERSONID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SALES_REQ__PERSO__25518C17");

                entity.HasOne(d => d.RESOURCE_DETAIL)
                    .WithMany(p => p.SALES_REQ)
                    .HasForeignKey(d => d.RESOURCE_DETAILID)
                    .HasConstraintName("FK__SALES_REQ__RESOU__4AA30C57");
            });

            modelBuilder.Entity<dbo.SIL>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ISOCODE2)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.dial_code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.name)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<dbo.SMS_MESSAGE>(entity =>
            {
                entity.Property(e => e.MESSAGEBODY).HasMaxLength(400);

                entity.Property(e => e.SENDDATE).HasColumnType("datetime");

                entity.Property(e => e.SENDERROR).HasMaxLength(250);

                entity.Property(e => e.TYPE).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.REQUEST_DETAIL)
                    .WithMany(p => p.SMS_MESSAGE)
                    .HasForeignKey(d => d.REQUEST_DETAILID)
                    .HasConstraintName("FK__SMS_MAIL__REQUE__3A6282ED");

                entity.HasOne(d => d.SMS)
                    .WithMany(p => p.SMS_MESSAGE)
                    .HasForeignKey(d => d.SMSID)
                    .HasConstraintName("FK__SMS_MESSA__SMSID__4E739D3B");
            });

            modelBuilder.Entity<dbo.SMS_SETTINGS>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__SMS_SETT__3214EC268E118F99")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.PARAM).HasMaxLength(100);

                entity.Property(e => e.PASS).HasMaxLength(100);

                entity.Property(e => e.SENDER).HasMaxLength(100);

                entity.Property(e => e.SMSCLASSNAME).HasMaxLength(100);

                entity.Property(e => e.USERNAME).HasMaxLength(100);

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.SMS_SETTINGSADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SMS_SETTI__ADDUS__03E676AB");

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.SMS_SETTINGS)
                    .HasForeignKey(d => d.CORPID)
                    .HasConstraintName("FK__SMS_SETTI__CORPI__04DA9AE4");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.SMS_SETTINGSEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__SMS_SETTI__EDITU__05CEBF1D");

                entity.HasOne(d => d.PROJECT)
                    .WithMany(p => p.SMS_SETTINGS)
                    .HasForeignKey(d => d.PROJECTID)
                    .HasConstraintName("FK__SMS_SETT__PROJE__3B6BB5BF");

                entity.HasOne(d => d.PROJECT_DETAIL)
                    .WithMany(p => p.SMS_SETTINGS)
                    .HasForeignKey(d => d.PROJECT_DETAILID)
                    .HasConstraintName("FK__SMS_SETT__PROJE__3C5FD9F8");
            });

            modelBuilder.Entity<dbo.SMTP_MAILS>(entity =>
            {
                entity.HasIndex(e => e.SENDDATE, "IX_SMTP_MAILS");

                entity.HasIndex(e => e.SENDDATE, "IX_SMTP_MAILS_1");

                entity.HasIndex(e => e.ISSENT, "IX_SMTP_MAILS_2");

                entity.HasIndex(e => new { e.REQUESTID, e._TO }, "IX_SMTP_MAILS_3");

                entity.Property(e => e.HOST).HasMaxLength(100);

                entity.Property(e => e.SENDDATE).HasColumnType("datetime");

                entity.Property(e => e.SENDERMAIL).HasMaxLength(200);

                entity.Property(e => e.SENDERNAME).HasMaxLength(150);

                entity.Property(e => e.SENDERROR).HasMaxLength(250);

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");

                entity.Property(e => e._CC).HasMaxLength(350);

                entity.Property(e => e._TO).HasMaxLength(350);

                entity.HasOne(d => d.REPORT)
                    .WithMany(p => p.SMTP_MAILS)
                    .HasForeignKey(d => d.REPORTID)
                    .HasConstraintName("FK__SMTP_MAIL__REPOR__55209ACA");

                entity.HasOne(d => d.REQUEST)
                    .WithMany(p => p.SMTP_MAILS)
                    .HasForeignKey(d => d.REQUESTID)
                    .HasConstraintName("FK__SMTP_MAIL__REQUE__54A177DD");

                entity.HasOne(d => d.REQUEST_DETAIL)
                    .WithMany(p => p.SMTP_MAILS)
                    .HasForeignKey(d => d.REQUEST_DETAILID)
                    .HasConstraintName("FK__SMTP_MAIL__REQUE__3A6282ED");

                entity.HasOne(d => d.SMTP)
                    .WithMany(p => p.SMTP_MAILS)
                    .HasForeignKey(d => d.SMTPID)
                    .HasConstraintName("FK__SMTP_MAIL__SMTPI__5614BF03");
            });

            modelBuilder.Entity<dbo.SMTP_SETTINGS>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__SMTP_SET__3214EC2647672D81")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DOMAIN).HasMaxLength(100);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.HOST).HasMaxLength(100);

                entity.Property(e => e.PASS).HasMaxLength(100);

                entity.Property(e => e.PORTNO).HasDefaultValueSql("((25))");

                entity.Property(e => e.SENDERMAIL).HasMaxLength(100);

                entity.Property(e => e.SENDERNAME).HasMaxLength(150);

                entity.Property(e => e.TSL).HasMaxLength(25);

                entity.Property(e => e.USERNAME).HasMaxLength(100);

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.SMTP_SETTINGSADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SMTP_SETT__ADDUS__57FD0775");

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.SMTP_SETTINGS)
                    .HasForeignKey(d => d.CORPID)
                    .HasConstraintName("FK__SMTP_SETT__CORPI__07B7078F");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.SMTP_SETTINGSEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__SMTP_SETT__EDITU__08AB2BC8");

                entity.HasOne(d => d.PROJECT)
                    .WithMany(p => p.SMTP_SETTINGS)
                    .HasForeignKey(d => d.PROJECTID)
                    .HasConstraintName("FK__SMTP_SETT__PROJE__3B6BB5BF");
            });

            modelBuilder.Entity<dbo.SNT_AGENT_STATUS>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_AGENT_STATUS");

                entity.Property(e => e.AGENTNAME).HasMaxLength(150);

                entity.Property(e => e.ENDTIME).HasColumnType("datetime");

                entity.Property(e => e.ID).ValueGeneratedOnAdd();

                entity.Property(e => e.STARTTIME).HasColumnType("datetime");

                entity.Property(e => e.STATU).HasMaxLength(30);
            });

            modelBuilder.Entity<dbo.SNT_CALLBACK_IGNORES>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_CALLBACK_IGNORES");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Number).HasMaxLength(25);
            });

            modelBuilder.Entity<dbo.SNT_CALLS>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_CALLS");

                entity.Property(e => e.AGENT)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CHN)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.FULLNAME).HasMaxLength(212);

                entity.Property(e => e.PHN)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PHONENUMBER).HasMaxLength(30);

                entity.Property(e => e.PROJECTGROUP).HasMaxLength(150);

                entity.Property(e => e.accountcode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.amaflags)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.answer).HasColumnType("datetime");

                entity.Property(e => e.calldate).HasColumnType("datetime");

                entity.Property(e => e.callednumber).HasMaxLength(50);

                entity.Property(e => e.callerid).HasMaxLength(30);

                entity.Property(e => e.channel)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.clid)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.dcontext)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.disposition)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.dst)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.dstchannel)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.end).HasColumnType("datetime");

                entity.Property(e => e.lastapp)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.lastdata)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.src)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.start).HasColumnType("datetime");

                entity.Property(e => e.uniqueid)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.userfield)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<dbo.SNT_CALL_DETAIL>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_CALL_DETAIL");

                entity.Property(e => e.CDATE).HasColumnType("date");

                entity.Property(e => e._event)
                    .HasMaxLength(32)
                    .HasColumnName("event");

                entity.Property(e => e.agent).HasMaxLength(32);

                entity.Property(e => e.answer).HasColumnType("datetime");

                entity.Property(e => e.calldate).HasColumnType("datetime");

                entity.Property(e => e.channel)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.clid)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.dcontext)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.disposition)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.dst)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.end).HasColumnType("datetime");

                entity.Property(e => e.lastapp)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.lastdata)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.queuename).HasMaxLength(32);

                entity.Property(e => e.src)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.start).HasColumnType("datetime");

                entity.Property(e => e.uniqueid)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.userfield)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<dbo.SNT_CALL_JOBS>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_CALL_JOBS");

                entity.Property(e => e.CALLTIME).HasColumnType("datetime");

                entity.Property(e => e.CAMPAIGNCODE)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.FULLNAME).HasMaxLength(212);

                entity.Property(e => e.KIND)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OUTPUT_EXTEN).HasMaxLength(150);

                entity.Property(e => e.PHONENUMBER).HasMaxLength(50);

                entity.Property(e => e.QUEUENAME)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.REASON)
                    .HasMaxLength(33)
                    .IsUnicode(false);

                entity.Property(e => e.SDATE).HasColumnType("datetime");

                entity.Property(e => e.SORTFLD).HasColumnType("datetime");

                entity.Property(e => e.STATE).HasMaxLength(25);

                entity.Property(e => e.USERNAME).HasMaxLength(100);
            });

            modelBuilder.Entity<dbo.SNT_CALL_LIST>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_CALL_LIST");

                entity.Property(e => e.AGENT).HasMaxLength(100);

                entity.Property(e => e.CALLTIME).HasColumnType("datetime");

                entity.Property(e => e.LAST_CALLTIME).HasColumnType("datetime");

                entity.Property(e => e.OUTPUT_EXTEN).HasMaxLength(150);

                entity.Property(e => e.PHONE).HasMaxLength(255);

                entity.Property(e => e.PHONENUMBER).HasMaxLength(50);

                entity.Property(e => e.QUEUENAME)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.STATE).HasMaxLength(25);

                entity.Property(e => e.TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<dbo.SNT_CALL_LIST_ORG>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_CALL_LIST_ORG");

                entity.Property(e => e.CALLID).HasMaxLength(32);

                entity.Property(e => e.CALLTIME).HasColumnType("datetime");

                entity.Property(e => e.ID).ValueGeneratedOnAdd();

                entity.Property(e => e.KIND)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OUTPUT_EXTEN).HasMaxLength(150);

                entity.Property(e => e.PHONENUMBER).HasMaxLength(50);

                entity.Property(e => e.SDATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<dbo.SNT_CALL_STATUS>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_CALL_STATUS");

                entity.Property(e => e.DESCRIPTION).HasMaxLength(25);

                entity.Property(e => e.ID).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<dbo.SNT_CALL_SUMMARY>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_CALL_SUMMARY");

                entity.Property(e => e.CALLTIME).HasMaxLength(53);

                entity.Property(e => e.CDATE).HasColumnType("date");

                entity.Property(e => e.RESCALLTIME).HasMaxLength(53);
            });

            modelBuilder.Entity<dbo.SNT_CALL_TOTALS>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_CALL_TOTALS");

                entity.Property(e => e.CAMPAIGN).HasMaxLength(100);

                entity.Property(e => e.CDATE).HasColumnType("date");

                entity.Property(e => e.CDAYNAME)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.CMONTHNAME)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.PRODUCTNAME).HasMaxLength(200);

                entity.Property(e => e.PROJECTNAME).HasMaxLength(150);
            });

            modelBuilder.Entity<dbo.SNT_CDR>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_CDR");

                entity.Property(e => e.accountcode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.amaflags)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.answer).HasColumnType("datetime");

                entity.Property(e => e.calldate).HasColumnType("datetime");

                entity.Property(e => e.callednumber).HasMaxLength(50);

                entity.Property(e => e.callerid).HasMaxLength(30);

                entity.Property(e => e.channel)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.clid)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.dcontext)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.disposition)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.dst)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.dstchannel)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.end).HasColumnType("datetime");

                entity.Property(e => e.exten)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.lastapp)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.lastdata)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.peername)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.src)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.start).HasColumnType("datetime");

                entity.Property(e => e.tdate).HasColumnType("date");

                entity.Property(e => e.uniqueid)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.userfield)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<dbo.SNT_CDR_REPORT>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_CDR_REPORT");

                entity.Property(e => e.CAMPAIGN).HasMaxLength(100);

                entity.Property(e => e.CDATE).HasColumnType("datetime");

                entity.Property(e => e.CDAYNAME)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.CMONTHNAME)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.PEERNAME)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PERSONNAME).HasMaxLength(212);

                entity.Property(e => e.PRODUCTNAME).HasMaxLength(200);

                entity.Property(e => e.PROJECTNAME).HasMaxLength(150);

                entity.Property(e => e.answer).HasColumnType("datetime");

                entity.Property(e => e.callednumber).HasMaxLength(50);

                entity.Property(e => e.disposition)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.end).HasColumnType("datetime");

                entity.Property(e => e.exten)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.src)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.start).HasColumnType("datetime");

                entity.Property(e => e.uniqueid)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.userfield)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<dbo.SNT_DBS>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_DBS");

                entity.Property(e => e.DATABASENAME).HasMaxLength(50);

                entity.Property(e => e.DENIFITION).HasMaxLength(100);

                entity.Property(e => e.IPADDRESS).HasMaxLength(30);

                entity.Property(e => e.PASS).HasMaxLength(30);

                entity.Property(e => e.TYPE).HasMaxLength(15);

                entity.Property(e => e.USERNAME).HasMaxLength(30);
            });

            modelBuilder.Entity<dbo.SNT_DIAGRAM>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_DIAGRAM");

                entity.Property(e => e.description).HasMaxLength(40);
            });

            modelBuilder.Entity<dbo.SNT_DIAGRAM_CHILDKEYS>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_DIAGRAM_CHILDKEYS");

                entity.Property(e => e.key)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<dbo.SNT_DIAGRAM_SHAPES>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_DIAGRAM_SHAPES");

                entity.Property(e => e.key)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.text).HasMaxLength(254);

                entity.Property(e => e.type).HasMaxLength(200);
            });

            modelBuilder.Entity<dbo.SNT_DIAL_PLAN>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_DIAL_PLAN");

                entity.Property(e => e.APP).HasMaxLength(100);

                entity.Property(e => e.APPDATA).HasMaxLength(250);

                entity.Property(e => e.GROUPNAME).HasMaxLength(150);
            });

            modelBuilder.Entity<dbo.SNT_LANGUAGE_COUNTRIES>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_LANGUAGE_COUNTRIES");

                entity.Property(e => e.COUNTRYCODE)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LANGCODE).HasMaxLength(5);
            });

            modelBuilder.Entity<dbo.SNT_MISSEDCALLS>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_MISSEDCALLS");

                entity.Property(e => e.CALLTIME).HasColumnType("datetime");

                entity.Property(e => e.KIND)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OUTPUT_EXTEN).HasMaxLength(150);

                entity.Property(e => e.PHONE).HasMaxLength(255);

                entity.Property(e => e.PHONENUMBER).HasMaxLength(50);

                entity.Property(e => e.QUEUENAME)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.SDATE).HasColumnType("datetime");

                entity.Property(e => e.SORTFLD).HasColumnType("datetime");

                entity.Property(e => e.STATE).HasMaxLength(25);

                entity.Property(e => e._event)
                    .HasMaxLength(32)
                    .HasColumnName("event");

                entity.Property(e => e.agent)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.callednumber).HasMaxLength(50);

                entity.Property(e => e.name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<dbo.SNT_MISSEDCALLS_ALL>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_MISSEDCALLS_ALL");

                entity.Property(e => e.CALLTIME).HasColumnType("datetime");

                entity.Property(e => e.KIND)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OUTPUT_EXTEN).HasMaxLength(150);

                entity.Property(e => e.PHONE).HasMaxLength(255);

                entity.Property(e => e.PHONENUMBER).HasMaxLength(50);

                entity.Property(e => e.QUEUENAME)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.SDATE).HasColumnType("datetime");

                entity.Property(e => e.SORTFLD).HasColumnType("datetime");

                entity.Property(e => e.STATE).HasMaxLength(25);

                entity.Property(e => e._event)
                    .HasMaxLength(32)
                    .HasColumnName("event");

                entity.Property(e => e.agent)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.callednumber).HasMaxLength(50);

                entity.Property(e => e.name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.userfield)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<dbo.SNT_QUEUES>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_QUEUES");

                entity.Property(e => e.announce)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.announce_holdtime)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.autofill).HasMaxLength(15);

                entity.Property(e => e.autopause).HasMaxLength(15);

                entity.Property(e => e.context)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.joinempty)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.leavewhenempty)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.monitor_format)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.musiconhold)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.name)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.periodic_announce)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.queue_callswaiting)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.queue_holdtime)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.queue_lessthan)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.queue_minutes)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.queue_reporthold)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.queue_seconds)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.queue_thankyou)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.queue_thereare)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.queue_youarenext)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.strategy)
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<dbo.SNT_QUEUE_ABANDON>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_QUEUE_ABANDON");
            });

            modelBuilder.Entity<dbo.SNT_QUEUE_LOG>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_QUEUE_LOG");

                entity.Property(e => e._event)
                    .HasMaxLength(32)
                    .HasColumnName("event");

                entity.Property(e => e.agent).HasMaxLength(32);

                entity.Property(e => e.callid).HasMaxLength(32);

                entity.Property(e => e.data).HasMaxLength(255);

                entity.Property(e => e.data1).HasMaxLength(255);

                entity.Property(e => e.data2).HasMaxLength(255);

                entity.Property(e => e.data3).HasMaxLength(255);

                entity.Property(e => e.data4).HasMaxLength(255);

                entity.Property(e => e.data5).HasMaxLength(255);

                entity.Property(e => e.id).ValueGeneratedOnAdd();

                entity.Property(e => e.logdate).HasColumnType("date");

                entity.Property(e => e.queuename).HasMaxLength(32);
            });

            modelBuilder.Entity<dbo.SNT_QUEUE_MEMBERS>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_QUEUE_MEMBERS");

                entity.Property(e => e._interface)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("interface");

                entity.Property(e => e.membername)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.queue_name)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.uniqueid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<dbo.SNT_REPORT>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_REPORT");

                entity.Property(e => e.CAMPAIGN).HasMaxLength(100);

                entity.Property(e => e.CDAYNAME)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.CMONTHNAME)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.HAT)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PRODUCTNAME).HasMaxLength(250);

                entity.Property(e => e.PROJECTNAME).HasMaxLength(150);

                entity.Property(e => e._event)
                    .HasMaxLength(32)
                    .HasColumnName("event");

                entity.Property(e => e.accountcode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.agent)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.amaflags)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.answer).HasColumnType("datetime");

                entity.Property(e => e.calldate).HasColumnType("datetime");

                entity.Property(e => e.callednumber).HasMaxLength(50);

                entity.Property(e => e.callerid).HasMaxLength(30);

                entity.Property(e => e.channel)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.clid)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.dcontext)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.disposition)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.dst)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.dstchannel)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.end).HasColumnType("datetime");

                entity.Property(e => e.exten)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.fromuser)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.lastapp)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.lastdata)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.peername)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.queuename).HasMaxLength(32);

                entity.Property(e => e.src)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.start).HasColumnType("datetime");

                entity.Property(e => e.tdate).HasColumnType("date");

                entity.Property(e => e.uniqueid)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.userfield)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<dbo.SNT_RT_SIPPEERS>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_RT_SIPPEERS");

                entity.Property(e => e.accountcode)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.allow)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.allowoverlap)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.allowsubscribe)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.allowtransfer)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.amaflags)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.auth)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.autoframing)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.buggymwi)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.call_limit).HasColumnName("call-limit");

                entity.Property(e => e.callbackextension)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.callcounter)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.callerid)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.callgroup)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.callingpres)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.cid_number)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.constantssrc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.contactdeny)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.contactpermit)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.context)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.defaultip)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.defaultuser)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.deny)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.directmedia)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.disallow)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.dtmfmode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.dynamic)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.extension).HasMaxLength(50);

                entity.Property(e => e.faxdetect)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.fromdomain)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.fromuser)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.fullcontact)
                    .HasMaxLength(135)
                    .IsUnicode(false);

                entity.Property(e => e.fullname)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.g726nonstandard)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.hasvoicemail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.host)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.id).ValueGeneratedOnAdd();

                entity.Property(e => e.ignoresdpversion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.insecure)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ipaddr)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.language)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.mailbox)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.md5secret)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.mohinterpret)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.mohsuggest)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.nat)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.outboundproxy)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.parkinglot)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.permit)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.pickupgroup)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.progressinband)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.promiscredir)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.qualify)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.regexten)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.regserver)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.remotesecret)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.rfc2833compensate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.secret)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.sendrpid)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.session_expires).HasColumnName("session-expires");

                entity.Property(e => e.session_minse).HasColumnName("session-minse");

                entity.Property(e => e.session_refresher)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("session-refresher");

                entity.Property(e => e.session_timers)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("session-timers");

                entity.Property(e => e.setvar)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.subscribemwi)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.t38pt_usertpsource)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.textsupport)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.transport)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.trunkname)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.trustrpid)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.type)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.useclientcode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.useragent)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.usereqphone)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.videosupport)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.vmexten)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<dbo.SNT_SIPPEERS>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_SIPPEERS");

                entity.Property(e => e.accountcode)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.allow)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.allowoverlap)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.allowsubscribe)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.allowtransfer)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.amaflags)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.auth)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.autoframing)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.buggymwi)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.call_limit).HasColumnName("call-limit");

                entity.Property(e => e.callbackextension)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.callcounter)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.callerid)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.callgroup)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.callingpres)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.cid_number)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.constantssrc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.contactdeny)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.contactpermit)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.context)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.defaultip)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.defaultuser)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.deny)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.directmedia)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.disallow)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.dtmfmode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.dynamic)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.extension).HasMaxLength(50);

                entity.Property(e => e.faxdetect)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.fromdomain)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.fromuser)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.fullcontact)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.fullname)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.g726nonstandard)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.hasvoicemail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.host)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.id).ValueGeneratedOnAdd();

                entity.Property(e => e.ignoresdpversion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.insecure)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ipaddr)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.language)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.mailbox)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.md5secret)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.mohinterpret)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.mohsuggest)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.nat)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.outbound_extension).HasMaxLength(50);

                entity.Property(e => e.outboundproxy)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.parkinglot)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.permit)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.pickupgroup)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.prefix).HasMaxLength(10);

                entity.Property(e => e.prefix_national).HasMaxLength(10);

                entity.Property(e => e.progressinband)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.promiscredir)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.qualify)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.regexten)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.regserver)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.remotesecret)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.rfc2833compensate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.secret)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.sendrpid)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.session_expires).HasColumnName("session-expires");

                entity.Property(e => e.session_minse).HasColumnName("session-minse");

                entity.Property(e => e.session_refresher)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("session-refresher");

                entity.Property(e => e.session_timers)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("session-timers");

                entity.Property(e => e.setvar)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.subscribemwi)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.t38pt_usertpsource)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.textsupport)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.transport)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.trunkname)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.trustrpid)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.type)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.useclientcode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.useragent)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.usereqphone)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.videosupport)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.vmexten)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<dbo.SNT_SWITCHBOARD>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SNT_SWITCHBOARD");

                entity.Property(e => e.IPADDRESS).HasMaxLength(30);

                entity.Property(e => e.NAME).HasMaxLength(100);

                entity.Property(e => e.PASS).HasMaxLength(50);

                entity.Property(e => e.USERNAME).HasMaxLength(40);
            });

            modelBuilder.Entity<dbo.STDBOARDTYPES>(entity =>
            {
                entity.HasKey(e => e.BOARDTYPE)
                    .HasName("PK__STDBOARD__9CD382A3B16C0FCE");

                entity.Property(e => e.BOARDTYPE).HasMaxLength(10);
            });

            modelBuilder.Entity<dbo.STDHOTEL>(entity =>
            {
                entity.HasIndex(e => e.SETURID, "IX_STDHOTEL");

                entity.HasIndex(e => new { e.ISDELETED, e.ISDISABLED }, "IX_STDHOTEL_1");

                entity.HasIndex(e => e.NAME, "IX_STDHOTEL_2");

                entity.HasIndex(e => e.NAME, "IX_STDHOTEL_3");

                entity.HasIndex(e => e.ADDDATE, "IX_STDHOTEL_4");

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CHECKINTIME).HasColumnType("datetime");

                entity.Property(e => e.CHECKOUTTIME).HasColumnType("datetime");

                entity.Property(e => e.CONTACT).HasMaxLength(200);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.EMAIL).HasMaxLength(200);

                entity.Property(e => e.FACTSHEETURL).HasMaxLength(250);

                entity.Property(e => e.FACTSHEETURL2).HasMaxLength(250);

                entity.Property(e => e.HOMEPAGEURL).HasMaxLength(350);

                entity.Property(e => e.NAME).HasMaxLength(70);

                entity.Property(e => e.RAKAM_ID).HasMaxLength(15);

                entity.Property(e => e.TEMPLATENAME).HasMaxLength(50);

                entity.Property(e => e.THUMBNAILMAXWIDTH).HasDefaultValueSql("((110))");

                entity.Property(e => e.THUMBNAILURL).HasMaxLength(350);

                entity.Property(e => e.TRIPADVISORID).HasMaxLength(50);

                entity.Property(e => e.URL_BLOGGER).HasMaxLength(250);

                entity.Property(e => e.URL_FACEBOOK).HasMaxLength(250);

                entity.Property(e => e.URL_FLICKER).HasMaxLength(250);

                entity.Property(e => e.URL_FOURSQUARE).HasMaxLength(250);

                entity.Property(e => e.URL_GOOGLEPLUS).HasMaxLength(250);

                entity.Property(e => e.URL_INSTAGRAM).HasMaxLength(250);

                entity.Property(e => e.URL_VINE).HasMaxLength(250);

                entity.Property(e => e.WEBADDRESS).HasMaxLength(250);

                entity.HasOne(d => d.ADDRESS)
                    .WithMany(p => p.STDHOTEL)
                    .HasForeignKey(d => d.ADDRESSID)
                    .HasConstraintName("FK__STDHOTEL__ADDRES__6754599E");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.STDHOTELADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL__ADDUSE__6A30C649");

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.STDHOTEL)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STDHOTEL_CORP");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.STDHOTELEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__STDHOTEL__EDITUS__6C190EBB");
            });

            modelBuilder.Entity<dbo.STDHOTELDISCOUNT>(entity =>
            {
                entity.Property(e => e.DEFINITION).HasMaxLength(50);
            });

            modelBuilder.Entity<dbo.STDHOTEL_ANNOUNCEMENT>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__STDHOTEL__3214EC2639831F6E")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DEFINITION).HasMaxLength(150);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.ENDDATE).HasColumnType("datetime");

                entity.Property(e => e.STARTDATE).HasColumnType("datetime");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.STDHOTEL_ANNOUNCEMENTADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___ADDUS__71A7CADF");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.STDHOTEL_ANNOUNCEMENTEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__STDHOTEL___EDITU__729BEF18");

                entity.HasOne(d => d.HOTEL)
                    .WithMany(p => p.STDHOTEL_ANNOUNCEMENT)
                    .HasForeignKey(d => d.HOTELID)
                    .HasConstraintName("FK__STDHOTEL___HOTEL__70B3A6A6");
            });

            modelBuilder.Entity<dbo.STDHOTEL_BOARDTYPES>(entity =>
            {
                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.BOARDTYPE).HasMaxLength(10);

                entity.Property(e => e.DEFINITION).HasMaxLength(25);

                entity.Property(e => e.ENT_ETSID).HasMaxLength(50);

                entity.Property(e => e.ENT_HOTELRUNNERID).HasMaxLength(100);

                entity.Property(e => e.ENT_IATIID).HasMaxLength(50);

                entity.Property(e => e.ENT_ID).HasMaxLength(25);

                entity.Property(e => e.ENT_JOLLYTOURID).HasMaxLength(150);

                entity.Property(e => e.ENT_SEDNAID).HasMaxLength(250);

                entity.Property(e => e.ENT_SETURID).HasMaxLength(150);

                entity.Property(e => e.ENT_TATILBUDURID).HasMaxLength(50);

                entity.Property(e => e.ENT_TOURISTICAID).HasMaxLength(50);

                entity.Property(e => e.ENT_TRAVELCLICKID).HasMaxLength(50);

                entity.HasOne(d => d.BOARDTYPENavigation)
                    .WithMany(p => p.STDHOTEL_BOARDTYPES)
                    .HasForeignKey(d => d.BOARDTYPE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___BOARD__618671AF");

                entity.HasOne(d => d.HOTEL)
                    .WithMany(p => p.STDHOTEL_BOARDTYPES)
                    .HasForeignKey(d => d.HOTELID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___HOTEL__214BF109");
            });

            modelBuilder.Entity<dbo.STDHOTEL_DESCRIPTIONS>(entity =>
            {
                entity.HasIndex(e => e.UID, "IX_STDHOTEL_DESCRIPTIONS")
                    .IsUnique();

                entity.Property(e => e.CATEGORY).HasMaxLength(150);

                entity.Property(e => e.SEASON).HasMaxLength(10);

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.HOTEL)
                    .WithMany(p => p.STDHOTEL_DESCRIPTIONS)
                    .HasForeignKey(d => d.HOTELID)
                    .HasConstraintName("FK__STDHOTEL___HOTEL__18178C8A");
            });

            modelBuilder.Entity<dbo.STDHOTEL_EXTRAS>(entity =>
            {
                entity.HasIndex(e => e.EXSERVICEID, "IX_STDHOTEL_EXTRAS");

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CURCODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEFINITION).HasMaxLength(150);

                entity.Property(e => e.PRICE).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.HOTEL)
                    .WithMany(p => p.STDHOTEL_EXTRAS)
                    .HasForeignKey(d => d.HOTELID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___HOTEL__3BFFE745");
            });

            modelBuilder.Entity<dbo.STDHOTEL_FECILITIES>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CATEGORY).HasMaxLength(100);

                entity.Property(e => e.DEFINITION).HasMaxLength(100);

                entity.Property(e => e.ICON).HasMaxLength(75);

                entity.Property(e => e.ID).ValueGeneratedOnAdd();

                entity.Property(e => e.SEASONTYPE).HasMaxLength(10);

                entity.HasOne(d => d.HOTEL)
                    .WithMany()
                    .HasForeignKey(d => d.HOTELID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__STDHOTEL___HOTEL__1DD065E0");

                entity.HasOne(d => d.ROOMTYPE)
                    .WithMany()
                    .HasForeignKey(d => d.ROOMTYPEID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__STDHOTEL___ROOMT__066DDD9B");
            });

            modelBuilder.Entity<dbo.STDHOTEL_IMAGES>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DEFINITION).HasMaxLength(100);

                entity.Property(e => e.ID).ValueGeneratedOnAdd();

                entity.Property(e => e.SHOWINOFFERFORM)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.THUMBNAIL).HasMaxLength(250);

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.URL).HasMaxLength(250);

                entity.HasOne(d => d.HOTEL)
                    .WithMany()
                    .HasForeignKey(d => d.HOTELID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__STDHOTEL___HOTEL__1BE81D6E");

                entity.HasOne(d => d.ROOMTYPE)
                    .WithMany()
                    .HasForeignKey(d => d.ROOMTYPEID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__STDHOTEL___ROOMT__55CAA640");
            });

            modelBuilder.Entity<dbo.STDHOTEL_MARKET>(entity =>
            {
                entity.HasIndex(e => e.ID, "UQ__STDHOTEL__3214EC26A7DB71ED")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DEFINITION).HasMaxLength(50);

                entity.Property(e => e.ENT_ETSID).HasMaxLength(50);

                entity.Property(e => e.ENT_HOTELRUNNERID).HasMaxLength(100);

                entity.Property(e => e.ENT_IATIID).HasMaxLength(50);

                entity.Property(e => e.ENT_ID).HasMaxLength(25);

                entity.Property(e => e.ENT_JOLLYTOURID).HasMaxLength(150);

                entity.Property(e => e.ENT_SEDNAID).HasMaxLength(250);

                entity.Property(e => e.ENT_SETURID).HasMaxLength(150);

                entity.Property(e => e.ENT_TATILBUDURID).HasMaxLength(50);

                entity.Property(e => e.ENT_TOURISTICAID).HasMaxLength(50);

                entity.Property(e => e.ENT_TRAVELCLICKID).HasMaxLength(50);

                entity.HasOne(d => d.HOTEL)
                    .WithMany(p => p.STDHOTEL_MARKET)
                    .HasForeignKey(d => d.HOTELID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___HOTEL__3C3FDE67");

                entity.HasOne(d => d.STDMARKET)
                    .WithMany(p => p.STDHOTEL_MARKET)
                    .HasForeignKey(d => d.STDMARKETID)
                    .HasConstraintName("FK__STDHOTEL___STDMA__673F4B05");
            });

            modelBuilder.Entity<dbo.STDHOTEL_MARKET_COUNTRY>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.ID, "UQ__STDHOTEL__3214EC26E0FACD80")
                    .IsUnique();

                entity.HasIndex(e => new { e.COUNTRYCODE, e.MARKETID }, "UQ__STDHOTEL__DF754A0EFCBD2DB3")
                    .IsUnique();

                entity.Property(e => e.COUNTRYCODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.HOTEL)
                    .WithMany()
                    .HasForeignKey(d => d.HOTELID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___HOTEL__41049384");

                entity.HasOne(d => d.MARKET)
                    .WithMany()
                    .HasForeignKey(d => d.MARKETID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___MARKE__69279377");
            });

            modelBuilder.Entity<dbo.STDHOTEL_PRICECONDITION>(entity =>
            {
                entity.HasIndex(e => new { e.RATETYPEID, e.BOARDTYPEID, e.ROOMTYPEID, e.MARKETID, e.CURCODE }, "IX_STDHOTEL_PRICECONDITION")
                    .IsUnique();

                entity.HasIndex(e => e.ID, "UQ__STDHOTEL__3214EC261CABA467")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADULT_RATE).HasDefaultValueSql("((1))");

                entity.Property(e => e.BABYAMOUNT).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.BABY_RATE).HasDefaultValueSql("((1))");

                entity.Property(e => e.CHDEAMOUNT).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.CHDYAMOUNT).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.CHILD_RATE).HasDefaultValueSql("((1))");

                entity.Property(e => e.CURCODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DBLAMOUNT).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.DEFINITION).HasMaxLength(150);

                entity.Property(e => e.QUADAMOUNT).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.SNGAMOUNT).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.TRPAMOUNT).HasColumnType("decimal(19, 2)");

                entity.HasOne(d => d.BOARDTYPE)
                    .WithMany(p => p.STDHOTEL_PRICECONDITION)
                    .HasForeignKey(d => d.BOARDTYPEID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___BOARD__46BD6CDA");

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.STDHOTEL_PRICECONDITION)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___CORPI__3FDB6521");

                entity.HasOne(d => d.HOTEL)
                    .WithMany(p => p.STDHOTEL_PRICECONDITION)
                    .HasForeignKey(d => d.HOTELID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___HOTEL__44D52468");

                entity.HasOne(d => d.MARKET)
                    .WithMany(p => p.STDHOTEL_PRICECONDITION)
                    .HasForeignKey(d => d.MARKETID)
                    .HasConstraintName("FK__STDHOTEL___MARKE__48A5B54C");

                entity.HasOne(d => d.RATETYPE)
                    .WithMany(p => p.STDHOTEL_PRICECONDITION)
                    .HasForeignKey(d => d.RATETYPEID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___RATET__47B19113");

                entity.HasOne(d => d.ROOMTYPE)
                    .WithMany(p => p.STDHOTEL_PRICECONDITION)
                    .HasForeignKey(d => d.ROOMTYPEID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___ROOMT__45C948A1");
            });

            modelBuilder.Entity<dbo.STDHOTEL_PRICECONDITION_CALENDAR>(entity =>
            {
                entity.HasIndex(e => new { e.DATE, e.PRICECONDITIONID }, "UQ__STDHOTEL__BC35458659EA38AD")
                    .IsUnique();

                entity.Property(e => e.BASERATE).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.DATE).HasColumnType("date");

                entity.Property(e => e.RELEASEDATE)
                    .HasColumnType("date")
                    .HasComputedColumnSql("(case when [RELEASE_DAY]>(0) then dateadd(day, -[RELEASE_DAY],[DATE])  end)", true);

                entity.HasOne(d => d.PRICECONDITION)
                    .WithMany(p => p.STDHOTEL_PRICECONDITION_CALENDAR)
                    .HasForeignKey(d => d.PRICECONDITIONID)
                    .HasConstraintName("FK__STDHOTEL___PRICE__42B7D1CC");
            });

            modelBuilder.Entity<dbo.STDHOTEL_PRICECONDITION_OCCUPANCY>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__STDHOTEL__3214EC269C63FEBC")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.PRICECONDITIONID, e.ADULT, e.CHDE, e.CHDY, e.BABY, e.TOTALCHD }, "UQ__STDHOTEL__506C296922C62C78")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.PRICECONDITION)
                    .WithMany(p => p.STDHOTEL_PRICECONDITION_OCCUPANCY)
                    .HasForeignKey(d => d.PRICECONDITIONID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___PRICE__135DC465");
            });

            modelBuilder.Entity<dbo.STDHOTEL_RATECODE>(entity =>
            {
                entity.HasIndex(e => new { e.HOTELID, e.CORPID }, "IX_STDHOTEL_RATECODE")
                    .IsUnique();

                entity.HasIndex(e => e.ID, "UQ__STDHOTEL__3214EC26D34E1904")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CURCODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEFINITION).HasMaxLength(50);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.STDHOTEL_RATECODEADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___ADDUS__11DF9047");

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.STDHOTEL_RATECODE)
                    .HasForeignKey(d => d.CORPID)
                    .HasConstraintName("FK__STDHOTEL___CORPI__66010E09");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.STDHOTEL_RATECODEEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__STDHOTEL___EDITU__12D3B480");

                entity.HasOne(d => d.HOTEL)
                    .WithMany(p => p.STDHOTEL_RATECODE)
                    .HasForeignKey(d => d.HOTELID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___HOTEL__3592E0D8");
            });

            modelBuilder.Entity<dbo.STDHOTEL_RATECODE_DETAIL>(entity =>
            {
                entity.HasIndex(e => new { e.RATECODEID, e.PRICECONDITIONID, e.STAYFROM, e.STAYTO, e.MINLOS, e.MAXLOS }, "IX_MISS_HOTELSEARCH");

                entity.HasIndex(e => e.ID, "UQ__STDHOTEL__3214EC2632A733C7")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.BABY).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.CHDE).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.CHDY).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.CHECKINDAYS)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CHECKOUTDAYS)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DBL).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.DEFINITION).HasMaxLength(50);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.EXBED).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.FIRSTBABY).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.FIRSTCHDE).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.FIRSTCHDY).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.PRICESORT).HasComputedColumnSql("(((((isnull((20)*datediff(day,[SELLFROM],[SELLTO]),(365))+isnull((10)*datediff(day,[STAYFROM],[STAYTO]),(365)))+isnull((1)*len(ltrim(rtrim([CHECKINDAYS]))),(7)))+isnull((2)*len(ltrim(rtrim([CHECKOUTDAYS]))),(7)))+isnull((3)*len(ltrim(rtrim([STAYINGDAYS]))),(7)))+isnull((4)*[MAXLOS]-[MINLOS],(0)))", true);

                entity.Property(e => e.QUAD).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.SELLFROM).HasColumnType("datetime");

                entity.Property(e => e.SELLTO).HasColumnType("datetime");

                entity.Property(e => e.SNG).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.SNGBABY).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.SNGCHDE).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.SNGCHDY).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.SNGFIRSTBABY).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.SNGFIRSTCHDE).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.SNGFIRSTCHDY).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.STAYFROM).HasColumnType("datetime");

                entity.Property(e => e.STAYINGDAYS)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.STAYTO).HasColumnType("datetime");

                entity.Property(e => e.TRP).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.TRPBABY).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.TRPCHDE).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.TRPCHDY).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.TRPFIRSTBABY).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.TRPFIRSTCHDE).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.TRPFIRSTCHDY).HasColumnType("decimal(19, 2)");

                entity.HasOne(d => d.PRICECONDITION)
                    .WithMany(p => p.STDHOTEL_RATECODE_DETAIL)
                    .HasForeignKey(d => d.PRICECONDITIONID)
                    .HasConstraintName("FK_STDHOTEL_RATECODE_DETAIL_STDHOTEL_PRICECONDITION");
            });

            modelBuilder.Entity<dbo.STDHOTEL_RATECODE_DETAIL_AGENCYGROUPS>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__STDHOTEL__3214EC268DDA1218")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.STDHOTEL_RATECODE_DETAIL_AGENCYGROUPSADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___ADDUS__6D630406");

                entity.HasOne(d => d.DETAIL)
                    .WithMany(p => p.STDHOTEL_RATECODE_DETAIL_AGENCYGROUPS)
                    .HasForeignKey(d => d.DETAILID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__STDHOTEL___DETAI__703F70B1");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.STDHOTEL_RATECODE_DETAIL_AGENCYGROUPSEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__STDHOTEL___EDITU__6F4B4C78");

                entity.HasOne(d => d.GROUP)
                    .WithMany(p => p.STDHOTEL_RATECODE_DETAIL_AGENCYGROUPS)
                    .HasForeignKey(d => d.GROUPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___GROUP__6C6EDFCD");
            });

            modelBuilder.Entity<dbo.STDHOTEL_RATECODE_DETAIL_OCCUPANCY>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.ID, "UQ__STDHOTEL__3214EC264DFD2C06")
                    .IsUnique();

                entity.HasIndex(e => new { e.RATECODEDETAILID, e.ADULT, e.CHDE, e.CHDY, e.BABY, e.TOTALCHD }, "UQ__STDHOTEL__57C4B69A2CE4E4FF")
                    .IsUnique();

                entity.Property(e => e.COSTPRICE).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.GUESTPRICE).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.HOTEL)
                    .WithMany()
                    .HasForeignKey(d => d.HOTELID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___HOTEL__513AFB4D");

                entity.HasOne(d => d.RATECODEDETAIL)
                    .WithMany()
                    .HasForeignKey(d => d.RATECODEDETAILID)
                    .HasConstraintName("FK__STDHOTEL___RATEC__522F1F86");
            });

            modelBuilder.Entity<dbo.STDHOTEL_RATECODE_DISCOUNT>(entity =>
            {
                entity.HasIndex(e => e.ADDITIONAL_DISCOUNT, "IX_STDHOTEL_RATECODE_DISCOUNT");

                entity.HasIndex(e => new { e.SELLFROM, e.SELLTO }, "IX_STDHOTEL_RATECODE_DISCOUNT_1");

                entity.HasIndex(e => new { e.STAYFROM, e.STAYTO }, "IX_STDHOTEL_RATECODE_DISCOUNT_2");

                entity.HasIndex(e => e.ID, "UQ__STDHOTEL__3214EC267A852001")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDITIONAL_EFFECT).HasDefaultValueSql("((2))");

                entity.Property(e => e.APPLYDAYS).HasMaxLength(100);

                entity.Property(e => e.APPLYFROM).HasColumnType("datetime");

                entity.Property(e => e.APPLYTO).HasColumnType("datetime");

                entity.Property(e => e.APPLYZONE).HasDefaultValueSql("((2))");

                entity.Property(e => e.CHECKINDAYS)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CHECKOUTDAYS)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEFINITION).HasMaxLength(50);

                entity.Property(e => e.SELLFROM).HasColumnType("datetime");

                entity.Property(e => e.SELLTO).HasColumnType("datetime");

                entity.Property(e => e.STAYFROM).HasColumnType("datetime");

                entity.Property(e => e.STAYINGDAYS)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.STAYTO).HasColumnType("datetime");

                entity.HasOne(d => d.AGENCY)
                    .WithMany(p => p.STDHOTEL_RATECODE_DISCOUNT)
                    .HasForeignKey(d => d.AGENCYID)
                    .HasConstraintName("FK_STDHOTEL_RATECODE_DISCOUNT_AGENCY");

                entity.HasOne(d => d.DISCOUNTTYPENavigation)
                    .WithMany(p => p.STDHOTEL_RATECODE_DISCOUNT)
                    .HasForeignKey(d => d.DISCOUNTTYPE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___DISCO__7869D707");

                entity.HasOne(d => d.HOTEL)
                    .WithMany(p => p.STDHOTEL_RATECODE_DISCOUNT)
                    .HasForeignKey(d => d.HOTELID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___HOTEL__4964CF5B");

                entity.HasOne(d => d.RATECODE)
                    .WithMany(p => p.STDHOTEL_RATECODE_DISCOUNT)
                    .HasForeignKey(d => d.RATECODEID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___RATEC__4A58F394");
            });

            modelBuilder.Entity<dbo.STDHOTEL_RATECODE_DISCOUNT_CONTRACT>(entity =>
            {
                entity.HasIndex(e => new { e.DISCOUNTID, e.CONTRACTID }, "UQ__STDHOTEL__100A09E2B088803D")
                    .IsUnique();

                entity.HasOne(d => d.CONTRACT)
                    .WithMany(p => p.STDHOTEL_RATECODE_DISCOUNT_CONTRACT)
                    .HasForeignKey(d => d.CONTRACTID)
                    .HasConstraintName("FK__STDHOTEL___CONTR__5C77A3CF");

                entity.HasOne(d => d.DISCOUNT)
                    .WithMany(p => p.STDHOTEL_RATECODE_DISCOUNT_CONTRACT)
                    .HasForeignKey(d => d.DISCOUNTID)
                    .HasConstraintName("FK__STDHOTEL___DISCO__5B837F96");
            });

            modelBuilder.Entity<dbo.STDHOTEL_RATECODE_DISCOUNT_DISCOUNT>(entity =>
            {
                entity.HasIndex(e => new { e.DISCOUNTID, e.OTHERDISCOUNTID }, "UQ__STDHOTEL__649F0431A924ADCC")
                    .IsUnique();
            });

            modelBuilder.Entity<dbo.STDHOTEL_RATECODE_DISCOUNT_MARKET>(entity =>
            {
                entity.HasIndex(e => new { e.DISCOUNTID, e.MARKETID }, "UQ__STDHOTEL__4B96FBB176D8588E")
                    .IsUnique();

                entity.HasOne(d => d.DISCOUNT)
                    .WithMany(p => p.STDHOTEL_RATECODE_DISCOUNT_MARKET)
                    .HasForeignKey(d => d.DISCOUNTID)
                    .HasConstraintName("FK__STDHOTEL___DISCO__53E25DCE");

                entity.HasOne(d => d.MARKET)
                    .WithMany(p => p.STDHOTEL_RATECODE_DISCOUNT_MARKET)
                    .HasForeignKey(d => d.MARKETID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___MARKE__54D68207");
            });

            modelBuilder.Entity<dbo.STDHOTEL_RATECODE_DISCOUNT_RATETYPE>(entity =>
            {
                entity.HasIndex(e => new { e.DISCOUNTID, e.RATETYPEID }, "UQ__STDHOTEL__050B357DD8B8D23E")
                    .IsUnique();

                entity.HasOne(d => d.DISCOUNT)
                    .WithMany(p => p.STDHOTEL_RATECODE_DISCOUNT_RATETYPE)
                    .HasForeignKey(d => d.DISCOUNTID)
                    .HasConstraintName("FK__STDHOTEL___DISCO__57B2EEB2");

                entity.HasOne(d => d.RATETYPE)
                    .WithMany(p => p.STDHOTEL_RATECODE_DISCOUNT_RATETYPE)
                    .HasForeignKey(d => d.RATETYPEID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___RATET__58A712EB");
            });

            modelBuilder.Entity<dbo.STDHOTEL_RATECODE_DISCOUNT_ROOMTYPE>(entity =>
            {
                entity.HasIndex(e => new { e.DISCOUNTID, e.ROOMTYPEID }, "UQ__STDHOTEL__46861580EC62108A")
                    .IsUnique();

                entity.HasOne(d => d.DISCOUNT)
                    .WithMany(p => p.STDHOTEL_RATECODE_DISCOUNT_ROOMTYPE)
                    .HasForeignKey(d => d.DISCOUNTID)
                    .HasConstraintName("FK__STDHOTEL___DISCO__5011CCEA");

                entity.HasOne(d => d.ROOMTYPE)
                    .WithMany(p => p.STDHOTEL_RATECODE_DISCOUNT_ROOMTYPE)
                    .HasForeignKey(d => d.ROOMTYPEID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___ROOMT__5105F123");
            });

            modelBuilder.Entity<dbo.STDHOTEL_RATECODE_MARKUP>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__STDHOTEL__3214EC266A363F9F")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.APPLYZONE).HasDefaultValueSql("((2))");

                entity.Property(e => e.CURCODE)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.STAYFROM).HasColumnType("datetime");

                entity.Property(e => e.STAYINGDAYS)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.STAYTO).HasColumnType("datetime");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.STDHOTEL_RATECODE_MARKUPADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___ADDUS__7948ECA7");

                entity.HasOne(d => d.CURCODENavigation)
                    .WithMany(p => p.STDHOTEL_RATECODE_MARKUP)
                    .HasForeignKey(d => d.CURCODE)
                    .HasConstraintName("FK__STDHOTEL___CURCO__7266E4EE");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.STDHOTEL_RATECODE_MARKUPEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__STDHOTEL___EDITU__7A3D10E0");

                entity.HasOne(d => d.RATECODE)
                    .WithMany(p => p.STDHOTEL_RATECODE_MARKUP)
                    .HasForeignKey(d => d.RATECODEID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___RATEC__7760A435");
            });

            modelBuilder.Entity<dbo.STDHOTEL_RATECODE_MARKUP_MARKETS>(entity =>
            {
                entity.HasOne(d => d.MARKET)
                    .WithMany(p => p.STDHOTEL_RATECODE_MARKUP_MARKETS)
                    .HasForeignKey(d => d.MARKETID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___MARKE__1B9E04AB");

                entity.HasOne(d => d.MARKUP)
                    .WithMany(p => p.STDHOTEL_RATECODE_MARKUP_MARKETS)
                    .HasForeignKey(d => d.MARKUPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___MARKU__1AA9E072");
            });

            modelBuilder.Entity<dbo.STDHOTEL_RATECODE_MARKUP_ROOMTYPE>(entity =>
            {
                entity.HasIndex(e => e.BEFORE_DISCOUNT, "IX_STDHOTEL_RATECODE_MARKUP_ROOMTYPE");

                entity.HasOne(d => d.MARKUP)
                    .WithMany(p => p.STDHOTEL_RATECODE_MARKUP_ROOMTYPE)
                    .HasForeignKey(d => d.MARKUPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___MARKU__1C9228E4");

                entity.HasOne(d => d.ROOMTYPE)
                    .WithMany(p => p.STDHOTEL_RATECODE_MARKUP_ROOMTYPE)
                    .HasForeignKey(d => d.ROOMTYPEID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___ROOMT__1D864D1D");
            });

            modelBuilder.Entity<dbo.STDHOTEL_RATETYPE>(entity =>
            {
                entity.HasIndex(e => e.ID, "UQ__STDHOTEL__3214EC26E6CD802C")
                    .IsUnique();

                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.DEFINITION).HasMaxLength(50);

                entity.Property(e => e.ENT_ETSID).HasMaxLength(50);

                entity.Property(e => e.ENT_HOTELRUNNERID).HasMaxLength(100);

                entity.Property(e => e.ENT_IATIID).HasMaxLength(50);

                entity.Property(e => e.ENT_JOLLYTOURID).HasMaxLength(150);

                entity.Property(e => e.ENT_SEDNAID).HasMaxLength(250);

                entity.Property(e => e.ENT_SETURID).HasMaxLength(150);

                entity.Property(e => e.ENT_TATILBUDURID).HasMaxLength(50);

                entity.Property(e => e.ENT_TOURISTICAID).HasMaxLength(50);

                entity.Property(e => e.ENT_TRAVELCLICKID).HasMaxLength(50);

                entity.HasOne(d => d.HOTEL)
                    .WithMany(p => p.STDHOTEL_RATETYPE)
                    .HasForeignKey(d => d.HOTELID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___HOTEL__386F4D83");
            });

            modelBuilder.Entity<dbo.STDHOTEL_RATETYPES_AVAILABILITY>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.CORPID, e.ROOMTYPEID, e.RATETYPEID, e.DATE, e.MARKETID }, "UQ__STDHOTEL__448ED8D9FD7F18D1")
                    .IsUnique();

                entity.Property(e => e.DATE).HasColumnType("date");

                entity.Property(e => e.ID).ValueGeneratedOnAdd();

                entity.HasOne(d => d.MARKET)
                    .WithMany()
                    .HasForeignKey(d => d.MARKETID)
                    .HasConstraintName("FK__STDHOTEL___MARKE__05C3D225");

                entity.HasOne(d => d.RATETYPE)
                    .WithMany()
                    .HasForeignKey(d => d.RATETYPEID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___RATET__7EECB764");

                entity.HasOne(d => d.ROOMTYPE)
                    .WithMany()
                    .HasForeignKey(d => d.ROOMTYPEID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___ROOMT__06B7F65E");
            });

            modelBuilder.Entity<dbo.STDHOTEL_ROOMTYPES>(entity =>
            {
                entity.HasIndex(e => e.ROOMGROUP, "IX_STDHOTEL_ROOMTYPES");

                entity.HasIndex(e => e.ROOMTYPE, "IX_STDHOTEL_ROOMTYPES_1");

                entity.HasIndex(e => e.ISDELETED, "IX_STDHOTEL_ROOMTYPES_2");

                entity.HasIndex(e => e.ISDISABLED, "IX_STDHOTEL_ROOMTYPES_3");

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ADULT_RATE).HasDefaultValueSql("((1))");

                entity.Property(e => e.BABY_RATE).HasDefaultValueSql("((1))");

                entity.Property(e => e.CHILD_RATE).HasDefaultValueSql("((1))");

                entity.Property(e => e.DEFINITION).HasMaxLength(50);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.ENT_ETSID).HasMaxLength(50);

                entity.Property(e => e.ENT_HOTELRUNNERID).HasMaxLength(100);

                entity.Property(e => e.ENT_IATIID).HasMaxLength(50);

                entity.Property(e => e.ENT_ID).HasMaxLength(50);

                entity.Property(e => e.ENT_JOLLYTOURID).HasMaxLength(150);

                entity.Property(e => e.ENT_SEDNAID).HasMaxLength(250);

                entity.Property(e => e.ENT_SETURID).HasMaxLength(150);

                entity.Property(e => e.ENT_TATILBUDURID).HasMaxLength(50);

                entity.Property(e => e.ENT_TOURISTICAID).HasMaxLength(50);

                entity.Property(e => e.ENT_TRAVELCLICKID).HasMaxLength(50);

                entity.Property(e => e.ROOMGROUP).HasMaxLength(50);

                entity.Property(e => e.ROOMTYPE).HasMaxLength(6);

                entity.Property(e => e.THUMBNAILIMG).HasMaxLength(250);

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.STDHOTEL_ROOMTYPESADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .HasConstraintName("FK_STDHOTEL_ROOMTYPES_USERS");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.STDHOTEL_ROOMTYPESEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK_STDHOTEL_ROOMTYPES_USERS1");

                entity.HasOne(d => d.HOTEL)
                    .WithMany(p => p.STDHOTEL_ROOMTYPES)
                    .HasForeignKey(d => d.HOTELID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___HOTEL__4A8310C6");

                entity.HasOne(d => d.ROOMTYPENavigation)
                    .WithMany(p => p.STDHOTEL_ROOMTYPES)
                    .HasForeignKey(d => d.ROOMTYPE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___ROOMT__4B7734FF");
            });

            modelBuilder.Entity<dbo.STDHOTEL_ROOMTYPES_AVAILABILITY>(entity =>
            {
                entity.HasIndex(e => new { e.CORPID, e.DATE, e.ROOMTYPEID }, "UQ__STDHOTEL__E5B25094C12D3A70")
                    .IsUnique();

                entity.Property(e => e.DATE).HasColumnType("date");

                entity.Property(e => e.RELEASEDATE)
                    .HasColumnType("date")
                    .HasComputedColumnSql("(dateadd(day, -[RELEASEDAYS],[DATE]))", true);

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.STDHOTEL_ROOMTYPES_AVAILABILITY)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___CORPI__0A888742");

                entity.HasOne(d => d.ROOMTYPE)
                    .WithMany(p => p.STDHOTEL_ROOMTYPES_AVAILABILITY)
                    .HasForeignKey(d => d.ROOMTYPEID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___ROOMT__0B7CAB7B");
            });

            modelBuilder.Entity<dbo.STDHOTEL_SEASONS>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ID).ValueGeneratedOnAdd();

                entity.Property(e => e.SEASONFINISH).HasColumnType("datetime");

                entity.Property(e => e.SEASONSTART).HasColumnType("datetime");

                entity.HasOne(d => d.HOTEL)
                    .WithMany()
                    .HasForeignKey(d => d.HOTELID)
                    .HasConstraintName("FK__STDHOTEL___HOTEL__19FFD4FC");
            });

            modelBuilder.Entity<dbo.STDHOTEL_STOPSALE>(entity =>
            {
                entity.HasIndex(e => e.CORPID, "IX_CORP");

                entity.Property(e => e.FROMDATE).HasColumnType("date");

                entity.Property(e => e.TODATE).HasColumnType("date");

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.STDHOTEL_STOPSALE)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDHOTEL___CORPI__0D64F3ED");

                entity.HasOne(d => d.PRICECONDITION)
                    .WithMany(p => p.STDHOTEL_STOPSALE)
                    .HasForeignKey(d => d.PRICECONDITIONID)
                    .HasConstraintName("FK__STDHOTEL___PRICE__6F8A7843");
            });

            modelBuilder.Entity<dbo.STDLANGUAGES>(entity =>
            {
                entity.HasKey(e => e.CODE)
                    .HasName("PK__STDLANGU__AA1D4378C43472E9");

                entity.Property(e => e.CODE)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEFINITION).HasMaxLength(100);
            });

            modelBuilder.Entity<dbo.STDMARKETS>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__STDMARKE__3214EC2650F9EF41")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.CORPID, e.DEFINITION }, "UQ__STDMARKE__D0FAF608463C925A")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CURCODE)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.DEFINITION).HasMaxLength(50);

                entity.Property(e => e.LANGUAGE).HasMaxLength(5);

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.STDMARKETS)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDMARKET__CORPI__0F4D3C5F");
            });

            modelBuilder.Entity<dbo.STDMARKET_COUNTRIES>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__STDMARKE__3214EC2683C5DABB")
                    .IsClustered(false);

                entity.HasIndex(e => e.COUNTRYCODE, "UQ__STDMARKE__FAC7CEB6C9F85917")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.COUNTRYCODE).HasMaxLength(2);

                entity.HasOne(d => d.STDMARKET)
                    .WithMany(p => p.STDMARKET_COUNTRIES)
                    .HasForeignKey(d => d.STDMARKETID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDMARKET__STDMA__4A8DFDBE");
            });

            modelBuilder.Entity<dbo.STDROOMTYPES>(entity =>
            {
                entity.HasKey(e => e.ROOMTYPE)
                    .HasName("PK__STDROOMT__D28E9DD16E29EB50");

                entity.Property(e => e.ROOMTYPE).HasMaxLength(6);

                entity.Property(e => e.ENT_ROOMTYPE).HasMaxLength(50);
            });

            modelBuilder.Entity<dbo.STDSTORE>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__STDSTORE__3214EC26DBCE8B6A")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CONTACT).HasMaxLength(200);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.EMAIL).HasMaxLength(200);

                entity.Property(e => e.NAME).HasMaxLength(250);

                entity.Property(e => e.THUMBNAILURL).HasMaxLength(350);

                entity.Property(e => e.TYPENAME)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(case [TYPE] when (0) then 'Restaurant'  end)", false);

                entity.Property(e => e.WEBADDRESS).HasMaxLength(250);

                entity.HasOne(d => d.ADDRESS)
                    .WithMany(p => p.STDSTORE)
                    .HasForeignKey(d => d.ADDRESSID)
                    .HasConstraintName("FK__STDSTORE__ADDRES__6ABBA185");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.STDSTOREADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDSTORE__ADDUSE__6BAFC5BE");

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.STDSTORE)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDSTORE__CORPID__69C77D4C");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.STDSTOREEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__STDSTORE__EDITUS__6CA3E9F7");
            });

            modelBuilder.Entity<dbo.STDSTORE_ITEMS>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__STDSTORE__3214EC267139131B")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.STOREID, e.DEFINITION }, "UQ__STDSTORE__C467D422F4172951")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DEFINITION).HasMaxLength(200);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<dbo.STDSTORE_ITEMS_GROUPS>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__STDSTORE__3214EC26FE38D331")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.GROUP)
                    .WithMany(p => p.STDSTORE_ITEMS_GROUPS)
                    .HasForeignKey(d => d.GROUPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDSTORE___GROUP__470850F4");

                entity.HasOne(d => d.ITEM)
                    .WithMany(p => p.STDSTORE_ITEMS_GROUPS)
                    .HasForeignKey(d => d.ITEMID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDSTORE___ITEMI__47FC752D");
            });

            modelBuilder.Entity<dbo.STDSTORE_ITEM_GROUPS>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__STDSTORE__3214EC26253554E9")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.STOREID, e.DEFINITION }, "UQ__STDSTORE__C467D422F9DABF61")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DEFINITION).HasMaxLength(120);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.THUMBNAILURL).HasMaxLength(350);

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.STDSTORE_ITEM_GROUPSADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDSTORE___ADDUS__056F97C1");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.STDSTORE_ITEM_GROUPSEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__STDSTORE___EDITU__0663BBFA");

                entity.HasOne(d => d.STORE)
                    .WithMany(p => p.STDSTORE_ITEM_GROUPS)
                    .HasForeignKey(d => d.STOREID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDSTORE___STORE__047B7388");
            });

            modelBuilder.Entity<dbo.STDSTORE_ITEM_GROUP_ITEMS>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__STDSTORE__3214EC2655910A0A")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.GROUPID, e.ITEMID }, "UQ__STDSTORE__98E91DBD6E833329")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.STDSTORE_ITEM_GROUP_ITEMSADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDSTORE___ADDUS__02932B16");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.STDSTORE_ITEM_GROUP_ITEMSEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__STDSTORE___EDITU__03874F4F");

                entity.HasOne(d => d.GROUP)
                    .WithMany(p => p.STDSTORE_ITEM_GROUP_ITEMS)
                    .HasForeignKey(d => d.GROUPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDSTORE___GROUP__00AAE2A4");

                entity.HasOne(d => d.ITEM)
                    .WithMany(p => p.STDSTORE_ITEM_GROUP_ITEMS)
                    .HasForeignKey(d => d.ITEMID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDSTORE___ITEMI__019F06DD");
            });

            modelBuilder.Entity<dbo.STDSTORE_ITEM_IMAGES>(entity =>
            {
                entity.Property(e => e.DEFINITION).HasMaxLength(100);

                entity.Property(e => e.THUMBNAIL).HasMaxLength(250);

                entity.Property(e => e.UID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.URL).HasMaxLength(250);

                entity.HasOne(d => d.STORE_ITEM)
                    .WithMany(p => p.STDSTORE_ITEM_IMAGES)
                    .HasForeignKey(d => d.STORE_ITEMID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__STDSTORE___STORE__52EE3995");

                entity.HasOne(d => d.STORE_ITEM_SIZES)
                    .WithMany(p => p.STDSTORE_ITEM_IMAGES)
                    .HasForeignKey(d => d.STORE_ITEM_SIZESID)
                    .HasConstraintName("FK_STDSTORE_ITEM_IMAGES_STDSTORE_ITEM_SIZES");
            });

            modelBuilder.Entity<dbo.STDSTORE_ITEM_INGREDIENTS>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__STDSTORE__3214EC26D03F377E")
                    .IsClustered(false);

                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DEFINITION).HasMaxLength(75);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.STDSTORE_ITEM_INGREDIENTS)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDSTORE___ADDUS__4278A601");

                entity.HasOne(d => d.STORE_ITEM)
                    .WithMany(p => p.STDSTORE_ITEM_INGREDIENTS)
                    .HasForeignKey(d => d.STORE_ITEMID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDSTORE___STORE__436CCA3A");

                entity.HasOne(d => d.STORE_ITEM_SIZES)
                    .WithMany(p => p.STDSTORE_ITEM_INGREDIENTS)
                    .HasForeignKey(d => d.STORE_ITEM_SIZESID)
                    .HasConstraintName("FK__STDSTORE___STORE__4460EE73");
            });

            modelBuilder.Entity<dbo.STDSTORE_ITEM_PRICES>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__STDSTORE__3214EC26971CC529")
                    .IsClustered(false);

                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CURCODE)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.SELLDAYS)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SELLEND).HasColumnType("date");

                entity.Property(e => e.SELLSTART).HasColumnType("date");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.STDSTORE_ITEM_PRICES)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDSTORE___ADDUS__725CC34D");

                entity.HasOne(d => d.CURCODENavigation)
                    .WithMany(p => p.STDSTORE_ITEM_PRICES)
                    .HasForeignKey(d => d.CURCODE)
                    .HasConstraintName("FK__STDSTORE___CURCO__71689F14");

                entity.HasOne(d => d.STORE_ITEM)
                    .WithMany(p => p.STDSTORE_ITEM_PRICES)
                    .HasForeignKey(d => d.STORE_ITEMID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDSTORE___STORE__6F8056A2");

                entity.HasOne(d => d.STORE_ITEM_SIZES)
                    .WithMany(p => p.STDSTORE_ITEM_PRICES)
                    .HasForeignKey(d => d.STORE_ITEM_SIZESID)
                    .HasConstraintName("FK__STDSTORE___STORE__70747ADB");
            });

            modelBuilder.Entity<dbo.STDSTORE_ITEM_PRICES_INGREDIENTS>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__STDSTORE__3214EC2654ABE1A8")
                    .IsClustered(false);

                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.STDSTORE_ITEM_PRICES_INGREDIENTS)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDSTORE___ADDUS__4A19C7C9");

                entity.HasOne(d => d.INGREDIENT)
                    .WithMany(p => p.STDSTORE_ITEM_PRICES_INGREDIENTS)
                    .HasForeignKey(d => d.INGREDIENTID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDSTORE___INGRE__473D5B1E");

                entity.HasOne(d => d.PRICENavigation)
                    .WithMany(p => p.STDSTORE_ITEM_PRICES_INGREDIENTS)
                    .HasForeignKey(d => d.PRICEID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STDSTORE___PRICE__4B0DEC02");
            });

            modelBuilder.Entity<dbo.STDSTORE_ITEM_SIZES>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__STDSTORE__3214EC26C8131450")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.STORE_ITEMID, e.DEFINITION }, "UQ__STDSTORE__92B9D130B75A427A")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DEFINITION).HasMaxLength(200);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<dbo.STDVEHICLETYPES>(entity =>
            {
                entity.HasKey(e => e.VEHICLETYPE)
                    .HasName("PK__STDVEHIC__560C00BC2A4F60DA");

                entity.Property(e => e.VEHICLETYPE).HasMaxLength(40);

                entity.Property(e => e.IMGTYPE).HasMaxLength(30);
            });

            modelBuilder.Entity<dbo.STD_PARAMS>(entity =>
            {
                entity.Property(e => e.GROUPNAME).HasMaxLength(50);

                entity.Property(e => e.PARAMNAME).HasMaxLength(200);

                entity.Property(e => e.PARAMVALUE).HasMaxLength(250);

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.STD_PARAMS)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STD_PARAM__CORPI__5CC1BC92");
            });

            modelBuilder.Entity<dbo.SURVEY>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__SURVEY__3214EC2657C407BC")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.NAME).HasMaxLength(100);

                entity.Property(e => e.QUESTIONNUMBERS)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.REQUIREDMARKS)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TITLE).HasMaxLength(250);

                entity.Property(e => e.TITLEVISIBLE)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.SURVEYADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SURVEY__ADDUSER__3BB5CE82");

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.SURVEY)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SURVEY__CORPID__35FCF52C");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.SURVEYEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__SURVEY__EDITUSER__3D9E16F4");
            });

            modelBuilder.Entity<dbo.SURVEYS>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__SURVEYS__3214EC2690F7C131")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EDITDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.STARTTIME).HasColumnType("datetime");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.SURVEYSADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SURVEYS__ADDUSER__66A02C87");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.SURVEYSEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__SURVEYS__EDITUSE__688874F9");

                entity.HasOne(d => d.PERSON)
                    .WithMany(p => p.SURVEYS)
                    .HasForeignKey(d => d.PERSONID)
                    .HasConstraintName("FK__SURVEYS__PERSONI__63C3BFDC");

                entity.HasOne(d => d.SURVEY)
                    .WithMany(p => p.SURVEYS)
                    .HasForeignKey(d => d.SURVEYID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SURVEYS__SURVEYI__64B7E415");
            });

            modelBuilder.Entity<dbo.SURVEY_ANSWEROPTIONS>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__SURVEY_A__3214EC26FB0AD76D")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ANSWER).HasMaxLength(250);

                entity.Property(e => e.QANSWER).HasMaxLength(250);

                entity.HasOne(d => d.QUESTION)
                    .WithMany(p => p.SURVEY_ANSWEROPTIONS)
                    .HasForeignKey(d => d.QUESTIONID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SURVEY_AN__QUEST__73FA27A5");

                entity.HasOne(d => d.SURVEYS)
                    .WithMany(p => p.SURVEY_ANSWEROPTIONS)
                    .HasForeignKey(d => d.SURVEYSID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SURVEY_AN__SURVE__7306036C");
            });

            modelBuilder.Entity<dbo.SURVEY_ANSWERS>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__SURVEY_A__3214EC26CA6CFBBC")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ANSWER).HasMaxLength(250);

                entity.Property(e => e.OTHERANSWER).HasMaxLength(250);

                entity.Property(e => e.QUESTION).HasMaxLength(250);

                entity.HasOne(d => d.SURVEYS)
                    .WithMany(p => p.SURVEY_ANSWERS)
                    .HasForeignKey(d => d.SURVEYSID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SURVEY_AN__SURVE__6C5905DD");
            });

            modelBuilder.Entity<dbo.SWICTHBOARD_LOG>(entity =>
            {
                entity.HasIndex(e => e.ADDDATE, "IX_SWICTHBOARD_LOG");

                entity.HasIndex(e => e.LOGKEY, "IX_SWICTHBOARD_LOG_1");

                entity.HasIndex(e => new { e.LOGKEY, e.ADDDATE }, "IX_SWICTHBOARD_LOG_2");

                entity.HasIndex(e => e.LINKEDID, "IX_SWICTHBOARD_LOG_3");

                entity.HasIndex(e => e.DSTCHANNEL, "IX_SWICTHBOARD_LOG_4");

                entity.HasIndex(e => new { e.CLID, e.DSTCHANNEL }, "IX_SWICTHBOARD_LOG_5");

                entity.Property(e => e.ACCOUNTCODE).HasMaxLength(50);

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CAMPAIGNNAME).HasMaxLength(150);

                entity.Property(e => e.CAUSETXT).HasMaxLength(150);

                entity.Property(e => e.CHANNELSTATEDESC).HasMaxLength(90);

                entity.Property(e => e.CLID).HasMaxLength(80);

                entity.Property(e => e.DST).HasMaxLength(80);

                entity.Property(e => e.DSTCHANNEL).HasMaxLength(80);

                entity.Property(e => e.LINKEDID).HasMaxLength(50);

                entity.Property(e => e.LOGKEY).HasMaxLength(50);
            });

            modelBuilder.Entity<dbo.TICKET>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__TICKET__3214EC269EB03149")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ADULTMANDATORY).HasDefaultValueSql("((1))");

                entity.Property(e => e.DEFINITION).HasMaxLength(200);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.PLU).HasMaxLength(10);

                entity.Property(e => e.TICKETTYPE).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.TICKETADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TICKET__ADDUSER__4FA7B896");

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.TICKET)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TICKET__CORPID__4BD727B2");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.TICKETEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__TICKET__EDITUSER__51900108");
            });

            modelBuilder.Entity<dbo.TICKET_ACTIVATIONS>(entity =>
            {
                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GATENUMBER).HasMaxLength(30);

                entity.Property(e => e.PERSONTYPE).HasMaxLength(15);

                entity.Property(e => e.REASON).HasMaxLength(250);

                entity.HasOne(d => d.GATENUMBERNavigation)
                    .WithMany(p => p.TICKET_ACTIVATIONS)
                    .HasForeignKey(d => d.GATENUMBER)
                    .HasConstraintName("FK__TICKET_AC__GATEN__131DCD43");

                entity.HasOne(d => d.REQUEST_DETAIL)
                    .WithMany(p => p.TICKET_ACTIVATIONS)
                    .HasForeignKey(d => d.REQUEST_DETAILID)
                    .HasConstraintName("FK__TICKET_AC__REQUE__5110DE1B");
            });

            modelBuilder.Entity<dbo.TICKET_GIFTS>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__TICKET_G__3214EC26E60638C6")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.CORPID, e.DEFINITION }, "UQ__TICKET_G__D0FAF60846C03765")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CURCODE)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEFINITION).HasMaxLength(100);

                entity.Property(e => e.PLU).HasMaxLength(10);

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.TICKET_GIFTS)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TICKET_GI__CORPI__150615B5");

                entity.HasOne(d => d.CURCODENavigation)
                    .WithMany(p => p.TICKET_GIFTS)
                    .HasForeignKey(d => d.CURCODE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TICKET_GI__CURCO__15FA39EE");
            });

            modelBuilder.Entity<dbo.TICKET_HOURS>(entity =>
            {
                entity.HasIndex(e => e.DATESORT, "IX_TICKET_HOURS");

                entity.HasIndex(e => new { e.STARTDATE, e.ENDDATE }, "IX_TICKET_HOURS_1");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DATESORT).HasComputedColumnSql("(datediff(day,[STARTDATE],[ENDDATE]))", true);

                entity.Property(e => e.DEFINITION).HasMaxLength(100);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.ENDDATE).HasColumnType("datetime");

                entity.Property(e => e.FRIDAY_ENDTIME).HasDefaultValueSql("((23))");

                entity.Property(e => e.FRIDAY_ENDTIME_M).HasDefaultValueSql("((0))");

                entity.Property(e => e.FRIDAY_STARTTIME).HasDefaultValueSql("((9))");

                entity.Property(e => e.FRIDAY_STARTTIME_M).HasDefaultValueSql("((0))");

                entity.Property(e => e.FRIDAY_USE)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MINUTEPERIOD).HasDefaultValueSql("((30))");

                entity.Property(e => e.MONDAY_ENDTIME).HasDefaultValueSql("((23))");

                entity.Property(e => e.MONDAY_ENDTIME_M).HasDefaultValueSql("((0))");

                entity.Property(e => e.MONDAY_STARTTIME).HasDefaultValueSql("((9))");

                entity.Property(e => e.MONDAY_STARTTIME_M).HasDefaultValueSql("((0))");

                entity.Property(e => e.MONDAY_USE)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SATURDAY_ENDTIME).HasDefaultValueSql("((23))");

                entity.Property(e => e.SATURDAY_ENDTIME_M).HasDefaultValueSql("((0))");

                entity.Property(e => e.SATURDAY_STARTTIME).HasDefaultValueSql("((9))");

                entity.Property(e => e.SATURDAY_STARTTIME_M).HasDefaultValueSql("((0))");

                entity.Property(e => e.SATURDAY_USE)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.STARTDATE).HasColumnType("datetime");

                entity.Property(e => e.SUNDAY_ENDTIME).HasDefaultValueSql("((23))");

                entity.Property(e => e.SUNDAY_ENDTIME_M).HasDefaultValueSql("((0))");

                entity.Property(e => e.SUNDAY_STARTTIME).HasDefaultValueSql("((9))");

                entity.Property(e => e.SUNDAY_STARTTIME_M).HasDefaultValueSql("((0))");

                entity.Property(e => e.SUNDAY_USE)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.THURSDAY_ENDTIME).HasDefaultValueSql("((23))");

                entity.Property(e => e.THURSDAY_ENDTIME_M).HasDefaultValueSql("((0))");

                entity.Property(e => e.THURSDAY_STARTTIME).HasDefaultValueSql("((9))");

                entity.Property(e => e.THURSDAY_STARTTIME_M).HasDefaultValueSql("((0))");

                entity.Property(e => e.THURSDAY_USE)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TUESDAY_ENDTIME).HasDefaultValueSql("((23))");

                entity.Property(e => e.TUESDAY_ENDTIME_M).HasDefaultValueSql("((0))");

                entity.Property(e => e.TUESDAY_STARTTIME).HasDefaultValueSql("((9))");

                entity.Property(e => e.TUESDAY_STARTTIME_M).HasDefaultValueSql("((0))");

                entity.Property(e => e.TUESDAY_USE)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.WEDNESDAY_ENDTIME).HasDefaultValueSql("((23))");

                entity.Property(e => e.WEDNESDAY_ENDTIME_M).HasDefaultValueSql("((0))");

                entity.Property(e => e.WEDNESDAY_STARTTIME).HasDefaultValueSql("((9))");

                entity.Property(e => e.WEDNESDAY_STARTTIME_M).HasDefaultValueSql("((0))");

                entity.Property(e => e.WEDNESDAY_USE)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.TICKET_HOURSADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TICKET_HO__ADDUS__5DF5D7ED");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.TICKET_HOURSEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__TICKET_HO__EDITU__5EE9FC26");

                entity.HasOne(d => d.TICKET)
                    .WithMany(p => p.TICKET_HOURS)
                    .HasForeignKey(d => d.TICKETID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TICKET_HO__TICKE__546C6DB3");
            });

            modelBuilder.Entity<dbo.TICKET_MARKET>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__TICKET_M__3214EC260690C17D")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.CORPID, e.DEFINITION, e.ISDELETED }, "UQ__TICKET_M__BDFB08EC06F75109")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DEFINITION).HasMaxLength(250);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.TICKET_MARKETADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TICKET_MA__ADDUS__19CACAD2");

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.TICKET_MARKET)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TICKET_MA__CORPI__1ABEEF0B");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.TICKET_MARKETEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__TICKET_MA__EDITU__1BB31344");

                entity.HasOne(d => d.STDMARKET)
                    .WithMany(p => p.TICKET_MARKET)
                    .HasForeignKey(d => d.STDMARKETID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TICKET_MARKET_STDMARKETS");
            });

            modelBuilder.Entity<dbo.TICKET_PRICES>(entity =>
            {
                entity.HasIndex(e => e.PRICESORT, "IX_TICKET_PRICES");

                entity.HasIndex(e => new { e.SELLFROM, e.SELLTO, e.TICKETDATEFROM, e.TICKETDATETO, e.CHECKINDAYS, e.MAXVALIDCAPACITY }, "IX_TICKET_PRICES_1");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ADULTPRICE).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.CHECKINDAYS)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CHILDPRICE).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.CURCODE)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.PRICEKIND).HasDefaultValueSql("((1))");

                entity.Property(e => e.PRICESORT).HasComputedColumnSql("(((((case when [SELLFROM] IS NOT NULL then (1) else (0) end+case when [SELLTO] IS NOT NULL then (1) else (0) end)+case when [TICKETDATEFROM] IS NOT NULL then (1) else (0) end)+case when [TICKETDATETO] IS NOT NULL then (1) else (0) end)+case when [CHECKINDAYS] IS NOT NULL then (1) else (0) end)+case when [MAXVALIDCAPACITY] IS NOT NULL then (1) else (0) end)", true);

                entity.Property(e => e.PRICETYPE).HasDefaultValueSql("((1))");

                entity.Property(e => e.SELLFROM).HasColumnType("datetime");

                entity.Property(e => e.SELLTO).HasColumnType("datetime");

                entity.Property(e => e.TICKETDATEFROM).HasColumnType("datetime");

                entity.Property(e => e.TICKETDATETO).HasColumnType("datetime");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.TICKET_PRICESADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TICKET_PR__ADDUS__60D24498");

                entity.HasOne(d => d.AGENCY)
                    .WithMany(p => p.TICKET_PRICES)
                    .HasForeignKey(d => d.AGENCYID)
                    .HasConstraintName("FK__TICKET_PR__AGENC__1CA7377D");

                entity.HasOne(d => d.CURCODENavigation)
                    .WithMany(p => p.TICKET_PRICES)
                    .HasForeignKey(d => d.CURCODE)
                    .HasConstraintName("FK__TICKET_PR__CURCO__593122D0");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.TICKET_PRICESEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__TICKET_PR__EDITU__61C668D1");

                entity.HasOne(d => d.MARKET)
                    .WithMany(p => p.TICKET_PRICES)
                    .HasForeignKey(d => d.MARKETID)
                    .HasConstraintName("FK_TICKET_PRICES_STDMARKETS");

                entity.HasOne(d => d.TICKET)
                    .WithMany(p => p.TICKET_PRICES)
                    .HasForeignKey(d => d.TICKETID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TICKET_PR__TICKE__5748DA5E");
            });

            modelBuilder.Entity<dbo.TILE_ITEMOPTION>(entity =>
            {
                entity.HasIndex(e => e.TICKETID, "UQ__TILE_ITE__19441072D123C1A9");

                entity.Property(e => e.BGIMAGE).HasColumnType("image");

                entity.Property(e => e.BGIMAGE2).HasColumnType("image");

                entity.Property(e => e.BGIMAGE_ALIGN).HasMaxLength(35);

                entity.Property(e => e.BGIMAGE_ALIGN2).HasMaxLength(25);

                entity.Property(e => e.BGIMAGE_MODE).HasMaxLength(25);

                entity.Property(e => e.BGIMAGE_MODE2).HasMaxLength(25);

                entity.Property(e => e.ROW_COUNT).HasDefaultValueSql("((2))");

                entity.HasOne(d => d.GIFT)
                    .WithMany(p => p.TILE_ITEMOPTION)
                    .HasForeignKey(d => d.GIFTID)
                    .HasConstraintName("FK__TILE_ITEM__GIFTI__41E3A924");

                entity.HasOne(d => d.TICKET)
                    .WithMany(p => p.TILE_ITEMOPTION)
                    .HasForeignKey(d => d.TICKETID)
                    .HasConstraintName("FK__TILE_ITEM__TICKE__6379A719");
            });

            modelBuilder.Entity<dbo.TOUR>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__TOUR__3214EC26A3D5EF82")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ADULTCAPACITY).HasDefaultValueSql("((1))");

                entity.Property(e => e.BOARDTYPE).HasMaxLength(100);

                entity.Property(e => e.DESCRIPTION).HasMaxLength(70);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.INTID).ValueGeneratedOnAdd();

                entity.Property(e => e.TOTAL_DAYS).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.TOURADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TOUR__ADDUSER__24485945");

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.TOUR)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TOUR__CORPID__253C7D7E");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.TOUREDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__TOUR__EDITUSER__2630A1B7");
            });

            modelBuilder.Entity<dbo.TOURDISCOUNT>(entity =>
            {
                entity.Property(e => e.DEFINITION).HasMaxLength(50);
            });

            modelBuilder.Entity<dbo.TOUR_DISCOUNTS>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__TOUR_DIS__3214EC26B2016A5E")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DEFINITION).HasMaxLength(50);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.SELLFROM).HasColumnType("datetime");

                entity.Property(e => e.SELLTO).HasColumnType("datetime");

                entity.Property(e => e.TOURFROM).HasColumnType("datetime");

                entity.Property(e => e.TOURTO).HasColumnType("datetime");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.TOUR_DISCOUNTSADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TOUR_DISC__ADDUS__66161CA2");

                entity.HasOne(d => d.DISCOUNTTYPENavigation)
                    .WithMany(p => p.TOUR_DISCOUNTS)
                    .HasForeignKey(d => d.DISCOUNTTYPE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TOUR_DISC__DISCO__61516785");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.TOUR_DISCOUNTSEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__TOUR_DISC__EDITU__670A40DB");

                entity.HasOne(d => d.TOUR)
                    .WithMany(p => p.TOUR_DISCOUNTS)
                    .HasForeignKey(d => d.TOURID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TOUR_DISC__TOURI__605D434C");
            });

            modelBuilder.Entity<dbo.TOUR_IMAGES>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DEFINITION).HasMaxLength(100);

                entity.Property(e => e.ID).ValueGeneratedOnAdd();

                entity.Property(e => e.THUMBNAIL).HasMaxLength(250);

                entity.Property(e => e.URL).HasMaxLength(250);

                entity.HasOne(d => d.TOUR)
                    .WithMany()
                    .HasForeignKey(d => d.TOURID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TOUR_IMAG__TOURI__2BE97B0D");

                entity.HasOne(d => d.TOUR_PROGRAM)
                    .WithMany()
                    .HasForeignKey(d => d.TOUR_PROGRAMID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__TOUR_IMAG__TOUR___2AF556D4");
            });

            modelBuilder.Entity<dbo.TOUR_PRICES>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__TOUR_PRI__3214EC262F119988")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.BABY).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.CHDE).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.CHDY).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.COMMISSIONINCLUDED).HasDefaultValueSql("((0))");

                entity.Property(e => e.CURCODE)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DBL).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.DEPARTURE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEPARTURE_LOCATION).HasMaxLength(100);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.EXBED).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.QUAD).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.SNG).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.TRP).HasColumnType("decimal(19, 2)");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.TOUR_PRICESADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TOUR_PRIC__ADDUS__0D8FDC76");

                entity.HasOne(d => d.CURCODENavigation)
                    .WithMany(p => p.TOUR_PRICES)
                    .HasForeignKey(d => d.CURCODE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TOUR_PRIC__CURCO__0C9BB83D");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.TOUR_PRICESEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__TOUR_PRIC__EDITU__0F7824E8");

                entity.HasOne(d => d.TOUR)
                    .WithMany(p => p.TOUR_PRICES)
                    .HasForeignKey(d => d.TOURID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TOUR_PRIC__TOURI__04FA9675");
            });

            modelBuilder.Entity<dbo.TOUR_PROGRAM>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__TOUR_PRO__3214EC26DD8FA3AC")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.STEPNO, e.SORTORDER }, "IX_TOUR_PROGRAM");

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.STEPNO).HasDefaultValueSql("((1))");

                entity.Property(e => e.TITLE).HasMaxLength(200);

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.TOUR_PROGRAMADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TOUR_PROG__ADDUS__30AE302A");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.TOUR_PROGRAMEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__TOUR_PROG__EDITU__31A25463");

                entity.HasOne(d => d.HOTEL)
                    .WithMany(p => p.TOUR_PROGRAM)
                    .HasForeignKey(d => d.HOTELID)
                    .HasConstraintName("FK__TOUR_PROG__HOTEL__3296789C");

                entity.HasOne(d => d.TOUR)
                    .WithMany(p => p.TOUR_PROGRAM)
                    .HasForeignKey(d => d.TOURID)
                    .HasConstraintName("FK__TOUR_PROG__TOURI__338A9CD5");
            });

            modelBuilder.Entity<dbo.TRANSFER_LOCATIONS>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__TRANSFER__3214EC26B028FCA6")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AIRPORTCODE).HasMaxLength(5);

                entity.Property(e => e.DEFINITION).HasMaxLength(170);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.TRANSFER_LOCATIONSADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TRANSFER___ADDUS__629A9179");

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.TRANSFER_LOCATIONS)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TRANSFER___CORPI__638EB5B2");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.TRANSFER_LOCATIONSEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__TRANSFER___EDITU__6482D9EB");
            });

            modelBuilder.Entity<dbo.TRANSFER_PRICES>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__TRANSFER__3214EC261C147107")
                    .IsClustered(false);

                entity.HasIndex(e => e.TOLOCATIONID, "IX_TRANSFER_PRICES");

                entity.HasIndex(e => e.FROMLOCATIONID, "IX_TRANSFER_PRICES_1");

                entity.HasIndex(e => e.PRICESORT, "IX_TRANSFER_PRICES_2");

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ADULTPRICE_ONEWAY).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.ADULTPRICE_TWOWAY).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.ARRIVALDAYS)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BABYPRICE_ONEWAY).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.BABYPRICE_TWOWAY).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.CHILDPRICE_ONEWAY).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.CHILDPRICE_TWOWAY).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.CURCODE)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEPARTUREDAYS)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.PRICESORT).HasComputedColumnSql("(case when [VEHICLETYPEID] IS NOT NULL then (4) else (0) end+((((((case when [SELLFROM] IS NOT NULL then (1) else (0) end+case when [SELLTO] IS NOT NULL then (1) else (0) end)+case when [TICKETDATEFROM] IS NOT NULL then (1) else (0) end)+case when [TICKETDATETO] IS NOT NULL then (1) else (0) end)+case when [ARRIVALDAYS] IS NOT NULL then (1) else (0) end)+case when [DEPARTUREDAYS] IS NOT NULL then (1) else (0) end)+case when [SELLDAYS] IS NOT NULL then (1) else (0) end))", true);

                entity.Property(e => e.PRICETYPE).HasDefaultValueSql("((1))");

                entity.Property(e => e.SELLDAYS)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SELLFROM).HasColumnType("datetime");

                entity.Property(e => e.SELLTO).HasColumnType("datetime");

                entity.Property(e => e.TICKETDATEFROM).HasColumnType("datetime");

                entity.Property(e => e.TICKETDATETO).HasColumnType("datetime");

                entity.Property(e => e.USEONLINE).HasDefaultValueSql("((1))");

                entity.Property(e => e.VEHICLEPRICE_ONEWAY).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.VEHICLEPRICE_TWOWAY).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.VEHICLETYPE).HasMaxLength(40);

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.TRANSFER_PRICESADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TRANSFER_PR__ADDUS__60D24498");

                entity.HasOne(d => d.AGENCY)
                    .WithMany(p => p.TRANSFER_PRICES)
                    .HasForeignKey(d => d.AGENCYID)
                    .HasConstraintName("FK__TRANSFER___AGENC__6E414E4F");

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.TRANSFER_PRICES)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TRANSFER_PRICES_CORP");

                entity.HasOne(d => d.CURCODENavigation)
                    .WithMany(p => p.TRANSFER_PRICES)
                    .HasForeignKey(d => d.CURCODE)
                    .HasConstraintName("FK__TRANSFER_PR__CURCO__593122D0");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.TRANSFER_PRICESEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__TRANSFER_PR__EDITU__61C668D1");

                entity.HasOne(d => d.MARKET)
                    .WithMany(p => p.TRANSFER_PRICES)
                    .HasForeignKey(d => d.MARKETID)
                    .HasConstraintName("FK__TRANSFER___MARKE__711DBAFA");

                entity.HasOne(d => d.PROVIDER)
                    .WithMany(p => p.TRANSFER_PRICES)
                    .HasForeignKey(d => d.PROVIDERID)
                    .HasConstraintName("FK__TRANSFER___PROVI__7F8BD5E2");

                entity.HasOne(d => d.VEHICLETYPENavigation)
                    .WithMany(p => p.TRANSFER_PRICES)
                    .HasForeignKey(d => d.VEHICLETYPE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TRANSFER___VEHIC__688874F9");

                entity.HasOne(d => d.VEHICLETYPE1)
                    .WithMany(p => p.TRANSFER_PRICES)
                    .HasForeignKey(d => d.VEHICLETYPEID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TRANSFER___VEHIC__08012052");
            });

            modelBuilder.Entity<dbo.TRANSFER_PROVIDERS>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__TRANSFER__3214EC26E0C4BD3E")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DESCRIPTION).HasMaxLength(170);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.TRANSFER_PROVIDERSADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TRANSFER___ADDUS__7CAF6937");

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.TRANSFER_PROVIDERS)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TRANSFER___CORPI__7DA38D70");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.TRANSFER_PROVIDERSEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__TRANSFER___EDITU__7E97B1A9");
            });

            modelBuilder.Entity<dbo.TURNIKE>(entity =>
            {
                entity.HasKey(e => e.GATENUMBER)
                    .HasName("PK__TURNIKE__686C874524E067A2")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.CORPID, e.GATENUMBER }, "UQ__TURNIKE__7049794427ADDDCD")
                    .IsUnique();

                entity.Property(e => e.GATENUMBER).HasMaxLength(30);

                entity.Property(e => e.DIRECTION)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.TURNIKE)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TURNIKE__CORPID__347EC10E");
            });

            modelBuilder.Entity<dbo.USERS>(entity =>
            {
                entity.HasIndex(e => e.MODULEID, "IX_USERS");

                entity.HasIndex(e => e.USERNAME, "IX_USERS_1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.EMAIL).HasMaxLength(200);

                entity.Property(e => e.FIRSTNAME).HasMaxLength(100);

                entity.Property(e => e.FULLNAME)
                    .HasMaxLength(201)
                    .HasComputedColumnSql("((isnull([FIRSTNAME],'')+' ')+isnull([LASTNAME],''))", false);

                entity.Property(e => e.LASTNAME).HasMaxLength(100);

                entity.Property(e => e.PASSWORD).HasMaxLength(100);

                entity.Property(e => e.USERNAME).HasMaxLength(100);

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.InverseADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__USERS__ADDUSER__3A81B327");

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.USERS)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USERS_CORP");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.InverseEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__USERS__EDITUSER__3C69FB99");
            });

            modelBuilder.Entity<dbo.USERS_CUSTOMAUTH>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__USERS_CU__3214EC264938BA04")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.EXTERNAL_PASSWORD).HasMaxLength(50);

                entity.HasOne(d => d.USER)
                    .WithMany(p => p.USERS_CUSTOMAUTH)
                    .HasForeignKey(d => d.USERID)
                    .HasConstraintName("FK__USERS_CUS__USERI__5654B625");
            });

            modelBuilder.Entity<dbo.USER_HISTORY>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__USER_HIS__3214EC261AE2A58D")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IPADDRESS).HasMaxLength(25);

                entity.HasOne(d => d.USER)
                    .WithMany(p => p.USER_HISTORY)
                    .HasForeignKey(d => d.USERID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__USER_HIST__USERI__519AEE00");
            });

            modelBuilder.Entity<dbo.USER_PROJECTS>(entity =>
            {
                entity.HasIndex(e => new { e.USERID, e.PROJECT_GROUPID }, "IX_USER_PROJECTS")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.HasOne(d => d.PROJECT_GROUP)
                    .WithMany(p => p.USER_PROJECTS)
                    .HasForeignKey(d => d.PROJECT_GROUPID)
                    .HasConstraintName("FK__USER_PROJ__PROJE__662B2B3B");
            });

            modelBuilder.Entity<dbo.USER_PROJECT_DETAILS>(entity =>
            {
                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.HasOne(d => d.PROJECT_GROUPDETAIL)
                    .WithMany(p => p.USER_PROJECT_DETAILS)
                    .HasForeignKey(d => d.PROJECT_GROUPDETAILID)
                    .HasConstraintName("FK_USER_PROJECT_DETAILS_PROJECT_GROUPDETAIL");
            });

            modelBuilder.Entity<dbo.USER_ROLES>(entity =>
            {
                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.HasOne(d => d.ROLE)
                    .WithMany(p => p.USER_ROLES)
                    .HasForeignKey(d => d.ROLEID)
                    .HasConstraintName("FK__USER_ROLE__ROLEI__5224328E");

                entity.HasOne(d => d.USER)
                    .WithMany(p => p.USER_ROLES)
                    .HasForeignKey(d => d.USERID)
                    .HasConstraintName("FK__USER_ROLE__USERI__46E78A0C");
            });

            modelBuilder.Entity<dbo.USER_ROLE_REQUEST_STATUS>(entity =>
            {
                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.ROLE)
                    .WithMany(p => p.USER_ROLE_REQUEST_STATUS)
                    .HasForeignKey(d => d.ROLEID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__USER_ROLE__ROLEI__7E8CC4B1");

                entity.HasOne(d => d.STATU)
                    .WithMany(p => p.USER_ROLE_REQUEST_STATUS)
                    .HasForeignKey(d => d.STATUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__USER_ROLE__STATU__7F80E8EA");
            });

            modelBuilder.Entity<dbo.VEHICLETYPES>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__VEHICLET__3214EC26E4D43FAB")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AIRCONDITION)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BAGGAGE_CAPACITY)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("((3))")
                    .IsFixedLength();

                entity.Property(e => e.DEFINITION).HasMaxLength(70);

                entity.Property(e => e.DESCRIPTION).HasMaxLength(250);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.PERSON_COUNT).HasDefaultValueSql("((4))");

                entity.Property(e => e.SPECIAL_CODE).HasMaxLength(15);

                entity.Property(e => e.VEHICLETYPE).HasMaxLength(40);

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.VEHICLETYPESADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VEHICLETY__ADDUS__30441BD6");

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.VEHICLETYPES)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VEHICLETY__CORPI__3138400F");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.VEHICLETYPESEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__VEHICLETY__EDITU__322C6448");

                entity.HasOne(d => d.VEHICLETYPENavigation)
                    .WithMany(p => p.VEHICLETYPES)
                    .HasForeignKey(d => d.VEHICLETYPE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VEHICLETY__VEHIC__2C738AF2");
            });

            modelBuilder.Entity<dbo.VIRTUAL_POS>(entity =>
            {
                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ACC_INV_CODE).HasMaxLength(30);

                entity.Property(e => e.ACC_PAY_CODE).HasMaxLength(30);

                entity.Property(e => e.BINNUMBER_NAME).HasMaxLength(50);

                entity.Property(e => e.CLASS).HasMaxLength(150);

                entity.Property(e => e.CORPID).HasDefaultValueSql("('183D3B34-92F3-4A9B-B976-60F68FD1519B')");

                entity.Property(e => e.DESCRIPTION).HasMaxLength(150);

                entity.Property(e => e.FONTCOLOR).HasMaxLength(20);

                entity.Property(e => e.FORECOLOR).HasMaxLength(20);

                entity.Property(e => e.ICONURL).HasMaxLength(250);

                entity.Property(e => e.INTID).ValueGeneratedOnAdd();

                entity.Property(e => e.NAME).HasMaxLength(150);

                entity.Property(e => e.XMLPASSWORD).HasMaxLength(150);

                entity.Property(e => e.XMLUSERNAME).HasMaxLength(150);

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.VIRTUAL_POS)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__CORPI__6DF7358C");
            });

            modelBuilder.Entity<dbo.VIRTUAL_POSBINNAMES>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BINNUMBER_NAME).HasMaxLength(50);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.POS)
                    .WithMany()
                    .HasForeignKey(d => d.POSID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__POSID__361CF0BD");
            });

            modelBuilder.Entity<dbo.VIRTUAL_POS_ACCOUNTS>(entity =>
            {
                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ACCOUNTNAME).HasMaxLength(50);

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.BINNUMBER_NAME).HasMaxLength(50);

                entity.Property(e => e.CLIENTID).HasMaxLength(50);

                entity.Property(e => e.DEFINITION).HasMaxLength(150);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.EMAIL).HasMaxLength(200);

                entity.Property(e => e.ENTID).HasMaxLength(100);

                entity.Property(e => e.ENT_HOTELID).HasMaxLength(25);

                entity.Property(e => e.PARAMS).HasMaxLength(350);

                entity.Property(e => e.PASSWORD).HasMaxLength(50);

                entity.Property(e => e.PASSWORD_3D).HasMaxLength(50);

                entity.Property(e => e.POSTURL).HasMaxLength(250);

                entity.Property(e => e.TERMINALID).HasMaxLength(50);

                entity.Property(e => e.USE3D).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.VIRTUAL_POS_ACCOUNTSADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__ADDUS__0A1E72EE");

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.VIRTUAL_POS_ACCOUNTS)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__CORPI__08362A7C");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.VIRTUAL_POS_ACCOUNTSEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__VIRTUAL_P__EDITU__0C06BB60");

                entity.HasOne(d => d.POS)
                    .WithMany(p => p.VIRTUAL_POS_ACCOUNTS)
                    .HasForeignKey(d => d.POSID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__POSID__07420643");
            });

            modelBuilder.Entity<dbo.VIRTUAL_POS_ACCOUNTS_CURCODES>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__VIRTUAL___3214EC263FC4CE80")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.ACCOUNTID, e.CURCODE }, "UQ__VIRTUAL___0ACA257EBD9DAF3E")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CURCODE)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SCHEMES).HasMaxLength(220);

                entity.HasOne(d => d.ACCOUNT)
                    .WithMany(p => p.VIRTUAL_POS_ACCOUNTS_CURCODES)
                    .HasForeignKey(d => d.ACCOUNTID)
                    .HasConstraintName("FK__VIRTUAL_P__ACCOU__5807F46D");

                entity.HasOne(d => d.CURCODENavigation)
                    .WithMany(p => p.VIRTUAL_POS_ACCOUNTS_CURCODES)
                    .HasForeignKey(d => d.CURCODE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__CURCO__4A6E022D");
            });

            modelBuilder.Entity<dbo.VIRTUAL_POS_ACCOUNT_INSTALMENTS>(entity =>
            {
                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.HasOne(d => d.ACCOUNT)
                    .WithMany(p => p.VIRTUAL_POS_ACCOUNT_INSTALMENTS)
                    .HasForeignKey(d => d.ACCOUNTID)
                    .HasConstraintName("FK__VIRTUAL_P__ACCOU__10CB707D");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.VIRTUAL_POS_ACCOUNT_INSTALMENTSADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__ADDUS__43C1049E");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.VIRTUAL_POS_ACCOUNT_INSTALMENTSEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__VIRTUAL_P__EDITU__44B528D7");
            });

            modelBuilder.Entity<dbo.VIRTUAL_POS_BINNUMBERS>(entity =>
            {
                entity.HasIndex(e => e.BINNO, "IX_VIRTUAL_POS_BINNUMBERS");

                entity.HasIndex(e => e.BINNO, "UQ__VIRTUAL___5D92CF0E5E919BD3")
                    .IsUnique();

                entity.Property(e => e.BANKNAME).HasMaxLength(100);

                entity.Property(e => e.BINNO).HasMaxLength(7);

                entity.Property(e => e.SCHEMA).HasMaxLength(30);

                entity.Property(e => e.TYPE).HasMaxLength(30);
            });

            modelBuilder.Entity<dbo.VIRTUAL_POS_DEFAULTS>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__VIRTUAL___3214EC26FBDA7D1D")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.VIRTUAL_POS_DEFAULTSADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__ADDUS__1D913A15");

                entity.HasOne(d => d.AMEX_EX_POS)
                    .WithMany(p => p.VIRTUAL_POS_DEFAULTSAMEX_EX_POS)
                    .HasForeignKey(d => d.AMEX_EX_POSID)
                    .HasConstraintName("FK__VIRTUAL_P__AMEX___19C0A931");

                entity.HasOne(d => d.AMEX_POS)
                    .WithMany(p => p.VIRTUAL_POS_DEFAULTSAMEX_POS)
                    .HasForeignKey(d => d.AMEX_POSID)
                    .HasConstraintName("FK__VIRTUAL_P__AMEX___1407CFDB");

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.VIRTUAL_POS_DEFAULTS)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__CORPI__10373EF7");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.VIRTUAL_POS_DEFAULTSEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__VIRTUAL_P__EDITU__1F798287");

                entity.HasOne(d => d.JCB_EX_POS)
                    .WithMany(p => p.VIRTUAL_POS_DEFAULTSJCB_EX_POS)
                    .HasForeignKey(d => d.JCB_EX_POSID)
                    .HasConstraintName("FK__VIRTUAL_P__JCB_E__1AB4CD6A");

                entity.HasOne(d => d.JCB_POS)
                    .WithMany(p => p.VIRTUAL_POS_DEFAULTSJCB_POS)
                    .HasForeignKey(d => d.JCB_POSID)
                    .HasConstraintName("FK__VIRTUAL_P__JCB_P__14FBF414");

                entity.HasOne(d => d.MAESTRO_EX_POS)
                    .WithMany(p => p.VIRTUAL_POS_DEFAULTSMAESTRO_EX_POS)
                    .HasForeignKey(d => d.MAESTRO_EX_POSID)
                    .HasConstraintName("FK__VIRTUAL_P__MAEST__1C9D15DC");

                entity.HasOne(d => d.MAESTRO_POS)
                    .WithMany(p => p.VIRTUAL_POS_DEFAULTSMAESTRO_POS)
                    .HasForeignKey(d => d.MAESTRO_POSID)
                    .HasConstraintName("FK__VIRTUAL_P__MAEST__16E43C86");

                entity.HasOne(d => d.MASTER_EX_POS)
                    .WithMany(p => p.VIRTUAL_POS_DEFAULTSMASTER_EX_POS)
                    .HasForeignKey(d => d.MASTER_EX_POSID)
                    .HasConstraintName("FK__VIRTUAL_P__MASTE__18CC84F8");

                entity.HasOne(d => d.MASTER_POS)
                    .WithMany(p => p.VIRTUAL_POS_DEFAULTSMASTER_POS)
                    .HasForeignKey(d => d.MASTER_POSID)
                    .HasConstraintName("FK__VIRTUAL_P__MASTE__1313ABA2");

                entity.HasOne(d => d.PORTALU)
                    .WithMany(p => p.VIRTUAL_POS_DEFAULTS)
                    .HasPrincipalKey(p => p.UID)
                    .HasForeignKey(d => d.PORTALUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__PORTA__112B6330");

                entity.HasOne(d => d.UNIONPAY_EX_POS)
                    .WithMany(p => p.VIRTUAL_POS_DEFAULTSUNIONPAY_EX_POS)
                    .HasForeignKey(d => d.UNIONPAY_EX_POSID)
                    .HasConstraintName("FK__VIRTUAL_P__UNION__1BA8F1A3");

                entity.HasOne(d => d.UNIONPAY_POS)
                    .WithMany(p => p.VIRTUAL_POS_DEFAULTSUNIONPAY_POS)
                    .HasForeignKey(d => d.UNIONPAY_POSID)
                    .HasConstraintName("FK__VIRTUAL_P__UNION__15F0184D");

                entity.HasOne(d => d.VISA_EX_POS)
                    .WithMany(p => p.VIRTUAL_POS_DEFAULTSVISA_EX_POS)
                    .HasForeignKey(d => d.VISA_EX_POSID)
                    .HasConstraintName("FK__VIRTUAL_P__VISA___17D860BF");

                entity.HasOne(d => d.VISA_POS)
                    .WithMany(p => p.VIRTUAL_POS_DEFAULTSVISA_POS)
                    .HasForeignKey(d => d.VISA_POSID)
                    .HasConstraintName("FK__VIRTUAL_P__VISA___121F8769");
            });

            modelBuilder.Entity<dbo.VIRTUAL_POS_DEP_ACCOUNTS>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__VIRTUAL___3214EC2631497AA5")
                    .IsClustered(false);

                entity.HasIndex(e => e.IBAN, "UQ__VIRTUAL___8235CCBCC71928CD")
                    .IsUnique();

                entity.HasIndex(e => new { e.POSID, e.BRAND_CODE, e.ACCOUNT_NO }, "UQ__VIRTUAL___FB82C868314D95A7")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ACCOUNT_NO).HasMaxLength(35);

                entity.Property(e => e.BRAND_CODE).HasMaxLength(25);

                entity.Property(e => e.CURCODE)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEFINITION).HasMaxLength(100);

                entity.Property(e => e.ENTID).HasMaxLength(100);

                entity.Property(e => e.FIRMNAME).HasMaxLength(250);

                entity.Property(e => e.IBAN).HasMaxLength(35);

                entity.Property(e => e.SWIFTCODE).HasMaxLength(50);
            });

            modelBuilder.Entity<dbo.VIRTUAL_POS_DEP_PAYMENTS>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__VIRTUAL___3214EC26FF40B2D4")
                    .IsClustered(false);

                entity.HasIndex(e => e.ADDDATE, "IX_VIRTUAL_POS_DEP_PAYMENTS");

                entity.HasIndex(e => e.ADDDATE, "IX_VIRTUAL_POS_DEP_PAYMENTS_1");

                entity.HasIndex(e => e.EDITDATE, "IX_VIRTUAL_POS_DEP_PAYMENTS_2");

                entity.HasIndex(e => e.EDITDATE, "IX_VIRTUAL_POS_DEP_PAYMENTS_3");

                entity.HasIndex(e => e.STATUS, "IX_VIRTUAL_POS_DEP_PAYMENTS_4");

                entity.HasIndex(e => e.TRANSFERCODE, "IX_VIRTUAL_POS_DEP_PAYMENTS_5");

                entity.HasIndex(e => e.ISDELETED, "IX_VIRTUAL_POS_DEP_PAYMENTS_6");

                entity.HasIndex(e => e.INTID, "IX_VIRTUAL_POS_DEP_PAYMENTS_7");

                entity.HasIndex(e => e.ENTID, "IX_VIRTUAL_POS_DEP_PAYMENTS_8");

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.BANKTRANSACTIONID).HasMaxLength(50);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.ENDTIME).HasColumnType("datetime");

                entity.Property(e => e.ENTID).HasMaxLength(100);

                entity.Property(e => e.INTID).ValueGeneratedOnAdd();

                entity.Property(e => e.TRANSFERCODE).HasMaxLength(10);

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.VIRTUAL_POS_DEP_PAYMENTSADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__ADDUS__4C564A9F");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.VIRTUAL_POS_DEP_PAYMENTSEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__VIRTUAL_P__EDITU__4D4A6ED8");

                entity.HasOne(d => d.POSACCOUNT)
                    .WithMany(p => p.VIRTUAL_POS_DEP_PAYMENTS)
                    .HasForeignKey(d => d.POSACCOUNTID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__POSAC__0D6FE0E5");

                entity.HasOne(d => d.REQUEST)
                    .WithMany(p => p.VIRTUAL_POS_DEP_PAYMENTS)
                    .HasForeignKey(d => d.REQUESTID)
                    .HasConstraintName("FK__VIRTUAL_P__REQUE__12349602");

                entity.HasOne(d => d.STATUSNavigation)
                    .WithMany(p => p.VIRTUAL_POS_DEP_PAYMENTS)
                    .HasForeignKey(d => d.STATUS)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__STATU__4E3E9311");
            });

            modelBuilder.Entity<dbo.VIRTUAL_POS_DEP_PAYMENTS_CANCEL>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__VIRTUAL___3214EC261F2CCB2B")
                    .IsClustered(false);

                entity.HasIndex(e => e.ENTID, "IX_VIRTUAL_POS_DEP_PAYMENTS_CANCEL");

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EDITDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ENTID).HasMaxLength(100);

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.VIRTUAL_POS_DEP_PAYMENTS_CANCELADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__ADDUS__4341E1B1");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.VIRTUAL_POS_DEP_PAYMENTS_CANCELEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__VIRTUAL_P__EDITU__443605EA");

                entity.HasOne(d => d.PAYMENT)
                    .WithMany(p => p.VIRTUAL_POS_DEP_PAYMENTS_CANCEL)
                    .HasForeignKey(d => d.PAYMENTID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__PAYME__452A2A23");

                entity.HasOne(d => d.REQUEST_DETAIL)
                    .WithMany(p => p.VIRTUAL_POS_DEP_PAYMENTS_CANCEL)
                    .HasForeignKey(d => d.REQUEST_DETAILID)
                    .HasConstraintName("FK__VIRTUAL_P__REQUE__2E11BAA1");
            });

            modelBuilder.Entity<dbo.VIRTUAL_POS_PAYMENTS>(entity =>
            {
                entity.HasIndex(e => e.ISDELETED, "IX_VIRTUAL_POS_PAYMENTS");

                entity.HasIndex(e => e.ADDDATE, "IX_VIRTUAL_POS_PAYMENTS_1");

                entity.HasIndex(e => e.ADDDATE, "IX_VIRTUAL_POS_PAYMENTS_2");

                entity.HasIndex(e => e.FIRSTSTEP, "IX_VIRTUAL_POS_PAYMENTS_3");

                entity.HasIndex(e => e.VOID, "IX_VIRTUAL_POS_PAYMENTS_4");

                entity.HasIndex(e => e.REFUND, "IX_VIRTUAL_POS_PAYMENTS_5");

                entity.HasIndex(e => e.ENTID, "IX_VIRTUAL_POS_PAYMENTS_6");

                entity.HasIndex(e => new { e.ISDELETED, e.PAYMENT_REQUESTID, e.STATUS }, "IX_VIRTUAL_POS_PAYMENTS_ISDELETED_PAYMENT_REQUESTID_STATUS");

                entity.HasIndex(e => new { e.STATUS, e.ISDELETED }, "MIS_IDX_01");

                entity.HasIndex(e => e.ISDELETED, "MIS_IDX_2");

                entity.HasIndex(e => e.ISDELETED, "MIS_IDX_VIRTUAL_POS_PAYMENTS_01");

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE).HasColumnType("datetime");

                entity.Property(e => e.AUTHCODE).HasMaxLength(200);

                entity.Property(e => e.CARDNUMBER).HasMaxLength(50);

                entity.Property(e => e.CARDOWNER).HasMaxLength(200);

                entity.Property(e => e.COMPLETEBASKET_AFTERSUCCESS).HasDefaultValueSql("((0))");

                entity.Property(e => e.CURCODE)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CVV).HasMaxLength(5);

                entity.Property(e => e.DESCRIPTION).HasMaxLength(100);

                entity.Property(e => e.ECI).HasMaxLength(50);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.ENDTIME).HasColumnType("datetime");

                entity.Property(e => e.ENTID).HasMaxLength(100);

                entity.Property(e => e.INSTALMENT).HasDefaultValueSql("((1))");

                entity.Property(e => e.INTID).ValueGeneratedOnAdd();

                entity.Property(e => e.ISINTEGRATED).HasComputedColumnSql("(case when [ENTID] IS NULL then (0) else (1) end)", true);

                entity.Property(e => e.PAYER_AUTHCODE).HasMaxLength(50);

                entity.Property(e => e.PAYER_TNXID).HasMaxLength(50);

                entity.Property(e => e.RETREFNUMBER).HasMaxLength(200);

                entity.Property(e => e.STATUSTEXT).HasMaxLength(500);

                entity.Property(e => e.STORETYPE).HasMaxLength(30);

                entity.Property(e => e.TRANTYPE).HasMaxLength(15);

                entity.Property(e => e.VALIDDATE).HasColumnType("datetime");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.VIRTUAL_POS_PAYMENTSADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REQUEST_P__ADDUS__25C68D63");

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.VIRTUAL_POS_PAYMENTS)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__CORPI__511AFFBC");

                entity.HasOne(d => d.CURCODENavigation)
                    .WithMany(p => p.VIRTUAL_POS_PAYMENTS)
                    .HasForeignKey(d => d.CURCODE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REQUEST_P__CURCO__23DE44F1");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.VIRTUAL_POS_PAYMENTSEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__REQUEST_P__EDITU__26BAB19C");

                entity.HasOne(d => d.PAYMENT_REQUEST)
                    .WithMany(p => p.VIRTUAL_POS_PAYMENTS)
                    .HasForeignKey(d => d.PAYMENT_REQUESTID)
                    .HasConstraintName("FK_VIRTUAL_POS_PAYMENTS_VIRTUAL_POS_PAYMENT_REQUESTS");

                entity.HasOne(d => d.POSACCOUNT)
                    .WithMany(p => p.VIRTUAL_POS_PAYMENTS)
                    .HasForeignKey(d => d.POSACCOUNTID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VIRTUAL_POS_PAYMENTS_VIRTUAL_POS_ACCOUNTS");

                entity.HasOne(d => d.POSINSTALMENT)
                    .WithMany(p => p.VIRTUAL_POS_PAYMENTS)
                    .HasForeignKey(d => d.POSINSTALMENTID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__POSIN__520F23F5");

                entity.HasOne(d => d.REQUEST)
                    .WithMany(p => p.VIRTUAL_POS_PAYMENTS)
                    .HasForeignKey(d => d.REQUESTID)
                    .HasConstraintName("FK__REQUEST_P__REQUE__22EA20B8");

                entity.HasOne(d => d.STATUSNavigation)
                    .WithMany(p => p.VIRTUAL_POS_PAYMENTS)
                    .HasForeignKey(d => d.STATUS)
                    .HasConstraintName("FK__REQUEST_P__STATU__24D2692A");
            });

            modelBuilder.Entity<dbo.VIRTUAL_POS_PAYMENTS_CANCEL>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__VIRTUAL___3214EC2696B31157")
                    .IsClustered(false);

                entity.HasIndex(e => e.SUCCESS, "IX_VIRTUAL_POS_PAYMENTS_CANCEL");

                entity.HasIndex(e => e.ADDDATE, "IX_VIRTUAL_POS_PAYMENTS_CANCEL_1");

                entity.HasIndex(e => e.ADDDATE, "IX_VIRTUAL_POS_PAYMENTS_CANCEL_2");

                entity.HasIndex(e => new { e.PAYMENTID, e.SUCCESS }, "IX_VIRTUAL_POS_PAYMENTS_CANCEL_3");

                entity.HasIndex(e => e.ENTID, "IX_VIRTUAL_POS_PAYMENTS_CANCEL_4");

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EDITDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ENTID).HasMaxLength(100);

                entity.HasOne(d => d.REQUEST_DETAIL)
                    .WithMany(p => p.VIRTUAL_POS_PAYMENTS_CANCEL)
                    .HasForeignKey(d => d.REQUEST_DETAILID)
                    .HasConstraintName("FK__VIRTUAL_P__REQUE__2D1D9668");
            });

            modelBuilder.Entity<dbo.VIRTUAL_POS_PAYMENT_EMAILS>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__VIRTUAL___3214EC26319DB2DB")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.EMAIL).HasMaxLength(200);

                entity.Property(e => e.FIRSTNAME).HasMaxLength(70);

                entity.Property(e => e.LASTNAME).HasMaxLength(70);

                entity.Property(e => e.PHONENUMBER).HasMaxLength(50);

                entity.Property(e => e.RESULT_MAIL).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.VIRTUAL_POS_PAYMENT_EMAILSADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__ADDUS__332B7579");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.VIRTUAL_POS_PAYMENT_EMAILSEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__VIRTUAL_P__EDITU__3513BDEB");

                entity.HasOne(d => d.PAYMENT)
                    .WithMany(p => p.VIRTUAL_POS_PAYMENT_EMAILS)
                    .HasForeignKey(d => d.PAYMENTID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_VIRTUAL_POS_PAYMENT_EMAILS_VIRTUAL_POS_PAYMENT_REQUESTS");

                entity.HasOne(d => d.TEMP)
                    .WithMany(p => p.VIRTUAL_POS_PAYMENT_EMAILS)
                    .HasForeignKey(d => d.TEMPID)
                    .HasConstraintName("FK__VIRTUAL_P__TEMPI__31432D07");
            });

            modelBuilder.Entity<dbo.VIRTUAL_POS_PAYMENT_MESSAGE_TEMPS>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__VIRTUAL___3214EC26B5BF55CC")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DESCRIPTION).HasMaxLength(150);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.VIRTUAL_POS_PAYMENT_MESSAGE_TEMPSADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__ADDUS__13B2CA20");

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.VIRTUAL_POS_PAYMENT_MESSAGE_TEMPS)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__CORPI__0FE2393C");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.VIRTUAL_POS_PAYMENT_MESSAGE_TEMPSEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__VIRTUAL_P__EDITU__159B1292");
            });

            modelBuilder.Entity<dbo.VIRTUAL_POS_PAYMENT_REQUESTS>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__VIR_REQTUAL___3214EC2615C97ABF")
                    .IsClustered(false);

                entity.HasIndex(e => e.ADDDATE, "IX_VIRTUAL_POS_PAYMENT_REQUESTS");

                entity.HasIndex(e => e.ADDDATE, "IX_VIRTUAL_POS_PAYMENT_REQUESTS_1");

                entity.HasIndex(e => new { e.ADDDATE, e.ISDELETED, e.CORPID }, "IX_VIRTUAL_POS_PAYMENT_REQUESTS_2");

                entity.HasIndex(e => e.ISDELETED, "IX_VIRTUAL_POS_PAYMENT_REQUESTS_3");

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CANDIV_PAYMENT).HasDefaultValueSql("((0))");

                entity.Property(e => e.CURCODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DESCRIPTION).HasMaxLength(150);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.FDATE).HasColumnType("datetime");

                entity.Property(e => e.LANGCODE)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PIECE).HasDefaultValueSql("((1))");

                entity.Property(e => e.RESNUMBER).HasMaxLength(50);

                entity.Property(e => e.SDATE).HasColumnType("datetime");

                entity.Property(e => e.TITLE).HasMaxLength(150);

                entity.Property(e => e.USEEMAIL)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.VIRTUAL_POS_PAYMENT_REQUESTSADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REQVIRTUAL_P__ADDUS__29A20B3F");

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.VIRTUAL_POS_PAYMENT_REQUESTS)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REQVIRTUAL_P__CORPI__22F50DB0");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.VIRTUAL_POS_PAYMENT_REQUESTSEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__REQVIRTUAL_P__EDITU__2B8A53B1");

                entity.HasOne(d => d.EMAILTEMP)
                    .WithMany(p => p.VIRTUAL_POS_PAYMENT_REQUESTSEMAILTEMP)
                    .HasForeignKey(d => d.EMAILTEMPID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__REQVIRTUAL_P__EMAIL__27B9C2CD");

                entity.HasOne(d => d.PAYMENTTEMP)
                    .WithMany(p => p.VIRTUAL_POS_PAYMENT_REQUESTS)
                    .HasForeignKey(d => d.PAYMENTTEMPID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_VIRTUAL_POS_PAYMENT_REQUESTS_VIRTUAL_POS_PAYMENT_TEMPS");

                entity.HasOne(d => d.PORTALU)
                    .WithMany(p => p.VIRTUAL_POS_PAYMENT_REQUESTS)
                    .HasPrincipalKey(p => p.UID)
                    .HasForeignKey(d => d.PORTALUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VIRTUAL_POS_PAYMENT_REQUESTS_PORTAL");

                entity.HasOne(d => d.SMSTEMP)
                    .WithMany(p => p.VIRTUAL_POS_PAYMENT_REQUESTSSMSTEMP)
                    .HasForeignKey(d => d.SMSTEMPID)
                    .HasConstraintName("FK__REQVIRTUAL_P__SMSTE__28ADE706");
            });

            modelBuilder.Entity<dbo.VIRTUAL_POS_PAYMENT_REQUESTS_NOTES>(entity =>
            {
                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.VIRTUAL_POS_PAYMENT_REQUESTS_NOTESADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__POS___REQUEST_N__ADDUS__78BEDCC2");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.VIRTUAL_POS_PAYMENT_REQUESTS_NOTESEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK_pos_VIRTUAL_POS_PAYMENT_REQUESTS_NOTES_USERS");

                entity.HasOne(d => d.PAYMENT)
                    .WithMany(p => p.VIRTUAL_POS_PAYMENT_REQUESTS_NOTES)
                    .HasForeignKey(d => d.PAYMENTID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VIRTUAL_POS_PAYMENT_REQUESTS_NOTES_VIRTUAL_POS_PAYMENT_REQUESTS");
            });

            modelBuilder.Entity<dbo.VIRTUAL_POS_PAYMENT_TEMPS>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__VIRTUAL___3214EC2615C97ABF")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CANDIV_PAYMENT).HasDefaultValueSql("((0))");

                entity.Property(e => e.CURCODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DESCRIPTION).HasMaxLength(150);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.LANGCODE)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PIECE).HasDefaultValueSql("((1))");

                entity.Property(e => e.RESNUMBER).HasMaxLength(50);

                entity.Property(e => e.TITLE).HasMaxLength(150);

                entity.Property(e => e.USEEMAIL)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.VIRTUAL_POS_PAYMENT_TEMPSADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__ADDUS__29A20B3F");

                entity.HasOne(d => d.CORP)
                    .WithMany(p => p.VIRTUAL_POS_PAYMENT_TEMPS)
                    .HasForeignKey(d => d.CORPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__CORPI__22F50DB0");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.VIRTUAL_POS_PAYMENT_TEMPSEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__VIRTUAL_P__EDITU__2B8A53B1");

                entity.HasOne(d => d.EMAILTEMP)
                    .WithMany(p => p.VIRTUAL_POS_PAYMENT_TEMPSEMAILTEMP)
                    .HasForeignKey(d => d.EMAILTEMPID)
                    .HasConstraintName("FK__VIRTUAL_P__EMAIL__27B9C2CD");

                entity.HasOne(d => d.LANGCODENavigation)
                    .WithMany(p => p.VIRTUAL_POS_PAYMENT_TEMPS)
                    .HasForeignKey(d => d.LANGCODE)
                    .HasConstraintName("FK_VIRTUAL_POS_PAYMENT_TEMPS_STDLANGUAGES");

                entity.HasOne(d => d.SMSTEMP)
                    .WithMany(p => p.VIRTUAL_POS_PAYMENT_TEMPSSMSTEMP)
                    .HasForeignKey(d => d.SMSTEMPID)
                    .HasConstraintName("FK__VIRTUAL_P__SMSTE__28ADE706");
            });

            modelBuilder.Entity<dbo.VIRTUAL_POS_PAYMENT_VPOSES>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PK__VIRTUAL___3214EC266D8BF4C0")
                    .IsClustered(false);

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ADDDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.HasOne(d => d.ADDUSERNavigation)
                    .WithMany(p => p.VIRTUAL_POS_PAYMENT_VPOSESADDUSERNavigation)
                    .HasForeignKey(d => d.ADDUSER)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__ADDUS__3BC0BB7A");

                entity.HasOne(d => d.EDITUSERNavigation)
                    .WithMany(p => p.VIRTUAL_POS_PAYMENT_VPOSESEDITUSERNavigation)
                    .HasForeignKey(d => d.EDITUSER)
                    .HasConstraintName("FK__VIRTUAL_P__EDITU__3DA903EC");

                entity.HasOne(d => d.INSTALLMENT)
                    .WithMany(p => p.VIRTUAL_POS_PAYMENT_VPOSES)
                    .HasForeignKey(d => d.INSTALLMENTID)
                    .HasConstraintName("FK_VIRTUAL_POS_PAYMENT_VPOSES_VIRTUAL_POS_ACCOUNT_INSTALMENTS");

                entity.HasOne(d => d.PAYMENT)
                    .WithMany(p => p.VIRTUAL_POS_PAYMENT_VPOSES)
                    .HasForeignKey(d => d.PAYMENTID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_VIRTUAL_POS_PAYMENT_VPOSES_VIRTUAL_POS_PAYMENT_REQUESTS");

                entity.HasOne(d => d.TEMP)
                    .WithMany(p => p.VIRTUAL_POS_PAYMENT_VPOSES)
                    .HasForeignKey(d => d.TEMPID)
                    .HasConstraintName("FK__VIRTUAL_P__TEMPI__38E44ECF");
            });

            modelBuilder.Entity<dbo.VIRTUAL_POS_SWAP>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.POSID1Navigation)
                    .WithMany()
                    .HasForeignKey(d => d.POSID1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__POSID__38F95D68");

                entity.HasOne(d => d.POSID2Navigation)
                    .WithMany()
                    .HasForeignKey(d => d.POSID2)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIRTUAL_P__POSID__39ED81A1");
            });

            modelBuilder.Entity<dbo.VW_BASKET_INFO>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_BASKET_INFO");

                entity.Property(e => e.BOARDTYPE).HasMaxLength(25);

                entity.Property(e => e.CHECKINTIME).HasColumnType("datetime");

                entity.Property(e => e.CHECKOUTTIME).HasColumnType("datetime");

                entity.Property(e => e.CITY).HasMaxLength(70);

                entity.Property(e => e.COUNTRY).HasMaxLength(70);

                entity.Property(e => e.CURCODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DATE1).HasColumnType("datetime");

                entity.Property(e => e.DATE2).HasColumnType("datetime");

                entity.Property(e => e.FROMLOC).HasMaxLength(170);

                entity.Property(e => e.PNR1).HasMaxLength(15);

                entity.Property(e => e.PNR2).HasMaxLength(15);

                entity.Property(e => e.PRODUCTNAME).HasMaxLength(200);

                entity.Property(e => e.PROMOTION).HasMaxLength(150);

                entity.Property(e => e.PROMOTIONCODE).HasMaxLength(255);

                entity.Property(e => e.RATETYPE).HasMaxLength(50);

                entity.Property(e => e.REQ_CURCODE)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ROOMTYPE).HasMaxLength(50);

                entity.Property(e => e.SPECIAL_CODE).HasMaxLength(15);

                entity.Property(e => e.THUMBNAILURL).HasMaxLength(350);

                entity.Property(e => e.TOLOC).HasMaxLength(170);

                entity.Property(e => e.VALIDDATE).HasColumnType("datetime");

                entity.Property(e => e.VEHICLE).HasMaxLength(70);

                entity.Property(e => e.VEHICLETYPE).HasMaxLength(40);
            });

            modelBuilder.Entity<dbo.VW_BASKET_PAYMENTS>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_BASKET_PAYMENTS");

                entity.Property(e => e.ACCOUNTNAME).HasMaxLength(50);

                entity.Property(e => e.ADDDATE).HasColumnType("datetime");

                entity.Property(e => e.AUTHCODE).HasMaxLength(200);

                entity.Property(e => e.CARDNO).HasMaxLength(24);

                entity.Property(e => e.CCURCODE)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CURCODE)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DESCRIPTION).HasMaxLength(200);

                entity.Property(e => e.ENDTIME).HasColumnType("datetime");

                entity.Property(e => e.POS).HasMaxLength(150);

                entity.Property(e => e.RETREFNUMBER).HasMaxLength(200);

                entity.Property(e => e.STORETYPE).HasMaxLength(30);

                entity.Property(e => e.TERMINALID).HasMaxLength(50);

                entity.Property(e => e.TRANTYPE).HasMaxLength(15);
            });

            modelBuilder.Entity<dbo.VW_CALLJOB_REASONS>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_CALLJOB_REASONS");

                entity.Property(e => e.REASON)
                    .HasMaxLength(33)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<dbo.VW_CALL_JOBS>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_CALL_JOBS");

                entity.Property(e => e.CALLTIME).HasColumnType("datetime");

                entity.Property(e => e.CAMPAIGNCODE)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.FIRSTNAME).HasMaxLength(70);

                entity.Property(e => e.FULLNAME).HasMaxLength(200);

                entity.Property(e => e.KIND)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LASTNAME).HasMaxLength(70);

                entity.Property(e => e.OUTPUT_EXTEN).HasMaxLength(150);

                entity.Property(e => e.PHONENUMBER).HasMaxLength(50);

                entity.Property(e => e.REASON)
                    .HasMaxLength(33)
                    .IsUnicode(false);

                entity.Property(e => e.SDATE).HasColumnType("datetime");

                entity.Property(e => e.SORTFLD).HasColumnType("datetime");

                entity.Property(e => e.STATE).HasMaxLength(25);

                entity.Property(e => e.USERNAME).HasMaxLength(100);
            });

            modelBuilder.Entity<dbo.VW_CAMPAIGNS>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_CAMPAIGNS");

                entity.Property(e => e.ADDDATE).HasColumnType("datetime");

                entity.Property(e => e.CODE).HasMaxLength(100);

                entity.Property(e => e.DESCRIPTION).HasMaxLength(100);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.ENDDATE).HasColumnType("datetime");

                entity.Property(e => e.STARTDATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<dbo.VW_HOTEL_MARKET_COUNTRY>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_HOTEL_MARKET_COUNTRY");

                entity.Property(e => e.COUNTRYCODE).HasMaxLength(2);
            });

            modelBuilder.Entity<dbo.VW_IPCOUNTRYCODES>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_IPCOUNTRYCODES");

                entity.Property(e => e.country_code).HasMaxLength(2);

                entity.Property(e => e.country_name).HasMaxLength(64);
            });

            modelBuilder.Entity<dbo.VW_IPLOCATIONS>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_IPLOCATIONS");

                entity.Property(e => e.city_name).HasMaxLength(128);

                entity.Property(e => e.country_code).HasMaxLength(2);

                entity.Property(e => e.country_name).HasMaxLength(64);

                entity.Property(e => e.region_name).HasMaxLength(128);
            });

            modelBuilder.Entity<dbo.VW_LOCATIONS>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_LOCATIONS");

                entity.Property(e => e.CODE).HasMaxLength(5);

                entity.Property(e => e.DEFINITION).HasMaxLength(170);

                entity.Property(e => e.TYPE)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<dbo.VW_MOB_PAYMENT_REPORT>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_MOB_PAYMENT_REPORT");

                entity.Property(e => e.AUTHCODE).HasMaxLength(200);

                entity.Property(e => e.CURCODE)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DESCRIPTION).HasMaxLength(200);

                entity.Property(e => e.ENDTIME).HasColumnType("datetime");

                entity.Property(e => e.PAYTYPE)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.PERSONNAME).HasMaxLength(212);

                entity.Property(e => e.POS).HasMaxLength(150);

                entity.Property(e => e.PRODUCTNAME).HasMaxLength(150);

                entity.Property(e => e.PROJECTGROUP).HasMaxLength(150);

                entity.Property(e => e.PROJECT_GROUPDETAIL).HasMaxLength(200);

                entity.Property(e => e.RCURCODE)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RESIDS).HasMaxLength(100);

                entity.Property(e => e.STATU).HasMaxLength(200);

                entity.Property(e => e.SUBSTATU).HasMaxLength(200);
            });

            modelBuilder.Entity<dbo.VW_PRODUCTS>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_PRODUCTS");

                entity.Property(e => e.NAME).HasMaxLength(250);

                entity.Property(e => e.TYPE)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<dbo.VW_PROJECT_GROUP>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_PROJECT_GROUP");

                entity.Property(e => e.ADDDATE).HasColumnType("datetime");

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.NAME).HasMaxLength(150);
            });

            modelBuilder.Entity<dbo.VW_PROMOTION_CODES>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_PROMOTION_CODES");

                entity.Property(e => e.ADDDATE).HasColumnType("datetime");

                entity.Property(e => e.CODE).HasMaxLength(255);

                entity.Property(e => e.DEFINITION).HasMaxLength(150);

                entity.Property(e => e.DISCOUNTKIND)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DISCOUNTTYPE)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EDITDATE).HasColumnType("datetime");

                entity.Property(e => e.KIND)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.SELLFROM).HasColumnType("datetime");

                entity.Property(e => e.SELLTO).HasColumnType("datetime");

                entity.Property(e => e.STAYFROM).HasColumnType("datetime");

                entity.Property(e => e.STAYTO).HasColumnType("datetime");

                entity.Property(e => e.USETYPE)
                    .HasMaxLength(11)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<dbo.VW_REQUEST_PAYMENTS>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_REQUEST_PAYMENTS");

                entity.Property(e => e.ADDDATE).HasColumnType("datetime");

                entity.Property(e => e.CARDNO).HasMaxLength(250);

                entity.Property(e => e.CURCODE)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DESCRIPTION).HasMaxLength(200);

                entity.Property(e => e.ENDTIME).HasColumnType("datetime");

                entity.Property(e => e.FULLNAME).HasMaxLength(201);

                entity.Property(e => e.POS).HasMaxLength(150);

                entity.Property(e => e.STATUSTEXT).HasMaxLength(500);

                entity.Property(e => e.STORETYPE).HasMaxLength(30);

                entity.Property(e => e.TRANTYPE).HasMaxLength(15);
            });

            modelBuilder.Entity<dbo.VW_REQUEST_PAYMENT_CANCELS>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_REQUEST_PAYMENT_CANCELS");

                entity.Property(e => e.ADDDATE).HasColumnType("datetime");

                entity.Property(e => e.CURCODE)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<dbo.VW_SALES>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_SALES");

                entity.Property(e => e.COUNTRY).HasMaxLength(70);

                entity.Property(e => e.CURCODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DATE1).HasColumnType("datetime");

                entity.Property(e => e.DATE2).HasColumnType("datetime");

                entity.Property(e => e.DIRECT_BRANDING).HasMaxLength(15);

                entity.Property(e => e.MARKET).HasMaxLength(50);

                entity.Property(e => e.PERSONNAME).HasMaxLength(212);

                entity.Property(e => e.PRODUCTNAME).HasMaxLength(250);

                entity.Property(e => e.PRODUCTTYPE)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RDADDATE).HasColumnType("date");

                entity.Property(e => e.REQADDATE).HasColumnType("date");

                entity.Property(e => e.SELL_DATE).HasColumnType("date");

                entity.Property(e => e.STATUS).HasMaxLength(200);

                entity.Property(e => e.SUBPRODUCT).HasMaxLength(50);

                entity.Property(e => e.SUBSTATUS).HasMaxLength(200);

                entity.Property(e => e.USERNAME).HasMaxLength(100);
            });

            modelBuilder.Entity<dbo.VW_SALES_ALL>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_SALES_ALL");

                entity.Property(e => e.BOARDTYPE).HasMaxLength(25);

                entity.Property(e => e.COST).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.CURCODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DATE1).HasColumnType("datetime");

                entity.Property(e => e.DATE2).HasColumnType("datetime");

                entity.Property(e => e.DIRECT_BRANDING).HasMaxLength(15);

                entity.Property(e => e.MARKET).HasMaxLength(50);

                entity.Property(e => e.NATIONAL).HasMaxLength(70);

                entity.Property(e => e.PERSONNAME).HasMaxLength(212);

                entity.Property(e => e.PRODUCTNAME).HasMaxLength(250);

                entity.Property(e => e.PRODUCTTYPE)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RESID).HasMaxLength(22);

                entity.Property(e => e.RESOURCECODE).HasMaxLength(30);

                entity.Property(e => e.RESOURCENAME).HasMaxLength(150);

                entity.Property(e => e.ROOMTYPE).HasMaxLength(50);

                entity.Property(e => e.STATUS).HasMaxLength(200);

                entity.Property(e => e.SUBSTATUS).HasMaxLength(200);

                entity.Property(e => e.TDATE).HasColumnType("datetime");

                entity.Property(e => e.USERNAME).HasMaxLength(100);
            });

            modelBuilder.Entity<dbo.VW_SALES_REPORT>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_SALES_REPORT");

                entity.Property(e => e.COUNTRY).HasMaxLength(70);

                entity.Property(e => e.CURCODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DATE).HasColumnType("date");

                entity.Property(e => e.DIRECT_BRANDING).HasMaxLength(15);

                entity.Property(e => e.MARKET).HasMaxLength(50);

                entity.Property(e => e.PRODUCTNAME).HasMaxLength(250);

                entity.Property(e => e.PRODUCTTYPE)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS).HasMaxLength(200);

                entity.Property(e => e.SUBPRODUCT).HasMaxLength(50);

                entity.Property(e => e.SUBSTATUS).HasMaxLength(200);

                entity.Property(e => e.USERNAME).HasMaxLength(100);
            });

            modelBuilder.Entity<dbo.VW_SALES_REPORT_ALL>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_SALES_REPORT_ALL");

                entity.Property(e => e.COST).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.CURCODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DATE).HasColumnType("date");

                entity.Property(e => e.DIRECT_BRANDING).HasMaxLength(15);

                entity.Property(e => e.PRODUCTNAME).HasMaxLength(200);

                entity.Property(e => e.PRODUCTTYPE)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS).HasMaxLength(200);

                entity.Property(e => e.SUBSTATUS).HasMaxLength(200);

                entity.Property(e => e.USERNAME).HasMaxLength(100);
            });

            modelBuilder.Entity<dbo.VW_SALES_REPORT_WITH_RESOURCEPATH>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_SALES_REPORT_WITH_RESOURCEPATH");

                entity.Property(e => e.CODE).HasMaxLength(30);

                entity.Property(e => e.COUNTRY).HasMaxLength(70);

                entity.Property(e => e.CURCODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DATE).HasColumnType("date");

                entity.Property(e => e.DIRECT_BRANDING).HasMaxLength(15);

                entity.Property(e => e.MARKET).HasMaxLength(50);

                entity.Property(e => e.PRODUCTNAME).HasMaxLength(250);

                entity.Property(e => e.PRODUCTTYPE)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RESOURCE_PATH).HasMaxLength(500);

                entity.Property(e => e.STATUS).HasMaxLength(200);

                entity.Property(e => e.SUBPRODUCT).HasMaxLength(50);

                entity.Property(e => e.SUBSTATUS).HasMaxLength(200);

                entity.Property(e => e.USERNAME).HasMaxLength(100);
            });

            modelBuilder.Entity<dbo.VW_STDHOTEL_DISCOUNT_TYPES>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_STDHOTEL_DISCOUNT_TYPES");

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(13)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<dbo.VW_STDHOTEL_RATECODE_DISCOUNT_DISCOUNT>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_STDHOTEL_RATECODE_DISCOUNT_DISCOUNT");

                entity.Property(e => e.ID).ValueGeneratedOnAdd();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
