using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class StdmarketCountries : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid Stdmarketid { get; set; }
        public string Countrycode { get; set; } = null!;

        public virtual Stdmarkets Stdmarket { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
