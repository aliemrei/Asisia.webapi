using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class VW_IPCOUNTRYCODES : EntityBase // My Handlebars Helper
    {
        public string country_code { get; set; } = null!;
        public string country_name { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
