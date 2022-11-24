using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class ReservationRules : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid? ProjectDetailid { get; set; }
        public string? RefundRules { get; set; }
        public string? GeneralRules { get; set; }

        public virtual ProjectGroupdetail? ProjectDetail { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
