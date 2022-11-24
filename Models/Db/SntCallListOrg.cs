using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class SntCallListOrg : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public int? Queuelogid { get; set; }
        public string? Callid { get; set; }
        public int Statu { get; set; }
        public DateTime? Calltime { get; set; }
        public int Priority { get; set; }
        public int Trycount { get; set; }
        public string? Phonenumber { get; set; }
        public string Kind { get; set; } = null!;
        public bool Dontcall { get; set; }
        public string? OutputExten { get; set; }
        public int Maxtrycount { get; set; }
        public int MaxtrycountBusy { get; set; }
        public int TrycountBusy { get; set; }
        public Guid? Qaid { get; set; }
        public DateTime Sdate { get; set; }
        public int? Jobid { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
