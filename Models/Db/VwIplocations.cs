using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class VwIplocations : EntityBase // My Handlebars Helper
    {
        public double IpFrom { get; set; }
        public double IpTo { get; set; }
        public string CountryCode { get; set; } = null!;
        public string CountryName { get; set; } = null!;
        public string RegionName { get; set; } = null!;
        public string CityName { get; set; } = null!;
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
