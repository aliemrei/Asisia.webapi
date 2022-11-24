using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class Campaigns : EntityBase // My Handlebars Helper
    {
        public Campaigns()
        {
            Request = new HashSet<Request>();
            RequestDetail = new HashSet<RequestDetail>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
        public Guid Corpid { get; set; }
        public Guid? Resourceid { get; set; }
        public Guid Projectid { get; set; }
        public Guid? ProjectDetailid { get; set; }
        public int Forallprojects { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Enddate { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public bool Isdeleted { get; set; }
        public string? RakamId { get; set; }
        public string? CallbackTrunk { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Corp Corp { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual ProjectGroup Project { get; set; } = null!;
        public virtual Resources? Resource { get; set; }
        public virtual ICollection<Request> Request { get; set; }
        public virtual ICollection<RequestDetail> RequestDetail { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
