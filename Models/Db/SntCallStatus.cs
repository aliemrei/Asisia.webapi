using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class SntCallStatus : EntityBase // My Handlebars Helper
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(25)]
        public string Description { get; set; } = null!;
        [Column("ISFINISHED")]
        public bool Isfinished { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
