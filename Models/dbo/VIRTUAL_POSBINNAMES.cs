using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class VIRTUAL_POSBINNAMES : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid POSID { get; set; }
        public string BINNUMBER_NAME { get; set; } = null!;

        public virtual VIRTUAL_POS POS { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
