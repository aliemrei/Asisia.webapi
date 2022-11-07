using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class RESOURCE_BUDGET : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public DateTime TDATE { get; set; }
        public Guid RESOURCEID { get; set; }
        public double? AMOUNT { get; set; }
        public string? CURCODE { get; set; }
        public double? RAMOUNT { get; set; }
        public double? INCOME_AMOUNT { get; set; }
        public Guid PROJECT_DETAILID { get; set; }
        public Guid CORPID { get; set; }

        public virtual CORP CORP { get; set; } = null!;
        public virtual PROJECT_GROUPDETAIL PROJECT_DETAIL { get; set; } = null!;
        public virtual RESOURCES RESOURCE { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
