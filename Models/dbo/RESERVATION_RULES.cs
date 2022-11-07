using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class RESERVATION_RULES : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid? PROJECT_DETAILID { get; set; }
        public string? REFUND_RULES { get; set; }
        public string? GENERAL_RULES { get; set; }

        public virtual PROJECT_GROUPDETAIL? PROJECT_DETAIL { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
