using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class StdhotelRatecodeMarkupRoomtype : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public Guid Markupid { get; set; }
        public Guid Roomtypeid { get; set; }
        public double? Rate { get; set; }
        public double? Amount { get; set; }
        public double? AdultPrice { get; set; }
        public double? ChdePrice { get; set; }
        public double? ChdyPrice { get; set; }
        public double? BabyPrice { get; set; }
        public bool BeforeDiscount { get; set; }
        public double? LastRate { get; set; }

        public virtual StdhotelRatecodeMarkup Markup { get; set; } = null!;
        public virtual StdhotelRoomtypes Roomtype { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
