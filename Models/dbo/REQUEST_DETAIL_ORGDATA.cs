using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class REQUEST_DETAIL_ORGDATA : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid REQUEST_DETAILID { get; set; }
        public string? JSONDATA { get; set; }

        public virtual REQUEST_DETAIL REQUEST_DETAIL { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
