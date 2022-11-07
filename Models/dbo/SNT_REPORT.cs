using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class SNT_REPORT : EntityBase // My Handlebars Helper
    {
        public int SUMMARYFIELD { get; set; }
        public string? CAMPAIGN { get; set; }
        public string? PROJECTNAME { get; set; }
        public string? PRODUCTNAME { get; set; }
        public int ISOUTBOUND { get; set; }
        public int ISTRANSFER { get; set; }
        public int? CWEEK { get; set; }
        public int? CWEEKDAY { get; set; }
        public byte? DAYOFWEEK { get; set; }
        public string? CDAYNAME { get; set; }
        public string? CMONTHNAME { get; set; }
        public int? CDAYOFYEAR { get; set; }
        public int? CYEAR { get; set; }
        public int? CMONTH { get; set; }
        public int? CDAY { get; set; }
        public int? CHOUR { get; set; }
        public int? CMINUTE { get; set; }
        public int? SWID { get; set; }
        public int? queuelogid { get; set; }
        public string? queuename { get; set; }
        public string? agent { get; set; }
        public string? _event { get; set; }
        public string? HAT { get; set; }
        public string? fromuser { get; set; }
        public string uniqueid { get; set; } = null!;
        public DateTime calldate { get; set; }
        public DateTime? tdate { get; set; }
        public string clid { get; set; } = null!;
        public string src { get; set; } = null!;
        public string dst { get; set; } = null!;
        public string dcontext { get; set; } = null!;
        public string channel { get; set; } = null!;
        public string dstchannel { get; set; } = null!;
        public string? lastapp { get; set; }
        public string lastdata { get; set; } = null!;
        public int duration { get; set; }
        public int billsec { get; set; }
        public string disposition { get; set; } = null!;
        public string amaflags { get; set; } = null!;
        public string accountcode { get; set; } = null!;
        public string userfield { get; set; } = null!;
        public DateTime? start { get; set; }
        public DateTime? answer { get; set; }
        public DateTime? end { get; set; }
        public string? exten { get; set; }
        public string? callednumber { get; set; }
        public string? peername { get; set; }
        public string? callerid { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
