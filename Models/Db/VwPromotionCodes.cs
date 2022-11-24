using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class VwPromotionCodes : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public string? Kind { get; set; }
        public string Definition { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string? Usetype { get; set; }
        public string? Discounttype { get; set; }
        public string? Discountkind { get; set; }
        public DateTime? Sellfrom { get; set; }
        public DateTime? Sellto { get; set; }
        public DateTime? Stayfrom { get; set; }
        public DateTime? Stayto { get; set; }
        public bool Isdeleted { get; set; }
        public bool Isdisabled { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public DateTime? Editdate { get; set; }
        public Guid? Edituser { get; set; }
        public Guid Corpid { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
