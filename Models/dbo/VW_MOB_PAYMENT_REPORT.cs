using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class VW_MOB_PAYMENT_REPORT : EntityBase // My Handlebars Helper
    {
        public Guid? CORPID { get; set; }
        public Guid? PROJECT_GROUPID { get; set; }
        public string? PROJECTGROUP { get; set; }
        public string? POS { get; set; }
        public string? PERSONNAME { get; set; }
        public double? LAST_AMOUNT { get; set; }
        public string? CURCODE { get; set; }
        public string? DESCRIPTION { get; set; }
        public DateTime ENDTIME { get; set; }
        public int? INTID { get; set; }
        public string? AUTHCODE { get; set; }
        public string? PAYTYPE { get; set; }
        public double? TOTAL { get; set; }
        public string? RCURCODE { get; set; }
        public string? PRODUCTNAME { get; set; }
        public string? RESIDS { get; set; }
        public string? STATU { get; set; }
        public string? SUBSTATU { get; set; }
        public Guid? STATUID { get; set; }
        public double CANCEL_AMOUNT { get; set; }
        public double? CTOTAL { get; set; }
        public string? PROJECT_GROUPDETAIL { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
