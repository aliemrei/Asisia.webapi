using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class UserProjects : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid Userid { get; set; }
        public Guid? ProjectGroupid { get; set; }
        public bool Isdisabled { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }

        public virtual ProjectGroup? ProjectGroup { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
