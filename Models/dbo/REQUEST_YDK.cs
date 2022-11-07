using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class REQUEST_YDK : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid? PERSONID { get; set; }
        public Guid CORPID { get; set; }
        public Guid RESOURCEID { get; set; }
        public Guid? PROJECT_DETAILID { get; set; }
        public string? REQ_URL { get; set; }
        public string? CAMPAIGNCODE { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public DateTime? CREATIONDATE { get; set; }
        public TimeSpan? CREATIONTIME { get; set; }
        public Guid PROJECT_GROUPID { get; set; }
        public Guid? STATUS { get; set; }
        public Guid? SUBSTATUS { get; set; }
        public string? RAKAM_ID { get; set; }
        public int? PERSON_CCARDID { get; set; }
        public string? CURCODE { get; set; }
        public Guid? POSACCOUNTID { get; set; }
        public Guid? POSINSTALMENTID { get; set; }
        public bool ISCALLTRANSFER { get; set; }
        public bool? ORG { get; set; }
        public Guid? SELLER_USERID { get; set; }
        public DateTime? SELL_DATE { get; set; }
        public string? RESNO { get; set; }
        public DateTime? SELLINGDATE { get; set; }
        public TimeSpan? SELLINGTIME { get; set; }
        public string? DIRECT_BRANDING { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
