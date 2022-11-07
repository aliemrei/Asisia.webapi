using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class DB_LOG : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public string? LOGTEXT { get; set; }
        public string? TRACEFLAG { get; set; }
        public Guid? GROUPID { get; set; }
        public string? TABLENAME { get; set; }
        public string? RECID { get; set; }
        public string? USERCODE { get; set; }
        public DateTime LOGTIME { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
