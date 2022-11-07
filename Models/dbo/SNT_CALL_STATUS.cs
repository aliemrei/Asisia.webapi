using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class SNT_CALL_STATUS : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public string DESCRIPTION { get; set; } = null!;
        public bool ISFINISHED { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
