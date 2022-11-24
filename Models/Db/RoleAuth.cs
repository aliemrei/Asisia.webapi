using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class RoleAuth : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public Guid Roleid { get; set; }
        public string Modulename { get; set; } = null!;
        public bool Canlist { get; set; }
        public bool Canadd { get; set; }
        public bool Canedit { get; set; }
        public bool Canview { get; set; }
        public bool Candelete { get; set; }
        public bool Canprint { get; set; }
        public bool Canexport { get; set; }

        public virtual Roles Role { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
