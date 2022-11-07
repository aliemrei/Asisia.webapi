using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.dbo
{ // Comment
    public partial class SNT_DIAGRAM_SHAPES : EntityBase // My Handlebars Helper
    {
        public Guid diagramKey { get; set; }
        public Guid dataKey { get; set; }
        public string key { get; set; } = null!;
        public bool locked { get; set; }
        public int zIndex { get; set; }
        public string type { get; set; } = null!;
        public string text { get; set; } = null!;
        public int? x { get; set; }
        public int? y { get; set; }
        public int? width { get; set; }
        public int? height { get; set; }
        public Guid? Head_ID { get; set; }
        public Guid? targetContainerId { get; set; }
        public Guid? targetId { get; set; }
        public int? sortIndex { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
