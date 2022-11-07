using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class VIRTUAL_POS_SWAP : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid POSID1 { get; set; }
        public Guid POSID2 { get; set; }

        public virtual VIRTUAL_POS POSID1Navigation { get; set; } = null!;
        public virtual VIRTUAL_POS POSID2Navigation { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
