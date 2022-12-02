using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("VIRTUAL_POS_DEFAULTS")]
    public partial class VirtualPosDefaults : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("CORPID")]
        public Guid Corpid { get; set; }
        [Column("PORTALUID")]
        public Guid Portaluid { get; set; }
        [Column("VISA_POSID")]
        public Guid? VisaPosid { get; set; }
        [Column("MASTER_POSID")]
        public Guid? MasterPosid { get; set; }
        [Column("AMEX_POSID")]
        public Guid? AmexPosid { get; set; }
        [Column("JCB_POSID")]
        public Guid? JcbPosid { get; set; }
        [Column("UNIONPAY_POSID")]
        public Guid? UnionpayPosid { get; set; }
        [Column("MAESTRO_POSID")]
        public Guid? MaestroPosid { get; set; }
        [Column("VISA_EX_POSID")]
        public Guid? VisaExPosid { get; set; }
        [Column("MASTER_EX_POSID")]
        public Guid? MasterExPosid { get; set; }
        [Column("AMEX_EX_POSID")]
        public Guid? AmexExPosid { get; set; }
        [Column("JCB_EX_POSID")]
        public Guid? JcbExPosid { get; set; }
        [Column("UNIONPAY_EX_POSID")]
        public Guid? UnionpayExPosid { get; set; }
        [Column("MAESTRO_EX_POSID")]
        public Guid? MaestroExPosid { get; set; }
        [Column("ADDUSER")]
        public Guid Adduser { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("EDITUSER")]
        public Guid? Edituser { get; set; }
        [Column("EDITDATE", TypeName = "datetime")]
        public DateTime? Editdate { get; set; }

        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.VirtualPosDefaultsAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(AmexExPosid))]
        [InverseProperty(nameof(VirtualPos.VirtualPosDefaultsAmexExPos))]
        public virtual VirtualPos? AmexExPos { get; set; }
        [ForeignKey(nameof(AmexPosid))]
        [InverseProperty(nameof(VirtualPos.VirtualPosDefaultsAmexPos))]
        public virtual VirtualPos? AmexPos { get; set; }
        [ForeignKey(nameof(Corpid))]
        [InverseProperty("VirtualPosDefaults")]
        public virtual Corp Corp { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.VirtualPosDefaultsEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(JcbExPosid))]
        [InverseProperty(nameof(VirtualPos.VirtualPosDefaultsJcbExPos))]
        public virtual VirtualPos? JcbExPos { get; set; }
        [ForeignKey(nameof(JcbPosid))]
        [InverseProperty(nameof(VirtualPos.VirtualPosDefaultsJcbPos))]
        public virtual VirtualPos? JcbPos { get; set; }
        [ForeignKey(nameof(MaestroExPosid))]
        [InverseProperty(nameof(VirtualPos.VirtualPosDefaultsMaestroExPos))]
        public virtual VirtualPos? MaestroExPos { get; set; }
        [ForeignKey(nameof(MaestroPosid))]
        [InverseProperty(nameof(VirtualPos.VirtualPosDefaultsMaestroPos))]
        public virtual VirtualPos? MaestroPos { get; set; }
        [ForeignKey(nameof(MasterExPosid))]
        [InverseProperty(nameof(VirtualPos.VirtualPosDefaultsMasterExPos))]
        public virtual VirtualPos? MasterExPos { get; set; }
        [ForeignKey(nameof(MasterPosid))]
        [InverseProperty(nameof(VirtualPos.VirtualPosDefaultsMasterPos))]
        public virtual VirtualPos? MasterPos { get; set; }
        public virtual Portal Portalu { get; set; } = null!;
        [ForeignKey(nameof(UnionpayExPosid))]
        [InverseProperty(nameof(VirtualPos.VirtualPosDefaultsUnionpayExPos))]
        public virtual VirtualPos? UnionpayExPos { get; set; }
        [ForeignKey(nameof(UnionpayPosid))]
        [InverseProperty(nameof(VirtualPos.VirtualPosDefaultsUnionpayPos))]
        public virtual VirtualPos? UnionpayPos { get; set; }
        [ForeignKey(nameof(VisaExPosid))]
        [InverseProperty(nameof(VirtualPos.VirtualPosDefaultsVisaExPos))]
        public virtual VirtualPos? VisaExPos { get; set; }
        [ForeignKey(nameof(VisaPosid))]
        [InverseProperty(nameof(VirtualPos.VirtualPosDefaultsVisaPos))]
        public virtual VirtualPos? VisaPos { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
