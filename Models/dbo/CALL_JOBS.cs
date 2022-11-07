using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class CALL_JOBS : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public Guid? REQUESTID { get; set; }
        public DateTime CALLDATE { get; set; }
        public long CALLNUMBER { get; set; }
        public Guid? USERID { get; set; }
        public Guid? PERSONID { get; set; }
        public short REASON { get; set; }
        public short RESULT { get; set; }
        public short? CANCELATION { get; set; }
        public string? CAMPAIGNCODE { get; set; }
        public bool ISDELETED { get; set; }
        public bool ISDISABLED { get; set; }
        public string? ENT_ID { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public string? OUTPUT_EXTEN { get; set; }
        public Guid? QAID { get; set; }
        public int? PRIORITY { get; set; }
        public string? DESCRIPTION { get; set; }
        public string? FIRSTNAME { get; set; }
        public string? LASTNAME { get; set; }
        public Guid? CORPID { get; set; }
        public string? FULLNAME { get; set; }
        public string KIND { get; set; } = null!;
        public Guid? PROJECT_GROUPID { get; set; }
        public Guid? PROJECT_DETAILID { get; set; }
        public string? RESULT_TEXT { get; set; }

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual CORP? CORP { get; set; }
        public virtual USERS? EDITUSERNavigation { get; set; }
        public virtual PERSON? PERSON { get; set; }
        public virtual PROJECT_GROUPDETAIL? PROJECT_DETAIL { get; set; }
        public virtual PROJECT_GROUP? PROJECT_GROUP { get; set; }
        public virtual REQUEST? REQUEST { get; set; }
        public virtual USERS? USER { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
