using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("SMS_SETTINGS")]
    public partial class SmsSettings : EntityBase 
    {
        public SmsSettings()
        {
            SmsMessage = new HashSet<SmsMessage>();
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


        [Column("SMSCLASSNAME")]
        [StringLength(100)]
        [RequiredIf]
        public string Smsclassname { get; set; } = null!;


        [Column("PARAM")]
        [StringLength(100)]
        
        public string? Param { get; set; }


        [Column("USERNAME")]
        [StringLength(100)]
        [RequiredIf]
        public string Username { get; set; } = null!;


        [Column("PASS")]
        [StringLength(100)]
        [RequiredIf]
        public string Pass { get; set; } = null!;


        [Column("SENDER")]
        [StringLength(100)]
        
        public string? Sender { get; set; }


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



        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.SmsSettingsAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Corpid))]
        [InverseProperty("SmsSettings")]
        public virtual Corp? Corp { get; set; }
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.SmsSettingsEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(Projectid))]
        [InverseProperty(nameof(ProjectGroup.SmsSettings))]
        public virtual ProjectGroup? Project { get; set; }
        [ForeignKey(nameof(ProjectDetailid))]
        [InverseProperty(nameof(ProjectGroupdetail.SmsSettings))]
        public virtual ProjectGroupdetail? ProjectDetail { get; set; }
        [InverseProperty("Sms")]
        public virtual ICollection<SmsMessage> SmsMessage { get; set; }

            }
}
