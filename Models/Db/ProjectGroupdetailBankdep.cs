using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class ProjectGroupdetailBankdep : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid ProjectDetailid { get; set; }
        public Guid Depaccountid { get; set; }
        public bool Isdisabled { get; set; }
        public bool? UseInPortal { get; set; }

        public virtual VirtualPosDepAccounts Depaccount { get; set; } = null!;
        public virtual ProjectGroupdetail ProjectDetail { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
