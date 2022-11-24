using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class VwProjectGroup : EntityBase // My Handlebars Helper
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public Guid? Corpid { get; set; }
        public bool Mergeclients { get; set; }
        public bool Usealternates { get; set; }
        public bool Isdeleted { get; set; }
        public bool Isdisabled { get; set; }
        public Guid Adduser { get; set; }
        public DateTime Adddate { get; set; }
        public Guid? Edituser { get; set; }
        public DateTime? Editdate { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
