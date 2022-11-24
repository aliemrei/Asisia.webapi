using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class VirtualPosbinnames : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public Guid Posid { get; set; }
        public string BinnumberName { get; set; } = null!;

        public virtual VirtualPos Pos { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
