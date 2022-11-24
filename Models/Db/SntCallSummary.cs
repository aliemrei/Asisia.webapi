using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class SntCallSummary : EntityBase // My Handlebars Helper
    {
        public DateTime? Cdate { get; set; }
        public int? Callcount { get; set; }
        public string? Calltime { get; set; }
        public int? Duration { get; set; }
        public int? Inbound { get; set; }
        public int? InboundSingle { get; set; }
        public int? Otherdepartment { get; set; }
        public int? Resinbound { get; set; }
        public int? ResinboundDuration { get; set; }
        public string? Rescalltime { get; set; }
        public int? Abandon { get; set; }
        public int? Transfercall { get; set; }
        public int? Resoutbound { get; set; }
        public int? Answered { get; set; }
        public int? Busy { get; set; }
        public int? Noanswer { get; set; }
        public int? Failed { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
