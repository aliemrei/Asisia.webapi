using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("RESOURCE_DETAIL")]
    public partial class ResourceDetail : EntityBase 
    {
        public ResourceDetail()
        {
            SalesReq = new HashSet<SalesReq>();
        }

        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("DESCRIPTION")]
        [StringLength(150)]
        [RequiredIf]
        public string Description { get; set; } = null!;


        [Column("DETAIL")]
        [StringLength(150)]
        [RequiredIf]
        public string Detail { get; set; } = null!;


        [Column("RESOURCEID")]
        [RequiredIf]
        public Guid Resourceid { get; set; }


        [Column("CORPID")]
        [RequiredIf]
        public Guid Corpid { get; set; }


        [Column("PROJECT_GROUPDETAILID")]
        [RequiredIf]
        public Guid ProjectGroupdetailid { get; set; }


        [Column("ISDELETED")]
        [RequiredIf]
        public bool Isdeleted { get; set; }


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
        [InverseProperty(nameof(Users.ResourceDetailAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Corpid))]
        [InverseProperty("ResourceDetail")]
        public virtual Corp Corp { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.ResourceDetailEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(ProjectGroupdetailid))]
        [InverseProperty("ResourceDetail")]
        public virtual ProjectGroupdetail ProjectGroupdetail { get; set; } = null!;
        [InverseProperty("ResourceDetail")]
        public virtual ICollection<SalesReq> SalesReq { get; set; }

            }
}
