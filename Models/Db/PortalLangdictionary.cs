using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class PortalLangdictionary : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public string? TrTr { get; set; }
        public string? EnUs { get; set; }
        public string? DeDe { get; set; }
        public string? RuRu { get; set; }
        public string? ArSa { get; set; }
        public string? Keyvalue2 { get; set; }
        public string? Keyvalue { get; set; }
        public string? FiFi { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
