using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class RequestDetailOrgdata : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid RequestDetailid { get; set; }
        public string? Jsondata { get; set; }

        public virtual RequestDetail RequestDetail { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
