using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class DATA_DICTIONARY : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public string TABLENAME { get; set; } = null!;
        public Guid RECID { get; set; }
        public string FIELDNAME { get; set; } = null!;
        public string LANGCODE { get; set; } = null!;
        public string? VAL { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
