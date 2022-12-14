using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class VwMobPaymentReport : EntityBase 
    {
        [Column("CORPID")]
        
        public Guid? Corpid { get; set; }


        [Column("PROJECT_GROUPID")]
        
        public Guid? ProjectGroupid { get; set; }


        [Column("PROJECTGROUP")]
        [StringLength(150)]
        
        public string? Projectgroup { get; set; }


        [Column("POS")]
        [StringLength(150)]
        
        public string? Pos { get; set; }


        [Column("PERSONNAME")]
        [StringLength(212)]
        
        public string? Personname { get; set; }


        [Column("LAST_AMOUNT")]
        
        public double? LastAmount { get; set; }


        [Column("CURCODE")]
        [StringLength(5)]
        [Unicode(false)]
        
        public string? Curcode { get; set; }


        [Column("DESCRIPTION")]
        [StringLength(200)]
        
        public string? Description { get; set; }


        [Column("ENDTIME", TypeName = "datetime")]
        [RequiredIf]
        public DateTime Endtime { get; set; }


        [Column("INTID")]
        
        public int? Intid { get; set; }


        [Column("AUTHCODE")]
        [StringLength(200)]
        
        public string? Authcode { get; set; }


        [Column("PAYTYPE")]
        [StringLength(9)]
        [Unicode(false)]
        
        public string? Paytype { get; set; }


        [Column("TOTAL")]
        
        public double? Total { get; set; }


        [Column("RCURCODE")]
        [StringLength(5)]
        [Unicode(false)]
        
        public string? Rcurcode { get; set; }


        [Column("PRODUCTNAME")]
        [StringLength(150)]
        
        public string? Productname { get; set; }


        [Column("RESIDS")]
        [StringLength(100)]
        
        public string? Resids { get; set; }


        [Column("STATU")]
        [StringLength(200)]
        
        public string? Statu { get; set; }


        [Column("SUBSTATU")]
        [StringLength(200)]
        
        public string? Substatu { get; set; }


        [Column("STATUID")]
        
        public Guid? Statuid { get; set; }


        [Column("CANCEL_AMOUNT")]
        [RequiredIf]
        public double CancelAmount { get; set; }


        [Column("CTOTAL")]
        
        public double? Ctotal { get; set; }


        [Column("PROJECT_GROUPDETAIL")]
        [StringLength(200)]
        
        public string? ProjectGroupdetail { get; set; }



            }
}
