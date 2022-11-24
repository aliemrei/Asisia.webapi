using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class SntCallList : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public string Type { get; set; } = null!;
        public string? Phonenumber { get; set; }
        public string? Phone { get; set; }
        public bool? Isfinished { get; set; }
        public bool Dontcall { get; set; }
        public DateTime? Calltime { get; set; }
        public string? OutputExten { get; set; }
        public int Priority { get; set; }
        public int? Jostart { get; set; }
        public int? Jobend { get; set; }
        public string? Agent { get; set; }
        public DateTime? LastCalltime { get; set; }
        public Guid? Qaid { get; set; }
        public Guid Queueid { get; set; }
        public string? Queuename { get; set; }
        public string? State { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
