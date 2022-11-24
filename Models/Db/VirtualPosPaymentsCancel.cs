using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class VirtualPosPaymentsCancel : EntityBase // My Handlebars Helper
    {
        public VirtualPosPaymentsCancel()
        {
            RequestPayments = new HashSet<RequestPayments>();
        }

        public Guid Id { get; set; }
        public Guid Paymentid { get; set; }
        public double Amount { get; set; }
        public bool Isvoid { get; set; }
        public bool Isrefund { get; set; }
        public DateTime Adddate { get; set; }
        public Guid Adduser { get; set; }
        public DateTime? Editdate { get; set; }
        public Guid? Edituser { get; set; }
        public bool Success { get; set; }
        public Guid? RequestDetailid { get; set; }
        public string? Entid { get; set; }

        public virtual RequestDetail? RequestDetail { get; set; }
        public virtual ICollection<RequestPayments> RequestPayments { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
