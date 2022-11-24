using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class StdhotelExtras : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid Hotelid { get; set; }
        public string Definition { get; set; } = null!;
        public double? Price { get; set; }
        public string? Curcode { get; set; }
        public Guid? Exserviceid { get; set; }

        public virtual Stdhotel Hotel { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
