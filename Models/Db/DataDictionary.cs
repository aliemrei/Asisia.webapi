using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class DataDictionary : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public string Tablename { get; set; } = null!;
        public Guid Recid { get; set; }
        public string Fieldname { get; set; } = null!;
        public string Langcode { get; set; } = null!;
        public string? Val { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
