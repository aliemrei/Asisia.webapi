using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class SNT_MISSEDCALLS_ALL : EntityBase // My Handlebars Helper
    {
        public string? _event { get; set; }
        public int? Id { get; set; }
        public bool? ISFINISHED { get; set; }
        public string? STATE { get; set; }
        public string? PHONE { get; set; }
        public DateTime? CALLTIME { get; set; }
        public string? KIND { get; set; }
        public string? PHONENUMBER { get; set; }
        public int? PRIORITY { get; set; }
        public int? QUEUELOGID { get; set; }
        public int? TRYCOUNT { get; set; }
        public bool? DONTCALL { get; set; }
        public string? OUTPUT_EXTEN { get; set; }
        public Guid? QUEUEID { get; set; }
        public string? QUEUENAME { get; set; }
        public int? MAXTRYCOUNT { get; set; }
        public int? MAXTRYCOUNT_BUSY { get; set; }
        public int? TRYCOUNT_BUSY { get; set; }
        public DateTime? SDATE { get; set; }
        public DateTime? SORTFLD { get; set; }
        public string? agent { get; set; }
        public Guid? QAID { get; set; }
        public string? callednumber { get; set; }
        public string? name { get; set; }
        public string? userfield { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
