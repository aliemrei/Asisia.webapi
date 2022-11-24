using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class RolesCustomauth : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid Roleid { get; set; }
        public bool DiscountAdmin { get; set; }
        public bool CreditcardAdmin { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
