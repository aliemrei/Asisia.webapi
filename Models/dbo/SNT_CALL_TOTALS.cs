using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class SNT_CALL_TOTALS : EntityBase // My Handlebars Helper
    {
        public DateTime? CDATE { get; set; }
        public int? CDAY { get; set; }
        public string? CMONTHNAME { get; set; }
        public int? CYEAR { get; set; }
        public string? CDAYNAME { get; set; }
        public int? CWEEK { get; set; }
        public string? CAMPAIGN { get; set; }
        public string? PROJECTNAME { get; set; }
        public string? PRODUCTNAME { get; set; }
        public int? CALLCOUNT { get; set; }
        public int? ANSWEREDCALL { get; set; }
        public int? ABANDONCALL { get; set; }
        public int? TOTALREALDURATION { get; set; }
        public int? TOTALDURATION { get; set; }
        public int? MAXREALDURATION { get; set; }
        public int? MAXDURATION { get; set; }
        public int? AVGREALDURATION { get; set; }
        public int? AVGDURATION { get; set; }
        public int? TOTALWAIT { get; set; }
        public int? MAXWAIT { get; set; }
        public int? AVGWAIT { get; set; }
        public int? ANSWERED_TOTALWAIT { get; set; }
        public int? ANSWERED_AVGWAIT { get; set; }
        public int? ANSWERED_MAXWAIT { get; set; }
        public int? ABANDON_TOTALWAIT { get; set; }
        public int? ABANDON_AVGWAIT { get; set; }
        public int? ABANDON_MAXWAIT { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
