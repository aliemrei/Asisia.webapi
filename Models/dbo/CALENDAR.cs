using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class CALENDAR : EntityBase // My Handlebars Helper
    {
        public DateTime DATE { get; set; }
        public byte? DAYOFWEEK { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
