using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class CONTACT_FORM : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid? PERSONID { get; set; }
        public string? TITLE { get; set; }
        public Guid? CATEGORY { get; set; }
        public string? MESSAGETEXT { get; set; }
        public Guid CORPID { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public Guid? EDITUSER { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual CONTACT_CATEGORY? CATEGORYNavigation { get; set; }
        public virtual CORP CORP { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual PERSON? PERSON { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
