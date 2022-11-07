using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class VW_SALES_REPORT_ALL : EntityBase // My Handlebars Helper
    {
        public Guid CORPID { get; set; }
        public int? YEAR { get; set; }
        public int? MONTH { get; set; }
        public int? DAY { get; set; }
        public DateTime? DATE { get; set; }
        public string? PRODUCTNAME { get; set; }
        public string? PRODUCTTYPE { get; set; }
        public short? STATUSCODE { get; set; }
        public string? STATUS { get; set; }
        public string? SUBSTATUS { get; set; }
        public Guid? AGENTID { get; set; }
        public Guid PROJECT_GROUPID { get; set; }
        public Guid RESOURCEID { get; set; }
        public string? DIRECT_BRANDING { get; set; }
        public double? TOTAL { get; set; }
        public int? COUNT { get; set; }
        public int? PAX { get; set; }
        public int? ROOMCOUNT { get; set; }
        public string? CURCODE { get; set; }
        public string? USERNAME { get; set; }
        public double? PROFIT_PERCENT { get; set; }
        public Guid? PROJECT_DETAILID { get; set; }
        public int? PROJECT_DETAIL_INTID { get; set; }
        public decimal? COST { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
