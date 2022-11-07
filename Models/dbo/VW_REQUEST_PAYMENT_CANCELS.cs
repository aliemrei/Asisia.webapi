using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class VW_REQUEST_PAYMENT_CANCELS : EntityBase // My Handlebars Helper
    {
        public int TYPE { get; set; }
        public Guid CANCELID { get; set; }
        public Guid ID { get; set; }
        public Guid? CORPID { get; set; }
        public Guid? REQUESTID { get; set; }
        public DateTime ADDDATE { get; set; }
        public double REFUND { get; set; }
        public double VOID { get; set; }
        public string? CURCODE { get; set; }
        public Guid? REQUEST_DETAILID { get; set; }
        public Guid PAYMENTID { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
