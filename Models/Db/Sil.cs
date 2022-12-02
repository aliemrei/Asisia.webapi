using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    [Table("SIL")]
    public partial class Sil : EntityBase // My Handlebars Helper
    {
        [Column("name")]
        [StringLength(20)]
        [Unicode(false)]
        public string? Name { get; set; }
        [Column("dial_code")]
        [StringLength(20)]
        [Unicode(false)]
        public string? DialCode { get; set; }
        [Column("code")]
        [StringLength(20)]
        [Unicode(false)]
        public string? Code { get; set; }
        [Column("ID")]
        public Guid? Id { get; set; }
        [Column("ISOCODE2")]
        [StringLength(2)]
        [Unicode(false)]
        public string? Isocode2 { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
