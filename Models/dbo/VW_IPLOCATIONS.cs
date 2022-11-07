using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class VW_IPLOCATIONS : EntityBase // My Handlebars Helper
    {
        public double ip_from { get; set; }
        public double ip_to { get; set; }
        public string country_code { get; set; } = null!;
        public string country_name { get; set; } = null!;
        public string region_name { get; set; } = null!;
        public string city_name { get; set; } = null!;
        public double latitude { get; set; }
        public double longitude { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
