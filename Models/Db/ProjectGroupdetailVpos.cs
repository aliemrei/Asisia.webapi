using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class ProjectGroupdetailVpos : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid ProjectDetailid { get; set; }
        public Guid Accountid { get; set; }
        public bool Isdisabled { get; set; }
        public bool Isdefault { get; set; }
        public string? Curcodes { get; set; }
        public string? Cardbrands { get; set; }

        public virtual ProjectGroupdetail ProjectDetail { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
