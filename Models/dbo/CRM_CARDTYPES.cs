using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class CRM_CARDTYPES : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid CARDGROUPID { get; set; }
        public string DEFINITION { get; set; } = null!;
        public string? TITLE { get; set; }
        public string? CARDUSE_RULES { get; set; }
        public string? CARDBRANDICONURL { get; set; }
        public bool? SHOWWIFI_ICON { get; set; }
        public bool? SHOWCHIP_ICON { get; set; }
        public bool? SHOWCARD_BRAND { get; set; }
        public string COLORGROUP1 { get; set; } = null!;
        public string COLORGROUP2 { get; set; } = null!;
        public string COLORGROUP3 { get; set; } = null!;
        public string COLORGROUP4 { get; set; } = null!;
        public bool ISDELETED { get; set; }
        public bool ISDISABLED { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public string BACKCOLOR1 { get; set; } = null!;
        public string BACKCOLOR2 { get; set; } = null!;
        public string? CARDBRANDLOGO { get; set; }
        public string? BACKGROUNDLOGO { get; set; }
        public bool? SHOWNUMBERS { get; set; }
        public bool? SHOWEXPIRE { get; set; }
        public bool? SHOWCARDHOLDERNAME { get; set; }
        public bool? SHOW_STRIPBOTTOM { get; set; }
        public bool? SHOW_STRIPTOP { get; set; }
        public string CARDNUMBER_MARGIN { get; set; } = null!;

        public virtual USERS ADDUSERNavigation { get; set; } = null!;
        public virtual CRM_CARDGROUPS CARDGROUP { get; set; } = null!;
        public virtual USERS? EDITUSERNavigation { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
