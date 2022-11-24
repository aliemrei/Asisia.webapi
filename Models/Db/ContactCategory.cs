using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class ContactCategory : EntityBase // My Handlebars Helper
    {
        public ContactCategory()
        {
            ContactForm = new HashSet<ContactForm>();
        }

        public Guid Id { get; set; }
        public string Definition { get; set; } = null!;
        public Guid Corpid { get; set; }

        public virtual Corp Corp { get; set; } = null!;
        public virtual ICollection<ContactForm> ContactForm { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
