using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class VwCallJobs : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public bool? Isfinished { get; set; }
        public string? State { get; set; }
        public long? Callnumber { get; set; }
        public DateTime? Calltime { get; set; }
        public string Kind { get; set; } = null!;
        public string? Phonenumber { get; set; }
        public int Priority { get; set; }
        public int? Queuelogid { get; set; }
        public int Trycount { get; set; }
        public bool Dontcall { get; set; }
        public string? OutputExten { get; set; }
        public int Maxtrycount { get; set; }
        public int MaxtrycountBusy { get; set; }
        public int TrycountBusy { get; set; }
        public DateTime Sdate { get; set; }
        public string? Fullname { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Username { get; set; }
        public string? Campaigncode { get; set; }
        public string? Reason { get; set; }
        public DateTime? Sortfld { get; set; }
        public int? Jobstart { get; set; }
        public int? Jobend { get; set; }
        public int? Jobid { get; set; }
        public string? Description { get; set; }
        public Guid? ProjectGroupid { get; set; }
        public Guid? ProjectDetailid { get; set; }
        public Guid? Personid { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
