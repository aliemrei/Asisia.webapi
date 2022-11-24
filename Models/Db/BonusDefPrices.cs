using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class BonusDefPrices : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid BonusDefItemsid { get; set; }
        public double FirstAmount { get; set; }
        public double LastAmount { get; set; }
        public double Rate { get; set; }
        public DateTime Adddate { get; set; }
        public Guid Adduser { get; set; }
        public DateTime? Editdate { get; set; }
        public Guid? Edituser { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual BonusDefItems BonusDefItems { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
