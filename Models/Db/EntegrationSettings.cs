using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class EntegrationSettings : EntityBase // My Handlebars Helper
    {
        public DateTime? FirstDate { get; set; }
        public DateTime? LastDate { get; set; }
        public string? Enttype { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
