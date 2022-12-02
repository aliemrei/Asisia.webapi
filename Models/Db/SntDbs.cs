using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class SntDbs : EntityBase // My Handlebars Helper
    {
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("SWID")]
        public Guid Swid { get; set; }
        [Column("DENIFITION")]
        [StringLength(100)]
        public string Denifition { get; set; } = null!;
        [Column("TYPE")]
        [StringLength(15)]
        public string Type { get; set; } = null!;
        [Column("DATABASENAME")]
        [StringLength(50)]
        public string Databasename { get; set; } = null!;
        [Column("IPADDRESS")]
        [StringLength(30)]
        public string Ipaddress { get; set; } = null!;
        [Column("USERNAME")]
        [StringLength(30)]
        public string Username { get; set; } = null!;
        [Column("PASS")]
        [StringLength(30)]
        public string? Pass { get; set; }
        [Column("PORT")]
        public int Port { get; set; }
        [Column("EXTRA_PARAMS")]
        public string? ExtraParams { get; set; }
        [Column("sippeers")]
        public bool? Sippeers { get; set; }
        [Column("sipregs")]
        public bool? Sipregs { get; set; }
        [Column("extensions")]
        public bool? Extensions { get; set; }
        [Column("queues")]
        public bool? Queues { get; set; }
        [Column("queue_members")]
        public bool? QueueMembers { get; set; }
        [Column("queue_log")]
        public bool? QueueLog { get; set; }
        [Column("cdr_tds")]
        public bool? CdrTds { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
