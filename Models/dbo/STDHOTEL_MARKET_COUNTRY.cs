using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class STDHOTEL_MARKET_COUNTRY : EntityBase // My Handlebars Helper
    {
        public Guid? ID { get; set; }
        public Guid HOTELID { get; set; }
        public Guid MARKETID { get; set; }
        public string COUNTRYCODE { get; set; } = null!;

        public virtual STDHOTEL HOTEL { get; set; } = null!;
        public virtual STDHOTEL_MARKET MARKET { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
