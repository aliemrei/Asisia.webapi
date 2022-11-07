using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class PROJECT_GROUP : EntityBase // My Handlebars Helper
    {
        public PROJECT_GROUP()
        {
            BONUS_DEF = new HashSet<BONUS_DEF>();
            CALL_JOBS = new HashSet<CALL_JOBS>();
            CAMPAIGNS = new HashSet<CAMPAIGNS>();
            PAYMENT_EMAILS = new HashSet<PAYMENT_EMAILS>();
            PORTAL = new HashSet<PORTAL>();
            PROJECT_GROUPDETAIL = new HashSet<PROJECT_GROUPDETAIL>();
            SMS_SETTINGS = new HashSet<SMS_SETTINGS>();
            SMTP_SETTINGS = new HashSet<SMTP_SETTINGS>();
            USER_PROJECTS = new HashSet<USER_PROJECTS>();
        }

        public Guid ID { get; set; }
        public string NAME { get; set; } = null!;
        public Guid? CORPID { get; set; }
        public bool MERGECLIENTS { get; set; }
        public bool USEALTERNATES { get; set; }
        public bool ISDELETED { get; set; }
        public bool ISDISABLED { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public string? ENT_ID { get; set; }
        public string? ENT_URL { get; set; }
        public string? RAKAM_ID { get; set; }
        public string? ACC_CODE { get; set; }
        public bool ENT_USE { get; set; }
        public string? RES_MAILURL { get; set; }
        public string? ENT_SETURURL { get; set; }
        public string? ENT_SETURAPIKEY { get; set; }
        public bool? DONTSTORE_CCARDS { get; set; }
        public Guid? ADDRESSID { get; set; }

        public virtual LOCATION_ADDRESS? ADDRESS { get; set; }
        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual CORP? CORP { get; set; }
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual ICollection<BONUS_DEF> BONUS_DEF { get; set; }
        public virtual ICollection<CALL_JOBS> CALL_JOBS { get; set; }
        public virtual ICollection<CAMPAIGNS> CAMPAIGNS { get; set; }
        public virtual ICollection<PAYMENT_EMAILS> PAYMENT_EMAILS { get; set; }
        public virtual ICollection<PORTAL> PORTAL { get; set; }
        public virtual ICollection<PROJECT_GROUPDETAIL> PROJECT_GROUPDETAIL { get; set; }
        public virtual ICollection<SMS_SETTINGS> SMS_SETTINGS { get; set; }
        public virtual ICollection<SMTP_SETTINGS> SMTP_SETTINGS { get; set; }
        public virtual ICollection<USER_PROJECTS> USER_PROJECTS { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
