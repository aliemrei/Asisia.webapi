using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class USERS_CUSTOMAUTH : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid USERID { get; set; }
        public bool ALLOWBUTGET_ONREELGRID { get; set; }
        public bool ALLOWCLIENT_INVOICE_INTEGRATION { get; set; }
        public string? EXTERNAL_PASSWORD { get; set; }

        public virtual USERS USER { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
