using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class STDHOTEL_RATECODE_DETAIL_OCCUPANCY : EntityBase // My Handlebars Helper
    {
        public Guid? ID { get; set; }
        public Guid HOTELID { get; set; }
        public Guid RATECODEDETAILID { get; set; }
        public byte? ADULT { get; set; }
        public byte? CHDE { get; set; }
        public byte? CHDY { get; set; }
        public byte? BABY { get; set; }
        public decimal? GUESTPRICE { get; set; }
        public decimal? COSTPRICE { get; set; }
        public byte? TOTALCHD { get; set; }

        public virtual STDHOTEL HOTEL { get; set; } = null!;
        public virtual STDHOTEL_RATECODE_DETAIL RATECODEDETAIL { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
