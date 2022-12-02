using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("CAMPAIGNS")]
    [Index(nameof(Code), Name = "IX_CAMPAIGNS")]
    public partial class Campaigns : EntityBase // My Handlebars Helper
    {
        public Campaigns()
        {
            Request = new HashSet<Request>();
            RequestDetail = new HashSet<RequestDetail>();
        }

        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("CODE")]
        [StringLength(100)]
        public string Code { get; set; } = null!;
        [Column("DESCRIPTION")]
        [StringLength(100)]
        public string Description { get; set; } = null!;
        [Column("CORPID")]
        public Guid Corpid { get; set; }
        [Column("RESOURCEID")]
        public Guid? Resourceid { get; set; }
        [Column("PROJECTID")]
        public Guid Projectid { get; set; }
        [Column("PROJECT_DETAILID")]
        public Guid? ProjectDetailid { get; set; }
        [Column("FORALLPROJECTS")]
        public int Forallprojects { get; set; }
        [Column("STARTDATE", TypeName = "datetime")]
        public DateTime Startdate { get; set; }
        [Column("ENDDATE", TypeName = "datetime")]
        public DateTime Enddate { get; set; }
        [Column("ADDUSER")]
        public Guid Adduser { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("EDITUSER")]
        public Guid? Edituser { get; set; }
        [Column("EDITDATE", TypeName = "datetime")]
        public DateTime? Editdate { get; set; }
        [Column("ISDELETED")]
        public bool Isdeleted { get; set; }
        [Column("RAKAM_ID")]
        [StringLength(15)]
        public string? RakamId { get; set; }
        [Column("CALLBACK_TRUNK")]
        [StringLength(150)]
        public string? CallbackTrunk { get; set; }

        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.CampaignsAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Corpid))]
        [InverseProperty("Campaigns")]
        public virtual Corp Corp { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.CampaignsEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(Projectid))]
        [InverseProperty(nameof(ProjectGroup.Campaigns))]
        public virtual ProjectGroup Project { get; set; } = null!;
        [ForeignKey(nameof(Resourceid))]
        [InverseProperty(nameof(Resources.Campaigns))]
        public virtual Resources? Resource { get; set; }
        [InverseProperty("Campaign")]
        public virtual ICollection<Request> Request { get; set; }
        [InverseProperty("Campaign")]
        public virtual ICollection<RequestDetail> RequestDetail { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
