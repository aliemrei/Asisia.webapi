using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class Payments : EntityBase // My Handlebars Helper
    {
        public Payments()
        {
            RequestPayments = new HashSet<RequestPayments>();
        }

        public Guid Id { get; set; }
        public Guid? Requestid { get; set; }
        public Guid? Resourceid { get; set; }
        public string? Description { get; set; }
        public bool Iscash { get; set; }
        public bool Isccard { get; set; }
        public string? Hardposidentity { get; set; }
        public double Debt { get; set; }
        public double Credit { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public Guid Corpid { get; set; }
        public Guid Status { get; set; }
        public string Curcode { get; set; } = null!;
        public byte Paytype { get; set; }
        public bool Isbonus { get; set; }
        public double? TlAmount { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Corp Corp { get; set; } = null!;
        public virtual Curcode CurcodeNavigation { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual Request? Request { get; set; }
        public virtual Resources? Resource { get; set; }
        public virtual RequestStatus StatusNavigation { get; set; } = null!;
        public virtual ICollection<RequestPayments> RequestPayments { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
