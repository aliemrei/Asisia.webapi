using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class SntReport : EntityBase // My Handlebars Helper
    {
        public int Summaryfield { get; set; }
        public string? Campaign { get; set; }
        public string? Projectname { get; set; }
        public string? Productname { get; set; }
        public int Isoutbound { get; set; }
        public int Istransfer { get; set; }
        public int? Cweek { get; set; }
        public int? Cweekday { get; set; }
        public byte? Dayofweek { get; set; }
        public string? Cdayname { get; set; }
        public string? Cmonthname { get; set; }
        public int? Cdayofyear { get; set; }
        public int? Cyear { get; set; }
        public int? Cmonth { get; set; }
        public int? Cday { get; set; }
        public int? Chour { get; set; }
        public int? Cminute { get; set; }
        public int? Swid { get; set; }
        public int? Queuelogid { get; set; }
        public string? Queuename { get; set; }
        public string? Agent { get; set; }
        public string? Event { get; set; }
        public string? Hat { get; set; }
        public string? Fromuser { get; set; }
        public string Uniqueid { get; set; } = null!;
        public DateTime Calldate { get; set; }
        public DateTime? Tdate { get; set; }
        public string Clid { get; set; } = null!;
        public string Src { get; set; } = null!;
        public string Dst { get; set; } = null!;
        public string Dcontext { get; set; } = null!;
        public string Channel { get; set; } = null!;
        public string Dstchannel { get; set; } = null!;
        public string? Lastapp { get; set; }
        public string Lastdata { get; set; } = null!;
        public int Duration { get; set; }
        public int Billsec { get; set; }
        public string Disposition { get; set; } = null!;
        public string Amaflags { get; set; } = null!;
        public string Accountcode { get; set; } = null!;
        public string Userfield { get; set; } = null!;
        public DateTime? Start { get; set; }
        public DateTime? Answer { get; set; }
        public DateTime? End { get; set; }
        public string? Exten { get; set; }
        public string? Callednumber { get; set; }
        public string? Peername { get; set; }
        public string? Callerid { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
