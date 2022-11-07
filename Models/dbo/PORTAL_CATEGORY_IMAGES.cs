using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class PORTAL_CATEGORY_IMAGES : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid CATID { get; set; }
        public string? GROUPNAME { get; set; }
        public string? DESCRIPTION { get; set; }
        public string THUMBNAILURL { get; set; } = null!;
        public string IMAGEURL { get; set; } = null!;
        public int SORTINDEX { get; set; }
        public bool ISDISABLED { get; set; }
        public bool ISDELETED { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual PORTAL_CATEGORIES CAT { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
