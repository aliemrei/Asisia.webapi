using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class VwRequestPaymentCancels : EntityBase // My Handlebars Helper
    {
        public int Type { get; set; }
        public Guid Cancelid { get; set; }
        public Guid Id { get; set; }
        public Guid? Corpid { get; set; }
        public Guid? Requestid { get; set; }
        public DateTime Adddate { get; set; }
        public double Refund { get; set; }
        public double Void { get; set; }
        public string? Curcode { get; set; }
        public Guid? RequestDetailid { get; set; }
        public Guid Paymentid { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
