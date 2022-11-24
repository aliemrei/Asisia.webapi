using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class SntCalls : EntityBase // My Handlebars Helper
    {
        public string? Agent { get; set; }
        public string? Phonenumber { get; set; }
        public Guid? Id { get; set; }
        public string? Fullname { get; set; }
        public string? Projectgroup { get; set; }
        public string Chn { get; set; } = null!;
        public string Phn { get; set; } = null!;
        public string Uniqueid { get; set; } = null!;
        public DateTime Calldate { get; set; }
        public string Clid { get; set; } = null!;
        public string Src { get; set; } = null!;
        public string Dst { get; set; } = null!;
        public string Dcontext { get; set; } = null!;
        public string Channel { get; set; } = null!;
        public string Dstchannel { get; set; } = null!;
        public string? Lastapp { get; set; }
        public string Lastdata { get; set; } = null!;
        public int Duration { get; set; }
        public int Billsec { get; set; }
        public string Disposition { get; set; } = null!;
        public string Amaflags { get; set; } = null!;
        public string Accountcode { get; set; } = null!;
        public string Userfield { get; set; } = null!;
        public DateTime? Start { get; set; }
        public DateTime? Answer { get; set; }
        public DateTime? End { get; set; }
        public string? Callednumber { get; set; }
        public string? Callerid { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
