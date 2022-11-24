using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class VwSalesAll : EntityBase // My Handlebars Helper
    {
        public Guid Corpid { get; set; }
        public Guid? Id { get; set; }
        public Guid Requestid { get; set; }
        public DateTime? Tdate { get; set; }
        public Guid? Productid { get; set; }
        public string? Productname { get; set; }
        public string? Producttype { get; set; }
        public short? Statuscode { get; set; }
        public string? Status { get; set; }
        public string? Substatus { get; set; }
        public Guid? Agentid { get; set; }
        public Guid ProjectGroupid { get; set; }
        public Guid Resourceid { get; set; }
        public double? Total { get; set; }
        public double? ExtraTotal { get; set; }
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
        public string? National { get; set; }
        public string? Market { get; set; }
        public string? Roomtype { get; set; }
        public string? Boardtype { get; set; }
        public string? Resid { get; set; }
        public decimal? Cost { get; set; }
        public int? Chdy { get; set; }
        public int? Chde { get; set; }
        public Guid? Statusid { get; set; }
        public string? Resourcecode { get; set; }
        public string? Resourcename { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
