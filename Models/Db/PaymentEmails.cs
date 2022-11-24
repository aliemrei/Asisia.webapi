using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class PaymentEmails : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid? Corpid { get; set; }
        public Guid? Projectid { get; set; }
        public string? ToEmails { get; set; }
        public string? CcEmails { get; set; }
        public string? BccEmails { get; set; }
        public Guid? Hotelid { get; set; }
        public Guid? ProjectDetailid { get; set; }
        public string? SuccessText { get; set; }
        public string? FailText { get; set; }

        public virtual Corp? Corp { get; set; }
        public virtual ProjectGroup? Project { get; set; }
        public virtual ProjectGroupdetail? ProjectDetail { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
