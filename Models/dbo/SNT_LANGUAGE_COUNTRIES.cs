using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class SNT_LANGUAGE_COUNTRIES : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public string LANGCODE { get; set; } = null!;
        public string COUNTRYCODE { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
