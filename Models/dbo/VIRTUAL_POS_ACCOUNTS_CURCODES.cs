using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class VIRTUAL_POS_ACCOUNTS_CURCODES : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid ACCOUNTID { get; set; }
        public string CURCODE { get; set; } = null!;
        public string? SCHEMES { get; set; }

        public virtual VIRTUAL_POS_ACCOUNTS ACCOUNT { get; set; } = null!;
        public virtual CURCODE CURCODENavigation { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
