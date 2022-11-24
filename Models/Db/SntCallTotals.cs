using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class SntCallTotals : EntityBase // My Handlebars Helper
    {
        public DateTime? Cdate { get; set; }
        public int? Cday { get; set; }
        public string? Cmonthname { get; set; }
        public int? Cyear { get; set; }
        public string? Cdayname { get; set; }
        public int? Cweek { get; set; }
        public string? Campaign { get; set; }
        public string? Projectname { get; set; }
        public string? Productname { get; set; }
        public int? Callcount { get; set; }
        public int? Answeredcall { get; set; }
        public int? Abandoncall { get; set; }
        public int? Totalrealduration { get; set; }
        public int? Totalduration { get; set; }
        public int? Maxrealduration { get; set; }
        public int? Maxduration { get; set; }
        public int? Avgrealduration { get; set; }
        public int? Avgduration { get; set; }
        public int? Totalwait { get; set; }
        public int? Maxwait { get; set; }
        public int? Avgwait { get; set; }
        public int? AnsweredTotalwait { get; set; }
        public int? AnsweredAvgwait { get; set; }
        public int? AnsweredMaxwait { get; set; }
        public int? AbandonTotalwait { get; set; }
        public int? AbandonAvgwait { get; set; }
        public int? AbandonMaxwait { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
