using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    [Table("STDHOTEL_MARKET_COUNTRY")]
    [Index(nameof(Id), Name = "UQ__STDHOTEL__3214EC26E0FACD80", IsUnique = true)]
    [Index(nameof(Countrycode), nameof(Marketid), Name = "UQ__STDHOTEL__DF754A0EFCBD2DB3", IsUnique = true)]
    public partial class StdhotelMarketCountry : EntityBase // My Handlebars Helper
    {
        [Column("ID")]
        public Guid? Id { get; set; }
        [Column("HOTELID")]
        public Guid Hotelid { get; set; }
        [Column("MARKETID")]
        public Guid Marketid { get; set; }
        [Column("COUNTRYCODE")]
        [StringLength(2)]
        [Unicode(false)]
        public string Countrycode { get; set; } = null!;

        [ForeignKey(nameof(Hotelid))]
        public virtual Stdhotel Hotel { get; set; } = null!;
        [ForeignKey(nameof(Marketid))]
        public virtual StdhotelMarket Market { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
