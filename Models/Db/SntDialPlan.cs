using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class SntDialPlan : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid? Parentid { get; set; }
        public Guid Swid { get; set; }
        public string Groupname { get; set; } = null!;
        public int Priority { get; set; }
        public string? App { get; set; }
        public string? Appdata { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
