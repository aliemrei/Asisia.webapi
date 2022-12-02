using System;
using System.Collections.Generic; // Comment
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Asisia.webapi.Models.Db
{ // Comment
    [Table("RESERVATION_RULES")]
    [Index(nameof(ProjectDetailid), Name = "UQ__RESERVAT__2639F4EA0E443A89", IsUnique = true)]
    public partial class ReservationRules : EntityBase // My Handlebars Helper
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("PROJECT_DETAILID")]
        public Guid? ProjectDetailid { get; set; }
        [Column("REFUND_RULES", TypeName = "ntext")]
        public string? RefundRules { get; set; }
        [Column("GENERAL_RULES", TypeName = "ntext")]
        public string? GeneralRules { get; set; }

        [ForeignKey(nameof(ProjectDetailid))]
        [InverseProperty(nameof(ProjectGroupdetail.ReservationRules))]
        public virtual ProjectGroupdetail? ProjectDetail { get; set; }

        // My Handlebars Block Helper: True
        // My Handlebars Block Helper: False
    }
}
