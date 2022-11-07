using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class TRANSFER_LOCATIONS : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid CORPID { get; set; }
        public string DEFINITION { get; set; } = null!;
        public double? LONGITUDE { get; set; }
        public double? LATITUDE { get; set; }
        public bool ISDELETED { get; set; }
        public bool ISDISABLED { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public string? AIRPORTCODE { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual CORP CORP { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
