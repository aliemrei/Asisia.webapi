using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class VwMobPaymentReport : EntityBase // My Handlebars Helper
    {
        public Guid? Corpid { get; set; }
        public Guid? ProjectGroupid { get; set; }
        public string? Projectgroup { get; set; }
        public string? Pos { get; set; }
        public string? Personname { get; set; }
        public double? LastAmount { get; set; }
        public string? Curcode { get; set; }
        public string? Description { get; set; }
        public DateTime Endtime { get; set; }
        public int? Intid { get; set; }
        public string? Authcode { get; set; }
        public string? Paytype { get; set; }
        public double? Total { get; set; }
        public string? Rcurcode { get; set; }
        public string? Productname { get; set; }
        public string? Resids { get; set; }
        public string? Statu { get; set; }
        public string? Substatu { get; set; }
        public Guid? Statuid { get; set; }
        public double CancelAmount { get; set; }
        public double? Ctotal { get; set; }
        public string? ProjectGroupdetail { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
