using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class SntCallListOrg : EntityBase 
    {
        [Column("ID")]
        [RequiredIf]
        public int Id { get; set; }


        [Column("QUEUELOGID")]
        
        public int? Queuelogid { get; set; }


        [Column("CALLID")]
        [StringLength(32)]
        
        public string? Callid { get; set; }


        [Column("STATU")]
        [RequiredIf]
        public int Statu { get; set; }


        [Column("CALLTIME", TypeName = "datetime")]
        
        public DateTime? Calltime { get; set; }


        [Column("PRIORITY")]
        [RequiredIf]
        public int Priority { get; set; }


        [Column("TRYCOUNT")]
        [RequiredIf]
        public int Trycount { get; set; }


        [Column("PHONENUMBER")]
        [StringLength(50)]
        
        public string? Phonenumber { get; set; }


        [Column("KIND")]
        [StringLength(1)]
        [Unicode(false)]
        [RequiredIf]
        public string Kind { get; set; } = null!;


        [Column("DONTCALL")]
        [RequiredIf]
        public bool Dontcall { get; set; }


        [Column("OUTPUT_EXTEN")]
        [StringLength(150)]
        
        public string? OutputExten { get; set; }


        [Column("MAXTRYCOUNT")]
        [RequiredIf]
        public int Maxtrycount { get; set; }


        [Column("MAXTRYCOUNT_BUSY")]
        [RequiredIf]
        public int MaxtrycountBusy { get; set; }


        [Column("TRYCOUNT_BUSY")]
        [RequiredIf]
        public int TrycountBusy { get; set; }


        [Column("QAID")]
        
        public Guid? Qaid { get; set; }


        [Column("SDATE", TypeName = "datetime")]
        [RequiredIf]
        public DateTime Sdate { get; set; }


        [Column("JOBID")]
        
        public int? Jobid { get; set; }



            }
}
