using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class SALES_REQ : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid PERSONID { get; set; }
        public Guid? RESOURCE_DETAILID { get; set; }
        public bool ISDELETED { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual PERSON PERSON { get; set; } = null!;
        public virtual RESOURCE_DETAIL? RESOURCE_DETAIL { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
