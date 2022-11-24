using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class ResourceBudget : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public DateTime Tdate { get; set; }
        public Guid Resourceid { get; set; }
        public double? Amount { get; set; }
        public string? Curcode { get; set; }
        public double? Ramount { get; set; }
        public double? IncomeAmount { get; set; }
        public Guid ProjectDetailid { get; set; }
        public Guid Corpid { get; set; }

        public virtual Corp Corp { get; set; } = null!;
        public virtual ProjectGroupdetail ProjectDetail { get; set; } = null!;
        public virtual Resources Resource { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
