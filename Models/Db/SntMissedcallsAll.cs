using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class SntMissedcallsAll : EntityBase // My Handlebars Helper
    {
        public string? Event { get; set; }
        public int? Id { get; set; }
        public bool? Isfinished { get; set; }
        public string? State { get; set; }
        public string? Phone { get; set; }
        public DateTime? Calltime { get; set; }
        public string? Kind { get; set; }
        public string? Phonenumber { get; set; }
        public int? Priority { get; set; }
        public int? Queuelogid { get; set; }
        public int? Trycount { get; set; }
        public bool? Dontcall { get; set; }
        public string? OutputExten { get; set; }
        public Guid? Queueid { get; set; }
        public string? Queuename { get; set; }
        public int? Maxtrycount { get; set; }
        public int? MaxtrycountBusy { get; set; }
        public int? TrycountBusy { get; set; }
        public DateTime? Sdate { get; set; }
        public DateTime? Sortfld { get; set; }
        public string? Agent { get; set; }
        public Guid? Qaid { get; set; }
        public string? Callednumber { get; set; }
        public string? Name { get; set; }
        public string? Userfield { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
