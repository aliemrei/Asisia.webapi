using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    public partial class VwProjectGroup : EntityBase // My Handlebars Helper
    {
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("NAME")]
        [StringLength(150)]
        public string Name { get; set; } = null!;
        [Column("CORPID")]
        public Guid? Corpid { get; set; }
        [Column("MERGECLIENTS")]
        public bool Mergeclients { get; set; }
        [Column("USEALTERNATES")]
        public bool Usealternates { get; set; }
        [Column("ISDELETED")]
        public bool Isdeleted { get; set; }
        [Column("ISDISABLED")]
        public bool Isdisabled { get; set; }
        [Column("ADDUSER")]
        public Guid Adduser { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Column("EDITUSER")]
        public Guid? Edituser { get; set; }
        [Column("EDITDATE", TypeName = "datetime")]
        public DateTime? Editdate { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
