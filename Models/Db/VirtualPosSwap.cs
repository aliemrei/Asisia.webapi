using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class VirtualPosSwap : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid Posid1 { get; set; }
        public Guid Posid2 { get; set; }

        public virtual VirtualPos Posid1Navigation { get; set; } = null!;
        public virtual VirtualPos Posid2Navigation { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
