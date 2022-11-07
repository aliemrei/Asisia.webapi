using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class VW_SALES : EntityBase // My Handlebars Helper
    {
        public Guid CORPID { get; set; }
        public Guid? ID { get; set; }
        public Guid REQUESTID { get; set; }
        public DateTime? SELL_DATE { get; set; }
        public DateTime? RDADDATE { get; set; }
        public DateTime? REQADDATE { get; set; }
        public Guid? PRODUCTID { get; set; }
        public string? PRODUCTNAME { get; set; }
        public string? PRODUCTTYPE { get; set; }
        public short? STATUSCODE { get; set; }
        public string? STATUS { get; set; }
        public string? SUBSTATUS { get; set; }
        public Guid? SELLER_USERID { get; set; }
        public Guid? AGENTID { get; set; }
        public Guid PROJECT_GROUPID { get; set; }
        public Guid RESOURCEID { get; set; }
        public double? GRAND_TOTAL { get; set; }
        public string? CURCODE { get; set; }
        public string? USERNAME { get; set; }
        public double? PROFIT_PERCENT { get; set; }
        public Guid? PROJECT_DETAILID { get; set; }
        public int? PROJECT_DETAIL_INTID { get; set; }
        public int? ADULT { get; set; }
        public int? ROOMCOUNT { get; set; }
        public DateTime? DATE1 { get; set; }
        public DateTime? DATE2 { get; set; }
        public int? CHD1 { get; set; }
        public int? CHD2 { get; set; }
        public int? BABY { get; set; }
        public Guid? PERSONID { get; set; }
        public string? PERSONNAME { get; set; }
        public string? DIRECT_BRANDING { get; set; }
        public int? NIGHTS { get; set; }
        public int? PAX { get; set; }
        public string? SUBPRODUCT { get; set; }
        public string? COUNTRY { get; set; }
        public string? MARKET { get; set; }
        public bool? CANCELATION_WARRANTY { get; set; }
        public double? CANCELLATION_WARRANTY_RATE { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
