using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class Sil : EntityBase // My Handlebars Helper
    {
        public string? Name { get; set; }
        public string? DialCode { get; set; }
        public string? Code { get; set; }
        public Guid? Id { get; set; }
        public string? Isocode2 { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
