using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class AgencyGroup : EntityBase // My Handlebars Helper
    {
        public AgencyGroup()
        {
            Agency = new HashSet<Agency>();
            StdhotelRatecodeDetailAgencygroups = new HashSet<StdhotelRatecodeDetailAgencygroups>();
        }

        public Guid Id { get; set; }
        public Guid Corpid { get; set; }
        public string Groupname { get; set; } = null!;
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public bool Isdeleted { get; set; }
        public bool Isdisabled { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Corp Corp { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual ICollection<Agency> Agency { get; set; }
        public virtual ICollection<StdhotelRatecodeDetailAgencygroups> StdhotelRatecodeDetailAgencygroups { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
