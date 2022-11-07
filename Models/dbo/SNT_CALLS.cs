using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class SNT_CALLS : EntityBase // My Handlebars Helper
    {
        public string? AGENT { get; set; }
        public string? PHONENUMBER { get; set; }
        public Guid? ID { get; set; }
        public string? FULLNAME { get; set; }
        public string? PROJECTGROUP { get; set; }
        public string CHN { get; set; } = null!;
        public string PHN { get; set; } = null!;
        public string uniqueid { get; set; } = null!;
        public DateTime calldate { get; set; }
        public string clid { get; set; } = null!;
        public string src { get; set; } = null!;
        public string dst { get; set; } = null!;
        public string dcontext { get; set; } = null!;
        public string channel { get; set; } = null!;
        public string dstchannel { get; set; } = null!;
        public string? lastapp { get; set; }
        public string lastdata { get; set; } = null!;
        public int duration { get; set; }
        public int billsec { get; set; }
        public string disposition { get; set; } = null!;
        public string amaflags { get; set; } = null!;
        public string accountcode { get; set; } = null!;
        public string userfield { get; set; } = null!;
        public DateTime? start { get; set; }
        public DateTime? answer { get; set; }
        public DateTime? end { get; set; }
        public string? callednumber { get; set; }
        public string? callerid { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
