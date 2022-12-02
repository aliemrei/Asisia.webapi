using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class SntCallList : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        [Column("TYPE")]
        [StringLength(1)]
        [Unicode(false)]
        public string Type { get; set; } = null!;
        [Column("PHONENUMBER")]
        [StringLength(50)]
        public string? Phonenumber { get; set; }
        [Column("PHONE")]
        [StringLength(255)]
        public string? Phone { get; set; }
        [Column("ISFINISHED")]
        public bool? Isfinished { get; set; }
        [Column("DONTCALL")]
        public bool Dontcall { get; set; }
        [Column("CALLTIME", TypeName = "datetime")]
        public DateTime? Calltime { get; set; }
        [Column("OUTPUT_EXTEN")]
        [StringLength(150)]
        public string? OutputExten { get; set; }
        [Column("PRIORITY")]
        public int Priority { get; set; }
        [Column("JOSTART")]
        public int? Jostart { get; set; }
        [Column("JOBEND")]
        public int? Jobend { get; set; }
        [Column("AGENT")]
        [StringLength(100)]
        public string? Agent { get; set; }
        [Column("LAST_CALLTIME", TypeName = "datetime")]
        public DateTime? LastCalltime { get; set; }
        [Column("QAID")]
        public Guid? Qaid { get; set; }
        [Column("QUEUEID")]
        public Guid Queueid { get; set; }
        [Column("QUEUENAME")]
        [StringLength(128)]
        [Unicode(false)]
        public string? Queuename { get; set; }
        [Column("STATE")]
        [StringLength(25)]
        public string? State { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
