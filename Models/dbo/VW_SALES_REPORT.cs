using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class VW_SALES_REPORT : EntityBase // My Handlebars Helper
    {
        public Guid CORPID { get; set; }
        public int? YEAR { get; set; }
        public int? MONTH { get; set; }
        public int? DAY { get; set; }
        public DateTime? DATE { get; set; }
        public string? PRODUCTNAME { get; set; }
        public string? SUBPRODUCT { get; set; }
        public string? PRODUCTTYPE { get; set; }
        public short? STATUSCODE { get; set; }
        public string? STATUS { get; set; }
        public string? DIRECT_BRANDING { get; set; }
        public string? SUBSTATUS { get; set; }
        public Guid? AGENTID { get; set; }
        public Guid PROJECT_GROUPID { get; set; }
        public Guid RESOURCEID { get; set; }
        public Guid? SELLER_USERID { get; set; }
        public string? COUNTRY { get; set; }
        public string? MARKET { get; set; }
        public double? TOTAL { get; set; }
        public int? COUNT { get; set; }
        public int? PAX { get; set; }
        public int? CHD1 { get; set; }
        public int? CHD2 { get; set; }
        public int? BABY { get; set; }
        public int? ROOMCOUNT { get; set; }
        public string? CURCODE { get; set; }
        public string? USERNAME { get; set; }
        public double? PROFIT_PERCENT { get; set; }
        public Guid? PROJECT_DETAILID { get; set; }
        public int? PROJECT_DETAIL_INTID { get; set; }
        public int? NIGHTS { get; set; }
        public double? WARRANTY_AMOUNT { get; set; }
        public Guid? PRODUCTID { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
