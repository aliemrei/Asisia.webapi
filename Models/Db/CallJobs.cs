using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("CALL_JOBS")]
    [Index(nameof(Adddate), Name = "IX_CALL_JOBS")]
    [Index(nameof(Isdeleted), nameof(Isdisabled), Name = "IX_CALL_JOBS_1")]
    [Index(nameof(Reason), nameof(Result), Name = "IX_CALL_JOBS_2")]
    public partial class CallJobs : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("REQUESTID")]
        public Guid? Requestid { get; set; }
        [Column("CALLDATE", TypeName = "datetime")]
        public DateTime Calldate { get; set; }
        [Column("CALLNUMBER")]
        public long Callnumber { get; set; }
        [Column("USERID")]
        public Guid? Userid { get; set; }
        [Column("PERSONID")]
        public Guid? Personid { get; set; }
        [Column("REASON")]
        public short Reason { get; set; }
        [Column("RESULT")]
        public short Result { get; set; }
        [Column("CANCELATION")]
        public short? Cancelation { get; set; }
        [Column("CAMPAIGNCODE")]
        [StringLength(100)]
        public string? Campaigncode { get; set; }
        [Column("ISDELETED")]
        public bool Isdeleted { get; set; }
        [Column("ISDISABLED")]
        public bool Isdisabled { get; set; }
        [Column("ENT_ID")]
        [StringLength(25)]
        public string? EntId { get; set; }
        [Column("ADDUSER")]
        public Guid Adduser { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("EDITUSER")]
        public Guid? Edituser { get; set; }
        [Column("EDITDATE", TypeName = "datetime")]
        public DateTime? Editdate { get; set; }
        [Column("OUTPUT_EXTEN")]
        [StringLength(150)]
        public string? OutputExten { get; set; }
        [Column("QAID")]
        public Guid? Qaid { get; set; }
        [Column("PRIORITY")]
        public int? Priority { get; set; }
        [Column("DESCRIPTION")]
        public string? Description { get; set; }
        [Column("FIRSTNAME")]
        [StringLength(70)]
        public string? Firstname { get; set; }
        [Column("LASTNAME")]
        [StringLength(70)]
        public string? Lastname { get; set; }
        [Column("CORPID")]
        public Guid? Corpid { get; set; }
        [Column("FULLNAME")]
        [StringLength(200)]
        public string? Fullname { get; set; }
        [Column("KIND")]
        [StringLength(1)]
        [Unicode(false)]
        public string Kind { get; set; } = null!;
        [Column("PROJECT_GROUPID")]
        public Guid? ProjectGroupid { get; set; }
        [Column("PROJECT_DETAILID")]
        public Guid? ProjectDetailid { get; set; }
        [Column("RESULT_TEXT")]
        public string? ResultText { get; set; }

        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.CallJobsAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Corpid))]
        [InverseProperty("CallJobs")]
        public virtual Corp? Corp { get; set; }
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.CallJobsEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(Personid))]
        [InverseProperty("CallJobs")]
        public virtual Person? Person { get; set; }
        [ForeignKey(nameof(ProjectDetailid))]
        [InverseProperty(nameof(ProjectGroupdetail.CallJobs))]
        public virtual ProjectGroupdetail? ProjectDetail { get; set; }
        [ForeignKey(nameof(ProjectGroupid))]
        [InverseProperty("CallJobs")]
        public virtual ProjectGroup? ProjectGroup { get; set; }
        [ForeignKey(nameof(Requestid))]
        [InverseProperty("CallJobs")]
        public virtual Request? Request { get; set; }
        [ForeignKey(nameof(Userid))]
        [InverseProperty(nameof(Users.CallJobsUser))]
        public virtual Users? User { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
