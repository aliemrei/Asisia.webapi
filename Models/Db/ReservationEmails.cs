using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class ReservationEmails : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid? Corpid { get; set; }
        public Guid? ProjectDetailid { get; set; }
        public Guid? Productid { get; set; }
        public string? ToEmails { get; set; }
        public string? CcEmails { get; set; }
        public string? BccEmails { get; set; }

        public virtual Corp? Corp { get; set; }
        public virtual ProjectGroupdetail? ProjectDetail { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
