using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class SntDiagramShapes : EntityBase 
    {
        [Column("diagramKey")]
        [RequiredIf]
        public Guid DiagramKey { get; set; }


        [Column("dataKey")]
        [RequiredIf]
        public Guid DataKey { get; set; }


        [Column("key")]
        [StringLength(15)]
        [Unicode(false)]
        [RequiredIf]
        public string Key { get; set; } = null!;


        [Column("locked")]
        [RequiredIf]
        public bool Locked { get; set; }


        [Column("zIndex")]
        [RequiredIf]
        public int ZIndex { get; set; }


        [Column("type")]
        [StringLength(200)]
        [RequiredIf]
        public string Type { get; set; } = null!;


        [Column("text")]
        [StringLength(254)]
        [RequiredIf]
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



            }
}
