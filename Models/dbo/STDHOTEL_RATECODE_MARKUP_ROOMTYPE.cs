using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class STDHOTEL_RATECODE_MARKUP_ROOMTYPE : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public Guid MARKUPID { get; set; }
        public Guid ROOMTYPEID { get; set; }
        public double? RATE { get; set; }
        public double? AMOUNT { get; set; }
        public double? ADULT_PRICE { get; set; }
        public double? CHDE_PRICE { get; set; }
        public double? CHDY_PRICE { get; set; }
        public double? BABY_PRICE { get; set; }
        public bool BEFORE_DISCOUNT { get; set; }
        public double? LAST_RATE { get; set; }

        public virtual STDHOTEL_RATECODE_MARKUP MARKUP { get; set; } = null!;
        public virtual STDHOTEL_ROOMTYPES ROOMTYPE { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
