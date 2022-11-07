using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class STDHOTEL_ANNOUNCEMENT : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid HOTELID { get; set; }
        public short KIND { get; set; }
        public string? DEFINITION { get; set; }
        public DateTime STARTDATE { get; set; }
        public DateTime ENDDATE { get; set; }
        public string? INNERHTML { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public bool ISDELETED { get; set; }
        public bool ISDISABLED { get; set; }
        public string? MARKETS { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual STDHOTEL HOTEL { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
