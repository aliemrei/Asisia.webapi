using System;
using System.Collections.Generic; // Comment

namespace Asisia.webapi.Models.Db
{ // Comment
    public partial class SntDiagramShapes : EntityBase // My Handlebars Helper
    {
        public Guid DiagramKey { get; set; }
        public Guid DataKey { get; set; }
        public string Key { get; set; } = null!;
        public bool Locked { get; set; }
        public int ZIndex { get; set; }
        public string Type { get; set; } = null!;
        public string Text { get; set; } = null!;
        public int? X { get; set; }
        public int? Y { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public Guid? HeadId { get; set; }
        public Guid? TargetContainerId { get; set; }
        public Guid? TargetId { get; set; }
        public int? SortIndex { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
