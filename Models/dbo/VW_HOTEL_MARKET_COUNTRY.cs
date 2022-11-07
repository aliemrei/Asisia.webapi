using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class VW_HOTEL_MARKET_COUNTRY : EntityBase // My Handlebars Helper
    {
        public Guid? ID { get; set; }
        public Guid HOTELID { get; set; }
        public string COUNTRYCODE { get; set; } = null!;
        public Guid CORPID { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
