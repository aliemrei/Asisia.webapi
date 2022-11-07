using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class ENTEGRATION_SETTINGS : EntityBase // My Handlebars Helper
    {
        public DateTime? FIRST_DATE { get; set; }
        public DateTime? LAST_DATE { get; set; }
        public string? ENTTYPE { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
