using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class SntCalls : EntityBase // My Handlebars Helper
    {
        [Column("AGENT")]
        [StringLength(80)]
        [Unicode(false)]
        public string? Agent { get; set; }
        [Column("PHONENUMBER")]
        [StringLength(30)]
        public string? Phonenumber { get; set; }
        [Column("ID")]
        public Guid? Id { get; set; }
        [Column("FULLNAME")]
        [StringLength(212)]
        public string? Fullname { get; set; }
        [Column("PROJECTGROUP")]
        [StringLength(150)]
        public string? Projectgroup { get; set; }
        [Column("CHN")]
        [StringLength(80)]
        [Unicode(false)]
        public string Chn { get; set; } = null!;
        [Column("PHN")]
        [StringLength(80)]
        [Unicode(false)]
        public string Phn { get; set; } = null!;
        [Column("uniqueid")]
        [StringLength(150)]
        [Unicode(false)]
        public string Uniqueid { get; set; } = null!;
        [Column("calldate", TypeName = "datetime")]
        public DateTime Calldate { get; set; }
        [Column("clid")]
        [StringLength(80)]
        [Unicode(false)]
        public string Clid { get; set; } = null!;
        [Column("src")]
        [StringLength(80)]
        [Unicode(false)]
        public string Src { get; set; } = null!;
        [Column("dst")]
        [StringLength(80)]
        [Unicode(false)]
        public string Dst { get; set; } = null!;
        [Column("dcontext")]
        [StringLength(80)]
        [Unicode(false)]
        public string Dcontext { get; set; } = null!;
        [Column("channel")]
        [StringLength(80)]
        [Unicode(false)]
        public string Channel { get; set; } = null!;
        [Column("dstchannel")]
        [StringLength(80)]
        [Unicode(false)]
        public string Dstchannel { get; set; } = null!;
        [Column("lastapp")]
        [StringLength(80)]
        [Unicode(false)]
        public string? Lastapp { get; set; }
        [Column("lastdata")]
        [StringLength(80)]
        [Unicode(false)]
        public string Lastdata { get; set; } = null!;
        [Column("duration")]
        public int Duration { get; set; }
        [Column("billsec")]
        public int Billsec { get; set; }
        [Column("disposition")]
        [StringLength(45)]
        [Unicode(false)]
        public string Disposition { get; set; } = null!;
        [Column("amaflags")]
        [StringLength(50)]
        [Unicode(false)]
        public string Amaflags { get; set; } = null!;
        [Column("accountcode")]
        [StringLength(20)]
        [Unicode(false)]
        public string Accountcode { get; set; } = null!;
        [Column("userfield")]
        [StringLength(255)]
        [Unicode(false)]
        public string Userfield { get; set; } = null!;
        [Column("start", TypeName = "datetime")]
        public DateTime? Start { get; set; }
        [Column("answer", TypeName = "datetime")]
        public DateTime? Answer { get; set; }
        [Column("end", TypeName = "datetime")]
        public DateTime? End { get; set; }
        [Column("callednumber")]
        [StringLength(50)]
        public string? Callednumber { get; set; }
        [Column("callerid")]
        [StringLength(30)]
        public string? Callerid { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
