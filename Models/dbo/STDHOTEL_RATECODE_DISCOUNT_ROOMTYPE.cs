using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class STDHOTEL_RATECODE_DISCOUNT_ROOMTYPE : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public Guid DISCOUNTID { get; set; }
        public Guid ROOMTYPEID { get; set; }

        public virtual STDHOTEL_RATECODE_DISCOUNT DISCOUNT { get; set; } = null!;
        public virtual STDHOTEL_ROOMTYPES ROOMTYPE { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
