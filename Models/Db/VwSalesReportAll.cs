using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class VwSalesReportAll : EntityBase // My Handlebars Helper
    {
        public Guid Corpid { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public int? Day { get; set; }
        public DateTime? Date { get; set; }
        public string? Productname { get; set; }
        public string? Producttype { get; set; }
        public short? Statuscode { get; set; }
        public string? Status { get; set; }
        public string? Substatus { get; set; }
        public Guid? Agentid { get; set; }
        public Guid ProjectGroupid { get; set; }
        public Guid Resourceid { get; set; }
        public string? DirectBranding { get; set; }
        public double? Total { get; set; }
        public int? Count { get; set; }
        public int? Pax { get; set; }
        public int? Roomcount { get; set; }
        public string? Curcode { get; set; }
        public string? Username { get; set; }
        public double? ProfitPercent { get; set; }
        public Guid? ProjectDetailid { get; set; }
        public int? ProjectDetailIntid { get; set; }
        public decimal? Cost { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
