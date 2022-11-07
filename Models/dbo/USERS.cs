using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class USERS : EntityBase // My Handlebars Helper
    {
        public USERS()
        {
            AGENCYADDUSERNavigation = new HashSet<AGENCY>();
            AGENCYEDITUSERNavigation = new HashSet<AGENCY>();
            AGENCY_GROUPADDUSERNavigation = new HashSet<AGENCY_GROUP>();
            AGENCY_GROUPEDITUSERNavigation = new HashSet<AGENCY_GROUP>();
            BONUS_DEFADDUSERNavigation = new HashSet<BONUS_DEF>();
            BONUS_DEFEDITUSERNavigation = new HashSet<BONUS_DEF>();
            BONUS_DEF_ITEMSADDUSERNavigation = new HashSet<BONUS_DEF_ITEMS>();
            BONUS_DEF_ITEMSEDITUSERNavigation = new HashSet<BONUS_DEF_ITEMS>();
            BONUS_DEF_PRICESADDUSERNavigation = new HashSet<BONUS_DEF_PRICES>();
            BONUS_DEF_PRICESEDITUSERNavigation = new HashSet<BONUS_DEF_PRICES>();
            BONUS_DEF_USERS = new HashSet<BONUS_DEF_USERS>();
            CALL_JOBSADDUSERNavigation = new HashSet<CALL_JOBS>();
            CALL_JOBSEDITUSERNavigation = new HashSet<CALL_JOBS>();
            CALL_JOBSUSER = new HashSet<CALL_JOBS>();
            CAMPAIGNSADDUSERNavigation = new HashSet<CAMPAIGNS>();
            CAMPAIGNSEDITUSERNavigation = new HashSet<CAMPAIGNS>();
            CASHIER_HANDOVERADDUSERNavigation = new HashSet<CASHIER_HANDOVER>();
            CASHIER_HANDOVEREDITUSERNavigation = new HashSet<CASHIER_HANDOVER>();
            CASHIER_HANDOVERUSER = new HashSet<CASHIER_HANDOVER>();
            CONTACT_FORMADDUSERNavigation = new HashSet<CONTACT_FORM>();
            CONTACT_FORMEDITUSERNavigation = new HashSet<CONTACT_FORM>();
            CORPADDUSERNavigation = new HashSet<CORP>();
            CORPEDITUSERNavigation = new HashSet<CORP>();
            CRM_CARDGROUPSADDUSERNavigation = new HashSet<CRM_CARDGROUPS>();
            CRM_CARDGROUPSEDITUSERNavigation = new HashSet<CRM_CARDGROUPS>();
            CRM_CARDTYPESADDUSERNavigation = new HashSet<CRM_CARDTYPES>();
            CRM_CARDTYPESEDITUSERNavigation = new HashSet<CRM_CARDTYPES>();
            HOTEL_RESERVATIONSADDUSERNavigation = new HashSet<HOTEL_RESERVATIONS>();
            HOTEL_RESERVATIONSEDITUSERNavigation = new HashSet<HOTEL_RESERVATIONS>();
            InverseADDUSERNavigation = new HashSet<USERS>();
            InverseEDITUSERNavigation = new HashSet<USERS>();
            LOCATION_ADDRESSADDUSERNavigation = new HashSet<LOCATION_ADDRESS>();
            LOCATION_ADDRESSEDITUSERNavigation = new HashSet<LOCATION_ADDRESS>();
            PAYMENTSADDUSERNavigation = new HashSet<PAYMENTS>();
            PAYMENTSEDITUSERNavigation = new HashSet<PAYMENTS>();
            PERSONADDUSERNavigation = new HashSet<PERSON>();
            PERSONEDITUSERNavigation = new HashSet<PERSON>();
            PERSON_BONUSADDUSERNavigation = new HashSet<PERSON_BONUS>();
            PERSON_BONUSEDITUSERNavigation = new HashSet<PERSON_BONUS>();
            PERSON_BONUS_TYPESADDUSERNavigation = new HashSet<PERSON_BONUS_TYPES>();
            PERSON_BONUS_TYPESEDITUSERNavigation = new HashSet<PERSON_BONUS_TYPES>();
            PERSON_GROUPADDUSERNavigation = new HashSet<PERSON_GROUP>();
            PERSON_GROUPEDITUSERNavigation = new HashSet<PERSON_GROUP>();
            PORTAL_CATEGORIESADDUSERNavigation = new HashSet<PORTAL_CATEGORIES>();
            PORTAL_CATEGORIESEDITUSERNavigation = new HashSet<PORTAL_CATEGORIES>();
            PORTAL_CATEGORY_IMAGESADDUSERNavigation = new HashSet<PORTAL_CATEGORY_IMAGES>();
            PORTAL_CATEGORY_IMAGESEDITUSERNavigation = new HashSet<PORTAL_CATEGORY_IMAGES>();
            PORTAL_CATEGORY_ITEMSADDUSERNavigation = new HashSet<PORTAL_CATEGORY_ITEMS>();
            PORTAL_CATEGORY_ITEMSEDITUSERNavigation = new HashSet<PORTAL_CATEGORY_ITEMS>();
            PORTAL_DOMAINSADDUSERNavigation = new HashSet<PORTAL_DOMAINS>();
            PORTAL_DOMAINSEDITUSERNavigation = new HashSet<PORTAL_DOMAINS>();
            PORTAL_SEOADDUSERNavigation = new HashSet<PORTAL_SEO>();
            PORTAL_SEOEDITUSERNavigation = new HashSet<PORTAL_SEO>();
            PROJECT_GROUPADDUSERNavigation = new HashSet<PROJECT_GROUP>();
            PROJECT_GROUPEDITUSERNavigation = new HashSet<PROJECT_GROUP>();
            PROMOTION_CODESADDUSERNavigation = new HashSet<PROMOTION_CODES>();
            PROMOTION_CODESEDITUSERNavigation = new HashSet<PROMOTION_CODES>();
            REQUESTADDUSERNavigation = new HashSet<REQUEST>();
            REQUESTSELLER_USER = new HashSet<REQUEST>();
            REQUEST_DETAILADDUSERNavigation = new HashSet<REQUEST_DETAIL>();
            REQUEST_DETAILCANCELLATION_USER = new HashSet<REQUEST_DETAIL>();
            REQUEST_DETAILEDITUSERNavigation = new HashSet<REQUEST_DETAIL>();
            REQUEST_DETAILSELLER_USER = new HashSet<REQUEST_DETAIL>();
            REQUEST_NOTESADDUSERNavigation = new HashSet<REQUEST_NOTES>();
            REQUEST_NOTESEDITUSERNavigation = new HashSet<REQUEST_NOTES>();
            RESERVATION_SETTINGS = new HashSet<RESERVATION_SETTINGS>();
            RESOURCESADDUSERNavigation = new HashSet<RESOURCES>();
            RESOURCESEDITUSERNavigation = new HashSet<RESOURCES>();
            RESOURCE_DETAILADDUSERNavigation = new HashSet<RESOURCE_DETAIL>();
            RESOURCE_DETAILEDITUSERNavigation = new HashSet<RESOURCE_DETAIL>();
            ROLESADDUSERNavigation = new HashSet<ROLES>();
            ROLESEDITUSERNavigation = new HashSet<ROLES>();
            SALES_REQADDUSERNavigation = new HashSet<SALES_REQ>();
            SALES_REQEDITUSERNavigation = new HashSet<SALES_REQ>();
            SMS_SETTINGSADDUSERNavigation = new HashSet<SMS_SETTINGS>();
            SMS_SETTINGSEDITUSERNavigation = new HashSet<SMS_SETTINGS>();
            SMTP_SETTINGSADDUSERNavigation = new HashSet<SMTP_SETTINGS>();
            SMTP_SETTINGSEDITUSERNavigation = new HashSet<SMTP_SETTINGS>();
            STDHOTELADDUSERNavigation = new HashSet<STDHOTEL>();
            STDHOTELEDITUSERNavigation = new HashSet<STDHOTEL>();
            STDHOTEL_ANNOUNCEMENTADDUSERNavigation = new HashSet<STDHOTEL_ANNOUNCEMENT>();
            STDHOTEL_ANNOUNCEMENTEDITUSERNavigation = new HashSet<STDHOTEL_ANNOUNCEMENT>();
            STDHOTEL_RATECODEADDUSERNavigation = new HashSet<STDHOTEL_RATECODE>();
            STDHOTEL_RATECODEEDITUSERNavigation = new HashSet<STDHOTEL_RATECODE>();
            STDHOTEL_RATECODE_DETAIL_AGENCYGROUPSADDUSERNavigation = new HashSet<STDHOTEL_RATECODE_DETAIL_AGENCYGROUPS>();
            STDHOTEL_RATECODE_DETAIL_AGENCYGROUPSEDITUSERNavigation = new HashSet<STDHOTEL_RATECODE_DETAIL_AGENCYGROUPS>();
            STDHOTEL_RATECODE_MARKUPADDUSERNavigation = new HashSet<STDHOTEL_RATECODE_MARKUP>();
            STDHOTEL_RATECODE_MARKUPEDITUSERNavigation = new HashSet<STDHOTEL_RATECODE_MARKUP>();
            STDHOTEL_ROOMTYPESADDUSERNavigation = new HashSet<STDHOTEL_ROOMTYPES>();
            STDHOTEL_ROOMTYPESEDITUSERNavigation = new HashSet<STDHOTEL_ROOMTYPES>();
            STDSTOREADDUSERNavigation = new HashSet<STDSTORE>();
            STDSTOREEDITUSERNavigation = new HashSet<STDSTORE>();
            STDSTORE_ITEM_GROUPSADDUSERNavigation = new HashSet<STDSTORE_ITEM_GROUPS>();
            STDSTORE_ITEM_GROUPSEDITUSERNavigation = new HashSet<STDSTORE_ITEM_GROUPS>();
            STDSTORE_ITEM_GROUP_ITEMSADDUSERNavigation = new HashSet<STDSTORE_ITEM_GROUP_ITEMS>();
            STDSTORE_ITEM_GROUP_ITEMSEDITUSERNavigation = new HashSet<STDSTORE_ITEM_GROUP_ITEMS>();
            STDSTORE_ITEM_INGREDIENTS = new HashSet<STDSTORE_ITEM_INGREDIENTS>();
            STDSTORE_ITEM_PRICES = new HashSet<STDSTORE_ITEM_PRICES>();
            STDSTORE_ITEM_PRICES_INGREDIENTS = new HashSet<STDSTORE_ITEM_PRICES_INGREDIENTS>();
            SURVEYADDUSERNavigation = new HashSet<SURVEY>();
            SURVEYEDITUSERNavigation = new HashSet<SURVEY>();
            SURVEYSADDUSERNavigation = new HashSet<SURVEYS>();
            SURVEYSEDITUSERNavigation = new HashSet<SURVEYS>();
            TICKETADDUSERNavigation = new HashSet<TICKET>();
            TICKETEDITUSERNavigation = new HashSet<TICKET>();
            TICKET_HOURSADDUSERNavigation = new HashSet<TICKET_HOURS>();
            TICKET_HOURSEDITUSERNavigation = new HashSet<TICKET_HOURS>();
            TICKET_MARKETADDUSERNavigation = new HashSet<TICKET_MARKET>();
            TICKET_MARKETEDITUSERNavigation = new HashSet<TICKET_MARKET>();
            TICKET_PRICESADDUSERNavigation = new HashSet<TICKET_PRICES>();
            TICKET_PRICESEDITUSERNavigation = new HashSet<TICKET_PRICES>();
            TOURADDUSERNavigation = new HashSet<TOUR>();
            TOUREDITUSERNavigation = new HashSet<TOUR>();
            TOUR_DISCOUNTSADDUSERNavigation = new HashSet<TOUR_DISCOUNTS>();
            TOUR_DISCOUNTSEDITUSERNavigation = new HashSet<TOUR_DISCOUNTS>();
            TOUR_PRICESADDUSERNavigation = new HashSet<TOUR_PRICES>();
            TOUR_PRICESEDITUSERNavigation = new HashSet<TOUR_PRICES>();
            TOUR_PROGRAMADDUSERNavigation = new HashSet<TOUR_PROGRAM>();
            TOUR_PROGRAMEDITUSERNavigation = new HashSet<TOUR_PROGRAM>();
            TRANSFER_LOCATIONSADDUSERNavigation = new HashSet<TRANSFER_LOCATIONS>();
            TRANSFER_LOCATIONSEDITUSERNavigation = new HashSet<TRANSFER_LOCATIONS>();
            TRANSFER_PRICESADDUSERNavigation = new HashSet<TRANSFER_PRICES>();
            TRANSFER_PRICESEDITUSERNavigation = new HashSet<TRANSFER_PRICES>();
            TRANSFER_PROVIDERSADDUSERNavigation = new HashSet<TRANSFER_PROVIDERS>();
            TRANSFER_PROVIDERSEDITUSERNavigation = new HashSet<TRANSFER_PROVIDERS>();
            USERS_CUSTOMAUTH = new HashSet<USERS_CUSTOMAUTH>();
            USER_HISTORY = new HashSet<USER_HISTORY>();
            USER_ROLES = new HashSet<USER_ROLES>();
            VEHICLETYPESADDUSERNavigation = new HashSet<VEHICLETYPES>();
            VEHICLETYPESEDITUSERNavigation = new HashSet<VEHICLETYPES>();
            VIRTUAL_POS_ACCOUNTSADDUSERNavigation = new HashSet<VIRTUAL_POS_ACCOUNTS>();
            VIRTUAL_POS_ACCOUNTSEDITUSERNavigation = new HashSet<VIRTUAL_POS_ACCOUNTS>();
            VIRTUAL_POS_ACCOUNT_INSTALMENTSADDUSERNavigation = new HashSet<VIRTUAL_POS_ACCOUNT_INSTALMENTS>();
            VIRTUAL_POS_ACCOUNT_INSTALMENTSEDITUSERNavigation = new HashSet<VIRTUAL_POS_ACCOUNT_INSTALMENTS>();
            VIRTUAL_POS_DEFAULTSADDUSERNavigation = new HashSet<VIRTUAL_POS_DEFAULTS>();
            VIRTUAL_POS_DEFAULTSEDITUSERNavigation = new HashSet<VIRTUAL_POS_DEFAULTS>();
            VIRTUAL_POS_DEP_PAYMENTSADDUSERNavigation = new HashSet<VIRTUAL_POS_DEP_PAYMENTS>();
            VIRTUAL_POS_DEP_PAYMENTSEDITUSERNavigation = new HashSet<VIRTUAL_POS_DEP_PAYMENTS>();
            VIRTUAL_POS_DEP_PAYMENTS_CANCELADDUSERNavigation = new HashSet<VIRTUAL_POS_DEP_PAYMENTS_CANCEL>();
            VIRTUAL_POS_DEP_PAYMENTS_CANCELEDITUSERNavigation = new HashSet<VIRTUAL_POS_DEP_PAYMENTS_CANCEL>();
            VIRTUAL_POS_PAYMENTSADDUSERNavigation = new HashSet<VIRTUAL_POS_PAYMENTS>();
            VIRTUAL_POS_PAYMENTSEDITUSERNavigation = new HashSet<VIRTUAL_POS_PAYMENTS>();
            VIRTUAL_POS_PAYMENT_EMAILSADDUSERNavigation = new HashSet<VIRTUAL_POS_PAYMENT_EMAILS>();
            VIRTUAL_POS_PAYMENT_EMAILSEDITUSERNavigation = new HashSet<VIRTUAL_POS_PAYMENT_EMAILS>();
            VIRTUAL_POS_PAYMENT_MESSAGE_TEMPSADDUSERNavigation = new HashSet<VIRTUAL_POS_PAYMENT_MESSAGE_TEMPS>();
            VIRTUAL_POS_PAYMENT_MESSAGE_TEMPSEDITUSERNavigation = new HashSet<VIRTUAL_POS_PAYMENT_MESSAGE_TEMPS>();
            VIRTUAL_POS_PAYMENT_REQUESTSADDUSERNavigation = new HashSet<VIRTUAL_POS_PAYMENT_REQUESTS>();
            VIRTUAL_POS_PAYMENT_REQUESTSEDITUSERNavigation = new HashSet<VIRTUAL_POS_PAYMENT_REQUESTS>();
            VIRTUAL_POS_PAYMENT_REQUESTS_NOTESADDUSERNavigation = new HashSet<VIRTUAL_POS_PAYMENT_REQUESTS_NOTES>();
            VIRTUAL_POS_PAYMENT_REQUESTS_NOTESEDITUSERNavigation = new HashSet<VIRTUAL_POS_PAYMENT_REQUESTS_NOTES>();
            VIRTUAL_POS_PAYMENT_TEMPSADDUSERNavigation = new HashSet<VIRTUAL_POS_PAYMENT_TEMPS>();
            VIRTUAL_POS_PAYMENT_TEMPSEDITUSERNavigation = new HashSet<VIRTUAL_POS_PAYMENT_TEMPS>();
            VIRTUAL_POS_PAYMENT_VPOSESADDUSERNavigation = new HashSet<VIRTUAL_POS_PAYMENT_VPOSES>();
            VIRTUAL_POS_PAYMENT_VPOSESEDITUSERNavigation = new HashSet<VIRTUAL_POS_PAYMENT_VPOSES>();
        }

        public Guid ID { get; set; }
        public Guid CORPID { get; set; }
        public string USERNAME { get; set; } = null!;
        public string? PASSWORD { get; set; }
        public bool SYSTEMADMIN { get; set; }
        public string FIRSTNAME { get; set; } = null!;
        public string LASTNAME { get; set; } = null!;
        public string FULLNAME { get; set; } = null!;
        public long? TEL1 { get; set; }
        public long? TEL2 { get; set; }
        public string? EMAIL { get; set; }
        public bool ISDELETED { get; set; }
        public bool ISDISABLED { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public bool MUSTCHANGEPASWORD_NEXTLOGON { get; set; }
        public Guid? MODULEID { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual CORP CORP { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual ICollection<AGENCY> AGENCYADDUSERNavigation { get; set; }
        public virtual ICollection<AGENCY> AGENCYEDITUSERNavigation { get; set; }
        public virtual ICollection<AGENCY_GROUP> AGENCY_GROUPADDUSERNavigation { get; set; }
        public virtual ICollection<AGENCY_GROUP> AGENCY_GROUPEDITUSERNavigation { get; set; }
        public virtual ICollection<BONUS_DEF> BONUS_DEFADDUSERNavigation { get; set; }
        public virtual ICollection<BONUS_DEF> BONUS_DEFEDITUSERNavigation { get; set; }
        public virtual ICollection<BONUS_DEF_ITEMS> BONUS_DEF_ITEMSADDUSERNavigation { get; set; }
        public virtual ICollection<BONUS_DEF_ITEMS> BONUS_DEF_ITEMSEDITUSERNavigation { get; set; }
        public virtual ICollection<BONUS_DEF_PRICES> BONUS_DEF_PRICESADDUSERNavigation { get; set; }
        public virtual ICollection<BONUS_DEF_PRICES> BONUS_DEF_PRICESEDITUSERNavigation { get; set; }
        public virtual ICollection<BONUS_DEF_USERS> BONUS_DEF_USERS { get; set; }
        public virtual ICollection<CALL_JOBS> CALL_JOBSADDUSERNavigation { get; set; }
        public virtual ICollection<CALL_JOBS> CALL_JOBSEDITUSERNavigation { get; set; }
        public virtual ICollection<CALL_JOBS> CALL_JOBSUSER { get; set; }
        public virtual ICollection<CAMPAIGNS> CAMPAIGNSADDUSERNavigation { get; set; }
        public virtual ICollection<CAMPAIGNS> CAMPAIGNSEDITUSERNavigation { get; set; }
        public virtual ICollection<CASHIER_HANDOVER> CASHIER_HANDOVERADDUSERNavigation { get; set; }
        public virtual ICollection<CASHIER_HANDOVER> CASHIER_HANDOVEREDITUSERNavigation { get; set; }
        public virtual ICollection<CASHIER_HANDOVER> CASHIER_HANDOVERUSER { get; set; }
        public virtual ICollection<CONTACT_FORM> CONTACT_FORMADDUSERNavigation { get; set; }
        public virtual ICollection<CONTACT_FORM> CONTACT_FORMEDITUSERNavigation { get; set; }
        public virtual ICollection<CORP> CORPADDUSERNavigation { get; set; }
        public virtual ICollection<CORP> CORPEDITUSERNavigation { get; set; }
        public virtual ICollection<CRM_CARDGROUPS> CRM_CARDGROUPSADDUSERNavigation { get; set; }
        public virtual ICollection<CRM_CARDGROUPS> CRM_CARDGROUPSEDITUSERNavigation { get; set; }
        public virtual ICollection<CRM_CARDTYPES> CRM_CARDTYPESADDUSERNavigation { get; set; }
        public virtual ICollection<CRM_CARDTYPES> CRM_CARDTYPESEDITUSERNavigation { get; set; }
        public virtual ICollection<HOTEL_RESERVATIONS> HOTEL_RESERVATIONSADDUSERNavigation { get; set; }
        public virtual ICollection<HOTEL_RESERVATIONS> HOTEL_RESERVATIONSEDITUSERNavigation { get; set; }
        public virtual ICollection<USERS> InverseADDUSERNavigation { get; set; }
        public virtual ICollection<USERS> InverseEDITUSERNavigation { get; set; }
        public virtual ICollection<LOCATION_ADDRESS> LOCATION_ADDRESSADDUSERNavigation { get; set; }
        public virtual ICollection<LOCATION_ADDRESS> LOCATION_ADDRESSEDITUSERNavigation { get; set; }
        public virtual ICollection<PAYMENTS> PAYMENTSADDUSERNavigation { get; set; }
        public virtual ICollection<PAYMENTS> PAYMENTSEDITUSERNavigation { get; set; }
        public virtual ICollection<PERSON> PERSONADDUSERNavigation { get; set; }
        public virtual ICollection<PERSON> PERSONEDITUSERNavigation { get; set; }
        public virtual ICollection<PERSON_BONUS> PERSON_BONUSADDUSERNavigation { get; set; }
        public virtual ICollection<PERSON_BONUS> PERSON_BONUSEDITUSERNavigation { get; set; }
        public virtual ICollection<PERSON_BONUS_TYPES> PERSON_BONUS_TYPESADDUSERNavigation { get; set; }
        public virtual ICollection<PERSON_BONUS_TYPES> PERSON_BONUS_TYPESEDITUSERNavigation { get; set; }
        public virtual ICollection<PERSON_GROUP> PERSON_GROUPADDUSERNavigation { get; set; }
        public virtual ICollection<PERSON_GROUP> PERSON_GROUPEDITUSERNavigation { get; set; }
        public virtual ICollection<PORTAL_CATEGORIES> PORTAL_CATEGORIESADDUSERNavigation { get; set; }
        public virtual ICollection<PORTAL_CATEGORIES> PORTAL_CATEGORIESEDITUSERNavigation { get; set; }
        public virtual ICollection<PORTAL_CATEGORY_IMAGES> PORTAL_CATEGORY_IMAGESADDUSERNavigation { get; set; }
        public virtual ICollection<PORTAL_CATEGORY_IMAGES> PORTAL_CATEGORY_IMAGESEDITUSERNavigation { get; set; }
        public virtual ICollection<PORTAL_CATEGORY_ITEMS> PORTAL_CATEGORY_ITEMSADDUSERNavigation { get; set; }
        public virtual ICollection<PORTAL_CATEGORY_ITEMS> PORTAL_CATEGORY_ITEMSEDITUSERNavigation { get; set; }
        public virtual ICollection<PORTAL_DOMAINS> PORTAL_DOMAINSADDUSERNavigation { get; set; }
        public virtual ICollection<PORTAL_DOMAINS> PORTAL_DOMAINSEDITUSERNavigation { get; set; }
        public virtual ICollection<PORTAL_SEO> PORTAL_SEOADDUSERNavigation { get; set; }
        public virtual ICollection<PORTAL_SEO> PORTAL_SEOEDITUSERNavigation { get; set; }
        public virtual ICollection<PROJECT_GROUP> PROJECT_GROUPADDUSERNavigation { get; set; }
        public virtual ICollection<PROJECT_GROUP> PROJECT_GROUPEDITUSERNavigation { get; set; }
        public virtual ICollection<PROMOTION_CODES> PROMOTION_CODESADDUSERNavigation { get; set; }
        public virtual ICollection<PROMOTION_CODES> PROMOTION_CODESEDITUSERNavigation { get; set; }
        public virtual ICollection<REQUEST> REQUESTADDUSERNavigation { get; set; }
        public virtual ICollection<REQUEST> REQUESTSELLER_USER { get; set; }
        public virtual ICollection<REQUEST_DETAIL> REQUEST_DETAILADDUSERNavigation { get; set; }
        public virtual ICollection<REQUEST_DETAIL> REQUEST_DETAILCANCELLATION_USER { get; set; }
        public virtual ICollection<REQUEST_DETAIL> REQUEST_DETAILEDITUSERNavigation { get; set; }
        public virtual ICollection<REQUEST_DETAIL> REQUEST_DETAILSELLER_USER { get; set; }
        public virtual ICollection<REQUEST_NOTES> REQUEST_NOTESADDUSERNavigation { get; set; }
        public virtual ICollection<REQUEST_NOTES> REQUEST_NOTESEDITUSERNavigation { get; set; }
        public virtual ICollection<RESERVATION_SETTINGS> RESERVATION_SETTINGS { get; set; }
        public virtual ICollection<RESOURCES> RESOURCESADDUSERNavigation { get; set; }
        public virtual ICollection<RESOURCES> RESOURCESEDITUSERNavigation { get; set; }
        public virtual ICollection<RESOURCE_DETAIL> RESOURCE_DETAILADDUSERNavigation { get; set; }
        public virtual ICollection<RESOURCE_DETAIL> RESOURCE_DETAILEDITUSERNavigation { get; set; }
        public virtual ICollection<ROLES> ROLESADDUSERNavigation { get; set; }
        public virtual ICollection<ROLES> ROLESEDITUSERNavigation { get; set; }
        public virtual ICollection<SALES_REQ> SALES_REQADDUSERNavigation { get; set; }
        public virtual ICollection<SALES_REQ> SALES_REQEDITUSERNavigation { get; set; }
        public virtual ICollection<SMS_SETTINGS> SMS_SETTINGSADDUSERNavigation { get; set; }
        public virtual ICollection<SMS_SETTINGS> SMS_SETTINGSEDITUSERNavigation { get; set; }
        public virtual ICollection<SMTP_SETTINGS> SMTP_SETTINGSADDUSERNavigation { get; set; }
        public virtual ICollection<SMTP_SETTINGS> SMTP_SETTINGSEDITUSERNavigation { get; set; }
        public virtual ICollection<STDHOTEL> STDHOTELADDUSERNavigation { get; set; }
        public virtual ICollection<STDHOTEL> STDHOTELEDITUSERNavigation { get; set; }
        public virtual ICollection<STDHOTEL_ANNOUNCEMENT> STDHOTEL_ANNOUNCEMENTADDUSERNavigation { get; set; }
        public virtual ICollection<STDHOTEL_ANNOUNCEMENT> STDHOTEL_ANNOUNCEMENTEDITUSERNavigation { get; set; }
        public virtual ICollection<STDHOTEL_RATECODE> STDHOTEL_RATECODEADDUSERNavigation { get; set; }
        public virtual ICollection<STDHOTEL_RATECODE> STDHOTEL_RATECODEEDITUSERNavigation { get; set; }
        public virtual ICollection<STDHOTEL_RATECODE_DETAIL_AGENCYGROUPS> STDHOTEL_RATECODE_DETAIL_AGENCYGROUPSADDUSERNavigation { get; set; }
        public virtual ICollection<STDHOTEL_RATECODE_DETAIL_AGENCYGROUPS> STDHOTEL_RATECODE_DETAIL_AGENCYGROUPSEDITUSERNavigation { get; set; }
        public virtual ICollection<STDHOTEL_RATECODE_MARKUP> STDHOTEL_RATECODE_MARKUPADDUSERNavigation { get; set; }
        public virtual ICollection<STDHOTEL_RATECODE_MARKUP> STDHOTEL_RATECODE_MARKUPEDITUSERNavigation { get; set; }
        public virtual ICollection<STDHOTEL_ROOMTYPES> STDHOTEL_ROOMTYPESADDUSERNavigation { get; set; }
        public virtual ICollection<STDHOTEL_ROOMTYPES> STDHOTEL_ROOMTYPESEDITUSERNavigation { get; set; }
        public virtual ICollection<STDSTORE> STDSTOREADDUSERNavigation { get; set; }
        public virtual ICollection<STDSTORE> STDSTOREEDITUSERNavigation { get; set; }
        public virtual ICollection<STDSTORE_ITEM_GROUPS> STDSTORE_ITEM_GROUPSADDUSERNavigation { get; set; }
        public virtual ICollection<STDSTORE_ITEM_GROUPS> STDSTORE_ITEM_GROUPSEDITUSERNavigation { get; set; }
        public virtual ICollection<STDSTORE_ITEM_GROUP_ITEMS> STDSTORE_ITEM_GROUP_ITEMSADDUSERNavigation { get; set; }
        public virtual ICollection<STDSTORE_ITEM_GROUP_ITEMS> STDSTORE_ITEM_GROUP_ITEMSEDITUSERNavigation { get; set; }
        public virtual ICollection<STDSTORE_ITEM_INGREDIENTS> STDSTORE_ITEM_INGREDIENTS { get; set; }
        public virtual ICollection<STDSTORE_ITEM_PRICES> STDSTORE_ITEM_PRICES { get; set; }
        public virtual ICollection<STDSTORE_ITEM_PRICES_INGREDIENTS> STDSTORE_ITEM_PRICES_INGREDIENTS { get; set; }
        public virtual ICollection<SURVEY> SURVEYADDUSERNavigation { get; set; }
        public virtual ICollection<SURVEY> SURVEYEDITUSERNavigation { get; set; }
        public virtual ICollection<SURVEYS> SURVEYSADDUSERNavigation { get; set; }
        public virtual ICollection<SURVEYS> SURVEYSEDITUSERNavigation { get; set; }
        public virtual ICollection<TICKET> TICKETADDUSERNavigation { get; set; }
        public virtual ICollection<TICKET> TICKETEDITUSERNavigation { get; set; }
        public virtual ICollection<TICKET_HOURS> TICKET_HOURSADDUSERNavigation { get; set; }
        public virtual ICollection<TICKET_HOURS> TICKET_HOURSEDITUSERNavigation { get; set; }
        public virtual ICollection<TICKET_MARKET> TICKET_MARKETADDUSERNavigation { get; set; }
        public virtual ICollection<TICKET_MARKET> TICKET_MARKETEDITUSERNavigation { get; set; }
        public virtual ICollection<TICKET_PRICES> TICKET_PRICESADDUSERNavigation { get; set; }
        public virtual ICollection<TICKET_PRICES> TICKET_PRICESEDITUSERNavigation { get; set; }
        public virtual ICollection<TOUR> TOURADDUSERNavigation { get; set; }
        public virtual ICollection<TOUR> TOUREDITUSERNavigation { get; set; }
        public virtual ICollection<TOUR_DISCOUNTS> TOUR_DISCOUNTSADDUSERNavigation { get; set; }
        public virtual ICollection<TOUR_DISCOUNTS> TOUR_DISCOUNTSEDITUSERNavigation { get; set; }
        public virtual ICollection<TOUR_PRICES> TOUR_PRICESADDUSERNavigation { get; set; }
        public virtual ICollection<TOUR_PRICES> TOUR_PRICESEDITUSERNavigation { get; set; }
        public virtual ICollection<TOUR_PROGRAM> TOUR_PROGRAMADDUSERNavigation { get; set; }
        public virtual ICollection<TOUR_PROGRAM> TOUR_PROGRAMEDITUSERNavigation { get; set; }
        public virtual ICollection<TRANSFER_LOCATIONS> TRANSFER_LOCATIONSADDUSERNavigation { get; set; }
        public virtual ICollection<TRANSFER_LOCATIONS> TRANSFER_LOCATIONSEDITUSERNavigation { get; set; }
        public virtual ICollection<TRANSFER_PRICES> TRANSFER_PRICESADDUSERNavigation { get; set; }
        public virtual ICollection<TRANSFER_PRICES> TRANSFER_PRICESEDITUSERNavigation { get; set; }
        public virtual ICollection<TRANSFER_PROVIDERS> TRANSFER_PROVIDERSADDUSERNavigation { get; set; }
        public virtual ICollection<TRANSFER_PROVIDERS> TRANSFER_PROVIDERSEDITUSERNavigation { get; set; }
        public virtual ICollection<USERS_CUSTOMAUTH> USERS_CUSTOMAUTH { get; set; }
        public virtual ICollection<USER_HISTORY> USER_HISTORY { get; set; }
        public virtual ICollection<USER_ROLES> USER_ROLES { get; set; }
        public virtual ICollection<VEHICLETYPES> VEHICLETYPESADDUSERNavigation { get; set; }
        public virtual ICollection<VEHICLETYPES> VEHICLETYPESEDITUSERNavigation { get; set; }
        public virtual ICollection<VIRTUAL_POS_ACCOUNTS> VIRTUAL_POS_ACCOUNTSADDUSERNavigation { get; set; }
        public virtual ICollection<VIRTUAL_POS_ACCOUNTS> VIRTUAL_POS_ACCOUNTSEDITUSERNavigation { get; set; }
        public virtual ICollection<VIRTUAL_POS_ACCOUNT_INSTALMENTS> VIRTUAL_POS_ACCOUNT_INSTALMENTSADDUSERNavigation { get; set; }
        public virtual ICollection<VIRTUAL_POS_ACCOUNT_INSTALMENTS> VIRTUAL_POS_ACCOUNT_INSTALMENTSEDITUSERNavigation { get; set; }
        public virtual ICollection<VIRTUAL_POS_DEFAULTS> VIRTUAL_POS_DEFAULTSADDUSERNavigation { get; set; }
        public virtual ICollection<VIRTUAL_POS_DEFAULTS> VIRTUAL_POS_DEFAULTSEDITUSERNavigation { get; set; }
        public virtual ICollection<VIRTUAL_POS_DEP_PAYMENTS> VIRTUAL_POS_DEP_PAYMENTSADDUSERNavigation { get; set; }
        public virtual ICollection<VIRTUAL_POS_DEP_PAYMENTS> VIRTUAL_POS_DEP_PAYMENTSEDITUSERNavigation { get; set; }
        public virtual ICollection<VIRTUAL_POS_DEP_PAYMENTS_CANCEL> VIRTUAL_POS_DEP_PAYMENTS_CANCELADDUSERNavigation { get; set; }
        public virtual ICollection<VIRTUAL_POS_DEP_PAYMENTS_CANCEL> VIRTUAL_POS_DEP_PAYMENTS_CANCELEDITUSERNavigation { get; set; }
        public virtual ICollection<VIRTUAL_POS_PAYMENTS> VIRTUAL_POS_PAYMENTSADDUSERNavigation { get; set; }
        public virtual ICollection<VIRTUAL_POS_PAYMENTS> VIRTUAL_POS_PAYMENTSEDITUSERNavigation { get; set; }
        public virtual ICollection<VIRTUAL_POS_PAYMENT_EMAILS> VIRTUAL_POS_PAYMENT_EMAILSADDUSERNavigation { get; set; }
        public virtual ICollection<VIRTUAL_POS_PAYMENT_EMAILS> VIRTUAL_POS_PAYMENT_EMAILSEDITUSERNavigation { get; set; }
        public virtual ICollection<VIRTUAL_POS_PAYMENT_MESSAGE_TEMPS> VIRTUAL_POS_PAYMENT_MESSAGE_TEMPSADDUSERNavigation { get; set; }
        public virtual ICollection<VIRTUAL_POS_PAYMENT_MESSAGE_TEMPS> VIRTUAL_POS_PAYMENT_MESSAGE_TEMPSEDITUSERNavigation { get; set; }
        public virtual ICollection<VIRTUAL_POS_PAYMENT_REQUESTS> VIRTUAL_POS_PAYMENT_REQUESTSADDUSERNavigation { get; set; }
        public virtual ICollection<VIRTUAL_POS_PAYMENT_REQUESTS> VIRTUAL_POS_PAYMENT_REQUESTSEDITUSERNavigation { get; set; }
        public virtual ICollection<VIRTUAL_POS_PAYMENT_REQUESTS_NOTES> VIRTUAL_POS_PAYMENT_REQUESTS_NOTESADDUSERNavigation { get; set; }
        public virtual ICollection<VIRTUAL_POS_PAYMENT_REQUESTS_NOTES> VIRTUAL_POS_PAYMENT_REQUESTS_NOTESEDITUSERNavigation { get; set; }
        public virtual ICollection<VIRTUAL_POS_PAYMENT_TEMPS> VIRTUAL_POS_PAYMENT_TEMPSADDUSERNavigation { get; set; }
        public virtual ICollection<VIRTUAL_POS_PAYMENT_TEMPS> VIRTUAL_POS_PAYMENT_TEMPSEDITUSERNavigation { get; set; }
        public virtual ICollection<VIRTUAL_POS_PAYMENT_VPOSES> VIRTUAL_POS_PAYMENT_VPOSESADDUSERNavigation { get; set; }
        public virtual ICollection<VIRTUAL_POS_PAYMENT_VPOSES> VIRTUAL_POS_PAYMENT_VPOSESEDITUSERNavigation { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
