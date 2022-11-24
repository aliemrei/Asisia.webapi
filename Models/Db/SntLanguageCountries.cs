using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class SntLanguageCountries : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public string Langcode { get; set; } = null!;
        public string Countrycode { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
