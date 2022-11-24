using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class UsersCustomauth : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid Userid { get; set; }
        public bool AllowbutgetOnreelgrid { get; set; }
        public bool AllowclientInvoiceIntegration { get; set; }
        public string? ExternalPassword { get; set; }

        public virtual Users User { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
