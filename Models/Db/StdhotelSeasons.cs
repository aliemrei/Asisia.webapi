using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class StdhotelSeasons : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public Guid? Hotelid { get; set; }
        public DateTime? Seasonstart { get; set; }
        public DateTime? Seasonfinish { get; set; }

        public virtual Stdhotel? Hotel { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
