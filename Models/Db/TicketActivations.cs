using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class TicketActivations : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public Guid? RequestDetailid { get; set; }
        public string? Gatenumber { get; set; }
        public string Persontype { get; set; } = null!;
        public int Personno { get; set; }
        public DateTime Adddate { get; set; }
        public bool Direction { get; set; }
        public bool Isallow { get; set; }
        public string? Reason { get; set; }

        public virtual Turnike? GatenumberNavigation { get; set; }
        public virtual RequestDetail? RequestDetail { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
