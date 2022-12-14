using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDHOTEL_RATECODE_MARKUP_MARKETS")]
    public partial class StdhotelRatecodeMarkupMarkets : EntityBase 
    {
        [Key]
        [Column("ID")]
        [RequiredIf]
        public int Id { get; set; }


        [Column("MARKUPID")]
        [RequiredIf]
        public Guid Markupid { get; set; }


        [Column("MARKETID")]
        [RequiredIf]
        public Guid Marketid { get; set; }



        [ForeignKey(nameof(Marketid))]
        [InverseProperty(nameof(StdhotelMarket.StdhotelRatecodeMarkupMarkets))]
        public virtual StdhotelMarket Market { get; set; } = null!;
        [ForeignKey(nameof(Markupid))]
        [InverseProperty(nameof(StdhotelRatecodeMarkup.StdhotelRatecodeMarkupMarkets))]
        public virtual StdhotelRatecodeMarkup Markup { get; set; } = null!;

            }
}
