using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class UserHistory : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid Userid { get; set; }
        public DateTime Adddate { get; set; }
        public string? Ipaddress { get; set; }
        public int? Corptid { get; set; }
        public Guid? Corpid { get; set; }

        public virtual Users User { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
