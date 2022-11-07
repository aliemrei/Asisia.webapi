using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class STD_PARAMS : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public Guid CORPID { get; set; }
        public string? PARAMNAME { get; set; }
        public string? PARAMVALUE { get; set; }
        public string? GROUPNAME { get; set; }

        public virtual CORP CORP { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
