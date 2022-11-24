using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class VwSales : EntityBase // My Handlebars Helper
    {
        public Guid Corpid { get; set; }
        public Guid? Id { get; set; }
        public Guid Requestid { get; set; }
        public DateTime? SellDate { get; set; }
        public DateTime? Rdaddate { get; set; }
        public DateTime? Reqaddate { get; set; }
        public Guid? Productid { get; set; }
        public string? Productname { get; set; }
        public string? Producttype { get; set; }
        public short? Statuscode { get; set; }
        public string? Status { get; set; }
        public string? Substatus { get; set; }
        public Guid? SellerUserid { get; set; }
        public Guid? Agentid { get; set; }
        public Guid ProjectGroupid { get; set; }
        public Guid Resourceid { get; set; }
        public double? GrandTotal { get; set; }
        public string? Curcode { get; set; }
        public string? Username { get; set; }
        public double? ProfitPercent { get; set; }
        public Guid? ProjectDetailid { get; set; }
        public int? ProjectDetailIntid { get; set; }
        public int? Adult { get; set; }
        public int? Roomcount { get; set; }
        public DateTime? Date1 { get; set; }
        public DateTime? Date2 { get; set; }
        public int? Chd1 { get; set; }
        public int? Chd2 { get; set; }
        public int? Baby { get; set; }
        public Guid? Personid { get; set; }
        public string? Personname { get; set; }
        public string? DirectBranding { get; set; }
        public int? Nights { get; set; }
        public int? Pax { get; set; }
        public string? Subproduct { get; set; }
        public string? Country { get; set; }
        public string? Market { get; set; }
        public bool? CancelationWarranty { get; set; }
        public double? CancellationWarrantyRate { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
