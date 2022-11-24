using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class VirtualPosDepAccounts : EntityBase // My Handlebars Helper
    {
        public VirtualPosDepAccounts()
        {
            ProjectGroupdetailBankdep = new HashSet<ProjectGroupdetailBankdep>();
            VirtualPosDepPayments = new HashSet<VirtualPosDepPayments>();
        }

        public Guid Id { get; set; }
        public Guid Posid { get; set; }
        public string? Definition { get; set; }
        public string? BrandCode { get; set; }
        public string? AccountNo { get; set; }
        public string? Iban { get; set; }
        public string Curcode { get; set; } = null!;
        public string? Firmname { get; set; }
        public string? Swiftcode { get; set; }
        public string? Entid { get; set; }

        public virtual ICollection<ProjectGroupdetailBankdep> ProjectGroupdetailBankdep { get; set; }
        public virtual ICollection<VirtualPosDepPayments> VirtualPosDepPayments { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
