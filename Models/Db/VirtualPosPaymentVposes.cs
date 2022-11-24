using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class VirtualPosPaymentVposes : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid? Tempid { get; set; }
        public Guid? Paymentid { get; set; }
        public Guid? Installmentid { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual VirtualPosAccountInstalments? Installment { get; set; }
        public virtual VirtualPosPaymentRequests? Payment { get; set; }
        public virtual VirtualPosPaymentTemps? Temp { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
