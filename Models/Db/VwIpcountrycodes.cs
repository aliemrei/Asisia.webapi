using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class VwIpcountrycodes : EntityBase // My Handlebars Helper
    {
        public string CountryCode { get; set; } = null!;
        public string CountryName { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
