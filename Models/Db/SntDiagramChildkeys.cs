using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class SntDiagramChildkeys : EntityBase 
    {
        [Column("key")]
        [StringLength(15)]
        [Unicode(false)]
        [RequiredIf]
        public string Key { get; set; } = null!;


        [Column("dataKey")]
        [RequiredIf]
        public Guid DataKey { get; set; }



            }
}
