using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class SNT_QUEUES : EntityBase // My Handlebars Helper
    {
        public Guid id { get; set; }
        public Guid swid { get; set; }
        public string name { get; set; } = null!;
        public string? musiconhold { get; set; }
        public string? announce { get; set; }
        public string? context { get; set; }
        public int? timeout { get; set; }
        public bool? monitor_join { get; set; }
        public string? monitor_format { get; set; }
        public string? queue_youarenext { get; set; }
        public string? queue_thereare { get; set; }
        public string? queue_callswaiting { get; set; }
        public string? queue_holdtime { get; set; }
        public string? queue_minutes { get; set; }
        public string? queue_seconds { get; set; }
        public string? queue_lessthan { get; set; }
        public string? queue_thankyou { get; set; }
        public string? queue_reporthold { get; set; }
        public int? announce_frequency { get; set; }
        public int? announce_round_seconds { get; set; }
        public string? announce_holdtime { get; set; }
        public int? retry { get; set; }
        public int? wrapuptime { get; set; }
        public int? maxlen { get; set; }
        public int? servicelevel { get; set; }
        public string? strategy { get; set; }
        public string? joinempty { get; set; }
        public string? leavewhenempty { get; set; }
        public bool? eventmemberstatus { get; set; }
        public bool? eventwhencalled { get; set; }
        public bool? reportholdtime { get; set; }
        public int? memberdelay { get; set; }
        public int? weight { get; set; }
        public bool? timeoutrestart { get; set; }
        public string? periodic_announce { get; set; }
        public int? periodic_announce_frequency { get; set; }
        public bool? ringinuse { get; set; }
        public bool? setinterfacevar { get; set; }
        public Guid? corpid { get; set; }
        public int? abandoncallback_exten { get; set; }
        public int jobstart { get; set; }
        public int jobend { get; set; }
        public bool isdisabled { get; set; }
        public string autofill { get; set; } = null!;
        public string autopause { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
