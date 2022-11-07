using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class SIL : EntityBase // My Handlebars Helper
    {
        public string? name { get; set; }
        public string? dial_code { get; set; }
        public string? code { get; set; }
        public Guid? ID { get; set; }
        public string? ISOCODE2 { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
