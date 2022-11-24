using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class UserRoles : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid Userid { get; set; }
        public Guid Roleid { get; set; }
        public bool Isdeleted { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public Guid? Moduleid { get; set; }

        public virtual Roles Role { get; set; } = null!;
        public virtual Users User { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
