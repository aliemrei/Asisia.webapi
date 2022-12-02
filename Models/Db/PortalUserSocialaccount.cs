using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("PORTAL_USER_SOCIALACCOUNT")]
    [Index(nameof(Userid), nameof(Providername), nameof(Providerid), Name = "UQ__PORTAL_U__47F26347B2CE65E0", IsUnique = true)]
    public partial class PortalUserSocialaccount : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("USERID")]
        public Guid Userid { get; set; }
        [Column("PROVIDERNAME")]
        [StringLength(50)]
        public string Providername { get; set; } = null!;
        [Column("PROVIDERID")]
        [StringLength(200)]
        public string Providerid { get; set; } = null!;

        [ForeignKey(nameof(Userid))]
        [InverseProperty(nameof(PortalUser.PortalUserSocialaccount))]
        public virtual PortalUser User { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
