using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class RESERVATION_EMAILS : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid? CORPID { get; set; }
        public Guid? PROJECT_DETAILID { get; set; }
        public Guid? PRODUCTID { get; set; }
        public string? TO_EMAILS { get; set; }
        public string? CC_EMAILS { get; set; }
        public string? BCC_EMAILS { get; set; }

        public virtual CORP? CORP { get; set; }
        public virtual PROJECT_GROUPDETAIL? PROJECT_DETAIL { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
