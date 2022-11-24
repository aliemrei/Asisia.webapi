using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class TicketGifts : EntityBase // My Handlebars Helper
    {
        public TicketGifts()
        {
            RequestDetail = new HashSet<RequestDetail>();
            TileItemoption = new HashSet<TileItemoption>();
        }

        public Guid Id { get; set; }
        public Guid Corpid { get; set; }
        public string Definition { get; set; } = null!;
        public double? Price { get; set; }
        public string Curcode { get; set; } = null!;
        public bool Isdisabled { get; set; }
        public string? Plu { get; set; }

        public virtual Corp Corp { get; set; } = null!;
        public virtual Curcode CurcodeNavigation { get; set; } = null!;
        public virtual ICollection<RequestDetail> RequestDetail { get; set; }
        public virtual ICollection<TileItemoption> TileItemoption { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
