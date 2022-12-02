using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    [Table("VIRTUAL_POSBINNAMES")]
    public partial class VirtualPosbinnames : EntityBase // My Handlebars Helper
    {
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("POSID")]
        public Guid Posid { get; set; }
        [Column("BINNUMBER_NAME")]
        [StringLength(50)]
        public string BinnumberName { get; set; } = null!;

        [ForeignKey(nameof(Posid))]
        public virtual VirtualPos Pos { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
