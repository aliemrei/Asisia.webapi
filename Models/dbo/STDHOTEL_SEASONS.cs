using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class STDHOTEL_SEASONS : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public Guid? HOTELID { get; set; }
        public DateTime? SEASONSTART { get; set; }
        public DateTime? SEASONFINISH { get; set; }

        public virtual STDHOTEL? HOTEL { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
