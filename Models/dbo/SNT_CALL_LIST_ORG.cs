using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class SNT_CALL_LIST_ORG : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public int? QUEUELOGID { get; set; }
        public string? CALLID { get; set; }
        public int STATU { get; set; }
        public DateTime? CALLTIME { get; set; }
        public int PRIORITY { get; set; }
        public int TRYCOUNT { get; set; }
        public string? PHONENUMBER { get; set; }
        public string KIND { get; set; } = null!;
        public bool DONTCALL { get; set; }
        public string? OUTPUT_EXTEN { get; set; }
        public int MAXTRYCOUNT { get; set; }
        public int MAXTRYCOUNT_BUSY { get; set; }
        public int TRYCOUNT_BUSY { get; set; }
        public Guid? QAID { get; set; }
        public DateTime SDATE { get; set; }
        public int? JOBID { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
