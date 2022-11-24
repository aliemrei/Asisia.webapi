using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class Roles : EntityBase // My Handlebars Helper
    {
        public Roles()
        {
            RoleAuth = new HashSet<RoleAuth>();
            RolesDashboards = new HashSet<RolesDashboards>();
            UserRoleRequestStatus = new HashSet<UserRoleRequestStatus>();
            UserRoles = new HashSet<UserRoles>();
        }

        public Guid Id { get; set; }
        public Guid Corpid { get; set; }
        public string Name { get; set; } = null!;
        public bool Isdeleted { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public Guid? Moduleid { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Corp Corp { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual ICollection<RoleAuth> RoleAuth { get; set; }
        public virtual ICollection<RolesDashboards> RolesDashboards { get; set; }
        public virtual ICollection<UserRoleRequestStatus> UserRoleRequestStatus { get; set; }
        public virtual ICollection<UserRoles> UserRoles { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
