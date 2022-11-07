using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class VW_PROJECT_GROUP : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public string NAME { get; set; } = null!;
        public Guid? CORPID { get; set; }
        public bool MERGECLIENTS { get; set; }
        public bool USEALTERNATES { get; set; }
        public bool ISDELETED { get; set; }
        public bool ISDISABLED { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
