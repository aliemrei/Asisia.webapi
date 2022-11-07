using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class ROLE_AUTH : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public Guid ROLEID { get; set; }
        public string MODULENAME { get; set; } = null!;
        public bool CANLIST { get; set; }
        public bool CANADD { get; set; }
        public bool CANEDIT { get; set; }
        public bool CANVIEW { get; set; }
        public bool CANDELETE { get; set; }
        public bool CANPRINT { get; set; }
        public bool CANEXPORT { get; set; }

        public virtual ROLES ROLE { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
