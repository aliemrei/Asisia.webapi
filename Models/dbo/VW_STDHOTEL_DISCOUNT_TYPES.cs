using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class VW_STDHOTEL_DISCOUNT_TYPES : EntityBase // My Handlebars Helper
    {
        public int? TYPEID { get; set; }
        public string DESCRIPTION { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
