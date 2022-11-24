using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class RequestPayments : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid RequestDetailid { get; set; }
        public Guid? VirtualPosPaymentid { get; set; }
        public double? Rate { get; set; }
        public Guid? VirtualPosDepPaymentid { get; set; }
        public Guid? VirtualPosPaymentCancelid { get; set; }
        public Guid? VirtualPosDepPaymentCancelid { get; set; }
        public double? CancelRate { get; set; }
        public Guid? Paymentid { get; set; }
        public string? Entid { get; set; }

        public virtual Payments? Payment { get; set; }
        public virtual RequestDetail RequestDetail { get; set; } = null!;
        public virtual VirtualPosDepPayments? VirtualPosDepPayment { get; set; }
        public virtual VirtualPosDepPaymentsCancel? VirtualPosDepPaymentCancel { get; set; }
        public virtual VirtualPosPayments? VirtualPosPayment { get; set; }
        public virtual VirtualPosPaymentsCancel? VirtualPosPaymentCancel { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
