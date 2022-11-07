using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class VW_PRODUCTS : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid CORPID { get; set; }
        public string? NAME { get; set; }
        public string? TYPE { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
