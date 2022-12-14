using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class SntCallSummary : EntityBase 
    {
        [Column("CDATE", TypeName = "date")]
        
        public DateTime? Cdate { get; set; }


        [Column("CALLCOUNT")]
        
        public int? Callcount { get; set; }


        [Column("CALLTIME")]
        [StringLength(53)]
        
        public string? Calltime { get; set; }


        [Column("DURATION")]
        
        public int? Duration { get; set; }


        [Column("INBOUND")]
        
        public int? Inbound { get; set; }


        [Column("INBOUND_SINGLE")]
        
        public int? InboundSingle { get; set; }


        [Column("OTHERDEPARTMENT")]
        
        public int? Otherdepartment { get; set; }


        [Column("RESINBOUND")]
        
        public int? Resinbound { get; set; }


        [Column("RESINBOUND_DURATION")]
        
        public int? ResinboundDuration { get; set; }


        [Column("RESCALLTIME")]
        [StringLength(53)]
        
        public string? Rescalltime { get; set; }


        [Column("ABANDON")]
        
        public int? Abandon { get; set; }


        [Column("TRANSFERCALL")]
        
        public int? Transfercall { get; set; }


        [Column("RESOUTBOUND")]
        
        public int? Resoutbound { get; set; }


        [Column("ANSWERED")]
        
        public int? Answered { get; set; }


        [Column("BUSY")]
        
        public int? Busy { get; set; }


        [Column("NOANSWER")]
        
        public int? Noanswer { get; set; }


        [Column("FAILED")]
        
        public int? Failed { get; set; }



            }
}
