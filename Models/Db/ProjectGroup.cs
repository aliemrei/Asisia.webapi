using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("PROJECT_GROUP")]
    [Index(nameof(RakamId), Name = "IX_PROJECT_GROUP")]
    public partial class ProjectGroup : EntityBase // My Handlebars Helper
    {
        public ProjectGroup()
        {
            BonusDef = new HashSet<BonusDef>();
            CallJobs = new HashSet<CallJobs>();
            Campaigns = new HashSet<Campaigns>();
            PaymentEmails = new HashSet<PaymentEmails>();
            Portal = new HashSet<Portal>();
            ProjectGroupdetail = new HashSet<ProjectGroupdetail>();
            SmsSettings = new HashSet<SmsSettings>();
            SmtpSettings = new HashSet<SmtpSettings>();
            UserProjects = new HashSet<UserProjects>();
        }

        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("NAME")]
        [StringLength(150)]
        public string Name { get; set; } = null!;
        [Column("CORPID")]
        public Guid? Corpid { get; set; }
        [Column("MERGECLIENTS")]
        public bool Mergeclients { get; set; }
        [Column("USEALTERNATES")]
        public bool Usealternates { get; set; }
        [Column("ISDELETED")]
        public bool Isdeleted { get; set; }
        [Column("ISDISABLED")]
        public bool Isdisabled { get; set; }
        [Column("ADDUSER")]
        public Guid Adduser { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("EDITUSER")]
        public Guid? Edituser { get; set; }
        [Column("EDITDATE", TypeName = "datetime")]
        public DateTime? Editdate { get; set; }
        [Column("ENT_ID")]
        [StringLength(25)]
        public string? EntId { get; set; }
        [Column("ENT_URL")]
        [StringLength(150)]
        public string? EntUrl { get; set; }
        [Column("RAKAM_ID")]
        [StringLength(15)]
        public string? RakamId { get; set; }
        [Column("ACC_CODE")]
        [StringLength(30)]
        public string? AccCode { get; set; }
        [Column("ENT_USE")]
        public bool EntUse { get; set; }
        [Column("RES_MAILURL")]
        [StringLength(250)]
        public string? ResMailurl { get; set; }
        [Column("ENT_SETURURL")]
        [StringLength(250)]
        public string? EntSetururl { get; set; }
        [Column("ENT_SETURAPIKEY")]
        [StringLength(150)]
        public string? EntSeturapikey { get; set; }
        [Column("DONTSTORE_CCARDS")]
        public bool? DontstoreCcards { get; set; }
        [Column("ADDRESSID")]
        public Guid? Addressid { get; set; }

        [ForeignKey(nameof(Addressid))]
        [InverseProperty(nameof(LocationAddress.ProjectGroup))]
        public virtual LocationAddress? Address { get; set; }
        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.ProjectGroupAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Corpid))]
        [InverseProperty("ProjectGroup")]
        public virtual Corp? Corp { get; set; }
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.ProjectGroupEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [InverseProperty("ProjectGroup")]
        public virtual ICollection<BonusDef> BonusDef { get; set; }
        [InverseProperty("ProjectGroup")]
        public virtual ICollection<CallJobs> CallJobs { get; set; }
        [InverseProperty("Project")]
        public virtual ICollection<Campaigns> Campaigns { get; set; }
        [InverseProperty("Project")]
        public virtual ICollection<PaymentEmails> PaymentEmails { get; set; }
        [InverseProperty("Project")]
        public virtual ICollection<Portal> Portal { get; set; }
        [InverseProperty("ProjectGroup")]
        public virtual ICollection<ProjectGroupdetail> ProjectGroupdetail { get; set; }
        [InverseProperty("Project")]
        public virtual ICollection<SmsSettings> SmsSettings { get; set; }
        [InverseProperty("Project")]
        public virtual ICollection<SmtpSettings> SmtpSettings { get; set; }
        [InverseProperty("ProjectGroup")]
        public virtual ICollection<UserProjects> UserProjects { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
