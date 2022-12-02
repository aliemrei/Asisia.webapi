using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("CASHIER_HANDOVER")]
    public partial class CashierHandover : EntityBase // My Handlebars Helper
    {
        public CashierHandover()
        {
            CashierHandoverEntity = new HashSet<CashierHandoverEntity>();
        }

        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("USERID")]
        public Guid Userid { get; set; }
        [Column("RESOURCEID")]
        public Guid Resourceid { get; set; }
        [Column("CORPID")]
        public Guid Corpid { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("ADDUSER")]
        public Guid Adduser { get; set; }
        [Column("EDITDATE", TypeName = "datetime")]
        public DateTime? Editdate { get; set; }
        [Column("EDITUSER")]
        public Guid? Edituser { get; set; }
        [Column("ISENDDATE")]
        public bool Isenddate { get; set; }

        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.CashierHandoverAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Corpid))]
        [InverseProperty("CashierHandover")]
        public virtual Corp Corp { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.CashierHandoverEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [ForeignKey(nameof(Resourceid))]
        [InverseProperty(nameof(Resources.CashierHandover))]
        public virtual Resources Resource { get; set; } = null!;
        [ForeignKey(nameof(Userid))]
        [InverseProperty(nameof(Users.CashierHandoverUser))]
        public virtual Users User { get; set; } = null!;
        [InverseProperty("CashierHandover")]
        public virtual ICollection<CashierHandoverEntity> CashierHandoverEntity { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
