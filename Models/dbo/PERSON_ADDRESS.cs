using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class PERSON_ADDRESS : EntityBase // My Handlebars Helper
    {
        public Guid ID { get; set; }
        public Guid PERSONID { get; set; }
        public Guid? ADDRESSID { get; set; }

        public virtual LOCATION_ADDRESS? ADDRESS { get; set; }
        public virtual PERSON PERSON { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
