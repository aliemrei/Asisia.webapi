using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("PROJECT_GROUPDETAIL_SEO")]
    public partial class ProjectGroupdetailSeo : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public int Id { get; set; }


        [Column("LANG")]
        [StringLength(6)]
        [Unicode(false)]
        [RequiredIf]
        public string Lang { get; set; } = null!;


        [Column("URL")]
        [StringLength(150)]
        
        public string? Url { get; set; }


        [Column("TITLE")]
        [StringLength(250)]
        
        public string? Title { get; set; }


        [Column("DESCRIPTION")]
        
        public string? Description { get; set; }


        [Column("KEYWORDS")]
        
        public string? Keywords { get; set; }


        [Column("PROJECT_DETAILID")]
        [RequiredIf]
        public Guid ProjectDetailid { get; set; }



        [ForeignKey(nameof(Lang))]
        [InverseProperty(nameof(Stdlanguages.ProjectGroupdetailSeo))]
        public virtual Stdlanguages LangNavigation { get; set; } = null!;

            }
}
