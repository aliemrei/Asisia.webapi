using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class VW_LOCATIONS : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public string DEFINITION { get; set; } = null!;
        public Guid CORPID { get; set; }
        public string TYPE { get; set; } = null!;
        public string? CODE { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
