using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class TILE_ITEMOPTION : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public Guid? TICKETID { get; set; }
        public int? GRADIENT_BEGINCOLOR { get; set; }
        public int? GRADIENT_ENDCOLOR { get; set; }
        public int ROW_COUNT { get; set; }
        public byte[]? BGIMAGE { get; set; }
        public string? BGIMAGE_MODE { get; set; }
        public string? BGIMAGE_ALIGN { get; set; }
        public byte[]? BGIMAGE2 { get; set; }
        public string? BGIMAGE_MODE2 { get; set; }
        public string? BGIMAGE_ALIGN2 { get; set; }
        public Guid? GIFTID { get; set; }
        public int SORTORDER { get; set; }
        public short GROUPID { get; set; }
        public byte SIZE { get; set; }

        public virtual TICKET_GIFTS? GIFT { get; set; }
        public virtual TICKET? TICKET { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
