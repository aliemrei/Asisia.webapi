using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("TILE_ITEMOPTION")]
    [Index(nameof(Ticketid), Name = "UQ__TILE_ITE__19441072D123C1A9")]
    public partial class TileItemoption : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("TICKETID")]
        public Guid? Ticketid { get; set; }
        [Column("GRADIENT_BEGINCOLOR")]
        public int? GradientBegincolor { get; set; }
        [Column("GRADIENT_ENDCOLOR")]
        public int? GradientEndcolor { get; set; }
        [Column("ROW_COUNT")]
        public int RowCount { get; set; }
        [Column("BGIMAGE", TypeName = "image")]
        public byte[]? Bgimage { get; set; }
        [Column("BGIMAGE_MODE")]
        [StringLength(25)]
        public string? BgimageMode { get; set; }
        [Column("BGIMAGE_ALIGN")]
        [StringLength(35)]
        public string? BgimageAlign { get; set; }
        [Column("BGIMAGE2", TypeName = "image")]
        public byte[]? Bgimage2 { get; set; }
        [Column("BGIMAGE_MODE2")]
        [StringLength(25)]
        public string? BgimageMode2 { get; set; }
        [Column("BGIMAGE_ALIGN2")]
        [StringLength(25)]
        public string? BgimageAlign2 { get; set; }
        [Column("GIFTID")]
        public Guid? Giftid { get; set; }
        [Column("SORTORDER")]
        public int Sortorder { get; set; }
        [Column("GROUPID")]
        public short Groupid { get; set; }
        [Column("SIZE")]
        public byte Size { get; set; }

        [ForeignKey(nameof(Giftid))]
        [InverseProperty(nameof(TicketGifts.TileItemoption))]
        public virtual TicketGifts? Gift { get; set; }
        [ForeignKey(nameof(Ticketid))]
        [InverseProperty("TileItemoption")]
        public virtual Ticket? Ticket { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
