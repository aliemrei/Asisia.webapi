using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class VwIplocations : EntityBase 
    {
        [Column("ip_from")]
        [RequiredIf]
        public double IpFrom { get; set; }


        [Column("ip_to")]
        [RequiredIf]
        public double IpTo { get; set; }


        [Column("country_code")]
        [StringLength(2)]
        [RequiredIf]
        public string CountryCode { get; set; } = null!;


        [Column("country_name")]
        [StringLength(64)]
        [RequiredIf]
        public string CountryName { get; set; } = null!;


        [Column("region_name")]
        [StringLength(128)]
        [RequiredIf]
        public string RegionName { get; set; } = null!;


        [Column("city_name")]
        [StringLength(128)]
        [RequiredIf]
        public string CityName { get; set; } = null!;


        [Column("latitude")]
        [RequiredIf]
        public double Latitude { get; set; }


        [Column("longitude")]
        [RequiredIf]
        public double Longitude { get; set; }



            }
}
