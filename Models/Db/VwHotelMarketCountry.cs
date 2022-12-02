using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class VwHotelMarketCountry : EntityBase // My Handlebars Helper
    {
        [Column("ID")]
        public Guid? Id { get; set; }
        [Column("HOTELID")]
        public Guid Hotelid { get; set; }
        [Column("COUNTRYCODE")]
        [StringLength(2)]
        public string Countrycode { get; set; } = null!;
        [Column("CORPID")]
        public Guid Corpid { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
