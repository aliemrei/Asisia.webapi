using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDSTORE")]
    public partial class Stdstore : EntityBase 
    {
        public Stdstore()
        {
            ProjectGroupdetail = new HashSet<ProjectGroupdetail>();
            StdstoreItemGroups = new HashSet<StdstoreItemGroups>();
        }

        [Key]
        [Column("ID")]
        [RequiredIf]
        public Guid Id { get; set; }


        [Column("CORPID")]
        [RequiredIf]
        public Guid Corpid { get; set; }


        [Column("NAME")]
        [StringLength(250)]
        [RequiredIf]
        public string Name { get; set; } = null!;


        [Column("TEL1")]
        
        public long? Tel1 { get; set; }


        [Column("TEL2")]
        
        public long? Tel2 { get; set; }


        [Column("EMAIL")]
        [StringLength(200)]
        
        public string? Email { get; set; }


        [Column("ADDRESSID")]
        
        public Guid? Addressid { get; set; }


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


        [Column("CONTACT")]
        [StringLength(200)]
        
        public string? Contact { get; set; }


        [Column("FAX")]
        
        public long? Fax { get; set; }


        [Column("WEBADDRESS")]
        [StringLength(250)]
        
        public string? Webaddress { get; set; }


        [Column("TYPE")]
        [RequiredIf]
        public short Type { get; set; }


        [Column("TYPENAME")]
        [StringLength(10)]
        [Unicode(false)]
        
        public string? Typename { get; set; }


        [Column("THUMBNAILURL")]
        [StringLength(350)]
        
        public string? Thumbnailurl { get; set; }



        [ForeignKey(nameof(Addressid))]
        [InverseProperty(nameof(LocationAddress.Stdstore))]
        public virtual LocationAddress? Address { get; set; }
        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.StdstoreAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Corpid))]
        [InverseProperty("Stdstore")]
        public virtual Corp Corp { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.StdstoreEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [InverseProperty("Store")]
        public virtual ICollection<ProjectGroupdetail> ProjectGroupdetail { get; set; }
        [InverseProperty("Store")]
        public virtual ICollection<StdstoreItemGroups> StdstoreItemGroups { get; set; }

            }
}
