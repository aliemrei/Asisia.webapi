using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class VwRequestPayments : EntityBase 
    {
        [Column("FULLNAME")]
        [StringLength(201)]
        
        public string? Fullname { get; set; }


        [Column("PAYTPE")]
        [RequiredIf]
        public int Paytpe { get; set; }


        [Column("DESCRIPTION")]
        [StringLength(200)]
        
        public string? Description { get; set; }


        [Column("SUBSTATUS")]
        
        public short? Substatus { get; set; }


        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("REQUESTID")]
        
        public Guid? Requestid { get; set; }


        [Column("POS")]
        [StringLength(150)]
        
        public string? Pos { get; set; }


        [Column("CARDNO")]
        [StringLength(250)]
        
        public string? Cardno { get; set; }


        [Column("AMOUNT")]
        
        public double? Amount { get; set; }


        [Column("CURCODE")]
        [StringLength(5)]
        [Unicode(false)]
        
        public string? Curcode { get; set; }


        [Column("INSTALMENT")]
        
        public int? Instalment { get; set; }


        [Column("TRANTYPE")]
        [StringLength(15)]
        
        public string? Trantype { get; set; }


        [Column("STORETYPE")]
        [StringLength(30)]
        
        public string? Storetype { get; set; }


        [Column("ENDTIME", TypeName = "datetime")]
        
        public DateTime? Endtime { get; set; }


        [Column("PREAUTH")]
        
        public bool? Preauth { get; set; }


        [Column("POSTAUTH")]
        
        public bool? Postauth { get; set; }


        [Column("VOID")]
        
        public bool? Void { get; set; }


        [Column("REFUND")]
        
        public bool? Refund { get; set; }


        [Column("STATUSTEXT")]
        [StringLength(500)]
        
        public string? Statustext { get; set; }


        [Column("ISDELETED")]
        
        public bool? Isdeleted { get; set; }


        [Column("INTID")]
        
        public int? Intid { get; set; }


        [Column("ADDUSER")]
        [RequiredIf]
        public Guid Adduser { get; set; }


        [Column("ADDDATE", TypeName = "datetime")]
        [RequiredIf]
        public DateTime Adddate { get; set; }



            }
}
