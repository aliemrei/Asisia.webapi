using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class USER_PROJECTS : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid USERID { get; set; }
        public Guid? PROJECT_GROUPID { get; set; }
        public bool ISDISABLED { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }

        public virtual PROJECT_GROUP? PROJECT_GROUP { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
