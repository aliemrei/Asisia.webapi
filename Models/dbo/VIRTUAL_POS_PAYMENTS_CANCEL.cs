using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class VIRTUAL_POS_PAYMENTS_CANCEL : EntityBase // My Handlebars Helper
    {
        public VIRTUAL_POS_PAYMENTS_CANCEL()
        {
            REQUEST_PAYMENTS = new HashSet<REQUEST_PAYMENTS>();
        }

        public Guid ID { get; set; }
        public Guid PAYMENTID { get; set; }
        public double AMOUNT { get; set; }
        public bool ISVOID { get; set; }
        public bool ISREFUND { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public bool SUCCESS { get; set; }
        public Guid? REQUEST_DETAILID { get; set; }
        public string? ENTID { get; set; }

        public virtual REQUEST_DETAIL? REQUEST_DETAIL { get; set; }
        public virtual ICollection<REQUEST_PAYMENTS> REQUEST_PAYMENTS { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
