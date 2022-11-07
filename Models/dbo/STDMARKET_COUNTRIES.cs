using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class STDMARKET_COUNTRIES : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid STDMARKETID { get; set; }
        public string COUNTRYCODE { get; set; } = null!;

        public virtual STDMARKETS STDMARKET { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
