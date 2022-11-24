using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class MailContents : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public int Mailid { get; set; }
        public string? Content { get; set; }
        public Guid? Mailuid { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
