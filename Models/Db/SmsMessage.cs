using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("SMS_MESSAGE")]
    public partial class SmsMessage : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public int Id { get; set; }


        [Column("REQUEST_DETAILID")]
        
        public Guid? RequestDetailid { get; set; }


        [Column("ISSENT")]
        [RequiredIf]
        public bool Issent { get; set; }


        [Column("SENDDATE", TypeName = "datetime")]
        
        public DateTime? Senddate { get; set; }


        [Column("MESSAGEBODY")]
        [StringLength(400)]
        [RequiredIf]
        public string Messagebody { get; set; } = null!;


        [Column("NUMBERS")]
        [RequiredIf]
        public string Numbers { get; set; } = null!;


        [Column("TYPE")]
        [RequiredIf]
        public short Type { get; set; }


        [Column("SMSID")]
        
        public Guid? Smsid { get; set; }


        [Column("SENDERROR")]
        [StringLength(250)]
        
        public string? Senderror { get; set; }



        [ForeignKey(nameof(RequestDetailid))]
        [InverseProperty("SmsMessage")]
        public virtual RequestDetail? RequestDetail { get; set; }
        [ForeignKey(nameof(Smsid))]
        [InverseProperty(nameof(SmsSettings.SmsMessage))]
        public virtual SmsSettings? Sms { get; set; }

            }
}
