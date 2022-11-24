using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class CrmCardgroups : EntityBase // My Handlebars Helper
    {
        public CrmCardgroups()
        {
            CrmCardtypes = new HashSet<CrmCardtypes>();
        }

        public Guid Id { get; set; }
        public Guid Corpid { get; set; }
        public string Definition { get; set; } = null!;
        public bool Isdeleted { get; set; }
        public bool Isdisabled { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Corp Corp { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual ICollection<CrmCardtypes> CrmCardtypes { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
