using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class VirtualPosBinnumbers : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public string? Bankname { get; set; }
        public string? Binno { get; set; }
        public string? Schema { get; set; }
        public string? Type { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
