using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("PROPERTY_MAPPING")]
    [Index(nameof(Hotelid), nameof(Boardtypeid), nameof(Providerid), Name = "IX_PROPERTY_MAPPING")]
    [Index(nameof(Hotelid), nameof(Roomid), nameof(Providerid), Name = "IX_PROPERTY_MAPPING_1")]
    [Index(nameof(Hotelid), nameof(Providerid), nameof(Ratetypeid), Name = "IX_PROPERTY_MAPPING_2")]
    public partial class PropertyMapping : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("PROVIDERID")]
        public Guid Providerid { get; set; }
        [Column("HOTELID")]
        public Guid Hotelid { get; set; }
        [Column("ROOMID")]
        public Guid? Roomid { get; set; }
        [Column("BOARDTYPEID")]
        public Guid? Boardtypeid { get; set; }
        [Column("RATETYPEID")]
        public Guid? Ratetypeid { get; set; }
        [Column("CODE")]
        [StringLength(150)]
        public string? Code { get; set; }

        [ForeignKey(nameof(Boardtypeid))]
        [InverseProperty(nameof(StdhotelBoardtypes.PropertyMapping))]
        public virtual StdhotelBoardtypes? Boardtype { get; set; }
        [ForeignKey(nameof(Hotelid))]
        [InverseProperty(nameof(Stdhotel.PropertyMapping))]
        public virtual Stdhotel Hotel { get; set; } = null!;
        [ForeignKey(nameof(Providerid))]
        [InverseProperty(nameof(PropertyProviders.PropertyMapping))]
        public virtual PropertyProviders Provider { get; set; } = null!;
        [ForeignKey(nameof(Ratetypeid))]
        [InverseProperty(nameof(StdhotelRatetype.PropertyMapping))]
        public virtual StdhotelRatetype? Ratetype { get; set; }
        [ForeignKey(nameof(Roomid))]
        [InverseProperty(nameof(StdhotelRoomtypes.PropertyMapping))]
        public virtual StdhotelRoomtypes? Room { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
