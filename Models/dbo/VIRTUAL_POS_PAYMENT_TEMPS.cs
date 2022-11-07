using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class VIRTUAL_POS_PAYMENT_TEMPS : EntityBase // My Handlebars Helper
    {
        public VIRTUAL_POS_PAYMENT_TEMPS()
        {
            VIRTUAL_POS_PAYMENT_EMAILS = new HashSet<VIRTUAL_POS_PAYMENT_EMAILS>();
            VIRTUAL_POS_PAYMENT_REQUESTS = new HashSet<VIRTUAL_POS_PAYMENT_REQUESTS>();
            VIRTUAL_POS_PAYMENT_VPOSES = new HashSet<VIRTUAL_POS_PAYMENT_VPOSES>();
        }

        public Guid ID { get; set; }
        public Guid CORPID { get; set; }
        public string DESCRIPTION { get; set; } = null!;
        public bool USEINSTALLMENTS { get; set; }
        public bool? USEEMAIL { get; set; }
        public bool USESMS { get; set; }
        public bool PRICECHANGEABLE { get; set; }
        public Guid? EMAILTEMPID { get; set; }
        public Guid? SMSTEMPID { get; set; }
        public string? EMAILTEXT { get; set; }
        public string? SMSTEXT { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public bool ISDELETED { get; set; }
        public bool ISDISABLED { get; set; }
        public string? TITLE { get; set; }
        public double PRICE { get; set; }
        public string CURCODE { get; set; } = null!;
        public int PIECE { get; set; }
        public string? PAYMENT_DESCRIPTION { get; set; }
        public string? PAYMENT_TEXT { get; set; }
        public string? PAYMENT_SUCCESSTEXT { get; set; }
        public string? PAYMENT_ERRORTEXT { get; set; }
        public string? SMS_TEXT { get; set; }
        public string? SMS_SUCCESSTEXT { get; set; }
        public string? SMS_ERRORTEXT { get; set; }
        public bool? CANDIV_PAYMENT { get; set; }
        public string? RESNUMBER { get; set; }
        public string? LANGCODE { get; set; }
        public bool SEND_MAILS_ONLY_CREATEUSER { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual CORP CORP { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual VIRTUAL_POS_PAYMENT_MESSAGE_TEMPS? EMAILTEMP { get; set; }
        public virtual STDLANGUAGES? LANGCODENavigation { get; set; }
        public virtual VIRTUAL_POS_PAYMENT_MESSAGE_TEMPS? SMSTEMP { get; set; }
        public virtual ICollection<VIRTUAL_POS_PAYMENT_EMAILS> VIRTUAL_POS_PAYMENT_EMAILS { get; set; }
        public virtual ICollection<VIRTUAL_POS_PAYMENT_REQUESTS> VIRTUAL_POS_PAYMENT_REQUESTS { get; set; }
        public virtual ICollection<VIRTUAL_POS_PAYMENT_VPOSES> VIRTUAL_POS_PAYMENT_VPOSES { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
