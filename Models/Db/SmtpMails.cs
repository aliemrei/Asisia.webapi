using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("SMTP_MAILS")]
    [Index(nameof(Senddate), Name = "IX_SMTP_MAILS")]
    [Index(nameof(Senddate), Name = "IX_SMTP_MAILS_1")]
    [Index(nameof(Issent), Name = "IX_SMTP_MAILS_2")]
    [Index(nameof(Requestid), nameof(To), Name = "IX_SMTP_MAILS_3")]
    public partial class SmtpMails : EntityBase 
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


        [Column("REPORTID")]
        
        public Guid? Reportid { get; set; }


        [Column("SENDERNAME")]
        [StringLength(150)]
        
        public string? Sendername { get; set; }


        [Column("SENDERMAIL")]
        [StringLength(200)]
        
        public string? Sendermail { get; set; }


        [Column("HOST")]
        [StringLength(100)]
        
        public string? Host { get; set; }


        [Column("_TO")]
        [StringLength(350)]
        
        public string? To { get; set; }


        [Column("_CC")]
        [StringLength(350)]
        
        public string? Cc { get; set; }


        [Column("SMTPID")]
        
        public Guid? Smtpid { get; set; }


        [Column("SENDERROR")]
        [StringLength(250)]
        
        public string? Senderror { get; set; }


        [Column("REQUESTID")]
        
        public Guid? Requestid { get; set; }


        [Column("UID")]
        [RequiredIf]
        public Guid Uid { get; set; }



        [ForeignKey(nameof(Reportid))]
        [InverseProperty(nameof(Reports.SmtpMails))]
        public virtual Reports? Report { get; set; }
        [ForeignKey(nameof(Requestid))]
        [InverseProperty("SmtpMails")]
        public virtual Request? Request { get; set; }
        [ForeignKey(nameof(RequestDetailid))]
        [InverseProperty("SmtpMails")]
        public virtual RequestDetail? RequestDetail { get; set; }
        [ForeignKey(nameof(Smtpid))]
        [InverseProperty(nameof(SmtpSettings.SmtpMails))]
        public virtual SmtpSettings? Smtp { get; set; }

            }
}
