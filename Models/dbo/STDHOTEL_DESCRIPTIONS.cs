using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class STDHOTEL_DESCRIPTIONS : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public Guid? HOTELID { get; set; }
        public string? DESCRIPTION { get; set; }
        public string? CATEGORY { get; set; }
        public string? SEASON { get; set; }
        public Guid UID { get; set; }

        public virtual STDHOTEL? HOTEL { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
