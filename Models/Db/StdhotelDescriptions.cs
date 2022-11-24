using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class StdhotelDescriptions : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public Guid? Hotelid { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public string? Season { get; set; }
        public Guid Uid { get; set; }

        public virtual Stdhotel? Hotel { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
