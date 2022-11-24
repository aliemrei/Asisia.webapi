using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class StdhotelStopsale : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public Guid Corpid { get; set; }
        public Guid? Priceconditionid { get; set; }
        public DateTime Fromdate { get; set; }
        public DateTime Todate { get; set; }
        public bool Isdisabled { get; set; }

        public virtual Corp Corp { get; set; } = null!;
        public virtual StdhotelPricecondition? Pricecondition { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
