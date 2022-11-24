using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class VirtualPosAccountInstalments : EntityBase // My Handlebars Helper
    {
        public VirtualPosAccountInstalments()
        {
            VirtualPosPaymentVposes = new HashSet<VirtualPosPaymentVposes>();
            VirtualPosPayments = new HashSet<VirtualPosPayments>();
        }

        public Guid Id { get; set; }
        public Guid Accountid { get; set; }
        public int Offset { get; set; }
        public double Commission { get; set; }
        public double BankCommission { get; set; }
        public bool Isdisabled { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public int Plus { get; set; }
        public int Expiryday { get; set; }

        public virtual VirtualPosAccounts Account { get; set; } = null!;
        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual ICollection<VirtualPosPaymentVposes> VirtualPosPaymentVposes { get; set; }
        public virtual ICollection<VirtualPosPayments> VirtualPosPayments { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
