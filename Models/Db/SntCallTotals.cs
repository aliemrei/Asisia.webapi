using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class SntCallTotals : EntityBase 
    {
        [Column("CDATE", TypeName = "date")]
        
        public DateTime? Cdate { get; set; }


        [Column("CDAY")]
        
        public int? Cday { get; set; }


        [Column("CMONTHNAME")]
        [StringLength(7)]
        [Unicode(false)]
        
        public string? Cmonthname { get; set; }


        [Column("CYEAR")]
        
        public int? Cyear { get; set; }


        [Column("CDAYNAME")]
        [StringLength(9)]
        [Unicode(false)]
        
        public string? Cdayname { get; set; }


        [Column("CWEEK")]
        
        public int? Cweek { get; set; }


        [Column("CAMPAIGN")]
        [StringLength(100)]
        
        public string? Campaign { get; set; }


        [Column("PROJECTNAME")]
        [StringLength(150)]
        
        public string? Projectname { get; set; }


        [Column("PRODUCTNAME")]
        [StringLength(200)]
        
        public string? Productname { get; set; }


        [Column("CALLCOUNT")]
        
        public int? Callcount { get; set; }


        [Column("ANSWEREDCALL")]
        
        public int? Answeredcall { get; set; }


        [Column("ABANDONCALL")]
        
        public int? Abandoncall { get; set; }


        [Column("TOTALREALDURATION")]
        
        public int? Totalrealduration { get; set; }


        [Column("TOTALDURATION")]
        
        public int? Totalduration { get; set; }


        [Column("MAXREALDURATION")]
        
        public int? Maxrealduration { get; set; }


        [Column("MAXDURATION")]
        
        public int? Maxduration { get; set; }


        [Column("AVGREALDURATION")]
        
        public int? Avgrealduration { get; set; }


        [Column("AVGDURATION")]
        
        public int? Avgduration { get; set; }


        [Column("TOTALWAIT")]
        
        public int? Totalwait { get; set; }


        [Column("MAXWAIT")]
        
        public int? Maxwait { get; set; }


        [Column("AVGWAIT")]
        
        public int? Avgwait { get; set; }


        [Column("ANSWERED_TOTALWAIT")]
        
        public int? AnsweredTotalwait { get; set; }


        [Column("ANSWERED_AVGWAIT")]
        
        public int? AnsweredAvgwait { get; set; }


        [Column("ANSWERED_MAXWAIT")]
        
        public int? AnsweredMaxwait { get; set; }


        [Column("ABANDON_TOTALWAIT")]
        
        public int? AbandonTotalwait { get; set; }


        [Column("ABANDON_AVGWAIT")]
        
        public int? AbandonAvgwait { get; set; }


        [Column("ABANDON_MAXWAIT")]
        
        public int? AbandonMaxwait { get; set; }



            }
}
