using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class BONUS_DEF : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid CORPID { get; set; }
        public DateTime FIRST_DATE { get; set; }
        public DateTime LAST_DATE { get; set; }
        public double? RATE { get; set; }
        public short APPLY_TYPE { get; set; }
        public Guid? PROJECT_GROUPID { get; set; }
        public string? DEFINITION { get; set; }
        public string CURCODE { get; set; } = null!;
        public DateTime ADDDATE { get; set; }
        public Guid? ADDUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public Guid? EDITUSER { get; set; }

        public virtual USERS? ADDUSERNavigation { get; set; }
        public virtual CORP CORP { get; set; } = null!;
        public virtual CURCODE CURCODENavigation { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual PROJECT_GROUP? PROJECT_GROUP { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
