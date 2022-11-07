using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class CURRATE : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public Guid CORPID { get; set; }
        public DateTime RATEDATE { get; set; }
        public double RATE { get; set; }
        public string CURCODE { get; set; } = null!;

        public virtual CORP CORP { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
