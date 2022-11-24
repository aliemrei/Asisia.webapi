using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class VwStdhotelDiscountTypes : EntityBase // My Handlebars Helper
    {
        public int? Typeid { get; set; }
        public string Description { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
