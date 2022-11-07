using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class STDHOTEL_RATECODE_MARKUP_MARKETS : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public Guid MARKUPID { get; set; }
        public Guid MARKETID { get; set; }

        public virtual STDHOTEL_MARKET MARKET { get; set; } = null!;
        public virtual STDHOTEL_RATECODE_MARKUP MARKUP { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
