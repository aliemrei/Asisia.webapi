using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class StdhotelPriceconditionOccupancy : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid Priceconditionid { get; set; }
        public byte? Adult { get; set; }
        public byte? Chde { get; set; }
        public byte? Chdy { get; set; }
        public byte? Baby { get; set; }
        public double? GuestpriceRate { get; set; }
        public double? CostpriceRate { get; set; }
        public byte? Totalchd { get; set; }

        public virtual StdhotelPricecondition Pricecondition { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
