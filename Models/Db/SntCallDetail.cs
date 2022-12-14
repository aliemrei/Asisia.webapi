using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class SntCallDetail : EntityBase 
    {
        [Column("CYEAR")]
        
        public int? Cyear { get; set; }


        [Column("CMONTH")]
        
        public int? Cmonth { get; set; }


        [Column("CDAY")]
        
        public int? Cday { get; set; }


        [Column("CDATE", TypeName = "date")]
        
        public DateTime? Cdate { get; set; }


        [Column("INBOUND")]
        
        public int? Inbound { get; set; }


        [Column("OUTBOUND")]
        
        public int? Outbound { get; set; }


        [Column("ANSWERED")]
        
        public int? Answered { get; set; }


        [Column("BUSY")]
        
        public int? Busy { get; set; }


        [Column("NOANSWER")]
        
        public int? Noanswer { get; set; }


        [Column("FAILED")]
        
        public int? Failed { get; set; }


        [Column("OTHERDEPARTMENT")]
        
        public int? Otherdepartment { get; set; }


        [Column("TRANSFERCALL")]
        [RequiredIf]
        public int Transfercall { get; set; }


        [Column("SENTQUEUE")]
        
        public int? Sentqueue { get; set; }


        [Column("ABANDON")]
        
        public int? Abandon { get; set; }


        [Column("userfield")]
        [StringLength(255)]
        [Unicode(false)]
        
        public string? Userfield { get; set; }


        [Column("event")]
        [StringLength(32)]
        
        public string? Event { get; set; }


        [Column("queuename")]
        [StringLength(32)]
        
        public string? Queuename { get; set; }


        [Column("agent")]
        [StringLength(32)]
        
        public string? Agent { get; set; }


        [Column("ENTERQUEUE")]
        
        public DateTime? Enterqueue { get; set; }


        [Column("calldate", TypeName = "datetime")]
        
        public DateTime? Calldate { get; set; }


        [Column("clid")]
        [StringLength(80)]
        [Unicode(false)]
        
        public string? Clid { get; set; }


        [Column("src")]
        [StringLength(80)]
        [Unicode(false)]
        
        public string? Src { get; set; }


        [Column("dst")]
        [StringLength(80)]
        [Unicode(false)]
        
        public string? Dst { get; set; }


        [Column("dcontext")]
        [StringLength(80)]
        [Unicode(false)]
        
        public string? Dcontext { get; set; }


        [Column("channel")]
        [StringLength(80)]
        [Unicode(false)]
        
        public string? Channel { get; set; }


        [Column("lastapp")]
        [StringLength(80)]
        [Unicode(false)]
        
        public string? Lastapp { get; set; }


        [Column("lastdata")]
        [StringLength(80)]
        [Unicode(false)]
        
        public string? Lastdata { get; set; }


        [Column("duration")]
        
        public int? Duration { get; set; }


        [Column("billsec")]
        
        public int? Billsec { get; set; }


        [Column("disposition")]
        [StringLength(45)]
        [Unicode(false)]
        
        public string? Disposition { get; set; }


        [Column("uniqueid")]
        [StringLength(150)]
        [Unicode(false)]
        
        public string? Uniqueid { get; set; }


        [Column("start", TypeName = "datetime")]
        
        public DateTime? Start { get; set; }


        [Column("end", TypeName = "datetime")]
        
        public DateTime? End { get; set; }


        [Column("answer", TypeName = "datetime")]
        
        public DateTime? Answer { get; set; }


        [Column("RESINBOUND")]
        
        public int? Resinbound { get; set; }


        [Column("RESOUTBOUND")]
        [RequiredIf]
        public int Resoutbound { get; set; }


        [Column("RESABANDON")]
        [RequiredIf]
        public int Resabandon { get; set; }



            }
}
