using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class SntCdrReport : EntityBase // My Handlebars Helper
    {
        public string? Personname { get; set; }
        public Guid? Personid { get; set; }
        public string Uniqueid { get; set; } = null!;
        public string Src { get; set; } = null!;
        public string? Campaign { get; set; }
        public string? Projectname { get; set; }
        public string? Productname { get; set; }
        public string? Peername { get; set; }
        public string Userfield { get; set; } = null!;
        public string Disposition { get; set; } = null!;
        public string? Exten { get; set; }
        public string? Callednumber { get; set; }
        public int Isoutbound { get; set; }
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
        public DateTime Cdate { get; set; }
        public int Duration { get; set; }
        public int Billsec { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? Answer { get; set; }
        public DateTime? End { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
