using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("RESOURCES")]
    [Index(nameof(Code), nameof(Corpid), Name = "IX_RESOURCES", IsUnique = true)]
    public partial class Resources : EntityBase // My Handlebars Helper
    {
        public Resources()
        {
            Campaigns = new HashSet<Campaigns>();
            CashierHandover = new HashSet<CashierHandover>();
            Payments = new HashSet<Payments>();
            RequestDetail = new HashSet<RequestDetail>();
        }

        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("CODE")]
        [StringLength(30)]
        public string Code { get; set; } = null!;
        [Column("DESCRIPTION")]
        [StringLength(150)]
        public string Description { get; set; } = null!;
        [Column("CORPID")]
        public Guid Corpid { get; set; }
        [Column("MASTERID")]
        public Guid? Masterid { get; set; }
        [Column("ISDELETED")]
        public bool Isdeleted { get; set; }
        [Column("COST_BUDGET")]
        public bool CostBudget { get; set; }
        [Column("DEFAULT_DIRECT_BRANDING")]
        [StringLength(15)]
        public string? DefaultDirectBranding { get; set; }
        [Column("ADDUSER")]
        public Guid Adduser { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("EDITUSER")]
        public Guid? Edituser { get; set; }
        [Column("EDITDATE", TypeName = "datetime")]
        public DateTime? Editdate { get; set; }
        [Column("RAKAM_DESC")]
        [StringLength(50)]
        public string? RakamDesc { get; set; }
        [Column("ICON")]
        [StringLength(35)]
        public string? Icon { get; set; }
        [Column("RESOURCESPATH")]
        [StringLength(500)]
        public string? Resourcespath { get; set; }

        [ForeignKey(nameof(Adduser))]
        [InverseProperty(nameof(Users.ResourcesAdduserNavigation))]
        public virtual Users AdduserNavigation { get; set; } = null!;
        [ForeignKey(nameof(Corpid))]
        [InverseProperty("Resources")]
        public virtual Corp Corp { get; set; } = null!;
        [ForeignKey(nameof(Edituser))]
        [InverseProperty(nameof(Users.ResourcesEdituserNavigation))]
        public virtual Users? EdituserNavigation { get; set; }
        [InverseProperty("Resource")]
        public virtual ICollection<Campaigns> Campaigns { get; set; }
        [InverseProperty("Resource")]
        public virtual ICollection<CashierHandover> CashierHandover { get; set; }
        [InverseProperty("Resource")]
        public virtual ICollection<Payments> Payments { get; set; }
        [InverseProperty("Resource")]
        public virtual ICollection<RequestDetail> RequestDetail { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
