using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("VIRTUAL_POS")]
    public partial class VirtualPos : EntityBase // My Handlebars Helper
    {
        public VirtualPos()
        {
            VirtualPosAccounts = new HashSet<VirtualPosAccounts>();
            VirtualPosDefaultsAmexExPos = new HashSet<VirtualPosDefaults>();
            VirtualPosDefaultsAmexPos = new HashSet<VirtualPosDefaults>();
            VirtualPosDefaultsJcbExPos = new HashSet<VirtualPosDefaults>();
            VirtualPosDefaultsJcbPos = new HashSet<VirtualPosDefaults>();
            VirtualPosDefaultsMaestroExPos = new HashSet<VirtualPosDefaults>();
            VirtualPosDefaultsMaestroPos = new HashSet<VirtualPosDefaults>();
            VirtualPosDefaultsMasterExPos = new HashSet<VirtualPosDefaults>();
            VirtualPosDefaultsMasterPos = new HashSet<VirtualPosDefaults>();
            VirtualPosDefaultsUnionpayExPos = new HashSet<VirtualPosDefaults>();
            VirtualPosDefaultsUnionpayPos = new HashSet<VirtualPosDefaults>();
            VirtualPosDefaultsVisaExPos = new HashSet<VirtualPosDefaults>();
            VirtualPosDefaultsVisaPos = new HashSet<VirtualPosDefaults>();
        }

        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(150)]
        public string Description { get; set; } = null!;
        [Column("NAME")]
        [StringLength(150)]
        public string? Name { get; set; }
        [Column("CLASS")]
        [StringLength(150)]
        public string Class { get; set; } = null!;
        [Column("CORPID")]
        public Guid Corpid { get; set; }
        [Column("BINNUMBER_NAME")]
        [StringLength(50)]
        public string? BinnumberName { get; set; }
        [Column("ACC_INV_CODE")]
        [StringLength(30)]
        public string? AccInvCode { get; set; }
        [Column("ACC_PAY_CODE")]
        [StringLength(30)]
        public string? AccPayCode { get; set; }
        [Column("INTID")]
        public int Intid { get; set; }
        [Column("ICONURL")]
        [StringLength(250)]
        public string? Iconurl { get; set; }
        [Column("FONTCOLOR")]
        [StringLength(20)]
        public string? Fontcolor { get; set; }
        [Column("FORECOLOR")]
        [StringLength(20)]
        public string? Forecolor { get; set; }
        [Column("XMLUSERNAME")]
        [StringLength(150)]
        public string? Xmlusername { get; set; }
        [Column("XMLPASSWORD")]
        [StringLength(150)]
        public string? Xmlpassword { get; set; }

        [ForeignKey(nameof(Corpid))]
        [InverseProperty("VirtualPos")]
        public virtual Corp Corp { get; set; } = null!;
        [InverseProperty("Pos")]
        public virtual ICollection<VirtualPosAccounts> VirtualPosAccounts { get; set; }
        [InverseProperty(nameof(VirtualPosDefaults.AmexExPos))]
        public virtual ICollection<VirtualPosDefaults> VirtualPosDefaultsAmexExPos { get; set; }
        [InverseProperty(nameof(VirtualPosDefaults.AmexPos))]
        public virtual ICollection<VirtualPosDefaults> VirtualPosDefaultsAmexPos { get; set; }
        [InverseProperty(nameof(VirtualPosDefaults.JcbExPos))]
        public virtual ICollection<VirtualPosDefaults> VirtualPosDefaultsJcbExPos { get; set; }
        [InverseProperty(nameof(VirtualPosDefaults.JcbPos))]
        public virtual ICollection<VirtualPosDefaults> VirtualPosDefaultsJcbPos { get; set; }
        [InverseProperty(nameof(VirtualPosDefaults.MaestroExPos))]
        public virtual ICollection<VirtualPosDefaults> VirtualPosDefaultsMaestroExPos { get; set; }
        [InverseProperty(nameof(VirtualPosDefaults.MaestroPos))]
        public virtual ICollection<VirtualPosDefaults> VirtualPosDefaultsMaestroPos { get; set; }
        [InverseProperty(nameof(VirtualPosDefaults.MasterExPos))]
        public virtual ICollection<VirtualPosDefaults> VirtualPosDefaultsMasterExPos { get; set; }
        [InverseProperty(nameof(VirtualPosDefaults.MasterPos))]
        public virtual ICollection<VirtualPosDefaults> VirtualPosDefaultsMasterPos { get; set; }
        [InverseProperty(nameof(VirtualPosDefaults.UnionpayExPos))]
        public virtual ICollection<VirtualPosDefaults> VirtualPosDefaultsUnionpayExPos { get; set; }
        [InverseProperty(nameof(VirtualPosDefaults.UnionpayPos))]
        public virtual ICollection<VirtualPosDefaults> VirtualPosDefaultsUnionpayPos { get; set; }
        [InverseProperty(nameof(VirtualPosDefaults.VisaExPos))]
        public virtual ICollection<VirtualPosDefaults> VirtualPosDefaultsVisaExPos { get; set; }
        [InverseProperty(nameof(VirtualPosDefaults.VisaPos))]
        public virtual ICollection<VirtualPosDefaults> VirtualPosDefaultsVisaPos { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
