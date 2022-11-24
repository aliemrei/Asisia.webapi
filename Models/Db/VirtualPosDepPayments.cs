using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class VirtualPosDepPayments : EntityBase // My Handlebars Helper
    {
        public VirtualPosDepPayments()
        {
            RequestPayments = new HashSet<RequestPayments>();
            VirtualPosDepPaymentsCancel = new HashSet<VirtualPosDepPaymentsCancel>();
        }

        public Guid Id { get; set; }
        public Guid Posaccountid { get; set; }
        public double Amount { get; set; }
        public Guid Status { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public string? Transfercode { get; set; }
        public Guid? Requestid { get; set; }
        public bool Isdeleted { get; set; }
        public int Intid { get; set; }
        public DateTime? Endtime { get; set; }
        public string? Banktransactionid { get; set; }
        public string? Entid { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual VirtualPosDepAccounts Posaccount { get; set; } = null!;
        public virtual Request? Request { get; set; }
        public virtual RequestStatus StatusNavigation { get; set; } = null!;
        public virtual ICollection<RequestPayments> RequestPayments { get; set; }
        public virtual ICollection<VirtualPosDepPaymentsCancel> VirtualPosDepPaymentsCancel { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
