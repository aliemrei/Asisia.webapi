using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class STDSTORE : EntityBase // My Handlebars Helper
    {
        public STDSTORE()
        {
            PROJECT_GROUPDETAIL = new HashSet<PROJECT_GROUPDETAIL>();
            STDSTORE_ITEM_GROUPS = new HashSet<STDSTORE_ITEM_GROUPS>();
        }

        public Guid ID { get; set; }
        public Guid CORPID { get; set; }
        public string NAME { get; set; } = null!;
        public long? TEL1 { get; set; }
        public long? TEL2 { get; set; }
        public string? EMAIL { get; set; }
        public Guid? ADDRESSID { get; set; }
        public bool ISDELETED { get; set; }
        public bool ISDISABLED { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public string? CONTACT { get; set; }
        public long? FAX { get; set; }
        public string? WEBADDRESS { get; set; }
        public short TYPE { get; set; }
        public string? TYPENAME { get; set; }
        public string? THUMBNAILURL { get; set; }

        public virtual LOCATION_ADDRESS? ADDRESS { get; set; }
        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual CORP CORP { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual ICollection<PROJECT_GROUPDETAIL> PROJECT_GROUPDETAIL { get; set; }
        public virtual ICollection<STDSTORE_ITEM_GROUPS> STDSTORE_ITEM_GROUPS { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
