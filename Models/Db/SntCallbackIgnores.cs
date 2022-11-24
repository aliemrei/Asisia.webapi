using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class SntCallbackIgnores : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public string Number { get; set; } = null!;
        public bool IsDisabled { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
