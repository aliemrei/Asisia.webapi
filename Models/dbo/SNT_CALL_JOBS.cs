using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class SNT_CALL_JOBS : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public bool? ISFINISHED { get; set; }
        public string? STATE { get; set; }
        public long? CALLNUMBER { get; set; }
        public DateTime? CALLTIME { get; set; }
        public string KIND { get; set; } = null!;
        public string? PHONENUMBER { get; set; }
        public int PRIORITY { get; set; }
        public int? QUEUELOGID { get; set; }
        public int TRYCOUNT { get; set; }
        public bool DONTCALL { get; set; }
        public string? OUTPUT_EXTEN { get; set; }
        public int MAXTRYCOUNT { get; set; }
        public int MAXTRYCOUNT_BUSY { get; set; }
        public int TRYCOUNT_BUSY { get; set; }
        public DateTime SDATE { get; set; }
        public string? FULLNAME { get; set; }
        public string? USERNAME { get; set; }
        public string? CAMPAIGNCODE { get; set; }
        public string? REASON { get; set; }
        public DateTime? SORTFLD { get; set; }
        public int? jobstart { get; set; }
        public int? jobend { get; set; }
        public Guid? QAID { get; set; }
        public string? QUEUENAME { get; set; }
        public Guid? PROJECT_GROUPID { get; set; }
        public Guid? PROJECT_DETAILID { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
