using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class STDBOARDTYPES : EntityBase // My Handlebars Helper
    {
        public STDBOARDTYPES()
        {
            STDHOTEL_BOARDTYPES = new HashSet<STDHOTEL_BOARDTYPES>();
        }

        public string BOARDTYPE { get; set; } = null!;

        public virtual ICollection<STDHOTEL_BOARDTYPES> STDHOTEL_BOARDTYPES { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
