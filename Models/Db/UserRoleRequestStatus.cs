using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class UserRoleRequestStatus : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid Roleid { get; set; }
        public Guid Statuid { get; set; }
        public bool? Allow { get; set; }

        public virtual Roles Role { get; set; } = null!;
        public virtual RequestStatus Statu { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
