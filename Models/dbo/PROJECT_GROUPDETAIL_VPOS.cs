using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class PROJECT_GROUPDETAIL_VPOS : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid PROJECT_DETAILID { get; set; }
        public Guid ACCOUNTID { get; set; }
        public bool ISDISABLED { get; set; }
        public bool ISDEFAULT { get; set; }
        public string? CURCODES { get; set; }
        public string? CARDBRANDS { get; set; }

        public virtual PROJECT_GROUPDETAIL PROJECT_DETAIL { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
