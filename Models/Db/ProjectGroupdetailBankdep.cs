using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("PROJECT_GROUPDETAIL_BANKDEP")]
    [Index(nameof(ProjectDetailid), nameof(Depaccountid), Name = "UQ__PROJECT___6EB8113D889D7241", IsUnique = true)]
    public partial class ProjectGroupdetailBankdep : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("PROJECT_DETAILID")]
        public Guid ProjectDetailid { get; set; }
        [Column("DEPACCOUNTID")]
        public Guid Depaccountid { get; set; }
        [Column("ISDISABLED")]
        public bool Isdisabled { get; set; }
        [Required]
        [Column("USE_IN_PORTAL")]
        public bool? UseInPortal { get; set; }

        [ForeignKey(nameof(Depaccountid))]
        [InverseProperty(nameof(VirtualPosDepAccounts.ProjectGroupdetailBankdep))]
        public virtual VirtualPosDepAccounts Depaccount { get; set; } = null!;
        [ForeignKey(nameof(ProjectDetailid))]
        [InverseProperty(nameof(ProjectGroupdetail.ProjectGroupdetailBankdep))]
        public virtual ProjectGroupdetail ProjectDetail { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
