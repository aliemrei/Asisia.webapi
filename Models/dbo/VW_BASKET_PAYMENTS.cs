using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class VW_BASKET_PAYMENTS : EntityBase // My Handlebars Helper
    {
        public int PAYTPE { get; set; }
        public Guid? CORPID { get; set; }
        public Guid? STATUID { get; set; }
        public string? DESCRIPTION { get; set; }
        public short? SUBSTATUS { get; set; }
        public Guid ID { get; set; }
        public Guid? REQUESTID { get; set; }
        public string? POS { get; set; }
        public double AMOUNT { get; set; }
        public double? LAST_AMOUNT { get; set; }
        public string? CURCODE { get; set; }
        public int? INSTALMENT { get; set; }
        public string? TRANTYPE { get; set; }
        public string? STORETYPE { get; set; }
        public DateTime ENDTIME { get; set; }
        public bool? PREAUTH { get; set; }
        public bool? POSTAUTH { get; set; }
        public bool? VOID { get; set; }
        public bool? REFUND { get; set; }
        public double? CTOTAL { get; set; }
        public double? CAMOUNT { get; set; }
        public string? CCURCODE { get; set; }
        public int? INTID { get; set; }
        public string? AUTHCODE { get; set; }
        public string? RETREFNUMBER { get; set; }
        public string? CARDNO { get; set; }
        public string? ACCOUNTNAME { get; set; }
        public string? TERMINALID { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public double CANCEL_AMOUNT { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
