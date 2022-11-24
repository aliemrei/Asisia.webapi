using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class VirtualPosPaymentMessageTemps : EntityBase // My Handlebars Helper
    {
        public VirtualPosPaymentMessageTemps()
        {
            VirtualPosPaymentRequestsEmailtemp = new HashSet<VirtualPosPaymentRequests>();
            VirtualPosPaymentRequestsSmstemp = new HashSet<VirtualPosPaymentRequests>();
            VirtualPosPaymentTempsEmailtemp = new HashSet<VirtualPosPaymentTemps>();
            VirtualPosPaymentTempsSmstemp = new HashSet<VirtualPosPaymentTemps>();
        }

        public Guid Id { get; set; }
        public Guid Corpid { get; set; }
        public short Kind { get; set; }
        public string Description { get; set; } = null!;
        public string? Messagetext { get; set; }
        public bool Isdisabled { get; set; }
        public bool Isdeleted { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public string? Successtext { get; set; }
        public string? Errortext { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Corp Corp { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual ICollection<VirtualPosPaymentRequests> VirtualPosPaymentRequestsEmailtemp { get; set; }
        public virtual ICollection<VirtualPosPaymentRequests> VirtualPosPaymentRequestsSmstemp { get; set; }
        public virtual ICollection<VirtualPosPaymentTemps> VirtualPosPaymentTempsEmailtemp { get; set; }
        public virtual ICollection<VirtualPosPaymentTemps> VirtualPosPaymentTempsSmstemp { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
