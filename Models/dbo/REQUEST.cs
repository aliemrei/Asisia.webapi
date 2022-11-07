using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class REQUEST : EntityBase // My Handlebars Helper
    {
        public REQUEST()
        {
            BASKET_DATA = new HashSet<BASKET_DATA>();
            CALL_JOBS = new HashSet<CALL_JOBS>();
            PAYMENTS = new HashSet<PAYMENTS>();
            REQUEST_DETAIL = new HashSet<REQUEST_DETAIL>();
            REQUEST_NOTES = new HashSet<REQUEST_NOTES>();
            SMTP_MAILS = new HashSet<SMTP_MAILS>();
            VIRTUAL_POS_DEP_PAYMENTS = new HashSet<VIRTUAL_POS_DEP_PAYMENTS>();
            VIRTUAL_POS_PAYMENTS = new HashSet<VIRTUAL_POS_PAYMENTS>();
        }

        public Guid ID { get; set; }
        public Guid? PERSONID { get; set; }
        public Guid CORPID { get; set; }
        public Guid RESOURCEID { get; set; }
        public Guid? PROJECT_DETAILID { get; set; }
        public string? REQ_URL { get; set; }
        public string? CAMPAIGNCODE { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public DateTime? CREATIONDATE { get; set; }
        public TimeSpan? CREATIONTIME { get; set; }
        public Guid PROJECT_GROUPID { get; set; }
        public Guid? STATUS { get; set; }
        public Guid? SUBSTATUS { get; set; }
        public string? RAKAM_ID { get; set; }
        public int? PERSON_CCARDID { get; set; }
        public string? CURCODE { get; set; }
        public Guid? POSACCOUNTID { get; set; }
        public Guid? POSINSTALMENTID { get; set; }
        public bool ISCALLTRANSFER { get; set; }
        public bool? ORG { get; set; }
        public Guid? SELLER_USERID { get; set; }
        public DateTime? SELL_DATE { get; set; }
        public string? RESNO { get; set; }
        public DateTime? SELLINGDATE { get; set; }
        public TimeSpan? SELLINGTIME { get; set; }
        public string? DIRECT_BRANDING { get; set; }
        public int? ENTID { get; set; }
        public Guid? INVOICE_ADDRESSID { get; set; }
        public byte INVOICE_TYPE { get; set; }
        public string? INVOICE_TAXNO { get; set; }
        public string? INVOICE_TAXPLACENAME { get; set; }
        public string? INVOICE_EMAIL { get; set; }
        public string? INVOICE_TITLE { get; set; }
        public string? INVOICE_FIRSTNAME { get; set; }
        public string? INVOICE_LASTNAME { get; set; }
        public bool PAY_AT_PLACE { get; set; }
        public Guid? CAMPAIGNID { get; set; }
        public Guid? AGENCYID { get; set; }
        public short INVOICE_KIND { get; set; }
        public DateTime? INVOICE_DATE { get; set; }
        public bool? CANCELATION_WARRANTY { get; set; }
        public bool? ALLOW_SINGLE_MEN { get; set; }
        public string? OFFER_TEXT { get; set; }
        public string? OFFER_RULES { get; set; }
        public string? OFFER_DESCRIPTION { get; set; }
        public string? PASSWORD { get; set; }
        public string? LANGCODE { get; set; }
        public string? CONVERSATION_ID { get; set; }
        public string? CONVERSATION_CUSTOMERID { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual AGENCY? AGENCY { get; set; }
        public virtual CAMPAIGNS? CAMPAIGN { get; set; }
        public virtual CORP CORP { get; set; } = null!;
        public virtual LOCATION_ADDRESS? INVOICE_ADDRESS { get; set; }
        public virtual STDLANGUAGES? LANGCODENavigation { get; set; }
        public virtual PERSON? PERSON { get; set; }
        public virtual USERS? SELLER_USER { get; set; }
        public virtual REQUEST_STATUS? STATUSNavigation { get; set; }
        public virtual ICollection<BASKET_DATA> BASKET_DATA { get; set; }
        public virtual ICollection<CALL_JOBS> CALL_JOBS { get; set; }
        public virtual ICollection<PAYMENTS> PAYMENTS { get; set; }
        public virtual ICollection<REQUEST_DETAIL> REQUEST_DETAIL { get; set; }
        public virtual ICollection<REQUEST_NOTES> REQUEST_NOTES { get; set; }
        public virtual ICollection<SMTP_MAILS> SMTP_MAILS { get; set; }
        public virtual ICollection<VIRTUAL_POS_DEP_PAYMENTS> VIRTUAL_POS_DEP_PAYMENTS { get; set; }
        public virtual ICollection<VIRTUAL_POS_PAYMENTS> VIRTUAL_POS_PAYMENTS { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
