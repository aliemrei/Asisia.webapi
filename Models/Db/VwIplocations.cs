using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class VwIplocations : EntityBase // My Handlebars Helper
    {
        [Column("ip_from")]
        public double IpFrom { get; set; }
        [Column("ip_to")]
        public double IpTo { get; set; }
        [Column("country_code")]
        [StringLength(2)]
        public string CountryCode { get; set; } = null!;
        [Column("country_name")]
        [StringLength(64)]
        public string CountryName { get; set; } = null!;
        [Column("region_name")]
        [StringLength(128)]
        public string RegionName { get; set; } = null!;
        [Column("city_name")]
        [StringLength(128)]
        public string CityName { get; set; } = null!;
        [Column("latitude")]
        public double Latitude { get; set; }
        [Column("longitude")]
        public double Longitude { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
