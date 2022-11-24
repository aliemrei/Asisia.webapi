using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class SntDbs : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid Swid { get; set; }
        public string Denifition { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string Databasename { get; set; } = null!;
        public string Ipaddress { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string? Pass { get; set; }
        public int Port { get; set; }
        public string? ExtraParams { get; set; }
        public bool? Sippeers { get; set; }
        public bool? Sipregs { get; set; }
        public bool? Extensions { get; set; }
        public bool? Queues { get; set; }
        public bool? QueueMembers { get; set; }
        public bool? QueueLog { get; set; }
        public bool? CdrTds { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
