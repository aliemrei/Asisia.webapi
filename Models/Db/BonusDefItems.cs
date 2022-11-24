using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class BonusDefItems : EntityBase // My Handlebars Helper
    {
        public BonusDefItems()
        {
            BonusDefPrices = new HashSet<BonusDefPrices>();
        }

        public Guid Id { get; set; }
        public Guid BonusDefid { get; set; }
        public Guid Productid { get; set; }
        public Guid? Propertyid { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Adduser { get; set; }
        public DateTime? Editdate { get; set; }
        public Guid? Edituser { get; set; }

        public virtual Users? AdduserNavigation { get; set; }
        public virtual Users? EdituserNavigation { get; set; }
        public virtual ICollection<BonusDefPrices> BonusDefPrices { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
