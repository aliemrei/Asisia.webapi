using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class TransferProviders : EntityBase // My Handlebars Helper
    {
        public TransferProviders()
        {
            TransferPrices = new HashSet<TransferPrices>();
        }

        public Guid Id { get; set; }
        public Guid Corpid { get; set; }
        public string Description { get; set; } = null!;
        public long? Tel1 { get; set; }
        public long? Tel2 { get; set; }
        public bool Isdeleted { get; set; }
        public bool Isdisabled { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Corp Corp { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual ICollection<TransferPrices> TransferPrices { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
