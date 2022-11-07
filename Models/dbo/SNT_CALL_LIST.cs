using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class SNT_CALL_LIST : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public string TYPE { get; set; } = null!;
        public string? PHONENUMBER { get; set; }
        public string? PHONE { get; set; }
        public bool? ISFINISHED { get; set; }
        public bool DONTCALL { get; set; }
        public DateTime? CALLTIME { get; set; }
        public string? OUTPUT_EXTEN { get; set; }
        public int PRIORITY { get; set; }
        public int? JOSTART { get; set; }
        public int? JOBEND { get; set; }
        public string? AGENT { get; set; }
        public DateTime? LAST_CALLTIME { get; set; }
        public Guid? QAID { get; set; }
        public Guid QUEUEID { get; set; }
        public string? QUEUENAME { get; set; }
        public string? STATE { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
