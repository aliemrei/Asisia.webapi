using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class VIRTUAL_POS_PAYMENTS : EntityBase // My Handlebars Helper
    {
        public VIRTUAL_POS_PAYMENTS()
        {
            REQUEST_PAYMENTS = new HashSet<REQUEST_PAYMENTS>();
        }

        public Guid ID { get; set; }
        public int INTID { get; set; }
        public Guid POSACCOUNTID { get; set; }
        public Guid? REQUESTID { get; set; }
        public string? CARDOWNER { get; set; }
        public string? CARDNUMBER { get; set; }
        public int? VALIDYEAR { get; set; }
        public int? VALIDMONTH { get; set; }
        public string? CVV { get; set; }
        public double AMOUNT { get; set; }
        public string CURCODE { get; set; } = null!;
        public int INSTALMENT { get; set; }
        public Guid? STATUS { get; set; }
        public string? AUTHCODE { get; set; }
        public string? RETREFNUMBER { get; set; }
        public string? TRANTYPE { get; set; }
        public string? STORETYPE { get; set; }
        public string? PAYER_AUTHCODE { get; set; }
        public string? PAYER_TNXID { get; set; }
        public string? ECI { get; set; }
        public string? STATUSTEXT { get; set; }
        public DateTime? ENDTIME { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public bool PREAUTH { get; set; }
        public bool POSTAUTH { get; set; }
        public bool VOID { get; set; }
        public bool REFUND { get; set; }
        public Guid POSINSTALMENTID { get; set; }
        public bool FIRSTSTEP { get; set; }
        public Guid CORPID { get; set; }
        public double? LAST_AMOUNT { get; set; }
        public bool ISDELETED { get; set; }
        public string? ENTID { get; set; }
        public int ISINTEGRATED { get; set; }
        public string? DESCRIPTION { get; set; }
        public bool? COMPLETEBASKET_AFTERSUCCESS { get; set; }
        public DateTime? VALIDDATE { get; set; }
        public string? BASKET_DESCRIPTION { get; set; }
        public bool FIXIT { get; set; }
        public Guid? PAYMENT_REQUESTID { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual CORP CORP { get; set; } = null!;
        public virtual CURCODE CURCODENavigation { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual VIRTUAL_POS_PAYMENT_REQUESTS? PAYMENT_REQUEST { get; set; }
        public virtual VIRTUAL_POS_ACCOUNTS POSACCOUNT { get; set; } = null!;
        public virtual VIRTUAL_POS_ACCOUNT_INSTALMENTS POSINSTALMENT { get; set; } = null!;
        public virtual REQUEST? REQUEST { get; set; }
        public virtual REQUEST_STATUS? STATUSNavigation { get; set; }
        public virtual ICollection<REQUEST_PAYMENTS> REQUEST_PAYMENTS { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
