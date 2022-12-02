using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("AGENCY_GROUP")]
    [Index(nameof(Corpid), nameof(Groupname), Name = "UQ__AGENCY_G__13040B821987821B", IsUnique = true)]
    public partial class AgencyGroup : EntityBase // My Handlebars Helper
    {
        public AgencyGroup()
        {
            Agency = new HashSet<Agency>();
            StdhotelRatecodeDetailAgencygroups = new HashSet<StdhotelRatecodeDetailAgencygroups>();
        }

        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("CORPID")]
        public Guid Corpid { get; set; }
        [Column("GROUPNAME")]
        [StringLength(200)]
        public string Groupname { get; set; } = null!;
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
        [Column("ISDISABLED")]
        public bool Isdisabled { get; set; }

        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.AgencyGroupAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Corpid))]
        [InverseProperty("AgencyGroup")]
        public virtual Corp Corp { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.AgencyGroupEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [InverseProperty("Group")]
        public virtual ICollection<Agency> Agency { get; set; }
        [InverseProperty("Group")]
        public virtual ICollection<StdhotelRatecodeDetailAgencygroups> StdhotelRatecodeDetailAgencygroups { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
