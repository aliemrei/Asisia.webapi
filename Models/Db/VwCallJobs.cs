using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class VwCallJobs : EntityBase 
    {
        [RequiredIf]
        public int Id { get; set; }


        [Column("ISFINISHED")]
        
        public bool? Isfinished { get; set; }


        [Column("STATE")]
        [StringLength(25)]
        
        public string? State { get; set; }


        [Column("CALLNUMBER")]
        
        public long? Callnumber { get; set; }


        [Column("CALLTIME", TypeName = "datetime")]
        
        public DateTime? Calltime { get; set; }


        [Column("KIND")]
        [StringLength(1)]
        [Unicode(false)]
        [RequiredIf]
        public string Kind { get; set; } = null!;


        [Column("PHONENUMBER")]
        [StringLength(50)]
        
        public string? Phonenumber { get; set; }


        [Column("PRIORITY")]
        [RequiredIf]
        public int Priority { get; set; }


        [Column("QUEUELOGID")]
        
        public int? Queuelogid { get; set; }


        [Column("TRYCOUNT")]
        [RequiredIf]
        public int Trycount { get; set; }


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


        [Column("SDATE", TypeName = "datetime")]
        [RequiredIf]
        public DateTime Sdate { get; set; }


        [Column("FULLNAME")]
        [StringLength(200)]
        
        public string? Fullname { get; set; }


        [Column("FIRSTNAME")]
        [StringLength(70)]
        
        public string? Firstname { get; set; }


        [Column("LASTNAME")]
        [StringLength(70)]
        
        public string? Lastname { get; set; }


        [Column("USERNAME")]
        [StringLength(100)]
        
        public string? Username { get; set; }


        [Column("CAMPAIGNCODE")]
        [StringLength(100)]
        
        public string? Campaigncode { get; set; }


        [Column("REASON")]
        [StringLength(33)]
        [Unicode(false)]
        
        public string? Reason { get; set; }


        [Column("SORTFLD", TypeName = "datetime")]
        
        public DateTime? Sortfld { get; set; }


        [Column("jobstart")]
        
        public int? Jobstart { get; set; }


        [Column("jobend")]
        
        public int? Jobend { get; set; }


        [Column("JOBID")]
        
        public int? Jobid { get; set; }


        [Column("DESCRIPTION")]
        
        public string? Description { get; set; }


        [Column("PROJECT_GROUPID")]
        
        public Guid? ProjectGroupid { get; set; }


        [Column("PROJECT_DETAILID")]
        
        public Guid? ProjectDetailid { get; set; }


        [Column("PERSONID")]
        
        public Guid? Personid { get; set; }



            }
}
