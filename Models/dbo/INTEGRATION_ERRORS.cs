using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class INTEGRATION_ERRORS : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public int? INSERTID { get; set; }
        public string? ERRORTEXT { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
