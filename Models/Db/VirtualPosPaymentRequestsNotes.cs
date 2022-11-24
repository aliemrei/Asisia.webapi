using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class VirtualPosPaymentRequestsNotes : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid Paymentid { get; set; }
        public string? Note { get; set; }
        public DateTime Adddate { get; set; }
        public Guid Adduser { get; set; }
        public byte Nottype { get; set; }
        public bool Isdeleted { get; set; }
        public DateTime? Editdate { get; set; }
        public Guid? Edituser { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual VirtualPosPaymentRequests Payment { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
