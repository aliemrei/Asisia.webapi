using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class Stdstore : EntityBase // My Handlebars Helper
    {
        public Stdstore()
        {
            ProjectGroupdetail = new HashSet<ProjectGroupdetail>();
            StdstoreItemGroups = new HashSet<StdstoreItemGroups>();
        }

        public Guid Id { get; set; }
        public Guid Corpid { get; set; }
        public string Name { get; set; } = null!;
        public long? Tel1 { get; set; }
        public long? Tel2 { get; set; }
        public string? Email { get; set; }
        public Guid? Addressid { get; set; }
        public bool Isdeleted { get; set; }
        public bool Isdisabled { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public string? Contact { get; set; }
        public long? Fax { get; set; }
        public string? Webaddress { get; set; }
        public short Type { get; set; }
        public string? Typename { get; set; }
        public string? Thumbnailurl { get; set; }

        public virtual LocationAddress? Address { get; set; }
        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Corp Corp { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual ICollection<ProjectGroupdetail> ProjectGroupdetail { get; set; }
        public virtual ICollection<StdstoreItemGroups> StdstoreItemGroups { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
