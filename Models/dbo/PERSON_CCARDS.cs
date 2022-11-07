using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class PERSON_CCARDS : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public Guid PERSONID { get; set; }
        public string? CARDOWNER { get; set; }
        public string? CARDNUMBER { get; set; }
        public int? VALIDYEAR { get; set; }
        public int? VALIDMONTH { get; set; }
        public string? CVV { get; set; }
        public Guid UID { get; set; }

        public virtual PERSON PERSON { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
