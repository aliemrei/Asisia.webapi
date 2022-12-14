using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("PROJECT_GROUPDETAIL_BANKDEP")]
    [Index(nameof(ProjectDetailid), nameof(Depaccountid), Name = "UQ__PROJECT___6EB8113D889D7241", IsUnique = true)]
    public partial class ProjectGroupdetailBankdep : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("PROJECT_DETAILID")]
        [RequiredIf]
        public Guid ProjectDetailid { get; set; }


        [Column("DEPACCOUNTID")]
        [RequiredIf]
        public Guid Depaccountid { get; set; }


        [Column("ISDISABLED")]
        [RequiredIf]
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

            }
}
