using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class PORTAL_USER_SOCIALACCOUNT : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public Guid USERID { get; set; }
        public string PROVIDERNAME { get; set; } = null!;
        public string PROVIDERID { get; set; } = null!;

        public virtual PORTAL_USER USER { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
