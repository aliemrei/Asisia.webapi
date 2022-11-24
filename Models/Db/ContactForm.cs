using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class ContactForm : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid? Personid { get; set; }
        public string? Title { get; set; }
        public Guid? Category { get; set; }
        public string? Messagetext { get; set; }
        public Guid Corpid { get; set; }
        public DateTime Adddate { get; set; }
        public Guid Adduser { get; set; }
        public DateTime? Editdate { get; set; }
        public Guid? Edituser { get; set; }

        public virtual Users AdduserNavigation { get; set; } = null!;
        public virtual ContactCategory? CategoryNavigation { get; set; }
        public virtual Corp Corp { get; set; } = null!;
        public virtual Users? EdituserNavigation { get; set; }
        public virtual Person? Person { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
