using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class CallList : EntityBase // My Handlebars Helper
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("QUEUELOGID")]
        public int? Queuelogid { get; set; }
        [Column("CALLID")]
        [StringLength(32)]
        public string? Callid { get; set; }
        [Column("STATU")]
        public int Statu { get; set; }
        [Column("CALLTIME", TypeName = "datetime")]
        public DateTime? Calltime { get; set; }
        [Column("PRIORITY")]
        public int Priority { get; set; }
        [Column("TRYCOUNT")]
        public int Trycount { get; set; }
        [Column("PHONENUMBER")]
        [StringLength(50)]
        public string? Phonenumber { get; set; }
        [Column("KIND")]
        [StringLength(1)]
        [Unicode(false)]
        public string Kind { get; set; } = null!;
        [Column("DONTCALL")]
        public bool Dontcall { get; set; }
        [Column("OUTPUT_EXTEN")]
        [StringLength(150)]
        public string? OutputExten { get; set; }
        [Column("MAXTRYCOUNT")]
        public int Maxtrycount { get; set; }
        [Column("MAXTRYCOUNT_BUSY")]
        public int MaxtrycountBusy { get; set; }
        [Column("TRYCOUNT_BUSY")]
        public int TrycountBusy { get; set; }
        [Column("QAID")]
        public Guid? Qaid { get; set; }
        [Column("SDATE", TypeName = "datetime")]
        public DateTime Sdate { get; set; }
        [Column("JOBID")]
        public int? Jobid { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
