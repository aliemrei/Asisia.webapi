using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class SntDiagramShapes : EntityBase // My Handlebars Helper
    {
        [Column("diagramKey")]
        public Guid DiagramKey { get; set; }
        [Column("dataKey")]
        public Guid DataKey { get; set; }
        [Column("key")]
        [StringLength(15)]
        [Unicode(false)]
        public string Key { get; set; } = null!;
        [Column("locked")]
        public bool Locked { get; set; }
        [Column("zIndex")]
        public int ZIndex { get; set; }
        [Column("type")]
        [StringLength(200)]
        public string Type { get; set; } = null!;
        [Column("text")]
        [StringLength(254)]
        public string Text { get; set; } = null!;
        [Column("x")]
        public int? X { get; set; }
        [Column("y")]
        public int? Y { get; set; }
        [Column("width")]
        public int? Width { get; set; }
        [Column("height")]
        public int? Height { get; set; }
        [Column("Head_ID")]
        public Guid? HeadId { get; set; }
        [Column("targetContainerId")]
        public Guid? TargetContainerId { get; set; }
        [Column("targetId")]
        public Guid? TargetId { get; set; }
        [Column("sortIndex")]
        public int? SortIndex { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
