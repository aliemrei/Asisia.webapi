using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class IntegrationErrors : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public int? Insertid { get; set; }
        public string? Errortext { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
