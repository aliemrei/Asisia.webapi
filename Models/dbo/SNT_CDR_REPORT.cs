using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class SNT_CDR_REPORT : EntityBase // My Handlebars Helper
    {
        public string? PERSONNAME { get; set; }
        public Guid? PERSONID { get; set; }
        public string uniqueid { get; set; } = null!;
        public string src { get; set; } = null!;
        public string? CAMPAIGN { get; set; }
        public string? PROJECTNAME { get; set; }
        public string? PRODUCTNAME { get; set; }
        public string? PEERNAME { get; set; }
        public string userfield { get; set; } = null!;
        public string disposition { get; set; } = null!;
        public string? exten { get; set; }
        public string? callednumber { get; set; }
        public int ISOUTBOUND { get; set; }
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
        public DateTime CDATE { get; set; }
        public int duration { get; set; }
        public int billsec { get; set; }
        public DateTime? start { get; set; }
        public DateTime? answer { get; set; }
        public DateTime? end { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
