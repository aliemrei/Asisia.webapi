using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class StdhotelRatecodeDetailOccupancy : EntityBase // My Handlebars Helper
    {
        public Guid? Id { get; set; }
        public Guid Hotelid { get; set; }
        public Guid Ratecodedetailid { get; set; }
        public byte? Adult { get; set; }
        public byte? Chde { get; set; }
        public byte? Chdy { get; set; }
        public byte? Baby { get; set; }
        public decimal? Guestprice { get; set; }
        public decimal? Costprice { get; set; }
        public byte? Totalchd { get; set; }

        public virtual Stdhotel Hotel { get; set; } = null!;
        public virtual StdhotelRatecodeDetail Ratecodedetail { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
