using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class VwHotelMarketCountry : EntityBase // My Handlebars Helper
    {
        public Guid? Id { get; set; }
        public Guid Hotelid { get; set; }
        public string Countrycode { get; set; } = null!;
        public Guid Corpid { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
