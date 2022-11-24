using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class TileItemoption : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public Guid? Ticketid { get; set; }
        public int? GradientBegincolor { get; set; }
        public int? GradientEndcolor { get; set; }
        public int RowCount { get; set; }
        public byte[]? Bgimage { get; set; }
        public string? BgimageMode { get; set; }
        public string? BgimageAlign { get; set; }
        public byte[]? Bgimage2 { get; set; }
        public string? BgimageMode2 { get; set; }
        public string? BgimageAlign2 { get; set; }
        public Guid? Giftid { get; set; }
        public int Sortorder { get; set; }
        public short Groupid { get; set; }
        public byte Size { get; set; }

        public virtual TicketGifts? Gift { get; set; }
        public virtual Ticket? Ticket { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
