using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class StdhotelPriceconditionCalendar : EntityBase // My Handlebars Helper
    {
        public Guid Priceconditionid { get; set; }
        public DateTime Date { get; set; }
        public decimal? Baserate { get; set; }
        public int? Quota { get; set; }
        public bool? StopCheckin { get; set; }
        public bool? StopCheckout { get; set; }
        public bool? StopSell { get; set; }
        public int? ReleaseDay { get; set; }
        public int? MinLos { get; set; }
        public int? MaxLos { get; set; }
        public int? FreeSell { get; set; }
        public int Id { get; set; }
        public DateTime? Releasedate { get; set; }

        public virtual StdhotelPricecondition Pricecondition { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
