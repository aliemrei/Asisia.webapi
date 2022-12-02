using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    [Table("STDHOTEL_SEASONS")]
    public partial class StdhotelSeasons : EntityBase // My Handlebars Helper
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("HOTELID")]
        public Guid? Hotelid { get; set; }
        [Column("SEASONSTART", TypeName = "datetime")]
        public DateTime? Seasonstart { get; set; }
        [Column("SEASONFINISH", TypeName = "datetime")]
        public DateTime? Seasonfinish { get; set; }

        [ForeignKey(nameof(Hotelid))]
        public virtual Stdhotel? Hotel { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
