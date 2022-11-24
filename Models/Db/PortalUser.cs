using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class PortalUser : EntityBase // My Handlebars Helper
    {
        public PortalUser()
        {
            PortalUserSocialaccount = new HashSet<PortalUserSocialaccount>();
        }

        public Guid Id { get; set; }
        public Guid? Personid { get; set; }
        public string? Pwd { get; set; }
        public string? Changekey { get; set; }
        public DateTime? Changedate { get; set; }
        public string? Email { get; set; }
        public long? Phone { get; set; }

        public virtual Person? Person { get; set; }
        public virtual ICollection<PortalUserSocialaccount> PortalUserSocialaccount { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
