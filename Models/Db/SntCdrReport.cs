using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class SntCdrReport : EntityBase 
    {
        [Column("PERSONNAME")]
        [StringLength(212)]
        
        public string? Personname { get; set; }


        [Column("PERSONID")]
        
        public Guid? Personid { get; set; }


        [Column("uniqueid")]
        [StringLength(150)]
        [Unicode(false)]
        [RequiredIf]
        public string Uniqueid { get; set; } = null!;


        [Column("src")]
        [StringLength(80)]
        [Unicode(false)]
        [RequiredIf]
        public string Src { get; set; } = null!;


        [Column("CAMPAIGN")]
        [StringLength(100)]
        
        public string? Campaign { get; set; }


        [Column("PROJECTNAME")]
        [StringLength(150)]
        
        public string? Projectname { get; set; }


        [Column("PRODUCTNAME")]
        [StringLength(200)]
        
        public string? Productname { get; set; }


        [Column("PEERNAME")]
        [StringLength(80)]
        [Unicode(false)]
        
        public string? Peername { get; set; }


        [Column("userfield")]
        [StringLength(255)]
        [Unicode(false)]
        [RequiredIf]
        public string Userfield { get; set; } = null!;


        [Column("disposition")]
        [StringLength(45)]
        [Unicode(false)]
        [RequiredIf]
        public string Disposition { get; set; } = null!;


        [Column("exten")]
        [StringLength(50)]
        [Unicode(false)]
        
        public string? Exten { get; set; }


        [Column("callednumber")]
        [StringLength(50)]
        
        public string? Callednumber { get; set; }


        [Column("ISOUTBOUND")]
        [RequiredIf]
        public int Isoutbound { get; set; }


        [Column("CWEEK")]
        
        public int? Cweek { get; set; }


        [Column("CWEEKDAY")]
        
        public int? Cweekday { get; set; }


        [Column("DAYOFWEEK")]
        
        public byte? Dayofweek { get; set; }


        [Column("CDAYNAME")]
        [StringLength(9)]
        [Unicode(false)]
        
        public string? Cdayname { get; set; }


        [Column("CMONTHNAME")]
        [StringLength(7)]
        [Unicode(false)]
        
        public string? Cmonthname { get; set; }


        [Column("CDAYOFYEAR")]
        
        public int? Cdayofyear { get; set; }


        [Column("CYEAR")]
        
        public int? Cyear { get; set; }


        [Column("CMONTH")]
        
        public int? Cmonth { get; set; }


        [Column("CDAY")]
        
        public int? Cday { get; set; }


        [Column("CHOUR")]
        
        public int? Chour { get; set; }


        [Column("CMINUTE")]
        
        public int? Cminute { get; set; }


        [Column("CDATE", TypeName = "datetime")]
        [RequiredIf]
        public DateTime Cdate { get; set; }


        [Column("duration")]
        [RequiredIf]
        public int Duration { get; set; }


        [Column("billsec")]
        [RequiredIf]
        public int Billsec { get; set; }


        [Column("start", TypeName = "datetime")]
        
        public DateTime? Start { get; set; }


        [Column("answer", TypeName = "datetime")]
        
        public DateTime? Answer { get; set; }


        [Column("end", TypeName = "datetime")]
        
        public DateTime? End { get; set; }



            }
}
