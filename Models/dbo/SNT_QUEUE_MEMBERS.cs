using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class SNT_QUEUE_MEMBERS : EntityBase // My Handlebars Helper
    {
        public int uniqueid { get; set; }
        public string? membername { get; set; }
        public string? queue_name { get; set; }
        public string? _interface { get; set; }
        public int? penalty { get; set; }
        public int? paused { get; set; }
        public Guid queueid { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
