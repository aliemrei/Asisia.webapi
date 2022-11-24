using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class BasketData : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public Guid? Requestid { get; set; }
        public string? Data { get; set; }

        public virtual Request? Request { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
