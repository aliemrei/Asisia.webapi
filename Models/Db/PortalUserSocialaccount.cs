using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("PORTAL_USER_SOCIALACCOUNT")]
    [Index(nameof(Userid), nameof(Providername), nameof(Providerid), Name = "UQ__PORTAL_U__47F26347B2CE65E0", IsUnique = true)]
    public partial class PortalUserSocialaccount : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public int Id { get; set; }


        [Column("USERID")]
        [RequiredIf]
        public Guid Userid { get; set; }


        [Column("PROVIDERNAME")]
        [StringLength(50)]
        [RequiredIf]
        public string Providername { get; set; } = null!;


        [Column("PROVIDERID")]
        [StringLength(200)]
        [RequiredIf]
        public string Providerid { get; set; } = null!;



        [ForeignKey(nameof(Userid))]
        [InverseProperty(nameof(PortalUser.PortalUserSocialaccount))]
        public virtual PortalUser User { get; set; } = null!;

            }
}
