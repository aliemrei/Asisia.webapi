using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class Stdlanguages : EntityBase // My Handlebars Helper
    {
        public Stdlanguages()
        {
            PortalSeo = new HashSet<PortalSeo>();
            ProjectGroupdetailSeo = new HashSet<ProjectGroupdetailSeo>();
            Request = new HashSet<Request>();
            VirtualPosPaymentTemps = new HashSet<VirtualPosPaymentTemps>();
        }

        public string Code { get; set; } = null!;
        public string Definition { get; set; } = null!;

        public virtual ICollection<PortalSeo> PortalSeo { get; set; }
        public virtual ICollection<ProjectGroupdetailSeo> ProjectGroupdetailSeo { get; set; }
        public virtual ICollection<Request> Request { get; set; }
        public virtual ICollection<VirtualPosPaymentTemps> VirtualPosPaymentTemps { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
