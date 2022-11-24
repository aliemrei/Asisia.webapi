using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class Calendar : EntityBase // My Handlebars Helper
    {
        public DateTime Date { get; set; }
        public byte? Dayofweek { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
