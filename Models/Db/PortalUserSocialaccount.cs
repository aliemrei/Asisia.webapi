using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class PortalUserSocialaccount : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public Guid Userid { get; set; }
        public string Providername { get; set; } = null!;
        public string Providerid { get; set; } = null!;

        public virtual PortalUser User { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
