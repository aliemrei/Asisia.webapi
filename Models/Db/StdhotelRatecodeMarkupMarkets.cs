using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDHOTEL_RATECODE_MARKUP_MARKETS")]
    public partial class StdhotelRatecodeMarkupMarkets : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("MARKUPID")]
        public Guid Markupid { get; set; }
        [Column("MARKETID")]
        public Guid Marketid { get; set; }

        [ForeignKey(nameof(Marketid))]
        [InverseProperty(nameof(StdhotelMarket.StdhotelRatecodeMarkupMarkets))]
        public virtual StdhotelMarket Market { get; set; } = null!;
        [ForeignKey(nameof(Markupid))]
        [InverseProperty(nameof(StdhotelRatecodeMarkup.StdhotelRatecodeMarkupMarkets))]
        public virtual StdhotelRatecodeMarkup Markup { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
