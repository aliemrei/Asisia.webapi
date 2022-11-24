using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class SntCallStatus : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public string Description { get; set; } = null!;
        public bool Isfinished { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
