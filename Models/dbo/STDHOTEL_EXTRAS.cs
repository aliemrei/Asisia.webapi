using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class STDHOTEL_EXTRAS : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid HOTELID { get; set; }
        public string DEFINITION { get; set; } = null!;
        public double? PRICE { get; set; }
        public string? CURCODE { get; set; }
        public Guid? EXSERVICEID { get; set; }

        public virtual STDHOTEL HOTEL { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
