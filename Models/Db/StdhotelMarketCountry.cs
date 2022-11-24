using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class StdhotelMarketCountry : EntityBase // My Handlebars Helper
    {
        public Guid? Id { get; set; }
        public Guid Hotelid { get; set; }
        public Guid Marketid { get; set; }
        public string Countrycode { get; set; } = null!;

        public virtual Stdhotel Hotel { get; set; } = null!;
        public virtual StdhotelMarket Market { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
