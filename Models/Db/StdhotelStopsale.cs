using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("STDHOTEL_STOPSALE")]
    [Index(nameof(Corpid), Name = "IX_CORP")]
    public partial class StdhotelStopsale : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("CORPID")]
        public Guid Corpid { get; set; }
        [Column("PRICECONDITIONID")]
        public Guid? Priceconditionid { get; set; }
        [Column("FROMDATE", TypeName = "date")]
        public DateTime Fromdate { get; set; }
        [Column("TODATE", TypeName = "date")]
        public DateTime Todate { get; set; }
        [Column("ISDISABLED")]
        public bool Isdisabled { get; set; }

        [ForeignKey(nameof(Corpid))]
        [InverseProperty("StdhotelStopsale")]
        public virtual Corp Corp { get; set; } = null!;
        [ForeignKey(nameof(Priceconditionid))]
        [InverseProperty(nameof(StdhotelPricecondition.StdhotelStopsale))]
        public virtual StdhotelPricecondition? Pricecondition { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
