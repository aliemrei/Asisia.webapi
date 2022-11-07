using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class VW_CAMPAIGNS : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public string CODE { get; set; } = null!;
        public string DESCRIPTION { get; set; } = null!;
        public Guid CORPID { get; set; }
        public Guid RESOURCEID { get; set; }
        public Guid PROJECTID { get; set; }
        public Guid? PROJECT_DETAILID { get; set; }
        public DateTime STARTDATE { get; set; }
        public DateTime ENDDATE { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public DateTime? EDITDATE { get; set; }
        public bool ISDELETED { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
