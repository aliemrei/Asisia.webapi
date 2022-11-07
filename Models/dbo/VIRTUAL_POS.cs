using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class VIRTUAL_POS : EntityBase // My Handlebars Helper
    {
        public VIRTUAL_POS()
        {
            VIRTUAL_POS_ACCOUNTS = new HashSet<VIRTUAL_POS_ACCOUNTS>();
            VIRTUAL_POS_DEFAULTSAMEX_EX_POS = new HashSet<VIRTUAL_POS_DEFAULTS>();
            VIRTUAL_POS_DEFAULTSAMEX_POS = new HashSet<VIRTUAL_POS_DEFAULTS>();
            VIRTUAL_POS_DEFAULTSJCB_EX_POS = new HashSet<VIRTUAL_POS_DEFAULTS>();
            VIRTUAL_POS_DEFAULTSJCB_POS = new HashSet<VIRTUAL_POS_DEFAULTS>();
            VIRTUAL_POS_DEFAULTSMAESTRO_EX_POS = new HashSet<VIRTUAL_POS_DEFAULTS>();
            VIRTUAL_POS_DEFAULTSMAESTRO_POS = new HashSet<VIRTUAL_POS_DEFAULTS>();
            VIRTUAL_POS_DEFAULTSMASTER_EX_POS = new HashSet<VIRTUAL_POS_DEFAULTS>();
            VIRTUAL_POS_DEFAULTSMASTER_POS = new HashSet<VIRTUAL_POS_DEFAULTS>();
            VIRTUAL_POS_DEFAULTSUNIONPAY_EX_POS = new HashSet<VIRTUAL_POS_DEFAULTS>();
            VIRTUAL_POS_DEFAULTSUNIONPAY_POS = new HashSet<VIRTUAL_POS_DEFAULTS>();
            VIRTUAL_POS_DEFAULTSVISA_EX_POS = new HashSet<VIRTUAL_POS_DEFAULTS>();
            VIRTUAL_POS_DEFAULTSVISA_POS = new HashSet<VIRTUAL_POS_DEFAULTS>();
        }

        public Guid ID { get; set; }
        public string DESCRIPTION { get; set; } = null!;
        public string? NAME { get; set; }
        public string CLASS { get; set; } = null!;
        public Guid CORPID { get; set; }
        public string? BINNUMBER_NAME { get; set; }
        public string? ACC_INV_CODE { get; set; }
        public string? ACC_PAY_CODE { get; set; }
        public int INTID { get; set; }
        public string? ICONURL { get; set; }
        public string? FONTCOLOR { get; set; }
        public string? FORECOLOR { get; set; }
        public string? XMLUSERNAME { get; set; }
        public string? XMLPASSWORD { get; set; }

        public virtual CORP CORP { get; set; } = null!;
        public virtual ICollection<VIRTUAL_POS_ACCOUNTS> VIRTUAL_POS_ACCOUNTS { get; set; }
        public virtual ICollection<VIRTUAL_POS_DEFAULTS> VIRTUAL_POS_DEFAULTSAMEX_EX_POS { get; set; }
        public virtual ICollection<VIRTUAL_POS_DEFAULTS> VIRTUAL_POS_DEFAULTSAMEX_POS { get; set; }
        public virtual ICollection<VIRTUAL_POS_DEFAULTS> VIRTUAL_POS_DEFAULTSJCB_EX_POS { get; set; }
        public virtual ICollection<VIRTUAL_POS_DEFAULTS> VIRTUAL_POS_DEFAULTSJCB_POS { get; set; }
        public virtual ICollection<VIRTUAL_POS_DEFAULTS> VIRTUAL_POS_DEFAULTSMAESTRO_EX_POS { get; set; }
        public virtual ICollection<VIRTUAL_POS_DEFAULTS> VIRTUAL_POS_DEFAULTSMAESTRO_POS { get; set; }
        public virtual ICollection<VIRTUAL_POS_DEFAULTS> VIRTUAL_POS_DEFAULTSMASTER_EX_POS { get; set; }
        public virtual ICollection<VIRTUAL_POS_DEFAULTS> VIRTUAL_POS_DEFAULTSMASTER_POS { get; set; }
        public virtual ICollection<VIRTUAL_POS_DEFAULTS> VIRTUAL_POS_DEFAULTSUNIONPAY_EX_POS { get; set; }
        public virtual ICollection<VIRTUAL_POS_DEFAULTS> VIRTUAL_POS_DEFAULTSUNIONPAY_POS { get; set; }
        public virtual ICollection<VIRTUAL_POS_DEFAULTS> VIRTUAL_POS_DEFAULTSVISA_EX_POS { get; set; }
        public virtual ICollection<VIRTUAL_POS_DEFAULTS> VIRTUAL_POS_DEFAULTSVISA_POS { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
