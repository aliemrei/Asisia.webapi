using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class USER_HISTORY : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid USERID { get; set; }
        public DateTime ADDDATE { get; set; }
        public string? IPADDRESS { get; set; }
        public int? CORPTID { get; set; }
        public Guid? CORPID { get; set; }

        public virtual USERS USER { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
