using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class REQUEST_STATUS : EntityBase // My Handlebars Helper
    {
        public REQUEST_STATUS()
        {
            PAYMENTS = new HashSet<PAYMENTS>();
            REQUEST = new HashSet<REQUEST>();
            REQUEST_DETAILSTATUSNavigation = new HashSet<REQUEST_DETAIL>();
            REQUEST_DETAILSUBSTATUSNavigation = new HashSet<REQUEST_DETAIL>();
            USER_ROLE_REQUEST_STATUS = new HashSet<USER_ROLE_REQUEST_STATUS>();
            VIRTUAL_POS_DEP_PAYMENTS = new HashSet<VIRTUAL_POS_DEP_PAYMENTS>();
            VIRTUAL_POS_PAYMENTS = new HashSet<VIRTUAL_POS_PAYMENTS>();
        }

        public Guid ID { get; set; }
        public string DESCRIPTION { get; set; } = null!;
        public short SUBSTATUS { get; set; }
        public short TYPE { get; set; }
        public int? SORTORDER { get; set; }
        public string? ALLOWED_SUBSTATUS { get; set; }
        public short? RAKAM_TYPE { get; set; }
        public string? RAKAM_ID { get; set; }

        public virtual ICollection<PAYMENTS> PAYMENTS { get; set; }
        public virtual ICollection<REQUEST> REQUEST { get; set; }
        public virtual ICollection<REQUEST_DETAIL> REQUEST_DETAILSTATUSNavigation { get; set; }
        public virtual ICollection<REQUEST_DETAIL> REQUEST_DETAILSUBSTATUSNavigation { get; set; }
        public virtual ICollection<USER_ROLE_REQUEST_STATUS> USER_ROLE_REQUEST_STATUS { get; set; }
        public virtual ICollection<VIRTUAL_POS_DEP_PAYMENTS> VIRTUAL_POS_DEP_PAYMENTS { get; set; }
        public virtual ICollection<VIRTUAL_POS_PAYMENTS> VIRTUAL_POS_PAYMENTS { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
