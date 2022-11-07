using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class SNT_CALL_DETAIL : EntityBase // My Handlebars Helper
    {
        public int? CYEAR { get; set; }
        public int? CMONTH { get; set; }
        public int? CDAY { get; set; }
        public DateTime? CDATE { get; set; }
        public int? INBOUND { get; set; }
        public int? OUTBOUND { get; set; }
        public int? ANSWERED { get; set; }
        public int? BUSY { get; set; }
        public int? NOANSWER { get; set; }
        public int? FAILED { get; set; }
        public int? OTHERDEPARTMENT { get; set; }
        public int TRANSFERCALL { get; set; }
        public int? SENTQUEUE { get; set; }
        public int? ABANDON { get; set; }
        public string? userfield { get; set; }
        public string? _event { get; set; }
        public string? queuename { get; set; }
        public string? agent { get; set; }
        public DateTime? ENTERQUEUE { get; set; }
        public DateTime? calldate { get; set; }
        public string? clid { get; set; }
        public string? src { get; set; }
        public string? dst { get; set; }
        public string? dcontext { get; set; }
        public string? channel { get; set; }
        public string? lastapp { get; set; }
        public string? lastdata { get; set; }
        public int? duration { get; set; }
        public int? billsec { get; set; }
        public string? disposition { get; set; }
        public string? uniqueid { get; set; }
        public DateTime? start { get; set; }
        public DateTime? end { get; set; }
        public DateTime? answer { get; set; }
        public int? RESINBOUND { get; set; }
        public int RESOUTBOUND { get; set; }
        public int RESABANDON { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
