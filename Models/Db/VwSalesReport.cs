using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class VwSalesReport : EntityBase // My Handlebars Helper
    {
        public Guid Corpid { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public int? Day { get; set; }
        public DateTime? Date { get; set; }
        public string? Productname { get; set; }
        public string? Subproduct { get; set; }
        public string? Producttype { get; set; }
        public short? Statuscode { get; set; }
        public string? Status { get; set; }
        public string? DirectBranding { get; set; }
        public string? Substatus { get; set; }
        public Guid? Agentid { get; set; }
        public Guid ProjectGroupid { get; set; }
        public Guid Resourceid { get; set; }
        public Guid? SellerUserid { get; set; }
        public string? Country { get; set; }
        public string? Market { get; set; }
        public double? Total { get; set; }
        public int? Count { get; set; }
        public int? Pax { get; set; }
        public int? Chd1 { get; set; }
        public int? Chd2 { get; set; }
        public int? Baby { get; set; }
        public int? Roomcount { get; set; }
        public string? Curcode { get; set; }
        public string? Username { get; set; }
        public double? ProfitPercent { get; set; }
        public Guid? ProjectDetailid { get; set; }
        public int? ProjectDetailIntid { get; set; }
        public int? Nights { get; set; }
        public double? WarrantyAmount { get; set; }
        public Guid? Productid { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
