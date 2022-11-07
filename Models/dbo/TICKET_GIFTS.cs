using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class TICKET_GIFTS : EntityBase // My Handlebars Helper
    {
        public TICKET_GIFTS()
        {
            REQUEST_DETAIL = new HashSet<REQUEST_DETAIL>();
            TILE_ITEMOPTION = new HashSet<TILE_ITEMOPTION>();
        }

        public Guid ID { get; set; }
        public Guid CORPID { get; set; }
        public string DEFINITION { get; set; } = null!;
        public double? PRICE { get; set; }
        public string CURCODE { get; set; } = null!;
        public bool ISDISABLED { get; set; }
        public string? PLU { get; set; }

        public virtual CORP CORP { get; set; } = null!;
        public virtual CURCODE CURCODENavigation { get; set; } = null!;
        public virtual ICollection<REQUEST_DETAIL> REQUEST_DETAIL { get; set; }
        public virtual ICollection<TILE_ITEMOPTION> TILE_ITEMOPTION { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
