using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class VwBasketPayments : EntityBase 
    {
        [Column("PAYTPE")]
        [RequiredIf]
        public int Paytpe { get; set; }


        [Column("CORPID")]
        
        public Guid? Corpid { get; set; }


        [Column("STATUID")]
        
        public Guid? Statuid { get; set; }


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


        [Column("AMOUNT")]
        [RequiredIf]
        public double Amount { get; set; }


        [Column("LAST_AMOUNT")]
        
        public double? LastAmount { get; set; }


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
        [RequiredIf]
        public DateTime Endtime { get; set; }


        [Column("PREAUTH")]
        
        public bool? Preauth { get; set; }


        [Column("POSTAUTH")]
        
        public bool? Postauth { get; set; }


        [Column("VOID")]
        
        public bool? Void { get; set; }


        [Column("REFUND")]
        
        public bool? Refund { get; set; }


        [Column("CTOTAL")]
        
        public double? Ctotal { get; set; }


        [Column("CAMOUNT")]
        
        public double? Camount { get; set; }


        [Column("CCURCODE")]
        [StringLength(5)]
        [Unicode(false)]
        
        public string? Ccurcode { get; set; }


        [Column("INTID")]
        
        public int? Intid { get; set; }


        [Column("AUTHCODE")]
        [StringLength(200)]
        
        public string? Authcode { get; set; }


        [Column("RETREFNUMBER")]
        [StringLength(200)]
        
        public string? Retrefnumber { get; set; }


        [Column("CARDNO")]
        [StringLength(24)]
        
        public string? Cardno { get; set; }


        [Column("CARDOWNER")]
        [StringLength(200)]
        
        public string? Cardowner { get; set; }


        [Column("ACCOUNTNAME")]
        [StringLength(50)]
        
        public string? Accountname { get; set; }


        [Column("TERMINALID")]
        [StringLength(50)]
        
        public string? Terminalid { get; set; }


        [Column("ADDUSER")]
        [RequiredIf]
        public Guid Adduser { get; set; }


        [Column("ADDDATE", TypeName = "datetime")]
        [RequiredIf]
        public DateTime Adddate { get; set; }


        [Column("CANCEL_AMOUNT")]
        [RequiredIf]
        public double CancelAmount { get; set; }



            }
}
