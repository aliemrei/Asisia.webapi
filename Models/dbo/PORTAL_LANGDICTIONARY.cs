using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class PORTAL_LANGDICTIONARY : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public string? tr_TR { get; set; }
        public string? en_US { get; set; }
        public string? de_DE { get; set; }
        public string? ru_RU { get; set; }
        public string? ar_SA { get; set; }
        public string? KEYVALUE2 { get; set; }
        public string? KEYVALUE { get; set; }
        public string? fi_FI { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
