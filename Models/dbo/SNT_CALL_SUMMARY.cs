using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class SNT_CALL_SUMMARY : EntityBase // My Handlebars Helper
    {
        public DateTime? CDATE { get; set; }
        public int? CALLCOUNT { get; set; }
        public string? CALLTIME { get; set; }
        public int? DURATION { get; set; }
        public int? INBOUND { get; set; }
        public int? INBOUND_SINGLE { get; set; }
        public int? OTHERDEPARTMENT { get; set; }
        public int? RESINBOUND { get; set; }
        public int? RESINBOUND_DURATION { get; set; }
        public string? RESCALLTIME { get; set; }
        public int? ABANDON { get; set; }
        public int? TRANSFERCALL { get; set; }
        public int? RESOUTBOUND { get; set; }
        public int? ANSWERED { get; set; }
        public int? BUSY { get; set; }
        public int? NOANSWER { get; set; }
        public int? FAILED { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
