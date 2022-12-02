using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    [Table("STDHOTEL_RATECODE_DETAIL_OCCUPANCY")]
    [Index(nameof(Id), Name = "UQ__STDHOTEL__3214EC264DFD2C06", IsUnique = true)]
    [Index(nameof(Ratecodedetailid), nameof(Adult), nameof(Chde), nameof(Chdy), nameof(Baby), nameof(Totalchd), Name = "UQ__STDHOTEL__57C4B69A2CE4E4FF", IsUnique = true)]
    public partial class StdhotelRatecodeDetailOccupancy : EntityBase // My Handlebars Helper
    {
        [Column("ID")]
        public Guid? Id { get; set; }
        [Column("HOTELID")]
        public Guid Hotelid { get; set; }
        [Column("RATECODEDETAILID")]
        public Guid Ratecodedetailid { get; set; }
        [Column("ADULT")]
        public byte? Adult { get; set; }
        [Column("CHDE")]
        public byte? Chde { get; set; }
        [Column("CHDY")]
        public byte? Chdy { get; set; }
        [Column("BABY")]
        public byte? Baby { get; set; }
        [Column("GUESTPRICE", TypeName = "decimal(19, 2)")]
        public decimal? Guestprice { get; set; }
        [Column("COSTPRICE", TypeName = "decimal(19, 2)")]
        public decimal? Costprice { get; set; }
        [Column("TOTALCHD")]
        public byte? Totalchd { get; set; }

        [ForeignKey(nameof(Hotelid))]
        public virtual Stdhotel Hotel { get; set; } = null!;
        [ForeignKey(nameof(Ratecodedetailid))]
        public virtual StdhotelRatecodeDetail Ratecodedetail { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
