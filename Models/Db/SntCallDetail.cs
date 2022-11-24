using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class SntCallDetail : EntityBase // My Handlebars Helper
    {
        public int? Cyear { get; set; }
        public int? Cmonth { get; set; }
        public int? Cday { get; set; }
        public DateTime? Cdate { get; set; }
        public int? Inbound { get; set; }
        public int? Outbound { get; set; }
        public int? Answered { get; set; }
        public int? Busy { get; set; }
        public int? Noanswer { get; set; }
        public int? Failed { get; set; }
        public int? Otherdepartment { get; set; }
        public int Transfercall { get; set; }
        public int? Sentqueue { get; set; }
        public int? Abandon { get; set; }
        public string? Userfield { get; set; }
        public string? Event { get; set; }
        public string? Queuename { get; set; }
        public string? Agent { get; set; }
        public DateTime? Enterqueue { get; set; }
        public DateTime? Calldate { get; set; }
        public string? Clid { get; set; }
        public string? Src { get; set; }
        public string? Dst { get; set; }
        public string? Dcontext { get; set; }
        public string? Channel { get; set; }
        public string? Lastapp { get; set; }
        public string? Lastdata { get; set; }
        public int? Duration { get; set; }
        public int? Billsec { get; set; }
        public string? Disposition { get; set; }
        public string? Uniqueid { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public DateTime? Answer { get; set; }
        public int? Resinbound { get; set; }
        public int Resoutbound { get; set; }
        public int Resabandon { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
