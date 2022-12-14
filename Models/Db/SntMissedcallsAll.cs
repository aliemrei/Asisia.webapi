using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class SntMissedcallsAll : EntityBase 
    {
        [Column("event")]
        [StringLength(32)]
        
        public string? Event { get; set; }


        
        public int? Id { get; set; }


        [Column("ISFINISHED")]
        
        public bool? Isfinished { get; set; }


        [Column("STATE")]
        [StringLength(25)]
        
        public string? State { get; set; }


        [Column("PHONE")]
        [StringLength(255)]
        
        public string? Phone { get; set; }


        [Column("CALLTIME", TypeName = "datetime")]
        
        public DateTime? Calltime { get; set; }


        [Column("KIND")]
        [StringLength(1)]
        [Unicode(false)]
        
        public string? Kind { get; set; }


        [Column("PHONENUMBER")]
        [StringLength(50)]
        
        public string? Phonenumber { get; set; }


        [Column("PRIORITY")]
        
        public int? Priority { get; set; }


        [Column("QUEUELOGID")]
        
        public int? Queuelogid { get; set; }


        [Column("TRYCOUNT")]
        
        public int? Trycount { get; set; }


        [Column("DONTCALL")]
        
        public bool? Dontcall { get; set; }


        [Column("OUTPUT_EXTEN")]
        [StringLength(150)]
        
        public string? OutputExten { get; set; }


        [Column("QUEUEID")]
        
        public Guid? Queueid { get; set; }


        [Column("QUEUENAME")]
        [StringLength(128)]
        [Unicode(false)]
        
        public string? Queuename { get; set; }


        [Column("MAXTRYCOUNT")]
        
        public int? Maxtrycount { get; set; }


        [Column("MAXTRYCOUNT_BUSY")]
        
        public int? MaxtrycountBusy { get; set; }


        [Column("TRYCOUNT_BUSY")]
        
        public int? TrycountBusy { get; set; }


        [Column("SDATE", TypeName = "datetime")]
        
        public DateTime? Sdate { get; set; }


        [Column("SORTFLD", TypeName = "datetime")]
        
        public DateTime? Sortfld { get; set; }


        [Column("agent")]
        [StringLength(80)]
        [Unicode(false)]
        
        public string? Agent { get; set; }


        [Column("QAID")]
        
        public Guid? Qaid { get; set; }


        [Column("callednumber")]
        [StringLength(50)]
        
        public string? Callednumber { get; set; }


        [Column("name")]
        [StringLength(100)]
        [Unicode(false)]
        
        public string? Name { get; set; }


        [Column("userfield")]
        [StringLength(255)]
        [Unicode(false)]
        
        public string? Userfield { get; set; }



            }
}
