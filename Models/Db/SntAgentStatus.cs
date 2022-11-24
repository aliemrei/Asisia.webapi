using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class SntAgentStatus : EntityBase // My Handlebars Helper
    {
        public int Id { get; set; }
        public string Agentname { get; set; } = null!;
        public string Statu { get; set; } = null!;
        public bool Isbreak { get; set; }
        public DateTime Starttime { get; set; }
        public DateTime? Endtime { get; set; }
        public int? Statuid { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
