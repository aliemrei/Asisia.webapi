using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class CashierHandover : EntityBase // My Handlebars Helper
    {
        public CashierHandover()
        {
            CashierHandoverEntity = new HashSet<CashierHandoverEntity>();
        }

        public Guid Id { get; set; }
        public Guid Userid { get; set; }
        public Guid Resourceid { get; set; }
        public Guid Corpid { get; set; }
        public DateTime Adddate { get; set; }
        public Guid Adduser { get; set; }
        public DateTime? Editdate { get; set; }
        public Guid? Edituser { get; set; }
        public bool Isenddate { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Corp Corp { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual Resources Resource { get; set; } = null!;
        public virtual Users User { get; set; } = null!;
        public virtual ICollection<CashierHandoverEntity> CashierHandoverEntity { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
