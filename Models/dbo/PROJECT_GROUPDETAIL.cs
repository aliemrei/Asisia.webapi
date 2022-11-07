using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class PROJECT_GROUPDETAIL : EntityBase // My Handlebars Helper
    {
        public PROJECT_GROUPDETAIL()
        {
            CALL_JOBS = new HashSet<CALL_JOBS>();
            PAYMENT_EMAILS = new HashSet<PAYMENT_EMAILS>();
            PORTAL = new HashSet<PORTAL>();
            PORTAL_SEO = new HashSet<PORTAL_SEO>();
            PROJECT_GROUPDETAIL_BANKDEP = new HashSet<PROJECT_GROUPDETAIL_BANKDEP>();
            PROJECT_GROUPDETAIL_VPOS = new HashSet<PROJECT_GROUPDETAIL_VPOS>();
            REQUEST_DETAIL = new HashSet<REQUEST_DETAIL>();
            RESERVATION_EMAILS = new HashSet<RESERVATION_EMAILS>();
            RESOURCE_DETAIL = new HashSet<RESOURCE_DETAIL>();
            SMS_SETTINGS = new HashSet<SMS_SETTINGS>();
            USER_PROJECT_DETAILS = new HashSet<USER_PROJECT_DETAILS>();
        }

        public Guid ID { get; set; }
        public int INTID { get; set; }
        public Guid PROJECT_GROUPID { get; set; }
        public Guid? HOTELID { get; set; }
        public Guid? TICKETID { get; set; }
        public string? DESCRIPTION { get; set; }
        public string? ENT_ID { get; set; }
        public double PROFIT_PERCENT { get; set; }
        public string? GA_CUSTOMERID { get; set; }
        public bool ISDISABLED { get; set; }
        public string? ACC_INV_CODE { get; set; }
        public string? ACC_PAY_CODE { get; set; }
        public long? TEL1 { get; set; }
        public long? TEL2 { get; set; }
        public string? EMAIL { get; set; }
        public bool DONT_MERGE { get; set; }
        public int? INVOICE_DUEDAY { get; set; }
        public Guid? TOURID { get; set; }
        public string? ENT_ETSID { get; set; }
        public string? ENT_TOURISTICAID { get; set; }
        public string? ENT_TATILBUDURID { get; set; }
        public Guid? PRODUCTID { get; set; }
        public string? ENT_IATIID { get; set; }
        public string? ENT_ETSURL { get; set; }
        public string? ENT_TOURISTICAURL { get; set; }
        public string? ENT_TATILBUDURURL { get; set; }
        public string? ENT_IATIURL { get; set; }
        public string? ENT_TRAVELCLICKID { get; set; }
        public string? ENT_TRAVELCLCIKURL { get; set; }
        public string? ENT_JOLLYTOURURL { get; set; }
        public string? ENT_JOLLYTOURID { get; set; }
        public string? RES_MAILURL { get; set; }
        public string? ENT_SEDNAURL { get; set; }
        public string? ENT_SEDNAID { get; set; }
        public int? ENT_PORTALID { get; set; }
        public string? ENT_URL { get; set; }
        public string? ENT_HOTELRUNNERID { get; set; }
        public string? ENT_HOTELRUNNERURL { get; set; }
        public bool HIDE_CONTRACTTAB_FROMAGENTS { get; set; }
        public string? ENT_SETURID { get; set; }
        public string? ENT_SETURURL { get; set; }
        public Guid? STOREID { get; set; }

        public virtual STDHOTEL? HOTEL { get; set; }
        public virtual PROJECT_GROUP PROJECT_GROUP { get; set; } = null!;
        public virtual STDSTORE? STORE { get; set; }
        public virtual TICKET? TICKET { get; set; }
        public virtual TOUR? TOUR { get; set; }
        public virtual RESERVATION_RULES? RESERVATION_RULES { get; set; }
        public virtual ICollection<CALL_JOBS> CALL_JOBS { get; set; }
        public virtual ICollection<PAYMENT_EMAILS> PAYMENT_EMAILS { get; set; }
        public virtual ICollection<PORTAL> PORTAL { get; set; }
        public virtual ICollection<PORTAL_SEO> PORTAL_SEO { get; set; }
        public virtual ICollection<PROJECT_GROUPDETAIL_BANKDEP> PROJECT_GROUPDETAIL_BANKDEP { get; set; }
        public virtual ICollection<PROJECT_GROUPDETAIL_VPOS> PROJECT_GROUPDETAIL_VPOS { get; set; }
        public virtual ICollection<REQUEST_DETAIL> REQUEST_DETAIL { get; set; }
        public virtual ICollection<RESERVATION_EMAILS> RESERVATION_EMAILS { get; set; }
        public virtual ICollection<RESOURCE_DETAIL> RESOURCE_DETAIL { get; set; }
        public virtual ICollection<SMS_SETTINGS> SMS_SETTINGS { get; set; }
        public virtual ICollection<USER_PROJECT_DETAILS> USER_PROJECT_DETAILS { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
