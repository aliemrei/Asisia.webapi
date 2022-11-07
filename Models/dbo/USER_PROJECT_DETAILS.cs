using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class USER_PROJECT_DETAILS : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid USERID { get; set; }
        public Guid? PROJECT_GROUPDETAILID { get; set; }
        public bool ISDISABLED { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }

        public virtual PROJECT_GROUPDETAIL? PROJECT_GROUPDETAIL { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
