using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDHOTEL_RATECODE_DETAIL_AGENCYGROUPS")]
    public partial class StdhotelRatecodeDetailAgencygroups : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("GROUPID")]
        public Guid Groupid { get; set; }
        [Column("ADDUSER")]
        public Guid Adduser { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("EDITUSER")]
        public Guid? Edituser { get; set; }
        [Column("EDITDATE", TypeName = "datetime")]
        public DateTime? Editdate { get; set; }
        [Column("DETAILID")]
        public Guid? Detailid { get; set; }
        [Column("ISDELETED")]
        public bool Isdeleted { get; set; }
        [Column("ISDISABLED")]
        public bool Isdisabled { get; set; }

        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.StdhotelRatecodeDetailAgencygroupsAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Detailid))]
        [InverseProperty(nameof(StdhotelRatecodeDetail.StdhotelRatecodeDetailAgencygroups))]
        public virtual StdhotelRatecodeDetail? Detail { get; set; }
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.StdhotelRatecodeDetailAgencygroupsEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(Groupid))]
        [InverseProperty(nameof(AgencyGroup.StdhotelRatecodeDetailAgencygroups))]
        public virtual AgencyGroup Group { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
