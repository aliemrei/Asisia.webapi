using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("VIRTUAL_POS_ACCOUNTS")]
    public partial class VirtualPosAccounts : EntityBase // My Handlebars Helper
    {
        public VirtualPosAccounts()
        {
            VirtualPosAccountInstalments = new HashSet<VirtualPosAccountInstalments>();
            VirtualPosAccountsCurcodes = new HashSet<VirtualPosAccountsCurcodes>();
            VirtualPosPayments = new HashSet<VirtualPosPayments>();
        }

        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("POSID")]
        public Guid Posid { get; set; }
        [Column("CORPID")]
        public Guid Corpid { get; set; }
        [Column("CLIENTID")]
        [StringLength(50)]
        public string? Clientid { get; set; }
        [Column("TERMINALID")]
        [StringLength(50)]
        public string? Terminalid { get; set; }
        [Column("ACCOUNTNAME")]
        [StringLength(50)]
        public string? Accountname { get; set; }
        [Column("PASSWORD")]
        [StringLength(50)]
        public string? Password { get; set; }
        [Column("PASSWORD_3D")]
        [StringLength(50)]
        public string? Password3d { get; set; }
        [Column("PARAMS")]
        [StringLength(350)]
        public string? Params { get; set; }
        [Column("USE3D")]
        public byte Use3d { get; set; }
        [Column("POSTURL")]
        [StringLength(250)]
        public string? Posturl { get; set; }
        [Column("INSTALMENT_MERGE")]
        public bool InstalmentMerge { get; set; }
        [Column("ADDUSER")]
        public Guid Adduser { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("EDITUSER")]
        public Guid? Edituser { get; set; }
        [Column("EDITDATE", TypeName = "datetime")]
        public DateTime? Editdate { get; set; }
        [Column("DEFINITION")]
        [StringLength(150)]
        public string? Definition { get; set; }
        [Column("ENT_HOTELID")]
        [StringLength(25)]
        public string? EntHotelid { get; set; }
        [Column("BINNUMBER_NAME")]
        [StringLength(50)]
        public string? BinnumberName { get; set; }
        [Column("ISFOREIGN_POS")]
        public bool IsforeignPos { get; set; }
        [Column("EMAIL")]
        [StringLength(200)]
        public string? Email { get; set; }
        [Column("ENTID")]
        [StringLength(100)]
        public string? Entid { get; set; }

        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.VirtualPosAccountsAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Corpid))]
        [InverseProperty("VirtualPosAccounts")]
        public virtual Corp Corp { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.VirtualPosAccountsEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(Posid))]
        [InverseProperty(nameof(VirtualPos.VirtualPosAccounts))]
        public virtual VirtualPos Pos { get; set; } = null!;
        [InverseProperty("Account")]
        public virtual ICollection<VirtualPosAccountInstalments> VirtualPosAccountInstalments { get; set; }
        [InverseProperty("Account")]
        public virtual ICollection<VirtualPosAccountsCurcodes> VirtualPosAccountsCurcodes { get; set; }
        [InverseProperty("Posaccount")]
        public virtual ICollection<VirtualPosPayments> VirtualPosPayments { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
