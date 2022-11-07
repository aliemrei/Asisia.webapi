using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class PERSON_BONUS : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid PERSONID { get; set; }
        public Guid TYPEID { get; set; }
        public DateTime? DATE { get; set; }
        public double POINT { get; set; }
        public Guid? PRODUCTID { get; set; }
        public Guid? REQUEST_DETAILID { get; set; }
        public bool ISDELETED { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public double AMOUNT { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual PERSON PERSON { get; set; } = null!;
        public virtual REQUEST_DETAIL? REQUEST_DETAIL { get; set; }
        public virtual PERSON_BONUS_TYPES TYPE { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
