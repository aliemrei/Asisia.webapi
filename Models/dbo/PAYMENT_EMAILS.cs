using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class PAYMENT_EMAILS : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid? CORPID { get; set; }
        public Guid? PROJECTID { get; set; }
        public string? TO_EMAILS { get; set; }
        public string? CC_EMAILS { get; set; }
        public string? BCC_EMAILS { get; set; }
        public Guid? HOTELID { get; set; }
        public Guid? PROJECT_DETAILID { get; set; }
        public string? SUCCESS_TEXT { get; set; }
        public string? FAIL_TEXT { get; set; }

        public virtual CORP? CORP { get; set; }
        public virtual PROJECT_GROUP? PROJECT { get; set; }
        public virtual PROJECT_GROUPDETAIL? PROJECT_DETAIL { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
