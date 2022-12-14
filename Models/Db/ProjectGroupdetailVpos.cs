using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("PROJECT_GROUPDETAIL_VPOS")]
    [Index(nameof(ProjectDetailid), nameof(Accountid), Name = "UQ__PROJECT___F7CFBB35722A2BCA", IsUnique = true)]
    public partial class ProjectGroupdetailVpos : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("PROJECT_DETAILID")]
        [RequiredIf]
        public Guid ProjectDetailid { get; set; }


        [Column("ACCOUNTID")]
        [RequiredIf]
        public Guid Accountid { get; set; }


        [Column("ISDISABLED")]
        [RequiredIf]
        public bool Isdisabled { get; set; }


        [Column("ISDEFAULT")]
        [RequiredIf]
        public bool Isdefault { get; set; }


        [Column("CURCODES")]
        [StringLength(220)]
        
        public string? Curcodes { get; set; }


        [Column("CARDBRANDS")]
        [StringLength(220)]
        
        public string? Cardbrands { get; set; }



        [ForeignKey(nameof(ProjectDetailid))]
        [InverseProperty(nameof(ProjectGroupdetail.ProjectGroupdetailVpos))]
        public virtual ProjectGroupdetail ProjectDetail { get; set; } = null!;

            }
}
