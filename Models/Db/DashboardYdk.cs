using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Keyless]
    [Table("DASHBOARD_YDK")]
    public partial class DashboardYdk : EntityBase // My Handlebars Helper
    {
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("DESIGN")]
        public string? Design { get; set; }
        [Column("TITLE")]
        [StringLength(50)]
        public string? Title { get; set; }
        [Column("MAXCOLUMN")]
        public int Maxcolumn { get; set; }
        [Column("STATEID")]
        [StringLength(50)]
        public string? Stateid { get; set; }
        [Column("COLUMNWIDTHS")]
        [StringLength(50)]
        public string Columnwidths { get; set; } = null!;
        [Column("SORTORDER")]
        public int Sortorder { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
