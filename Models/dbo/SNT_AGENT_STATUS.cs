using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class SNT_AGENT_STATUS : EntityBase // My Handlebars Helper
    {
        public int ID { get; set; }
        public string AGENTNAME { get; set; } = null!;
        public string STATU { get; set; } = null!;
        public bool ISBREAK { get; set; }
        public DateTime STARTTIME { get; set; }
        public DateTime? ENDTIME { get; set; }
        public int? STATUID { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
