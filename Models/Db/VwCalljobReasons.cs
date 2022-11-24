using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class VwCalljobReasons : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public string Reason { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
