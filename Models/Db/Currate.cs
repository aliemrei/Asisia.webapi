using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class Currate : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public Guid Corpid { get; set; }
        public DateTime Ratedate { get; set; }
        public double Rate { get; set; }
        public string Curcode { get; set; } = null!;

        public virtual Corp Corp { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
