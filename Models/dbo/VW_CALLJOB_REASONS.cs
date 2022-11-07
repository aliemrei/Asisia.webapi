using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class VW_CALLJOB_REASONS : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public string REASON { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
