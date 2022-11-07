using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class REQUEST_CLIENTS : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public Guid? REQUEST_DETAILID { get; set; }
        public string? FIRSTNAME { get; set; }
        public string? LASTNAME { get; set; }
        public DateTime? BIRTHDATE { get; set; }
        public byte KIND { get; set; }
        public string? HESCODE { get; set; }
        public bool? GENDER { get; set; }
        public string? ENTID { get; set; }

        public virtual REQUEST_DETAIL? REQUEST_DETAIL { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
