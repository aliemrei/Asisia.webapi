using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class STDHOTEL_PRICECONDITION_OCCUPANCY : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid PRICECONDITIONID { get; set; }
        public byte? ADULT { get; set; }
        public byte? CHDE { get; set; }
        public byte? CHDY { get; set; }
        public byte? BABY { get; set; }
        public double? GUESTPRICE_RATE { get; set; }
        public double? COSTPRICE_RATE { get; set; }
        public byte? TOTALCHD { get; set; }

        public virtual STDHOTEL_PRICECONDITION PRICECONDITION { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
