using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class REQUEST_NOTES : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid REQUESTID { get; set; }
        public Guid? REQUEST_DETAILID { get; set; }
        public string? NOTE { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid ADDUSER { get; set; }
        public byte NOTTYPE { get; set; }
        public bool ISDELETED { get; set; }
        public DateTime? EDITDATE { get; set; }
        public Guid? EDITUSER { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual REQUEST REQUEST { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
