using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class SNT_DBS : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid SWID { get; set; }
        public string DENIFITION { get; set; } = null!;
        public string TYPE { get; set; } = null!;
        public string DATABASENAME { get; set; } = null!;
        public string IPADDRESS { get; set; } = null!;
        public string USERNAME { get; set; } = null!;
        public string? PASS { get; set; }
        public int PORT { get; set; }
        public string? EXTRA_PARAMS { get; set; }
        public bool? sippeers { get; set; }
        public bool? sipregs { get; set; }
        public bool? extensions { get; set; }
        public bool? queues { get; set; }
        public bool? queue_members { get; set; }
        public bool? queue_log { get; set; }
        public bool? cdr_tds { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
