using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class ROLES_CUSTOMAUTH : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid ROLEID { get; set; }
        public bool DISCOUNT_ADMIN { get; set; }
        public bool CREDITCARD_ADMIN { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
