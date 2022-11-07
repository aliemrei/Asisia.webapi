using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class VW_PROMOTION_CODES : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public string? KIND { get; set; }
        public string DEFINITION { get; set; } = null!;
        public string CODE { get; set; } = null!;
        public string? USETYPE { get; set; }
        public string? DISCOUNTTYPE { get; set; }
        public string? DISCOUNTKIND { get; set; }
        public DateTime? SELLFROM { get; set; }
        public DateTime? SELLTO { get; set; }
        public DateTime? STAYFROM { get; set; }
        public DateTime? STAYTO { get; set; }
        public bool ISDELETED { get; set; }
        public bool ISDISABLED { get; set; }
        public Guid ADDUSER { get; set; }
        public DateTime ADDDATE { get; set; }
        public DateTime? EDITDATE { get; set; }
        public Guid? EDITUSER { get; set; }
        public Guid CORPID { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
