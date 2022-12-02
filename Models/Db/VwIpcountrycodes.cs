using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class VwIpcountrycodes : EntityBase // My Handlebars Helper
    {
        [Column("country_code")]
        [StringLength(2)]
        public string CountryCode { get; set; } = null!;
        [Column("country_name")]
        [StringLength(64)]
        public string CountryName { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
