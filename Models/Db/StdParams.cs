using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class StdParams : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public Guid Corpid { get; set; }
        public string? Paramname { get; set; }
        public string? Paramvalue { get; set; }
        public string? Groupname { get; set; }

        public virtual Corp Corp { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
