using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class PORTAL : EntityBase // My Handlebars Helper
    {
        public PORTAL()
        {
            PORTAL_AUTH_IPADDRESS = new HashSet<PORTAL_AUTH_IPADDRESS>();
            PORTAL_CATEGORIES = new HashSet<PORTAL_CATEGORIES>();
            PORTAL_CURRENCIES = new HashSet<PORTAL_CURRENCIES>();
            PORTAL_DESCRIPTION = new HashSet<PORTAL_DESCRIPTION>();
            PORTAL_DOMAINS = new HashSet<PORTAL_DOMAINS>();
            PORTAL_EMAILS = new HashSet<PORTAL_EMAILS>();
            PORTAL_LANGUAGES = new HashSet<PORTAL_LANGUAGES>();
            PORTAL_SETTINGS = new HashSet<PORTAL_SETTINGS>();
            VIRTUAL_POS_DEFAULTS = new HashSet<VIRTUAL_POS_DEFAULTS>();
            VIRTUAL_POS_PAYMENT_REQUESTS = new HashSet<VIRTUAL_POS_PAYMENT_REQUESTS>();
        }

        public int ID { get; set; }
        public Guid UID { get; set; }
        public Guid? PROJECTID { get; set; }
        public Guid? PROJECT_DETAILID { get; set; }
        public Guid? CORPORATIONID { get; set; }
        public string? DOMAIN { get; set; }
        public string? TEMPLATENAME { get; set; }
        public string? LOGININFO { get; set; }
        public Guid? RESOURCEID { get; set; }
        public bool ISDISABLED { get; set; }
        public string? DEFAULT_LANG { get; set; }
        public string DEFAULT_CURCODE { get; set; } = null!;
        public string? LOGO { get; set; }
        public string? DISPLAYNAME { get; set; }
        public string? CONTACT_PHONE { get; set; }
        public string? CONTACT_EMAIL { get; set; }
        public byte MODE { get; set; }
        public string? CONTACT_MAPURL { get; set; }
        public string? FAVICON { get; set; }
        public bool SET_LANG_BYMARKET { get; set; }
        public bool SET_CURCODE_BYMARKET { get; set; }
        public bool? MULTIPLE_CURCODES { get; set; }
        public string? OFFER_TEXT { get; set; }
        public string? OFFER_RULES { get; set; }
        public string? OFFER_BANNER { get; set; }
        public bool ACCOUNT_USE { get; set; }
        public string? ACCOUNT_BACKGROUNDURL { get; set; }
        public string? ACCOUNT_LOGO { get; set; }
        public string? ACCOUNT_COPYRIGHT { get; set; }
        public bool? ACCOUNT_LOGIN_BY_PHONE { get; set; }
        public bool ACCOUNT_LOGIN_BY_ROOMNO { get; set; }
        public bool? ACCOUNT_LOGIN_BY_VOUCHERNO { get; set; }
        public bool? ACCOUNT_AUTO_CREATEUSER_ONFORGETPASSFORM { get; set; }
        public bool CRM_ACTIVE { get; set; }
        public string? PORTAL_GROUPNAME { get; set; }
        public string? POSTEK_DOMAIN { get; set; }

        public virtual CORP? CORPORATION { get; set; }
        public virtual CURCODE DEFAULT_CURCODENavigation { get; set; } = null!;
        public virtual PROJECT_GROUP? PROJECT { get; set; }
        public virtual PROJECT_GROUPDETAIL? PROJECT_DETAIL { get; set; }
        public virtual ICollection<PORTAL_AUTH_IPADDRESS> PORTAL_AUTH_IPADDRESS { get; set; }
        public virtual ICollection<PORTAL_CATEGORIES> PORTAL_CATEGORIES { get; set; }
        public virtual ICollection<PORTAL_CURRENCIES> PORTAL_CURRENCIES { get; set; }
        public virtual ICollection<PORTAL_DESCRIPTION> PORTAL_DESCRIPTION { get; set; }
        public virtual ICollection<PORTAL_DOMAINS> PORTAL_DOMAINS { get; set; }
        public virtual ICollection<PORTAL_EMAILS> PORTAL_EMAILS { get; set; }
        public virtual ICollection<PORTAL_LANGUAGES> PORTAL_LANGUAGES { get; set; }
        public virtual ICollection<PORTAL_SETTINGS> PORTAL_SETTINGS { get; set; }
        public virtual ICollection<VIRTUAL_POS_DEFAULTS> VIRTUAL_POS_DEFAULTS { get; set; }
        public virtual ICollection<VIRTUAL_POS_PAYMENT_REQUESTS> VIRTUAL_POS_PAYMENT_REQUESTS { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
