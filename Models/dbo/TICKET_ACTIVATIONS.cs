using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class TICKET_ACTIVATIONS : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public Guid? REQUEST_DETAILID { get; set; }
        public string? GATENUMBER { get; set; }
        public string PERSONTYPE { get; set; } = null!;
        public int PERSONNO { get; set; }
        public DateTime ADDDATE { get; set; }
        public bool DIRECTION { get; set; }
        public bool ISALLOW { get; set; }
        public string? REASON { get; set; }

        public virtual TURNIKE? GATENUMBERNavigation { get; set; }
        public virtual REQUEST_DETAIL? REQUEST_DETAIL { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
