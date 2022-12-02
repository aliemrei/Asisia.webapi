using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("DASHBOARD_ITEM")]
    public partial class DashboardItem : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("DASHBOARDID")]
        public Guid Dashboardid { get; set; }
        [Column("QSQL")]
        public string? Qsql { get; set; }
        [Column("DESIGN")]
        public string? Design { get; set; }
        [Column("TITLE")]
        [StringLength(50)]
        public string? Title { get; set; }
        [Column("WIDGETNAME")]
        [StringLength(50)]
        public string Widgetname { get; set; } = null!;
        [Column("COLUMNINDEX")]
        public int Columnindex { get; set; }
        [Column("DETAIL_SQL")]
        public string? DetailSql { get; set; }
        [Column("SORTORDER")]
        public int Sortorder { get; set; }

        [ForeignKey(nameof(Dashboardid))]
        [InverseProperty("DashboardItem")]
        public virtual Dashboard Dashboard { get; set; } = null!;

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
