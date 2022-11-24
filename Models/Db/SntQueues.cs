using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class SntQueues : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid Swid { get; set; }
        public string Name { get; set; } = null!;
        public string? Musiconhold { get; set; }
        public string? Announce { get; set; }
        public string? Context { get; set; }
        public int? Timeout { get; set; }
        public bool? MonitorJoin { get; set; }
        public string? MonitorFormat { get; set; }
        public string? QueueYouarenext { get; set; }
        public string? QueueThereare { get; set; }
        public string? QueueCallswaiting { get; set; }
        public string? QueueHoldtime { get; set; }
        public string? QueueMinutes { get; set; }
        public string? QueueSeconds { get; set; }
        public string? QueueLessthan { get; set; }
        public string? QueueThankyou { get; set; }
        public string? QueueReporthold { get; set; }
        public int? AnnounceFrequency { get; set; }
        public int? AnnounceRoundSeconds { get; set; }
        public string? AnnounceHoldtime { get; set; }
        public int? Retry { get; set; }
        public int? Wrapuptime { get; set; }
        public int? Maxlen { get; set; }
        public int? Servicelevel { get; set; }
        public string? Strategy { get; set; }
        public string? Joinempty { get; set; }
        public string? Leavewhenempty { get; set; }
        public bool? Eventmemberstatus { get; set; }
        public bool? Eventwhencalled { get; set; }
        public bool? Reportholdtime { get; set; }
        public int? Memberdelay { get; set; }
        public int? Weight { get; set; }
        public bool? Timeoutrestart { get; set; }
        public string? PeriodicAnnounce { get; set; }
        public int? PeriodicAnnounceFrequency { get; set; }
        public bool? Ringinuse { get; set; }
        public bool? Setinterfacevar { get; set; }
        public Guid? Corpid { get; set; }
        public int? AbandoncallbackExten { get; set; }
        public int Jobstart { get; set; }
        public int Jobend { get; set; }
        public bool Isdisabled { get; set; }
        public string Autofill { get; set; } = null!;
        public string Autopause { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
