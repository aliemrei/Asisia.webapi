using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class VIRTUAL_POS_BINNUMBERS : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public string? BANKNAME { get; set; }
        public string? BINNO { get; set; }
        public string? SCHEMA { get; set; }
        public string? TYPE { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
