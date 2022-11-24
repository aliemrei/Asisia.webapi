using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class PersonCcards : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public Guid Personid { get; set; }
        public string? Cardowner { get; set; }
        public string? Cardnumber { get; set; }
        public int? Validyear { get; set; }
        public int? Validmonth { get; set; }
        public string? Cvv { get; set; }
        public Guid Uid { get; set; }

        public virtual Person Person { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
