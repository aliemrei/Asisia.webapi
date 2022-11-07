using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class SNT_DIAL_PLAN : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid? PARENTID { get; set; }
        public Guid SWID { get; set; }
        public string GROUPNAME { get; set; } = null!;
        public int PRIORITY { get; set; }
        public string? APP { get; set; }
        public string? APPDATA { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
