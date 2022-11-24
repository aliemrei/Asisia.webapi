using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class PersonAddress : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid Personid { get; set; }
        public Guid? Addressid { get; set; }

        public virtual LocationAddress? Address { get; set; }
        public virtual Person Person { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
