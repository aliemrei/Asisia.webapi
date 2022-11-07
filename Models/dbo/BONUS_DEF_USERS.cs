using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class BONUS_DEF_USERS : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid BONUS_DEFID { get; set; }
        public Guid USERID { get; set; }

        public virtual USERS USER { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
