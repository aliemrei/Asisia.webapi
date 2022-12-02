using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    [Table("RESOURCE_BUDGET")]
    public partial class ResourceBudget : EntityBase // My Handlebars Helper
    {
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("TDATE", TypeName = "date")]
        public DateTime Tdate { get; set; }
        [Column("RESOURCEID")]
        public Guid Resourceid { get; set; }
        [Column("AMOUNT")]
        public double? Amount { get; set; }
        [Column("CURCODE")]
        [StringLength(5)]
        [Unicode(false)]
        public string? Curcode { get; set; }
        [Column("RAMOUNT")]
        public double? Ramount { get; set; }
        [Column("INCOME_AMOUNT")]
        public double? IncomeAmount { get; set; }
        [Column("PROJECT_DETAILID")]
        public Guid ProjectDetailid { get; set; }
        [Column("CORPID")]
        public Guid Corpid { get; set; }

        [ForeignKey(nameof(Corpid))]
        public virtual Corp Corp { get; set; } = null!;
        [ForeignKey(nameof(ProjectDetailid))]
        public virtual ProjectGroupdetail ProjectDetail { get; set; } = null!;
        [ForeignKey(nameof(Resourceid))]
        public virtual Resources Resource { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
