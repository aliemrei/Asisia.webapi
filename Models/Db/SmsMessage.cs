using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("SMS_MESSAGE")]
    public partial class SmsMessage : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("REQUEST_DETAILID")]
        public Guid? RequestDetailid { get; set; }
        [Column("ISSENT")]
        public bool Issent { get; set; }
        [Column("SENDDATE", TypeName = "datetime")]
        public DateTime? Senddate { get; set; }
        [Column("MESSAGEBODY")]
        [StringLength(400)]
        public string Messagebody { get; set; } = null!;
        [Column("NUMBERS")]
        public string Numbers { get; set; } = null!;
        [Column("TYPE")]
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

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
