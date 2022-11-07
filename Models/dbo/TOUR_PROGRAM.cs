using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class TOUR_PROGRAM : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid TOURID { get; set; }
        public int STEPNO { get; set; }
        public int DURATION { get; set; }
        public short INTERVAL { get; set; }
        public string TITLE { get; set; } = null!;
        public string? DESCRIPTION { get; set; }
        public Guid? HOTELID { get; set; }
        public bool ISDISABLED { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public int? SORTORDER { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual STDHOTEL? HOTEL { get; set; }
        public virtual TOUR TOUR { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
