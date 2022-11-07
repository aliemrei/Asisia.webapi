using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class REQUEST_PAYMENTS : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid REQUEST_DETAILID { get; set; }
        public Guid? VIRTUAL_POS_PAYMENTID { get; set; }
        public double? RATE { get; set; }
        public Guid? VIRTUAL_POS_DEP_PAYMENTID { get; set; }
        public Guid? VIRTUAL_POS_PAYMENT_CANCELID { get; set; }
        public Guid? VIRTUAL_POS_DEP_PAYMENT_CANCELID { get; set; }
        public double? CANCEL_RATE { get; set; }
        public Guid? PAYMENTID { get; set; }
        public string? ENTID { get; set; }

        public virtual PAYMENTS? PAYMENT { get; set; }
        public virtual REQUEST_DETAIL REQUEST_DETAIL { get; set; } = null!;
        public virtual VIRTUAL_POS_DEP_PAYMENTS? VIRTUAL_POS_DEP_PAYMENT { get; set; }
        public virtual VIRTUAL_POS_DEP_PAYMENTS_CANCEL? VIRTUAL_POS_DEP_PAYMENT_CANCEL { get; set; }
        public virtual VIRTUAL_POS_PAYMENTS? VIRTUAL_POS_PAYMENT { get; set; }
        public virtual VIRTUAL_POS_PAYMENTS_CANCEL? VIRTUAL_POS_PAYMENT_CANCEL { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
