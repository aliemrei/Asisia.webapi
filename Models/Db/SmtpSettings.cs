using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("SMTP_SETTINGS")]
    public partial class SmtpSettings : EntityBase 
    {
        public SmtpSettings()
        {
            SmtpMails = new HashSet<SmtpMails>();
        }

        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("CORPID")]
        
        public Guid? Corpid { get; set; }


        [Column("PROJECTID")]
        
        public Guid? Projectid { get; set; }


        [Column("PROJECT_DETAILID")]
        
        public Guid? ProjectDetailid { get; set; }


        [Column("HOST")]
        [StringLength(100)]
        [RequiredIf]
        public string Host { get; set; } = null!;


        [Column("USERNAME")]
        [StringLength(100)]
        [RequiredIf]
        public string Username { get; set; } = null!;


        [Column("PASS")]
        [StringLength(100)]
        [RequiredIf]
        public string Pass { get; set; } = null!;


        [Column("PORTNO")]
        [RequiredIf]
        public int Portno { get; set; }


        [Column("TSL")]
        [StringLength(25)]
        
        public string? Tsl { get; set; }


        [Column("SENDERNAME")]
        [StringLength(150)]
        
        public string? Sendername { get; set; }


        [Column("ISDISABLED")]
        [RequiredIf]
        public bool Isdisabled { get; set; }


        [Column("ADDUSER")]
        [RequiredIf]
        public Guid Adduser { get; set; }


        [Column("ADDDATE", TypeName = "datetime")]
        [RequiredIf]
        public DateTime Adddate { get; set; }


        [Column("EDITUSER")]
        
        public Guid? Edituser { get; set; }


        [Column("EDITDATE", TypeName = "datetime")]
        
        public DateTime? Editdate { get; set; }


        [Column("SENDERMAIL")]
        [StringLength(100)]
        
        public string? Sendermail { get; set; }


        [Column("TYPE")]
        [RequiredIf]
        public short Type { get; set; }


        [Column("DOMAIN")]
        [StringLength(100)]
        
        public string? Domain { get; set; }



        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.SmtpSettingsAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Corpid))]
        [InverseProperty("SmtpSettings")]
        public virtual Corp? Corp { get; set; }
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.SmtpSettingsEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(Projectid))]
        [InverseProperty(nameof(ProjectGroup.SmtpSettings))]
        public virtual ProjectGroup? Project { get; set; }
        [InverseProperty("Smtp")]
        public virtual ICollection<SmtpMails> SmtpMails { get; set; }

            }
}
