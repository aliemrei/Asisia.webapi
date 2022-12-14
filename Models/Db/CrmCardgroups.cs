using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("CRM_CARDGROUPS")]
    [Index(nameof(Corpid), nameof(Definition), Name = "UQ__CRM_CARD__D0FAF6086F855A68", IsUnique = true)]
    public partial class CrmCardgroups : EntityBase 
    {
        public CrmCardgroups()
        {
            CrmCardtypes = new HashSet<CrmCardtypes>();
        }

        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("CORPID")]
        [RequiredIf]
        public Guid Corpid { get; set; }


        [Column("DEFINITION")]
        [StringLength(100)]
        [RequiredIf]
        public string Definition { get; set; } = null!;


        [Column("ISDELETED")]
        [RequiredIf]
        public bool Isdeleted { get; set; }


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
        [InverseProperty(nameof(Users.CrmCardgroupsAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Corpid))]
        [InverseProperty("CrmCardgroups")]
        public virtual Corp Corp { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.CrmCardgroupsEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [InverseProperty("Cardgroup")]
        public virtual ICollection<CrmCardtypes> CrmCardtypes { get; set; }

            }
}
