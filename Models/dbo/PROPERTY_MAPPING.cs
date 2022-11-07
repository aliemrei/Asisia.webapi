using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class PROPERTY_MAPPING : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public Guid PROVIDERID { get; set; }
        public Guid HOTELID { get; set; }
        public Guid? ROOMID { get; set; }
        public Guid? BOARDTYPEID { get; set; }
        public Guid? RATETYPEID { get; set; }
        public string? CODE { get; set; }

        public virtual STDHOTEL_BOARDTYPES? BOARDTYPE { get; set; }
        public virtual STDHOTEL HOTEL { get; set; } = null!;
        public virtual PROPERTY_PROVIDERS PROVIDER { get; set; } = null!;
        public virtual STDHOTEL_RATETYPE? RATETYPE { get; set; }
        public virtual STDHOTEL_ROOMTYPES? ROOM { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
