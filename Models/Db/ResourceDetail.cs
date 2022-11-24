using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class ResourceDetail : EntityBase // My Handlebars Helper
    {
        public ResourceDetail()
        {
            SalesReq = new HashSet<SalesReq>();
        }

        public Guid Id { get; set; }
        public string Description { get; set; } = null!;
        public string Detail { get; set; } = null!;
        public Guid Resourceid { get; set; }
        public Guid Corpid { get; set; }
        public Guid ProjectGroupdetailid { get; set; }
        public bool Isdeleted { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Corp Corp { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual ProjectGroupdetail ProjectGroupdetail { get; set; } = null!;
        public virtual ICollection<SalesReq> SalesReq { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
