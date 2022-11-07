using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class MAIL_CONTENTS : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public int MAILID { get; set; }
        public string? CONTENT { get; set; }
        public Guid? MAILUID { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
