using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class SntQueues : EntityBase 
    {
        [Column("id")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("swid")]
        [RequiredIf]
        public Guid Swid { get; set; }


        [Column("name")]
        [StringLength(128)]
        [Unicode(false)]
        [RequiredIf]
        public string Name { get; set; } = null!;


        [Column("musiconhold")]
        [StringLength(128)]
        [Unicode(false)]
        
        public string? Musiconhold { get; set; }


        [Column("announce")]
        [StringLength(128)]
        [Unicode(false)]
        
        public string? Announce { get; set; }


        [Column("context")]
        [StringLength(128)]
        [Unicode(false)]
        
        public string? Context { get; set; }


        [Column("timeout")]
        
        public int? Timeout { get; set; }


        [Column("monitor_join")]
        
        public bool? MonitorJoin { get; set; }


        [Column("monitor_format")]
        [StringLength(128)]
        [Unicode(false)]
        
        public string? MonitorFormat { get; set; }


        [Column("queue_youarenext")]
        [StringLength(128)]
        [Unicode(false)]
        
        public string? QueueYouarenext { get; set; }


        [Column("queue_thereare")]
        [StringLength(128)]
        [Unicode(false)]
        
        public string? QueueThereare { get; set; }


        [Column("queue_callswaiting")]
        [StringLength(128)]
        [Unicode(false)]
        
        public string? QueueCallswaiting { get; set; }


        [Column("queue_holdtime")]
        [StringLength(128)]
        [Unicode(false)]
        
        public string? QueueHoldtime { get; set; }


        [Column("queue_minutes")]
        [StringLength(128)]
        [Unicode(false)]
        
        public string? QueueMinutes { get; set; }


        [Column("queue_seconds")]
        [StringLength(128)]
        [Unicode(false)]
        
        public string? QueueSeconds { get; set; }


        [Column("queue_lessthan")]
        [StringLength(128)]
        [Unicode(false)]
        
        public string? QueueLessthan { get; set; }


        [Column("queue_thankyou")]
        [StringLength(128)]
        [Unicode(false)]
        
        public string? QueueThankyou { get; set; }


        [Column("queue_reporthold")]
        [StringLength(128)]
        [Unicode(false)]
        
        public string? QueueReporthold { get; set; }


        [Column("announce_frequency")]
        
        public int? AnnounceFrequency { get; set; }


        [Column("announce_round_seconds")]
        
        public int? AnnounceRoundSeconds { get; set; }


        [Column("announce_holdtime")]
        [StringLength(128)]
        [Unicode(false)]
        
        public string? AnnounceHoldtime { get; set; }


        [Column("retry")]
        
        public int? Retry { get; set; }


        [Column("wrapuptime")]
        
        public int? Wrapuptime { get; set; }


        [Column("maxlen")]
        
        public int? Maxlen { get; set; }


        [Column("servicelevel")]
        
        public int? Servicelevel { get; set; }


        [Column("strategy")]
        [StringLength(128)]
        [Unicode(false)]
        
        public string? Strategy { get; set; }


        [Column("joinempty")]
        [StringLength(128)]
        [Unicode(false)]
        
        public string? Joinempty { get; set; }


        [Column("leavewhenempty")]
        [StringLength(128)]
        [Unicode(false)]
        
        public string? Leavewhenempty { get; set; }


        [Column("eventmemberstatus")]
        
        public bool? Eventmemberstatus { get; set; }


        [Column("eventwhencalled")]
        
        public bool? Eventwhencalled { get; set; }


        [Column("reportholdtime")]
        
        public bool? Reportholdtime { get; set; }


        [Column("memberdelay")]
        
        public int? Memberdelay { get; set; }


        [Column("weight")]
        
        public int? Weight { get; set; }


        [Column("timeoutrestart")]
        
        public bool? Timeoutrestart { get; set; }


        [Column("periodic_announce")]
        [StringLength(50)]
        [Unicode(false)]
        
        public string? PeriodicAnnounce { get; set; }


        [Column("periodic_announce_frequency")]
        
        public int? PeriodicAnnounceFrequency { get; set; }


        [Column("ringinuse")]
        
        public bool? Ringinuse { get; set; }


        [Column("setinterfacevar")]
        
        public bool? Setinterfacevar { get; set; }


        [Column("corpid")]
        
        public Guid? Corpid { get; set; }


        [Column("abandoncallback_exten")]
        
        public int? AbandoncallbackExten { get; set; }


        [Column("jobstart")]
        [RequiredIf]
        public int Jobstart { get; set; }


        [Column("jobend")]
        [RequiredIf]
        public int Jobend { get; set; }


        [Column("isdisabled")]
        [RequiredIf]
        public bool Isdisabled { get; set; }


        [Column("autofill")]
        [StringLength(15)]
        [RequiredIf]
        public string Autofill { get; set; } = null!;


        [Column("autopause")]
        [StringLength(15)]
        [RequiredIf]
        public string Autopause { get; set; } = null!;



            }
}
