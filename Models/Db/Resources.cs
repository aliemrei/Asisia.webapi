using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class Resources : EntityBase // My Handlebars Helper
    {
        public Resources()
        {
            Campaigns = new HashSet<Campaigns>();
            CashierHandover = new HashSet<CashierHandover>();
            Payments = new HashSet<Payments>();
            RequestDetail = new HashSet<RequestDetail>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
        public Guid Corpid { get; set; }
        public Guid? Masterid { get; set; }
        public bool Isdeleted { get; set; }
        public bool CostBudget { get; set; }
        public string? DefaultDirectBranding { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public string? RakamDesc { get; set; }
        public string? Icon { get; set; }
        public string? Resourcespath { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Corp Corp { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual ICollection<Campaigns> Campaigns { get; set; }
        public virtual ICollection<CashierHandover> CashierHandover { get; set; }
        public virtual ICollection<Payments> Payments { get; set; }
        public virtual ICollection<RequestDetail> RequestDetail { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
