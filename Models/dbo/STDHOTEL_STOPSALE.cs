using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class STDHOTEL_STOPSALE : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public Guid CORPID { get; set; }
        public Guid? PRICECONDITIONID { get; set; }
        public DateTime FROMDATE { get; set; }
        public DateTime TODATE { get; set; }
        public bool ISDISABLED { get; set; }

        public virtual CORP CORP { get; set; } = null!;
        public virtual STDHOTEL_PRICECONDITION? PRICECONDITION { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
