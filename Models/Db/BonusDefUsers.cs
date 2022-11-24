using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class BonusDefUsers : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid BonusDefid { get; set; }
        public Guid Userid { get; set; }

        public virtual Users User { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
