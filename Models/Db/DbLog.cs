using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class DbLog : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public string? Logtext { get; set; }
        public string? Traceflag { get; set; }
        public Guid? Groupid { get; set; }
        public string? Tablename { get; set; }
        public string? Recid { get; set; }
        public string? Usercode { get; set; }
        public DateTime Logtime { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
